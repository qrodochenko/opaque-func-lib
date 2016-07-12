using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting; //консольное приложение не имеет ссылки сюда само по себе. Нужно добавить её через меню "Добавить->Ссылка->Платформа".
//System.Windows.Forms + System.Windows.Forms.DataVisualization + System.Drawing
using Microsoft.VisualBasic.FileIO; //то же самое, нужно для обработки .csv
using OpaqueFunctions;
using System.Windows.Forms;

namespace SummerPractice_2016
{
    class Program
    {
        static void Main(string[] args) {
            string offset = "D:\\student\\Рабочий стол\\repo\\opaque-func-lib\\Vedenev\\"; // чтобы выходные файлы оказались точно в папке с фамилией  
            MakeResultsSummaryFile("L00_58_2_arctg_arcctg_2", CL00_58_2_arctg_arcctg.Body, 1);
            MakeResultsSummaryFile("L00_59_2_arctg_arccos_2", CL00_59_2_arctg_arccos.Body, 1);
            MakeResultsSummaryFile("L00_60_2_arcctg_arccos_2", CL00_60_2_arcctg_arccos.Body, 1);
            MakeResultsSummaryFile("L00_61_2_arcctg_arccos_2", CL00_61_2_arcctg_arccos.Body, 1);
            MakeResultsSummaryFile("L00_62_2_arctg_arcsin_2", CL00_62_2_arcctg_arcsin.Body, 1);
            MakeResultsSummaryFile("L00_63_2_cos_2", CL00_63_2_cos.Body, 1);
            MakeResultsSummaryFile("L00_64_2_cos_sin_2", CL00_64_2_cos_sin.Body, 1);
            MakeResultsSummaryFile("L00_65_2_tg_2", CL00_65_2_tg.Body, 1);
            MakeResultsSummaryFile("L00_67_2_ch_sh_2", CL00_67_2_ch_sh.Body, 1);
            MakeResultsSummaryFile("L00_68_2_th_sh_ch_2", CL00_68_2_th_sh_ch.Body, 1);
            MakeResultsSummaryFile("L00_69_2_cth_sh_ch_2", CL00_69_2_cth_sh_ch.Body, 1);
            MakeResultsSummaryFile("L00_70_2_sch_ch_2", CL00_70_2_sch_ch.Body, 1);
            MakeResultsSummaryFile("L00_71_2_sch_ch_2", CL00_71_2_sch_ch.Body, 1);
            MakeResultsSummaryFile("L00_83_2_sh_ch_2", CL00_83_2_sh_ch.Body, 1);
            MakeResultsSummaryFile("L00_84_2_cth_2", CL00_84_2_cth.Body, 1);
            MakeResultsSummaryFile("L00_85_2_sh_ch_2", CL00_85_2_sh_ch.Body, 1);
            string source_csv_folder_name = offset + "csv"; // пусть папка для файлов с отчётами .csv называется так.
            makeErrorPlots(source_csv_folder_name);             
        }

        static void MakeResultsSummaryFile(string funcname, Func<double,int,double> f, int N)
        {
            //генерирует файл .csv нужного формата
            string dest_folder = ("D:\\student\\Рабочий стол\\repo\\opaque-func-lib\\Vedenev\\csv\\");
            //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
            string dest = dest_folder + funcname + "_N" + N.ToString() + ".csv"; 
            System.IO.StreamWriter dest_file_writer =
               new System.IO.StreamWriter(dest);
            dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");
            //мы хотим равномерно покрыть область определения (или хорошей сходимости) функции number_of_points точками. Подойдите к выбору области аккуратно.
            double left_border_of_range = 0.1;
            double right_border_of_range = 10;
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 200;
            double dx = range_length / number_of_points;
            for (int i = 1; i < number_of_points; i++)
            {
                System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // измеритель времени, для каждой точки
                swatch.Start();
                double x = left_border_of_range + i * dx;
                double F = f(x, N);
                double benchmark = 0;
                double absoluteError = Math.Abs((F - benchmark));
                double relativeError = 0;//Math.Abs((F - benchmark) / benchmark);
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

