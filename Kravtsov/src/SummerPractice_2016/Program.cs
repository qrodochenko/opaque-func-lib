using System;
using System.Collections.Generic;
using OpaqueFunctions;
using System.Windows.Forms.DataVisualization.Charting; //консольное приложение не имеет ссылки сюда само по себе. Нужно добавить её через меню "Добавить->Ссылка->Платформа".
//System.Windows.Forms + System.Windows.Forms.DataVisualization + System.Drawing
using Microsoft.VisualBasic.FileIO; //то же самое, нужно для обработки .csv
namespace SummerPractice_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeResultsSummaryFile("Sin_1", CSin_1.Sin_1, Program.Sin_1_bechmark, -Math.PI / 2.0 + 1e-3, Math.PI / 2.0 - 1e-3, 10);
            MakeResultsSummaryFile("Cos_1", CCos_1.Cos_1, Program.Cos_1_bechmark, -Math.PI + 1e-3, Math.PI - 1e-3, 10);
            MakeResultsSummaryFile("Arcsin_1", CArcsin_1.Arcsin_1, Program.Arcsin_1_bechmark, -1.0 + 1e-3, 1.0 - 1e-3, 4000000);
            MakeResultsSummaryFile("Arccos_1", CArccos_1.Arccos_1, Program.Arccos_1_bechmark, -1.0 + 1e-3, 1.0 - 1e-3, 4000000);
            MakeResultsSummaryFile("Tg_1", CTg_1.Tg_1, Program.Tg_1_bechmark, -Math.PI / 2.0 + 1e-3, Math.PI / 2.0 - 1e-3, 10);
            MakeResultsSummaryFile("Ctg_1", Cctg_1.Сtg_1, Program.Ctg_1_bechmark, 0.0 + 1e-3, Math.PI - 1e-3, 10);
            MakeResultsSummaryFile("Arctg_1", CArctg_1.Arctg_1, Program.Arctg_1_bechmark, -1.0, 1.0, 4000000);
            MakeResultsSummaryFile("Arcctg_1", CArcctg_1.Arcctg_1, Program.Arcctg_1_bechmark, -1.0 + 1e-3, 1.0 - 1e-3, 4000000);
            MakeResultsSummaryFile("Cosec_1", CCosec_1.Cosec_1, Program.Cosec_1_bechmark, -Math.PI + 1e-3, Math.PI - 1e-3, 12);
            MakeResultsSummaryFile("XPow2_Sin_1", CXpow2_Sin_1.Xpow2_Sin_1, Program.Xpow2_Sin_1_bechmark, -Math.PI / 2.0 + 1e-3, Math.PI / 2.0 - 1e-3, 20);
            MakeResultsSummaryFile("XPow2_Cos_1", CXpow2_Cos_1.Xpow2_Cos_1, Program.Xpow2_Cos_1_bechmark, -Math.PI + 1e-3, Math.PI - 1e-3, 20);
            MakeResultsSummaryFile("XPow3_Sin_1", CXpow3_Sin_1.Xpow3_Sin_1, Program.Xpow3_Sin_1_bechmark, -Math.PI / 2.0 + 1e-3, Math.PI / 2.0 - 1e-3, 20);
            MakeResultsSummaryFile("XPow3_Cos_1", CXpow3_Cos_1.Xpow3_Cos_1, Program.Xpow3_Cos_1_bechmark, -Math.PI + 1e-3, Math.PI - 1e-3, 20);
            string offset = "..\\..\\..\\..\\"; // чтобы выходные файлы оказались точно в папке с фамилией  
            string source_csv_folder_name = offset + "csv"; // пусть папка для файлов с отчётами .csv называется так.
            makeErrorPlots(source_csv_folder_name);
        }
     
        static double Sin_1_bechmark(double x)
        {
            return Math.Sin(x);
        }
        static double Cos_1_bechmark(double x)
        {
            return Math.Cos(x);
        }
        static double Arcsin_1_bechmark(double x)
        {
            return Math.Asin(x);
        }
        static double Arccos_1_bechmark(double x)
        {
            return Math.Acos(x);
        }
        static double Tg_1_bechmark(double x)
        {
            return Math.Tan(x);
        }
        static double Ctg_1_bechmark(double x)
        {
            return 1 / Math.Tan(x);
        }
        static double Arctg_1_bechmark(double x)
        {
            return Math.Atan(x);
        }
        static double Arcctg_1_bechmark(double x)
        {
            return Math.PI / 2.0 - Math.Atan(x);
        }
        static double Cosec_1_bechmark(double x)
        {
            return 1 / Math.Sin(x);
        }
        static double Xpow2_Sin_1_bechmark(double x)
        {
            return Math.Sin(x) * Math.Sin(x);
        }
        static double Xpow2_Cos_1_bechmark(double x)
        {
            return Math.Cos(x) * Math.Cos(x);
        }
        static double Xpow3_Sin_1_bechmark(double x)
        {
            return Math.Sin(x) * Math.Sin(x) * Math.Sin(x);
        }
        static double Xpow3_Cos_1_bechmark(double x)
        {
            return Math.Cos(x) * Math.Cos(x) * Math.Cos(x);
        }
    
        static void MakeResultsSummaryFile(string funcname, Func<double, int, double> f, Func<double, double> benchmark, double left_border_of_range, double right_border_of_range, int N)
        {
            //генерирует файл .csv нужного формата
            string dest_folder = ("..\\..\\..\\..\\csv\\");
            if(!System.IO.Directory.Exists(dest_folder))
            {
                System.IO.Directory.CreateDirectory(dest_folder);
            }
            //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
            string dest = dest_folder + funcname + "_N" + N.ToString() + ".csv";
            System.IO.StreamWriter dest_file_writer =
               new System.IO.StreamWriter(dest);
            dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");
            //мы хотим равномерно покрыть область определения (или хорошей сходимости) функции number_of_points точками. Подойдите к выбору области аккуратно.
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 200;
            double dx = range_length / number_of_points;
            for (int i = 1; i < number_of_points; i++)
            {
                System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // измеритель времени, для каждой точки
                swatch.Start();
                double x = left_border_of_range + i * dx;
                double F = f(x, N);
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
            errorChart.Series["absolute_error"].ChartType = SeriesChartType.FastLine;
            errorChart.Series["absolute_error"].Color = System.Drawing.Color.Red;
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

}
        
















