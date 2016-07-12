#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            /// Создание csv-файлов
            /// 
            double x, g, g_inv;
            double result; // Результат вычисления
            double t; // Шаг
            double absoluteError; // Абсолютная погрешность
            double relativeError; // Относительная погрешность
            string name;
            string name_folder = (@"D:\PRACTICE\K\csv\");
            string funcname;
            string S1 = "g_ginvx";
            string S2 = "ginv_gx";

            int i, k;
            double A, B, C, a, b, c, d;

            /// g(x) = (x + A)^(2k + 1) + B
            /// g_inv(x) = (x - B)^(1/(2k + 1)) - A
            /// (w, w) -> (w, w)
            
            A = 0.0135;
            B = 1.2477;
            k = -4;
            funcname = "interval_ww_ww_1";

            name = name_folder + funcname + "_" + S1 + "_A=" + A.ToString() + "_B=" + B.ToString() + "_k=" + k.ToString() + ".csv";
                System.IO.StreamWriter name_file_writer =
               new System.IO.StreamWriter(name);
                name_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "result");

            g = 0; g_inv = 0;
            result = 0;
            x = -50;
            t = 1.0 / 10.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g_inv = Cinterval_ww_ww_1_inv.interval_ww_ww_1_inv(x, A, B, k);
                g = Cinterval_ww_ww_1.interval_ww_ww_1(g_inv, A, B, k);
                result = g;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                name_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + result.ToString());

            }
            name_file_writer.Close();


            
            name = name_folder + funcname + "_" + S2 + "_A=" + A.ToString() + "_B=" + B.ToString() + "_k=" + k.ToString() + ".csv";
            name_file_writer =
               new System.IO.StreamWriter(name);
            name_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "result");
            g = 0; g_inv = 0;
            result = 0;
            x = -50;
            t = 1.0 / 10.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g = Cinterval_ww_ww_1.interval_ww_ww_1(x, A, B, k);
                g_inv = Cinterval_ww_ww_1_inv.interval_ww_ww_1_inv(g, A, B, k);
                result = g_inv;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                name_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + result.ToString());

            }
            name_file_writer.Close();



            /// g(x) = x / sqrt(x*x + C)
            /// g_inv(x) = sqrt(C) * x / sqrt(1 - x*x)
            /// (w, w) -> (-1, 1)

            funcname = "interval_ww_finfin_2";
            C = 0.4673;

            name = name_folder + funcname + "_" + S1 + "_C=" + C.ToString() + ".csv";
            name_file_writer =
                new System.IO.StreamWriter(name);
                name_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "result");

            g = 0; g_inv = 0;
            result = 0;
            x = -0.5;
            t = 1.0 / 1000.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g_inv = Cinterval_ww_finfin_2_inv.interval_ww_finfin_2_inv(x, C);
                g = Cinterval_ww_finfin_2.interval_ww_finfin_2(g_inv, C);
                result = g;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                name_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + result.ToString());
            }
            name_file_writer.Close();


            name = name_folder + funcname + "_" + S2 + "_C=" + C.ToString() + ".csv";
            name_file_writer =
                new System.IO.StreamWriter(name);
                name_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "result");

            g = 0; g_inv = 0;
            result = 0;
            x = -50;
            t = 1.0 / 10.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g = Cinterval_ww_finfin_2.interval_ww_finfin_2(x, C);
                g_inv = Cinterval_ww_finfin_2_inv.interval_ww_finfin_2_inv(g, C);
                result = g_inv;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                name_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + result.ToString());

            }
            name_file_writer.Close();



            /// g(x) = tg(x)
            /// g_inv(x) = arctg(x)
            /// (-Pi/2, Pi/2) -> (w, w)

            funcname = "interval_finfin_ww_3";

            name = name_folder + funcname + "_" + S1 + ".csv";
            name_file_writer =
                new System.IO.StreamWriter(name);
            name_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "result");


            g = 0; g_inv = 0;
            result = 0;
            x = -50;
            t = 1.0 / 10.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g_inv = Cinterval_finfin_ww_3_inv.interval_finfin_ww_3_inv(x);
                g = Cinterval_finfin_ww_3.interval_finfin_ww_3(g_inv);

                result = g;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                name_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + result.ToString());

            }
            name_file_writer.Close();


            name = name_folder + funcname + "_" + S2 + ".csv";
            name_file_writer =
                new System.IO.StreamWriter(name);
            name_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "result");

            g = 0; g_inv = 0;
            result = 0;
            x = -Math.PI / 2;
            t = Math.PI / 1000.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g = Cinterval_finfin_ww_3.interval_finfin_ww_3(x);
                g_inv = Cinterval_finfin_ww_3_inv.interval_finfin_ww_3_inv(g);

                result = g_inv;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                name_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + result.ToString());

            }
            name_file_writer.Close();


            /// g(x) = 1/x
            /// g_inv(x) = 1/x
            /// (0, w) -> (0, w)

            funcname = "interval_finw_finw_4";

            name = name_folder + funcname + "_" + S1 + ".csv";
            name_file_writer =
                new System.IO.StreamWriter(name);
            name_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "result");

            g = 0; g_inv = 0;
            result = 0;
            x = 0;
            t = 1.0 / 10.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g_inv = Cinterval_finw_finw_4_inv.interval_finw_finw_4_inv(x);
                g = Cinterval_finw_finw_4.interval_finw_finw_4(g_inv);

                result = g;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                name_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + result.ToString());

            }
            name_file_writer.Close();

            name = name_folder + funcname + "_" + S2 + ".csv";
            name_file_writer =
                new System.IO.StreamWriter(name);
            name_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "result");
            g = 0; g_inv = 0;
            result = 0;
            x = 0;
            t = 1.0 / 10.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g = Cinterval_finw_finw_4.interval_finw_finw_4(x);
                g_inv = Cinterval_finw_finw_4_inv.interval_finw_finw_4_inv(g);

                result = g_inv;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                name_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + result.ToString());

            }
            name_file_writer.Close();


            /// g(x) = -x
            /// g_inv(x) = -x
            /// (0, w) -> (w, 0)

            funcname = "interval_finw_wfin_5";

            name = name_folder + funcname + "_" + S1 + ".csv";
            name_file_writer =
                new System.IO.StreamWriter(name);
            name_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "result");

            g = 0; g_inv = 0;
            result = 0;
            x = -100;
            t = 1.0 / 10.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g_inv = Cinterval_finw_wfin_5_inv.interval_finw_wfin_5_inv(x);
                g = Cinterval_finw_wfin_5.interval_finw_wfin_5(g_inv);

                result = g;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                name_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + result.ToString());

            }
            name_file_writer.Close();

            name = name_folder + funcname + "_" + S2 + ".csv";
            name_file_writer =
                new System.IO.StreamWriter(name);
            name_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "result");

            g = 0; g_inv = 0;
            result = 0;
            x = 0;
            t = 1.0 / 10.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g = Cinterval_finw_wfin_5.interval_finw_wfin_5(x);
                g_inv = Cinterval_finw_wfin_5_inv.interval_finw_wfin_5_inv(g);

                result = g_inv;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                name_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + result.ToString());

            }
            name_file_writer.Close();


            /// g(x) = A*exp(x + B)
            /// g_inv(x) = ln(x / A) - B
            /// (w, w) -> (0, w)
            
            A = 1.4636;
            B = 0.5731;
            funcname = "interval_ww_finw_6";

            name = name_folder + funcname + "_" + S1 + "_A=" + A.ToString() + "_B=" + B.ToString() + ".csv";
            name_file_writer =
               new System.IO.StreamWriter(name);
            name_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "result");


            g = 0; g_inv = 0;
            result = 0;
            x = 0;
            t = 1.0 / 10.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g_inv = Cinterval_ww_finw_6_inv.interval_ww_finw_6_inv(x, A, B);
                g = Cinterval_ww_finw_6.interval_ww_finw_6(g_inv, A, B);

                result = g;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                name_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + result.ToString());

            }
            name_file_writer.Close();

            name = name_folder + funcname + "_" + S2 + "_A=" + A.ToString() + "_B=" + B.ToString() + ".csv";
            name_file_writer =
               new System.IO.StreamWriter(name);
            name_file_writer.WriteLine("x" + ';' + "absoluteError" + "relativeError" + ';' + "result");

            g = 0; g_inv = 0;
            result = 0;
            x = -50;
            t = 1.0 / 10.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g = Cinterval_ww_finw_6.interval_ww_finw_6(x, A, B);
                g_inv = Cinterval_ww_finw_6_inv.interval_ww_finw_6_inv(g, A, B);

                result = g_inv;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                name_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + result.ToString());

            }
            name_file_writer.Close();


            /// g(x) = ((c - d)/(a - b)) * x + (ad - bc) / (a - b)
            /// g_inv(x) = ((a - b)/(c -d)) * x + (bc - ad) / (c - d)
            /// (a, b) -> (c, d)
            a = 40; b = 140;
            c = 30; d = 130;
            funcname = "interval_finfin_finfin_7";

            name = name_folder + funcname + "_" + S1 + "_a=" + a.ToString() + "_b=" + b.ToString() + "_c=" + c.ToString() + "_d=" + d.ToString() + ".csv";
            name_file_writer =
               new System.IO.StreamWriter(name);
            name_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "result");

            g = 0; g_inv = 0;
            result = 0;

            t = 1.0 / 10.0;

            x = c;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g_inv = Cinterval_finfin_finfin_7_inv.interval_finfin_finfin_7_inv(x, a, b, c, d);
                g = Cinterval_finfin_finfin_7.interval_finfin_finfin_7(g_inv, a, b, c, d);

                result = g;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                name_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + result.ToString());

            }
            name_file_writer.Close();


            name = name_folder + funcname + "_" + S2 + "_a=" + a.ToString() + "_b=" + b.ToString() + "_c=" + c.ToString() + "_d=" + d.ToString() + ".csv";
            name_file_writer =
               new System.IO.StreamWriter(name);
            name_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "result");


            g = 0; g_inv = 0;
            result = 0;

            t = 1.0 / 10.0;

            x = a;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g = Cinterval_finfin_finfin_7.interval_finfin_finfin_7(x, a, b, c, d);
                g_inv = Cinterval_finfin_finfin_7_inv.interval_finfin_finfin_7_inv(g, a, b, c, d);

                result = g_inv;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                name_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + result.ToString());

            }
            name_file_writer.Close();


            /// g(x) = (ab*(d - c)/(a - b)) / x + (ac - bd) / (a - b)
            /// g_inv(x) = (d - c)*a*b/(x*(a- b) - (a*c - b*d))
            /// (a, b) -> (c, d)

            funcname = "interval_finfin_finfin_8";
            a = 5.8363;
            b = a + 7.3245;
            c = 3.7841;
            d = c + 8.4234;

            name = name_folder + funcname + "_" + S1 + "_a=" + a.ToString() + "_b=" + b.ToString() + "_c=" + c.ToString() + "_d=" + d.ToString() + ".csv";
            name_file_writer =
               new System.IO.StreamWriter(name);
            name_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "result");


            g = 0; g_inv = 0;
            result = 0;

            t = (d - c) / 1000.0;
            x = c;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g_inv = Cinterval_finfin_finfin_8_inv.interval_finfin_finfin_8_inv(x, a, b, c, d);
                g = Cinterval_finfin_finfin_8.interval_finfin_finfin_8(g_inv, a, b, c, d);

                result = g;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                name_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + result.ToString());

            }
            name_file_writer.Close();

            name = name_folder + funcname + "_" + S2 + "_a=" + a.ToString() + "_b=" + b.ToString() + "_c=" + c.ToString() + "_d=" + d.ToString() + ".csv";
            name_file_writer =
               new System.IO.StreamWriter(name);
            name_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "result");

            g = 0; g_inv = 0;
            result = 0;

            t = (b - a) / 1000.0;
            x = a;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g = Cinterval_finfin_finfin_8.interval_finfin_finfin_8(x, a, b, c, d);
                g_inv = Cinterval_finfin_finfin_8_inv.interval_finfin_finfin_8_inv(g, a, b, c, d);

                result = g_inv;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                name_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + result.ToString());

            }
            name_file_writer.Close();


            /// g(x) = sin(x)
            /// g_inv(x) = arcsin(x)
            /// (-Pi/2, Pi/2) -> (-1, 1)
            funcname = "interval_finfin_finfin_9";

            name = name_folder + funcname + "_" + S1 + ".csv";
            name_file_writer =
                new System.IO.StreamWriter(name);
            name_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "result");

            g = 0; g_inv = 0;
            result = 0;
            x = -0.5;
            t = 1.0 / 1000.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g_inv = Cinterval_finfin_finfin_9_inv.interval_finfin_finfin_9_inv(x);
                g = Cinterval_finfin_finfin_9.interval_finfin_finfin_9(g_inv);

                result = g;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                name_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + result.ToString());

            }
            name_file_writer.Close();

            name = name_folder + funcname + "_" + S2 + ".csv";
            name_file_writer =
                new System.IO.StreamWriter(name);
            name_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "result");

            g = 0; g_inv = 0;
            result = 0;
            x = -Math.PI / 2;
            t = Math.PI / 1000.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g = Cinterval_finfin_finfin_9.interval_finfin_finfin_9(x);
                g_inv = Cinterval_finfin_finfin_9_inv.interval_finfin_finfin_9_inv(g);

                result = g_inv;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                name_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + result.ToString());

            }
            name_file_writer.Close();


            /// g(x) = cos(x)
            /// g_inv(x) = arccos(x)
            /// (0, Pi) -> (-1, 1)

            funcname = "interval_finfin_finfin_10";

            name = name_folder + funcname + "_" + S1 + ".csv";
            name_file_writer =
                new System.IO.StreamWriter(name);
            name_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "result");

            g = 0; g_inv = 0;
            result = 0;
            x = -0.5;
            t = 1.0 / 1000.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g_inv = Cinterval_finfin_finfin_10_inv.interval_finfin_finfin_10_inv(x);
                g = Cinterval_finfin_finfin_10.interval_finfin_finfin_10(g_inv);

                result = g;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                name_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + result.ToString());

            }
            name_file_writer.Close();


            name = name_folder + funcname + "_" + S2 + ".csv";
            name_file_writer =
                new System.IO.StreamWriter(name);
            name_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "result");

            g = 0; g_inv = 0;
            result = 0;
            x = 0;
            t = Math.PI / 1000.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g = Cinterval_finfin_finfin_10.interval_finfin_finfin_10(x);
                g_inv = Cinterval_finfin_finfin_10_inv.interval_finfin_finfin_10_inv(g);

                result = g_inv;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                name_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + result.ToString());

            }
            name_file_writer.Close();


            Console.WriteLine("CSV-files generated successfully");


            makeErrorPlots(@"D:\PRACTICE\K\csv");

            Console.WriteLine("Plots created successfully");
        }




            ///  Создание графиков
            
                    static void makeErrorPlot(string source_csv_file_name)
        {
            TextFieldParser parser = new TextFieldParser(source_csv_file_name); 
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

        static void makeErrorPlots(string source_csv_folder_name) 
        {
            foreach (String source_csv_file_name in System.IO.Directory.GetFiles(source_csv_folder_name))
                makeErrorPlot(source_csv_file_name);
        }
        }
    
    }


