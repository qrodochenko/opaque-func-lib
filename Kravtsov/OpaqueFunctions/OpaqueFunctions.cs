﻿using System;

namespace OpaqueFunctions
{
    /// <summary>
    /// Реализует тригонометрическую функцию sin(x),  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    [OpaqueFunction()]
    [FunctionName("Csin_1", "sin")]
    public static class CSin_1
    {
        public static double Sin_1(double angle, int count)
        {
            double X = angle, fact = 1, sign = -1, result = 0, a;
            for (int i = 0; i < count; i++)
            {
                sign *= -1;
                for (int k = i; k <= 2 * i + 1; k++) 
                    X *= X;
                fact *= (2 * i + 1);
                a = sign * X / fact;
                result += a;

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
            double X1 = angle, fact = 1, sign = -1, result = 0, a;
            for (int i = 0; i < count; i++)
            {
                sign *= -1;
                for (int k = i; k <= 2 * i; k++)
                    X1 *= X1;
                for (int k = 1; k <= 2 * i; k++)
                    fact *= k;
                a = sign * X1 / fact;
                result += a;
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
            double result = 0, X = angle;
            int k1 = 1, k2 = 1;
            for (int i = 0; i < count; i++)
            {
                for (int k = i; k <= 2 * i + 1; k++)
                    X *= X;
                k1 = 2 * i - 1;
                k2 = 2 * i * (2 * i + 1);
                result += k1 * X / k2;
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
            double result = 0, X = angle;
            double k1 = 1, k2 = 1;
            for (int i = 0; i < count; i++)
            {
                k1 = 2 * i - 1;
                k2 = 2 * i * (2 * i + 1);
                for (int k = i; k <= 2 * i + 1; k++)
                    X *= X;
                result += k1 * X / k2;
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
    ///  Вычисляет числа Бернулли
    /// </summary>
    public static class Bernoulli
    {
        public static long  fact(int N)
        {
            if (N < 0) 
                return 0; 
            if (N == 0) 
                return 1; 
            else 
                return N * fact(N - 1); 
        }
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
    /// Реализует тригонометрическую функцию tg(x),  
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
            double X = angle, sum = 0, Ber = 0, two;
            long fakt;
            for (int i = 1; i <= count; i++) 
            {
                for (int k = i; k <= 2 * i + 1; k++)
                    X *= X;
                two = Math.Pow(2.0, (double)(2 * i));
                fakt = Bernoulli.fact(2 * i);
                Ber = Math.Abs(Bernoulli.Ber(2 * i));
                sum += two * (two - 1) / fakt * X * Ber;
            }
            return sum;
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
            double result = 0, sign = -1, X = angle;
            int k1;
            for (int i = 0; i < count; i++)
            {
                for (int k = i; k <= 2 * i + 1; k++)
                    X *= X;
                k1 = 2 * i + 1;
                result += sign * X / k1;
                sign *= -1;
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
            double result = 0, sign = -1, X = angle;
            int k1;
            for (int i = 0; i < count; i++)
            {
                for (int k = i; k <= 2 * i; k++)
                    X *= X;
                k1 = 2 * i + 1;
                result += sign * X / k1;
                sign *= -1;
            }
            return Math.PI / 2.0 - result;
        }
    }
    /// <summary>
    /// Возвращает область определения функции arcctg(x)
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("Arcctg_1_in", "Arcctg(x)")]
    public static class CArcctg_1_in
    {
        public static string Arcctg_1_in()
        {
            string str = "(-1, 1)";
            return str;
        }
    }
    // Пропустил sec & cosec

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
            double result=0, X = angle;
            int one = 1, k1 = 1, k2 = 1;
            for (int i = 1; i < count; i++)
            {
                for (int k = i; k <= 2 * i; k++) 
                    X*=X;
                for (int k = i; k <= 2 * i - 1; k++)
                    k1 *= 2;
                for (int k = 1; k <= 2 * i; k++)
                    k2 *= k;
                result += k1 / k2 * one * X;
                one*=-1;
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
            double result = 0, X = angle;
            int one = 1, k1 = 1, k2 = 1;
            for (int i = 1; i < count; i++)
            {
                for (int k = i; k <= 2 * i; k++)
                    X *= X;
                for (int k = i; k <= 2 * i - 1; k++)
                    k1 *= 2;
                for (int k = 1; k <= 2 * i; k++)
                    k2 *= k;
                result += k1 / k2 * one * X;
                one *= -1;
            }
            return 1-result;
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
            double result = 0, X = angle;
            int one = 1, k1 = 1, k2 = 1;
            for (int i = 1; i < count; i++)
            {
                for (int k = i; k <= 2 * i + 1; k++) 
                    X *= X;
                for (int k = i; k <= 2 * i + 1; k++)
                    k1 *= 3;
                k1 -= 3;
                for (int k = 1; k <= 2 * i+1; k++)
                    k2 *= k;
                result += k1 / k2 * one * X;
                one *= -1;
            }
            return result / 4.0;
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
            double result = 0, X = angle;
            int one = 1, k1 = 1, k2 = 1;
            for (int i = 0; i < count; i++)
            {
                for (int k = i; k <= 2 * i; k++)
                    X *= X;
                for (int k = i; k <= 2 * i; k++)
                    k1 *= 3;
                k1 += 3;
                for (int k = 1; k <= 2 * i; k++)
                    k2 *= k;
                result += k1 / k2 * one * X;
                one *= -1;
            }
            return result / 4.0;
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

