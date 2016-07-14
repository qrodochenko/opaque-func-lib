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
            double A = 1;
            double B = 1;
            MakeResultsSummaryFile("Cinterval_1", Cinterval_ww_finfin_1.interval_ww_finfin_1);
            MakeResultsSummaryFile("Cinterval_2", Cinterval_ww_finfin_2.interval_ww_finfin_2);
            MakeResultsSummaryFile("Cinterval_3", Cinterval_ww_finfin_3.interval_ww_finfin_3, A, B);
            MakeResultsSummaryFile("Cinterval_4", Cinterval_ww_finfin_4.interval_ww_finfin_4);
            MakeResultsSummaryFile("Cinterval_5", Cinterval_ww_finfin_5.interval_ww_finfin_5);

            string offset = "..\\..\\..\\"; // чтобы выходные файлы оказались точно в папке с фамилией  
            string source_csv_folder_name = offset + "csv"; // пусть папка для файлов с отчётами .csv называется так.
            makeFunctionPlots(source_csv_folder_name);

        }

        static void MakeResultsSummaryFile(string funcname, Func<double, double> f)
        {
            string dest_folder = ("..\\..\\..\\csv\\");
            string dest = dest_folder + funcname + ".csv";
            if(!System.IO.Directory.Exists(dest_folder))
            {
                System.IO.Directory.CreateDirectory(dest_folder);
            }
            System.IO.StreamWriter dest_file_writer =
               new System.IO.StreamWriter(dest);
            dest_file_writer.WriteLine("x" + ';' + "y" + ';' + "computation time (milliseconds)");
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
                swatch.Stop();
                long t = swatch.ElapsedMilliseconds;
                dest_file_writer.WriteLine(x.ToString() + ';' + F.ToString() + ';' + t.ToString());
            }

            

        }

        static void MakeResultsSummaryFile(string funcname, Func<double, double, double, double> f, double A, double B)
        {
            string dest_folder = ("..\\..\\..\\csv\\");
            string dest = dest_folder + funcname + "_A" + A.ToString() + "_B" + B.ToString() + ".csv";
            System.IO.StreamWriter dest_file_writer =
               new System.IO.StreamWriter(dest);
            dest_file_writer.WriteLine("x" + ';' + "y" + ';' + "computation time (milliseconds)");
            double left_border_of_range = -100.0;
            double right_border_of_range = 100.0;
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 200;
            double dx = range_length / number_of_points;
            for (int i = 1; i < number_of_points; i++)
            {
                System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); 
                swatch.Start();
                double x = left_border_of_range + i * dx;
                double F = f(x, A, B);
                swatch.Stop();
                long t = swatch.ElapsedMilliseconds;
                dest_file_writer.WriteLine(x.ToString() + ';' + F.ToString() + ';'  + t.ToString());
             
            }    

        }


        static void makeFunctionPlot(string source_csv_file_name)
        //немного магии от разработчиков .Net, по которой нет ни одного приличного гайда в сети. Нужно осознать.
        {
            TextFieldParser parser = new TextFieldParser(source_csv_file_name); //обрабатываем .csv файл
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(";");
            var functionPlotChart = new Chart();

            functionPlotChart.Series.Add("function_value");

            string headers = parser.ReadLine();
            var x_coordinates = new List<double>();
            while (!parser.EndOfData)
            {
                string[] fields = parser.ReadFields();
                if (fields.Length>2)
                    functionPlotChart.Series["function_value"].Points.AddXY(Convert.ToDouble(fields[0]), Convert.ToDouble(fields[1])); //добавляем точки на график
            }
            functionPlotChart.Series["function_value"].ChartType = SeriesChartType.FastLine;
            functionPlotChart.Series["function_value"].Color = System.Drawing.Color.Green;
            functionPlotChart.Series["function_value"].BorderWidth = 7; 
            functionPlotChart.Height = 1000;
            functionPlotChart.Width = 1000;
            functionPlotChart.ChartAreas.Add("NewChartArea");
            functionPlotChart.Series["function_value"].ChartArea = "NewChartArea";

            String path = source_csv_file_name.Replace("csv\\", "$").Split('$')[0];
            String functionPlotFolder = path + "functions_plots";
            if (!System.IO.Directory.Exists(functionPlotFolder))
                System.IO.Directory.CreateDirectory(functionPlotFolder);
            functionPlotChart.SaveImage(source_csv_file_name.Replace("csv\\", "functions_plots\\").Replace(".csv", ".png"), ChartImageFormat.Png);
        }

        static void makeFunctionPlots(string source_csv_folder_name) //в директории не должно быть лишнего, считаем, что там только csv, притом нужного формата
        {
            foreach (String source_csv_file_name in System.IO.Directory.GetFiles(source_csv_folder_name))
                makeFunctionPlot(source_csv_file_name);
        }

    }

}
