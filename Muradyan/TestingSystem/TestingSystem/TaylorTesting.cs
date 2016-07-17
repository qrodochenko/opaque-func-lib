using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestingSystem
{
    /// <summary>
    /// O(NlogN) -summator for ideal sum implementation
    /// </summary>
    public class Heap
    {
        /// <summary>
        /// Количество элементов в контейнере
        /// </summary>
        private int elnum = 0;
        /// <summary>
        /// Контейнер - динамическая таблица
        /// </summary>
        private List<double> ar = new List<double>();

        /// <summary>
        /// Сравнение на меньше по модулю
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>true, если |a| меньше |b|</returns>
        public static bool less(double a, double b)
        {
            return (Math.Abs(a) < Math.Abs(b));
        }

        /// <summary>
        /// Сравнение на больше по модулю
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>true, если |a| больше |b|</returns>
        public static bool more(double a, double b)
        {
            return (Math.Abs(a) > Math.Abs(b));
        }

        /// <summary>
        /// Сравнение на меньше или равно по модулю
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>true, если |a| меньше или равно |b|</returns>
        public static bool lesseq(double a, double b)
        {
            return (Math.Abs(a) <= Math.Abs(b));
        }

        /// <summary>
        /// Сравнение на больше или равно по модулю
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>true, если |a| больше или равно |b|</returns>
        public static bool moreeq(double a, double b)
        {
            return (Math.Abs(a) >= Math.Abs(b));
        }

        /// <summary>
        /// Сохраняет порядок кучи в структуре с порядком кучи, нарушенным лишь в вершине <paramref name="index"/>
        /// </summary>
        /// <param name="index">Номер элемента, в котором нарушен порядок кучи</param>
        private void Heapify(int index = 1)
        {
            int ind = index;
            int l = ind << 1;
            int r = l + 1;
            

            while (ind <= elnum && l <= elnum)
            {
                if (r > elnum)
                {
                    if (less(ar[l - 1], ar[ind - 1]))
                        Utility.SwapArr(ref ar, l - 1, ind - 1);
                    return;
                }
                else
                {
                    if (lesseq(ar[ind - 1], ar[r - 1]) && lesseq(ar[ind - 1], ar[l - 1]))
                        return;
                    if (less(ar[r - 1], ar[l - 1]))
                    {
                        Utility.SwapArr(ref ar, r - 1, ind - 1);
                        ind = r;
                        l = ind << 1;
                        r = l + 1;
                    }
                    else
                    {
                        Utility.SwapArr(ref ar, l - 1, ind - 1);
                        ind = l;
                        l = ind << 1;
                        r = l + 1;
                    }
                }
            }
        }

        /// <summary>
        /// Извлекает из кучи наименьший элемент (вершину кучи)
        /// </summary>
        /// <returns></returns>
        private double ExtractMin()
        {
            double m = ar[0];
            ar[0] = ar[--elnum];
            ar.RemoveAt(elnum);
            Heapify();
            return m;
        }


        /// <summary>
        /// Извлекает из кучи два минимальных элемента, и добавляет их сумму обратно в кучу
        /// </summary>
        private void AddTwoMin()
        {
            double m = ExtractMin();
            m += ExtractMin();
            //Console.WriteLine(m);
            elnum++;
            ar.Add(m);
            int cn = elnum;
            int p = cn >> 1;
            while (p > 0 && more(ar[p - 1], ar[cn - 1]))
            {
                Utility.SwapArr<double>(ref ar, p - 1, cn - 1);
                cn = p;
                p = p >> 1;
            }
        }

        /// <summary>
        /// Очищает кучу
        /// </summary>
        public void Clear()
        {
            ar.Clear();
            elnum = 0;
        }

        /// <summary>
        /// Вычисляет сумму элементов в куче.
        /// При этом сама куча редуцируется до одного элемента.
        /// Если элементов в куче не было, возвращает ноль.
        /// </summary>
        /// <returns></returns>
        public double Sum()
        {
            if (elnum == 0) return 0;
            for (int i = elnum >> 1; i >= 1; --i)
            {
                Heapify(i);
            }
            while (elnum > 1) AddTwoMin();
            return ar[0];
        }

        /// <summary>
        /// Изменяет массив-хранитель данной кучи
        /// </summary>
        /// <param name="a">Новый массив</param>
        public void ChangeArray(ref List<double> a)
        {
            ar = a;
            elnum = a.Count();
        }

        /// <summary>
        /// Добавляет элемент в конец массива.
        /// </summary>
        /// <remarks>
        /// Heapify не вызывается, однако Sum превращает любой массив в кучу
        /// Мы дилегируем ей эти полномочия, ибо всегда до суммирования выполняется только добавление,
        /// а после него - ничего
        /// </remarks>
        /// <param name="el"></param>
        public void AddElement(double el)
        {
            //Console.WriteLine(elnum);
            ar.Add(el);
            ++elnum;
        }

    }

    /// <summary>
    /// The extension of MethodForTesting for testing simple sum functions
    /// </summary>
    public class MethodForTestingTaylor : MethodForTesting
    {
        /// <summary>
        /// Namespaces which Taylor-testing uses
        /// </summary>
        public static new string Usings = "using System; \n using TestingSystem; \n";
        /// <summary>
        /// Name of addon-method
        /// </summary>
        public static string TaylorAddonName = "_TaylorAddon";
        /// <summary>
        /// Скрипт, тестирующий суммирование
        /// </summary>
        public Script<Tuple<double, double>> ScriptTaylor;

        /// <summary>
        /// Добавляет новую функциональность обычному экземпляру MethodForTesting (тест суммирования)
        /// </summary>
        /// <param name="meth">Объект, на основе которого конструируется расширение для проверки суммирования</param>
        public MethodForTestingTaylor(MethodForTesting meth) : base(meth)
        {
            var TaylorEvalCode = Usings +
                getChangedNode(Node).GetText().ToString() +
                constructTaylorAddon(Name, Type) +
                "return " + TaylorAddonName + TestingUtilities.generateArguments(Type, true, false, 0, true) + ";";

            var opts = ScriptOptions.Default;
            var mscorlib = typeof(object).Assembly;
            var testingEntry = typeof(Heap).Assembly;
            opts = opts.AddReferences(mscorlib, testingEntry);
            opts = opts.AddImports("System");
            opts = opts.AddImports("System.Math");
            opts = opts.AddImports("TestingSystem.Heap");

            Correct = true;
            try
            {
                ScriptTaylor = CSharpScript.Create<Tuple<double, double>>(TaylorEvalCode, opts, typeof(IterMethodArgs));
                ScriptTaylor.Compile();
            }
            catch (Exception)
            {
                Correct = false;
            }
        }

        /// <summary>
        /// Выполняет скрипт с данными аргументами
        /// </summary>
        /// <param name="args">Аргументы для скрипта</param>
        /// <returns>Пара (тестируемое значение, идеальное значение)</returns>
        public Tuple<double, double> EvaluateTaylor(IterMethodArgs args)
        {
            return ScriptTaylor.RunAsync(args).Result.ReturnValue;
        }

        /// <summary>
        /// Возвращает отчёт по проверке суммирования
        /// </summary>
        /// <param name="N">Число итераций</param>
        /// <param name="PointsNumber">Количество точек области сходимости для тестирования</param>
        /// <param name="parameters">Параметры метода</param>
        /// <returns></returns>
        public Report GetTestingReportTaylor(int N, int PointsNumber, double[] parameters = null)
        {
            return TestingUtilities.GetReport(N, PointsNumber, parameters,
                Type, Name, FilePath, Region,
                TestingUtilities.GenerateStructures,
                (ideal, iter, pt) => iter.args = pt.coords,
                (ideal, iter) => EvaluateTaylor(iter));
        }

        /// <summary>
        /// Максимальная абсолютная погрешность в проверке суммирования
        /// </summary>
        /// <param name="N">Количество итераций</param>
        /// <param name="PointsNumber">Количество точек области сходимости для тестирования</param>
        /// <param name="parameters">Параметры функции</param>
        /// <returns></returns>
        public double GetMaxEpsilonAbsTaylor(
            int N, int PointsNumber, double[] parameters = null)
        {
            return GetTestingReportTaylor(N, PointsNumber, parameters).maxEpsilonAbsolute();
        }

        /// <summary>
        /// Максимальная относительная погрешность в проверке суммирования
        /// </summary>
        /// <param name="N">Количество итераций</param>
        /// <param name="PointsNumber">Количество точек области сходимости для тестирования</param>
        /// <param name="parameters">Параметры функции</param>
        /// <returns></returns>
        public double GetMaxEpsilonRelTaylor(
            int N, int PointsNumber, double[] parameters = null)
        {
            return GetTestingReportTaylor(N, PointsNumber, parameters).maxEpsilonRelative();
        }

        /// <summary>
        /// Получает необходимое количество итераций по требуемой погрешности - относительной или абсолютной
        /// </summary>
        /// <param name="epsilon">Значение погрешности</param>
        /// <param name="pointsNumber">Количество точек, на которых проводится измерение погрешности</param>
        /// <param name="functionParameters">Параметры функции</param>
        /// <param name="epsType">Тип погрешности - относительная или абсолютная</param>
        /// <returns></returns>
        public int GetIterationsByEpsilonTaylor(
            double epsilon,
            int pointsNumber,
            double[] functionParameters = null,
            EpsilonType epsType = EpsilonType.RELATIVE)
        {
            return TestingUtilities.GetIterationsByEpsilon(
                this, 
                epsilon, 
                pointsNumber, 
                epsType, 
                functionParameters,
                GetTestingReportTaylor);
        }

        /// <summary>
        /// Changes the method node by adding the last parameter and new lines insted of ///add comments 
        /// </summary>
        /// <param name="method">Method node to change</param>
        /// <returns>Changed node</returns>
        public static MethodDeclarationSyntax getChangedNode(MethodDeclarationSyntax method)
        {
            var TestEntryArgName = "__tst";
            /* Adding last param */
            var parlist = method.ChildNodes().OfType<ParameterListSyntax>().First();
            var newparlist = parlist.AddParameters(SyntaxFactory.Parameter(
                                                                    SyntaxFactory.Identifier(TestEntryArgName))
                                                                                    .WithType(SyntaxFactory.ParseTypeName("Heap ")));
            var newmethod = method.ReplaceNode(parlist, newparlist);

            /* Adding __tst.AddElement(i); */
            while (true) {
                IEnumerable<SyntaxNode> desc;
                bool triviaFound;
                desc = newmethod.Body.DescendantNodes();
                triviaFound = false;
                foreach (var s in desc)
                {
                    SyntaxTrivia st = SyntaxFactory.SyntaxTrivia(SyntaxKind.WhitespaceTrivia, " ");
                    bool fl = false;
                    bool before = true;
                    var lt = s.GetLeadingTrivia();

                    foreach (var triviaEntry in lt)
                    {
                        if (triviaEntry.Kind() == SyntaxKind.SingleLineDocumentationCommentTrivia)
                        {
                            fl = true;
                            st = triviaEntry;
                            break;
                        }
                    }

                    if (!fl)
                    {
                        lt = s.GetTrailingTrivia();
                        before = false;
                        foreach (var triviaEntry in lt)
                        {
                            if (triviaEntry.Kind() == SyntaxKind.SingleLineDocumentationCommentTrivia)
                            {
                                fl = true;
                                st = triviaEntry;
                                break;
                            }
                        }
                        if (!fl) continue;
                    }
                    
                    var commentContents = st.ToString();
                    char[] delim = { ' ', '\n', '\t', '\r' };
                    var ar = commentContents.Split(delim, StringSplitOptions.RemoveEmptyEntries);
                    if (ar.Length != 2 || ar[0] != "add") continue;
                    
                    var lineToAdd = TestEntryArgName + ".AddElement(" + ar[1] + ")";
                    var linelist = new List<ExpressionStatementSyntax>();
                    linelist.Add(SyntaxFactory.ExpressionStatement(SyntaxFactory.ParseExpression(lineToAdd)));
                    
                    var childlist = s.Parent.ChildNodes();
                    
                    foreach (var si in childlist)
                    {
                        if (s != si) continue;
                        if (before) newmethod = newmethod.InsertNodesBefore(si, linelist);
                        else newmethod = newmethod.InsertNodesAfter(si, linelist);
                        break;
                    }

                    var newTrvias = newmethod.DescendantTrivia().Where((t) =>
                                    {
                                        if (t.Kind() != SyntaxKind.SingleLineDocumentationCommentTrivia)
                                            return false;
                                        var arr = t.ToString().Split(delim, StringSplitOptions.RemoveEmptyEntries);
                                        return arr.Length == 2 && arr[0] == "add";
                                    });

                    newmethod = newmethod.ReplaceTrivia(newTrvias.First(), SyntaxFactory.SyntaxTrivia(SyntaxKind.WhitespaceTrivia, " "));
                    triviaFound = true;
                    break;
                }
                if (!triviaFound) break;
            }
            return newmethod;
        }

        /// <summary>
        /// Constructs the code of method that calls modified testing method 
        /// and gives it a heap through the reference
        /// </summary>
        /// <param name="funName">Name of the function to call</param>
        /// <param name="Type">Type of the function <paramref name="funName"/></param>
        /// <returns></returns>
        public static string constructTaylorAddon(string funName, MethodType Type)
        {
            return @"Tuple<double, double> " + TaylorAddonName + @" " + TestingUtilities.generateArguments(Type, true, true, 0) + @"{
                        Heap tst1 = new Heap();
                        var v = " + funName + @" " + TestingUtilities.generateArguments(Type, true, false, 1) + @";
                        return Tuple.Create(v, tst1.Sum());
                    }";
        }

    }
}