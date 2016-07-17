using System;
using System.Collections.Generic;
using System.IO;

//main namespace
namespace TestingSystem
{
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

            var hp = new Heap();
            for(int i=99999; i>0; --i)
            {
                hp.AddElement(i);
            }
            hp.AddElement(2);
            hp.AddElement(11);
            Console.WriteLine(hp.Sum());
            //Console.ReadKey();

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
                                m.GetTestingReport(1000, 500, new double[] { 2, 3 }).SaveCSV("Reports\\" + m.Name + ".csv");
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
}

