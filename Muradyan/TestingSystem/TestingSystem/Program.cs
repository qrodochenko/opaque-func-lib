using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

//main namespace
namespace TestingSystem
{
    public enum MethodType
    {
        X, XY, XA, XYA, XAB, XYAB
    }

    public enum TestingApproach
    {
        UNIVERSAL, TAYLOR
    }

    namespace ArgsTypesIdeal
    {

        public class ArgsOneArg
        {
            public double x;
        }
        public class ArgsTwoArg
        {
            public double x, y;
        }
        public class ArgsX : ArgsOneArg
        {

        }
        public class ArgsXY : ArgsTwoArg
        {

        }
        public class ArgsXA : ArgsOneArg
        {
            public double a;
        }
        public class ArgsXYA : ArgsTwoArg
        {
            public double a;
        }
        public class ArgsXAB : ArgsOneArg
        {
            public double a, b;
        }
        public class ArgsXYAB : ArgsTwoArg
        {
            public double a, b;
        }
    }

    namespace ArgsTypesIterations
    {

        public class ArgsOneArg : ArgsTypesIdeal.ArgsOneArg
        {
            public int N;
        }
        public class ArgsTwoArg : ArgsTypesIdeal.ArgsTwoArg
        {
            public int N;
        }
        public class ArgsX : ArgsOneArg
        {

        }
        public class ArgsXY : ArgsTwoArg
        {

        }
        public class ArgsXA : ArgsOneArg
        {
            public double a;
        }
        public class ArgsXYA : ArgsTwoArg
        {
            public double a;
        }
        public class ArgsXAB : ArgsOneArg
        {
            public double a, b;
        }
        public class ArgsXYAB : ArgsTwoArg
        {
            public double a, b;
        }
    }

    // some utility functions
    class Utility
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }
        public static void SwapArr<T>(ref System.Collections.Generic.List<T> array, int ind1, int ind2)
        {
            T t = array[ind1];
            array[ind1] = array[ind2];
            array[ind2] = t;
        }
    }
    
    class MainClass
    {
        static string[] testingMethodsNames = new string[] { "Body", "Sin_1_in" };

        static void Main(string[] args)
        {
            var path = "OpaqueFunctions.cs";

            var methSin = new MethodForTesting(path, "Sin_1");
            var methSinTaylor = new MethodForTestingTaylor(methSin);
            Console.WriteLine(methSinTaylor.GetTestingReportOneArg(10000, 30));
            //Console.WriteLine(methSin.GetIterationsByEpsilon(0.01,10));
            Console.ReadKey();
        }
    }

    public class ReportEntry
    {
        public string FunctionName;
        public int NumberOfIterations;
        public double[] Arguments;
        public double[] Parameters;
        public double Val;
        public double WantedVal;
        public double AbsoluteEps;
        public double RelativeEps;

        public ReportEntry(
            bool evaluateEps = true,
            string functionName = "NONAME",
            int N = -1,
            double[] args = null,
            double[] param = null,
            double val = double.NaN,
            double wantedVal = double.NaN,
            double absEps = double.NaN,
            double relEps = double.NaN)
        {
            Arguments = args ?? new double[0];
            Parameters = param ?? new double[0];
            FunctionName = functionName;
            NumberOfIterations = N;
            Val = val;
            WantedVal = wantedVal;

            if (evaluateEps)
            {
                AbsoluteEps = Math.Abs(wantedVal - val);
                RelativeEps = AbsoluteEps / Math.Abs(WantedVal);
            }
            else
            {
                AbsoluteEps = absEps;
                RelativeEps = relEps;
            }
        }

        public string ToString(int argnum = 1, int parnum = 0)
        {
            //var joinedargs = Arguments.Take.Aggregate("",(res, cur) => "" + res + ", " + cur.ToString("G5"), (res) => res);
            //var joinedparam = Parameters.Aggregate("", (res, cur) => "" + res + ", " + cur.ToString("G5"), (res) => res);

            string joinedargs = Arguments.Length == 0 ? "" : Arguments[0].ToString("G5"), 
                   joinedparam = Parameters.Length == 0 ? "" : Parameters[0].ToString("G5");
            for(int i=1; i<Arguments.Length; ++i)
            {
                joinedargs += ", " + Arguments[i].ToString("G5");
            }
            for (int i = 1; i < Parameters.Length; ++i)
            {
                joinedparam += ", " + Parameters[i].ToString("G5");
            }

            return string.Format(getFormatString(argnum, parnum),
                FunctionName,
                NumberOfIterations,
                joinedargs,
                joinedparam,
                Val,
                WantedVal,
                AbsoluteEps,
                RelativeEps);
        }

        public static string getFormatString(int argnum = 1, int parnum = 0)
        {
            return "{0,10} {1,5} {2," + (argnum * 7) + "} {3," + (parnum * 7) + "} {4,9:G4} {5,9:G4} {6,9:G4} {7,9:G4}\n";
        }
    }

    public class Report : List<ReportEntry>
    {
        public static string getFormatString(int argnum = 1, int parnum = 0)
        {
            return "{0,10} {1,5} {2," + (argnum * 7) + "} {3," + (parnum * 7) + "} {4,9} {5,9} {6,9} {7,9}\n";
        }
        
        public override string ToString()
        {
            int maxArgs = 0, maxParams = 0;
            foreach(var entry in this)
            {
                maxArgs = Math.Max(maxArgs, entry.Arguments.Length);
                maxParams = Math.Max(maxParams, entry.Parameters.Length);
            }

            string title = string.Format(
                getFormatString(maxArgs, maxParams),
                "Function", "N", "Args", maxParams == 0 ? "" : "Params", "Val", "Ideal", "Abs", "Rel");
            StringBuilder resultingStr = new StringBuilder(title);
            foreach(var entry in this)
            {
                resultingStr.Append(entry.ToString(maxArgs, maxParams));
            }
            return resultingStr.ToString();
        }

        public double maxEpsilonAbsolute()
        {
            return this.Max((entry) => entry.AbsoluteEps);
        }

        public double maxEpsilonRelative()
        {
            return this.Max((entry) => entry.RelativeEps);
        }
    }

    // important container for testing functions that use sums
    class Heap
    {
        private int elnum = 0;
        private List<double> ar = new List<double>();

        public static bool less(double a, double b)
        {
            return (Math.Abs(a) < Math.Abs(b));
        }
        public static bool more(double a, double b)
        {
            return (Math.Abs(a) > Math.Abs(b));
        }
        public static bool lesseq(double a, double b)
        {
            return (Math.Abs(a) <= Math.Abs(b));
        }
        public static bool moreeq(double a, double b)
        {
            return (Math.Abs(a) >= Math.Abs(b));
        }

        private void Heapify(int index = 1)
        {
            int l = index << 1;
            int r = l + 1;

            if (index > elnum || l > elnum)
            {
                return;
            }
            else
            {
                if (r > elnum)
                {
                    if (less(ar[l - 1], ar[index - 1]))
                        Utility.SwapArr(ref ar, l - 1, index - 1);
                }
                else
                {
                    if (lesseq(ar[index - 1], ar[r - 1]) && lesseq(ar[index - 1], ar[l - 1]))
                        return;
                    if (less(ar[r - 1], ar[l - 1]))
                    {
                        Utility.SwapArr(ref ar, r - 1, index - 1);
                        Heapify(r);
                    }
                    else
                    {
                        Utility.SwapArr(ref ar, l - 1, index - 1);
                        Heapify(l);
                    }
                }
            }
        }

        private double ExtractMin()
        {
            double m = ar[0];
            ar[0] = ar[--elnum];
            ar.RemoveAt(elnum);
            Heapify();
            return m;
        }

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

        public void Clear()
        {
            ar.Clear();
            elnum = 0;
        }

        public double Sum()
        {
            for (int i = elnum >> 1; i >= 1; --i)
            {
                Heapify(i);
            }
            while (elnum > 1) AddTwoMin();
            return ar[0];
        }

        public void ChangeArray(ref List<double> a)
        {
            ar = a;
            elnum = a.Count();
        }

        public void AddElem(double el)
        {
            //Console.WriteLine(elnum);
            ar.Add(el);
            ++elnum;
        }

    }
    
    class TestingUtilities
    {
        public const string DefaultUsings = "using System;\n";

        public static string getEvalExpression(MethodDeclarationSyntax meth, string usings = DefaultUsings, MethodType Type = MethodType.X, bool isIdeal = false)
        {
            return usings + meth.GetText().ToString() + "\nreturn " + meth.Identifier + generateArguments(Type, !isIdeal) + ";\n";
        }

        public static T Evaluate<ArgsT, T>(MethodDeclarationSyntax meth, ArgsT args, string usings = DefaultUsings, ScriptOptions opts = null)
        {
            opts = opts ?? ScriptOptions.Default;
            return CSharpScript.EvaluateAsync<T>(getEvalExpression(meth, usings), opts, globals:args).Result;
        }

        public static T Evaluate<ArgsT, T>(string EvalExpression, ArgsT args, ScriptOptions opts = null)
        {
            opts = opts ?? ScriptOptions.Default;
            return CSharpScript.EvaluateAsync<T>(EvalExpression, opts, globals: args).Result;
        }

        // (arg1, arg2, .. , argn)
        public static string generateArguments(MethodType Type, bool WithN = true, bool types = false, int TestingEntriesNumber = 0)
        {
            Dictionary<MethodType, List<string>> dic = new Dictionary<MethodType, List<string>>();
            dic[MethodType.X] = new List<string> { "x" };
            dic[MethodType.XA] = new List<string> { "x", "a" };
            dic[MethodType.XAB] = new List<string> { "x", "a", "b" };
            dic[MethodType.XY] = new List<string> { "x", "y" };
            dic[MethodType.XYA] = new List<string> { "x", "y", "a" };
            dic[MethodType.XYAB] = new List<string> { "x", "y", "a", "b" };

            var res = "(" + (types ? "double " : "") + dic[Type].Aggregate( (result, cur) => result + ", " + (types ? "double" : "") + " " + cur);
            if (WithN)
            {
                res += ", " + (types ? "int " : "") + "N";
            }

            if (TestingEntriesNumber == 0) return res + ')';

            string[] ar = new string[TestingEntriesNumber];
            for (int i = 0; i < ar.Length; ++i)
            {
                ar[i] = "tst" + (i + 1);
            }
            return res + ", " + ar.Aggregate((result, cur) => result + ", " + (types ? "TaylorTestingEntry" : "") + " " + cur) + ')';
        }

        public static string makeArg(double x)
        {
            return x.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
        }

        // returns the number of iterations by epsilon we want
        public static int GetIterationsByEpsilonApproach(
            MethodForTesting f,
            double epsilon, 
            int pointsNumber, 
            TestingApproach approach = TestingApproach.UNIVERSAL,
            double[] functionParameters = null)
        {
            functionParameters = functionParameters ?? new double[0];

            const int initialN = 8;
            const int initialBadnessCountdown = 5;

            int cN = initialN;
            int badnessCountdown = initialBadnessCountdown;
            double ceps = 
                    approach == TestingApproach.UNIVERSAL ? 
                    f.GetMaxEpsilonAbsOneArg(cN, pointsNumber,functionParameters) : 
                    ((MethodForTestingTaylor)f).GetMaxEpsilonOneArgTaylor(cN, pointsNumber, functionParameters);
            while(ceps > epsilon)
            {
                //Console.WriteLine(cN + " " + ceps);
                cN <<= 1;
                double neweps = approach == TestingApproach.UNIVERSAL ?
                        f.GetMaxEpsilonAbsOneArg(cN, pointsNumber, functionParameters) :
                        ((MethodForTestingTaylor)f).GetMaxEpsilonOneArgTaylor(cN, pointsNumber, functionParameters);
                if (neweps == ceps) --badnessCountdown;
                else
                {
                    badnessCountdown = initialBadnessCountdown;
                    ceps = neweps;
                }

                if (badnessCountdown == 0) return cN >> initialBadnessCountdown;
            }
            return cN;
        }
        
    }

    public struct Interval
    {
        public const double almostInfinity = 10e4;
        public double left, right;
    }

    public class IntervalMethod
    {
        public static Interval Evaluate(MethodDeclarationSyntax meth)
        {
            var methName = meth.Identifier.ValueText;
            var methCode = meth.GetText().ToString();
            var interval = CSharpScript.EvaluateAsync<string>(methCode + "\n return " + methName + "();").Result;
            interval = interval.Substring(1, interval.Length - 2);
            var lnr = interval.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (lnr.Length != 2) throw new Exception();

            double[] corners = new double[2];
            for (int i = 0; i < 2; ++i)
            {
                try
                {
                    corners[i] = CSharpScript.EvaluateAsync<double>(lnr[i].ToUpper(), ScriptOptions.Default.WithImports("System.Math")).Result;
                }
                catch (CompilationErrorException)
                {
                    corners[i] = i == 0 ? -Interval.almostInfinity : Interval.almostInfinity;
                    continue;
                }
            }

            return new Interval { left = corners[0], right = corners[1] };
        }
    }

    public class IdealTestMethod
    {
        string EvalExpression;
        MethodType type;

        public static string Name = "_ideal";
        public static string ReturnType = "double";
        
        public IdealTestMethod(string IdealExpression, MethodType mtype)
        {
            type = mtype;
            EvalExpression = TestingUtilities.getEvalExpression(
                CSharpSyntaxTree.ParseText(ReturnType + " " + Name + TestingUtilities.generateArguments(type, false, true, 0) + 
                                            "{ return "+IdealExpression+"; }")
                                            .GetRoot().ChildNodes().OfType<MethodDeclarationSyntax>().First(),
                "using System;\n", mtype, true);
        }
        public double Evaluate<ArgsT>(ArgsT args)
        {
            return TestingUtilities.Evaluate<ArgsT, double>(EvalExpression, args, ScriptOptions.Default.WithImports("System.Math"));
        }
    }

    public class MethodForTesting
    {
        public static string Usings = "using System; \n";
        

        public string Code;
        public string EvalCode;
        public string Name;
        public IdealTestMethod IdealMethod;
        public MethodDeclarationSyntax Node;
        public MethodType Type;
        public string FilePath;
        public Interval Interval;
        
        public MethodForTesting()
        {

        }

        public MethodForTesting(MethodForTesting m)
        {
            Code = m.Code;
            EvalCode = m.EvalCode;
            IdealMethod = m.IdealMethod;
            FilePath = m.FilePath;
            Interval = m.Interval;
            Name = m.Name;
            Node = m.Node;
            Type = m.Type;
        }

        public MethodForTesting(string FilePath, string MethodName) : 
            this(getMethodsFromFiles(new string[] { FilePath }, new string[] { MethodName })[0])
        {
            
        } 

        //public class ArgsT{
        //  public double arg1;
        //  public int arg2; ...
        //}
        public double Evaluate<ArgsT>(ArgsT args){
            var opts = ScriptOptions.Default;
            var mscorlib = typeof(System.Object).Assembly;
            opts = opts.AddReferences(mscorlib);
            opts = opts.AddImports("System");
            opts = opts.AddImports("System.Math");
            return CSharpScript.EvaluateAsync<double>(EvalCode, opts, globals : args).Result;
        }

        public double GetMaxEpsilonAbsOneArg(int N, int PointsNumber, double [] parameters = null)
        {
            return GetTestingReportOneArg(N, PointsNumber, parameters).maxEpsilonAbsolute();
        }

        public double GetMaxEpsilonRelOneArg(int N, int PointsNumber, double[] parameters = null)
        {
            return GetTestingReportOneArg(N, PointsNumber, parameters).maxEpsilonRelative();
        }

        public int GetIterationsByEpsilon(
            double epsilon,
            int pointsNumber,
            double[] functionParameters = null)
        {
            return TestingUtilities.GetIterationsByEpsilonApproach(this, epsilon, pointsNumber, TestingApproach.UNIVERSAL, functionParameters);
        }

        public Report GetTestingReportOneArg(int N, int PointsNumber, double[] parameters = null)
        {
            Report rep = new Report();
            double h = (Interval.right - Interval.left) / (PointsNumber + 1);

            var structures = fillStructuresOneArg(Type, parameters);
            var argStructIdeal = structures.Item1;
            var argStructIter = structures.Item2;

            argStructIter.N = N;
            
            for (double arg = Interval.left + h; arg < Interval.right; arg += h)
            {
                argStructIter.x = argStructIdeal.x = arg;
                var val = Evaluate(argStructIter);
                var idealVal = IdealMethod.Evaluate(argStructIdeal);
                rep.Add(new ReportEntry(evaluateEps: true, functionName: Name, N: N, args: new double[] { arg }, val: val, wantedVal: idealVal));
            }
            return rep;
        }

        internal static Tuple<ArgsTypesIdeal.ArgsOneArg, ArgsTypesIterations.ArgsOneArg> fillStructuresOneArg(MethodType Type, double[] parameters = null)
        {
            if (Type != MethodType.X && Type != MethodType.XA && Type != MethodType.XAB)
                throw new Exception();

            parameters = parameters ?? new double[0];

            ArgsTypesIdeal.ArgsOneArg argStructIdeal = new ArgsTypesIdeal.ArgsOneArg();
            ArgsTypesIterations.ArgsOneArg argStructIter = new ArgsTypesIterations.ArgsOneArg();

            switch (Type)
            {
                case MethodType.X:
                    argStructIdeal = new ArgsTypesIdeal.ArgsX();
                    argStructIter = new ArgsTypesIterations.ArgsX();
                    break;
                case MethodType.XA:
                    argStructIdeal = new ArgsTypesIdeal.ArgsXA();
                    argStructIter = new ArgsTypesIterations.ArgsXA();
                    ((ArgsTypesIterations.ArgsXA)argStructIter).a =
                        ((ArgsTypesIdeal.ArgsXA)argStructIdeal).a = parameters[0];
                    break;
                case MethodType.XAB:
                    argStructIdeal = new ArgsTypesIdeal.ArgsXAB();
                    argStructIter = new ArgsTypesIterations.ArgsXAB();
                    ((ArgsTypesIterations.ArgsXAB)argStructIter).a =
                        ((ArgsTypesIdeal.ArgsXAB)argStructIdeal).a = parameters[0];
                    ((ArgsTypesIterations.ArgsXAB)argStructIter).b =
                        ((ArgsTypesIdeal.ArgsXAB)argStructIdeal).b = parameters[1];
                    break;
            }

            return Tuple.Create(argStructIdeal, argStructIter);
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

        public static Dictionary<string, Interval> getIntervals(SyntaxNode TreeRoot)
        {
            var dic = new Dictionary<string, Interval>();
            var methods = TreeRoot.DescendantNodes().OfType<MethodDeclarationSyntax>();
            foreach(var meth in methods)
            {
                string inMethName = meth.Identifier.ValueText;
                if (!inMethName.EndsWith("_in")) continue;
                string methodName = inMethName.Substring(0, inMethName.Length - 3);
                dic[methodName] = IntervalMethod.Evaluate(meth);
            }

            return dic;
        }

        public static List<MethodForTesting> getMethodsFromFiles(
            string[] FileNames,
            string[] MethodNames,
            bool exclude = false,
            Dictionary<string, MethodType> MethodTypes = null )
        {
            MethodTypes = MethodTypes ?? new Dictionary<string, MethodType>();

            List<MethodForTesting> reslist = new List<MethodForTesting>();
            foreach(var fname in FileNames)
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

                    MethodForTesting m = new MethodForTesting();
                    m.Code = meth.GetText().ToString();
                    m.Name = thisMethodName;
                    m.Node = meth;
                    m.FilePath = fname;
                    m.Type = MethodTypes.ContainsKey(m.Name) ? MethodTypes[m.Name] : MethodType.X;
                    m.IdealMethod = new IdealTestMethod(expressionsDic[m.Name], m.Type);
                    m.EvalCode = Usings + m.Code + "\nreturn " + 
                        m.Name + TestingUtilities.generateArguments(m.Type, true, false, 0)+";\n";
                    m.Interval = intervalsDic[m.Name];

                    reslist.Add(m);
                }
            }

            return reslist;
        }
    }

    public class MethodForTestingTaylor : MethodForTesting
    {
        public string TaylorEvalCode;
        public static new string Usings = "using System; \n using TestingSystem; \n";
        public static string TaylorAddonName = "_TaylorAddon";

        public MethodForTestingTaylor(MethodForTesting meth): base(meth)
        {
            TaylorEvalCode = Usings + 
                getChangedNode(Node).GetText().ToString() + 
                constructTaylorAddon(Name, Type) +
                "return " +TaylorAddonName + TestingUtilities.generateArguments(Type, true, false, 0)+ ";";
        }

        public Tuple<double, double> EvaluateTaylor<ArgsT>(ArgsT args)
        {
            var opts = ScriptOptions.Default;
            var mscorlib = typeof(object).Assembly;
            var testingEntry = typeof(TaylorTestingEntry).Assembly;
            opts = opts.AddReferences(mscorlib, testingEntry);
            opts = opts.AddImports("System");
            opts = opts.AddImports("System.Math");
            opts = opts.AddImports("TestingSystem.TaylorTestingEntry");
            var cort = TestingUtilities.Evaluate<ArgsT, Tuple<double, TaylorTestingEntry>>(TaylorEvalCode, args, opts);
            return Tuple.Create(cort.Item1, cort.Item2.GetSumAndClear());
        }
        
        public double GetMaxEpsilonOneArgTaylor(int N, int PointsNumber, double[] parameters = null)
        {
            double h = (Interval.right - Interval.left) / (PointsNumber + 1);

            var structures = fillStructuresOneArg(Type, parameters);
            var argStructIdeal = structures.Item1;
            var argStructIter = structures.Item2;

            argStructIter.N = N;

            double eps = 0;
            for (double arg = Interval.left + h; arg < Interval.right; arg += h)
            {
                argStructIter.x = argStructIdeal.x = arg;
                var taylorTuple = EvaluateTaylor(argStructIter);
                var val = taylorTuple.Item1;
                var idealVal = taylorTuple.Item2;
                eps = Math.Max(eps, Math.Abs(val - idealVal));
            }
            return eps;
        }

        public int GetIterationsByEpsilonTaylor(
            double epsilon,
            int pointsNumber,
            double[] functionParameters = null)
        {
            return TestingUtilities.GetIterationsByEpsilonApproach(this, epsilon, pointsNumber, TestingApproach.TAYLOR, functionParameters);
        }

        public static MethodDeclarationSyntax getChangedNode(MethodDeclarationSyntax method)
        {
            var TestEntryArgName = "__tst";
            /* Adding last param */
            //Console.WriteLine(i.GetText());
            var parlist = method.ChildNodes().OfType<ParameterListSyntax>().First();
            //Console.WriteLine(parlist.GetType()+ " " + parlist.GetText()+ " " + parlist.ChildTokens().Count());
            var newparlist = parlist.AddParameters(SyntaxFactory.Parameter(
                                                                    SyntaxFactory   .Identifier(TestEntryArgName))
                                                                                    .WithType(SyntaxFactory.ParseTypeName("TaylorTestingEntry ")));
            //Console.WriteLine(newparlist.GetText());
            var newmethod = method.ReplaceNode(parlist, newparlist);

            /* Adding tst.AddElement(i); */
            foreach (var s in newmethod.Body.DescendantNodes())
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

                //Console.WriteLine("PAMPARAM");

                var commentContents = st.ToString();
                char[] delim = { ' ', '\n', '\t', '\r' };
                var ar = commentContents.Split(delim, StringSplitOptions.RemoveEmptyEntries);
                //Console.WriteLine(ar.Length);
                if (ar.Length != 2 || ar[0] != "add") continue;

                var lineToAdd = TestEntryArgName + ".AddElement(" + ar[1] + ")";
                //newmethod = newmethod.//ReplaceNode(s, newparlist);
                var linelist = new List<ExpressionStatementSyntax>();
                linelist.Add(SyntaxFactory.ExpressionStatement(SyntaxFactory.ParseExpression(lineToAdd)));

                var childlist = s.Parent.ChildNodes();

                //Console.WriteLine("trtt");
                foreach (var si in childlist)
                {
                    if (s != si) continue;
                    if (before) newmethod = newmethod.InsertNodesBefore(si, linelist);
                    else newmethod = newmethod.InsertNodesAfter(si, linelist);
                    break;
                }

                //Console.WriteLine(s.Kind() + " " + s.ToString());
                break;
            }

            return newmethod;
        }

        public static string constructTaylorAddon(string funName, MethodType Type)
        {
            return @"Tuple<double, TaylorTestingEntry> " + TaylorAddonName + @" " + TestingUtilities.generateArguments(Type, true, true, 0) + @"{
                        TaylorTestingEntry tst1 = new TaylorTestingEntry();
                        var v = " + funName + @" " + TestingUtilities.generateArguments(Type, true, false, 1) + @";
                        return Tuple.Create(v, tst1);
                    }";
        }

    }
    // Testing different functions that use simple sums
    public class TaylorTestingEntry
    {
        private Heap h = new Heap();
        //private double eps;

        public void AddElement(double el)
        {
            h.AddElem(el);
        }

        public double GetSumAndClear()
        {
            var t = h.Sum();
            h.Clear();
            return t;
        }

        public string MatchResult(double res, double eps)
        {
            double sum = h.Sum();
            double current_eps = Math.Abs(res - sum);
            h.Clear();
            if (current_eps <= eps)
                return "OK";
            else return "Error, mistake is " + current_eps;
        }
        
    }
        
}

