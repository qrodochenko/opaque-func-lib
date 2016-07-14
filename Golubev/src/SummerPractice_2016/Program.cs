using System;
using OpaqueFunctions;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.VisualBasic.FileIO;

namespace SummerPractice_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Summer Practice! Yay!");
            Console.ReadKey();


            System.IO.StreamWriter file1 =
            new System.IO.StreamWriter(@"D:\hello-world\opaque-func-lib\Golubev\csv\priv_sin_2.csv");
            file1.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            double x = -50;
            for (int i = 1; i < 1000; i++)
            {
            
                double step = 1.0 / 10.0;
                x += step;
                double standart = Math.Sin(x);
                OpaqueFunctions.C_build_func func = OpaqueFunctions.Cpriv_sin_2.priv_sin_2(x);
                int sign = 1;
                if (string.Compare(func.sign, "-") == 0)
                    sign = -1;
                double converted = sign * Math.Sin(func.argument);
                double absoluteError = Math.Abs(standart - converted);          
                double relativeError = Math.Abs((standart - converted) / converted);
                file1.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() );
            
            }
            file1.Close();


            System.IO.StreamWriter file6 =
            new System.IO.StreamWriter(@"D:\hello-world\opaque-func-lib\Golubev\csv\priv_cos_2.csv");
            file6.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            x = -50;
            for (int i = 1; i < 1000; i++)
            {

                double step = 1.0 / 10.0;
                x += step;
                double standart = Math.Cos(x);
                OpaqueFunctions.C_build_func func = OpaqueFunctions.Cpriv_cos_2.priv_cos_2(x);
                int sign = 1;
                if (string.Compare(func.sign, "-") == 0)
                    sign = -1;
                double converted = sign * Math.Cos(func.argument);
                double absoluteError = Math.Abs(standart - converted);
                double relativeError = Math.Abs((standart - converted) / converted);
                file6.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file6.Close();

            


            System.IO.StreamWriter file2 =
            new System.IO.StreamWriter(@"D:\hello-world\opaque-func-lib\Golubev\csv\priv_sin_3.csv");
            file2.WriteLine("x" +  ';' + "absoluteError" + ';' + "relativeError");
            x = -50;
            for (int i = 1; i < 1000; i++)
            {

                double step = 1.0 / 10.0;
                x += step;
                double standart = Math.Sin(x);
                OpaqueFunctions.C_build_func func = OpaqueFunctions.Cpriv_sin_3.priv_sin_3(x);
                int sign = 1;
                if (string.Compare(func.sign, "-") == 0)
                    sign = -1;
                double converted;
                if (string.Compare(func.function,"sin")==0)
                    converted = sign * Math.Sin(func.argument);
                else
                    converted = sign * Math.Cos(func.argument);
                double absoluteError = Math.Abs(standart - converted);
                double relativeError = Math.Abs((standart - converted) / converted);
                file2.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() );

            }
            file2.Close();

            System.IO.StreamWriter file3 =
            new System.IO.StreamWriter(@"D:\hello-world\opaque-func-lib\Golubev\csv\priv_cos_3.csv");
            file3.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            x = -50;
            for (int i = 1; i < 1000; i++)
            {

                double step = 1.0 / 10.0;
                x += step;
                double standart = Math.Cos(x);
                OpaqueFunctions.C_build_func func = OpaqueFunctions.Cpriv_cos_3.priv_cos_3(x);
                int sign = 1;
                if (string.Compare(func.sign, "-") == 0)
                    sign = -1;
                double converted;
                if (string.Compare(func.function, "sin") == 0)
                    converted = sign * Math.Sin(func.argument);
                else
                    converted = sign * Math.Cos(func.argument);
                double absoluteError = Math.Abs(standart - converted);
                double relativeError = Math.Abs((standart - converted) / converted);
                file3.WriteLine(x.ToString()+ ';' + absoluteError.ToString() + ';' + relativeError.ToString() );

            }
            file3.Close();

            System.IO.StreamWriter file4 =
            new System.IO.StreamWriter(@"D:\hello-world\opaque-func-lib\Golubev\csv\priv_tan_6.csv");
            file4.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" );
            x = -50;
            for (int i = 1; i < 1000; i++)
            {

                double step = 1.0 / 10.0;
                x += step;
                double standart = Math.Tan(x);
                OpaqueFunctions.C_build_func func = OpaqueFunctions.Cpriv_tan_6.priv_tan_6(x);
                int sign = 1;
                if (string.Compare(func.sign, "-") == 0)
                    sign = -1;
                double converted;
                if (string.Compare(func.function, "tan") == 0)
                    converted = sign * Math.Tan(func.argument);
                else
                    converted = sign * 1/Math.Tan(func.argument);
                double absoluteError = Math.Abs(standart - converted);
                double relativeError = Math.Abs((standart - converted) / converted);
                file4.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file4.Close();

            System.IO.StreamWriter file5 =
            new System.IO.StreamWriter(@"D:\hello-world\opaque-func-lib\Golubev\csv\priv_ctg_6.csv");
            file5.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" );
            x = -50;
            for (int i = 1; i < 1000; i++)
            {

                double step = 1.0 / 10.0;
                x += step;
                double standart = 1/Math.Tan(x);
                OpaqueFunctions.C_build_func func = OpaqueFunctions.Cpriv_ctg_6.priv_ctg_6(x);
                int sign = 1;
                if (string.Compare(func.sign, "-") == 0)
                    sign = -1;
                double converted;
                if (string.Compare(func.function, "tan") == 0)
                    converted = sign * Math.Tan(func.argument);
                else
                    converted = sign * 1 / Math.Tan(func.argument);
                double absoluteError = Math.Abs(standart - converted);
                double relativeError = Math.Abs((standart - converted) / converted);
                file5.WriteLine(x.ToString() +  ';' + absoluteError.ToString() + ';' + relativeError.ToString() );

            }
            file5.Close();

            makeErrorPlots(@"D:\hello-world\opaque-func-lib\Golubev\csv\");

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
