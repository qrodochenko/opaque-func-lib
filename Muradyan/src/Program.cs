using System;
using System.Collections.Generic;
using System.IO;

//main namespace
namespace TestingSystem
{
    static class OutputPath
    {
        public static string FilesListPath = "..\\CSlist.txt";
        public static string UniversalReportsDir = "..\\..\\testing_data\\Reports";
        public static string TaylorReportsDir = "..\\..\\testing_data\\ReportsTaylor";
        public static string GetMethodsFromFilesErrorsPath = "..\\..\\debug_data\\gmff_errors.txt";
        public static string CommonErrorsPath = "..\\..\\debug_data\\errors.txt";
    }

    class MainClass
    {
        
        static void Main(string[] args)
        {

            var sr = new StreamReader(OutputPath.FilesListPath);
            var listOfFiles = new List<string>();
            while (!sr.EndOfStream)
            {
                listOfFiles.Add(sr.ReadLine());
            }
            var listOfMethods = MethodForTesting.getMethodsFromFiles(listOfFiles.ToArray(), new string[] {}, true, true);

            Directory.CreateDirectory(OutputPath.UniversalReportsDir);
            Directory.CreateDirectory(OutputPath.TaylorReportsDir);
            var sw = new StreamWriter(OutputPath.CommonErrorsPath);
            Console.WriteLine("Methods found total: {0}", listOfMethods.Count);
            listOfMethods.ForEach(
                (m) => 
                {
                    if (m.CompileScript())
                    {
                        try
                        {
                            m.GetTestingReport(1000, 500, new double[] { 2, 3 }).SaveCSV(OutputPath.UniversalReportsDir + "\\" + m.Name + ".csv");
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
                        m.Script = null;
                        try
                        {
                            mt.GetTestingReportTaylor(1000, 500, new double[] { 2, 3 }).SaveCSV(OutputPath.TaylorReportsDir + "\\" + mt.Name + ".csv");
                        }
                        catch
                        {
                            sw.WriteLine("Taylor error: " + m.Name + " " + m.FilePath);
                        }
                    }
                });
            sw.Close();

            PlotGraph.makeErrorPlots(OutputPath.UniversalReportsDir);
            PlotGraph.makeErrorPlots(OutputPath.TaylorReportsDir);
        }
    }
}

