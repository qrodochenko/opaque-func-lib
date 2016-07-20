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
            var sr = new StreamReader("..\\CSlist.txt");
            var listOfFiles = new List<string>();
            while (!sr.EndOfStream)
            {
                listOfFiles.Add(sr.ReadLine());
            }
            var listOfMethods = MethodForTesting.getMethodsFromFiles(listOfFiles.ToArray(), new string[] {}, true, true);

            Directory.CreateDirectory("..\\..\\testing_data\\Reports");
            Directory.CreateDirectory("..\\..\\testing_data\\ReportsTaylor");
            var sw = new StreamWriter("..\\..\\debug_data\\errors.txt");
            Console.WriteLine("Methods found total: {0}", listOfMethods.Count);
            listOfMethods.ForEach(
                (m) => 
                {
                    if (m.CompileScript())
                    {
                        try
                        {
                            m.GetTestingReport(1000, 500, new double[] { 2, 3 }).SaveCSV("..\\..\\testing_data\\Reports\\" + m.Name + ".csv");
                        }
                        catch
                        {
                            sw.WriteLine("Universal error: " + m.Name + " " + m.FilePath);
                        }
                        m.Script = null;
                        m.IdealMethod = null;
                    }
                    else if(!m.Correct)
                    {
                        sw.WriteLine("Can't compile general code: " + m.Name + " " + m.FilePath);
                        return;
                    }
                    var mt = new MethodForTestingTaylor(m);
                    if (mt.CorrectTaylor)
                    {
                        try
                        {
                            mt.GetTestingReportTaylor(1000, 500, new double[] { 2, 3 }).SaveCSV("..\\..\\testing_data\\ReportsTaylor\\" + mt.Name + ".csv");
                        }
                        catch
                        {
                            sw.WriteLine("Taylor error: " + m.Name + " " + m.FilePath);
                        }
                    }
                });
            sw.Close();

            PlotGraph.makeErrorPlots("..\\..\\testing_data\\Reports");
            PlotGraph.makeErrorPlots("..\\..\\testing_data\\ReportsTaylor");
        }
    }
}

