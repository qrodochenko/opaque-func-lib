using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestingSystem
{
    /// <summary>
    /// Класс, представляющий образцовый метод, выражение для которого находится в атрибуте FunctionName
    /// </summary>
    public class IdealTestMethod
    {
        /// <summary>
        /// Скрипт, хранящий код и компиляцию образцового метода
        /// </summary>
        Script<double> Script;
        /// <summary>
        /// Тип образцового метода, должен совпадать с типом тестируемого метода
        /// </summary>
        public MethodType Type;

        /// <summary>
        /// Название для всех образцовых методов
        /// </summary>
        public const string Name = "_ideal";
        /// <summary>
        /// Возвращаемый тип для всех образцовых методов
        /// </summary>
        public const string ReturnType = "double";

        /// <summary>
        /// Словарь замен в образцовых выражениях
        /// </summary>
        public static Dictionary<string, string> IdentifierDic = new Dictionary<string, string>()
        {
            {"LN", "Log" }, { "LOG","Log10"}, {"POW", "Pow" }, { "SQR", "Sqr"}, {"SQRT", "Sqrt" },

            { "SIN", "Sin" }, {"COS", "Cos" }, {"TAN",  "Tan"}, { "TG", "Tan"},
            { "CTG", "Ctg" }, {"SEC", "Sec" }, {"COSEC",  "Cosec"}, { "CSC", "Cosec"},

            {"SH", "Sinh" }, {"CH","Cosh" }, {"TANH", "Tanh" },  {"TH", "Tanh" },
            {"CTH", "Cth" }, {"CSCH","Csch" }, {"SECH", "Sech" },  {"CTANH", "Cth" },

            { "ASIN", "Asin" }, {"ACOS", "Acos" }, {"ATAN",  "Atan"}, { "ATG", "Atan"},
            { "ARCSIN", "Asin" }, {"ARCCOS", "Acos" }, {"ARCTAN",  "Atan"}, { "ARCTG", "Atan"},
            { "ARCSEC", "Arcsec" }, {"ARCCOSEC", "Arccosec" }, {"ARCCTG",  "Arcctg"}, { "ARCCSC", "Arccosec"},

            { "ARCSINH", "Arsh" }, {"ARCCOSH", "Arch" }, {"ARCTANH",  "Arth"},
            { "ARCSECH", "Arsech" }, {"ARCCOSECH", "Arcsch" }, {"ARCCTGH",  "Arcth"},
            { "ARSH", "Arsh" }, {"ARCH", "Arch" }, {"ARTH",  "Arth"},
            { "ARSECH", "Arsech" }, {"ARCSCH", "Arcsch" }, {"ARCTH",  "Arcth"},

            {"X", "args[0]" }, {"Y", "args[1]" }, {"Z", "args[2]" },
            { "A", "param[0]" }, {"B", "param[1]" }, {"C", "param[2]" }, {"D", "param[3]" }, {"E", "param[4]" }
        };

        /// <summary>
        /// По математическому выражению и типу (тестируемого метода) конструирует новый экземпляр IdealTestMethod
        /// </summary>
        /// <param name="idealExpression">Второй параметр атрибута FunctionName</param>
        /// <param name="type">Тип тестируемого метода</param>
        public IdealTestMethod(string idealExpression, MethodType type)
        {
            // Тип тестируемого и идеального метода совпадают
            Type = type;
            // Убираем выражения типа "f(x,y) = ..."
            var eqPos = idealExpression.LastIndexOf('=');
            if (eqPos != -1)
                idealExpression = idealExpression.Substring(eqPos + 1);

            // Добавляем список аргументов и парсим выражение как метод.
            var parsed = CSharpSyntaxTree.ParseText(ReturnType + " " + Name + TestingUtilities.GenerateArguments(Type, false, true, 0) +
                                            "{ return " +
                                            idealExpression +
                                            "; }")
                                            .GetRoot().ChildNodes().OfType<MethodDeclarationSyntax>().First();

            // Добавляе перед всеми числами, перед которыми ещё нет приведения типов,
            // приведение к (double)
            while (true)
            {
                var numbers = parsed.DescendantNodes().OfType<LiteralExpressionSyntax>();
                bool notFound = true;
                foreach (var id in numbers)
                {
                    if (id.Kind() != SyntaxKind.NumericLiteralExpression
                        || id.Parent.Kind() == SyntaxKind.CastExpression)
                        continue;
                    notFound = false;
                    var txt = "(double)" + id.Token.ValueText;
                    parsed = parsed.ReplaceNode(id, SyntaxFactory.ParseExpression(txt));
                    break;
                }
                if (notFound) break;
            }

            // Заменяем все идентификаторы, указанные в словаре
            while (true)
            {
                var identifiers = parsed.DescendantNodes().OfType<IdentifierNameSyntax>();
                bool notFound = true;
                foreach (var id in identifiers)
                {
                    var idTextNCh = id.Identifier.ValueText.Trim();
                    var idText = idTextNCh.ToUpper();
                    if (!IdentifierDic.ContainsKey(idText) || IdentifierDic.ContainsValue(idTextNCh)) continue;
                    var dicText = IdentifierDic[idText];

                    if (dicText != idTextNCh)
                    {
                        parsed = parsed.ReplaceNode(id, SyntaxFactory.ParseExpression(dicText));
                        notFound = false;
                        break;
                    }
                }
                if (notFound) break;
            }

            // Заменям запись вида x^(double)1/(double)2 на Pow(x, (double)1/(double)2)
            while (true)
            {
                var binExprs = parsed.DescendantNodes().OfType<BinaryExpressionSyntax>();
                bool notFound = true;
                foreach (var id in binExprs)
                {
                    if (id.Kind() != SyntaxKind.ExclusiveOrExpression)
                        continue;
                    notFound = false;
                    var txt = "Pow(" + id.Left.GetText() + ", " + id.Right.GetText() + ")";
                    parsed = parsed.ReplaceNode(id, SyntaxFactory.ParseExpression(txt));
                    break;
                }
                if (notFound) break;
            }

            // Получаем строку для скрипта
            var EvalExpression = "using System; using TestingSystem;\n" + parsed.GetText().ToString() +
                "\nreturn " + parsed.Identifier.ValueText +
                TestingUtilities.GenerateArguments(Type, false, false, 0, true) + ";";
#if DEBUG
            Console.WriteLine(EvalExpression);
#endif
            //Создаём и компилируем скрипт
            Script = CSharpScript.Create<double>(
                EvalExpression,
                ScriptOptions.Default.WithReferences(typeof(ExtendedMath).Assembly)
                                        .WithImports("System.Math", "TestingSystem.ExtendedMath"),
                typeof(IdealMethodArgs));
            Script.Compile();
        }

        /// <summary>
        /// Выполняет метод на заданных аргументах/параметрах
        /// </summary>
        /// <param name="args">Структура, содержащая аргументы и параметры метода</param>
        /// <returns></returns>
        public double Evaluate(IdealMethodArgs args)
        {
            return Script.RunAsync(args).Result.ReturnValue;
        }
    }

    /// <summary>
    /// Основной класс, представляющий тестируемый метод. 
    /// Также предоставляет сравнение с образцом
    /// </summary>
    public class MethodForTesting
    {
        /// <summary>
        /// Пространства имён, используемые тестируемым методом
        /// </summary>
        public static string Usings = "using System; \n";
        
        /// <summary>
        /// Код тестируемого метода, хранится всегда с моента создания
        /// </summary>
        public string Code;
        
        /// <summary>
        /// Код метода с добавленным вызовом этого метода в правильной форме 
        /// </summary>
        public string EvalCode;
        
        /// <summary>
        /// Код образцового метода (второй аргумент FunctionName)
        /// </summary>
        public string IdealCode;
        
        /// <summary>
        /// Название тестируемого метода
        /// </summary>
        public string Name;

        /// <summary>
        /// Объект, представляющий образцовый метод. Создаётся только при вызове CompileScript()
        /// </summary>
        public IdealTestMethod IdealMethod;

        /// <summary>
        /// Узел синтаксического дерева, представляющий данный метод
        /// </summary>
        public MethodDeclarationSyntax Node;

        /// <summary>
        /// Тип метода
        /// </summary>
        public MethodType Type;

        /// <summary>
        /// Путь к файлу, в котором находится код данного метода
        /// </summary>
        public string FilePath;

        /// <summary>
        /// Скрипт, служащий для выполнения данного метода.
        /// Компиляция только при вызове CompileScrpt()
        /// </summary>
        public Script<double> Script;

        /// <summary>
        /// Указывает, корректно ли скомпилированы тестируемый и образцовый метод
        /// </summary>
        public bool Correct;

        /// <summary>
        /// Интервальный метод
        /// </summary>
        public IntervalMethod IntervalMethod;

        /// <summary>
        /// Определения необходимых классов из кода
        /// </summary>
        public string ClassesDeclarations;

        /// <summary>
        /// Конструктор без параметров, только выделяет память
        /// </summary>
        public MethodForTesting()
        {

        }

        /// <summary>
        /// Конструктор-копировщик, переносит все данные о методе
        /// </summary>
        /// <param name="m">Копируемый метод</param>
        public MethodForTesting(MethodForTesting m)
        {
            Code = m.Code;
            Script = m.Script;
            IdealMethod = m.IdealMethod;
            FilePath = m.FilePath;
            Name = m.Name;
            Node = m.Node;
            Type = m.Type;
            Correct = m.Correct;
            EvalCode = m.EvalCode;
            IdealCode = m.IdealCode;
            IntervalMethod = m.IntervalMethod;
            ClassesDeclarations = m.ClassesDeclarations;
        }

        /// <summary>
        /// Находит в указанном файле метод с указанным именем и создаёт соответствующий объект
        /// </summary>
        /// <param name="FilePath">Путь к файлу</param>
        /// <param name="MethodName">Имя тестируемого метода</param>
        public MethodForTesting(string FilePath, string MethodName) :
            this(getMethodsFromFiles(new string[] { FilePath }, new string[] { MethodName }, methodTypeDetection: true)[0])
        {

        }


        /// <summary>
        /// Пытается скомпилировать тестируемый метод, а также образцовый метод.
        /// Если удалось скомпилировать тестируемый метод, возвращает true, иначе false
        /// Если удалось скомпилировать и тестируемый, и образцовый метод, значение Correct устанавливается в true,
        /// иначе в false.
        /// </summary>
        /// <returns></returns>
        public bool CompileScript()
        {
            
            Correct = true;
            var opts = ScriptOptions.Default;
            opts = opts.AddImports("System");
            opts = opts.AddImports("System.Math");
            try
            {
                Script = CSharpScript.Create<double>(EvalCode, opts, typeof(IterMethodArgs));
                Script.Compile();
            }
            catch
            {
                Correct = false;
            }


            if (IdealCode == null) return false;

            try
            {
                IdealMethod = new IdealTestMethod(IdealCode, Type);
            }
            catch
#if DEBUG
            (Exception e)
#endif
            {
#if DEBUG
                Console.WriteLine("Ideal test method: " + Name + " " + FilePath + " " + e.Message);
#endif
                return false;
            }

            return true;
        }

        /// <summary>
        /// Выполняет скомпилированный скрипт тестируемого метода с предоставленными аргументами и параметрами
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public double Evaluate(IterMethodArgs args)
        {
            return Script.RunAsync(args).Result.ReturnValue;
        }

        /// <summary>
        /// Максимальная абсолютная погрешность при сравнении с образцовым методом
        /// </summary>
        /// <param name="N">Количество итераций</param>
        /// <param name="PointsNumber">Количество точек области сходимости для тестирования</param>
        /// <param name="parameters">Параметры функции</param>
        /// <param name="reportingFunc">Используемая для составления отчёта функция</param>
        /// <returns></returns>
        public double GetMaxEpsilonAbs(
            int N, int PointsNumber, double[] parameters = null,
            Func<int, int, double[], Report> reportingFunc = null)
        {
            reportingFunc = reportingFunc ?? GetTestingReport;
            return reportingFunc(N, PointsNumber, parameters).maxEpsilonAbsolute();
        }

        /// <summary>
        /// Максимальная относительная погрешность при сравнении с образцовым методом
        /// </summary>
        /// <param name="N">Количество итераций</param>
        /// <param name="PointsNumber">Количество точек области сходимости для тестирования</param>
        /// <param name="parameters">Параметры функции</param>
        /// <param name="reportingFunc">Используемая для составления отчёта функция</param>
        /// <returns></returns>
        public double GetMaxEpsilonRel(
            int N, int PointsNumber, double[] parameters = null,
            Func<int, int, double[], Report> reportingFunc = null)
        {
            reportingFunc = reportingFunc ?? GetTestingReport;
            return reportingFunc(N, PointsNumber, parameters).maxEpsilonRelative();
        }

        /// <summary>
        /// Получает необходимое количество итераций по требуемой погрешности - относительной или абсолютной
        /// </summary>
        /// <param name="epsilon">Значение погрешности</param>
        /// <param name="pointsNumber">Количество точек, на которых проводится измерение погрешности</param>
        /// <param name="functionParameters">Параметры функции</param>
        /// <param name="epsType">Тип погрешности - относительная или абсолютная</param>
        /// <param name="reportingFunc">Используемая для составления отчёта функция</param>
        /// <returns></returns>
        public int GetIterationsByEpsilon(
            double epsilon,
            int pointsNumber,
            double[] functionParameters = null,
            EpsilonType epsType = EpsilonType.RELATIVE,
            Func<int, int, double[], Report> reportingFunc = null)
        {
            reportingFunc = reportingFunc ?? GetTestingReport;
            return TestingUtilities.GetIterationsByEpsilon(this, epsilon, pointsNumber, 
                functionParameters: functionParameters, 
                epsType:epsType, 
                reportingFunction:reportingFunc);
        }

        /// <summary>
        /// Возвращает отчёт сопоставления данной функции с образцовой
        /// </summary>
        /// <param name="N">Количество итераций для тестируемой функции</param>
        /// <param name="PointsNumber">Число точек, на которых производится тестирование</param>
        /// <param name="parameters">Параметры для функции</param>
        /// <returns></returns>
        public Report GetTestingReport(int N, int PointsNumber, double[] parameters = null)
        {
            parameters = parameters ?? new double[0];
            return TestingUtilities.GetReport(N, PointsNumber, parameters,
                Type, Name, FilePath, IntervalMethod.GetConvergencyRegion(parameters),
                TestingUtilities.GenerateStructures,
                (ideal, iter, pt) => ideal.args = iter.args = pt.coords,
                (ideal, iter) => Tuple.Create(Evaluate(iter), IdealMethod.Evaluate(ideal)));
        }

        /// <summary>
        /// Searches for all the ideal expression and returns map (funcname) => (expr)
        /// </summary>
        /// <param name="TreeRoot">The root of the tree to search for expression attributes</param>
        /// <returns></returns>
        public static Dictionary<string, string> getExpressionsFromAttributes(SyntaxNode TreeRoot)
        {
            var dic = new Dictionary<string, string>();
            var attribs = TreeRoot.DescendantNodes().OfType<AttributeSyntax>();
            foreach (var attr in attribs)
            {
                if (attr.Name.GetText().ToString() == "FunctionName")
                {
                    var attrArgs = attr.ArgumentList.Arguments;
                    dic[attrArgs.ElementAt(0).GetFirstToken().ValueText] = attrArgs.ElementAt(1).GetFirstToken().ValueText;
                }
            }

            return dic;
        }

        /// <summary>
        /// Searches for interval methods, executes them, and returns the intervals in dictionary form
        /// </summary>
        /// <param name="TreeRoot">The root of the tree to search for interval methods</param>
        /// <returns></returns>
        public static Dictionary<string, MethodDeclarationSyntax> getIntervalMethCodes(SyntaxNode TreeRoot)
        {
            var dic = new Dictionary<string, MethodDeclarationSyntax>();
            var methods = TreeRoot.DescendantNodes().OfType<MethodDeclarationSyntax>();
            foreach (var meth in methods)
            {
                string inMethName = meth.Identifier.ValueText;
                if (!inMethName.EndsWith("_in")) continue;
                string methodName = inMethName.Substring(0, inMethName.Length - 3);
                try
                {
                    dic[methodName] = meth;
                }
                catch
                {
                    continue;
                }
            }

            return dic;
        }

        /// <summary>
        /// Searches for classes, and returns them in dictionary form
        /// </summary>
        /// <param name="TreeRoot">The root of the tree to search for classes</param>
        /// <returns></returns>
        public static Dictionary<string, string> getClassCodes(SyntaxNode TreeRoot)
        {
            var dic = new Dictionary<string, string>();
            var classes = TreeRoot.DescendantNodes().OfType<ClassDeclarationSyntax>();
            foreach (var cl in classes)
            {
                dic[cl.Identifier.Text] = cl.RemoveNodes(cl.DescendantNodes().
                    OfType<AttributeListSyntax>(), SyntaxRemoveOptions.KeepNoTrivia).GetText().ToString();
            }

            return dic;
        }

        /// <summary>
        /// Определяет тип метода по сигнатуре
        /// </summary>
        /// <param name="meth">Узел ситаксического дерева, представляющий данный метод</param>
        /// <remarks>
        /// Если тип возвращаемого значения - не double, тип не определяется.
        /// Последний аргумент должен быть типа int.
        /// Все остальные аргументы - типа double, причём должным образом поименованы.
        /// </remarks>
        /// <returns></returns>
        public static MethodType DetectType(MethodDeclarationSyntax meth)
        {
#if DEBUG
            Console.WriteLine(meth.ReturnType.GetText());
#endif
            if (meth.ReturnType.GetText().ToString().Trim() != "double") return MethodType.NOT_DETECTED;
            var argsSynt = meth.ParameterList.ChildNodes().OfType<ParameterSyntax>();
            var argsL = argsSynt.Select((elem) => elem.Identifier.ValueText.ToUpper());
            var args = argsL.ToArray();
            var possibleArgs = new string[] { "X", "Y", "Z" };
            var possibleParams = new string[] { "A", "B", "C", "D", "E", "F" };

            if (argsSynt.Count() < 2 || argsSynt.Last().Type.GetText().ToString().Trim() != "int") return MethodType.NOT_DETECTED;
            if (argsSynt.Count() == 2 && argsSynt.First().Type.GetText().ToString().Trim() == "double") return MethodType.X;

            int argnum = 0, parnum = 0;
            for (; argnum < possibleArgs.Length && argnum < args.Length && possibleArgs[argnum] == args[argnum]; ++argnum) ;
            for (; parnum < possibleParams.Length && (parnum + argnum) < args.Length && possibleParams[parnum] == args[argnum + parnum]; ++parnum) ;
            if (argnum == 0 || (argnum + parnum + 1) != args.Length) return MethodType.NOT_DETECTED;
            return new MethodType(argnum, parnum);
        }

        /// <summary>
        /// Получает методы для тестирования из указанных файлов
        /// </summary>
        /// <param name="FileNames">Список файлов исходного кода, в которых осуществляется поиск</param>
        /// <param name="MethodNames">Имена методов, включаемые, или исключаемы из поиска (см. <paramref name="exclude"/>)</param>
        /// <param name="exclude">Если true, <paramref name="MethodNames"/> исключаются из поиска, иначе включаются</param>
        /// <param name="methodTypeDetection">Если true, самостоятельно пытается определить тип методов</param>
        /// <param name="MethodTypes">Словарь типов методов - указывается при необходимости, если методы имют нестандартную сигнатуру, не распознаваемую DetectType()</param>
        /// <returns></returns>
        public static List<MethodForTesting> getMethodsFromFiles(
            string[] FileNames,
            string[] MethodNames,
            bool exclude = false,
            bool methodTypeDetection = false,
            Dictionary<string, MethodType> MethodTypes = null)
        {
            MethodTypes = MethodTypes ?? new Dictionary<string, MethodType>();
#if DEBUG
            StreamWriter sw = new StreamWriter(OutputPath.GetMethodsFromFilesErrorsPath);
#endif
            List<MethodForTesting> reslist = new List<MethodForTesting>();
            foreach (var fname in FileNames)
            {
                var tree = CSharpSyntaxTree.ParseText(File.ReadAllText(fname));
                var rt = tree.GetRoot();
                var fileMethods = rt.DescendantNodes().OfType<MethodDeclarationSyntax>();
                var expressionsDic = getExpressionsFromAttributes(rt);
                var intervalsDic = getIntervalMethCodes(rt);
                var classesDic = getClassCodes(rt);

                foreach (var meth in fileMethods)
                {
                    string thisMethodName = meth.Identifier.Text;
                    if (!(MethodNames.Contains(thisMethodName) ^ exclude)) continue;

                    var t = MethodTypes.ContainsKey(thisMethodName) ? MethodTypes[thisMethodName] :
                        (methodTypeDetection ? DetectType(meth) : MethodType.X);
                    if (t == MethodType.NOT_DETECTED)
                    {
#if DEBUG
                        sw.WriteLine(thisMethodName + " " + fname + " " + " Not detected");
#endif
                        continue;
                    }

                    MethodForTesting m = null;

                    if (!intervalsDic.ContainsKey(thisMethodName)) continue;
                    var intervalMethod = intervalsDic[thisMethodName];

                    m = new MethodForTesting();
                    m.Name = thisMethodName;
                    m.FilePath = fname;
                    m.IntervalMethod = new IntervalMethod(intervalMethod);
#if DEBUG
                    Console.WriteLine(thisMethodName + " " + fname);
#endif
                    m.Type = t;
                    m.Code = meth.GetText().ToString();
                    m.Node = meth;

                    m.Correct = false;

                    m.ClassesDeclarations = "";
                    foreach(string className in meth.DescendantNodes().
                        OfType<MemberAccessExpressionSyntax>().
                        Select((acc) => acc.Expression.WithoutTrivia().GetText().ToString()))
                    {
                        if (classesDic.ContainsKey(className))
                        {
                            m.ClassesDeclarations += classesDic[className] + "\r\n";
                        }
                    }

                    m.EvalCode = Usings + m.ClassesDeclarations + m.Code + "\nreturn " +
                        m.Name + TestingUtilities.GenerateArguments(m.Type, true, false, 0) + ";\n";

                    if (expressionsDic.ContainsKey(m.Name))
                        m.IdealCode = expressionsDic[m.Name];
                    else
                        m.IdealCode = null;

                    reslist.Add(m);

                }
            }

#if DEBUG
            sw.Close();
            sw.Dispose();
#endif
            return reslist;
        }
    }

}