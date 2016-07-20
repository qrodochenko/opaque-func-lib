using System;
using System.Globalization;
using System.Linq;

namespace TestingSystem
{

    // some utility functions
    internal static class Utility
    {
        internal static void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }
        internal static void SwapArr<T>(ref System.Collections.Generic.List<T> array, int ind1, int ind2)
        {
            T t = array[ind1];
            array[ind1] = array[ind2];
            array[ind2] = t;
        }
    }

    class TestingUtilities
    {
        public const string DefaultUsings = "using System;\n";

        // (arg[0], arg[1], .. , arg[n-1], param[0], param[1], ..., param[m-1])
        public static string generateArguments(MethodType Type, bool WithN = true, bool types = false, int HeapsNumber = 0, bool callTaylorAddonOrIdeal = false)
        {
            string res = "";
            if (types)
                res += "(double [] args, double [] param";
            else if (callTaylorAddonOrIdeal)
                res += "(args, param";
            else
            {
                res += "(";
                for (int i = 0; i < Type.argnum; ++i)
                    res += "args[" + i + "], ";
                for (int i = 0; i < Type.parnum; ++i)
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

        public static Tuple<IdealMethodArgs, IterMethodArgs> GenerateStructures(MethodType t, double[] parameters = null)
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
            double[] functionParameters = null,
            Func<int, int, double[], Report> reportingFunction = null)
        {
            functionParameters = functionParameters ?? new double[0];
            reportingFunction = reportingFunction ?? f.GetTestingReport;

            const int initialN = 8;
            const int initialBadnessCountdown = 5;

            int cN = initialN;
            int badnessCountdown = initialBadnessCountdown;
            double ceps = epsType == EpsilonType.ABSOLUTE ?
                f.GetMaxEpsilonAbs(cN, pointsNumber, functionParameters, reportingFunction) :
                f.GetMaxEpsilonRel(cN, pointsNumber, functionParameters, reportingFunction);

            while (ceps > epsilon)
            {
                //Console.WriteLine(cN + " " + ceps);
                cN <<= 1;
                double neweps = epsType == EpsilonType.ABSOLUTE ?
                    f.GetMaxEpsilonAbs(cN, pointsNumber, functionParameters, reportingFunction) :
                    f.GetMaxEpsilonRel(cN, pointsNumber, functionParameters, reportingFunction);
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
            Action<IdealMethodArgs, IterMethodArgs, Point> putArg,
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
                putArg(argStructIdeal, argStructIter, pt);
                var resTuple = evalFunc(argStructIdeal, argStructIter);
                var val = resTuple.Item1;
                var idealVal = resTuple.Item2;
                rep.Add(new ReportEntry(
                    evaluateEps: true,
                    functionName: methodName,
                    fileName: fieName,
                    N: N,
                    args: pt.coords,
                    param: parameters,
                    val: val,
                    wantedVal: idealVal));
            }
            return rep;
        }
    }
}