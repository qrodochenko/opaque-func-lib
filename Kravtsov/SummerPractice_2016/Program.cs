/*using System;
using OpaqueFunctions;
namespace SummerPractice_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            double Xc = CCos_1.Cos_1(Math.PI / 4.0, 20);
            double X1c = Math.Cos(Math.PI / 4.0);
            Console.WriteLine("Cos check");
            Console.WriteLine(Xc);
            Console.WriteLine(X1c);

            double Xs = CSin_1.Sin_1(Math.PI / 4.0, 20);
            double X1s = Math.Sin(Math.PI / 4.0);
            Console.WriteLine("Sin check");
            Console.WriteLine(Xs);
            Console.WriteLine(X1s);

            double Xarcs = CArcsin_1.Arcsin_1(0.4, 400000);
            double Xarcs1 = Math.Asin(0.4);
            Console.WriteLine("Arcsin check");
            Console.WriteLine(Xarcs);
            Console.WriteLine(Xarcs1);

            double Xarcc = CArccos_1.Arccos_1(0.5, 400000);
            double Xarcc1 = Math.Acos(0.5);
            Console.WriteLine("ArcCos check");
            Console.WriteLine(Xarcc);
            Console.WriteLine(Xarcc1);

            double Xtg = CTg_1.Tg_1(Math.PI / 3.0, 10);
            double Xtg1 = Math.Tan(Math.PI / 3.0);
            Console.WriteLine("Tg check");
            Console.WriteLine(Xtg);
            Console.WriteLine(Xtg1);


            double Xctg = Cctg_1.Сtg_1(Math.PI / 4.0, 10);
            double Xctg1 = 1 / Math.Tan(Math.PI / 4.0);
            Console.WriteLine("Ctg check");
            Console.WriteLine(Xctg);
            Console.WriteLine(Xctg1);

            double Xarctg = CArctg_1.Arctg_1(0.3, 10);
            double Xarctg1 = Math.Atan(0.3);
            Console.WriteLine("Arctg check");
            Console.WriteLine(Xarctg);
            Console.WriteLine(Xarctg1);

            double Xarcctg = CArcctg_1.Arcctg_1(0, 15);
            double Xarcctg1 = Math.PI / 2.0 - Math.Atan(0);
            Console.WriteLine("Arcctg check");
            Console.WriteLine(Xarcctg);
            Console.WriteLine(Xarcctg1);

            double Xcosec = CCosec_1.Cosec_1(Math.PI / 2.0, 13);
            double Xcosec1 = 1 / Math.Sin(Math.PI / 2.0);
            Console.WriteLine("Cosec check");
            Console.WriteLine(Xcosec);
            Console.WriteLine(Xcosec1);

            double Xs2 = CXpow2_Sin_1.Xpow2_Sin_1(Math.PI / 4.0, 10);
            double X1s2 = Math.Sin(Math.PI / 4.0);
            X1s2 *= X1s2;
            Console.WriteLine("Sin^2 check");
            Console.WriteLine(Xs2);
            Console.WriteLine(X1s2);

            double Xc2 = CXpow2_Cos_1.Xpow2_Cos_1(Math.PI / 4.0, 10);
            double X1c2 = Math.Cos(Math.PI / 4.0);
            X1c2 *= X1c2;
            Console.WriteLine("Cos^2 check");
            Console.WriteLine(Xc2);
            Console.WriteLine(X1c2);

            double Xs3 = CXpow3_Sin_1.Xpow3_Sin_1(Math.PI / 4.0, 10);
            double X1s3 = Math.Sin(Math.PI / 4.0);
            X1s3 *= X1s3 * X1s3;
            Console.WriteLine("Sin^3 check");
            Console.WriteLine(Xs3);
            Console.WriteLine(X1s3);

            double Xc3 = CXpow3_Cos_1.Xpow3_Cos_1(Math.PI / 4.0, 10);
            double X1c3 = Math.Cos(Math.PI / 4.0);
            X1c3 *= X1c3 * X1c3;
            Console.WriteLine("Cos^3 check");
            Console.WriteLine(Xc3);
            Console.WriteLine(X1c3);
        }
    }
}
*/
using System;
using System.Collections.Generic;
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
          /*  for (int n = 18; n <= 20; n ++ ) 
            {
               // int n = 4000000;
                MakeResultsSummaryFile("Xpow3_Cos_1", CXpow3_Cos_1.Xpow3_Cos_1, n);
                string offset = "..\\..\\..\\"; // чтобы выходные файлы оказались точно в папке с фамилией  
                string source_csv_folder_name = offset + "csv"; // пусть папка для файлов с отчётами .csv называется так.
                makeErrorPlots(source_csv_folder_name);
            } */
        }

        /* static void MakeResultsSummaryFile(string funcname, Func<double, int, double> f, int N)
        {
            //генерирует файл .csv нужного формата
            string dest_folder = ("..\\..\\..\\csv\\");
            //здесь добавлено только количество итераций в файл. У вас другие параметры? По аналогии.
            string dest = dest_folder + funcname + "_N" + N.ToString() + ".csv";
            System.IO.StreamWriter dest_file_writer =
               new System.IO.StreamWriter(dest);
            dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");
            //мы хотим равномерно покрыть область определения (или хорошей сходимости) функции number_of_points точками. Подойдите к выбору области аккуратно.
            double left_border_of_range = -Math.PI + 1e-3;
            double right_border_of_range = Math.PI - 1e-3;
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 200;
            double dx = range_length / number_of_points;
            for (int i = 1; i < number_of_points; i++)
            {
                System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // измеритель времени, для каждой точки
                swatch.Start();
                double x = left_border_of_range + i * dx;
                double F = f(x, N);
                double benchmark = Math.Cos(x) * Math.Cos(x)*Math.Cos(x);
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

}
        */
















