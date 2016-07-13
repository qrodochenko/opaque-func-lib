#define _Debug
using System;
namespace OpaqueFunctions
{
    /// <summary>
    /// Реализует рекуррентное вычисление факториала, используется во многих функциях для избежаний переполнения и простоты вычислений
    /// </summary>
    [OpaqueFunction()]
    [FunctionName("CFakt", "Fakt")]
    public static class CFakt
    {
        public static long Fakt(long N)
        {
            if (N == 0 || N == 1)
                return 1;
            else
                return N * Fakt(N - 1);
        }
    }
    /// <summary>
    /// Реализует тригонометрическую функцию sin(x),  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    [OpaqueFunction()]
    [FunctionName("Sin_1", "sin")]
    public static class CSin_1
    {
        public static double Sin_1(double angle, int count)
        {
#if _Debug
            if (Math.Abs(angle) >= Math.PI / 2.0)
                throw new Exception("Значение x не принадлежит области определения функции!");
#endif
            double X1, X = angle, result = 0, top, bottom;
            for (int i = 0; i < count; i++)
            {
                X1 = Math.Pow(X, 2 * i + 1);
                top = X1 * Math.Pow(-1, i);
                bottom = CFakt.Fakt(2 * i + 1);
                result += top / bottom;
            }
            return result;
        }
    }
    /// <summary>
    /// Возвращает область определения функции sin(x)
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Sin_1_in", "Sin(x)")]
    public static class CSin_1_in
    {
        public static string Sin_1_in()
        {
            string str = "(-Pi/2, Pi/2)";
            return str;
        }
    }
    /// <summary>
    /// Реализует тригонометрическую функцию cos(x),  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    [OpaqueFunction()]
    [FunctionName("Cos_1", "Cos(x)")]
    public static class CCos_1
    {
        public static double Cos_1(double angle, int count)
        {
#if _Debug
            if (Math.Abs(angle) >= Math.PI)
                throw new Exception("Значение x не принадлежит области определения функции!");
#endif
            double X1,X = angle, result = 0, top, bottom;
            for (int i = 1; i < count; i++)
            {
                if (i <= 1)
                    result = 1 - X * X / 2.0;
                else
                {
                    X1 = Math.Pow(X, 2 * i);
                    top = X1 * Math.Pow(-1, i);
                    bottom = CFakt.Fakt(2 * i);
                    result += top / bottom;
                }
            }
            return result;
        }
    }
    /// <summary>
    /// Возвращает область определения функции cos(x)
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Cos_1_in", "Cos(x)")]
    public static class CCos_1_in
    {
        public static string Cos_1_in()
        {
            string str = "(-Pi, Pi)";
            return str;
        }
    }
    /// <summary>
    /// Реализует тригонометрическую функцию arcsin(x),  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    [OpaqueFunction()]
    [FunctionName("Arcsin_1", "Arcsin(x)")]
    public static class CArcsin_1
    {
        public static double Arcsin_1(double angle, int count)
        {
#if _Debug
            if (Math.Abs(angle) >= 1.0)
                throw new Exception("Значение x не принадлежит области определения функции!");
#endif
            double X1, X = angle, result = 0, top, bottom;
            for (int i = 4; i < count; i++)
            {
                if (i <= 4)
                    result = X + Math.Pow(X, 3) / 6.0 + 3.0 * Math.Pow(X, 5) / 40.0 + 5 * Math.Pow(X, 7) / 112.0;
                else
                {
                    X1 = Math.Pow(X, 2 * i + 1);
                    top = X1 * (2 * i - 1);
                    bottom = 2 * i * (2 * i + 1);
                    result += top / bottom;
                }
            }
            return result;
        }
    }
    /// <summary>
    /// Возвращает область определения функции arcsin(x)
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Arcsin_1_in", "Arcsin(x)")]
    public static class CArcsin_1_in
    {
        public static string Arcsin_1_in()
        {
            string str = "(-1, 1)";
            return str;
        }
    }
    /// <summary>
    /// Реализует тригонометрическую функцию arccos(x),  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    [OpaqueFunction()]
    [FunctionName("Arccos_1", "Arccos(x)")]
    public static class CArccos_1
    {
        public static double Arccos_1(double angle, int count)
        {
#if _Debug
            if (Math.Abs(angle) >= 1.0)
                throw new Exception("Значение x не принадлежит области определения функции!");
#endif
            double X1, X = angle, result = 0, top, bottom;
            for (int i = 4; i < count; i++)
            {
                if (i <= 4)
                    result = X + Math.Pow(X, 3) / 6.0 + 3.0 * Math.Pow(X, 5) / 40.0 + 5 * Math.Pow(X, 7) / 112.0;
                else
                {
                    X1 = Math.Pow(X, 2 * i + 1);
                    top = X1 * (2 * i - 1);
                    bottom = 2 * i * (2 * i + 1);
                    result += top / bottom;
                }
            }
            return Math.PI / 2.0 - result;
        }
    }
    /// <summary>
    /// Возвращает область определения функции arccos(x)
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Arccos_1_in", "Arccos(x)")]
    public static class CArccos_1_in
    {
        public static string Arccos_1_in()
        {
            string str = "(-1, 1)";
            return str;
        }
    }
    /// <summary>
    /// Используется для вычисления чисел Бернулли
    /// Функция rec вычисляет количество сочетаний Cn_k, она используется в функции Ber
    /// Функция Ber вычисляет сами числа Бернулли
    /// </summary>
    public static class Bernoulli
    {
        public static long rec(long n, long k)
        {
            long result = 1;
            if (n == k)
                return 1;
            else
                if (k == 1)
                return n;
            else
                if (k > n)
                return 0;
            else
            {
                for (long i = 1; i <= k; ++i)
                {
                    result *= n--;
                    result /= i;
                }
            }
            return result;
        }
        public static double Ber(int n)
        {
            double sum = 0;
            if (n == 0)
                return 1;
            else
                if (n == 1)
                return -1.0 / 2.0;
            else
                if (n % 2 == 1)
                return 0;
            else
                for(int k = 1; k <= n; k++)
                {
                    sum += rec(n + 1, k + 1) * Ber(n - k);
                }
            return -1.0/((double)(n+1))*sum;
        }  
    }
    /// <summary>
    /// Реализует тригонометрическую функцию tg(x), при аппроксимации которой общий член выражается с помощью чисел Бернулли
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    [OpaqueFunction()]
    [FunctionName("Tg_1", "tg(x)")]
    public static class CTg_1
    {
        public static double Tg_1(double angle, int count)
        {
#if _Debug
            if (Math.Abs(angle) >= Math.PI / 2.0) 
                throw new Exception("Значение x не принадлежит области определения функции!");
#endif
            double X1, X = angle, top, common, bottom, result = 0;
            for (int i = 1; i <= count; i++) 
            {
                if (i == 5)
                    result = X + Math.Pow(X, 3) / 3.0 + 2.0 * Math.Pow(X, 5) / 15.0 + 17.0 * Math.Pow(X, 7) / 315.0 + 62.0 * Math.Pow(X, 9) / 2835.0;
                else
                {
                    X1 = Math.Pow(X, 2 * i - 1);
                    top = Math.Pow(2, 2 * i) * X1 * (Math.Pow(2, 2 * i) - 1);
                    bottom = CFakt.Fakt(2 * i);
                    common = top / bottom;
                    result += common * Math.Abs(Bernoulli.Ber(2 * i));
                }
            }
            return result;
        }
    }
    /// <summary>
    /// Возвращает область определения функции tg(x)
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Tg_1_in", "tg(x)")]
    public static class CTg_1_in
    {
        public static string Tg_1_in()
        {
            string str = "(-Pi/2, Pi/2)";
            return str;
        }
    }
    /// <summary>
    /// Реализует тригонометрическую функцию сtg(x), при аппроксимации которой общий член выражается с помощью чисел Бернулли
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    [OpaqueFunction()]
    [FunctionName("Ctg_1", "сtg(x)")]
    public static class Cctg_1
    {
        public static double Сtg_1(double angle, int count)
        {
#if _Debug
            if (Math.Abs(angle) <= 0.0 || Math.Abs(angle) >= Math.PI) 
                throw new Exception("Значение x не принадлежит области определения функции!");
#endif
            double result = Math.Pow(angle,-1), X = angle, X1, top, bottom, common;
            for (int i = 4; i < count; i++)
                if (i == 4)
                    result -= (X / 3.0 + Math.Pow(X, 3) / 45.0 + 2.0 * Math.Pow(X, 5) / 945.0 + Math.Pow(X, 7) / 4725.0);
                else
                {
                    X1 = Math.Pow(X, 2 * i - 1);
                    top = Math.Pow(2, 2 * i) * X1;
                    bottom = CFakt.Fakt(2 * i);
                    common = top / bottom;
                    result -= common * Math.Abs(Bernoulli.Ber(2 * i));
                }
            return result;
        }
    }
    /// <summary>
    /// Возвращает область определения функции ctg(x)
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Ctg_1_in", "ctg(x)")]
    public static class Cctg_1_in
    {
        public static string Ctg_1_in()
        {
            string str = "(0, Pi)";
            return str;
        }
    }
    /// <summary>
    /// Реализует тригонометрическую функцию arctg(x),  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    [OpaqueFunction()]
    [FunctionName("Arctg_1", "Arctg(x)")]
    public static class CArctg_1
    {
        public static double Arctg_1(double angle, int count)
        {
#if _Debug
            if (Math.Abs(angle) > 1.0)
                throw new Exception("Значение x не принадлежит области определения функции!");
#endif
            double result = 0, top, bottom, X = angle;
            for(int i = 0; i < count; i++)
            {
                top = Math.Pow(-1, i) * Math.Pow(X, 2 * i + 1);
                bottom = 2 * i + 1;
                result += top / bottom;
            }
            return result;
        }
    }
    /// <summary>
    /// Возвращает область определения функции arctg(x)
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Arctg_1_in", "Arctg(x)")]
    public static class CArctg_1_in
    {
        public static string Arctg_1_in()
        {
            string str = "(-1, 1)";
            return str;
        }
    }
    /// <summary>
    /// Реализует тригонометрическую функцию arcctg(x),  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    [OpaqueFunction()]
    [FunctionName("Arcctg_1", "Arcctg(x)")]
    public static class CArcctg_1
    {
        public static double Arcctg_1(double angle, int count)
        {
#if _Debug
            if (Math.Abs(angle) >= 1.0)
                throw new Exception("Значение x не принадлежит области определения функции!");
#endif
            double result = 0, top, bottom, X = angle;
            for(int i = 0; i < count; i++)
            {
                top = Math.Pow(-1, i) * Math.Pow(X, 2 * i + 1);
                bottom = 2 * i + 1;
                result += top / bottom;
            }
            return  Math.PI*Math.Pow(2,-1)-result;
        }
    }
    /// <summary>
    /// Возвращает область определения функции arcctg(x)
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Arcctg_1_in", "arcctg(x)")]
    public static class CArcctg_1_in
    {
        public static string Arcctg_1_in()
        {
            string str = "(-1, 1)";
            return str;
        }
    }
    /// <summary>
    /// Реализует тригонометрическую функцию cosec(x), при аппроксимации которой общий член выражается с помощью чисел Бернулли
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
     [OpaqueFunction()]
    [FunctionName("Cosec_1", "cosec(x)")]
   public static class CCosec_1
    {
        public static double Cosec_1(double angle, int count)
        {
#if _Debug
            if (Math.Abs(angle) >= Math.PI) 
                throw new Exception("Значение x не принадлежит области определения функции!");
#endif
            double result = 0, X = angle, top, bottom, common;
            for(int i = 4; i < count; i++)
            {
                if (i == 4)
                     result = Math.Pow(X, -1) + X / 6.0 + 7.0 * Math.Pow(X, 3) / 360.0 + 31.0 * Math.Pow(X, 5) / 15120.0 + 127.0*Math.Pow(X,7)/604800.0;
                else
                {
                    top = 2 * (Math.Pow(2, 2 * i - 1) - 1) * Math.Pow(X, 2 * i - 1);
                    bottom = CFakt.Fakt(2 * i);
                    common = top / bottom;
                    common *= Bernoulli.Ber(2 * i);
                    result += common;
                }
            }
            return result;
        }
    }
    /// <summary>
    /// Возвращает область определения функции cosec(x)
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Cosec_1_in", "cosec(x)")]
    public static class CCosec_1_in
    {
        public static string Cosec_1_in()
        {
            string str = "(-Pi, Pi)";
            return str;
        }
    }
    /// <summary>
    /// Реализует тригонометрическую функцию sin^2(x),  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    [OpaqueFunction()]
    [FunctionName("Xpow2_Sin_1", "sin^2(x)")]
    public static class CXpow2_Sin_1
    {
        public static double Xpow2_Sin_1(double angle, int count)
        {
#if _Debug
            if (Math.Abs(angle) >= Math.PI / 2.0) 
                throw new Exception("Значение x не принадлежит области определения функции!");
#endif
            double result = 0, bottom, top, X = angle, common;
            for(int i = 1; i < count; i++)
            {
                top = Math.Pow(2, 2 * i - 1) * Math.Pow(-1, i + 1);
                bottom = CFakt.Fakt(2 * i);
                common = top / bottom;
                common *= Math.Pow(X, 2 * i);
                result += common;
            }
            return result;
        }
    }
    /// <summary>
    /// Возвращает область определения функции sin^2(x)
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Xpow2_Sin_1_in", "Sin^2(x)")]
    public static class CXpow2_Sin_1_in
    {
        public static string Xpow2_Sin_1_in()
        {
            string str = "(-Pi/2, Pi/2)";
            return str;
        }
    }
    /// <summary>
    /// Реализует тригонометрическую функцию cos^2(x),  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    [OpaqueFunction()]
    [FunctionName("Xpow2_Cos_1", "cos^2(x)")]
    public static class CXpow2_Cos_1
    {
        public static double Xpow2_Cos_1(double angle, int count)
        {
#if _Debug
            if (Math.Abs(angle) >= Math.PI)
                throw new Exception("Значение x не принадлежит области определения функции!");
#endif
            double result = 0, bottom, top, X = angle, common;
            for (int i = 1; i < count; i++)
            {
                top = Math.Pow(2, 2 * i - 1) * Math.Pow(-1, i + 1);
                bottom = CFakt.Fakt(2 * i);
                common = top / bottom;
                common *= Math.Pow(X, 2 * i);
                result += common;
            }
            return 1 - result;
        }
    }
    /// <summary>
    /// Возвращает область определения функции cos^2(x)
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Xpow2_Cos_1_in", "Cos^2(x)")]
    public static class CXpow2_Cos_1_in
    {
        public static string Xpow2_Cos_1_in()
        {
            string str = "(-Pi, Pi)";
            return str;
        }
    }
    /// <summary>
    /// Реализует тригонометрическую функцию sin^3(x),  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    [OpaqueFunction()]
    [FunctionName("Xpow3_Sin_1", "sin^3(x)")]
    public static class CXpow3_Sin_1
    {
        public static double Xpow3_Sin_1(double angle, int count)
        {
#if _Debug
            if (Math.Abs(angle) >= Math.PI / 2.0) 
                throw new Exception("Значение x не принадлежит области определения функции!");
#endif
            double result = 0, top, bottom, common, X = angle;
            for (int i = 1; i < count; i++) 
            {
                top = Math.Pow(-1, i + 1) * (Math.Pow(3, 2 * i + 1) - 3);
                bottom = CFakt.Fakt(2 * i + 1);
                common = top / bottom * Math.Pow(X, 2 * i + 1) / 4.0;
                result += common;
            }
            return result;
        }
    }
    /// <summary>
    /// Возвращает область определения функции sin^3(x)
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Xpow3_Sin_1_in", "Sin^3(x)")]
    public static class CXpow3_Sin_1_in
    {
        public static string Xpow3_Sin_1_in()
        {
            string str = "(-Pi/2, Pi/2)";
            return str;
        }
    }
    /// <summary>
    /// Реализует тригонометрическую функцию cos^3(x),  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    [OpaqueFunction()]
    [FunctionName("Xpow3_Cos_1", "cos^3(x)")]
    public static class CXpow3_Cos_1
    {
        public static double Xpow3_Cos_1(double angle, int count)
        {
#if _Debug
            if (Math.Abs(angle) >= Math.PI)
                throw new Exception("Значение x не принадлежит области определения функции!");
#endif
            double result = 0, top, bottom, common, X = angle;
            for (int i = 0; i < count; i++)
            {
                top = Math.Pow(-1, i) * (Math.Pow(3, 2 * i) + 3);
                bottom = CFakt.Fakt(2 * i );
                common = top / bottom * Math.Pow(X, 2 * i) / 4.0;
                result += common;
            }
            return result;
        }
    }
    /// <summary>
    /// Возвращает область определения функции cos^3(x)
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Xpow3_Cos_1_in", "Cos^3(x)")]
    public static class CXpow3_Cos_1_in
    {
        public static string Xpow3_Cos_1_in()
        {
            string str = "(-Pi, Pi)";
            return str;
        }
    }
}

