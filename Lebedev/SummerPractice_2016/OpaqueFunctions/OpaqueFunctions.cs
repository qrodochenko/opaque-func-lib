using System;

namespace OpaqueFunctions
{
    /// <summary>
    /// Реализует основное тригонометрическое тождество sin^2 (x) + cos^2 (x) = 1,  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("Opaque1", "sin^2 + cos^2 = 1")]
    [EquivalentIntConstant(1)]
    public static class Opaque1SinCos
    {
        public static double Body(double angle, int count)
        {
            double X = 1;
            for (int i = 0; i < count; i++)
            {
                X *= Math.Sin(angle)*Math.Sin(angle) + Math.Cos(angle)*Math.Cos(angle);
            }
            return X;
        }
    };



    /// <summary>
    /// Реализует степенную функцию (1 + x)^1/3,  
    /// где X задается параметром <paramref name="x"/>. 
    /// Результатом функции является целое число S - результат суммы элементов разложения ряда,
    /// сколько задано параметром <paramref name="N"/>.
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_1_2", "(1+x)^1/3")]
    public static class CMath_1_2
    {
        public static double Math_1_2(double x, int N)
        {
            double S = 0;
            if (N > 1)
            {
                S = 1 + (1 / 3) * x;
                double F = (1 / 3) * x;
                for (int i = 2; i <= N; i++)
                {
                    F *= (Math.Pow(-1, i + 1)) * ((3 * i - 4) / 3 * i) * x;
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
                    S = 1 + (1 / 3) * x;
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
    /// сколько задано параметром <paramref name="N"/>.
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_1_2", "(1-x)^1/3")]
    public static class CMath_2_2
    {
        public static double Math_2_2(double x, int N)
        {
            double S = 0;
            if (N > 1)
            {
                S = 1 + (1 / 3) * x;
                double F = -(1 / 3) * x;
                for (int i = 2; i <= N; i++)
                {
                    F *= ((3 * i - 4) / 3 * i) * x;
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
                    S = 1 - (1 / 3) * x;
                }
            }
            return S;

        }
    };


    /// <summary>
    /// Возвращает область определения для степенной функции (1 - x)^1/3
    /// </summary>
    [OpaqueFunction()]
    [FunctionName("Math_1_2", "(1-x)^1/3")]
    public static class CMath_2_2_in
    {
        public static string Math_2_2_in()
        {
            string s = "(-1, 1)";
            return s;

        }
    };

    //---------------------------------------------------------

    /// <summary>
    /// Реализует степенную функцию (1 + x)^1/2,  
    /// где X задается параметром <paramref name="x"/>. 
    /// Результатом функции является целое число S - результат суммы элементов разложения ряда,
    /// сколько задано параметром <paramref name="N"/>.
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_3_2", "(1+x)^1/2")]
    public static class CMath_3_2
    {
        public static double Math_3_2(double x, int N)
        {
            double S = 1;
            if (N > 1)
            {
                S = 1 + (1 / 2) * x;
                double F = (1 / 2) * x;
                for (int i = 2; i <= N; i++)
                {
                    F *= (Math.Pow(-1, i + 1)) * ((2 * i - 3) / 2 * i) * x;
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
    /// сколько задано параметром <paramref name="N"/>.
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_4_2", "(1-x)^1/2")]
    public static class CMath_4_2
    {
        public static double Math_4_2(double x, int N)
        {
            double S = 1;
            if (N > 1)
            {
                S = 1 + (1 / 2) * x;
                double F = -(1 / 2) * x;
                for (int i = 2; i <= N; i++)
                {
                    F *= ((2 * i - 3) / 2 * i) * x;
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
                    S = 1 - (1 / 2) * x;
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

    //---------------------------------------------------------

    /// <summary>
    /// Реализует степенную функцию (1 + x)^1/4,  
    /// где X задается параметром <paramref name="x"/>. 
    /// Результатом функции является целое число S - результат суммы элементов разложения ряда,
    /// сколько задано параметром <paramref name="N"/>.
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_5_2", "(1+x)^1/4")]
    public static class CMath_5_2
    {
        public static double Math_5_2(double x, int N)
        {
            double S = 1;
            if (N > 1)
            {
                S = 1 + (1.0 / 4.0) * x;
                double F = (1.0 / 4.0) * x;
                for (int i = 2; i <= N; i++)
                {
                    F *= (Math.Pow(-1, i + 1)) * ((4 * i - 5) / 4 * i) * x;
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
    /// сколько задано параметром <paramref name="N"/>.
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_6_2", "(1-x)^1/4")]
    public static class CMath_6_2
    {
        public static double Math_6_2(double x, int N)
        {
            double S = 1;
            if (N > 1)
            {
                S = 1 - (1.0 / 4.0) * x;
                double F = (1.0 / 4.0) * x;
                double F1 = 0;
                for (int i = N; i > 0; i--)
                {
                    F *= ((4 * i - 5) / (4 * i)) * x;
                    F1 = -F;
                    S += F1;
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

    //---------------------------------------------------------

    /// <summary>
    /// Реализует степенную функцию (1 + x)^(-1),  
    /// где X задается параметром <paramref name="x"/>. 
    /// Результатом функции является целое число S - результат суммы элементов разложения ряда,
    /// сколько задано параметром <paramref name="N"/>.
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_7_2", "(1+x)^(-1)")]
    public static class CMath_7_2
    {
        public static double Math_7_2(double x, int N)
        {
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
    /// сколько задано параметром <paramref name="N"/>.
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_8_2", "(1-x)^(-1)")]
    public static class CMath_8_2
    {
        public static double Math_8_2(double x, int N)
        {
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
    /// сколько задано параметром <paramref name="N"/>.
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_9_2", "(1+x)^(-2)")]
    public static class CMath_9_2
    {
        public static double Math_9_2(double x, int N)
        {
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
    /// сколько задано параметром <paramref name="N"/>.
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_10_2", "(1-x)^(-2)")]
    public static class CMath_10_2
    {
        public static double Math_10_2(double x, int N)
        {
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
    /// сколько задано параметром <paramref name="N"/>.
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_11_2", "(1+x)^(-3)")]
    public static class CMath_11_2
    {
        public static double Math_11_2(double x, int N)
        {
            double S = 1;
            double F = 0;
            for (int i = 2; i < N+2; i++)
            {
                F = (-1.0/2.0)*(Math.Pow(-1, i) * i * (i + 1) * Math.Pow(x, i - 1));
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
    /// сколько задано параметром <paramref name="N"/>.
    /// </summary>
    /// <param name="x">Параметр X</param>
    /// <param name="N">Количество требуемых слогаемых (точность)</param>
    [OpaqueFunction()]
    [FunctionName("Math_12_2", "(1-x)^(-3)")]
    public static class CMath_12_2
    {
        public static double Math_12_2(double x, int N)
        {
            double S = 1;
            double F = 0;
            for (int i = 2; i < N + 2; i++)
            {
                F = (1.0 / 2.0) * (i * (i + 1) * Math.Pow(x, i - 1));
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


}
