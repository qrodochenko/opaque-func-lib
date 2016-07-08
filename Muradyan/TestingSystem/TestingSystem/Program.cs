#define TEST_TAYLOR

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
    public delegate double TaylorFuncTestDelegate(double x, int N, TaylorTestingEntry tst);
    public delegate double TaylorFuncDelegate(double x, int N);
    public delegate double TaylorFuncParamDelegate(double x, double a, int N);

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

    // too much code here, should be reduced to methods
    class MainClass
    {
        static string[] testingMethodsNames = new string[] { "Body", "Sin_1_in" };

        static void Main(string[] args)
        {/*
            Heap h = new Heap();
            int sgn = 1;
            double s = 0;
            for(int i=1; i<=10000000; ++i)
            {
                h.AddElem(sgn*1.0 / i);
                s += sgn*1.0 / i;
                sgn = -sgn;
            }
            Console.WriteLine(h.Sum() + " " + s);
            Console.ReadKey();
            */
            //TaylorTestingEntry t = new TaylorTestingEntry();
            //TaylorFunc f = TaylorFuncTest.Sin;
            //Console.WriteLine(t.TestFunction(f, 1000000, 1e-10, -1, 1, 20));

            var path = "OpaqueFunctions.cs";

            //Console.WriteLine(newrt.GetText());

            //Console.WriteLine("Max epsilon: " + UniversalTesting.getMaxEpsilon(path, "Sin_1", 100000, 10));
            //Console.WriteLine(UniversalTesting.getIterationsByEpsilon(path, "Sin_1", 0.005, 10));
            
            Console.WriteLine("Max epsilon: " + TaylorTesting.getMaxEpsilon(path, "Sin_1", 100000, 10));
            Console.ReadKey();
        }
    }

    // important container for testing functions which that use sums
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

    // This class do tests of almost all functions.
    // It searches all the information in the attributes
    class UniversalTesting
    {
        public static string getMethodCode(SyntaxNode TreeRoot, string MethodName)
        {
            var nodes = TreeRoot.DescendantNodes().OfType<MethodDeclarationSyntax>();
            string defsStr = "";
            foreach (var meth in nodes)
            {
                if (meth.Identifier.ValueText == MethodName)
                {
                    defsStr += meth.GetText().ToString();
                    break;
                }
            }
            return defsStr;
        }

        public static string getIdealExpressionFromAttribute(SyntaxNode TreeRoot, string MethodName)
        {
            string idealExpr = "";
            var attribs = TreeRoot.DescendantNodes().OfType<AttributeSyntax>();
            foreach (var attr in attribs)
            {
                var attrArgs = attr.ArgumentList.Arguments;
                if (attr.Name.GetText().ToString() == "FunctionName" &&
                    attrArgs.ElementAt(0).GetFirstToken().ValueText == MethodName)
                {
                    idealExpr += attrArgs.ElementAt(1).GetFirstToken().ValueText;
                    break;
                }

            }
            return idealExpr;
        }

        public static T Evaluate<T>(string methodName, string methodCode, params string[] args)
        {
            string arguments = args.Aggregate((res, cur) => res + "," +cur);
            //Console.WriteLine(arguments);
            arguments = '(' + arguments + ')' ;
            
            string EvalExpression = methodCode + "\nreturn " + methodName + arguments + ";";
            Console.WriteLine(EvalExpression);

            var opts = ScriptOptions.Default;
            var mscorlib = typeof(System.Object).Assembly;
            var systemCore = typeof(System.Linq.Enumerable).Assembly;
            var sth = typeof(TestingSystem.TaylorTestingEntry).Assembly;
            opts = opts.AddReferences(mscorlib, systemCore, sth);
            opts = opts.AddImports("System");
            opts = opts.AddImports("System.Linq");
            opts = opts.AddImports("System.Collections.Generic");
            opts = opts.AddImports("TestingSystem.TaylorTestingEntry"); 
            return CSharpScript.EvaluateAsync<T>(EvalExpression, opts).Result;
        }

        public static string constructMethodCodeFromExpr(string methodName, string retType, string Expression, string usings,  string arguments)
        {
            return usings + retType + " " + methodName + arguments + "{ return (" + Expression + "); }";
        }

        public static string makeArg(double x)
        {
            return x.ToString(CultureInfo.CreateSpecificCulture("en-GB"));
        }

        // TODO: define intervals by function name
        public static double getMaxEpsilon(string FilePath, string f, int N, int pointsNumber)
        {
            // Syntax tree building
            var tree = CSharpSyntaxTree.ParseText(File.ReadAllText(FilePath));
            var rt = tree.GetRoot();
            var usings = "using System; \n";

            // Find the code of the method we want to use and write it into defStr
            var defsStr = usings + getMethodCode(rt, f);

            // Find the attribute which contains "ideal" math expression
            // Write this expression to idealExpr
            string idealExpr = getIdealExpressionFromAttribute(rt, f);

            var intervalMethodStr = usings + getMethodCode(rt, f + "_in");
            
            double eps = 0;
            // TODO !!!!!
            double l = -1, r = 1;

            // evaluating our function in some points
            double h = (r - l) / (pointsNumber + 1);
            for (double arg = l + h; arg < r; arg += h)
            {
                // constructing script for calling "regular funtion"
                var strarg = makeArg(arg);
                //Console.WriteLine(N);
                double val = Evaluate<double>(f, defsStr, strarg, N.ToString());

                // constructing and calling "ideal" expression
                double idealVal = Evaluate<double>(
                    "_ideal_", 
                    constructMethodCodeFromExpr("_ideal_","double",idealExpr,usings,"(double x)"), 
                    strarg);
                //Console.WriteLine("Val: "+ val +". Ideal val: " + idealVal);

                // evaluating epsilon
                eps = Math.Max(eps, Math.Abs(val - idealVal));
            }
            return eps;
        }

        // returns the number of iterations by epsilon we want
        public static int getIterationsByEpsilon(string FilePath, string f, double epsilon, int pointsNumber)
        {
            const int initialN = 8;
            const int initialBadnessCountdown = 5;

            int cN = initialN;
            int badnessCountdown = initialBadnessCountdown;
            double ceps = getMaxEpsilon(FilePath, f, cN, pointsNumber);
            while(ceps > epsilon)
            {
                //Console.WriteLine(cN + " " + ceps);
                cN <<= 1;
                double neweps = getMaxEpsilon(FilePath, f, cN, pointsNumber);
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

        public string TestFunction(TaylorFuncTestDelegate f, int N, double eps, double l, double r, int pointsNumber)
        {

            Random rand = new Random();
            string res = "Testing...\n";
            for (int i = 0; i < pointsNumber; ++i)
            {
                double arg = l + rand.NextDouble() * (r - l);
                double val = f(arg, N, this);
                res += "f(" + arg + ") = " + val + " : " + MatchResult(val, eps) + "\n";

            }
            return res;
        }


    }

    
    class TaylorTesting
    {
        
        public static SyntaxNode getChangedTree(SyntaxNode root, string f)
        {
            var TestEntryArgName = "__tst";
            var nodes = root.DescendantNodes().OfType<MethodDeclarationSyntax>();
            SyntaxNode newrt = root;

            foreach (var method in nodes)
            {
                var methodName = method.Identifier.ValueText;
                //Console.WriteLine("-" + methodName + "-");
                if (methodName != f) continue;
                //Console.WriteLine(" ==================== ");

                /* Adding last param */
                //Console.WriteLine(i.GetText());
                var parlist = method.ChildNodes().OfType<ParameterListSyntax>().First();
                //Console.WriteLine(parlist.GetType()+ " " + parlist.GetText()+ " " + parlist.ChildTokens().Count());
                var newparlist = parlist.AddParameters(SyntaxFactory.Parameter(SyntaxFactory.Identifier(TestEntryArgName)).WithType(SyntaxFactory.ParseTypeName("TaylorTestingEntry ")));
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


                /* Nodes changing */
                newrt = newrt.ReplaceNode(method, newmethod);
                break;
            }
            return newrt;
        }

        public static string constructTeylorAddon(string funName)
        {
            return @"Tuple<double, TaylorTestingEntry> _TeylorAddon (double arg, int N){
                        TaylorTestingEntry tst = new TaylorTestingEntry();
                        var v = " + funName + @" (arg, N, tst);
                        return Tuple.Create(v, tst);
                    }";
        }

        public static double getMaxEpsilon(string FilePath, string f, int N, int pointsNumber)
        {
            var usings = "using System; \n using TestingSystem; \n";
            // Syntax tree building
            var tree = CSharpSyntaxTree.ParseText(File.ReadAllText(FilePath));
            var rt = tree.GetRoot();
            rt = getChangedTree(rt, f);

            // Find the code of the method we want to use and write it into defStr
            var defsStr = usings + UniversalTesting.getMethodCode(rt, f);

            // Find the attribute which contains "ideal" math expression
            // Write this expression to idealExpr

            //var intervalMethodStr = usings + getMethodCode(rt, f + "_in");

            double eps = 0;
            // TODO !!!!!
            double l = -1, r = 1;

            // evaluating our function in some points
            double h = (r - l) / (pointsNumber + 1);
            for (double arg = l + h; arg < r; arg += h)
            {
                // constructing script for calling "regular funtion"
                var strarg = UniversalTesting.makeArg(arg);
                //Console.WriteLine(N);
                string TaylorTestingAddon = constructTeylorAddon(f);
                var TaylorTestingMethod = defsStr + TaylorTestingAddon;
                var cort = UniversalTesting.Evaluate<Tuple<double,TaylorTestingEntry>>("_TeylorAddon", TaylorTestingMethod, strarg, N.ToString());
                double val = cort.Item1;
                TaylorTestingEntry tst = cort.Item2;
                double idealVal = tst.GetSumAndClear();

                // constructing and calling "ideal" expression
                //Console.WriteLine("Val: "+ val +". Ideal val: " + idealVal);

                // evaluating epsilon
                eps = Math.Max(eps, Math.Abs(val - idealVal));
            }
            return eps;
        }

        /*public static int getIterationsByEpsilon(string FilePath, string f, double epsilon, int pointsNumber)
        {

        }*/

        /*private static string getChangedMethodCode(string FilePath, string fname)
        {

        }*/
    }
    
}

