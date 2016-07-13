using System;
using OpaqueFunctions;
using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace SummerPractice_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Summer Practice! Yay!");
            Console.WriteLine();
            

            //if (MakeTests(0.00000000001, CMathApprox_1_Compute.MathApprox_1_Compute_2))
            //  Console.WriteLine("Testing failed...");
            Console.WriteLine();

            //MakeResFile("MathApprox_Ln_2", CMathApprox_1_Compute.MathApprox_1_Compute_2, 
            //    Math.Log, 0.5, 0.00000005);

            //if (MakeTests(0.0000000000000000005, CMathApprox_2_Compute.MathApprox_2_Compute_2, 1.05))
            //   Console.WriteLine("Failed...");
            
            

            Console.WriteLine(CMathApprox_1.MathApprox_1_2("D:\\C#\\Kovalev\\", 0.0000000005));

            MakeResFile("MathApprox_Ln_2", CMathApprox_1_Compute.MathApprox_1_Compute_2,
                Math.Log, 0.5, 0.0000000005);

            MakeErrorPlot("D:\\C#\\Kovalev\\csv\\Report_MathApprox_Atan_2_5E-10.csv");
            MakeErrorPlot("D:\\C#\\Kovalev\\csv\\Report_MathApprox_Ln_2_5E-10.csv");
        }

        static void MakeResFile(string funcname, Func<double, double, double> F, 
            Func<double, double> f, double border, double error)
        {
            string Folder = ("csv\\");
            string Dest = Folder + "Report_" + funcname + "_" + error.ToString() + ".csv";
            System.IO.StreamWriter Dest_file_writer = new System.IO.StreamWriter(Dest);
            Dest_file_writer.WriteLine("x" + ';' + "Value" + ";" + "Abs" + ';' + "Rel");
            double length = border * 2;
            uint number_of_points = 100;
            double dx = length / number_of_points;
            border = -Math.Abs(border);
            for (int i = 1; i < number_of_points; i++)
            {
                double x = border + i * dx;
                double Res = F(x, error);
                double R = 0;
                if (funcname == "MathApprox_Ln_2")
                    R = f(1 + x);
                else
                    R = f(x);
                double abs = Math.Abs(Res - R);
                double rel;
                if (R == 0)
                    rel = 0;
                else
                    rel = Math.Abs((Res - R) / R);
                Dest_file_writer.WriteLine(x.ToString() + ';' + Res.ToString() + ";" + abs.ToString() + ';' + rel.ToString());
            }

            Console.Write("Complete! \n");
            Dest_file_writer.Close();
        }

        static bool MakeTests(double error, Func<double, double, double> f, double border)
        {

            Random rnd = new Random();
            double max = 0.0;
            Console.WriteLine("Starting tests...");
            Console.WriteLine();
            bool F = false;
            double Range = border * 4000.0;
            for (int i = 0; i < 1000; i++)
            {
                double arg = rnd.Next(1, Convert.ToInt32(Range)) - Range/2;
                arg = arg / 2000.0;
                if (Math.Abs(arg) > max)
                    max = Math.Abs(arg);
                if (Math.Abs(f(arg, error) - Math.Atan(arg)) > error)
                {
                    F = true;
                    max = arg;
                    break;
                }
            }
            if (F)
                Console.WriteLine(max);
            
            return F;
        }

        static void MakeErrorPlot(string Source)
        {
            TextFieldParser Parser = new TextFieldParser(Source); //обрабатываем .csv файл
            Parser.TextFieldType = FieldType.Delimited;
            Parser.SetDelimiters(";");
            var AbsErrChart = new Chart();
            var RelErrChart = new Chart();

            AbsErrChart.Series.Add("AbsErr");
            RelErrChart.Series.Add("RelErr");

            string headers = Parser.ReadLine();
            var x_coordinates = new List<double>();
            while (!Parser.EndOfData)
            {
                string[] fields = Parser.ReadFields();
                AbsErrChart.Series["AbsErr"].Points.AddXY(Convert.ToDouble(fields[0]), Convert.ToDouble(fields[2])); //добавляем точки на график
                RelErrChart.Series["RelErr"].Points.AddXY(Convert.ToDouble(fields[0]), Convert.ToDouble(fields[3]));
            }
            AbsErrChart.Series["AbsErr"].ChartType = SeriesChartType.FastLine;
            AbsErrChart.Series["AbsErr"].Color = System.Drawing.Color.Red;
            AbsErrChart.Height = 1000;
            AbsErrChart.Width = 1000;
            AbsErrChart.ChartAreas.Add("NewAbsChartArea");
            AbsErrChart.Series["AbsErr"].ChartArea = "NewAbsChartArea";

            String Path = Source.Replace("csv\\", "$").Split('$')[0];
            String AbsErrorFolder = Path + "Plots\\AbsErr_plots";
            if (!System.IO.Directory.Exists(AbsErrorFolder))
                System.IO.Directory.CreateDirectory(AbsErrorFolder);
            AbsErrChart.SaveImage(Source.Replace("csv\\", "Plots\\AbsErr_Plots\\").Replace(".csv", ".png"), ChartImageFormat.Png);

            RelErrChart.Series["RelErr"].ChartType = SeriesChartType.FastLine;
            RelErrChart.Series["RelErr"].Color = System.Drawing.Color.Green;
            RelErrChart.Height = 1000;
            RelErrChart.Width = 1000;
            RelErrChart.ChartAreas.Add("NewRelChartArea");
            RelErrChart.Series["RelErr"].ChartArea = "NewRelChartArea";

            String RelErrorFolder = Path + "Plots\\RelErr_plots";
            if (!System.IO.Directory.Exists(RelErrorFolder))
                System.IO.Directory.CreateDirectory(RelErrorFolder);
            RelErrChart.SaveImage(Source.Replace("csv\\", "Plots\\RelErr_Plots\\").Replace(".csv", ".png"), ChartImageFormat.Png);
        }

    }
}
