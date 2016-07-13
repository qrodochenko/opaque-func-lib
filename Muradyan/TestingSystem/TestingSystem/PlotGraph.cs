using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.VisualBasic.FileIO; //то же самое, нужно для обработки .csv
using System.IO;

namespace TestingSystem
{
    class PlotGraph {
        public static void makeErrorPlot(string source_csv_file_name)
        //немного магии от разработчиков .Net, по которой нет ни одного приличного гайда в сети. Нужно осознать.
        {
            var absDir = Path.GetDirectoryName(Path.GetFullPath(source_csv_file_name));
            var filename = Path.GetFileNameWithoutExtension(Path.GetFullPath(source_csv_file_name)) + ".png";

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

                var myf1 = Double.IsInfinity(Convert.ToDouble(fields[2])) ? Double.NaN : Convert.ToDouble(fields[2]);
                var myf2 = Double.IsInfinity(Convert.ToDouble(fields[6])) ? Double.NaN : Convert.ToDouble(fields[6]);
                errorChart.Series["absolute_error"].Points.AddXY(myf1, myf2); //добавляем точки на график
                
                myf2 = Double.IsInfinity(Convert.ToDouble(fields[7])) ? Double.NaN : Convert.ToDouble(fields[7]);
                relativeErrorChart.Series["relative_error"].Points.AddXY(myf1, myf2);
            }
            errorChart.Series["absolute_error"].ChartType = SeriesChartType.FastLine;
            errorChart.Series["absolute_error"].Color = System.Drawing.Color.Red;
            errorChart.Height = 1000;
            errorChart.Width = 1000;
            errorChart.ChartAreas.Add("NewChartArea");
            errorChart.Series["absolute_error"].ChartArea = "NewChartArea";

            Directory.CreateDirectory(absDir+"\\abs_err_plots\\");
            errorChart.SaveImage(absDir+"\\abs_err_plots\\"+filename, ChartImageFormat.Png);

            relativeErrorChart.Series["relative_error"].ChartType = SeriesChartType.FastLine;
            relativeErrorChart.Series["relative_error"].Color = System.Drawing.Color.Green;
            relativeErrorChart.Height = 1000;
            relativeErrorChart.Width = 1000;
            relativeErrorChart.ChartAreas.Add("NewRelativeChartArea");
            relativeErrorChart.Series["relative_error"].ChartArea = "NewRelativeChartArea";

            Directory.CreateDirectory(absDir + "\\rel_err_plots\\");
            errorChart.SaveImage(absDir+"\\rel_err_plots\\"+filename, ChartImageFormat.Png);
        }

        public static void makeErrorPlots(string source_csv_folder_name) //в директории не должно быть лишнего, считаем, что там только csv, притом нужного формата
        {
            foreach (String source_csv_file_name in System.IO.Directory.GetFiles(source_csv_folder_name))
            {
                try
                {
                    makeErrorPlot(source_csv_file_name);
                }
                catch(Exception e)
                {
                    Console.WriteLine(source_csv_file_name+" was not plotted: " + e.Message);
                }
            }
        }
    }
}
