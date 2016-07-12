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
        public OpaqueException() : base("Argument is out of range")
        {

        }

    }

    /// <summary>
    /// Реализует функцию g(x) = sin(x),  
    /// где аргумент X задается параметром <paramref name="x"/>, который удовлетворяет интервалу (w, w),
    /// а второй параметр <paramref name="count"/> задает количество членов ряда.
    /// Результатом функции является число, которое получается при подстановке 
    /// параметров x и count в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="count">Количество членов ряда</param>
    /// <returns>double</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_1", "g(x) = sin(x)")]
    public class CSin_1
    {
        public static double Sin_1(double x, int count)
        {

            double fact = 1;
            double sum = x;
            for (int k = 1; k <= count; k++)
            {
                fact = fact * (2 * k + 1) * (2 * k);
                if (Math.Abs(Math.Pow(-1, k) * Math.Pow(x, 2 * k + 1) / fact) < 1e-15) break;
                sum = sum + Math.Pow(-1, k) * Math.Pow(x, 2 * k + 1) / fact;
            }
            if (Math.Abs(sum) < 1e-15) sum = 0;
            return (sum);
        }
    }
    /// <summary>
    /// Возвращает область определения функции g(x) = sin(x),  
    /// (w, w).
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_1_in", "(w, w)")]
    public class CSin_1_in
    {
        public static string Sin_1_in()
        {
            return ("(w, w)");
        }
    }
    /// <summary>
    /// Возвращает имя функции, обратной функции g(x) = sin(x),  
    /// арксинус.
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_1_inv", "арксинус")]
    public class CSin_1_inv
    {
        public static string Sin_1_inv()
        {
            return ("арксинус");
        }
    }
    /// <summary>
    /// Реализует функцию g(x) = sin(x),  
    /// где аргумент X задается параметром <paramref name="x"/>, который удовлетворяет интервалу (w, w),
    /// второй параметр <paramref name="er"/> задает минимальный размер остаточного члена ряда,
    /// а третий параметр <paramref name="cnst"/> задает число меньше 1 и больше 0,
    /// использующееся в формуле остаточного члена.
    /// Результатом функции является число, которое получается при подстановке 
    /// параметров x, er и cnst в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="er">минимальный размер остаточного члена ряда</param>
    /// <paramref name="cnst"/>Число меньше 1 и больше 0</param>
    /// <returns>double</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_2", "g(x) = sin(x)")]
    public class CSin_2
    {
        public static double Sin_2(double x, double er, double cnst = 0.9)
        {
            double fact = 1;
            double fact2 = 1;
            double sum = 0;
            double residue = 100000;
            int k = 0;
            while ((Math.Abs(residue) > er) && (k <= 1000))
            {
                fact2 = fact2 * (k + 1);
                sum = sum + Math.Pow(-1, k) * Math.Pow(x, 2 * k + 1) / fact;
                k++;
                fact = fact * (2 * k + 1) * (2 * k);
                residue = (Math.Pow(x, k) / fact2) * Math.Pow(-1, k) * Math.Pow(cnst * x, 2 * k + 1) / fact;
                Console.WriteLine(residue);
            }
            sum = sum + residue;
            return (sum);
        }
    }
    /// <summary>
    /// Возвращает область определения функции g(x) = sin(x),  
    /// (w, w).
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_2_in", "(w, w)")]
    public class CSin_2_in
    {
        public static string Sin_2_in()
        {
            return ("(w, w)");
        }
    }
    /// <summary>
    /// Возвращает имя функции, обратной функции g(x) = sin(x),  
    /// арксинус.
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_2_inv", "арксинус")]
    public class CSin_2_inv
    {
        public static string Sin_2_inv()
        {
            return ("арксинус");
        }
    }
    /// <summary>
    /// Реализует функцию g(x) = cos(x),  
    /// где аргумент X задается параметром <paramref name="x"/>, который удовлетворяет интервалу (w, w),
    /// а второй параметр <paramref name="count"/> задает количество членов ряда.
    /// Результатом функции является число, которое получается при подстановке 
    /// параметров x и count в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="count">Количество членов ряда</param>
    /// <returns>double</returns>
    [OpaqueFunction()]
    [FunctionName("Cos_3", "g(x) = cos(x)")]
    public class CCos_3
    {
        public static double Cos_3(double x, int count)
        {
            double fact = 1;
            double sum = 1;
            for (int k = 1; k <= count; k++)
            {
                fact = fact * (2 * k) * (2 * k - 1);
                if (Math.Abs(Math.Pow(-1, k) * Math.Pow(x, 2 * k) / fact) < 1e-15) break;
                sum = sum + Math.Pow(-1, k) * Math.Pow(x, 2 * k) / fact;
            }
            if (Math.Abs(sum) < 1e-15) sum = 0;
            return (sum);
        }
    }
    /// <summary>
    /// Возвращает область определения функции g(x) = cos(x),  
    /// (w, w).
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Cos_3_in", "(w, w)")]
    public class CCos_3_in
    {
        public static string Cos_3_in()
        {
            return ("(w, w)");
        }
    }
    /// <summary>
    /// Возвращает имя функции, обратной функции g(x) = cos(x),  
    /// арккосинус.
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Cos_3_inv", "арккосинус")]
    public class CCos_3_inv
    {
        public static string Cos_3_inv()
        {
            return ("арккосинус");
        }
    }
    /// <summary>
    /// Реализует функцию g(x) = cos(x),  
    /// где аргумент X задается параметром <paramref name="x"/>, который удовлетворяет интервалу (w, w),
    /// второй параметр <paramref name="er"/> задает минимальный размер остаточного члена ряда,
    /// а третий параметр <paramref name="cnst"/> задает число меньше 1 и больше 0,
    /// использующееся в формуле остаточного члена.
    /// Результатом функции является число, которое получается при подстановке 
    /// параметров x, er и cnst в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="er">минимальный размер остаточного члена ряда</param>
    /// <paramref name="cnst"/>Число меньше 1 и больше 0</param>
    /// <returns>double</returns>
    [OpaqueFunction()]
    [FunctionName("Cos_4", "g(x) = cos(x)")]
    public class CCos_4
    {
        public static double Cos_4(double x, double er, double cnst = 0.8)
        {
            double fact = 1;
            double fact2 = 1;
            double sum = 0;
            double residue = 10000;
            int k = 0;
            while ((Math.Abs(residue) > er) && (k <= 1000))
            {
                fact2 = fact2 * (k + 1);
                sum = sum + Math.Pow(-1, k) * Math.Pow(x, 2 * k) / fact;
                k++;
                fact = fact * (2 * k) * (2 * k - 1);
                residue = (Math.Pow(x, k) / fact2) * Math.Pow(-1, k) * Math.Pow(cnst * x, 2 * k) / fact;
                Console.WriteLine(residue);
            }
            sum = sum + residue;
            return (sum);
        }
    }
    /// <summary>
    /// Возвращает область определения функции g(x) = cos(x),  
    /// (w, w).
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Cos_4_in", "(w, w)")]
    public class CCos_4_in
    {
        public static string Cos_4_in()
        {
            return ("(w, w)");
        }
    }
    /// <summary>
    /// Возвращает имя функции, обратной функции g(x) = cos(x),  
    /// арккосинус.
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Cos_4_inv", "арккосинус")]
    public class CCos_4_inv
    {
        public static string Cos_4_inv()
        {
            return ("арккосинус");
        }
    }

    /// <summary>
    /// Реализует функцию g(x) = sin(x) через заданную формулу,  
    /// где аргумент X задается параметром <paramref name="x"/>, который удовлетворяет интервалу (w, w),
    /// второй параметр <paramref name="count"/> задает количество членов ряда,
    /// третий параметр <paramref name="y0"/> задает приближенное значение функции.
    /// Результатом функции является число, которое получается при подстановке 
    /// параметров x, count и y0 в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="count">Количество членов ряда</param>
    /// <param name="y0">Приближенное значение функции</param>
    /// <returns>double</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_5", "g(x) = sin(x)")]
    public class CSin_5
    {
        public static double Sin_5(double x, int count, double y0 = 1)
        {
            int k = 0;
            double fact = 1;
            double fact2 = 1;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double z0 = Math.Asin(y0) - x;
            while (k <= count)
            {
                if (Math.Abs(Math.Pow(-1, k) * Math.Pow(z0, 2 * k + 1) / fact) < 1e-15) break;
                sum1 = sum1 + Math.Pow(-1, k) * Math.Pow(z0, 2 * k + 1) / fact;
                k++;
                fact = fact * (2 * k + 1) * (2 * k);
                fact2 = fact2 * (2 * k) * (2 * k - 1);
                sum2 = sum2 + Math.Pow(-1, k) * Math.Pow(z0, 2 * k) / fact2;
            }
            sum3 = y0 * (1 + sum2) - Math.Sqrt(1 - y0 * y0) * sum1;
            if (Math.Abs(sum3) < 1e-15) sum3 = 0;
            return (sum3);
        }
    }
    /// <summary>
    /// Возвращает область определения функции g(x) = sin(x),  
    /// (w, w).
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_5_in", "(w, w)")]
    public class CSin_5_in
    {
        public static string Sin_5_in()
        {
            return ("(w, w)");
        }
    }
    /// <summary>
    /// Возвращает имя функции, обратной функции g(x) = sin(x),  
    /// арксинус.
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_5_inv", "арксинус")]
    public class CSin_5_inv
    {
        public static string Sin_5_inv()
        {
            return ("арксинус");
        }
    }

    /// <summary>
    /// Реализует функцию g(x) = sin(x) через заданную формулу,  
    /// где аргумент X задается параметром <paramref name="x"/>, который удовлетворяет интервалу (w, w),
    /// второй параметр <paramref name="count"/> задает количество членов ряда,
    /// третий параметр <paramref name="y0"/> задает приближенное значение функции,
    /// четвертый параметр <paramref name="cnst"/> задает число больше 0 и меньше 1, 
    /// используемое в формуле остаточного члена.
    /// Результатом функции является число, которое получается при подстановке 
    /// параметров x, count, y0 и cnst в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="count">Количество членов ряда</param>
    /// <param name="y0">Приближенное значение функции</param>
    /// <param name="cnst">Число больше 0 и меньше 1</param>
    /// <returns>double</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_6", "g(x) = sin(x)")]
    public class CSin_6
    {
        public static double Sin_6(double x, double er, double y0 = 1, double cnst = 0.8)
        {
            int k = 0;
            double fact = 1;
            double fact2 = 1;
            double fact3 = 1;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double z0 = Math.Asin(y0) - x;
            double residue = 10;
            while ((Math.Abs(residue) > er) && (k <= 1000))
            {
                fact3 = fact3 * (k + 1);
                sum1 = sum1 + Math.Pow(-1, k) * Math.Pow(z0, 2 * k + 1) / fact;
                k++;
                fact2 = fact2 * (2 * k) * (2 * k - 1);
                sum2 = sum2 + Math.Pow(-1, k) * Math.Pow(z0, 2 * k) / fact2;
                fact = fact * (2 * k + 1) * (2 * k);
                residue = (Math.Pow(x, k) / fact3) * Math.Pow(-1, k) * Math.Pow(cnst * z0, 2 * k + 1) / fact;
            }
            sum3 = y0 * (1 + sum2) - Math.Sqrt(1 - y0 * y0) * sum1;
            return (sum3);
        }
    }
    /// <summary>
    /// Возвращает область определения функции g(x) = sin(x),  
    /// (w, w).
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_6_in", "(w, w)")]
    public class CSin_6_in
    {
        public static string Sin_6_in()
        {
            return ("(w, w)");
        }
    }
    /// <summary>
    /// Возвращает имя функции, обратной функции g(x) = sin(x),  
    /// арксинус.
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_6_inv", "арксинус")]
    public class CSin_6_inv
    {
        public static string Sin_6_inv()
        {
            return ("арксинус");
        }
    }
    /// <summary>
    /// Реализует функцию g(x) = cos(x) через заданную формулу,  
    /// где аргумент X задается параметром <paramref name="x"/>, который удовлетворяет интервалу (w, w),
    /// второй параметр <paramref name="count"/> задает количество членов ряда,
    /// третий параметр <paramref name="y0"/> задает приближенное значение функции.
    /// Результатом функции является число, которое получается при подстановке 
    /// параметров x, count и y0 в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="count">Количество членов ряда</param>
    /// <param name="y0">Приближенное значение функции</param>
    /// <returns>double</returns>
    [OpaqueFunction()]
    [FunctionName("Cos_7", "g(x) = cos(x)")]
    public class CCos_7
    {
        public static double Cos_7(double x, int count, double y0 = 1)
        {
            int k = 0;
            double fact = 1;
            double fact2 = 1;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double z0 = Math.Acos(y0) - x;
            while (k <= count)
            {
                if (Math.Abs(Math.Pow(-1, k) * Math.Pow(z0, 2 * k + 1) / fact) < 1e-15) break;
                sum1 = sum1 + Math.Pow(-1, k) * Math.Pow(z0, 2 * k + 1) / fact;
                k++;
                fact = fact * (2 * k + 1) * (2 * k);
                fact2 = fact2 * (2 * k) * (2 * k - 1);
                sum2 = sum2 + Math.Pow(-1, k) * Math.Pow(z0, 2 * k) / fact2;
            }
            sum3 = y0 * (1 + sum2) + Math.Sqrt(1 - y0 * y0) * sum1;
            if (Math.Abs(sum3) < 1e-15) sum3 = 0;
            return (sum3);
        }
    }
    /// <summary>
    /// Возвращает область определения функции g(x) = cos(x),  
    /// (w, w).
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Cos_7_in", "(w, w)")]
    public class CCos_7_in
    {
        public static string Cos_7_in()
        {
            return ("(w, w)");
        }
    }
    public class CCos_7_inv
    {
        public static string Cos_7_inv()
        {
            return ("арккосинус");
        }
    }
    /// <summary>
    /// Реализует функцию g(x) = cos(x) через заданную формулу,  
    /// где аргумент X задается параметром <paramref name="x"/>, который удовлетворяет интервалу (w, w),
    /// второй параметр <paramref name="count"/> задает количество членов ряда,
    /// третий параметр <paramref name="y0"/> задает приближенное значение функции,
    /// четвертый параметр <paramref name="cnst"/> задает число больше 0 и меньше 1, 
    /// используемое в формуле остаточного члена.
    /// Результатом функции является число, которое получается при подстановке 
    /// параметров x, count, y0 и cnst в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="count">Количество членов ряда</param>
    /// <param name="y0">Приближенное значение функции</param>
    /// <param name="cnst">Число больше 0 и меньше 1</param>
    /// <returns>double</returns>
    [OpaqueFunction()]
    [FunctionName("Cos_8", "g(x) = cos(x)")]
    public class CCos_8
    {
        public static double Cos_8(double x, double er, double y0 = 1, double cnst = 0.8)
        {
            int k = 0;
            double fact = 1;
            double fact2 = 1;
            double fact3 = 1;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double z0 = Math.Acos(y0) - x;
            double residue = 10;
            while ((Math.Abs(residue) > er) && (k <= 1000))
            {
                fact3 = fact3 * (k + 1);
                sum1 = sum1 + Math.Pow(-1, k) * Math.Pow(z0, 2 * k + 1) / fact;
                k++;
                fact2 = fact2 * (2 * k) * (2 * k - 1);
                sum2 = sum2 + Math.Pow(-1, k) * Math.Pow(z0, 2 * k) / fact2;
                fact = fact * (2 * k + 1) * (2 * k);
                residue = (Math.Pow(x, k) / fact3) * Math.Pow(-1, k) * Math.Pow(cnst * z0, 2 * k + 1) / fact;
            }
            sum3 = y0 * (1 + sum2) + Math.Sqrt(1 - y0 * y0) * sum1;
            return (sum3);
        }
    }
    /// <summary>
    /// Возвращает область определения функции g(x) = cos(x),  
    /// (w, w).
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Cos_8_in", "(w, w)")]
    public class CCos_8_in
    {
        public static string Cos_8_in()
        {
            return ("(w, w)");
        }
    }
    /// <summary>
    /// Возвращает имя функции, обратной функции g(x) = cos(x),  
    /// арккосинус.
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Cos_8_inv", "арккосинус")]
    public class CCos_8_inv
    {
        public static string Cos_8_inv()
        {
            return ("арккосинус");
        }
    }

    /// <summary>
    /// Реализует подсчет чисел Бернулли ,  
    /// где параметром явлется натуральное число <paramref name="k"/>.
    /// Результатом функции является число Бернулли с заданным номером.
    /// </summary>
    /// <param name="k">Аргумент функции</param>
    /// <returns>double</returns>
    [OpaqueFunction()]
    [FunctionName("bernulli", "g(x) = Bn")]
    public class Cbernulli
    {
        public static double bernulli(int k)
        {
            double fact1 = 1;
            double fact2 = 1;
            double fact3 = 1;
            for (int i = 1; i <= k; i++)
            {
                fact1 = fact1 * (i + 1);
                fact3 = fact3 * i;
            }
            double sum = 0;
            if (k == 0) return (1);
            if ((k > 1) && (k % 2 == 1)) return (0);
            else
            {
                for (int i = 1; i <= k; i++)
                {
                    fact2 = fact2 * (i + 1);
                    fact3 = fact3 / (k - i + 1);
                    if (k == i) sum++;
                    else sum = sum + bernulli(k - i) * fact1 / fact2 / fact3;
                }
                sum = sum * (-1) / (k + 1);
                return (sum);
            }

        }
    }

    /// <summary>
    /// Реализует функцию g(x) = tg(x),  
    /// где аргумент X задается параметром <paramref name="x"/>, который удовлетворяет интервалу (-Pi/2, Pi/2),
    /// а второй параметр <paramref name="count"/> задает количество членов ряда.
    /// Результатом функции является число, которое получается при подстановке 
    /// параметров x и count в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="count">Количество членов ряда</param>
    /// <returns>double</returns>
    [OpaqueFunction()]
    [FunctionName("Tg_9", "g(x) = tg(x)")]
    public class CTg_9
    {

        public static double Tg_9(double x, int count)
        {
            double fact = 1;
            double sum = 0;
#if DEBUG
            if (Math.Abs(x) >= (Math.PI / 2 - double.Epsilon))
            {
                throw new OpaqueException();
            }
#endif
            else
            {
                for (int k = 1; k <= count; k++)
                {
                    fact = fact * (2 * k) * (2 * k - 1);
                    double s = Math.Abs(Cbernulli.bernulli(2 * k));
                    if (Math.Abs(Math.Pow(2, 2 * k) * (Math.Pow(2, 2 * k) - 1) / fact * Math.Pow(x, 2 * k - 1) * s) < double.Epsilon) break;
                    sum = sum + Math.Pow(2, 2 * k) * (Math.Pow(2, 2 * k) - 1) * Math.Pow(x, 2 * k - 1) * s / fact;
                }
                if (Math.Abs(sum) < double.Epsilon) sum = 0;
            }

            return (sum);
        }
    }
    /// <summary>
    /// Возвращает область определения функции g(x) = tg(x),  
    /// (-Pi/2, Pi/2).
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Tg_9_in", "(-Pi/2, Pi/2)")]
    public class CTg_9_in
    {
        public static string Tg_9_in()
        {
            return ("(-Pi/2, Pi/2)");
        }
    }
    /// <summary>
    /// Возвращает имя функции, обратной функции g(x) = tg(x),  
    /// арктангенс.
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Tg_9_inv", "арктангенс")]
    public class CTg_9_inv
    {
        public static string Tg_9_inv()
        {
            return ("арктангенс");
        }
    }
    /// <summary>
    /// Реализует функцию g(x) = tg(x),  
    /// где аргумент X задается параметром <paramref name="x"/>, который удовлетворяет интервалу (-Pi/2, Pi/2),
    /// второй параметр <paramref name="er"/> задает минимальный размер остаточного члена ряда,
    /// а третий параметр <paramref name="cnst"/> задает число меньше 1 и больше 0,
    /// использующееся в формуле остаточного члена.
    /// Результатом функции является число, которое получается при подстановке 
    /// параметров x, er и cnst в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="er">минимальный размер остаточного члена ряда</param>
    /// <paramref name="cnst"/>Число меньше 1 и больше 0</param>
    /// <returns>double</returns>
    [OpaqueFunction()]
    [FunctionName("Tg_10", "g(x) = tg(x)")]
    public class CTg_10
    {
        public static double Tg_10(double x, double er, double cnst = 0.8)
        {
            double fact = 2;
            double fact2 = 1;
            double sum = 0;
            double residue = 10;
            int k = 1;
#if DEBUG
            if (Math.Abs(x) >= (Math.PI / 2 - double.Epsilon))
            {
                throw new OpaqueException();
            }
#endif
            else
                while ((Math.Abs(residue) > er) && (k <= 20))
                {
                    fact2 = fact2 * (k + 1);
                    sum = sum + Math.Pow(2, 2 * k) * (Math.Pow(2, 2 * k) - 1) / fact * Math.Pow(x, 2 * k - 1) * Math.Abs(Cbernulli.bernulli(2 * k));
                    k++;
                    fact = fact * (2 * k - 1) * (2 * k);
                    residue = (Math.Pow(x, k) / fact2) * Math.Pow(2, 2 * k) * (Math.Pow(2, 2 * k) - 1) / fact * Math.Pow(cnst * x, 2 * k - 1) * Math.Abs(Cbernulli.bernulli(2 * k));
                }
            return (sum + residue);
        }
    }
    /// <summary>
    /// Возвращает область определения функции g(x) = tg(x),  
    /// (-Pi/2, Pi/2).
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Tg_10_in", "(-Pi/2, Pi/2)")]
    public class CTg_10_in
    {
        public static string Tg_10_in()
        {
            return ("(-Pi/2, Pi/2)");
        }
    }
    /// <summary>
    /// Возвращает имя функции, обратной функции g(x) = tg(x),  
    /// арктангенс.
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Tg_10_inv", "арктангенс")]
    public class CTg_10_inv
    {
        public static string Tg_10_inv()
        {
            return ("арктангенс");
        }
    }
    /// <summary>
    /// Реализует функцию g(x) = ctg(x),  
    /// где аргумент X задается параметром <paramref name="x"/>, который удовлетворяет интервалу (0, Pi),
    /// а второй параметр <paramref name="count"/> задает количество членов ряда.
    /// Результатом функции является число, которое получается при подстановке 
    /// параметров x и count в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="count">Количество членов ряда</param>
    /// <returns>double</returns>
    [OpaqueFunction()]
    [FunctionName("Ctg_11", "g(x) = ctg(x)")]
    public class CCtg_11
    {
        public static double Ctg_11(double x, int count)
        {
            double fact = 1;
            double sum = 0;
#if DEBUG
            if ((Math.Abs(x) <= (0 + double.Epsilon)) || (Math.Abs(x) >= (Math.PI - double.Epsilon)))
            {
                throw new OpaqueException();
            }
#endif
            else
            {
                for (int k = 1; k <= count; k++)
                {
                    fact = fact * (2 * k) * (2 * k - 1);
                    double s = Math.Abs(Cbernulli.bernulli(2 * k));
                    if (Math.Abs(Math.Pow(2, 2 * k) / fact * Math.Pow(x, 2 * k - 1) * s) < 1e-15) break;
                    sum = sum + Math.Pow(2, 2 * k) / fact * Math.Pow(x, 2 * k - 1) * s;
                }
            }
            if (Math.Abs(sum) < 1e-15) sum = 0;
            return ((1.0 / x) - sum);
        }
    }
    /// <summary>
    /// Возвращает область определения функции g(x) = ctg(x),  
    /// (0, Pi).
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Ctg_11_in", "(0, Pi)")]
    public class CCtg_11_in
    {
        public static string Ctg_11_in()
        {
            return ("(0, Pi)");
        }
    }
    /// <summary>
    /// Возвращает имя функции, обратной функции g(x) = ctg(x),  
    /// арккотангенс.
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Ctg_11_inv", "арккотангенс")]
    public class CCtg_11_inv
    {
        public static string Ctg_11_inv()
        {
            return ("арккотангенс");
        }
    }
    /// <summary>
    /// Реализует функцию g(x) = сtg(x),  
    /// где аргумент X задается параметром <paramref name="x"/>, который удовлетворяет интервалу (0, Pi),
    /// второй параметр <paramref name="er"/> задает минимальный размер остаточного члена ряда,
    /// а третий параметр <paramref name="cnst"/> задает число меньше 1 и больше 0,
    /// использующееся в формуле остаточного члена.
    /// Результатом функции является число, которое получается при подстановке 
    /// параметров x, er и cnst в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="er">минимальный размер остаточного члена ряда</param>
    /// <paramref name="cnst"/>Число меньше 1 и больше 0</param>
    /// <returns>double</returns>
    [OpaqueFunction()]
    [FunctionName("Ctg_12", "g(x) = ctg(x)")]
    public class CCtg_12
    {
        public static double Ctg_12(double x, double er, double cnst = 0.8)
        {
            double fact = 2;
            double fact2 = 1;
            double sum = 0;
            double residue = 10;
            int k = 1;
#if DEBUG
            if ((Math.Abs(x) <= (0 + double.Epsilon)) || (Math.Abs(x) >= (Math.PI - double.Epsilon)))
            {
                throw new OpaqueException();
            }
#endif
            else
                while ((Math.Abs(residue) > er) && (k <= 20))
                {
                    fact2 = fact2 * (k + 1);
                    sum = sum + Math.Pow(2, 2 * k) / fact * Math.Pow(x, 2 * k - 1) * Math.Abs(Cbernulli.bernulli(2 * k));
                    k++;
                    fact = fact * (2 * k - 1) * (2 * k);
                    residue = (Math.Pow(x, k) / fact2) * Math.Pow(2, 2 * k) / fact * Math.Pow(cnst * x, 2 * k - 1) * Math.Abs(Cbernulli.bernulli(2 * k));
                }
            return ((1.0 / x) - (sum + residue));
        }
    }
    /// <summary>
    /// Возвращает область определения функции g(x) = ctg(x),  
    /// (0, Pi).
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Ctg_12_in", "(0, Pi)")]
    public class CCtg_12_in
    {
        public static string Ctg_12_in()
        {
            return ("(0, Pi)");
        }
    }
    /// <summary>
    /// Возвращает имя функции, обратной функции g(x) = ctg(x),  
    /// арккотангенс.
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Ctg_12_inv", "арккотангенс")]
    public class CCtg_12_inv
    {
        public static string Ctg_12_inv()
        {
            return ("арккотангенс");
        }
    }

    /// <summary>
    /// Реализует функцию g(x) = cosec(x),  
    /// где аргумент X задается параметром <paramref name="x"/>, который удовлетворяет интервалу (0, Pi),
    /// а второй параметр <paramref name="count"/> задает количество членов ряда.
    /// Результатом функции является число, которое получается при подстановке 
    /// параметров x и count в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="count">Количество членов ряда</param>
    /// <returns>double</returns>
    [OpaqueFunction()]
    [FunctionName("Cosec_13", "g(x) = cosec(x)")]
    public class CCosec_13
    {
        public static double Cosec_13(double x, int count)
        {
            double fact = 1;
            double sum = 1.0 / x;
#if DEBUG
            if ((Math.Abs(x) <= (0 + double.Epsilon)) || (Math.Abs(x) >= (Math.PI + double.Epsilon)) || (Math.Abs(x) >= (Math.PI - double.Epsilon)))
            {
                throw new OpaqueException();
            }
#endif
            else
            {
                for (int k = 1; k <= count; k++)
                {
                    fact = fact * (2 * k) * (2 * k - 1);
                    if (Math.Abs(Math.Pow(x, 2 * k - 1) / fact * 2 * (Math.Pow(2, 2 * k - 1) - 1) * Math.Abs(Cbernulli.bernulli(2 * k))) < 1e-15) break;
                    sum = sum + Math.Pow(x, 2 * k - 1) / fact * 2 * (Math.Pow(2, 2 * k - 1) - 1) * Math.Abs(Cbernulli.bernulli(2 * k));
                }
            }
            if (Math.Abs(sum) < 1e-15) sum = 0;
            return (sum);
        }
    }
    /// <summary>
    /// Возвращает область определения функции g(x) = cosec(x),  
    /// (0, Pi).
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Cosec_13_in", "(0, Pi)")]
    public class CCosec_13_in
    {
        public static string Cosec_13_in()
        {
            return ("(0, Pi)");
        }
    }
    /// <summary>
    /// Возвращает имя функции, обратной функции g(x) = cosec(x),  
    /// арккосеканс.
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Cosec_13_inv", "арккосеканс")]
    public class CCosec_13_inv
    {
        public static string Cosec_13_inv()
        {
            return ("арккосеканс");
        }
    }
    /// <summary>
    /// Реализует функцию g(x) = cosec(x),  
    /// где аргумент X задается параметром <paramref name="x"/>, который удовлетворяет интервалу (0, Pi),
    /// второй параметр <paramref name="er"/> задает минимальный размер остаточного члена ряда,
    /// а третий параметр <paramref name="cnst"/> задает число меньше 1 и больше 0,
    /// использующееся в формуле остаточного члена.
    /// Результатом функции является число, которое получается при подстановке 
    /// параметров x, er и cnst в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="er">минимальный размер остаточного члена ряда</param>
    /// <paramref name="cnst"/>Число меньше 1 и больше 0</param>
    /// <returns>double</returns>
    [OpaqueFunction()]
    [FunctionName("Cosec_14", "g(x) = cosec(x)")]
    public class CCosec_14
    {
        public static double Cosec_14(double x, double er, double cnst = 0.8)
        {
            double fact = 2;
            double fact2 = 1;
            double sum = 1 / x;
            double residue = 10;
            int k = 1;
#if DEBUG
            if ((Math.Abs(x) <= (0 + double.Epsilon)) || (Math.Abs(x) >= (Math.PI + double.Epsilon)) || (Math.Abs(x) >= (Math.PI - double.Epsilon)))
            {
                throw new OpaqueException();
            }
#endif
            else
                while ((Math.Abs(residue) > er) && (k <= 100))
                {
                    fact2 = fact2 * (k + 1);
                    sum = sum + Math.Pow(x, 2 * k - 1) / fact * 2 * (Math.Pow(2, 2 * k - 1) - 1) * Math.Abs(Cbernulli.bernulli(2 * k));
                    k++;
                    fact = fact * (2 * k - 1) * (2 * k);
                    residue = (Math.Pow(x, k) / fact2) * Math.Pow(cnst * x, 2 * k - 1) / fact * 2 * (Math.Pow(2, 2 * k - 1) - 1) * Math.Abs(Cbernulli.bernulli(2 * k));
                }
            return (sum + residue);
        }
    }
    /// <summary>
    /// Возвращает область определения функции g(x) = cosec(x),  
    /// (0, Pi).
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Cosec_14_in", "(0, Pi)")]
    public class CCosec_14_in
    {
        public static string Cosec_14_in()
        {
            return ("(0, Pi)");
        }
    }
    /// <summary>
    /// Возвращает имя функции, обратной функции g(x) = cosec(x),  
    /// арккосеканс.
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Cosec_14_inv", "арккосеканс")]
    public class CCosec_14_inv
    {
        public static string Cosec_14_inv()
        {
            return ("арккосеканс");
        }
    }
    /// <summary>
    /// Реализует функцию g(x) = (sin(x))^2,  
    /// где аргумент X задается параметром <paramref name="x"/>, который удовлетворяет интервалу (w, w),
    /// а второй параметр <paramref name="count"/> задает количество членов ряда.
    /// Результатом функции является число, которое получается при подстановке 
    /// параметров x и count в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="count">Количество членов ряда</param>
    /// <returns>double</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_15", "g(x) = (sin(x))^2")]
    public class CSin_15
    {
        public static double Sin_15(double x, int count)
        {
            double fact = 1;
            double sum = 0;
            for (int k = 1; k <= count; k++)
            {
                fact = fact * (2 * k) * (2 * k - 1);
                if (Math.Abs(Math.Pow(-1, k + 1) * Math.Pow(2, 2 * k - 1) * Math.Pow(x, 2 * k) / fact) < 1e-15) break;
                sum = sum + Math.Pow(-1, k + 1) * Math.Pow(2, 2 * k - 1) * Math.Pow(x, 2 * k) / fact;
            }
            if (Math.Abs(sum) < 1e-15) sum = 0;
            return (sum);
        }
    }
    /// <summary>
    /// Возвращает область определения функции g(x) = (sin(x))^2,  
    /// (w, w).
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_15_in", "(w, w)")]
    public class CSin_15_in
    {
        public static string Sin_15_in()
        {
            return ("(w, w)");
        }
    }
    /// <summary>
    /// Возвращает имя функции, обратной функции g(x) = sin(x),  
    /// арксинус.
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_15_inv", "арксинус")]
    public class CSin_15_inv
    {
        public static string Sin_15_inv()
        {
            return ("арксинус");
        }
    }
    /// <summary>
    /// Реализует функцию g(x)=(sin(x))^2,  
    /// где аргумент X задается параметром <paramref name="x"/>, который удовлетворяет интервалу (w, w),
    /// второй параметр <paramref name="er"/> задает минимальный размер остаточного члена ряда,
    /// а третий параметр <paramref name="cnst"/> задает число меньше 1 и больше 0,
    /// использующееся в формуле остаточного члена.
    /// Результатом функции является число, которое получается при подстановке 
    /// параметров x, er и cnst в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="er">минимальный размер остаточного члена ряда</param>
    /// <paramref name="cnst"/>Число меньше 1 и больше 0</param>
    /// <returns>double</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_16", "(sin(x))^2")]
    public class CSin_16
    {
        public static double Sin_16(double x, double er, double cnst = 0.8)
        {
            double fact = 2;
            double fact2 = 1;
            double sum = 0;
            double residue = 10;
            int k = 1;
            while ((Math.Abs(residue) > er) && (k <= 100))
            {
                fact2 = fact2 * (k + 1);
                sum = sum + Math.Pow(-1, k + 1) * Math.Pow(2, 2 * k - 1) * Math.Pow(x, 2 * k) / fact;
                k++;
                fact = fact * (2 * k) * (2 * k - 1);
                residue = (Math.Pow(x, k) / fact2) * Math.Pow(-1, k + 1) * Math.Pow(2, 2 * k - 1) * Math.Pow(cnst * x, 2 * k) / fact;
            }
            return (sum + residue);
        }
    }
    /// <summary>
    /// Возвращает область определения функции g(x) = (sin(x))^2,  
    /// (w, w).
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_16_in", "(w, w)")]
    public class CSin_16_in
    {
        public static string Sin_16_in()
        {
            return ("(w, w)");
        }
    }
    /// <summary>
    /// Возвращает имя функции, обратной функции g(x) = sin(x),  
    /// арксинус.
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_16_inv", "арксинус")]
    public class CSin_16_inv
    {
        public static string Sin_16_inv()
        {
            return ("арксинус");
        }
    }
    /// <summary>
    /// Реализует функцию g(x) = (cos(x))^2,  
    /// где аргумент X задается параметром <paramref name="x"/>, который удовлетворяет интервалу (w, w),
    /// а второй параметр <paramref name="count"/> задает количество членов ряда.
    /// Результатом функции является число, которое получается при подстановке 
    /// параметров x и count в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="count">Количество членов ряда</param>
    /// <returns>double</returns>
    [OpaqueFunction()]
    [FunctionName("Cos_17", "g(x) = (cos(x))^2")]
    public class CCos_17
    {
        public static double Cos_17(double x, int count)
        {
            double fact = 1;
            double sum = 0;
            for (int k = 1; k <= count; k++)
            {
                fact = fact * (2 * k) * (2 * k - 1);
                if (Math.Abs(Math.Pow(-1, k + 1) * Math.Pow(2, 2 * k - 1) * Math.Pow(x, 2 * k) / fact) < 1e-15) break;
                sum = sum + Math.Pow(-1, k + 1) * Math.Pow(2, 2 * k - 1) * Math.Pow(x, 2 * k) / fact;
            }
            if (Math.Abs(sum) < 1e-15) sum = 0;
            sum = 1 - sum;
            return (sum);

        }
    }
    /// <summary>
    /// Возвращает область определения функции g(x) = (cos(x))^2,  
    /// (w, w).
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Cos_17_in", "(w, w)")]
    public class CCos_17_in
    {
        public static string Cos_17_in()
        {
            return ("(w, w)");
        }
    }
    /// <summary>
    /// Возвращает имя функции, обратной функции g(x) = cos(x),  
    /// арккосинус.
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Cos_17_inv", "арккосинус")]
    public class CCos_17_inv
    {
        public static string Cos_17_inv()
        {
            return ("арккосинус");
        }
    }
    /// <summary>
    /// Реализует функцию g(x)=(cos(x))^2,  
    /// где аргумент X задается параметром <paramref name="x"/>, который удовлетворяет интервалу (w, w),
    /// второй параметр <paramref name="er"/> задает минимальный размер остаточного члена ряда,
    /// а третий параметр <paramref name="cnst"/> задает число меньше 1 и больше 0,
    /// использующееся в формуле остаточного члена.
    /// Результатом функции является число, которое получается при подстановке 
    /// параметров x, er и cnst в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="er">минимальный размер остаточного члена ряда</param>
    /// <paramref name="cnst"/>Число меньше 1 и больше 0</param>
    /// <returns>double</returns>
    [OpaqueFunction()]
    [FunctionName("Cos_18", "(cos(x))^2")]
    public class CCos_18
    {
        public static double Cos_18(double x, double er, double cnst = 0.8)
        {
            double fact = 2;
            double fact2 = 1;
            double sum = 0;
            double residue = 10;
            int k = 1;
            while ((Math.Abs(residue) > er) && (k <= 100))
            {
                fact2 = fact2 * (k + 1);
                sum = sum + Math.Pow(-1, k + 1) * Math.Pow(2, 2 * k - 1) * Math.Pow(x, 2 * k) / fact;
                k++;
                fact = fact * (2 * k) * (2 * k - 1);
                residue = (Math.Pow(x, k) / fact2) * Math.Pow(-1, k + 1) * Math.Pow(2, 2 * k - 1) * Math.Pow(cnst * x, 2 * k) / fact;
            }
            sum = 1 - (sum + residue);
            return (sum);
        }
    }
    /// <summary>
    /// Возвращает область определения функции g(x) = (cos(x))^2,  
    /// (w, w).
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Cos_18_in", "(w, w)")]
    public class CCos_18_in
    {
        public static string Cos_18_in()
        {
            return ("(w, w)");
        }
    }
    /// <summary>
    /// Возвращает имя функции, обратной функции g(x) = cos(x),  
    /// арккосинус.
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Cos_18_inv", "арккосинус")]
    public class CCos_18_inv
    {
        public static string Cos_18_inv()
        {
            return ("арккосинус");
        }
    }
    /// <summary>
    /// Реализует функцию g(x) = (sin(x))^3,  
    /// где аргумент X задается параметром <paramref name="x"/>, который удовлетворяет интервалу (w, w),
    /// а второй параметр <paramref name="count"/> задает количество членов ряда.
    /// Результатом функции является число, которое получается при подстановке 
    /// параметров x и count в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="count">Количество членов ряда</param>
    /// <returns>double</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_19", "g(x) = (sin(x))^3")]
    public class CSin_19
    {
        public static double Sin_19(double x, int count)
        {
            double fact = 1;
            double sum = 0;
            for (int k = 1; k <= count; k++)
            {
                fact = fact * (2 * k + 1) * (2 * k);
                if (Math.Abs(Math.Pow(-1, k + 1) * (Math.Pow(3, 2 * k + 1) - 3) * Math.Pow(x, 2 * k + 1) / fact) < 1e-15) break;
                sum = sum + Math.Pow(-1, k + 1) * (Math.Pow(3, 2 * k + 1) - 3) * Math.Pow(x, 2 * k + 1) / fact;
            }
            if (Math.Abs(sum) < 1e-15) sum = 0;
            sum = sum / 4;
            return (sum);

        }
    }
    /// <summary>
    /// Возвращает область определения функции g(x) = (sin(x))^3,  
    /// (w, w).
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_19_in", "(w, w)")]
    public class CSin_19_in
    {
        public static string Sin_19_in()
        {
            return ("(w, w)");
        }
    }
    /// <summary>
    /// Возвращает имя функции, обратной функции g(x) = sin(x),  
    /// арксинус.
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_19_inv", "арксинус")]
    public class CSin_19_inv
    {
        public static string Sin_19_inv()
        {
            return ("арксинус");
        }
    }
    /// <summary>
    /// Реализует функцию g(x)=(sin(x))^3,  
    /// где аргумент X задается параметром <paramref name="x"/>, который удовлетворяет интервалу (w, w),
    /// второй параметр <paramref name="er"/> задает минимальный размер остаточного члена ряда,
    /// а третий параметр <paramref name="cnst"/> задает число меньше 1 и больше 0,
    /// использующееся в формуле остаточного члена.
    /// Результатом функции является число, которое получается при подстановке 
    /// параметров x, er и cnst в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="er">минимальный размер остаточного члена ряда</param>
    /// <paramref name="cnst"/>Число меньше 1 и больше 0</param>
    /// <returns>double</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_20", "(sin(x))^3")]
    public class CSin_20
    {
        public static double Sin_20(double x, double er, double cnst = 0.8)
        {
            double fact = 6;
            double fact2 = 1;
            double sum = 0;
            double residue = 10;
            int k = 1;
            while ((Math.Abs(residue) > er) && (k <= 100))
            {
                fact2 = fact2 * (k + 1);
                sum = sum + Math.Pow(-1, k + 1) * (Math.Pow(3, 2 * k + 1) - 3) * Math.Pow(x, 2 * k + 1) / fact;
                k++;
                fact = fact * (2 * k + 1) * (2 * k);
                residue = (Math.Pow(x, k) / fact2) * Math.Pow(-1, k + 1) * (Math.Pow(3, 2 * k + 1) - 3) * Math.Pow(cnst * x, 2 * k + 1) / fact;
            }
            sum = (sum + residue) / 4;
            return (sum);
        }
    }
    /// <summary>
    /// Возвращает область определения функции g(x) = (sin(x))^3,  
    /// (w, w).
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_20_in", "(w, w)")]
    public class CSin_20_in
    {
        public static string Sin_20_in()
        {
            return ("(w, w)");
        }
    }
    /// <summary>
    /// Возвращает имя функции, обратной функции g(x) = sin(x),  
    /// арксинус.
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_20_inv", "арксинус")]
    public class CSin_20_inv
    {
        public static string Sin_20_inv()
        {
            return ("арксинус");
        }
    }
    /// <summary>
    /// Реализует функцию g(x) = (cos(x))^3,  
    /// где аргумент X задается параметром <paramref name="x"/>, который удовлетворяет интервалу (w, w),
    /// а второй параметр <paramref name="count"/> задает количество членов ряда.
    /// Результатом функции является число, которое получается при подстановке 
    /// параметров x и count в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="count">Количество членов ряда</param>
    /// <returns>double</returns>
    [OpaqueFunction()]
    [FunctionName("Cos_21", "g(x) = (cos(x))^3")]
    public class CCos_21
    {
        public static double Cos_21(double x, int count)
        {
            double fact = 1;
            double sum = 4;
            for (int k = 1; k <= count; k++)
            {
                fact = fact * (2 * k) * (2 * k - 1);
                if (Math.Abs(Math.Pow(-1, k) * (Math.Pow(3, 2 * k) + 3) * Math.Pow(x, 2 * k) / fact) < 1e-15) break;
                sum = sum + Math.Pow(-1, k) * (Math.Pow(3, 2 * k) + 3) * Math.Pow(x, 2 * k) / fact;
            }
            if (Math.Abs(sum) < 1e-15) sum = 0;
            sum = sum / 4;
            return (sum);

        }
    }
    /// <summary>
    /// Возвращает область определения функции g(x) = (cos(x))^3,  
    /// (w, w).
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Cos_21_in", "(w, w)")]
    public class CCos_21_in
    {
        public static string Cos_21_in()
        {
            return ("(w, w)");
        }
    }
    /// <summary>
    /// Возвращает имя функции, обратной функции g(x) = cos(x),  
    /// арккосинус.
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Cos_21_inv", "арккосинус")]
    public class CCos_21_inv
    {
        public static string Cos_21_inv()
        {
            return ("арккосинус");
        }
    }
    /// <summary>
    /// Реализует функцию g(x)=(cos(x))^3,  
    /// где аргумент X задается параметром <paramref name="x"/>, который удовлетворяет интервалу (w, w),
    /// второй параметр <paramref name="er"/> задает минимальный размер остаточного члена ряда,
    /// а третий параметр <paramref name="cnst"/> задает число меньше 1 и больше 0,
    /// использующееся в формуле остаточного члена.
    /// Результатом функции является число, которое получается при подстановке 
    /// параметров x, er и cnst в функцию.
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="er">минимальный размер остаточного члена ряда</param>
    /// <paramref name="cnst"/>Число меньше 1 и больше 0</param>
    /// <returns>double</returns>
    [OpaqueFunction()]
    [FunctionName("Cos_22", "(cos(x))^3")]
    public class CCos_22
    {
        public static double Cos_22(double x, double er, double cnst = 0.8)
        {
            double fact = 1;
            double fact2 = 1;
            double sum = 0;
            double residue = 10;
            int k = 0;
            while ((Math.Abs(residue) > er) && (k <= 100))
            {
                fact2 = fact2 * (k + 1);
                sum = sum + Math.Pow(-1, k) * (Math.Pow(3, 2 * k) + 3) * Math.Pow(x, 2 * k) / fact;
                k++;
                fact = fact * (2 * k) * (2 * k - 1);
                residue = (Math.Pow(x, k) / fact2) * Math.Pow(-1, k) * (Math.Pow(3, 2 * k) + 3) * Math.Pow(cnst * x, 2 * k) / fact;
            }
            sum = (sum + residue) / 4;
            return (sum);
        }
    }
    /// <summary>
    /// Возвращает область определения функции g(x) = (cos(x))^3,  
    /// (w, w).
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Cos_22_in", "(w, w)")]
    public class CCos_22_in
    {
        public static string Cos_22_in()
        {
            return ("(w, w)");
        }
    }
    /// <summary>
    /// Возвращает имя функции, обратной функции g(x) = cos(x),  
    /// арккосинус.
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Cos_22_inv", "арккосинус")]
    public class CCos_22_inv
    {
        public static string Cos_22_inv()
        {
            return ("арккосинус");
        }
    }
}
