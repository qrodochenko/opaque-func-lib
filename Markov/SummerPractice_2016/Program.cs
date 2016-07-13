#define DEBUG
using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting; //консольное приложение не имеет ссылки сюда само по себе. Нужно добавить её через меню "Добавить->Ссылка->Платформа".
//System.Windows.Forms + System.Windows.Forms.DataVisualization + System.Drawing
using Microsoft.VisualBasic.FileIO; //то же самое, нужно для обработки .csv
using OpaqueFunctions;
namespace SummerPractice_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            string offset = (@"D:\SummerPractice_2016\"); // чтобы выходные файлы оказались точно в папке с фамилией  
            string source_csv_folder_name = offset + "csv"; // пусть папка для файлов с отчётами .csv называется так.
            MakeResultsSummaryFile_1_1_count("Sin_1", CSin_1.Sin_1, Math.Sin, 50);
            MakeResultsSummaryFile_1_1_er("Sin_2", CSin_2.Sin_2, Math.Sin, 1e-30);
            MakeResultsSummaryFile_1_1_count("Cos_3", CCos_3.Cos_3, Math.Cos, 50);
            MakeResultsSummaryFile_1_1_er("Cos_4", CCos_4.Cos_4, Math.Cos, 1e-30);
            MakeResultsSummaryFile_1_1_form_count("Sin_5", CSin_5.Sin_5, Math.Sin, 50);
            MakeResultsSummaryFile_1_1_form_er("Sin_6", CSin_6.Sin_6, Math.Sin, 1e-30);
            MakeResultsSummaryFile_1_1_form_count("Cos_7", CCos_7.Cos_7, Math.Cos, 50);
            MakeResultsSummaryFile_1_1_form_er("Cos_8", CCos_8.Cos_8, Math.Cos, 1e-30);
            MakeResultsSummaryFile_1_1_count("Tg_9", CTg_9.Tg_9, Math.Tan, 15);
            MakeResultsSummaryFile_1_1_er("Tg_10", CTg_10.Tg_10, Math.Tan, 1e-30);
            MakeResultsSummaryFile_0_1_count("Ctg_11", CCtg_11.Ctg_11, Math.Tan, 15);
            MakeResultsSummaryFile_0_1_er("Ctg_12", CCtg_12.Ctg_12, Math.Tan, 1e-30);
            MakeResultsSummaryFile_0_1_count("Cosec_13", CCosec_13.Cosec_13, Math.Sin, 15);
            MakeResultsSummaryFile_0_1_er("Cosec_14", CCosec_14.Cosec_14, Math.Sin, 1e-30);
            MakeResultsSummaryFile_1_1_count_2("Sin_15", CSin_15.Sin_15, Math.Sin, 50);
            MakeResultsSummaryFile_1_1_er_2("Sin_16", CSin_16.Sin_16, Math.Sin, 1e-30);
            MakeResultsSummaryFile_1_1_count_2("Cos_17", CCos_17.Cos_17, Math.Cos, 50);
            MakeResultsSummaryFile_1_1_er_2("Cos_18", CCos_18.Cos_18, Math.Cos, 1e-30);
            MakeResultsSummaryFile_1_1_count_3("Sin_19", CSin_19.Sin_19, Math.Sin, 50);
            MakeResultsSummaryFile_1_1_er_3("Sin_20", CSin_20.Sin_20, Math.Sin, 1e-30);
            MakeResultsSummaryFile_1_1_count_3("Cos_21", CCos_21.Cos_21, Math.Cos, 50);
            MakeResultsSummaryFile_1_1_er_3("Cos_22", CCos_22.Cos_22, Math.Cos, 1e-30);
            makeErrorPlots(source_csv_folder_name);
        }

        static void MakeResultsSummaryFile_1_1_count(string funcname, Func<double, int, double> f, Func<double, double> g, int N)
        {
            //генерирует файл .csv нужного формата
            string dest_folder = (@"D:\SummerPractice_2016\csv\");
            //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
            string dest = dest_folder + funcname + "_N" + N.ToString() + ".csv";
            System.IO.StreamWriter dest_file_writer = new System.IO.StreamWriter(dest);
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
                double benchmark = g(x);
                double absoluteError = Math.Abs((F - benchmark));
                double relativeError = Math.Abs((F - benchmark) / benchmark);
                swatch.Stop();
                long t = swatch.ElapsedMilliseconds;
                dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
            }
            dest_file_writer.Close();
        }

        static void MakeResultsSummaryFile_1_1_er(string funcname, Func<double, double, double, double> f, Func<double, double> g, double er)
        {
            //генерирует файл .csv нужного формата
            string dest_folder = (@"D:\SummerPractice_2016\csv\");
            //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
            string dest = dest_folder + funcname + "_er" + er.ToString() + ".csv";
            System.IO.StreamWriter dest_file_writer = new System.IO.StreamWriter(dest);
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
                double F = f(x, er, 0.8);
                double benchmark = g(x);
                double absoluteError = Math.Abs((F - benchmark));
                double relativeError = Math.Abs((F - benchmark) / benchmark);
                swatch.Stop();
                long t = swatch.ElapsedMilliseconds;
                dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
            }
            dest_file_writer.Close();
        }
        static void MakeResultsSummaryFile_1_1_count_2(string funcname, Func<double, int, double> f, Func<double, double> g, int N)
        {
            //генерирует файл .csv нужного формата
            string dest_folder = (@"D:\SummerPractice_2016\csv\");
            //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
            string dest = dest_folder + funcname + "_N" + N.ToString() + ".csv";
            System.IO.StreamWriter dest_file_writer = new System.IO.StreamWriter(dest);
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
                double benchmark = g(x) * g(x);
                double absoluteError = Math.Abs((F - benchmark));
                double relativeError = Math.Abs((F - benchmark) / benchmark);
                swatch.Stop();
                long t = swatch.ElapsedMilliseconds;
                dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
            }
            dest_file_writer.Close();
        }

        static void MakeResultsSummaryFile_1_1_er_2(string funcname, Func<double, double, double, double> f, Func<double, double> g, double er)
        {
            //генерирует файл .csv нужного формата
            string dest_folder = (@"D:\SummerPractice_2016\csv\");
            //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
            string dest = dest_folder + funcname + "_er" + er.ToString() + ".csv";
            System.IO.StreamWriter dest_file_writer = new System.IO.StreamWriter(dest);
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
                double F = f(x, er, 0.8);
                double benchmark = g(x) * g(x);
                double absoluteError = Math.Abs((F - benchmark));
                double relativeError = Math.Abs((F - benchmark) / benchmark);
                swatch.Stop();
                long t = swatch.ElapsedMilliseconds;
                dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
            }
            dest_file_writer.Close();
        }
        static void MakeResultsSummaryFile_1_1_count_3(string funcname, Func<double, int, double> f, Func<double, double> g, int N)
        {
            //генерирует файл .csv нужного формата
            string dest_folder = (@"D:\SummerPractice_2016\csv\");
            //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
            string dest = dest_folder + funcname + "_N" + N.ToString() + ".csv";
            System.IO.StreamWriter dest_file_writer = new System.IO.StreamWriter(dest);
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
                double benchmark = g(x) * g(x) * g(x);
                double absoluteError = Math.Abs((F - benchmark));
                double relativeError = Math.Abs((F - benchmark) / benchmark);
                swatch.Stop();
                long t = swatch.ElapsedMilliseconds;
                dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
            }
            dest_file_writer.Close();
        }

        static void MakeResultsSummaryFile_1_1_er_3(string funcname, Func<double, double, double, double> f, Func<double, double> g, double er)
        {
            //генерирует файл .csv нужного формата
            string dest_folder = (@"D:\SummerPractice_2016\csv\");
            //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
            string dest = dest_folder + funcname + "_er" + er.ToString() + ".csv";
            System.IO.StreamWriter dest_file_writer = new System.IO.StreamWriter(dest);
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
                double F = f(x, er, 0.8);
                double benchmark = g(x) * g(x) * g(x);
                double absoluteError = Math.Abs((F - benchmark));
                double relativeError = Math.Abs((F - benchmark) / benchmark);
                swatch.Stop();
                long t = swatch.ElapsedMilliseconds;
                dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
            }
            dest_file_writer.Close();
        }
        static void MakeResultsSummaryFile_0_1_count(string funcname, Func<double, int, double> f, Func<double, double> g, int N)
        {
            //генерирует файл .csv нужного формата
            string dest_folder = (@"D:\SummerPractice_2016\csv\");
            //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
            string dest = dest_folder + funcname + "_N" + N.ToString() + ".csv";
            System.IO.StreamWriter dest_file_writer = new System.IO.StreamWriter(dest);
            dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");
            //мы хотим равномерно покрыть область определения (или хорошей сходимости) функции number_of_points точками. Подойдите к выбору области аккуратно.
            double left_border_of_range = 0.0;
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
                double benchmark = 1.0 / g(x);
                double absoluteError = Math.Abs((F - benchmark));
                double relativeError = Math.Abs((F - benchmark) / benchmark);
                swatch.Stop();
                long t = swatch.ElapsedMilliseconds;
                dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
            }
            dest_file_writer.Close();
        }

        static void MakeResultsSummaryFile_0_1_er(string funcname, Func<double, double, double, double> f, Func<double, double> g, double er)
        {
            //генерирует файл .csv нужного формата
            string dest_folder = (@"D:\SummerPractice_2016\csv\");
            //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
            string dest = dest_folder + funcname + "_er" + er.ToString() + ".csv";
            System.IO.StreamWriter dest_file_writer = new System.IO.StreamWriter(dest);
            dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");
            //мы хотим равномерно покрыть область определения (или хорошей сходимости) функции number_of_points точками. Подойдите к выбору области аккуратно.
            double left_border_of_range = 0.0;
            double right_border_of_range = 1.0;
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 200;
            double dx = range_length / number_of_points;
            for (int i = 1; i < number_of_points; i++)
            {
                System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // измеритель времени, для каждой точки
                swatch.Start();
                double x = left_border_of_range + i * dx;
                double F = f(x, er, 0.8);
                double benchmark = 1.0 / g(x);
                double absoluteError = Math.Abs((F - benchmark));
                double relativeError = Math.Abs((F - benchmark) / benchmark);
                swatch.Stop();
                long t = swatch.ElapsedMilliseconds;
                dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
            }
            dest_file_writer.Close();
        }
        static void MakeResultsSummaryFile_1_1_form_count(string funcname, Func<double, int, double, double> f, Func<double, double> g, int N)
        {
            //генерирует файл .csv нужного формата
            string dest_folder = (@"D:\SummerPractice_2016\csv\");
            //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
            string dest = dest_folder + funcname + "_form_N" + N.ToString() + ".csv";
            System.IO.StreamWriter dest_file_writer = new System.IO.StreamWriter(dest);
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
                double F = f(x, N, g(x));
                double benchmark = g(x);
                double absoluteError = Math.Abs((F - benchmark));
                double relativeError = Math.Abs((F - benchmark) / benchmark);
                swatch.Stop();
                long t = swatch.ElapsedMilliseconds;
                dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
            }
            dest_file_writer.Close();
        }
        static void MakeResultsSummaryFile_1_1_form_er(string funcname, Func<double, double, double, double, double> f, Func<double, double> g, double er)
        {
            //генерирует файл .csv нужного формата
            string dest_folder = (@"D:\SummerPractice_2016\csv\");
            //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
            string dest = dest_folder + funcname + "_form_er" + er.ToString() + ".csv";
            System.IO.StreamWriter dest_file_writer = new System.IO.StreamWriter(dest);
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
                double F = f(x, er, g(x), 0.8);
                double benchmark = g(x);
                double absoluteError = Math.Abs((F - benchmark));
                double relativeError = Math.Abs((F - benchmark) / benchmark);
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