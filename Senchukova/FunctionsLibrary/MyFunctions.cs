#define Debug
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsLibrary
{
    //Function 1

    // (w, w) -> (fin, fin)
    // g(x) = x / (x^2 + 1)
    /// <summary>
    /// Реализует функцию g(x) =  x / (x^2 + 1),
    /// где аргумент x задается параметром <paramref name="x"/>,
    /// который удовлетворяет интервалу (w, w).
    /// Результатом функции является число, которое получается при подстановке
    /// параметра x в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <returns>double</returns>
    [FunctionAttributes()]
    [FunctionName("interval_ww_finfin_1", "g(x) = x / (x^2 + 1)")]
    public class Cinterval_ww_finfin_1
    {
        public static double interval_ww_finfin_1(double x)
        {
            double x2 = x * x;
            return x / (x2 + 1);
        }
    }

    /// <summary>
    /// Возвращает область определения функции g(x) = x / (x^2 + 1),  
    /// (w, w).
    /// <returns>string</returns>
    [FunctionAttributes()]
    [FunctionName("interval_ww_finfin_1_in", "(w, w)")]
    public class Cinterval_ww_finfin_1_in
    {
        public static string interval_ww_finfin_1_in()
        {
            return "(w, w)";
        }
    }
    //------------------------------------------------------
    //Function 2
    // (w, w) -> (fin, fin)
    // g(x) = (1 + x^2) / (x^4 + 1)
    /// <summary>
    /// Реализует функцию g(x) =  (1 + x^2) / (x^4 + 1),
    /// где аргумент x задается параметром <paramref name="x"/>,
    /// который удовлетворяет интервалу (w, w).
    /// Результатом функции является число, которое получается при подстановке
    /// параметра x в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <returns>double</returns>
    [FunctionAttributes()]
    [FunctionName("interval_ww_finfin_2", "g(x) = (1 + x^2) / (x^4 + 1)")]

    public class Cinterval_ww_finfin_2
    {
        public static double interval_ww_finfin_2(double x)
        {
            double x2 = x * x;
            double x4 = x2 * x2;
            return (1 + x2) / (x4 + 1);
        }
    }
    /// <summary>
    /// Возвращает область определения функции g(x) = (1 + x^2) / (x^4 + 1),  
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

    //-----------------------------------------------------
    //Function 3
    // (w, w) -> (fin, fin)
    // g(x) = x / (x^2 + A * x + B);

    /// <summary>
    /// Реализует функцию g(x) = x / (x^2 + A * x + B),
    /// где аргумент X задается параметром <paramref name="x"/>,
    /// который удовлетворяет интервалу (w, w).
    /// Числовые коэффициенты - <paramref name="A"/>, <paramref name="B"/>.
    /// Результатом функции является число, которое получается при подстановке
    /// параметра x и числовых коэффициентов в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="A">коэффициент A</param>
    /// <param name="B">коэффициент B</param>
    /// <returns>double</returns>
    [FunctionAttributes()]
    [FunctionName("interval_ww_ww_3", "g(x) = x / (x^2 + A * x + B)")]
    public class Cinterval_ww_finfin_3
    {
        public static double interval_ww_finfin_3(double x, double A, double B)
        {
            #if Debug
                if (((A * A) - (4 * B)) >= 0)
                {
                    throw new Exception();
                }
            #endif
            double x2 = x * x;
            return x / (x2 + A * x + B);


        }
    }

    /// <summary>
    /// Возвращает область определения функции g(x) = x / (x^2 + A * x + B),  
    /// (w, w).
    /// <returns>string</returns>
    [FunctionAttributes()]
    [FunctionName("interval_ww_finfin_3_in", "(w, w)")]
    public class Cinterval_ww_finfin_3_in
    {
        public static string interval_ww_finfin_3_in()
        {
            return "(w, w)";
        }
    }

    //------------------------------------------------------------
    //Function 4
    // (w, w) -> (fin, fin)
    // g(x) = Cos(x) / (x^2 + x + 1);

    /// <summary>
    /// Реализует функцию g(x) = Cos(x) / (x^2 + x + 1),
    /// где аргумент X задается параметром <paramref name="x"/>,
    /// который удовлетворяет интервалу (w, w).
    /// Результатом функции является число, которое получается при подстановке
    /// параметра x в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <returns>double</returns>
    [FunctionAttributes()]
    [FunctionName("interval_ww_ww_4", "g(x) = Cos(x) / (x^2 + x + 1)")]
    public class Cinterval_ww_finfin_4
    {
        public static double interval_ww_finfin_4(double x)
        {
            double x2 = x * x;
            return Math.Cos(x) / (x2 + x + 1);
        }
    }

    /// <summary>
    /// Возвращает область определения функции g(x) = Cos(x) / (x^2 + x + 1),  
    /// (w, w).
    /// <returns>string</returns>
    [FunctionAttributes()]
    [FunctionName("interval_ww_finfin_4_in", "(w, w)")]
    public class Cinterval_ww_finfin_4_in
    {
        public static string interval_ww_finfin_4_in()
        {
            return "(w, w)";
        }
    }



    //-------------------------------------------------------
    //Function 5 
    // (w, w) -> (fin, fin)
    // g(x) = Sin(x) / (x^4 + 1);

    /// <summary>
    /// Реализует функцию g(x) = Sin(x) / (x^4 + 1),
    /// где аргумент X задается параметром <paramref name="x"/>,
    /// который удовлетворяет интервалу (w, w).
    /// Результатом функции является число, которое получается при подстановке
    /// параметра x в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <returns>double</returns>
    [FunctionAttributes()]
    [FunctionName("interval_ww_ww_5", "g(x) = Sin(x) / (x^4 + 1)")]
    public class Cinterval_ww_finfin_5
    {
        public static double interval_ww_finfin_5(double x)
        {
            double x4 = x * x * x * x;
            return Math.Sin(x) / (x4 + 1);
        }
    }

    /// <summary>
    /// Возвращает область определения функции g(x) = Sin(x) / (x^4 + 1) ,  
    /// (w, w).
    /// <returns>string</returns>
    [FunctionAttributes()]
    [FunctionName("interval_ww_finfin_5_in", "(w, w)")]
    public class Cinterval_ww_finfin_5_in
    {
        public static string interval_ww_finfin_5_in()
        {
            return "(w, w)";
        }
    }




}
