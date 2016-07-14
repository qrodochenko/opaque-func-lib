using System;
using OpaqueFunctions;
using System.Collections.Generic;
using System.Linq; 
using System.Windows.Forms.DataVisualization.Charting; //консольное приложение не имеет ссылки сюда само по себе. Нужно добавить её через меню "Добавить->Ссылка->Платформа".
//System.Windows.Forms + System.Windows.Forms.DataVisualization + System.Drawing
using Microsoft.VisualBasic.FileIO; //то же самое, нужно для обработки .csv

namespace SummerPractice_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            for (int i = 1; i <= 3; i++)
            {                
                switch (i)
                {
                    case 1:
                        N = 100;
                        break;
                    case 2:
                        N = 500;
                        break;
                    case 3:
                        N = 1000;
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
                
                MakeResultsSummaryFile("Math_1_2", CMath_1_2.Math_1_2, N, MyBenchmark.Math_1_2_benchmark);
                MakeResultsSummaryFile("Math_2_2", CMath_2_2.Math_2_2, N, MyBenchmark.Math_2_2_benchmark);
                MakeResultsSummaryFile("Math_3_2", CMath_3_2.Math_3_2, N, MyBenchmark.Math_3_2_benchmark);
                MakeResultsSummaryFile("Math_4_2", CMath_4_2.Math_4_2, N, MyBenchmark.Math_4_2_benchmark);
                MakeResultsSummaryFile("Math_5_2", CMath_5_2.Math_5_2, N, MyBenchmark.Math_5_2_benchmark);
                MakeResultsSummaryFile("Math_6_2", CMath_6_2.Math_6_2, N, MyBenchmark.Math_6_2_benchmark);
                MakeResultsSummaryFile("Math_7_2", CMath_7_2.Math_7_2, N, MyBenchmark.Math_7_2_benchmark);
                MakeResultsSummaryFile("Math_8_2", CMath_8_2.Math_8_2, N, MyBenchmark.Math_8_2_benchmark);
                MakeResultsSummaryFile("Math_9_2", CMath_9_2.Math_9_2, N, MyBenchmark.Math_9_2_benchmark);
                MakeResultsSummaryFile("Math_10_2", CMath_10_2.Math_10_2, N, MyBenchmark.Math_10_2_benchmark);
                MakeResultsSummaryFile("Math_11_2", CMath_11_2.Math_11_2, N, MyBenchmark.Math_11_2_benchmark);
                MakeResultsSummaryFile("Math_12_2", CMath_12_2.Math_12_2, N, MyBenchmark.Math_12_2_benchmark);
                MakeResultsSummaryFile("Math_13_2", CMath_13_2.Math_13_2, N, MyBenchmark.Math_13_2_benchmark);
                MakeResultsSummaryFile("Math_14_2", CMath_14_2.Math_14_2, N, MyBenchmark.Math_14_2_benchmark);
                MakeResultsSummaryFile("Math_15_2", CMath_15_2.Math_15_2, N, MyBenchmark.Math_15_2_benchmark);
                MakeResultsSummaryFile("Math_16_2", CMath_16_2.Math_16_2, N, MyBenchmark.Math_16_2_benchmark);
                MakeResultsSummaryFile("Math_17_2", CMath_17_2.Math_17_2, N, MyBenchmark.Math_17_2_benchmark);
                MakeResultsSummaryFile("Math_18_2", CMath_18_2.Math_18_2, N, MyBenchmark.Math_18_2_benchmark);
                MakeResultsSummaryFile("Math_19_2", CMath_19_2.Math_19_2, N, MyBenchmark.Math_19_2_benchmark);
                MakeResultsSummaryFile("Math_20_2", CMath_20_2.Math_20_2, N, MyBenchmark.Math_20_2_benchmark);

                string offset = "..\\..\\..\\..\\"; // чтобы выходные файлы оказались точно в папке с фамилией  
                string source_csv_folder_name = offset + "csv"; // пусть папка для файлов с отчётами .csv называется так.
                makeErrorPlots(source_csv_folder_name);
                
            }

        }
              
        static void MakeResultsSummaryFile(string funcname, Func<double, int, double> f, int N, Func<double, double> benchmark)
        {
            //генерирует файл .csv нужного формата
            string dest_folder = ("..\\..\\..\\..\\csv\\");
            //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
            string dest = dest_folder + funcname + "_N" + N.ToString() + ".csv";
            if(!System.IO.Directory.Exists(dest_folder))
            {
                System.IO.Directory.CreateDirectory(dest_folder);
            }
            System.IO.StreamWriter dest_file_writer =
               new System.IO.StreamWriter(dest);
            dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");
            //мы хотим равномерно покрыть область определения (или хорошей сходимости) функции number_of_points точками. Подойдите к выбору области аккуратно.
            double left_border_of_range = -1.0;
            double right_border_of_range = 1.0;
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 200;
            double dx = range_length / number_of_points;
            for (int i = 1; i < number_of_points; i++)
            {
                System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // измеритель времени, для каждой точки
                swatch.Start();
                double x = left_border_of_range + i * dx;
                double F = f(x, N);
                //double benchmark = Math.Pow(1.0 + x, (1.0 / 3.0));
                double absoluteError = Math.Abs((F - benchmark(x)));
                double relativeError = Math.Abs((F - benchmark(x)) / benchmark(x));
                swatch.Stop();
                long t = swatch.ElapsedMilliseconds;
                dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
            }
            dest_file_writer.Close();
        }

        static void makeErrorPlot(string source_csv_file_name)
        //немного магии от разработчиков .Net, по которой нет ни одного приличного гайда в сети. Нужно осознать.
        {
            TextFieldParser parser = new TextFieldParser(source_csv_file_name); //обрабатываем .csv файл
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(";");
            var errorChart = new Chart();
            var relativeErrorChart = new Chart();

            errorChart.Series.Add("absolute_error");
            relativeErrorChart.Series.Add("relative_error");

            string headers = parser.ReadLine();
            var x_coordinates = new List<double>();
            while (!parser.EndOfData)
            {
                string[] fields = parser.ReadFields();
                errorChart.Series["absolute_error"].Points.AddXY(Convert.ToDouble(fields[0]), Convert.ToDouble(fields[1])); //добавляем точки на график
                relativeErrorChart.Series["relative_error"].Points.AddXY(Convert.ToDouble(fields[0]), Convert.ToDouble(fields[2]));
            }
            errorChart.Series["absolute_error"].ChartType = SeriesChartType.Line;
            errorChart.Series["absolute_error"].Color = System.Drawing.Color.Red;            
            errorChart.Series["absolute_error"].BorderWidth = 7;
            errorChart.Height = 1000;
            errorChart.Width = 1000;
            errorChart.ChartAreas.Add("NewChartArea");
            errorChart.Series["absolute_error"].ChartArea = "NewChartArea";

            String path = source_csv_file_name.Replace("csv\\", "$").Split('$')[0];
            String absoluteErrorFolder = path + "absolute_error_plots";
            if (!System.IO.Directory.Exists(absoluteErrorFolder))
                System.IO.Directory.CreateDirectory(absoluteErrorFolder);
            errorChart.SaveImage(source_csv_file_name.Replace("csv\\", "absolute_error_plots\\").Replace(".csv", ".png"), ChartImageFormat.Png);

            relativeErrorChart.Series["relative_error"].ChartType = SeriesChartType.FastLine;
            relativeErrorChart.Series["relative_error"].Color = System.Drawing.Color.Green;

            relativeErrorChart.Series["relative_error"].BorderWidth = 7;
            relativeErrorChart.Height = 1000;
            relativeErrorChart.Width = 1000;
            relativeErrorChart.ChartAreas.Add("NewRelativeChartArea");
            relativeErrorChart.Series["relative_error"].ChartArea = "NewRelativeChartArea";

            String relativeErrorFolder = path + "relative_error_plots";
            if (!System.IO.Directory.Exists(relativeErrorFolder))
                System.IO.Directory.CreateDirectory(relativeErrorFolder);
            relativeErrorChart.SaveImage(source_csv_file_name.Replace("csv\\", "relative_error_plots\\").Replace(".csv", ".png"), ChartImageFormat.Png);
        }

        static void makeErrorPlots(string source_csv_folder_name) //в директории не должно быть лишнего, считаем, что там только csv, притом нужного формата
        {
            foreach (String source_csv_file_name in System.IO.Directory.GetFiles(source_csv_folder_name))
                makeErrorPlot(source_csv_file_name);
        }


    }

    public class MyBenchmark
    {

        public static double Math_1_2_benchmark(double x)
        {
            return Math.Pow(1 + x, 1.0 / 3.0);
        }
        public static double Math_2_2_benchmark(double x)
        {
            return Math.Pow(1 - x, 1.0 / 3.0);
        }
        public static double Math_3_2_benchmark(double x)
        {
            return Math.Pow(1 + x, 1.0 / 2.0);
        }
        public static double Math_4_2_benchmark(double x)
        {
            return Math.Pow(1 - x, 1.0 / 2.0);
        }
        public static double Math_5_2_benchmark(double x)
        {
            return Math.Pow(1 + x, 1.0 / 4.0);
        }
        public static double Math_6_2_benchmark(double x)
        {
            return Math.Pow(1 - x, 1.0 / 4.0);
        }
        public static double Math_7_2_benchmark(double x)
        {
            return Math.Pow(1 + x, -1);
        }
        public static double Math_8_2_benchmark(double x)
        {
            return Math.Pow(1 - x, -1);
        }
        public static double Math_9_2_benchmark(double x)
        {
            return Math.Pow(1 + x, -2);
        }
        public static double Math_10_2_benchmark(double x)
        {
            return Math.Pow(1 - x, -2);
        }
        public static double Math_11_2_benchmark(double x)
        {
            return Math.Pow(1 + x, -3);
        }
        public static double Math_12_2_benchmark(double x)
        {
            return Math.Pow(1 - x, -3);
        }
        public static double Math_13_2_benchmark(double x)
        {
            return Math.Pow(1 + x, -4);
        }
        public static double Math_14_2_benchmark(double x)
        {
            return Math.Pow(1 - x, -4);
        }
        public static double Math_15_2_benchmark(double x)
        {
            return Math.Pow(1 + x, -1.0 / 2.0);
        }
        public static double Math_16_2_benchmark(double x)
        {
            return Math.Pow(1 - x, -1.0 / 2.0);
        }
        public static double Math_17_2_benchmark(double x)
        {
            return Math.Pow(1 + x, -1.0 / 3.0);
        }
        public static double Math_18_2_benchmark(double x)
        {
            return Math.Pow(1 - x, -1.0 / 3.0);
        }
        public static double Math_19_2_benchmark(double x)
        {
            return Math.Pow(1 + x, -1.0 / 4.0);
        }
        public static double Math_20_2_benchmark(double x)
        {
            return Math.Pow(1 - x, -1.0 / 4.0);
        }
    }
}


