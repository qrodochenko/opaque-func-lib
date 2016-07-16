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
    public static class ExtendedMath
    {
        public static double Sqr(double x)
        {
            return x * x;
        }

        public static double Ctg(double x)
        {
            return 1 / Math.Tan(x);
        }

        public static double Cosec(double x)
        {
            return 1 / Math.Sin(x);
        }

        public static double Sec(double x)
        {
            return 1 / Math.Cos(x);
        }

        public static double Cth(double x)
        {
            return 1 / Math.Tanh(x);
        }

        public static double Csch(double x)
        {
            return 1 / Math.Sinh(x);
        }

        public static double Sech(double x)
        {
            return 1 / Math.Cosh(x);
        }

        public static double Arcctg(double x)
        {
            return Math.PI / 2 - Math.Atan(x);
        }
        public static double Arcsec(double x)
        {
            return Math.Acos(1 / x);
        }
        public static double Arccosec(double x)
        {
            return Math.Asin(1 / x);
        }

        public static double Arsh(double x)
        {
            return Math.Log(x + Math.Sqrt(x * x + 1));
        }

        public static double Arch(double x)
        {
            return Math.Log(x + Math.Sqrt(x * x - 1));
        }

        public static double Arth(double x)
        {
            return .5*Math.Log((1+x)/(1-x));
        }

        public static double Arcth(double x)
        {
            return .5 * Math.Log((1 + x) / (x - 1));
        }

        public static double Arsech(double x)
        {
            return Math.Log(1 / x + Math.Sqrt(1 / (x * x) - 1));
        }

        public static double Arcsch(double x)
        {
            return Math.Log(1 / x + Math.Sqrt(1 / (x * x) + 1));
        }
    }

    public class Point
    {
        public double[] coords;

        public Point(int n, double defaultVal = 0)
        {
            coords = new double[n];
            for(int i=0; i<n; ++i)
            {
                coords[i] = defaultVal;
            }
        }

        public Point(Point pt)
        {
            coords = new double[pt.coords.Length];
            Array.Copy(pt.coords, coords, coords.Length);
        }

        public double this[int i]{
            get
            {
                return coords[i];
            }
            set
            {
                coords[i] = value;
            }
        }
    } 

    public class PointCounter
    {
        public Point Cur { get; set; }
        Point Offset;
        Interval[] Limits;
        double Incer;

        public PointCounter(Interval[] lim, double incer, Point offset = null)
        {
            Offset = offset ?? new Point(lim.Length,incer/2);
            Limits = lim;
            Cur = new Point(lim.Length);
            Incer = incer;
            for(int i=0; i<lim.Length; ++i)
            {
                Cur[i] = lim[i].left + Offset[i];
            }
        }

        public bool inc()
        {
            for(int i=0; i<Limits.Length; ++i)
            {
                if(Cur[i] + Incer > Limits[i].right)
                {
                    if (i == Limits.Length - 1)
                        return false;
                    Cur[i] = Limits[i].left + Offset[i];
                    continue;
                }
                Cur[i] += Incer;
                break;
            }
            return true;
        }
    }

    public class ConvergencyRegion
    {
        public Interval[] Intervals;

        public ConvergencyRegion(Interval[] intervals)
        {
            Intervals = intervals;
        }

        public int getDim()
        {
            return Intervals.Length;
        }

        public double Area()
        {
            double sq = 1;
            foreach(var interv in Intervals)
            {
                sq *= interv.Length();
            }
            return sq;
        }

        public List<Point> GetPoints(int maxPoints)
        {
            List<Point> res = new List<Point>();

            double area = Area();
            double sqArea = area / maxPoints;
            double sqSide = Math.Pow(sqArea, 1 / getDim());
            PointCounter cnt = new PointCounter(Intervals, sqSide, new Point(getDim(),sqSide / 2));

            do
            {
                res.Add(new Point(cnt.Cur));
            }
            while (cnt.inc());

            return res;
        }


    }

    public enum EpsilonType
    {
        ABSOLUTE, RELATIVE
    }

    public class MethodType
    {
        public int argnum, parnum;

        public static MethodType X = new MethodType(1,0);
        public MethodType(int argnum, int parnum)
        {
            this.argnum = argnum;
            this.parnum = parnum;
        }
    }

    public class IdealMethodArgs
    {
        public double[] args;
        public double[] param;
    }

    public class IterMethodArgs : IdealMethodArgs
    {
        public int N;
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
    
    public class OpaqueException : Exception
    {
        public OpaqueException():base("Argument is out of range"){
            
        }
    }

    class MainClass
    {
        static string[] testingMethodsNames = new string[] { "Body", "Sin_1_in" };

        static void Main(string[] args)
        {
            /*
            var path = "OpaqueFunctions.cs";

            var methSin = new MethodForTestingOneArg(path, "Sin_1");
            var methSinTaylor = new MethodForTestingTaylorOneArg(methSin);
            methSin.GetTestingReport(100000, 300).SaveCSV("reportU.csv");
            methSinTaylor.GetTestingReport(1000, 300).SaveCSV("reportT.csv");
            //Console.WriteLine(methSin.GetIterationsByEpsilon(0.01,10));
            Console.ReadKey();
            */

            //PlotGraph.makeErrorPlot()

            var sr = new StreamReader("../../CSlist.txt");
            var listOfFiles = new List<string>();
            while (!sr.EndOfStream)
            {
                listOfFiles.Add(sr.ReadLine());
            }
            var listOfMethods = MethodForTesting.getMethodsFromFiles(listOfFiles.ToArray(), new string[] {}, true, true);

            Directory.CreateDirectory("Reports");
            Directory.CreateDirectory("ReportsTaylor");
            var sw = new StreamWriter("errors.txt");
            Console.WriteLine("Methods found total: {0}", listOfMethods.Count);
            listOfMethods.ForEach(
                (m) => 
                {
                    if (m.CompileScript())
                    {
                        if (m.Correct)
                        {
                            try
                            {
                                m.GetTestingReport(10, 500, new double[] { 2, 3 }).SaveCSV("Reports\\" + m.Name + ".csv");
                            }
                            catch
                            {
                                sw.WriteLine("Universal error: " + m.Name + " " + m.FilePath);
                            }
                        }
                        m.Script = null;
                        m.IdealMethod = null;
                    }
                    else
                    {
                        sw.WriteLine("Can't compile general code: " + m.Name + " " + m.FilePath);
                        return;
                    }
                    var mt = new MethodForTestingTaylor(m);
                    if (mt.Correct)
                    {
                        try
                        {
                            mt.GetTestingReportTaylor(1000, 500, new double[] { 2, 3 }).SaveCSV("ReportsTaylor\\" + mt.Name + ".csv");
                        }
                        catch
                        {
                            sw.WriteLine("Taylor error: " + m.Name + " " + m.FilePath);
                        }
                    }
                });
            sw.Close();

            PlotGraph.makeErrorPlots("Reports");
            PlotGraph.makeErrorPlots("ReportsTaylor");
        }
    }

    public class ReportEntry
    {
        public string FunctionName;
        public string FileName;
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
            string fileName = "NOFILE",
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
            FileName = fileName;
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

        public string ToString(string fieldsSeparator = " ", string argparamSeparator = ", ", int argnum = 1, int parnum = 0, bool forCSV = false)
        {
            //var joinedargs = Arguments.Take.Aggregate("",(res, cur) => "" + res + ", " + cur.ToString("G5"), (res) => res);
            //var joinedparam = Parameters.Aggregate("", (res, cur) => "" + res + ", " + cur.ToString("G5"), (res) => res);
            var dotOption = CultureInfo.CreateSpecificCulture("ru-RU");


            string joinedargs = Arguments.Length == 0 ? "" : Arguments[0].ToString("G5", dotOption), 
                   joinedparam = Parameters.Length == 0 ? "" : Parameters[0].ToString("G5", dotOption);
            for(int i=1; i<Arguments.Length; ++i)
            {
                joinedargs += argparamSeparator + Arguments[i].ToString("G5", dotOption);
            }
            for (int i = 1; i < Parameters.Length; ++i)
            {
                joinedparam += argparamSeparator + Parameters[i].ToString("G5", dotOption);
            }

            return string.Format(dotOption,
                getFormatString(argnum, parnum, fieldsSeparator, forCSV),
                FunctionName+ "("+FileName+")",
                NumberOfIterations,
                joinedargs,
                joinedparam,
                Val,
                WantedVal,
                AbsoluteEps,
                RelativeEps);
        }

        public string GetCSVLine()
        {
            return ToString(";", "|",forCSV:true);
        }

        public static string getFormatString(int argnum = 1, int parnum = 0, string fieldsSeparator = " ", bool forCSV = false)
        {
            string q = forCSV ? "\"" : "";
            return q + "{0,30}" + q + fieldsSeparator + 
                "{1,5}" + fieldsSeparator + 
                "{2," + (argnum * 7) + "}" + fieldsSeparator + 
                "{3," + (parnum * 7) + "} " + fieldsSeparator +
                "{4,9:G4} " + fieldsSeparator +
                "{5,9:G4}" + fieldsSeparator +
                "{6,9:G4}" + fieldsSeparator + 
                "{7,9:G4}\n";
        }
    }

    public class Report : List<ReportEntry>
    {
        public static string getFormatString(int argnum = 1, int parnum = 0, bool forCSV = false)
        {
            string q = forCSV ? "\"" : "";
            string dq = q + (forCSV ? ";" : " ") + q;
            return q+"{0,30}" + dq + "{1,5}" + dq + "{2," + (argnum * 7) + "}" + dq + "{3," + (parnum * 7) + "}" + dq + 
                "{4,9}" + dq + "{5,9}" + dq + "{6,9}" + dq + "{7,9}" + q + "\n";
        }
        
        public static string getTitleString(int argnum = 1, int parnum = 0, bool forCSV = false)
        {
            return string.Format(
                getFormatString(argnum, parnum, forCSV),
                "Function", "N", "Args", parnum == 0 ? "" : "Params", "Val", "Ideal", "Abs", "Rel");
        }

        public override string ToString()
        {
            int maxArgs = 0, maxParams = 0;
            foreach(var entry in this)
            {
                maxArgs = Math.Max(maxArgs, entry.Arguments.Length);
                maxParams = Math.Max(maxParams, entry.Parameters.Length);
            }

            string title = getTitleString(maxArgs, maxParams);
            StringBuilder resultingStr = new StringBuilder(title);
            foreach(var entry in this)
            {
                resultingStr.Append(entry.ToString(argnum:maxArgs, parnum:maxParams));
            }
            return resultingStr.ToString();
        }

        public void SaveCSV(string path)
        {
            string title = getTitleString(forCSV: true);
            StringBuilder resultingStr = new StringBuilder(title);
            foreach (var entry in this)
            {
                resultingStr.Append(entry.GetCSVLine());
            }
            var resStr = resultingStr.ToString();
            var file = new StreamWriter(path);

            file.WriteLine(resStr);
            file.Close();
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
    public class Heap
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
            if (elnum == 0) return 0;
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

        public void AddElement(double el)
        {
            //Console.WriteLine(elnum);
            ar.Add(el);
            ++elnum;
        }

    }
    
    class TestingUtilities
    {
        public const string DefaultUsings = "using System;\n";

        // (arg1, arg2, .. , argn)
        public static string generateArguments(MethodType Type, bool WithN = true, bool types = false, int HeapsNumber = 0, bool callTaylorAddonOrIdeal = false)
        {
            string res = "";
            if (types)
                res += "(double [] args, double [] param";
            else if(callTaylorAddonOrIdeal)
                res += "(args, param";
            else
            {
                res += "(";
                for (int i = 0; i < Type.argnum; ++i)
                    res += "args[" + i + "], ";
                for (int i=0; i<Type.parnum; ++i)
                {
                    res += "param[" + i + "], ";
                }
                res = res.Substring(0, res.Length - 2);
            }

            if (WithN)
            {
                res += ", " + (types ? "int " : "") + "N";
            }

            if (HeapsNumber == 0) return res + ')';

            string[] ar = new string[HeapsNumber];
            for (int i = 0; i < ar.Length; ++i)
            {
                ar[i] = "tst" + (i + 1);
            }
            return res + ", " + ar.Aggregate((result, cur) => result + ", " + (types ? "Heap" : "") + " " + cur) + ')';
        }

        public static Tuple<IdealMethodArgs,IterMethodArgs> GenerateStructures(MethodType t, double[] parameters = null)
        {
            parameters = parameters ?? new double[0];
            var idargs = new IdealMethodArgs();
            var itargs = new IterMethodArgs();
            idargs.param = itargs.param = parameters;
            idargs.args = itargs.args = new double[t.argnum];
            return new Tuple<IdealMethodArgs, IterMethodArgs>(idargs, itargs);
        }

        public static string makeArg(double x)
        {
            return x.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
        }

        // returns the number of iterations by epsilon we want
        public static int GetIterationsByEpsilon(
            MethodForTesting f,
            double epsilon, 
            int pointsNumber, 
            EpsilonType epsType = EpsilonType.RELATIVE,
            double[] functionParameters = null)
        {
            functionParameters = functionParameters ?? new double[0];

            const int initialN = 8;
            const int initialBadnessCountdown = 5;

            int cN = initialN;
            int badnessCountdown = initialBadnessCountdown;
            double ceps = epsType == EpsilonType.ABSOLUTE ? 
                f.GetMaxEpsilonAbs(cN, pointsNumber,functionParameters):
                f.GetMaxEpsilonRel(cN, pointsNumber, functionParameters);
            
            while(ceps > epsilon)
            {
                //Console.WriteLine(cN + " " + ceps);
                cN <<= 1;
                double neweps = epsType == EpsilonType.ABSOLUTE ?
                    f.GetMaxEpsilonAbs(cN, pointsNumber, functionParameters) :
                    f.GetMaxEpsilonRel(cN, pointsNumber, functionParameters);
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
        
        public static Report GetReport(
            int N, 
            int pointsNumber, 
            double[] parameters, 
            MethodType type,
            string methodName,
            string fieName,
            ConvergencyRegion reg, 
            Func<MethodType, double[], Tuple<IdealMethodArgs, IterMethodArgs>> generateStructures,
            Action<IdealMethodArgs, IterMethodArgs, Point>  putArg,
            Func<IdealMethodArgs, IterMethodArgs, Tuple<double, double>> evalFunc)
        {
            Report rep = new Report();

            var structures = generateStructures(type, parameters);
            var argStructIdeal = structures.Item1;
            var argStructIter = structures.Item2;
            argStructIter.N = N;

            var ptsList = reg.GetPoints(pointsNumber);

            foreach (var pt in ptsList)
            {
                putArg(argStructIdeal,argStructIter, pt);
                var resTuple = evalFunc(argStructIdeal, argStructIter);
                var val = resTuple.Item1;
                var idealVal = resTuple.Item2;
                rep.Add(new ReportEntry(
                    evaluateEps: true,
                    functionName: methodName,
                    fileName:fieName,
                    N: N,
                    args: pt.coords,
                    param: parameters,
                    val: val,
                    wantedVal: idealVal));
            }
            return rep;
        }
    }

    public struct Interval
    {
        public const double almostInfinity = 10e4;
        public double left, right;

        public double Length()
        {
            return right - left;
        }
    }

    //Считаем, что внутри выажений скобок нет
    public class IntervalMethod
    {
        //TODO:
        //Параметризованные интервалы
        //Замена маленьких идентификаторов на большие

        public static Interval[] Evaluate(MethodDeclarationSyntax meth)
        {
            var methName = meth.Identifier.ValueText;
            var methCode = meth.GetText().ToString();
            string methodResult = "";
            try
            {
                methodResult = CSharpScript.EvaluateAsync<string>(methCode + "\n return " + methName + "();").Result;
            }
            catch(Exception)
            {
                return null;
            }
            var intervalsList = new List<string>();
            int cBracket = 0, oBracket = 0;
            string cS = "";
            foreach(char c in methodResult)
            {
                if (c == '(') ++cBracket;
                else if (c == ')') --cBracket;
                else cS += c;

                if(cBracket == 0 && oBracket == 1)
                {
                    intervalsList.Add(cS);
                    cS = "";
                }
                oBracket = cBracket;
            }
            string[] intervalsStrs = intervalsList.ToArray();
            
            Interval[] intervals = new Interval[intervalsStrs.Length];

            int k = 0;
            foreach (var interval in intervalsStrs)
            {
                var lnr = interval.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (lnr.Length != 2) throw new Exception();

                double[] corners = new double[2];
                for (int i = 0; i < 2; ++i)
                {
                    var upperText = lnr[i].ToUpper();
                    corners[i] = upperText.IndexOf('W') == -1 ?
                        CSharpScript.EvaluateAsync<double>(upperText, ScriptOptions.Default.WithImports("System.Math")).Result :
                        (i == 0 ? -Interval.almostInfinity : Interval.almostInfinity);
                    
                }
                intervals[k] = new Interval { left = corners[0], right = corners[1] };
                ++k;
            }

            return intervals;
        }
    }

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
                foreach(var id in identifiers)
                {
                    var idTextNCh = id.Identifier.ValueText.Trim();
                    var idText = idTextNCh.ToUpper();
                    if (!IdentifierDic.ContainsKey(idText) || IdentifierDic.ContainsValue(idTextNCh)) continue;
                    var dicText = IdentifierDic[idText];

                    if (dicText != idTextNCh){
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
                    var txt = "Pow("+id.Left.GetText()+", "+id.Right.GetText()+")";
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
                ScriptOptions.Default   .WithReferences(typeof(ExtendedMath).Assembly)
                                        .WithImports("System.Math","TestingSystem.ExtendedMath"), 
                typeof (IdealMethodArgs));
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
            this(getMethodsFromFiles(new string[] { FilePath }, new string[] { MethodName },methodTypeDetection:true)[0])
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
                Console.WriteLine("Ideal test method: "+Name + " " + FilePath + " " + e.Message);
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
        public double Evaluate(IterMethodArgs args){
            return Script.RunAsync(args).Result.ReturnValue;
        }

        public double GetMaxEpsilonAbs(int N, int PointsNumber, double[] parameters = null)
        {
            return GetTestingReport(N, PointsNumber, parameters).maxEpsilonAbsolute();
        }

        public double GetMaxEpsilonRel(int N, int PointsNumber, double[] parameters = null)
        {
            return GetTestingReport(N, PointsNumber, parameters).maxEpsilonRelative();
        }

        public int GetIterationsByEpsilon(
            double epsilon,
            int pointsNumber,
            double[] functionParameters = null)
        {
            return TestingUtilities.GetIterationsByEpsilon(this, epsilon, pointsNumber, functionParameters:functionParameters);
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
            foreach(var meth in methods)
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
            for (; parnum < possibleParams.Length && (parnum+argnum) < args.Length && possibleParams[parnum] == args[argnum+parnum]; ++parnum) ;
            if (argnum == 0 || (argnum+parnum+1) != args.Length) return null;
            return new MethodType (argnum, parnum);
        }

        public static List<MethodForTesting> getMethodsFromFiles(
            string[] FileNames,
            string[] MethodNames,
            bool exclude = false,
            bool methodTypeDetection = false,
            Dictionary<string, MethodType > MethodTypes = null )
        {
            MethodTypes = MethodTypes ?? new Dictionary<string, MethodType>();
#if DEBUG
            StreamWriter sw = new StreamWriter("gmffErrors.txt");
#endif
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

                    var t = MethodTypes.ContainsKey(thisMethodName) ? MethodTypes[thisMethodName] :
                        (methodTypeDetection ? DetectType(meth): MethodType.X);
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
                    
                    if(methIntervals.Length != t.argnum)
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
                    Console.WriteLine(thisMethodName+" "+fname);
#endif
                    m.Type = t;
                    m.Code = meth.GetText().ToString();
                    m.Node = meth;
                    
                    m.Correct = false;
                    m.EvalCode = Usings + m.Code + "\nreturn " + 
                        m.Name + TestingUtilities.generateArguments(m.Type, true, false, 0)+";\n";

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

    public class MethodForTestingTaylor : MethodForTesting
    {
        //public string TaylorEvalCode;
        public static new string Usings = "using System; \n using TestingSystem; \n";
        public static string TaylorAddonName = "_TaylorAddon";
        public Script<Tuple<double, double>> ScriptTaylor;

        public MethodForTestingTaylor(MethodForTesting meth): base(meth)
        {
            var TaylorEvalCode = Usings + 
                getChangedNode(Node).GetText().ToString() + 
                constructTaylorAddon(Name, Type) +
                "return " +TaylorAddonName + TestingUtilities.generateArguments(Type, true, false, 0, true)+ ";";

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
            catch(Exception)
            {
                Correct = false;
            }
        }

        public Tuple<double, double> EvaluateTaylor(IterMethodArgs args)
        {
            return ScriptTaylor.RunAsync(args).Result.ReturnValue;
        }

        public Report GetTestingReportTaylor(int N, int PointsNumber, double[] parameters = null)
        {
            return TestingUtilities.GetReport(N, PointsNumber, parameters,
                Type, Name, FilePath, Region,
                TestingUtilities.GenerateStructures,
                (ideal, iter, pt) => iter.args = pt.coords,
                (ideal, iter) => EvaluateTaylor(iter));
        }

        public int GetIterationsByEpsilonTaylor(
            double epsilon,
            int pointsNumber,
            double[] functionParameters = null)
        {
            return TestingUtilities.GetIterationsByEpsilon(this, epsilon, pointsNumber, functionParameters:functionParameters);
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
                                                                                    .WithType(SyntaxFactory.ParseTypeName("Heap ")));
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
            return @"Tuple<double, double> " + TaylorAddonName + @" " + TestingUtilities.generateArguments(Type, true, true, 0) + @"{
                        Heap tst1 = new Heap();
                        var v = " + funName + @" " + TestingUtilities.generateArguments(Type, true, false, 1) + @";
                        return Tuple.Create(v, tst1.Sum());
                    }";
        }

    }

}

