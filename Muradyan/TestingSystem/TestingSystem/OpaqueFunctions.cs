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
    [FunctionName("Opaque1", "Math.Sin(x) * Math.Sin(x) + Math.Cos(x) * Math.Cos(x)")]
    [EquivalentIntConstant(1)]
    public static class Opaque1SinCos
    {
        public static double Body(double angle, int count)
        {
            double X = 1;
            for (int i = 0; i < count; i++)
            {
                /// add h
                X *= Math.Sin(angle) * Math.Sin(angle) + Math.Cos(angle) * Math.Cos(angle);
            }
            return X;
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
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("Opaque2", "sin")]
    // [EquivalentIntConstant(1)]
    public static class CSin_1
    {
        public static double Sin_1(double angle, int count)
        {
            double X = 0, X1 = angle, fact = 1, sign = -1, result = 0, a;
            for (int i = 0; i < count; i++)
            {
                sign *= sign;
                for (int k = i; k <= 2 * k + 1; k++)
                    X1 *= X1;
                fact *= (2 * i + 1);
                a = sign * X1 / fact;
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
            /// add gh
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
            double X = 0, X1 = angle, fact = 1, sign = -1, result = 0, a;
            for (int i = 0; i < count; i++)
            {
                sign *= sign;
                for (int k = i; k <= 2 * k; k++)
                    X1 *= X1;
                fact *= (2 * i);
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
    // [EquivalentIntConstant(1)]
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
            return Math.PI / 2 - result;
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









}

