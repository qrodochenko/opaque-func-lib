using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionsLibrary;
using System.Windows.Forms.DataVisualization.Charting; //консольное приложение не имеет ссылки сюда само по себе. Нужно добавить её через меню "Добавить->Ссылка->Платформа".
//System.Windows.Forms + System.Windows.Forms.DataVisualization + System.Drawing
using Microsoft.VisualBasic.FileIO; //то же самое, нужно для обработки .csv

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {


            int N = 100;
            double A = 1;
            double B = 1;
            MakeResultsSummaryFile("Cinterval_1", Cinterval_ww_finfin_1.interval_ww_finfin_1, N);
            MakeResultsSummaryFile("Cinterval_2", Cinterval_ww_finfin_2.interval_ww_finfin_2, N);
            MakeResultsSummaryFile("Cinterval_3", Cinterval_ww_finfin_3.interval_ww_finfin_3, A, B);
            MakeResultsSummaryFile("Cinterval_4", Cinterval_ww_finfin_4.interval_ww_finfin_4, N);
            MakeResultsSummaryFile("Cinterval_5", Cinterval_ww_finfin_5.interval_ww_finfin_5, N);


            string offset = "..\\..\\..\\"; // чтобы выходные файлы оказались точно в папке с фамилией  
            string source_csv_folder_name = offset + "csv"; // пусть папка для файлов с отчётами .csv называется так.
            makeErrorPlots(source_csv_folder_name);


        }

        static void MakeResultsSummaryFile(string funcname, Func<double, double> f, int N)
        {
            string dest_folder = ("..\\..\\..\\csv\\");
            string dest = dest_folder + funcname + "_N" + N.ToString() + ".csv";
            if(!System.IO.Directory.Exists(dest_folder))
            {
                System.IO.Directory.CreateDirectory(dest_folder);
            }
            System.IO.StreamWriter dest_file_writer =
               new System.IO.StreamWriter(dest);
            dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");
            double left_border_of_range = -100.0;
            double right_border_of_range = 100.0;
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 200;
            double dx = range_length / number_of_points;
            for (int i = 1; i < number_of_points; i++)
            {
                System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
                swatch.Start();
                double x = left_border_of_range + i * dx;
                double F = f(x);
                double benchmark = Math.Pow(1.0 + x, (1.0 / 3.0));
                double absoluteError = Math.Abs((F - benchmark));
                double relativeError = Math.Abs((F - benchmark) / benchmark);
                swatch.Stop();
                long t = swatch.ElapsedMilliseconds;
                if (relativeError.ToString() == "∞")
                {
                    dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + "NaN" + ';' + t.ToString());
                }
                else
                {
                    dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
                }
            }

            

        }

        static void MakeResultsSummaryFile(string funcname, Func<double, double, double, double> f, double A, double B)
        {
            string dest_folder = ("..\\..\\..\\csv\\");
            string dest = dest_folder + funcname + "_A" + A.ToString() + "_B" + B.ToString() + ".csv";
            System.IO.StreamWriter dest_file_writer =
               new System.IO.StreamWriter(dest);
            dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");
            double left_border_of_range = -100.0;
            double right_border_of_range = 100.0;
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 200;
            double dx = range_length / number_of_points;
            for (int i = 1; i < number_of_points; i++)
            {
                System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
                swatch.Start();
                double x = left_border_of_range + i * dx;
                double F = f(x, A, B);
                double benchmark = Math.Pow(1.0 + x, (1.0 / 3.0));
                double absoluteError = Math.Abs((F - benchmark));
                double relativeError = Math.Abs((F - benchmark) / benchmark);
                swatch.Stop();
                long t = swatch.ElapsedMilliseconds;
                if (x == 64)
                {
                    int g = 0;
                }
                if (relativeError.ToString() == "∞")
                {
                    dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + "NaN" + ';' + t.ToString());
                }
                else
                {
                    dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
                }
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
                if (fields.Length > 3)
                {
                    errorChart.Series["absolute_error"].Points.AddXY(Convert.ToDouble(fields[0]), Convert.ToDouble(fields[1])); //добавляем точки на график
                    relativeErrorChart.Series["relative_error"].Points.AddXY(Convert.ToDouble(fields[0]), Convert.ToDouble(fields[2]));
                }
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
