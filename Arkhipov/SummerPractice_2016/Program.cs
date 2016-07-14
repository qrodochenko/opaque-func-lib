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
            MakeResultsSummaryFile("L00_86_1_th", CL00_86_1_th.L00_86_1_th, 1, 100); 
            MakeResultsSummaryFile("L00_87_2_sh_ch", CL00_87_2_sh_ch.L00_87_2_sh_ch);
            MakeResultsSummaryFile("L00_88_2_sh_ch", CL00_88_2_sh_ch.L00_88_2_sh_ch);
            MakeResultsSummaryFile("L00_89_2_ch", CL00_89_2_ch.L00_89_2_ch);
            MakeResultsSummaryFile("L00_90_2_ch_sh", CL00_90_2_ch_sh.L00_90_2_ch_sh);
            MakeResultsSummaryFile("L00_91_2_th_sh_ch", CL00_91_2_th_sh_ch.L00_91_2_th_sh_ch);
            MakeResultsSummaryFile("L00_92_2_th_sh_ch", CL00_92_2_th_sh_ch.L00_92_2_th_sh_ch);
            MakeResultsSummaryFile("L00_93_2_cth_sh", CL00_93_2_cth_sh.L00_93_2_cth_sh, 0, 100); // (0, w)
            MakeResultsSummaryFile("L00_94_2_cth_sh", CL00_94_2_cth_sh.L00_94_2_cth_sh, 0, 100); // (0, w)
            MakeResultsSummaryFile("L00_95_2_sh", CL00_95_2_sh.L00_95_2_sh);
            MakeResultsSummaryFile("L00_96_2_ch_sh", CL00_96_2_ch_sh.L00_96_2_ch_sh);
            MakeResultsSummaryFile("L00_97_2_sh_ch", CL00_97_2_sh_ch.L00_97_2_sh_ch);
            MakeResultsSummaryFile("L00_98_2_sh_ch", CL00_98_2_sh_ch.L00_98_2_sh_ch, -10, 10); // (-10, 10)
            MakeResultsSummaryFile("L00_99_2_log", CL00_99_2_log.L00_99_2_log, 5.0, 2, 100); // (2, w)
            MakeResultsSummaryFile("L00_100_3_log", CL00_100_3_log.L00_100_3_log, 5.0, 1, 100); // (1, w)
            MakeResultsSummaryFile("L00_101_3_log", CL00_101_3_log.L00_101_3_log, 5.0, 1, 100); // (1, w)
            MakeResultsSummaryFile("L00_102_3_log", CL00_102_3_log.L00_102_3_log, 10, 5.0, 1, 100); // (1, w)
            MakeResultsSummaryFile("L00_103_3_log", CL00_103_3_log.L00_103_3_log, 5.0, 10.0, 1, 100); // (1, w)
            MakeResultsSummaryFile("L00_104_1_ln_arsh", CL00_104_1_ln_arsh.L00_104_1_ln_arsh);
            MakeResultsSummaryFile("L00_105_1_ln_arch", CL00_105_1_ln_arch.L00_105_1_ln_arch, 2, 100); // (2, w)
            MakeResultsSummaryFile("L00_106_1_ln_arth", CL00_106_1_ln_arth.L00_106_1_ln_arth, -0.1, 0.1, 0); // (-1, 1)
            MakeResultsSummaryFile("L00_107_2_pow_exp", CL00_107_2_pow_exp.L00_107_2_pow_exp, 2.0);   
            MakeResultsSummaryFile("L00_108_3_pow", CL00_108_3_pow.L00_108_3_pow, 2.0);
            MakeResultsSummaryFile("L00_109_3_pow", CL00_109_3_pow.L00_109_3_pow, 2.0);
            MakeResultsSummaryFile("L00_110_3_pow", CL00_110_3_pow.L00_110_3_pow, 2.0);
            MakeResultsSummaryFile("L00_111_1_exp_th", CL00_111_1_exp_th.L00_111_1_exp_th, 1, 4);
            MakeResultsSummaryFile("L00_112_1_exp_ch_sh", CL00_112_1_exp_ch_sh.L00_112_1_exp_ch_sh, 1, 100); // (1, w)
            MakeResultsSummaryFile("L00_113_1_ch_sh_th", CL00_113_1_ch_sh_th.L00_113_1_ch_sh_th, 1, 100); // (1, w) 


            string offset = "..\\..\\..\\"; // чтобы выходные файлы оказались точно в папке с фамилией  
            string source_csv_folder_name = offset + "csv"; // пусть папка для файлов с отчётами .csv называется так.
            makeErrorPlots(source_csv_folder_name); 
        }

        // С автоматически задающимся интервалом

        /// <summary>
        /// Создает csv файлы с абсолютной и относительной погрешности для функций со следующими аргументами: X
        /// </summary>
        /// <param name="funcname"></param>
        /// <param name="f"></param>
        static void MakeResultsSummaryFile(string funcname, Func<double, double> f) // x 
        {
            //генерирует файл .csv нужного формата
            string dest_folder = ("..\\..\\..\\csv\\");
            //мы хотим равномерно покрыть область определения (или хорошей сходимости) функции number_of_points точками. Подойдите к выбору области аккуратно.
            double left_border_of_range = -100.0;
            double right_border_of_range = 100.0;
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 100;
            double dx = range_length / number_of_points;
            double dy = range_length / number_of_points;

            for (int j = 1; j < number_of_points; j++)
            {
                //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
                string dest = dest_folder + funcname + ".csv";
                System.IO.StreamWriter dest_file_writer =
                   new System.IO.StreamWriter(dest);
                dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");

                for (int i = 1; i < number_of_points; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // измеритель времени, для каждой точки
                    swatch.Start();
                    double x = left_border_of_range + i * dx + 1;
                    double F = f(x);
                    double benchmark = 0;
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / F);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
                }
                dest_file_writer.Close();
            }
        }

        /// <summary>
        /// Создает csv файлы с абсолютной и относительной погрешности для функций со следующими аргументами: X, Y
        /// </summary>
        /// <param name="funcname"></param>
        /// <param name="f"></param>
        static void MakeResultsSummaryFile(string funcname, Func<double, double, double> f) // x, y 
        {
            //генерирует файл .csv нужного формата
            string dest_folder = ("..\\..\\..\\csv\\");
            //мы хотим равномерно покрыть область определения (или хорошей сходимости) функции number_of_points точками. Подойдите к выбору области аккуратно.
            double left_border_of_range = -100.0;
            double right_border_of_range = 100.0;
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 100;
            double dx = range_length / number_of_points;
            double dy = range_length / number_of_points;
            for (int j = 1; j < number_of_points; j++)
            {
                double y = left_border_of_range + j * dy;
                //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
                string dest = dest_folder + funcname + "_y" + y.ToString() + ".csv";
                System.IO.StreamWriter dest_file_writer =
                    new System.IO.StreamWriter(dest);
                dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");

                for (int i = 1; i < number_of_points; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // измеритель времени, для каждой точки
                    swatch.Start();
                    double x = left_border_of_range + i * dx;
                    double F = f(x, y);
                    double benchmark = 0;
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / F);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
                }
                dest_file_writer.Close();
            }
        }

        /// <summary>
        /// Создает csv файлы с абсолютной и относительной погрешности для функций со следующими аргументами: X, A
        /// </summary>
        /// <param name="funcname"></param>
        /// <param name="f"></param>
        static void MakeResultsSummaryFile(string funcname, Func<double, double, double> f, double a) // x, a 
        {
            //генерирует файл .csv нужного формата
            string dest_folder = ("..\\..\\..\\csv\\");
            //мы хотим равномерно покрыть область определения (или хорошей сходимости) функции number_of_points точками. Подойдите к выбору области аккуратно.
            double left_border_of_range = -100.0;
            double right_border_of_range = 100.0;
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 100;
            double dx = range_length / number_of_points;
            double dy = range_length / number_of_points;
            for (int j = 1; j < number_of_points; j++)
            {
                //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
                string dest = dest_folder + funcname + ".csv";
                System.IO.StreamWriter dest_file_writer =
                   new System.IO.StreamWriter(dest);
                dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");


                for (int i = 1; i < number_of_points; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // измеритель времени, для каждой точки
                    swatch.Start();
                    double x = left_border_of_range + i * dx;
                    double F = f(x, a);
                    double benchmark = 0;
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / F);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
                }
                dest_file_writer.Close();
            }
        }

        /// <summary>
        /// Создает csv файлы с абсолютной и относительной погрешности для функций со следующими аргументами: X, Y, A
        /// </summary>
        /// <param name="funcname"></param>
        /// <param name="f"></param>
        static void MakeResultsSummaryFile(string funcname, Func<double, double, double, double> f, double a) // x, y, a 
        {
            //генерирует файл .csv нужного формата
            string dest_folder = ("..\\..\\..\\csv\\");

            //мы хотим равномерно покрыть область определения (или хорошей сходимости) функции number_of_points точками. Подойдите к выбору области аккуратно.
            double left_border_of_range = -100.0;
            double right_border_of_range = 100.0;
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 100;
            double dx = range_length / number_of_points;
            double dy = range_length / number_of_points;

            for (int j = 1; j < number_of_points; j++)
            {
                double y = left_border_of_range + j * dy;
                //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
                string dest = dest_folder + funcname + "_y" + y.ToString() + "_a" + a.ToString() + ".csv";
                System.IO.StreamWriter dest_file_writer =
                    new System.IO.StreamWriter(dest);
                dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");

                for (int i = 1; i < number_of_points; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // измеритель времени, для каждой точки
                    swatch.Start();
                    double x = left_border_of_range + i * dx;
                    double F = f(x, y, a);
                    double benchmark = 0;
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / F);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
                }
                dest_file_writer.Close();
            }
        }

        /// <summary>
        /// Создает csv файлы с абсолютной и относительной погрешности для функций со следующими аргументами: X, A, B
        /// </summary>
        /// <param name="funcname"></param>
        /// <param name="f"></param>
        static void MakeResultsSummaryFile(string funcname, Func<double, double, double, double> f, double a, double b) // x, a, b 
        {
            //генерирует файл .csv нужного формата
            string dest_folder = ("..\\..\\..\\csv\\");

            //мы хотим равномерно покрыть область определения (или хорошей сходимости) функции number_of_points точками. Подойдите к выбору области аккуратно.
            double left_border_of_range = -100.0;
            double right_border_of_range = 100.0;
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 100;
            double dx = range_length / number_of_points;

            for (int j = 1; j < number_of_points; j++)
            {
                //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
                string dest = dest_folder + funcname + "_a" + a.ToString() + "_b" + b.ToString() + ".csv";
                System.IO.StreamWriter dest_file_writer =
                    new System.IO.StreamWriter(dest);
                dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");

                for (int i = 1; i < number_of_points; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // измеритель времени, для каждой точки
                    swatch.Start();
                    double x = left_border_of_range + i * dx;
                    double F = f(x, a, b);
                    double benchmark = 0;
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / F);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
                }
                dest_file_writer.Close();
            }
        }

        /// <summary>
        /// Создает csv файлы с абсолютной и относительной погрешности для функций со следующими аргументами: X, N, B 
        /// </summary>
        /// <param name="funcname"></param>
        /// <param name="f"></param>
        static void MakeResultsSummaryFile(string funcname, Func<double, int, double, double> f, int n, double b) // x, n, b 
        {
            //генерирует файл .csv нужного формата
            string dest_folder = ("..\\..\\..\\csv\\");

            //мы хотим равномерно покрыть область определения (или хорошей сходимости) функции number_of_points точками. Подойдите к выбору области аккуратно.
            double left_border_of_range = -100.0;
            double right_border_of_range = 100.0;
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 100;
            double dx = range_length / number_of_points;

            for (int j = 1; j < number_of_points; j++)
            {
                //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
                string dest = dest_folder + funcname + "_n" + n.ToString() + "_b" + b.ToString() + ".csv";
                System.IO.StreamWriter dest_file_writer =
                    new System.IO.StreamWriter(dest);
                dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");

                for (int i = 1; i < number_of_points; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // измеритель времени, для каждой точки
                    swatch.Start();
                    double x = left_border_of_range + i * dx;
                    double F = f(x, n, b);
                    double benchmark = 0;
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / F);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
                }
                dest_file_writer.Close();
            }
        }

        // С ручной настройкой интервала

        /// <summary>
        /// Создает csv файлы с абсолютной и относительной погрешности для функций со следующими аргументами: X, left_border_of_range, right_border_of_range
        /// </summary>
        /// <param name="funcname"></param>
        /// <param name="f"></param>
        static void MakeResultsSummaryFile(string funcname, Func<double, double> f, double left_border_of_range, double right_border_of_range) // x, lb, rb
        {
            //генерирует файл .csv нужного формата
            string dest_folder = ("..\\..\\..\\csv\\");
            //мы хотим равномерно покрыть область определения (или хорошей сходимости) функции number_of_points точками. Подойдите к выбору области аккуратно.
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 100;
            double dx = range_length / number_of_points;
            double dy = range_length / number_of_points;
            for (int j = 1; j < number_of_points; j++)
            {
                //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
                string dest = dest_folder + funcname + ".csv";
                System.IO.StreamWriter dest_file_writer =
                   new System.IO.StreamWriter(dest);
                dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");


                for (int i = 1; i < number_of_points; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // измеритель времени, для каждой точки
                    swatch.Start();
                    double x = left_border_of_range + i * dx;
                    double F = f(x);
                    double benchmark = 0;
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / F);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
                }
                dest_file_writer.Close();
            }
        }

        /// <summary>
        /// Создает csv файлы с абсолютной и относительной погрешности для функций со следующими аргументами: X, Y, left_border_of_range, right_border_of_range
        /// </summary>
        /// <param name="funcname"></param>
        /// <param name="f"></param>
        static void MakeResultsSummaryFile(string funcname, Func<double, double, double> f, double left_border_of_range, double right_border_of_range) // x, y, lb, rb 
        {
            //генерирует файл .csv нужного формата
            string dest_folder = ("..\\..\\..\\csv\\");
            //мы хотим равномерно покрыть область определения (или хорошей сходимости) функции number_of_points точками. Подойдите к выбору области аккуратно.
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 100;
            double dx = range_length / number_of_points;
            double dy = range_length / number_of_points;
            for (int j = 1; j < number_of_points; j++)
            {
                double y = left_border_of_range + j * dy;
                //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
                string dest = dest_folder + funcname + "_y" + y.ToString() + ".csv";
                System.IO.StreamWriter dest_file_writer =
                    new System.IO.StreamWriter(dest);
                dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");

                for (int i = 1; i < number_of_points; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // измеритель времени, для каждой точки
                    swatch.Start();
                    double x = left_border_of_range + i * dx;
                    double F = f(x, y);
                    double benchmark = 0;
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / F);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
                }
                dest_file_writer.Close();
            }
        }
       
        /// <summary>
        /// Создает csv файлы с абсолютной и относительной погрешности для функций со следующими аргументами: X, A, left_border_of_range, right_border_of_range
        /// </summary>
        /// <param name="funcname"></param>
        /// <param name="f"></param>
        static void MakeResultsSummaryFile(string funcname, Func<double, double, double> f, double a, double left_border_of_range, double right_border_of_range) // x, a, lb, rb
        {
            //генерирует файл .csv нужного формата
            string dest_folder = ("..\\..\\..\\csv\\");
            //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
            string dest = dest_folder + funcname + "_a" + a.ToString() + ".csv";
            System.IO.StreamWriter dest_file_writer =
               new System.IO.StreamWriter(dest);
            dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");
            //мы хотим равномерно покрыть область определения (или хорошей сходимости) функции number_of_points точками. Подойдите к выбору области аккуратно.
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 100;
            double dx = range_length / number_of_points;
            double dy = range_length / number_of_points;
            for (int i = 1; i < number_of_points; i++)
            {
                System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // измеритель времени, для каждой точки
                swatch.Start();
                double x = left_border_of_range + i * dx;
                double F = f(x, a);
                double benchmark = 0;
                double absoluteError = Math.Abs((F - benchmark));
                double relativeError = Math.Abs((F - benchmark) / F);
                swatch.Stop();
                long t = swatch.ElapsedMilliseconds;
                dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
            }
            dest_file_writer.Close();
        }
        
        /// <summary>
        /// Создает csv файлы с абсолютной и относительной погрешности для функций со следующими аргументами: X, A, B, left_border_of_range, right_border_of_range
        /// </summary>
        /// <param name="funcname"></param>
        /// <param name="f"></param>
        static void MakeResultsSummaryFile(string funcname, Func<double, double, double, double> f, double a, double b, double left_border_of_range, double right_border_of_range) // x, a, b, lb, rb 
        {
            //генерирует файл .csv нужного формата
            string dest_folder = ("..\\..\\..\\csv\\");

            //мы хотим равномерно покрыть область определения (или хорошей сходимости) функции number_of_points точками. Подойдите к выбору области аккуратно.
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 100;
            double dx = range_length / number_of_points;

            for (int j = 1; j < number_of_points; j++)
            {
                //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
                string dest = dest_folder + funcname + "_a" + a.ToString() + "_b" + b.ToString() + ".csv";
                System.IO.StreamWriter dest_file_writer =
                    new System.IO.StreamWriter(dest);
                dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");

                for (int i = 1; i < number_of_points; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // измеритель времени, для каждой точки
                    swatch.Start();
                    double x = left_border_of_range + i * dx;
                    double F = f(x, a, b);
                    double benchmark = 0;
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / F);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
                }
                dest_file_writer.Close();
            }
        }
        
        /// <summary>
        /// Создает csv файлы с абсолютной и относительной погрешности для функций со следующими аргументами: X, Y, A, left_border_of_range, right_border_of_range
        /// </summary>
        /// <param name="funcname"></param>
        /// <param name="f"></param>
        static void MakeResultsSummaryFile(string funcname, Func<double, double, double, double> f, double a, double left_border_of_range, double right_border_of_range) // x, y, a, lb, rb
        {
            //генерирует файл .csv нужного формата
            string dest_folder = ("..\\..\\..\\csv\\");

            //мы хотим равномерно покрыть область определения (или хорошей сходимости) функции number_of_points точками. Подойдите к выбору области аккуратно.
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 100;
            double dx = range_length / number_of_points;
            double dy = range_length / number_of_points;

            for (int j = 1; j < number_of_points; j++)
            {
                double y = left_border_of_range + j * dy;
                //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
                string dest = dest_folder + funcname + "_y" + y.ToString() + "_a" + a.ToString() + ".csv";
                System.IO.StreamWriter dest_file_writer =
                    new System.IO.StreamWriter(dest);
                dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");

                for (int i = 1; i < number_of_points; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // измеритель времени, для каждой точки
                    swatch.Start();
                    double x = left_border_of_range + i * dx;
                    double F = f(x, y, a);
                    double benchmark = 0;
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / F);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
                }
                dest_file_writer.Close();
            }
        }
        
        /// <summary>
        /// Создает csv файлы с абсолютной и относительной погрешности для функций со следующими аргументами: X, N, B, left_border_of_range, right_border_of_range
        /// </summary>
        /// <param name="funcname"></param>
        /// <param name="f"></param>
        static void MakeResultsSummaryFile(string funcname, Func<double, int, double, double> f, int n, double b, double left_border_of_range, double right_border_of_range) // x, n, b, lb, rb
        {
            //генерирует файл .csv нужного формата
            string dest_folder = ("..\\..\\..\\csv\\");

            //мы хотим равномерно покрыть область определения (или хорошей сходимости) функции number_of_points точками. Подойдите к выбору области аккуратно.
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 100;
            double dx = range_length / number_of_points;

            for (int j = 1; j < number_of_points; j++)
            {
                //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
                string dest = dest_folder + funcname + "_n" + n.ToString() + "_b" + b.ToString() + ".csv";
                System.IO.StreamWriter dest_file_writer =
                    new System.IO.StreamWriter(dest);
                dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");

                for (int i = 1; i < number_of_points; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // измеритель времени, для каждой точки
                    swatch.Start();
                    double x = left_border_of_range + i * dx;
                    double F = f(x, n, b);
                    double benchmark = 0;
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / F);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
                }
                dest_file_writer.Close();
            }
        }


        // Костыль

        /// <summary>
        /// Создает csv файлы с абсолютной и относительной погрешности для функций со следующими аргументами: X, в интервале (-1, 1).
        /// Последний аргумент нигде не используется, нужен для выбора этой перегрузки
        /// </summary>
        /// <param name="funcname"></param>
        /// <param name="f"></param>
        static void MakeResultsSummaryFile(string funcname, Func<double, double> f, double right_border_of_range, double left_border_of_range, int for106) // x, lb, rb (-1, 1)
        {
            //генерирует файл .csv нужного формата
            string dest_folder = ("..\\..\\..\\csv\\");
            //мы хотим равномерно покрыть область определения (или хорошей сходимости) функции number_of_points точками. Подойдите к выбору области аккуратно.
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 10;
            double dx = range_length / number_of_points;
            for (int j = 1; j < number_of_points; j++)
            {
                //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
                string dest = dest_folder + funcname + ".csv";
                System.IO.StreamWriter dest_file_writer =
                   new System.IO.StreamWriter(dest);
                dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");

                for (int i = 1; i < number_of_points; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // измеритель времени, для каждой точки
                    swatch.Start();
                    double x = left_border_of_range + double.Epsilon + i * dx;
                    double F = f(x);
                    double benchmark = 0;
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / F);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
                }
                dest_file_writer.Close();
            }
        }


        static void makeErrorPlot(string source_csv_file_name)
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
                /* Выдает ошибку:
                Необработанное исключение: System.OverflowException: Значение было недопустимо малым или недопустимо льшим для Decimal.
                Не знаю, как пофиксить.. 4 if-а не работают
                */
                if (Convert.ToDouble(fields[0]) >= 1e+50) { fields[0] = "NaN"; }
                if (Convert.ToDouble(fields[2]) >= 1e+50) { fields[0] = "NaN"; }
                if (Convert.ToDouble(fields[0]) <= 1e-50) { fields[0] = "0"; }
                if (Convert.ToDouble(fields[2]) <= 1e-50) { fields[0] = "0"; }

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

        static void makeErrorPlots(string source_csv_folder_name) //в директории не должно быть лишнего, считаем, что там только csv, при том, нужного формата
        {
            foreach (String source_csv_file_name in System.IO.Directory.GetFiles(source_csv_folder_name))
                makeErrorPlot(source_csv_file_name);
        }
    
    
    }
    
}

//старый вариант для создания csv файлов без циклов
/*
        double left_range_border = -100.0;
        double right_range_border = 100.0;
        double range = Math.Abs(left_range_border) + Math.Abs(right_range_border);
        int number_of_points = 100;
        double dx = range / number_of_points;
        double dy = range / number_of_points;
        double benchmark = 0;

        double x = 0;
        double y = 0;

        double absoluteError = 0;
        double relativeError = 0;


        System.IO.StreamWriter file86 =
        new System.IO.StreamWriter(@"csv\L00_86_1_th.csv");
        file86.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");
        for (int i = 0; i <= number_of_points; i++)
        {
            System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
            swatch.Start();
            x = left_range_border + i * dx;
            double F86 = CL00_86_1_th.L00_86_1_th(x);
            absoluteError = Math.Abs((F86 - benchmark));
            relativeError = Math.Abs((F86 - benchmark) / F86);
            swatch.Stop();
            long t = swatch.ElapsedMilliseconds;
            file86.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());
        }
        file86.Close();


        System.IO.StreamWriter file87 =
                    new System.IO.StreamWriter(@"csv\L00_87_2_sh_ch.csv");
        file87.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            x = left_range_border + i * dx;
            y = left_range_border + i * dy;
            double F87 = CL00_87_2_sh_ch.L00_87_2_sh_ch(x, y);
            absoluteError = Math.Abs((F87 - benchmark));
            relativeError = Math.Abs((F87 - benchmark) / F87);
            file87.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file87.Close();

        System.IO.StreamWriter file88 =
                    new System.IO.StreamWriter(@"csv\L00_88_2_sh_ch.csv");
        file88.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {

            x = left_range_border + i * dx;
            y = left_range_border + i * dy;
            double F88 = CL00_88_2_sh_ch.L00_88_2_sh_ch(x, y);
            absoluteError = Math.Abs((F88 - benchmark));
            relativeError = Math.Abs((F88 - benchmark) / F88);
            file88.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file88.Close();

        System.IO.StreamWriter file89 =
                    new System.IO.StreamWriter(@"csv\L00_89_2_ch.csv");
        file89.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            x = left_range_border + i * dx;
            y = left_range_border + i * dy;
            double F89 = CL00_89_2_ch.L00_89_2_ch(x, y);
            absoluteError = Math.Abs((F89 - benchmark));
            relativeError = Math.Abs((F89 - benchmark) / F89);
            file89.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file89.Close();

        System.IO.StreamWriter file90 =
        new System.IO.StreamWriter(@"csv\L00_90_2_ch_sh.csv");
        file90.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            x = left_range_border + i * dx;
            y = left_range_border + i * dy;
            double F90 = CL00_90_2_ch_sh.L00_90_2_ch_sh(x, y);
            absoluteError = Math.Abs((F90 - benchmark));
            relativeError = Math.Abs((F90 - benchmark) / F90);
            file90.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file90.Close();

        System.IO.StreamWriter file91 =
        new System.IO.StreamWriter(@"csv\L00_91_2_th_sh_ch.csv");
        file91.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            x = left_range_border + i * dx;
            y = left_range_border + i * dy;
            double F91 = CL00_91_2_th_sh_ch.L00_91_2_th_sh_ch(x, y);
            absoluteError = Math.Abs((F91 - benchmark));
            relativeError = Math.Abs((F91 - benchmark) / F91);
            file91.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file91.Close();

        System.IO.StreamWriter file92 =
        new System.IO.StreamWriter(@"csv\L00_92_2_th_sh_ch.csv");
        file92.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            x = left_range_border + i * dx;
            y = left_range_border + i * dy;
            double F92 = CL00_92_2_th_sh_ch.L00_92_2_th_sh_ch(x, y);
            absoluteError = Math.Abs((F92 - benchmark));
            relativeError = Math.Abs((F92 - benchmark) / F92);
            file92.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file92.Close();

        System.IO.StreamWriter file93 =
        new System.IO.StreamWriter(@"csv\L00_93_2_cth_sh.csv");
        file93.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            x = i * dx + 1; //+1, т.к. при х=0 функция не определена
            y = i * dy + 1; //+1, т.к. при у=0 функция не определена
            double F93 = CL00_93_2_cth_sh.L00_93_2_cth_sh(x, y);
            absoluteError = Math.Abs((F93 - benchmark));
            relativeError = Math.Abs((F93 - benchmark) / F93);
            file93.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file93.Close();

        System.IO.StreamWriter file94 =
        new System.IO.StreamWriter(@"csv\L00_94_2_cth_sh.csv");
        file94.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            x = i * dx + 1;
            y = i * dy + 1;
            double F94 = CL00_94_2_cth_sh.L00_94_2_cth_sh(x, y);
            absoluteError = Math.Abs((F94 - benchmark));
            relativeError = Math.Abs((F94 - benchmark) / F94);
            file94.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file94.Close();

        System.IO.StreamWriter file95 =
                    new System.IO.StreamWriter(@"csv\L00_95_2_sh.csv");
        file95.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            x = left_range_border + i * dx;
            y = left_range_border + i * dy;
            double F95 = CL00_95_2_sh.L00_95_2_sh(x, y);
            absoluteError = Math.Abs((F95 - benchmark));
            relativeError = Math.Abs((F95 - benchmark) / F95);
            file95.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file95.Close();

        System.IO.StreamWriter file96 =
                    new System.IO.StreamWriter(@"csv\L00_96_2_ch_sh.csv");
        file96.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            x = left_range_border + i * dx;
            y = left_range_border + i * dy;
            double F96 = CL00_96_2_ch_sh.L00_96_2_ch_sh(x, y);
            absoluteError = Math.Abs((F96 - benchmark));
            relativeError = Math.Abs((F96 - benchmark) / F96);
            file96.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file96.Close();

        System.IO.StreamWriter file97 =
                    new System.IO.StreamWriter(@"csv\L00_97_2_sh_ch.csv");
        file97.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            x = left_range_border + i * dx;
            y = left_range_border + i * dy;
            double F97 = CL00_97_2_sh_ch.L00_97_2_sh_ch(x, y);
            absoluteError = Math.Abs((F97 - benchmark));
            relativeError = Math.Abs((F97 - benchmark) / F97);
            file97.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file97.Close();

        System.IO.StreamWriter file98 =
                    new System.IO.StreamWriter(@"csv\L00_98_2_sh_ch.csv");
        file98.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            double dx0 = 20.0 / number_of_points;
            double dy0 = 20.0 / number_of_points;
            x = -10 + i * dx0;
            y = -10 + i * dy0;
            double F98 = CL00_98_2_sh_ch.L00_98_2_sh_ch(x, y);
            absoluteError = Math.Abs((F98 - benchmark));
            relativeError = Math.Abs((F98 - benchmark) / F98);
            file98.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file98.Close();

        System.IO.StreamWriter file99 =
                    new System.IO.StreamWriter(@"csv\L00_99_2_log.csv");
        file99.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            x = i * dx + 2;
            y = i * dy + 2;
            double F99 = CL00_99_2_log.L00_99_2_log(x, y);
            absoluteError = Math.Abs((F99 - benchmark));
            relativeError = Math.Abs((F99 - benchmark) / F99);
            file99.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file99.Close();

        System.IO.StreamWriter file100 =
                    new System.IO.StreamWriter(@"csv\L00_100_3_log.csv");
        file100.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            x = i * dx + 1;
            y = i * dy + 1;
            double F100 = CL00_100_3_log.L00_100_3_log(x, y);
            absoluteError = Math.Abs((F100 - benchmark));
            relativeError = Math.Abs((F100 - benchmark) / F100);
            file100.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file100.Close();

        System.IO.StreamWriter file101 =
                    new System.IO.StreamWriter(@"csv\L00_101_3_log.csv");
        file101.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            x = i * dx + 1;
            y = i * dy + 1;
            double F101 = CL00_101_3_log.L00_101_3_log(x, y);
            absoluteError = Math.Abs((F101 - benchmark));
            relativeError = Math.Abs((F101 - benchmark) / F101);
            file101.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file101.Close();

        System.IO.StreamWriter file102 =
                    new System.IO.StreamWriter(@"csv\L00_102_3_log.csv");
        file102.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            x = i * dx + 1;
            double F102 = CL00_102_3_log.L00_102_3_log(x);
            absoluteError = Math.Abs((F102 - benchmark));
            relativeError = Math.Abs((F102 - benchmark) / F102);
            file102.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file102.Close();

        System.IO.StreamWriter file103 =
                    new System.IO.StreamWriter(@"csv\L00_103_3_log.csv");
        file103.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            x = i * dx + 1;
            double F103 = CL00_103_3_log.L00_103_3_log(x);
            absoluteError = Math.Abs((F103 - benchmark));
            relativeError = Math.Abs((F103 - benchmark) / F103);
            file103.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file103.Close();

        System.IO.StreamWriter file104 =
                    new System.IO.StreamWriter(@"csv\L00_104_1_ln_arsh.csv");
        file104.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            x = left_range_border + i * dx;
            double F104 = CL00_104_1_ln_arsh.L00_104_1_ln_arsh(x);
            absoluteError = Math.Abs((F104 - benchmark));
            relativeError = Math.Abs((F104 - benchmark) / F104);
            file104.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file104.Close();

        System.IO.StreamWriter file105 =
                    new System.IO.StreamWriter(@"csv\L00_105_1_ln_arch.csv");
        file105.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            x = i * dx + 2;
            double F105 = CL00_105_1_ln_arch.L00_105_1_ln_arch(x);
            absoluteError = Math.Abs((F105 - benchmark));
            relativeError = Math.Abs((F105 - benchmark) / F105);
            file105.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file105.Close();

        System.IO.StreamWriter file106 =
        new System.IO.StreamWriter(@"csv\L00_106_1_ln_arth.csv");
        file106.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            double dx1 = 1.99 / number_of_points;
            x = i * dx1 - 0.999;
            double F106 = CL00_106_1_ln_arth.L00_106_1_ln_arth(x);
            absoluteError = Math.Abs((F106 - benchmark));
            relativeError = Math.Abs((F106 - benchmark) / F106);
            file106.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file106.Close();

        System.IO.StreamWriter file107 =
        new System.IO.StreamWriter(@"csv\L00_107_2_pow_exp.csv");
        file107.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            x = left_range_border + i * dx;
            double F107 = CL00_107_2_pow_exp.L00_107_2_pow_exp(x);
            absoluteError = Math.Abs((F107 - benchmark));
            relativeError = Math.Abs((F107 - benchmark) / F107);
            file107.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file107.Close();
        //-------------------------------------// большие значения при х>40

        System.IO.StreamWriter file108 =
        new System.IO.StreamWriter(@"csv\L00_108_3_pow.csv");
        file108.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            x = left_range_border + i * dx;
            y = left_range_border + i * dy;
            double F108 = CL00_108_3_pow.L00_108_3_pow(x, y);
            absoluteError = Math.Abs((F108 - benchmark));
            relativeError = Math.Abs((F108 - benchmark) / F108);
            file108.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file108.Close();
        //-------------------------------------// NaaaaaN дичь

        System.IO.StreamWriter file109 =
        new System.IO.StreamWriter(@"csv\L00_109_3_pow.csv");
        file109.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            x = left_range_border + i * dx;
            y = left_range_border + i * dy;
            double F109 = CL00_109_3_pow.L00_109_3_pow(x, y);
            absoluteError = Math.Abs((F109 - benchmark));
            relativeError = Math.Abs((F109 - benchmark) / F109);
            file109.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file109.Close();

        System.IO.StreamWriter file110 =
        new System.IO.StreamWriter(@"csv\L00_110_3_pow.csv");
        file110.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            x = left_range_border + i * dx;
            y = left_range_border + i * dy;
            double F110 = CL00_110_3_pow.L00_110_3_pow(x, y);
            absoluteError = Math.Abs((F110 - benchmark));
            relativeError = Math.Abs((F110 - benchmark) / F110);
            file110.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file110.Close();
        //-------------------------------------// NaaaaaN дичь при |x|>30

        System.IO.StreamWriter file111 =
        new System.IO.StreamWriter(@"csv\L00_111_1_exp_th.csv");
        file111.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            x = left_range_border + i * dx;
            double F111 = CL00_111_1_exp_th.L00_111_1_exp_th(x);
            absoluteError = Math.Abs((F111 - benchmark));
            relativeError = Math.Abs((F111 - benchmark) / F111);
            file111.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file111.Close();
        //-------------------------------------// значительно больше нуля при x > 10

        System.IO.StreamWriter file112 =
        new System.IO.StreamWriter(@"csv\L00_112_1_exp_ch_sh.csv");
        file112.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            x = i * dx + 1;
            double F112 = CL00_112_1_exp_ch_sh.L00_112_1_exp_ch_sh(x);
            absoluteError = Math.Abs((F112 - benchmark));
            relativeError = Math.Abs((F112 - benchmark) / F112);
            file112.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file112.Close();
        //-------------------------------------// большие значения при x > 10

        System.IO.StreamWriter file113 =
        new System.IO.StreamWriter(@"csv\L00_113_1_ch_sh_th.csv");
        file113.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

        for (int i = 0; i <= number_of_points; i++)
        {
            x = i * dx + 1;
            double F113 = CL00_113_1_ch_sh_th.L00_113_1_ch_sh_th(x);
            absoluteError = Math.Abs((F113 - benchmark));
            relativeError = Math.Abs((F113 - benchmark) / F113);
            file113.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
        }
        file113.Close();
        //-------------------------------------// большие значения при x > 10
*/
