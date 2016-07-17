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

    public class IdealTestMethod
    {
        Script<double> Script;
        public MethodType Type;

        public static string Name = "_ideal";
        public static string ReturnType = "double";
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


        public IdealTestMethod(string IdealExpression, MethodType type)
        {
            Type = type;
            var eqPos = IdealExpression.LastIndexOf('=');
            if (eqPos != -1)
                IdealExpression = IdealExpression.Substring(eqPos + 1);
            var parsed = CSharpSyntaxTree.ParseText(ReturnType + " " + Name + TestingUtilities.generateArguments(Type, false, true, 0) +
                                            "{ return " +
                                            IdealExpression +
                                            "; }")
                                            .GetRoot().ChildNodes().OfType<MethodDeclarationSyntax>().First();

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

            var EvalExpression = "using System; using TestingSystem;\n" + parsed.GetText().ToString() +
                "\nreturn " + parsed.Identifier.ValueText +
                TestingUtilities.generateArguments(Type, false, false, 0, true) + ";";
#if DEBUG
            Console.WriteLine(EvalExpression);
#endif
            Script = CSharpScript.Create<double>(
                EvalExpression,
                ScriptOptions.Default.WithReferences(typeof(ExtendedMath).Assembly)
                                        .WithImports("System.Math", "TestingSystem.ExtendedMath"),
                typeof(IdealMethodArgs));
            Script.Compile();
        }
        public double Evaluate(IdealMethodArgs args)
        {
            return Script.RunAsync(args).Result.ReturnValue;
        }
    }

    public class MethodForTesting
    {
        public static string Usings = "using System; \n";


        public string Code;
        public string EvalCode;
        public string IdealCode;
        public string Name;
        public IdealTestMethod IdealMethod;
        public MethodDeclarationSyntax Node;
        public MethodType Type;
        public string FilePath;
        public Script<double> Script;
        public bool Correct;
        public ConvergencyRegion Region;

        public MethodForTesting()
        {

        }

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
            Region = m.Region;
        }

        public MethodForTesting(string FilePath, string MethodName) :
            this(getMethodsFromFiles(new string[] { FilePath }, new string[] { MethodName }, methodTypeDetection: true)[0])
        {

        }


        public bool CompileScript()
        {
            if (IdealCode == null) return false;
            Correct = true;
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
                Correct = false;
            }


            var opts = ScriptOptions.Default;
            //var mscorlib = typeof(System.Object).Assembly;
            //opts = opts.AddReferences(mscorlib);
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
                return false;
            }
            return true;
        }

        //public class ArgsT{
        //  public double arg1;
        //  public int arg2; ...
        //}
        public double Evaluate(IterMethodArgs args)
        {
            return Script.RunAsync(args).Result.ReturnValue;
        }

        public double GetMaxEpsilonAbs(
            int N, int PointsNumber, double[] parameters = null,
            Func<int, int, double[], Report> reportingFunc = null)
        {
            reportingFunc = reportingFunc ?? GetTestingReport;
            return reportingFunc(N, PointsNumber, parameters).maxEpsilonAbsolute();
        }

        public double GetMaxEpsilonRel(
            int N, int PointsNumber, double[] parameters = null,
            Func<int, int, double[], Report> reportingFunc = null)
        {
            reportingFunc = reportingFunc ?? GetTestingReport;
            return reportingFunc(N, PointsNumber, parameters).maxEpsilonRelative();
        }

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

        public Report GetTestingReport(int N, int PointsNumber, double[] parameters = null)
        {
            return TestingUtilities.GetReport(N, PointsNumber, parameters,
                Type, Name, FilePath, Region,
                TestingUtilities.GenerateStructures,
                (ideal, iter, pt) => ideal.args = iter.args = pt.coords,
                (ideal, iter) => Tuple.Create(Evaluate(iter), IdealMethod.Evaluate(ideal)));
        }

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

        public static Dictionary<string, Interval[]> getIntervals(SyntaxNode TreeRoot)
        {
            var dic = new Dictionary<string, Interval[]>();
            var methods = TreeRoot.DescendantNodes().OfType<MethodDeclarationSyntax>();
            foreach (var meth in methods)
            {
                string inMethName = meth.Identifier.ValueText;
                if (!inMethName.EndsWith("_in")) continue;
                string methodName = inMethName.Substring(0, inMethName.Length - 3);
                try
                {
                    dic[methodName] = IntervalMethod.Evaluate(meth);
                }
                catch
                {
                    continue;
                }
            }

            return dic;
        }

        public static MethodType DetectType(MethodDeclarationSyntax meth)
        {
#if DEBUG
            Console.WriteLine(meth.ReturnType.GetText());
#endif
            if (meth.ReturnType.GetText().ToString().Trim() != "double") return null;
            var argsSynt = meth.ParameterList.ChildNodes().OfType<ParameterSyntax>();
            var argsL = argsSynt.Select((elem) => elem.Identifier.ValueText.ToUpper());
            var args = argsL.ToArray();
            var possibleArgs = new string[] { "X", "Y", "Z" };
            var possibleParams = new string[] { "A", "B", "C", "D", "E", "F" };

            if (argsSynt.Count() < 2 || argsSynt.Last().Type.GetText().ToString().Trim() != "int") return null;
            if (argsSynt.Count() == 2 && argsSynt.First().Type.GetText().ToString().Trim() == "double") return MethodType.X;

            int argnum = 0, parnum = 0;
            for (; argnum < possibleArgs.Length && argnum < args.Length && possibleArgs[argnum] == args[argnum]; ++argnum) ;
            for (; parnum < possibleParams.Length && (parnum + argnum) < args.Length && possibleParams[parnum] == args[argnum + parnum]; ++parnum) ;
            if (argnum == 0 || (argnum + parnum + 1) != args.Length) return null;
            return new MethodType(argnum, parnum);
        }

        public static List<MethodForTesting> getMethodsFromFiles(
            string[] FileNames,
            string[] MethodNames,
            bool exclude = false,
            bool methodTypeDetection = false,
            Dictionary<string, MethodType> MethodTypes = null)
        {
            MethodTypes = MethodTypes ?? new Dictionary<string, MethodType>();
#if DEBUG
            StreamWriter sw = new StreamWriter("gmffErrors.txt");
#endif
            List<MethodForTesting> reslist = new List<MethodForTesting>();
            foreach (var fname in FileNames)
            {
                var tree = CSharpSyntaxTree.ParseText(File.ReadAllText(fname));
                var rt = tree.GetRoot();
                var fileMethods = rt.DescendantNodes().OfType<MethodDeclarationSyntax>();
                var expressionsDic = getExpressionsFromAttributes(rt);
                var intervalsDic = getIntervals(rt);

                foreach (var meth in fileMethods)
                {
                    string thisMethodName = meth.Identifier.Text;
                    if (!(MethodNames.Contains(thisMethodName) ^ exclude)) continue;

                    var t = MethodTypes.ContainsKey(thisMethodName) ? MethodTypes[thisMethodName] :
                        (methodTypeDetection ? DetectType(meth) : MethodType.X);
                    if (t == null)
                    {
#if DEBUG
                        sw.WriteLine(thisMethodName + " " + fname + " " + " Not detected");
#endif
                        continue;
                    }

                    MethodForTesting m = null;

                    if (!intervalsDic.ContainsKey(thisMethodName)) continue;
                    var methIntervals = intervalsDic[thisMethodName];
                    if (methIntervals == null)
                    {

#if DEBUG
                        sw.WriteLine(thisMethodName + " " + fname + " " + " No intervals");
#endif
                        continue;
                    }

                    if (methIntervals.Length != t.argnum)
                    {

#if DEBUG
                        sw.WriteLine(thisMethodName + " " + fname + " " + " No correlation between args and intervals");
#endif
                        continue;
                    }

                    m = new MethodForTesting();

                    m.Name = thisMethodName;
                    m.FilePath = fname;
                    m.Region = new ConvergencyRegion(methIntervals);
#if DEBUG
                    Console.WriteLine(thisMethodName + " " + fname);
#endif
                    m.Type = t;
                    m.Code = meth.GetText().ToString();
                    m.Node = meth;

                    m.Correct = false;
                    m.EvalCode = Usings + m.Code + "\nreturn " +
                        m.Name + TestingUtilities.generateArguments(m.Type, true, false, 0) + ";\n";

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