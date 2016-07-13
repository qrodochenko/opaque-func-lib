using System;
using OpaqueFunctions;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting; //консольное приложение не имеет ссылки сюда само по себе. Нужно добавить её через меню "Добавить->Ссылка->Платформа".
//System.Windows.Forms + System.Windows.Forms.DataVisualization + System.Drawing
using Microsoft.VisualBasic.FileIO; //то же самое, нужно для обработки .csv
namespace SummerPractice_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int n = 5;
            MakeResultsSummaryFile("LOX_1_1_sin_arcsin", CLOX_1_1_sin_arcsin.LOX_1_1_sin_arcsin, -1, 1);
            MakeResultsSummaryFile("LOX_2_1_cos_arccos", CLOX_2_1_cos_arccos.LOX_2_1_cos_arccos, -1, 1);
            MakeResultsSummaryFile("LOX_3_1_tg_arctg", CLOX_3_1_tg_arctg.LOX_3_1_tg_arctg, -1, 1);
            MakeResultsSummaryFile("LOX_4_1_ctg_arcctg", CLOX_4_1_ctg_arcctg.LOX_4_1_ctg_arcctg, -1, 1);
            MakeResultsSummaryFile("LOX_5_1_arcsin_sin", CLOX_5_1_arcsin_sin.LOX_5_1_arcsin_sin, -1, 1);
            MakeResultsSummaryFile("LOX_6_1_arccos_cos", CLOX_6_1_arccos_cos.LOX_6_1_arccos_cos, 0, 1);
            MakeResultsSummaryFile("LOX_7_1_arctg_tg", CLOX_7_1_arctg_tg.LOX_7_1_arctg_tg, -1, 1);
            MakeResultsSummaryFile("LOX_8_1_arcctg_ctg", CLOX_8_1_arcctg_ctg.LOX_8_1_arcctg_ctg, 0, Math.PI);
            MakeResultsSummaryFile("LOX_9_2_xpowy_xpown_1divn", CLOX_9_2_xpowy_xpown_1divn.LOX_9_2_xpowy_xpown_1divn, n);
            MakeResultsSummaryFile("LOX_10_2_xpown_xpown_1divn", CLOX_10_2_xpown_xpown_1divn.LOX_10_2_xpown_xpown_1divn, n);
            MakeResultsSummaryFile("LOX_11_2_logax_apowx", CLOX_11_2_logax_apowx.LOX_11_2_logax_apowx, a);
            MakeResultsSummaryFile("LOX_12_2_xpowy_logax", CLOX_12_2_xpowy_logax.LOX_12_2_xpowy_logax, a);
            MakeResultsSummaryFile("LOX_13_1_lnx_epowx", CLOX_13_1_lnx_epowx.LOX_13_1_lnx_epowx, -1, 1);
            MakeResultsSummaryFile("LOX_14_1_xpowy_lnx", CLOX_14_1_xpowy_lnx.LOX_14_1_xpowy_lnx, -1, 1);
            MakeResultsSummaryFile("LOX_15_1_sh_arsh", CLOX_15_1_sh_arsh.LOX_15_1_sh_arsh, -1, 1);
            MakeResultsSummaryFile("LOX_16_1_arsh_sh", CLOX_16_1_arsh_sh.LOX_16_1_arsh_sh, -1, 1);
            MakeResultsSummaryFile("LOX_17_1_ch_arch", CLOX_17_1_ch_arch.LOX_17_1_ch_arch, 1, 5);
            MakeResultsSummaryFile("LOX_18_1_arch_ch", CLOX_18_1_arch_ch.LOX_18_1_arch_ch, 0, 1);
            MakeResultsSummaryFile("LOX_19_1_th_arth", CLOX_19_1_th_arth.LOX_19_1_th_arth, -1, 1);
            MakeResultsSummaryFile("LOX_20_1_arth_th", CLOX_20_1_arth_th.LOX_20_1_arth_th, 1, 2);
            MakeResultsSummaryFile("LOX_21_1_cth_arcth", CLOX_21_1_cth_arcth.LOX_21_1_cth_arcth, 1, 5);
            MakeResultsSummaryFile("LOX_22_1_arcth_cth", CLOX_22_1_arcth_cth.LOX_22_1_arcth_cth, -1, 1);
            string offset = "..\\..\\..\\..\\"; // чтобы выходные файлы оказались точно в папке с фамилией  
            string source_csv_folder_name = offset + "csv"; // пусть папка для файлов с отчётами .csv называется так.
            makeErrorPlots(source_csv_folder_name);
        }

        static void MakeResultsSummaryFile(string funcname, Func<double, double> f, double left_border_of_range, double right_border_of_range)
        {
            //генерирует файл .csv нужного формата
            string dest_folder = ("..\\..\\..\\..\\csv\\");
            //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
            string dest = dest_folder + funcname + ".csv";
            if (!System.IO.Directory.Exists(dest_folder))
            {
                System.IO.Directory.CreateDirectory(dest_folder);
            }
            System.IO.StreamWriter dest_file_writer =
               new System.IO.StreamWriter(dest);
            dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");
            //мы хотим равномерно покрыть область определения (или хорошей сходимости) функции number_of_points точками. Подойдите к выбору области аккуратно.
            right_border_of_range -= 1e-2; //чтобы не достигать 1
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 200;
            double dx = range_length / number_of_points;
            for (int i = 1; i < number_of_points; i++)
            {
                System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // измеритель времени, для каждой точки
                swatch.Start();
                double x = left_border_of_range + i * dx;
                double F = f(x);
                double benchmark = x;
                double absoluteError = Math.Abs((F - benchmark));
                double relativeError = Math.Abs((F - benchmark) / benchmark);
                swatch.Stop();
                long t = swatch.ElapsedMilliseconds;
                dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
            }
            dest_file_writer.Close();
        }

        static void MakeResultsSummaryFile(string funcname, Func<double, int, double> f, int a)
        {
            //генерирует файл .csv нужного формата
            string dest_folder = ("..\\..\\..\\..\\csv\\");
            //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
            string dest = dest_folder + funcname + "_a" + a.ToString() + ".csv";
            if(!System.IO.Directory.Exists(dest_folder))
            {
                System.IO.Directory.CreateDirectory(dest_folder);
            }
            System.IO.StreamWriter dest_file_writer =
               new System.IO.StreamWriter(dest);
            dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");
            //мы хотим равномерно покрыть область определения (или хорошей сходимости) функции number_of_points точками. Подойдите к выбору области аккуратно.
            double left_border_of_range = 1.0;
            double right_border_of_range = 2.0;
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 200;
            double dx = range_length / number_of_points;
            for (int i = 1; i < number_of_points; i++)
            {
                System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // измеритель времени, для каждой точки
                swatch.Start();
                double x = left_border_of_range + i * dx;
                double F = f(x, a);
                double benchmark = x;
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





            /*double N = 10000000;
            double K = 0;
            double L = 0;
            for (double i = 1; i < N; i++)
            {
                K += 1/i;

            }
            Console.WriteLine(K);
            for (double i = 1; i <= N; i++)
            {
                L = L + 1/(N - i + 1);

            }
            Console.WriteLine(L);
            proverka();
            Console.ReadKey();
             */
            ///Random random = new Random();
            ///double param = 0.9;
            ///Console.WriteLine(OpaqueFunctions.CLOX_21_1.LOX_21_1(param));
            ///Console.ReadKey();
            ///double eps;
            ///double F = CLOX_21_1.LOX_21_1(param);
            ///eps = Math.Abs(F - param);
            ///Console.WriteLine(param.ToString() + ' ' + eps.ToString());
            ///Console.ReadKey();
        

        /* static void proverka()

         {
             Console.WriteLine("Summer Practice! Yay!");
             Console.ReadKey();
             float N = 10000000;
             float K = 0;
             float L = 0;
             for (float i = 1; i <= N; i++)
             {
                 K = K + 1 / i;

             }
             Console.WriteLine(K);
             for (float i = 1; i <= N; i++)
             {
                 L = L + 1/(N - i + 1);

             }
             Console.WriteLine(L);







         }*/

    
}
