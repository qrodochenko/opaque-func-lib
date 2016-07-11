using System;
using OpaqueFunctions;

namespace SummerPractice_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Summer Practice! Yay!");
            Console.ReadKey();


            System.IO.StreamWriter file1 =
            new System.IO.StreamWriter(@"D:\programing\opaque-func-lib\Golubev\csv\priv_sin_2.csv");
            file1.WriteLine("x" + ';'+"new_x"+';' + "absoluteError" + ';' + "relativeError"+';'+"standart"+';'+ "converted");
            double x = -50;
            for (int i = 1; i < 1000; i++)
            {
            
                double step = 1.0 / 10.0;
                x += step;
                double standart = Math.Sin(x);
                OpaqueFunctions.C_build_func func = OpaqueFunctions.C_priv_sin_2.priv_sin_2(x);
                int sign = 1;
                if (string.Compare(func.sign, "-") == 0)
                    sign = -1;
                double converted = sign * Math.Sin(func.argument);
                double absoluteError = Math.Abs(standart - converted);          
                double relativeError = Math.Abs((standart - converted) / converted);
                file1.WriteLine(x.ToString() + ';'+ func.argument.ToString()+';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + standart.ToString() + ';' + converted.ToString());
            
            }
            file1.Close();

            System.IO.StreamWriter file2 =
            new System.IO.StreamWriter(@"D:\programing\opaque-func-lib\Golubev\csv\priv_sin_3.csv");
            file2.WriteLine("x" + ';' + "new_x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "standart" + ';' + "converted");
            x = -50;
            for (int i = 1; i < 1000; i++)
            {

                double step = 1.0 / 10.0;
                x += step;
                double standart = Math.Sin(x);
                OpaqueFunctions.C_build_func func = OpaqueFunctions.C_priv_sin_3.priv_sin_3(x);
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
                file2.WriteLine(x.ToString() + ';' + func.argument.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + standart.ToString() + ';' + converted.ToString());

            }
            file2.Close();

            System.IO.StreamWriter file3 =
            new System.IO.StreamWriter(@"D:\programing\opaque-func-lib\Golubev\csv\priv_cos_3.csv");
            file3.WriteLine("x" + ';' + "new_x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "standart" + ';' + "converted");
            x = -50;
            for (int i = 1; i < 1000; i++)
            {

                double step = 1.0 / 10.0;
                x += step;
                double standart = Math.Cos(x);
                OpaqueFunctions.C_build_func func = OpaqueFunctions.C_priv_cos_3.priv_cos_3(x);
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
                file3.WriteLine(x.ToString() + ';' + func.argument.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + standart.ToString() + ';' + converted.ToString());

            }
            file3.Close();

            System.IO.StreamWriter file4 =
            new System.IO.StreamWriter(@"D:\programing\opaque-func-lib\Golubev\csv\priv_tan_6.csv");
            file4.WriteLine("x" + ';' + "new_x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "standart" + ';' + "converted");
            x = -50;
            for (int i = 1; i < 1000; i++)
            {

                double step = 1.0 / 10.0;
                x += step;
                double standart = Math.Tan(x);
                OpaqueFunctions.C_build_func func = OpaqueFunctions.C_priv_tan_6.priv_tan_6(x);
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
                file4.WriteLine(x.ToString() + ';' + func.argument.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + standart.ToString() + ';' + converted.ToString());

            }
            file4.Close();

            System.IO.StreamWriter file5 =
            new System.IO.StreamWriter(@"D:\programing\opaque-func-lib\Golubev\csv\priv_ctg_6.csv");
            file5.WriteLine("x" + ';' + "new_x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "standart" + ';' + "converted");
            x = -50;
            for (int i = 1; i < 1000; i++)
            {

                double step = 1.0 / 10.0;
                x += step;
                double standart = 1/Math.Tan(x);
                OpaqueFunctions.C_build_func func = OpaqueFunctions.C_priv_ctg_6.priv_ctg_6(x);
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
                file5.WriteLine(x.ToString() + ';' + func.argument.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + standart.ToString() + ';' + converted.ToString());

            }
            file5.Close();

        }
    }
}
