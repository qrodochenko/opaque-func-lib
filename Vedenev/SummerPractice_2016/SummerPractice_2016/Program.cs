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
            string offset = "D:\\Vedenev\\"; // чтобы выходные файлы оказались точно в папке с фамилией  
            MakeResultsSummaryFile("L00_58_1_arctg_arcctg", CL00_58_1_arctg_arcctg.Body, 1);
            MakeResultsSummaryFile("L00_59_1_arctg_arccos", CL00_59_1_arctg_arccos.Body, 1);
            MakeResultsSummaryFile("L00_60_1_arcctg_arccos", CL00_60_1_arcctg_arccos.Body, 1);
            MakeResultsSummaryFile("L00_61_1_arcctg_arccos", CL00_61_1_arcctg_arccos.Body, 1);
            MakeResultsSummaryFile("L00_62_1_arctg_arcsin", CL00_62_1_arcctg_arcsin.Body, 1);
            MakeResultsSummaryFile("L00_63_1_cos", CL00_63_1_cos.Body, 1);
            MakeResultsSummaryFile("L00_64_1_cos_sin", CL00_64_1_cos_sin.Body, 1);
            MakeResultsSummaryFile("L00_65_1_tg", CL00_65_1_tg.Body, 1);
            MakeResultsSummaryFile("L00_66_2_tg", CL00_66_2_tg.Body);
            MakeResultsSummaryFile("L00_67_1_ch_sh", CL00_67_1_ch_sh.Body, 1);
            MakeResultsSummaryFile("L00_68_1_th_sh_ch", CL00_68_1_th_sh_ch.Body, 1);
            MakeResultsSummaryFile("L00_69_1_cth_sh_ch", CL00_69_1_cth_sh_ch.Body, 1);
            MakeResultsSummaryFile("L00_70_1_sch_ch", CL00_70_1_sch_ch.Body, 1);
            MakeResultsSummaryFile("L00_71_1_sch_ch", CL00_71_1_sch_ch.Body, 1);
            MakeResultsSummaryFile("L00_72_2_sh_ch", CL00_72_2_sh_ch.Body);
            MakeResultsSummaryFile("L00_73_2_sh_ch", CL00_73_2_sh_ch.Body);
            MakeResultsSummaryFile("L00_74_2_sh_ch", CL00_74_2_sh_ch.Body);
            MakeResultsSummaryFile("L00_75_2_sh_ch", CL00_75_2_sh_ch.Body);
            MakeResultsSummaryFile("L00_76_2_th", CL00_76_2_th.Body);
            MakeResultsSummaryFile("L00_77_2_th", CL00_77_2_th.Body);
            MakeResultsSummaryFile("L00_78_2_cth", CL00_78_2_cth.Body);
            MakeResultsSummaryFile("L00_79_2_cth", CL00_79_2_cth.Body);
            MakeResultsSummaryFile("L00_80_2_sh_ch", CL00_80_2_sh_ch.Body);
            MakeResultsSummaryFile("L00_81_2_sh_ch", CL00_81_2_sh_ch.Body);
            MakeResultsSummaryFile("L00_82_2_sh_ch", CL00_82_2_sh_ch.Body);
            MakeResultsSummaryFile("L00_83_1_sh_ch", CL00_83_1_sh_ch.Body, 1);
            MakeResultsSummaryFile("L00_84_1_cth", CL00_84_1_cth.Body, 1);
            MakeResultsSummaryFile("L00_85_1_sh_ch", CL00_85_1_sh_ch.Body, 1);
            string source_csv_folder_name = offset + "csv"; // пусть папка для файлов с отчётами .csv называется так.
            makeErrorPlots(source_csv_folder_name);             
        }

        static void MakeResultsSummaryFile(string funcname, Func<double,double> f, int N)
        {
            //генерирует файл .csv нужного формата
            string dest_folder = ("D:\\Vedenev\\csv\\");
            //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
            string dest = dest_folder + funcname + ".csv"; 
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
                double F = f(x);
                double benchmark = 0;
                double absoluteError = Math.Abs((F - benchmark));
                double relativeError = 0;//Math.Abs((F - benchmark) / benchmark);
                swatch.Stop();
                long t = swatch.ElapsedMilliseconds;
                dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());                                  
            }
            dest_file_writer.Close();
        }
        static void MakeResultsSummaryFile(string funcname, Func<double,double,double> f) 
        {
            //генерирует файл .csv нужного формата
            string dest_folder = ("D:\\Vedenev\\csv\\");
            //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
            //мы хотим равномерно покрыть область определения (или хорошей сходимости) функции number_of_points точками. Подойдите к выбору области аккуратно.
            double left_border_of_range = 0.1;
            double right_border_of_range = 10;
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 200;
            double dx = range_length / number_of_points;
            double dy = range_length / 10;
            string dest;
            System.IO.StreamWriter dest_file_writer;
            double F;
            for (int j = 1; j < 11; ++j)
            {
                double y = left_border_of_range + j * dy;
                dest = dest_folder + funcname + "_Y" + y.ToString() + ".csv";
                dest_file_writer = new System.IO.StreamWriter(dest);
                dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");            
                for (int i = 1; i < number_of_points; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // измеритель времени, для каждой точки
                    swatch.Start();
                    double x = left_border_of_range + i * dx;
                    try
                    {
                        F = f(x, y);
                    }
                    catch (OpaqueFunctions.OpaqueException e)
                    {
                        F = 0;
                    }
                    double benchmark = 0;
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = 0;//Math.Abs((F - benchmark) / benchmark);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());                    
                }
                dest_file_writer.Close();
            }            
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

