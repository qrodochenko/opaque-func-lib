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

        static void Main(string[] args)
        {
            makeErrorPlots(@"D:\student\prakt\opaque-func-lib\Pashkov\csv");

           /* System.IO.StreamWriter file2 =
                 new System.IO.StreamWriter(@"F:\Практика\csv\L00_2.csv");
            file2.WriteLine("angle" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = Math.PI / 100.0;
                double angle = -Math.PI / 2 + i * dx;
                double F = L00_2_1.L00_2_1_tg_sin_cos(angle);
                double benchmark = 0;
                double absoluteError = Math.Abs(F - benchmark);
                double relativeError = Math.Abs((F - benchmark) / F);
                file2.WriteLine(angle.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file2.Close();

            System.IO.StreamWriter file3 =
                 new System.IO.StreamWriter(@"F:\Практика\csv\L00_3.csv");
            file3.WriteLine("angle" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = Math.PI / 100.0;
                double angle = i * dx;
                double F = L00_2_1.L00_2_1_tg_sin_cos(angle);
                double benchmark = 0;
                double absoluteError = Math.Abs(F - benchmark);
                double relativeError = Math.Abs((F - benchmark) / F);
                file3.WriteLine(angle.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file3.Close();

            System.IO.StreamWriter file4 =
                 new System.IO.StreamWriter(@"F:\Практика\csv\L00_4.csv");
            file4.WriteLine("angle" + ';' + "absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = Math.PI / 100.0;
                double angle = -Math.PI / 2 + i * dx;
                double F = L00_4_1.L00_4_1_sec_cos(angle);
                double benchmark = 0;
                double absoluteError = Math.Abs(F - benchmark);
                double relativeError = Math.Abs((F - benchmark) / F);
                file4.WriteLine(angle.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file4.Close();

            System.IO.StreamWriter file5 =
                 new System.IO.StreamWriter(@"F:\Практика\csv\L00_5.csv");
            file5.WriteLine("angle" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = Math.PI / 100.0;
                double angle = i * dx;
                double F = L00_5_1.L00_5_1_cosec_sin(angle);
                double benchmark = 0;
                double absoluteError = Math.Abs(F - benchmark);
                double relativeError = Math.Abs((F - benchmark) / F);
                file5.WriteLine(angle.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file5.Close();

            System.IO.StreamWriter file6 =
                new System.IO.StreamWriter(@"F:\Практика\csv\L00_6.csv");
            file6.WriteLine("angle" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = 200 / 100.0;
                double angle1 = i * dx;
                for (int j = 1; j < 100; j++)
                {
                    double angle2 =  + j * dx;
                    double F = L00_6_2.L00_6_2_sin_cos(angle1, angle2);
                    double benchmark = 0;
                    double absoluteError = Math.Abs(F - benchmark);
                    double relativeError = Math.Abs((F - benchmark) / F);
                    file6.WriteLine(angle1.ToString() + ';' + angle2.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                }

            }
            file6.Close();

            System.IO.StreamWriter file7 =
                new System.IO.StreamWriter(@"F:\Практика\csv\L00_7.csv");
            file7.WriteLine("angle" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = 200 / 100.0;
                double angle1 = i * dx;
                for (int j = 1; j < 100; j++)
                {
                    double angle2 = +j * dx;
                    double F = L00_7_2.L00_7_2_sin_cos(angle1, angle2);
                    double benchmark = 0;
                    double absoluteError = Math.Abs(F - benchmark);
                    double relativeError = Math.Abs((F - benchmark) / F);
                    file7.WriteLine(angle1.ToString() + ';' + angle2.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                }

            }
            file7.Close();

            System.IO.StreamWriter file8 =
                new System.IO.StreamWriter(@"F:\Практика\csv\L00_8.csv");
            file8.WriteLine("angle" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = 200 / 100.0;
                double angle1 = i * dx;
                for (int j = 1; j < 100; j++)
                {
                    double angle2 = +j * dx;
                    double F = L00_8_2.L00_8_2_sin_cos(angle1, angle2);
                    double benchmark = 0;
                    double absoluteError = Math.Abs(F - benchmark);
                    double relativeError = Math.Abs((F - benchmark) / F);
                    file8.WriteLine(angle1.ToString() + ';' + angle2.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                }

            }
            file8.Close();

            System.IO.StreamWriter file9 =
                new System.IO.StreamWriter(@"F:\Практика\csv\L00_9.csv");
            file9.WriteLine("angle" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = 200 / 100.0;
                double angle1 = i * dx;
                for (int j = 1; j < 100; j++)
                {
                    double angle2 = +j * dx;
                    double F = L00_6_2.L00_6_2_sin_cos(angle1, angle2);
                    double benchmark = 0;
                    double absoluteError = Math.Abs(F - benchmark);
                    double relativeError = Math.Abs((F - benchmark) / F);
                    file9.WriteLine(angle1.ToString() + ';' + angle2.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                }

            }
            file9.Close();

            System.IO.StreamWriter file10 =
                 new System.IO.StreamWriter(@"F:\Практика\csv\L00_10.csv");
            file10.WriteLine("angle1" + ';' + " angle2" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = Math.PI /2 / 100.0;
                double angle1 = -Math.PI / 4 + i * dx;
                
                for(int j= 1; j< 100; j++){
                    double angle2 = -Math.PI / 4 + j * dx;
                    double F = L00_10_2.L00_10_2_tg(angle1, angle2);
                    double benchmark = 0;
                    double absoluteError = Math.Abs(F - benchmark);
                    double relativeError = Math.Abs((F - benchmark) / F);
                    file10.WriteLine(angle1.ToString() + ';' + angle2.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            }
            file10.Close();
            
            System.IO.StreamWriter file11 =
                 new System.IO.StreamWriter(@"F:\Практика\csv\L00_11.csv");
            file11.WriteLine("angle1" + ';' + " angle2" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = Math.PI / 2 / 100.0;
                double angle1 = -Math.PI / 4 + i * dx;

                for (int j = 1; j < 100; j++)
                {
                    double angle2 = -Math.PI / 4 + j * dx;
                    double F = L00_11_2.L00_11_2_tg(angle1, angle2);
                    double benchmark = 0;
                    double absoluteError = Math.Abs(F - benchmark);
                    double relativeError = Math.Abs((F - benchmark) / F);
                    file11.WriteLine(angle1.ToString() + ';' + angle2.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                }
            }
            file11.Close();

            System.IO.StreamWriter file12 =
                new System.IO.StreamWriter(@"F:\Практика\csv\L00_12.csv");
            file12.WriteLine("angle1" + ';' + " angle2" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = Math.PI/2 / 100.0;
                double angle1 = i * dx;

                for (int j = 1; j < 100; j++)
                {
                    double angle2 = j * dx;
                    double F = L00_12_2.L00_12_2_ctg(angle1, angle2);
                    double benchmark = 0;
                    double absoluteError = Math.Abs(F - benchmark);
                    double relativeError = Math.Abs((F - benchmark) / F);
                    file12.WriteLine(angle1.ToString() + ';' + angle2.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                }
            }
            file12.Close();

            System.IO.StreamWriter file13 =
                new System.IO.StreamWriter(@"F:\Практика\csv\L00_13.csv");
            file13.WriteLine("angle1" + ';' + " angle2" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = Math.PI / 2 / 100.0;
                double dy = dx + 1e-15;
                double angle1 = i * dx;
                
                for (int j = 1; j < 100; j++)
                {
                    double angle2 = j * dy;
                    double F = L00_13_2.L00_13_2_ctg(angle1, angle2);
                    double benchmark = 0;
                    double absoluteError = Math.Abs(F - benchmark);
                    double relativeError = Math.Abs((F - benchmark) / F);
                    file13.WriteLine(angle1.ToString() + ';' + angle2.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                }
            }
            file13.Close();

            System.IO.StreamWriter file14 =
                new System.IO.StreamWriter(@"F:\Практика\csv\L00_14.csv");
            file14.WriteLine("angle" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = 200 / 100.0;
                double angle1 = -100 + i * dx; 
                for (int j = 1; j < 100; j++)
                {
                    double angle2 = -100 + j * dx; 
                    double F = L00_14_2.L00_14_2_sin_cos(angle1, angle2);
                    double benchmark = 0;
                    double absoluteError = Math.Abs(F - benchmark);
                    double relativeError = Math.Abs((F - benchmark) / F);
                    file14.WriteLine(angle1.ToString() + ';' + angle2.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                }

            }
            file14.Close();

            System.IO.StreamWriter file15 =
                new System.IO.StreamWriter(@"F:\Практика\csv\L00_15.csv");
            file15.WriteLine("angle" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = 200 / 100.0;
                double angle1 = -100 + i * dx; 
                for (int j = 1; j < 100; j++)
                {
                    double angle2 = -100 + j * dx; 
                    double F = L00_15_2.L00_15_2_cos(angle1, angle2);
                    double benchmark = 0;
                    double absoluteError = Math.Abs(F - benchmark);
                    double relativeError = Math.Abs((F - benchmark) / F);
                    file15.WriteLine(angle1.ToString() + ';' + angle2.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                }

            }
            file15.Close();

            System.IO.StreamWriter file16 =
                new System.IO.StreamWriter(@"F:\Практика\csv\L00_16.csv");
            file16.WriteLine("angle" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = 200 / 100.0;
                double angle1 = -100 + i * dx; 
                for (int j = 1; j < 100; j++)
                {
                    double angle2 = -100 + j * dx; 
                    double F = L00_16_2.L00_16_2_sin(angle1, angle2);
                    double benchmark = 0;
                    double absoluteError = Math.Abs(F - benchmark);
                    double relativeError = Math.Abs((F - benchmark) / F);
                    file16.WriteLine(angle1.ToString() + ';' + angle2.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                }

            }
            file16.Close();

            System.IO.StreamWriter file17 =
                new System.IO.StreamWriter(@"F:\Практика\csv\L00_17.csv");
            file17.WriteLine("angle" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = 200 / 100.0;
                double angle1 = -100 + i * dx; 
                for (int j = 1; j < 100; j++)
                {
                    double angle2 = -100 + j * dx; 
                    double F = L00_17_2.L00_17_2_sin_cos(angle1, angle2);
                    double benchmark = 0;
                    double absoluteError = Math.Abs(F - benchmark);
                    double relativeError = Math.Abs((F - benchmark) / F);
                    file17.WriteLine(angle1.ToString() + ';' + angle2.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                }

            }
            file17.Close();

            System.IO.StreamWriter file18 =
                new System.IO.StreamWriter(@"F:\Практика\csv\L00_18.csv");
            file18.WriteLine("angle" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = 200 / 100.0;
                double angle1 = -100 + i * dx; 
                for (int j = 1; j < 100; j++)
                {
                    double angle2 = -100 + j * dx; 
                    double F = L00_18_2.L00_18_2_sin_cos(angle1, angle2);
                    double benchmark = 0;
                    double absoluteError = Math.Abs(F - benchmark);
                    double relativeError = Math.Abs((F - benchmark) / F);
                    file18.WriteLine(angle1.ToString() + ';' + angle2.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                }

            }
            file18.Close();

            System.IO.StreamWriter file19 =
                new System.IO.StreamWriter(@"F:\Практика\csv\L00_19.csv");
            file19.WriteLine("angle" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = 200 / 100.0;
                double angle1 = -100 + i * dx; 
                for (int j = 1; j < 100; j++)
                {
                    double angle2 = -100 + j * dx; 
                    double F = L00_19_2.L00_19_2_cos_sin(angle1, angle2);
                    double benchmark = 0;
                    double absoluteError = Math.Abs(F - benchmark);
                    double relativeError = Math.Abs((F - benchmark) / F);
                    file19.WriteLine(angle1.ToString() + ';' + angle2.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                }

            }
            file19.Close();

            System.IO.StreamWriter file20 =
                new System.IO.StreamWriter(@"F:\Практика\csv\L00_20.csv");
            file20.WriteLine("angle" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = 200 / 100.0;
                double angle1 = -100 + i * dx;
                for (int j = 1; j < 100; j++)
                {
                    double angle2 = -100 + i * dx;
                    double F = L00_20_2.L00_20_2_cos(angle1, angle2);
                    double benchmark = 0;
                    double absoluteError = Math.Abs(F - benchmark);
                    double relativeError = Math.Abs((F - benchmark) / F);
                    file20.WriteLine(angle1.ToString() + ';' + angle2.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                }

            }
            file20.Close();

            System.IO.StreamWriter file21 =
               new System.IO.StreamWriter(@"F:\Практика\csv\L00_21.csv");
            file21.WriteLine("angle1" + ';' + " angle2" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = Math.PI / 100.0;
                double dy = dx;
                double angle1 =-Math.PI/2 + i * dx;

                for (int j = 1; j < 100; j++)
                {
                    double angle2 = -Math.PI / 2 + i * dx;
                    double F = L00_21_2.L00_21_2_tg_sin_cos(angle1, angle2);
                    double benchmark = 0;
                    double absoluteError = Math.Abs(F - benchmark);
                    double relativeError = Math.Abs((F - benchmark) / F);
                    file21.WriteLine(angle1.ToString() + ';' + angle2.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                }
            }
            file21.Close();

            System.IO.StreamWriter file22 =
               new System.IO.StreamWriter(@"F:\Практика\csv\L00_22.csv");
            file22.WriteLine("angle1" + ';' + " angle2" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = Math.PI / 100.0;
                double dy = dx;
                double angle1 = -Math.PI / 2 + i * dx;

                for (int j = 1; j < 100; j++)
                {
                    double angle2 = -Math.PI / 2 + i * dx;
                    double F = L00_22_2.L00_22_2_tg_sin_cos(angle1, angle2);
                    double benchmark = 0;
                    double absoluteError = Math.Abs(F - benchmark);
                    double relativeError = Math.Abs((F - benchmark) / F);
                    file22.WriteLine(angle1.ToString() + ';' + angle2.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                }
            }
            file22.Close();

            System.IO.StreamWriter file23 =
               new System.IO.StreamWriter(@"F:\Практика\csv\L00_23.csv");
            file23.WriteLine("angle1" + ';' + " angle2" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = Math.PI / 100.0;
                double dy = dx;
                double angle1 = i * dx;

                for (int j = 1; j < 100; j++)
                {
                    double angle2 = j * dy;
                    double F = L00_23_2.L00_23_2_ctg_sin(angle1, angle2);
                    double benchmark = 0;
                    double absoluteError = Math.Abs(F - benchmark);
                    double relativeError = Math.Abs((F - benchmark) / F);
                    file23.WriteLine(angle1.ToString() + ';' + angle2.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                }
            }
            file23.Close();

            System.IO.StreamWriter file24 =
               new System.IO.StreamWriter(@"F:\Практика\csv\L00_24.csv");
            file24.WriteLine("angle1" + ';' + " angle2" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = Math.PI / 100.0;
                double dy = dx;
                double angle1 = i * dx;

                for (int j = 1; j < 100; j++)
                {
                    double angle2 = j * dy;
                    double F = L00_24_2.L00_24_2_ctg_sin(angle1, angle2);
                    double benchmark = 0;
                    double absoluteError = Math.Abs(F - benchmark);
                    double relativeError = Math.Abs((F - benchmark) / F);
                    file24.WriteLine(angle1.ToString() + ';' + angle2.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                }
            }
            file24.Close();

            System.IO.StreamWriter file25 =
                 new System.IO.StreamWriter(@"F:\Практика\csv\L00_25.csv");
            file25.WriteLine("angle" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = 200 / 100.0;
                double angle = -100 + i * dx;
                double F = L00_25_1.L00_25_1_sin_cos(angle);
                double benchmark = 0;
                double absoluteError = Math.Abs(F - benchmark);
                double relativeError = Math.Abs((F - benchmark) / F);
                file25.WriteLine(angle.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file25.Close();

            System.IO.StreamWriter file26 =
                 new System.IO.StreamWriter(@"F:\Практика\csv\L00_26.csv");
            file26.WriteLine("angle" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = 200 / 100.0;
                double angle = -100 + i * dx;
                double F = L00_26_1.L00_26_1_sin(angle);
                double benchmark = 0;
                double absoluteError = Math.Abs(F - benchmark);
                double relativeError = Math.Abs((F - benchmark) / F);
                file26.WriteLine(angle.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file26.Close();

            System.IO.StreamWriter file27 =
                 new System.IO.StreamWriter(@"F:\Практика\csv\L00_27.csv");
            file27.WriteLine("angle" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = 2 / 100.0;
                double angle = -1 + i * dx;
                double F = L00_27_1.L00_27_1_sin_arcsin(angle);
                double benchmark = 0;
                double absoluteError = Math.Abs(F - benchmark);
                double relativeError = Math.Abs((F - benchmark) / F);
                file27.WriteLine(angle.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file27.Close();

            System.IO.StreamWriter file28 =
                 new System.IO.StreamWriter(@"F:\Практика\csv\L00_28.csv");
            file28.WriteLine("angle" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = 2 / 100.0;
                double angle = -1 + i * dx;
                double F = L00_28_1.L00_28_1_cos_arccos(angle);
                double benchmark = 0;
                double absoluteError = Math.Abs(F - benchmark);
                double relativeError = Math.Abs((F - benchmark) / F);
                file28.WriteLine(angle.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file28.Close();

            System.IO.StreamWriter file29 =
                 new System.IO.StreamWriter(@"F:\Практика\csv\L00_29.csv");
            file29.WriteLine("angle" + ';' + " absoluteError" + ';' + " relativeError");
            for (int i = 1; i < 100; i++)
            {
                double dx = 2 / 100.0;
                double angle = -1 + i * dx;
                double F = L00_29_1.L00_29_1_sin_arccos_cos_arcsin(angle);
                double benchmark = 0;
                double absoluteError = Math.Abs(F - benchmark);
                double relativeError = Math.Abs((F - benchmark) / F);
                file29.WriteLine(angle.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file29.Close();

            */
        }
    }
}
