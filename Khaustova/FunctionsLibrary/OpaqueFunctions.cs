#define DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OpaqueFunctions

{
    public class OpaqueException : Exception 
    {
        public OpaqueException() : base ("Argument is out of range")
        {

        }

    }


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
    [FunctionAttributes()]
    [FunctionName("interval_ww_ww_1", "g(x) = Pow((x + A), (2k + 1)) + B")]
    public class Cinterval_ww_ww_1
    {
        public static double interval_ww_ww_1(double x, double A, double B, int k)
        {
            double t = x + A;
            double p = 2 * k + 1;

            return (Math.Pow(t, p) + B);
        }
    }


    /// <summary>
    /// Возвращает область определения функции g(x) = (x + A)^(2k + 1) + B,  
    /// (w, w).
    /// <returns>string</returns>
    [FunctionAttributes()]
    [FunctionName("interval_ww_ww_1_in", "(w, w)")]
    public class Cinterval_ww_ww_1_in
    {
        public static string interval_ww_ww_1_in()
         {
             return "(w, w)";
         }
    }


    /// <summary>
    /// Реализует функцию g_inv(x) = (x - B)^(1/(2k + 1)) - A,  
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
    [FunctionAttributes()]
    [FunctionName("interval_ww_ww_1_inv", "g_inv(x) = Pow((x - B), (1/(2k + 1))) - A")]
    public class Cinterval_ww_ww_1_inv
    {
        public static double interval_ww_ww_1_inv(double x, double A, double B, int k)
        {
            if (x > B)
            {
                double t = x - B;
                double p = 1.0 / (2 * k + 1);

                return (Math.Pow(t, p) - A);
            }
            else if (Math.Abs(x - B) < double.Epsilon) return (-A);
            else
            {
                double t = B - x;
                double p = 1.0 / (2 * k + 1);

                return (-Math.Pow(t, p) - A);
            }
        }
    }




    /// <summary>
    /// Реализует функцию g(x) = x / sqrt(x*x + C),  
    /// где аргумент X задается параметром <paramref name="x"/>,
    /// который удовлетворяет интервалу (w, w).
    /// Числовой коэффициент C > 0 - <paramref name="С"/>
    /// Результатом функции является число, которое получается при подстановке 
    /// параметра x и числового коэффициента C в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="C">коэффициент C > 0</param>
    /// <returns>double</returns>
    [FunctionAttributes()]
    [FunctionName("interval_ww_finfin_2", "g(x) = x / Sqrt(x*x + C)")]
    public class Cinterval_ww_finfin_2
    {
        public static double interval_ww_finfin_2(double x, double C)
        {
#if DEBUG
            if (C < double.Epsilon)
            {
                throw new OpaqueException();
            }
#endif
            return (x / Math.Sqrt(x * x + C)); 
        }
    }

    /// <summary>
    /// Возвращает область определения функции g(x) = x / sqrt(x*x + C),  
    /// (w, w).
    /// <returns>string</returns>
    [FunctionAttributes()]
    [FunctionName("interval_ww_finfin_2_in", "(w, w)")]
    public class Cinterval_ww_finfin_2_in
    {
        public static string interval_ww_finfin_2_in()
        {
            return "(w, w)";
        }
    }


    /// Опечатка! g_inv(x) = sqrt(C) * x * sqrt(1 - x*x)
    /// Заменено на функцию - g_inv(x) = sqrt(C) * x / sqrt(1 - x*x)
    /// <summary>
    /// Реализует функцию g_inv(x) = sqrt(C) * x / sqrt(1 - x*x),  
    /// где аргумент X задается параметром <paramref name="x"/>,
    /// который удовлетворяет интервалу (-1, 1).
    /// Числовой коэффициент C > 0 - <paramref name="С"/>
    /// Результатом функции является число, которое получается при подстановке 
    /// параметра x и числового коэффициента C в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="C">коэффициент C > 0</param>
    /// <returns>double</returns>
    [FunctionAttributes()]
    [FunctionName("interval_ww_finfin_2_inv", "g_inv(x) = Sqrt(C) * x / Sqrt(1 - x*x)")]
    public class Cinterval_ww_finfin_2_inv
    {
        public static double interval_ww_finfin_2_inv(double x, double C)
        {

#if DEBUG
            if ( Math.Abs(x) >= 1 + double.Epsilon || Math.Abs(x) >= 1 - double.Epsilon )
            {
                throw new OpaqueException();
            }
#endif

#if DEBUG
            if (C < double.Epsilon)
            {
                throw new OpaqueException();
            }
#endif

            return (Math.Sqrt(C) * x / Math.Sqrt(1 - x * x));
        }
    }



    /// <summary>
    /// Реализует функцию g(x) = tg(x),  
    /// где угол X задается параметром в радианах <paramref name="x"/>. 
    /// который удовлетворяет интервалу (-Pi/2, Pi/2).
    /// Результатом функции является число, которое получается при подстановке 
    /// параметра x в функцию.
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <returns>double</returns>
    [FunctionAttributes()]
    [FunctionName("interval_finfin_ww_3", "g(x) = Tan(x)")]
    public class Cinterval_finfin_ww_3
    {
        public static double interval_finfin_ww_3(double x)
        {
#if DEBUG
            if (Math.Abs(Math.Cos(x)) < double.Epsilon)
            {
                throw new OpaqueException();
            }
#endif

#if DEBUG
            if ((Math.Abs(x) >= Math.PI/2 + double.Epsilon) || (Math.Abs(x) >= Math.PI / 2 - double.Epsilon))
            {
                throw new OpaqueException();
            }
#endif
            return (Math.Tan(x));
        }
    }

    /// <summary>
    /// Возвращает область определения функции g(x) = Tan(x),  
    /// (-Pi/2, Pi/2).
    /// <returns>string</returns>
    [FunctionAttributes()]
    [FunctionName("interval_finfin_ww_3_in", "(-PI/2, PI/2)")]
    public class Cinterval_finfin_ww_3_in
    {
        public static string interval_finfin_ww_3_in()
        {
            return "(-Pi/2, Pi/2)";
        }
    }

    /// <summary>
    /// Реализует функцию g_inv(x) = arctg(x),  
    /// где угол X задается параметром в радианах <paramref name="x"/>. 
    /// который удовлетворяет интервалу (w, w).
    /// Результатом функции является число, которое получается при подстановке 
    /// параметра x в функцию.
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <returns>double</returns>
    [FunctionAttributes()]
    [FunctionName("interval_finfin_ww_3_inv", "Atan(x)")]
    public class Cinterval_finfin_ww_3_inv
    {
        public static double interval_finfin_ww_3_inv(double x)
        {
            return (Math.Atan(x));
        }

    }


    /// <summary>
    /// Реализует функцию g(x) = 1/x,  
    /// где аргумент X задается параметром <paramref name="x"/>,
    /// который удовлетворяет интервалу (0, w).
    /// Результатом функции является число, которое получается при подстановке 
    /// параметра x в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <returns>double</returns>
    [FunctionAttributes()]
    [FunctionName("interval_finw_finw_4", "1/х")]
    public class Cinterval_finw_finw_4
    {
        public static double interval_finw_finw_4(double x)
        {

#if DEBUG
            if (x < double.Epsilon)
            {
                throw new OpaqueException();
            }
#endif
            return (1 / x);
        }
    }

    /// <summary>
    /// Возвращает область определения функции g(x) = 1/x,  
    /// (0, w).
    /// <returns>string</returns>
    [FunctionAttributes()]
    [FunctionName("interval_finw_finw_4_in", "(0, w)")]
    public class Cinterval_finw_finw_4_in
    {
        public static string interval_finw_finw_4_in()
        {
            return "(0, w)";
        }
    }

    /// <summary>
    /// Реализует функцию g_inv(x) = 1/x,  
    /// где аргумент X задается параметром <paramref name="x"/>,
    /// который удовлетворяет интервалу (0, w).
    /// Результатом функции является число, которое получается при подстановке 
    /// параметра x в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <returns>double</returns>
    [FunctionAttributes()]
    [FunctionName("interval_finw_finw_4_inv", "1/х")]
    public class Cinterval_finw_finw_4_inv
    {
        public static double interval_finw_finw_4_inv(double x)
        {

#if DEBUG
            if (x < double.Epsilon)
            {
                throw new OpaqueException();
            }
#endif
            return (1 / x);
        }
    }



    /// <summary>
    /// Реализует функцию g(x) = -x,  
    /// где аргумент X задается параметром <paramref name="x"/>,
    /// который удовлетворяет интервалу (0, w).
    /// Результатом функции является число, которое получается при подстановке 
    /// параметра x в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <returns>double</returns>
    [FunctionAttributes()]
    [FunctionName("interval_finw_wfin_5", "-x")]
    public class Cinterval_finw_wfin_5
    {
        public static double interval_finw_wfin_5(double x)
        {
#if DEBUG
            if (x < double.Epsilon)
            {
                throw new OpaqueException();
            }
#endif
            return (-x);
        }
    }

    /// <summary>
    /// Возвращает область определения функции g(x) = -x,  
    /// (0, w).
    /// <returns>string</returns>
    [FunctionAttributes()]
    [FunctionName("interval_finw_wfin_5_in", "(0, w)")]
    public class Cinterval_finw_wfin_5_in
    {
        public static string interval_finw_wfin_5_in()
        {
            return "(0, w)";
        }
    }

    /// <summary>
    /// Реализует функцию g_inv(x) = -x,  
    /// где аргумент X задается параметром <paramref name="x"/>,
    /// который удовлетворяет интервалу (w, 0).
    /// Результатом функции является число, которое получается при подстановке 
    /// параметра x в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <returns>double</returns>
    [FunctionAttributes()]
    [FunctionName("interval_finw_wfin_5_inv", "-x")]
    public class Cinterval_finw_wfin_5_inv
    {
        public static double interval_finw_wfin_5_inv(double x)
        {
#if DEBUG
            if (x > double.Epsilon)
            {
                throw new OpaqueException();
            }
#endif
            return (-x);
        }
    }
    


    /// <summary>
    /// Реализует функцию g(x) = A*exp(x + B),  
    /// где аргумент X задается параметром <paramref name="x"/>,
    /// который удовлетворяет интервалу (w, w).
    /// Числовые коэффициенты - <paramref name="A"/>, <paramref name="B"/>, 
    /// Результатом функции является число, которое получается при подстановке 
    /// параметра x и числовых коэффициентов в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="A">коэффициент A</param>
    /// <param name="B">коэффициент B</param>
    /// <returns>double</returns>
    [FunctionAttributes()]
    [FunctionName("interval_ww_finw_6", "A*Exp(x + B)")]
    public class Cinterval_ww_finw_6
    {
        public static double interval_ww_finw_6(double x, double A, double B)
        {
            return (A * Math.Exp(x + B));
        }
    }

    /// <summary>
    /// Возвращает область определения функции g(x) = A*exp(x + B),  
    /// (w, w).
    /// <returns>string</returns>
    [FunctionAttributes()]
    [FunctionName("interval_ww_finw_6_in", "(0, w)")]
    public class Cinterval_ww_finw_6_in
    {
        public static string interval_ww_finw_6_in()
        {
            return "(w, w)";
        }
    }

    /// <summary>
    /// Реализует функцию g_inv(x) = ln(x / A) - B,  
    /// где аргумент X задается параметром <paramref name="x"/>,
    /// который удовлетворяет интервалу (0, w).
    /// Числовые коэффициенты - <paramref name="A"/>, <paramref name="B"/>, 
    /// Результатом функции является число, которое получается при подстановке 
    /// параметра x и числовых коэффициентов в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="A">коэффициент A</param>
    /// <param name="B">коэффициент B</param>
    /// <returns>double</returns>
    [FunctionAttributes()]
    [FunctionName("interval_ww_finw_6_inv", "Log(x / A) - B")]
    public class Cinterval_ww_finw_6_inv
    {
        public static double interval_ww_finw_6_inv(double x, double A, double B)
        {

#if DEBUG
            if (x < double.Epsilon)
            {
                throw new OpaqueException();
            }
#endif

#if DEBUG
            if (Math.Abs(A) < double.Epsilon)
            {
                throw new OpaqueException();
            }
#endif
            return (Math.Log(x / A) - B);
        }
    }





    /// <summary>
    /// Реализует функцию g(x) = ((c - d)/(a - b)) * x + (ad - bc) / (a - b),  
    /// где аргумент X задается параметром <paramref name="x"/>,
    /// который удовлетворяет интервалу (a, b).
    /// Числовые коэффициенты a, b, c, d - 
    /// <paramref name="a"/>, <paramref name="b"/>, <paramref name="c"/>, <paramref name="d"/>
    /// Результатом функции является число, которое получается при подстановке 
    /// параметра x и числовых коэффициентов в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="a">коэффициент a</param>
    /// <param name="b">коэффициент b</param>
    /// <param name="c">коэффициент a</param>
    /// <param name="d">коэффициент b</param>
    /// <returns>double</returns>
    [FunctionAttributes()]
    [FunctionName("interval_finfin_finfin_7", "((c - d)/(a - b)) * x + (a*d - b*c) / (a - b)")]
    public class Cinterval_finfin_finfin_7
    {
        public static double interval_finfin_finfin_7(double x, double a, double b, double c, double d)
        {

#if DEBUG
            if ((Math.Abs(a) < double.Epsilon) && (Math.Abs(b) < double.Epsilon) 
                 && (Math.Abs(a - b) < double.Epsilon) && (Math.Abs(c - d) < double.Epsilon))
            {
                throw new OpaqueException();
            }
#endif

#if DEBUG
            if ((x <= a) || (x >= b))

            {
                throw new OpaqueException();
            }
#endif
            return (((c - d) / (a - b)) * x + (a * d - b * c) / (a - b));

        }
    }

    /// <summary>
    /// Возвращает область определения функции g(x) = ((c - d)/(a -b)) * x + (ad - bc) / (a - b),  
    /// (a, b).
    /// <returns>string</returns>
    [FunctionAttributes()]
    [FunctionName("interval_finfin_finfin_7_in", "(a, b)")]
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

    /// <summary>
    /// Реализует функцию g_inv(x) = ((a - b)/(c -d)) * x + (bc - ad) / (c - d),  
    /// где аргумент X задается параметром <paramref name="x"/>,
    /// который удовлетворяет интервалу (c, d).
    /// Числовые коэффициенты a, b, c, d - 
    /// <paramref name="a"/>, <paramref name="b"/>, <paramref name="c"/>, <paramref name="d"/>, 
    /// Результатом функции является число, которое получается при подстановке 
    /// параметра x и числовых коэффициентов в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="a">коэффициент a</param>
    /// <param name="b">коэффициент b</param>
    /// <param name="c">коэффициент a</param>
    /// <param name="d">коэффициент b</param>
    /// <returns>double</returns>
    [FunctionAttributes()]
    [FunctionName("interval_finfin_finfin_7_inv", "((a - b)/(c -d)) * x + (b*c - a*d) / (c - d)")]
    public class Cinterval_finfin_finfin_7_inv
    {
        public static double interval_finfin_finfin_7_inv(double x, double a, double b, double c, double d)
        {

#if DEBUG
            if ((Math.Abs(c) < double.Epsilon) && (Math.Abs(d) < double.Epsilon)
                 && (Math.Abs(a - b) < double.Epsilon) && (Math.Abs(c - d) < double.Epsilon))
            {
                throw new OpaqueException();
            }
#endif

#if DEBUG
            if ((x <= c) || (x >= d))

            {
                throw new OpaqueException();
            }
#endif
            return (((a - b) / (c - d)) * x + (b*c - a*d) / (c - d));

        }
    }




    /// <summary>
    /// Реализует функцию g(x) = (ab*(d - c)/(a - b)) / x + (ac - bd) / (a - b),  
    /// где аргумент X задается параметром <paramref name="x"/>,
    /// который удовлетворяет интервалу (a, b).
    /// Числовые коэффициенты a, b, c, d - 
    /// <paramref name="a"/>, <paramref name="b"/>, <paramref name="c"/>, <paramref name="d"/>
    /// Результатом функции является число, которое получается при подстановке 
    /// параметра x и числовых коэффициентов в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="a">коэффициент a</param>
    /// <param name="b">коэффициент b</param>
    /// <param name="c">коэффициент a</param>
    /// <param name="d">коэффициент b</param>
    /// <returns>double</returns>
    [FunctionAttributes()]
    [FunctionName("interval_finfin_finfin_8", "(a*b*(d - c)/(a - b)) / x + (a*c - b*d) / (a - b)")]
    public class Cinterval_finfin_finfin_8
    {
        public static double interval_finfin_finfin_8(double x, double a, double b, double c, double d)
        {

#if DEBUG
            if ((Math.Abs(a) < double.Epsilon) && (Math.Abs(b) < double.Epsilon)
                 && (Math.Abs(a - b) < double.Epsilon) && (Math.Abs(c - d) < double.Epsilon))
            {
                throw new OpaqueException();
            }
#endif

#if DEBUG
            if ((x <= a) || (x >= b))

            {
                throw new OpaqueException();
            }
#endif
            return (((d - c) * a * b / (a - b)) / x + (a * c - b * d) / (a - b));

        }
    }

    /// <summary>
    /// Возвращает область определения функции g(x) = (a*b*(d - c)/(a - b)) / x + (a*c - b*d) / (a - b),  
    /// (a, b).
    /// <returns>string</returns>
    [FunctionAttributes()]
    [FunctionName("interval_finfin_finfin_8_in", "(a, b)")]
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

    /// Опечатка! g_inv(x) = (cd*(b - a)/(c -d)) / x + (ca - bd) / (c - d)
    /// Заменено на функцию: g_inv(x) = (d - c)*a*b/(x*(a- b) - (a*c - b*d))
    /// <summary>
    /// Реализует функцию g_inv(x) = (d - c)*a*b/(x*(a - b) - (a*c - b* d)),  
    /// где аргумент X задается параметром <paramref name="x"/>,
    /// который удовлетворяет интервалу (c, d).
    /// Числовые коэффициенты a, b, c, d - 
    /// <paramref name="a"/>, <paramref name="b"/>, <paramref name="c"/>, <paramref name="d"/>
    /// Результатом функции является число, которое получается при подстановке 
    /// параметра x и числовых коэффициентов в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="a">коэффициент a</param>
    /// <param name="b">коэффициент b</param>
    /// <param name="c">коэффициент a</param>
    /// <param name="d">коэффициент b</param>
    /// <returns>double</returns>
    [FunctionAttributes()]
    [FunctionName("interval_finfin_finfin_8_inv", "(d - c)*a*b/(x*(a- b) - (a*c - b*d))")]
    public class Cinterval_finfin_finfin_8_inv
    {
        public static double interval_finfin_finfin_8_inv(double x, double a, double b, double c, double d)
        {


#if DEBUG
            if ((Math.Abs(c) < double.Epsilon) && (Math.Abs(d) < double.Epsilon)
                 && (Math.Abs(a - b) < double.Epsilon) && (Math.Abs(c - d) < double.Epsilon))
            {
                throw new OpaqueException();
            }
#endif

#if DEBUG
            if ((x <= c) || (x >= d))

            {
                throw new OpaqueException();
            }
#endif

              return ((d - c)*a*b/(x*(a - b) - (a*c - b* d)));



        }
    }




    /// <summary>
    /// Реализует функцию g(x) = sin(x),  
    /// где угол X задается параметром в радианах <paramref name="x"/>. 
    /// который удовлетворяет интервалу (-Pi/2, Pi/2).
    /// Результатом функции является число, которое получается при подстановке 
    /// параметра x в функцию.
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <returns>double</returns>
    [FunctionAttributes()]
    [FunctionName("interval_finfin_finfin_9", "Sin(x)")]
    public class Cinterval_finfin_finfin_9
    {
        public static double interval_finfin_finfin_9(double x)
        {

#if DEBUG
            if (x >= Math.PI/2 || x <= (-Math.PI/2))
            {
                throw new OpaqueException();
            }
#endif
            return (Math.Sin(x));
        }
    }

    /// <summary>
    /// Возвращает область определения функции g(x) = Sin(x),  
    /// (-Pi/2, Pi/2).
    /// <returns>string</returns>
    [FunctionAttributes()]
    [FunctionName("interval_finfin_finfin_9_in", "(-PI/2, PI/2)")]
    public class Cinterval_finfin_finfin_9_in
    {
        public static string interval_finfin_finfin_9_in()
        {
            return "(-Pi/2, Pi/2)";
        }
    }

    /// <summary>
    /// Реализует функцию g_inv(x) = arcsin(x),  
    /// где угол X задается параметром в радианах <paramref name="x"/>. 
    /// который удовлетворяет интервалу (-1, 1).
    /// Результатом функции является число, которое получается при подстановке 
    /// параметра x в функцию.
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <returns>double</returns>
    [FunctionAttributes()]
    [FunctionName("interval_finfin_finfin_9_inv", "Asin(x)")]
    public class Cinterval_finfin_finfin_9_inv
    {
        public static double interval_finfin_finfin_9_inv(double x)
        {

#if DEBUG
            if (x >= 1 || x <= -1)
            {
                throw new OpaqueException();
            }
#endif
            return (Math.Asin(x));
        }

    }



    /// <summary>
    /// Реализует функцию g(x) = cos(x),  
    /// где угол X задается параметром в радианах <paramref name="x"/>. 
    /// который удовлетворяет интервалу (0, Pi).
    /// Результатом функции является число, которое получается при подстановке 
    /// параметра x в функцию.
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <returns>double</returns>
    [FunctionAttributes()]
    [FunctionName("interval_finfin_finfin_10", "Cos(x)")]
    public class Cinterval_finfin_finfin_10
    {
        public static double interval_finfin_finfin_10(double x)
        {

#if DEBUG
            if (x <= 0 || x >= Math.PI)
            {
                throw new OpaqueException();
            }
#endif
            return (Math.Cos(x));
        }
    }

    /// <summary>
    /// Возвращает область определения функции g(x) = Cos(x),  
    /// (0, Pi).
    /// <returns>string</returns>
    [FunctionAttributes()]
    [FunctionName("interval_finfin_finfin_10_in", "(0, PI)")]
    public class Cinterval_finfin_finfin_10_in
    {
        public static string interval_finfin_finfin_10_in()
        {
            return "(0, Pi)";
        }
    }

    /// <summary>
    /// Реализует функцию g_inv(x) = arccos(x),  
    /// где угол X задается параметром в радианах <paramref name="x"/>. 
    /// который удовлетворяет интервалу (-1, 1).
    /// Результатом функции является число, которое получается при подстановке 
    /// параметра x в функцию.
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <returns>double</returns>
    [FunctionAttributes()]
    [FunctionName("interval_finfin_finfin_10_inv", "Acos(x)")]
    public class Cinterval_finfin_finfin_10_inv
    {
        public static double interval_finfin_finfin_10_inv(double x)
        {

#if DEBUG
            if (x >= 1 || x <= -1)
            {
                throw new OpaqueException();
            }
#endif
            return (Math.Acos(x));
        }
    }
}
