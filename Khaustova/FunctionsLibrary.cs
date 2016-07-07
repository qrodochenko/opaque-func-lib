using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsLibrary
{
    // (w, w) -> (w, w)
    // g(x) = (x + A)^(2k + 1) + B
    // g_inv(x) = (x - B)^(1/(2k + 1)) - A

    /// <summary>
    /// Реализует функцию g(x) = (x + A)^(2k + 1) + B,  
    /// где аргумент X задается параметром <paramref name="x"/>,
    /// который удовлетворяет интервалу (w, w).
    /// Числовые коэффициенты - <paramref name="A"/>, <paramref name="B"/>, <paramref name="k"/>,
    /// где k - целое число.
    /// Результатом функции является число, которое получается при подстановке 
    /// параметра x и числовых коэффициентов в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="A">коэффициент A</param>
    /// <param name="B">коэффициент B</param>
    /// <param name="k">коэффициент k, определяет степень</param>
    /// <returns>double</returns>
    [FunctionInterval()]
    [FunctionName("interval_ww_ww_1", "g(x) = (x + A)^(2k + 1) + B")]
    //[EquivalentIntConstant(1)]
    public class Cinterval_ww_ww_1
    {
        public static double interval_ww_ww_1(double x, double A, double B, int k)
        {
            double t = x + A;
            double p = 2 * k + 1;

            return (Math.Pow(t, p) + B);
        }
    }

    public class Cinterval_ww_ww_1_in
    {
        public static string interval_ww_ww_1_in()
         {
             return "(w, w)";
         }
    }

    public class Cinterval_ww_ww_1_inv
    {
        public static double interval_ww_ww_1_inv(double x, double A, double B, int k)
        {
            if (x >= B)
            {
                double t = x - B;
                double p = 1f / (double)(2 * k + 1);

                return (Math.Pow(t, p) - A);
            }
            else
            {
                double t = B - x;
                double p = 1f / (double)(2 * k + 1);

                return (-Math.Pow(t, p) - A);
            }
        }
    }

    
    //(w, w) -> (-1, 1)
    // g(x) = x / sqrt(x*x + C)
    // g_inv(x) = sqrt(C) * x * sqrt(1 - x*x)
    public class Cinterval_ww_finfin_2
    {
        public static double interval_ww_finfin_2(double x, double C)
        {
            if (C <= 0) return 0;
            else
            {
                return (x / Math.Sqrt(x * x + C));
            }
        }
    }


    public class Cinterval_ww_finfin_2_in
    {
        public static string interval_ww_finfin_2_in()
        {
            return "(w, w)";
        }
    }


    public class Cinterval_ww_finfin_2_inv
    {
        public static double interval_ww_finfin_2_inv(double x, double C)
        {
            if (C <= 0) return 0;
            if (Math.Abs(x) > 1+double.Epsilon) return 0;  
            else if ((Math.Abs(x) == 1+double.Epsilon) || (Math.Abs(x) == 1 - double.Epsilon))
                return (Math.Sqrt(C) * x * Math.Sqrt(0 + double.Epsilon));
            else return (Math.Sqrt(C) * x * Math.Sqrt(1 - x * x));
        }
    }

    //(-Pi/2, Pi/2) -> (w, w)
    //g(x) = tg(x)
    //g_inv(x) = arctg(x)
    public class Cinterval_finfin_ww_3
    {
        public static double interval_finfin_ww_3(double x)
        {
            if (Math.Cos(x) == 0) return 0;
            else return (Math.Tan(x));
        }
    }


    public class Cinterval_finfin_ww_3_in
    {
        public static string interval_finfin_ww_3_in()
        {
            return "(-Pi/2, Pi/2)";
        }
    }


    public class Cinterval_finfin_ww_3_inv
    {
        public static double interval_finfin_ww_3_inv(double x)
        {
            return (Math.Atan(x));
        }

    }

    //(0, w) -> (0, w)
    //g(x) = 1 / x
    //g_inv(x) = 1 / x
    public class Cinterval_finw_finw_4
    {
        public static double interval_finw_finw_4(double x)
        {
            if (x != 0) return (1 / x); else return 0;
        }
    }

    public class Cinterval_finw_finw_4_in
    {
        public static string interval_finw_finw_4_in()
        {
            return "(0, w)";
        }
    }

    public class Cinterval_finw_finw_4_inv
    {
        public static double interval_finw_finw_4_inv(double x)
        {
            if (x != 0) return (1 / x); else return 0;
        }
    }


    //(0, w) -> (w, 0)
    //g(x) = -x
    //g_inv(x) = -x
    public class Cinterval_finw_wfin_5
    {
        public static double interval_finw_wfin_5(double x)
        {
            return (-x);
        }
    }

    public class Cinterval_finw_wfin_5_in
    {
        public static string interval_finw_wfin_5_in()
        {
            return "(0, w)";
        }
    }

    public class Cinterval_finw_wfin_5_inv
    {
        public static double interval_finw_wfin_5_inv(double x)
        {
            return (-x);
        }
    }

    //(w, w) -> (0, w)
    //g(x) = A*exp(x + B)
    //g_inv(x) = ln(x / A) - B
    public class Cinterval_ww_finw_6
    {
        public static double interval_ww_finw_6(double A, double B, double x)
        {
            return (A * Math.Exp(x + B));
        }
    }


    public class Cinterval_ww_finw_6_in
    {
        public static string interval_ww_finw_6_in()
        {
            return "(w, w)";
        }
    }


    public class Cinterval_ww_finw_6_inv
    {
        public static double interval_ww_finw_6_inv(double A, double B, double x)
        {
            if (A <= 0) return 0;
            if (Math.Abs(x) < double.Epsilon) return 0;
            else return (Math.Log(x / A) - B);
        }
    }


    //(a, b) -> (c, d)
    //g(x) = ((c - d)/(a -b)) * x + (ad - bc) / (a - b)
    //g_inv(x) = ((a - b)/(c -d)) * x + (bc - ad) / (c - d)
    public class Cinterval_finfin_finfin_7
    {
        public static double interval_finfin_finfin_7(double a, double b, double c, double d, double x)
        {
            if (a != 0 && b != 0 && a != b && c != d)
                return (((c - d) / (a - b)) * x + (a * d - b * c) / (a - b));
            else return 0;
        }
    }


    public class Cinterval_finfin_finfin_7_in
    {
        public static string interval_finfin_finfin_7_in(double a, double b)
        {

            string a1 = Convert.ToString(a);
            string b1 = Convert.ToString(b);
            string s = "(" + a1 + ", " + b1 + ")";
            return s;
        }
    }


    public class Cinterval_finfin_finfin_7_inv
    {
        public static double interval_finfin_finfin_7_inv(double a, double b, double c, double d, double x)
        {
            if (c != 0 && d != 0 && a != b && c != d)
                return (((a - b) / (c - d)) * x + (b*c - a*d) / (c - d));
            else return 0;
        }
    }



    //(a, b) -> (c, d)
    //g(x) = (ab*(d - c)/(a - b)) / x + (ac - bd) / (a - b)
    //g_inv(x) = (cd*(b - a)/(c -d)) / x + (ca - bd) / (c - d)
    public class Cinterval_finfin_finfin_8
    {
        public static double interval_finfin_finfin_8(double a, double b, double c, double d, double x)
        {
            if (a != 0 && b != 0 && a != b && c != d && x!=0)
                return (((d - c) * a * b / (a - b)) / x + (a * c - b * d) / (a - b));
            else return 0;
        }
    }


    public class Cinterval_finfin_finfin_8_in
    {
        public static string interval_finfin_finfin_8_in(double a, double b)
        {

            string a1 = Convert.ToString(a);
            string b1 = Convert.ToString(b);
            string s = "(" + a1 + ", " + b1 + ")";
            return s;
        }
    }


    public class Cinterval_finfin_finfin_8_inv
    {
        public static double interval_finfin_finfin_8_inv(double a, double b, double c, double d, double x)
        {
            if (c != 0 && d != 0 && a != b && c != d && x!=0)
                return (((b - a) * c * d / (c - d)) / x + (c * a - b * d) / (c - d));
            else return 0;
        }
    }


    //(-Pi/2, Pi/2) -> (-1, 1)
    //g(x) = sin(x)
    //g_inv(x) = arcsin(x)
    public class Cinterval_finfin_finfin_9
    {
        public static double interval_finfin_finfin_9(double x)
        {
            if (Math.Abs(x) < Math.PI / 2 + double.Epsilon) return (Math.Sin(x));
            else return 0;
        }
    }


    public class Cinterval_finfin_finfin_9_in
    {
        public static string interval_finfin_finfin_9_in()
        {
            return "(-Pi/2, Pi/2)";
        }
    }


    public class Cinterval_finfin_finfin_9_inv
    {
        public static double interval_finfin_finfin_9_inv(double x)
        {
            if (Math.Abs(x) < 1 + double.Epsilon) return (Math.Asin(x));
            else return 0;
        }

    }


    //(0, Pi) -> (-1, 1)
    //g(x) = cos(x)
    //g_inv(x) = arccos(x)
    public class Cinterval_finfin_finfin_10
    {
        public static double interval_finfin_finfin_10(double x)
        {
            if ((x > double.Epsilon) && (x < Math.PI + double.Epsilon)) return (Math.Cos(x));
            else return 0;
        }
    }


    public class Cinterval_finfin_finfin_10_in
    {
        public static string interval_finfin_finfin_10_in()
        {
            return "(0, Pi)";
        }
    }


    public class Cinterval_finfin_finfin_10_inv
    {
        public static double interval_finfin_finfin_10_inv(double x)
        {
            if (Math.Abs(x) < 1 + double.Epsilon) return (Math.Acos(x));
            else return 0;
        }

    }

}
