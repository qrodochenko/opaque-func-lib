﻿ /// gfgh
#define _Debug
/// fhjj
using System;


namespace OpaqueFunctions
{
    /// <summary>
    /// Реализует степенную функцию (1 + x)^1/3,  
    /// где X задается параметром <paramref name="x"/>. 
    /// Результатом функции является целое число S - результат суммы элементов разложения ряда,
    /// Количество членов ряда задано параметром <paramref name="N"/>.
    /// Точность до десятого знака (1e-10) на интервале (-0.85, 0.87) при N = 100;
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слагаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_1_2", "(1+x)^1/3")]
    public static class CMath_1_2
    {
        public static double Math_1_2(double x, int N)
        {
#if _Debug
            if (Math.Abs(x) >= 1)
                throw new Exception("Значение 'x' не принадлежит области определения!");
            if (N < 0)
                throw new Exception("Значение 'N' не принадлежит области определения!");
#endif
            double S = 0;
            if (N > 1)
            {
                /// add (1+(1.0/3.0)*x)
                S = 1 + (1.0 / 3.0) * x;
                double F = (1.0 / 3.0) * x;
                for (int i = 2; i <= N; i++)
                {
                    F *= ((3.0 * i - 4) * Math.Pow(3.0 * i, -1)) * x;
                    F = -F;
                    /// add F
                    S += F;
                }
            }

            else
            {
                if (N == 0)
                {
                    /// add 1
                    S = 1;
                }
                if (N == 1)
                {
                    /// add (1+(1.0/3.0)*x)
                    S = 1 + (1.0 / 3.0) * x;
                }
            }
            return S;

        }
    };

    /// <summary>
    /// Возвращает область определения для степенной функции (1+x)^1/3
    /// </summary>
    [OpaqueFunction()]
    [FunctionName("Math_1_2", "(1+x)^1/3")]
    public static class CMath_1_2_in
    {
        public static string Math_1_2_in()
        {
            string s = "(-1, 1)";
            return s;

        }
    };



    /// <summary>
    /// Реализует степенную функцию (1 - x)^1/3,  
    /// где X задается параметром <paramref name="x"/>. 
    /// Результатом функции является целое число S - результат суммы элементов разложения ряда,
    /// Количество членов ряда задано параметром <paramref name="N"/>.
    /// Точность до десятого знака(1e-10) на интервале (-0.87, 0.85) при N = 100;
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_2_2", "(1-x)^1/3")]
    public static class CMath_2_2
    {
        public static double Math_2_2(double x, int N)
        {
#if _Debug
            if (Math.Abs(x) >= 1)
                throw new Exception("Значение 'x' не принадлежит области определения!");
            if (N < 0)
                throw new Exception("Значение 'N' не принадлежит области определения!");
#endif

            double S = 0;
            if (N > 1)
            {
                S = 1 - (1.0 / 3.0) * x;
                double F = (1.0 / 3.0) * x;
                for (int i = 2; i <= N; i++)
                {
                    F *= ((3.0 * i - 4) * Math.Pow(3.0 * i, -1)) * x;
                    S -= F;
                }
            }
            else
            {
                if (N == 0)
                {
                    S = 1;
                }
                if (N == 1)
                {
                    S = 1 - (1.0 / 3.0) * x;
                }
            }
            return S;

        }
    };


    /// <summary>
    /// Возвращает область определения для степенной функции (1 - x)^1/3
    /// </summary>
    [OpaqueFunction()]
    [FunctionName("Math_2_2", "(1-x)^1/3")]
    public static class CMath_2_2_in
    {
        public static string Math_2_2_in()
        {
            string s = "(-1, 1)";
            return s;

        }
    };


    /// <summary>
    /// Реализует степенную функцию (1 + x)^1/2,  
    /// где X задается параметром <paramref name="x"/>. 
    /// Результатом функции является целое число S - результат суммы элементов разложения ряда,
    /// Количество членов ряда задано параметром <paramref name="N"/>.
    /// Точность до десятого знака (1e-10) на сегменте (-0.85, 0.87) при N = 100;
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_3_2", "(1+x)^1/2")]
    public static class CMath_3_2
    {
        public static double Math_3_2(double x, int N)
        {
#if _Debug
            if (Math.Abs(x) >= 1)
                throw new Exception("Значение 'x' не принадлежит области определения!");
            if (N < 0)
                throw new Exception("Значение 'N' не принадлежит области определения!");
#endif

            double S = 1;
            if (N > 1)
            {
                S = 1 + (1.0 / 2.0) * x;
                double F = (1.0 / 2.0) * x;
                for (int i = 2; i <= N; i++)
                {
                    F *= ((2.0 * i - 3) * Math.Pow(2.0 * i, -1)) * x;
                    F = -F;
                    S += F;
                }
            }
            else
            {
                if (N == 0)
                {
                    S = 1;
                }
                if (N == 1)
                {
                    S = 1 + (1 / 2) * x;
                }
            }
            return S;

        }
    };

    /// <summary>
    /// Возвращает область определения для степенной функции (1+x)^1/2
    /// </summary>
    [OpaqueFunction()]
    [FunctionName("Math_3_2", "(1+x)^1/2")]
    public static class CMath_3_2_in
    {
        public static string Math_3_2_in()
        {
            string s = "(-1, 1)";
            return s;

        }
    };

    /// <summary>
    /// Реализует степенную функцию (1 - x)^1/2,  
    /// где X задается параметром <paramref name="x"/>. 
    /// Результатом функции является целое число S - результат суммы элементов разложения ряда,
    /// Количество членов ряда задано параметром <paramref name="N"/>.
    /// Точность до десятого знака (1e-10) на сегменте (-0.87, 0.85) при N = 100;
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_4_2", "(1-x)^1/2")]
    public static class CMath_4_2
    {
        public static double Math_4_2(double x, int N)
        {
#if _Debug
            if (Math.Abs(x) >= 1)
                throw new Exception("Значение 'x' не принадлежит области определения!");
            if (N < 0)
                throw new Exception("Значение 'N' не принадлежит области определения!");
#endif
            double S = 1;
            if (N > 1)
            {
                S = 1 - (1.0 / 2.0) * x;
                double F = (1.0 / 2.0) * x;
                for (int i = 2; i <= N; i++)
                {
                    F *= ((2.0 * i - 3) * Math.Pow(2.0 * i, -1)) * x;
                    S -= F;
                }
            }
            else
            {
                if (N == 0)
                {
                    S = 1;
                }
                if (N == 1)
                {
                    S = 1 - (1.0 / 2.0) * x;
                }
            }
            return S;

        }
    };

    /// <summary>
    /// Возвращает область определения для степенной функции (1-x)^1/2
    /// </summary>
    [OpaqueFunction()]
    [FunctionName("Math_4_2", "(1-x)^1/2")]
    public static class CMath_4_2_in
    {
        public static string Math_4_2_in()
        {
            string s = "(-1, 1)";
            return s;

        }
    };


    /// <summary>
    /// Реализует степенную функцию (1 + x)^1/4,  
    /// где X задается параметром <paramref name="x"/>. 
    /// Результатом функции является целое число S - результат суммы элементов разложения ряда,
    /// Количество членов ряда задано параметром <paramref name="N"/>.
    /// Точность до десятого знака (1e-10) на сегменте (-0.85, 0.87) при N = 100;
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_5_2", "(1+x)^1/4")]
    public static class CMath_5_2
    {
        public static double Math_5_2(double x, int N)
        {
#if _Debug
            if (Math.Abs(x) >= 1)
                throw new Exception("Значение 'x' не принадлежит области определения!");
            if (N < 0)
                throw new Exception("Значение 'N' не принадлежит области определения!");
#endif
            double S = 1;
            if (N > 1)
            {
                S = 1 + (1.0 / 4.0) * x;
                double F = (1.0 / 4.0) * x;
                for (int i = 2; i <= N; i++)
                {
                    F *= ((4.0 * i - 5) * Math.Pow(4.0 * i, -1)) * x;
                    F = -F;
                    S += F;
                }
            }
            else
            {
                if (N == 0)
                {
                    S = 1;
                }
                if (N == 1)
                {
                    S = 1 + (1.0 / 4.0) * x;
                }
            }
            return S;

        }
    };

    /// <summary>
    /// Возвращает область определения для степенной функции (1+x)^1/4
    /// </summary>
    [OpaqueFunction()]
    [FunctionName("Math_5_2", "(1+x)^1/4")]
    public static class CMath_5_2_in
    {
        public static string Math_5_2_in()
        {
            string s = "(-1, 1)";
            return s;

        }
    };

    /// <summary>
    /// Реализует степенную функцию (1 - x)^1/4,  
    /// где X задается параметром <paramref name="x"/>. 
    /// Результатом функции является целое число S - результат суммы элементов разложения ряда,
    /// Тест показал, что ряд сходится только в точке {0}
    /// Количество членов ряда задано параметром <paramref name="N"/>.
    /// Точность до десятого знака (1e-10) на сегменте (-0.87, 0.84) при N = 100;
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_6_2", "(1-x)^1/4")]
    public static class CMath_6_2
    {
        public static double Math_6_2(double x, int N)
        {
#if _Debug
            if (Math.Abs(x) >= 1)
                throw new Exception("Значение 'x' не принадлежит области определения!");
            if (N < 0)
                throw new Exception("Значение 'N' не принадлежит области определения!");
#endif
            double S = 1;
            if (N > 1)
            {
                S = 1 - (1.0 / 4.0) * x;
                double F = (1.0 / 4.0) * x;
                for (int i = 2; i < N; i++)
                {
                    F *= ((4.0 * i - 5) * Math.Pow(4.0 * i, -1)) * x;
                    S -= F;
                }
            }
            else
            {
                if (N == 0)
                {
                    S = 1;
                }
                if (N == 1)
                {
                    S = 1 - (1.0 / 4.0) * x;
                }
            }
            return S;

        }
    };

    /// <summary>
    /// Возвращает область определения для степенной функции (1-x)^1/4
    /// </summary>
    [OpaqueFunction()]
    [FunctionName("Math_6_2", "(1-x)^1/4")]
    public static class CMath_6_2_in
    {
        public static string Math_6_2_in()
        {
            string s = "(-1, 1)";
            return s;

        }
    };


    /// <summary>
    /// Реализует степенную функцию (1 + x)^(-1),  
    /// где X задается параметром <paramref name="x"/>. 
    /// Результатом функции является целое число S - результат суммы элементов разложения ряда,
    /// Количество членов ряда задано параметром <paramref name="N"/>.    
    /// Точность до десятого знака (1e-10) на сегменте (-0.79, 0.81) при N = 100;
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_7_2", "(1+x)^(-1)")]
    public static class CMath_7_2
    {
        public static double Math_7_2(double x, int N)
        {
#if _Debug
            if (Math.Abs(x) >= 1)
                throw new Exception("Значение 'x' не принадлежит области определения!");
            if (N < 0)
                throw new Exception("Значение 'N' не принадлежит области определения!");
#endif
            double S = 0;
            double F = 0;
            for (int i = 0; i <= N; i++)
            {
                F = (Math.Pow(-1, i)) * (Math.Pow(x, i));
                S += F;
            }
            return S;

        }
    };

    /// <summary>
    /// Возвращает область определения для степенной функции (1+x)^(-1)
    /// </summary>
    [OpaqueFunction()]
    [FunctionName("Math_7_2", "(1+x)^(-1)")]
    public static class CMath_7_2_in
    {
        public static string Math_7_2_in()
        {
            string s = "(-1, 1)";
            return s;

        }
    };

    /// <summary>
    /// Реализует степенную функцию (1 - x)^(-1),  
    /// где X задается параметром <paramref name="x"/>. 
    /// Результатом функции является целое число S - результат суммы элементов разложения ряда,
    /// Количество членов ряда задано параметром <paramref name="N"/>.
    /// Точность до десятого знака (1e-10) на сегменте (-0.81, 0.79) при N = 100;
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_8_2", "(1-x)^(-1)")]
    public static class CMath_8_2
    {
        public static double Math_8_2(double x, int N)
        {
#if _Debug
            if (Math.Abs(x) >= 1)
                throw new Exception("Значение 'x' не принадлежит области определения!");
            if (N < 0)
                throw new Exception("Значение 'N' не принадлежит области определения!");
#endif
            double S = 0;
            double F = 0;
            for (int i = 0; i <= N; i++)
            {
                F = (Math.Pow(x, i));
                S += F;
            }
            return S;

        }
    };

    /// <summary>
    /// Возвращает область определения для степенной функции (1-x)^(-1)
    /// </summary>
    [OpaqueFunction()]
    [FunctionName("Math_8_2", "(1-x)^(-1)")]
    public static class CMath_8_2_in
    {
        public static string Math_8_2_in()
        {
            string s = "(-1, 1)";
            return s;

        }
    };

    /// <summary>
    /// Реализует степенную функцию (1 + x)^(-2),  
    /// где X задается параметром <paramref name="x"/>. 
    /// Результатом функции является целое число S - результат суммы элементов разложения ряда,
    /// Количество членов ряда задано параметром <paramref name="N"/>.
    /// Точность до десятого знака (1e-10) на сегменте (-0.75, 0.77) при N = 100;
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_9_2", "(1+x)^(-2)")]
    public static class CMath_9_2
    {
        public static double Math_9_2(double x, int N)
        {
#if _Debug
            if (Math.Abs(x) >= 1)
                throw new Exception("Значение 'x' не принадлежит области определения!");
            if (N < 0)
                throw new Exception("Значение 'N' не принадлежит области определения!");
#endif
            double S = 0;
            double F = 0;
            for (int i = 0; i <= N; i++)
            {
                F = (Math.Pow(-1, i) * (i + 1) * Math.Pow(x, i));
                S += F;
            }
            return S;

        }
    };

    /// <summary>
    /// Возвращает область определения для степенной функции (1+x)^(-2)
    /// </summary>
    [OpaqueFunction()]
    [FunctionName("Math_9_2", "(1+x)^(-2)")]
    public static class CMath_9_2_in
    {
        public static string Math_9_2_in()
        {
            string s = "(-1, 1)";
            return s;

        }
    };

    /// <summary>
    /// Реализует степенную функцию (1 - x)^(-2),  
    /// где X задается параметром <paramref name="x"/>. 
    /// Результатом функции является целое число S - результат суммы элементов разложения ряда,
    /// Количество членов ряда задано параметром <paramref name="N"/>.
    /// Точность до десятого знака(1e-10) на сегменте (-0.77, 0.75) при N = 100;
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_10_2", "(1-x)^(-2)")]
    public static class CMath_10_2
    {
        public static double Math_10_2(double x, int N)
        {
#if _Debug
            if (Math.Abs(x) >= 1)
                throw new Exception("Значение 'x' не принадлежит области определения!");
            if (N < 0)
                throw new Exception("Значение 'N' не принадлежит области определения!");
#endif
            double S = 0;
            double F = 0;
            for (int i = 0; i <= N; i++)
            {
                F = ((i + 1) * Math.Pow(x, i));
                S += F;
            }
            return S;

        }
    };

    /// <summary>
    /// Возвращает область определения для степенной функции (1-x)^(-2)
    /// </summary>
    [OpaqueFunction()]
    [FunctionName("Math_10_2", "(1-x)^(-2)")]
    public static class CMath_10_2_in
    {
        public static string Math_10_2_in()
        {
            string s = "(-1, 1)";
            return s;

        }
    };

    /// <summary>
    /// Реализует степенную функцию (1 + x)^(-3),  
    /// где X задается параметром <paramref name="x"/>. 
    /// Результатом функции является целое число S - результат суммы элементов разложения ряда,
    /// Количество членов ряда задано параметром <paramref name="N"/>.
    /// Точность до десятого знака (1e-10) на сегменте (-0.73, 0.74) при N = 100;
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_11_2", "(1+x)^(-3)")]
    public static class CMath_11_2
    {
        public static double Math_11_2(double x, int N)
        {
#if _Debug
            if (Math.Abs(x) >= 1)
                throw new Exception("Значение 'x' не принадлежит области определения!");
            if (N < 0)
                throw new Exception("Значение 'N' не принадлежит области определения!");
#endif
            double S = 1;
            double F = 0;
            for (int i = 2; i < N + 2; i++)
            {
                F = (-1.0 / 2.0) * (Math.Pow(-1, i) * i * (i + 1) * Math.Pow(x, i - 1));
                S += F;
            }
            return S;

        }
    };

    /// <summary>
    /// Возвращает область определения для степенной функции (1+x)^(-3)
    /// </summary>
    [OpaqueFunction()]
    [FunctionName("Math_11_2", "(1+x)^(-3)")]
    public static class CMath_11_2_in
    {
        public static string Math_11_2_in()
        {
            string s = "(-1, 1)";
            return s;

        }
    };

    /// <summary>
    /// Реализует степенную функцию (1 - x)^(-3),  
    /// где X задается параметром <paramref name="x"/>. 
    /// Результатом функции является целое число S - результат суммы элементов разложения ряда,
    /// Количество членов ряда задано параметром <paramref name="N"/>.
    /// Точность до десятого знака (1e-10) на сегменте (-0.74, 0.73) при N = 100;
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_12_2", "(1-x)^(-3)")]
    public static class CMath_12_2
    {
        public static double Math_12_2(double x, int N)
        {
#if _Debug
            if (Math.Abs(x) >= 1)
                throw new Exception("Значение 'x' не принадлежит области определения!");
            if (N < 0)
                throw new Exception("Значение 'N' не принадлежит области определения!");
#endif
            /// add 1
            double S = 1;
            double F = 0;
            for (int i = 2; i < N + 2; i++)
            {
                F = (1.0 / 2.0) * (i * (i + 1) * Math.Pow(x, i - 1));
                /// add F
                S += F;
            }
            return S;

        }
    };

    /// <summary>
    /// Возвращает область определения для степенной функции (1-x)^(-3)
    /// </summary>
    [OpaqueFunction()]
    [FunctionName("Math_12_2", "(1-x)^(-3)")]
    public static class CMath_12_2_in
    {
        public static string Math_12_2_in()
        {
            string s = "(-1, 1)";
            return s;

        }
    };

    /// <summary>
    /// Реализует степенную функцию (1 + x)^(-4),  
    /// где X задается параметром <paramref name="x"/>. 
    /// Результатом функции является целое число S - результат суммы элементов разложения ряда,
    /// Количество членов ряда задано параметром <paramref name="N"/>.
    /// Точность до десятого знака (1e-10) на сегменте (-0.70, 0.71) при N = 100;
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_13_2", "(1+x)^(-4)")]
    public static class CMath_13_2
    {
        public static double Math_13_2(double x, int N)
        {
#if _Debug
            if (Math.Abs(x) >= 1)
                throw new Exception("Значение 'x' не принадлежит области определения!");
            if (N < 0)
                throw new Exception("Значение 'N' не принадлежит области определения!");
#endif
            /// add 1
            double S = 1;
            double F = 0;
            for (int i = 2; i < N; i++)
            {
                F = (1.0 / 6.0) * Math.Pow(-1, i+1) * (i * (i + 1) * (i + 2) * Math.Pow(x, i - 1));
                /// add F
                S += F;
            }
            return S;

        }
    };

    /// <summary>
    /// Возвращает область определения для степенной функции (1+x)^(-4)
    /// </summary>
    [OpaqueFunction()]
    [FunctionName("Math_13_2", "(1+x)^(-4)")]
    public static class CMath_13_2_in
    {
        public static string Math_13_2_in()
        {
            string s = "(-1, 1)";
            return s;

        }
    };

    /// <summary>
    /// Реализует степенную функцию (1 - x)^(-4),  
    /// где X задается параметром <paramref name="x"/>. 
    /// Результатом функции является целое число S - результат суммы элементов разложения ряда,
    /// Количество членов ряда задано параметром <paramref name="N"/>.
    /// Точность до десятого знака (1e-10) на сегменте (-0.71, 0.70) при N = 100;
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_14_2", "(1-x)^(-4)")]
    public static class CMath_14_2
    {
        public static double Math_14_2(double x, int N)
        {
#if _Debug
            if (Math.Abs(x) >= 1)
                throw new Exception("Значение 'x' не принадлежит области определения!");
            if (N < 0)
                throw new Exception("Значение 'N' не принадлежит области определения!");
#endif
            double S = 1;
            double F = 0;
            for (int i = 2; i < N; i++)
            {
                F = (1.0 / 6.0) * (i * (i + 1) * (i + 2) * Math.Pow(x, i - 1));
                S += F;
            }
            return S;            
        }
    };

    /// <summary>
    /// Возвращает область определения для степенной функции (1-x)^(-4)
    /// </summary>
    [OpaqueFunction()]
    [FunctionName("Math_14_2", "(1-x)^(-4)")]
    public static class CMath_14_2_in
    {
        public static string Math_14_2_in()
        {
            string s = "(-1, 1)";
            return s;

        }
    };

    /// <summary>
    /// Реализует степенную функцию (1 + x)^-1/2,  
    /// где X задается параметром <paramref name="x"/>. 
    /// Результатом функции является целое число S - результат суммы элементов разложения ряда,
    /// Количество членов ряда задано параметром <paramref name="N"/>.
    /// Точность до десятого знака (1e-10) на сегменте (-0.81, 0.83) при N = 100;
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_15_2", "(1+x)^-1/2")]
    public static class CMath_15_2
    {
        public static double Math_15_2(double x, int N)
        {
#if _Debug
            if (Math.Abs(x) >= 1)
                throw new Exception("Значение 'x' не принадлежит области определения!");
            if (N < 0)
                throw new Exception("Значение 'N' не принадлежит области определения!");
#endif
            double S = 1;
            if (N > 0)
            {
                S = 1;
                double F = 1;
                for (int i = 1; i <= N; i++)
                {
                    F *= (((2 * i - 1) * Math.Pow(2 * i, -1))) * x;
                    F = -F;
                    S += F;
                }
            }
            else
            {
                if (N == 0)
                {
                    S = 1;
                }
            }
            return S;

        }
    };

    /// <summary>
    /// Возвращает область определения для степенной функции (1+x)^-1/2
    /// </summary>
    [OpaqueFunction()]
    [FunctionName("Math_15_2", "(1+x)^-1/2")]
    public static class CMath_15_2_in
    {
        public static string Math_15_2_in()
        {
            string s = "(-1, 1)";
            return s;

        }
    };

    /// <summary>
    /// Реализует степенную функцию (1 - x)^-1/2,  
    /// где X задается параметром <paramref name="x"/>. 
    /// Результатом функции является целое число S - результат суммы элементов разложения ряда,
    /// Количество членов ряда задано параметром <paramref name="N"/>.
    /// Точность до десятого знака (1e-10) на сегменте (-0.83, 0.81) при N = 100;
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_16_2", "(1-x)^-1/2")]
    public static class CMath_16_2
    {
        public static double Math_16_2(double x, int N)
        {
#if _Debug
            if (Math.Abs(x) >= 1)
                throw new Exception("Значение 'x' не принадлежит области определения!");
            if (N < 0)
                throw new Exception("Значение 'N' не принадлежит области определения!");
#endif
            double S = 1;
            if (N > 0)
            {
                S = 1;
                double F = 1;
                for (int i = 1; i <= N; i++)
                {
                    F *= ((2.0 * i - 1) * Math.Pow(2.0 * i, -1)) * x;
                    S += F;
                }
            }
            else
            {
                if (N == 0)
                {
                    S = 1;
                }
               
            }
            return S;

        }
    };

    /// <summary>
    /// Возвращает область определения для степенной функции (1-x)^-1/2
    /// </summary>
    [OpaqueFunction()]
    [FunctionName("Math_16_2", "(1-x)^-1/2")]
    public static class CMath_16_2_in
    {
        public static string Math_16_2_in()
        {
            string s = "(-1, 1)";
            return s;

        }
    };

    /// <summary>
    /// Реализует степенную функцию (1 + x)^-1/3,  
    /// где X задается параметром <paramref name="x"/>. 
    /// Результатом функции является целое число S - результат суммы элементов разложения ряда,
    /// Количество членов ряда задано параметром <paramref name="N"/>.
    /// Точность до десятого знака (1e-10) на сегменте (-0.82, 0.84) при N = 100;
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_17_2", "(1+x)^-1/3")]
    public static class CMath_17_2
    {
        public static double Math_17_2(double x, int N)
        {
#if _Debug
            if (Math.Abs(x) >= 1)
                throw new Exception("Значение 'x' не принадлежит области определения!");
            if (N < 0)
                throw new Exception("Значение 'N' не принадлежит области определения!");
#endif
            double S = 1;
            if (N > 0)
            {
                double F = 1;
                for (int i = 1; i <= N; i++)
                {
                    F *= ((3.0 * i - 2.0) * Math.Pow(3.0 * i, -1)) * x;
                    F = -F;
                    S += F;
                }
            }
            else
            {
                if (N == 0)
                {
                    S = 1;
                }                
            }
            return S;

        }
    };

    /// <summary>
    /// Возвращает область определения для степенной функции (1+x)^-1/3
    /// </summary>
    [OpaqueFunction()]
    [FunctionName("Math_17_2", "(1+x)^-1/3")]
    public static class CMath_17_2_in
    {
        public static string Math_17_2_in()
        {
            string s = "(-1, 1)";
            return s;

        }
    };

    /// <summary>
    /// Реализует степенную функцию (1 - x)^-1/3,  
    /// где X задается параметром <paramref name="x"/>. 
    /// Результатом функции является целое число S - результат суммы элементов разложения ряда,
    /// Количество членов ряда задано параметром <paramref name="N"/>.
    /// Точность до десятого знака (1e-10) на сегменте (-0.84, 0.82) при N = 100;
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_18_2", "(1-x)^-1/3")]
    public static class CMath_18_2
    {
        public static double Math_18_2(double x, int N)
        {
#if _Debug
            if (Math.Abs(x) >= 1)
                throw new Exception("Значение 'x' не принадлежит области определения!");
            if (N < 0)
                throw new Exception("Значение 'N' не принадлежит области определения!");
#endif
            double S = 1;
            if (N > 0)
            {
                double F = 1;
                for (int i = 1; i <= N; i++)
                {
                    F *= ((3 * i - 2) * Math.Pow(3 * i, -1)) * x;
                    S += F;
                }
            }
            else
            {
                if (N == 0)
                {
                    S = 1;
                }
            }
            return S;

        }
    };

    /// <summary>
    /// Возвращает область определения для степенной функции (1-x)^-1/3
    /// </summary>
    [OpaqueFunction()]
    [FunctionName("Math_18_2", "(1-x)^-1/3")]
    public static class CMath_18_2_in
    {
        public static string Math_18_2_in()
        {
            string s = "(-1, 1)";
            return s;

        }
    };

    /// <summary>
    /// Реализует степенную функцию (1 + x)^-1/4,  
    /// где X задается параметром <paramref name="x"/>. 
    /// Результатом функции является целое число S - результат суммы элементов разложения ряда,
    /// Количество членов ряда задано параметром <paramref name="N"/>.
    /// Точность до десятого знака (1e-10) на сегменте (-0.83, 0.84) при N = 100;
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_19_2", "(1+x)^-1/4")]
    public static class CMath_19_2
    {
        public static double Math_19_2(double x, int N)
        {
#if _Debug
            if (Math.Abs(x) >= 1)
                throw new Exception("Значение 'x' не принадлежит области определения!");
            if (N < 0)
                throw new Exception("Значение 'N' не принадлежит области определения!");
#endif
            double S = 1;
            if (N > 0)
            {
                double F = 1;
                for (int i = 1; i <= N; i++)
                {
                    F *= ((4 * i - (double)3) * Math.Pow(4 * i, -1)) * x;
                    F = -F;
                    S += F;
                }
            }
            else
            {
                if (N == 0)
                {
                    S = 1;
                }
            }
            return S;

        }
    };

    /// <summary>
    /// Возвращает область определения для степенной функции (1+x)^-1/4
    /// </summary>
    [OpaqueFunction()]
    [FunctionName("Math_19_2", "(1+x)^-1/4")]
    public static class CMath_19_2_in
    {
        public static string Math_19_2_in()
        {
            string s = "(-1, 1)";
            return s;

        }
    };

    /// <summary>
    /// Реализует степенную функцию (1 - x)^-1/4,  
    /// где X задается параметром <paramref name="x"/>. 
    /// Результатом функции является целое число S - результат суммы элементов разложения ряда,
    /// Количество членов ряда задано параметром <paramref name="N"/>.
    /// Точность до десятого знака (1e-10) на сегменте (-0.84, 0.83) при N = 100;
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_20_2", "(1-x)^-1/4")]
    public static class CMath_20_2
    {
        public static double Math_20_2(double x, int N)
        {
#if _Debug
            if (Math.Abs(x) >= 1)
                throw new Exception("Значение 'x' не принадлежит области определения!");
            if (N < 0)
                throw new Exception("Значение 'N' не принадлежит области определения!");
#endif
            double S = 1;
            if (N > 0)
            {
                double F = 1;
                for (int i = 1; i <= N; i++)
                {
                    //F *= ((4 * i - 3) / 4 * i) * x;
                    F *= ((4 * i - 3) * Math.Pow(4 * i, -1)) * x;
                    //F *= 1 - (3.0 / 4.0) * Math.Pow(i, -1) * x;
                    S += F;
                }
            }
            else
            {
                if (N == 0)
                {
                    S = 1;
                }
            }
            return S;

        }
    };

    /// <summary>
    /// Возвращает область определения для степенной функции (1-x)^-1/4
    /// </summary>
    [OpaqueFunction()]
    [FunctionName("Math_20_2", "(1-x)^-1/4")]
    public static class CMath_20_2_in
    {
        public static string Math_20_2_in()
        {
            string s = "(-1, 1)";
            return s;

        }
    };


}
