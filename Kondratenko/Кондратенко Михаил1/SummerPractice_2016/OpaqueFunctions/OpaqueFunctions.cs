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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="angle"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static double Body(double angle, int count)
        {
            double X = 1;
            for (int i = 0; i < count; i++)
            {
                X *= Math.Sin(angle)*Math.Sin(angle) + Math.Cos(angle)*Math.Cos(angle);
            }
            return X;
        }
    }

    /// <summary>
    /// Реализует сложную функцию  f(x) = sin(arcsin(x)), -1≤x≤1,  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>

    [OpaqueFunction()]
    [FunctionName("Opaque2", "f(x) = sin(arcsin(x))")]
    [EquivalentIntConstant(1)]
    public static class Opaque2SinArcSin
    {

        public static double Body(double angle)
        {
            double X = 1;
            double Y1;
              Y1 = Math.Asin(angle);
              X = Math.Sin(Y1);
            return X;
        }
    }


    /// <summary>
    /// Возращает область определения для сложной функции f(x) = sin(arcsin(x))
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque2", "f(x) = sin(arcsin(x))")]
    public static class CBody_in
    {
        public static string Body_in()
        {
            string s = "(-1, 1)";
            return s;
        }
    }


    /// <summary>
    /// Реализует сложную функцию  f(x) = cos(arccos(x)), -1≤x≤1,  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>

    [OpaqueFunction()]
    [FunctionName("Opaque3", "f(x) = cos(arccos(x))")]
    [EquivalentIntConstant(1)]
    public static class Opaque3CosArcCos
    {
        public static double Body(double angle)
        {
            double X = 1;
            double Y1;
              Y1 = Math.Acos(angle);
              X = Math.Cos(Y1);
            return X;
        }
    }



    /// <summary>
    /// Возращает область определения для сложной функции f(x) = cos(arccos(x))
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque3", "f(x) = cos(arccos(x))")]
    public static class CBody_in
    {
        public static string Body_in()
        {
            string s = "(-1, 1)";
            return s;
        }
    }


    /// <summary>
    /// Реализует сложную функцию  f(x) = tg(arctg(x)), -π/2≤ x ≤ π/2,  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>

    [OpaqueFunction()]
    [FunctionName("Opaque4", "f(x) = tg(arctg(x))")]
    [EquivalentIntConstant(1)]
    public static class Opaque4TgArcTg
    {
        public static double Body(double angle)
        {
            double X = 1;
            double Y1;
              Y1 = Math.Atan(angle);
              X = Math.Tan(Y1);
            return X;
        }
    }



    /// <summary>
    /// Возращает область определения для сложной функции f(x) = tg(arctg(x))
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque4", "f(x) = tg(arctg(x))")]
    public static class CBody_in
    {
        public static string Body_in()
        {
            string s = "(-Pi/2, Pi/2)";
            return s;
        }
    }



    /// <summary>
    /// Реализует сложную функцию   f(x) = ctg(arcctg(x)), -π/2≤ x ≤ π/2,
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>

    [OpaqueFunction()]
    [FunctionName("Opaque5", "f(x) = ctg(arcctg(x))")]
    [EquivalentIntConstant(1)]
    public static class Opaque5AtgArcAtg
    {
        public static double Body(double angle) 
        {
            double X = 1;
            double Y1, Y2, Y3;
              Y1 = Math.Atan(angle);
              Y2 = Math.PI / 2;
              Y3 = Y2 - Y1;
              X = 1.0 / Math.Tan(Y3);
            return X;
        }
    }



    /// <summary>
    /// Возращает область определения для сложной функции f(x) = ctg(arcctg(x))
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque5", "f(x) = ctg(arcctg(x))")]
    public static class CBody_in
    {
        public static string Body_in()
        {
            string s = "(-Pi/2, Pi/2)";
            return s;
        }
    }



    /// <summary>
    /// Реализует сложную функцию    f(x) = arcsin(sin(x)), -π/2≤ x ≤ π/2,  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>

    [OpaqueFunction()]
    [FunctionName("Opaque6", "f(x) = arcsin(sin(x))")]
    [EquivalentIntConstant(1)]
    public static class Opaque6ArcSinSin
    {
        public static double Body(double angle)
        {
            double X = 1;
            double Y1;
              Y1 = Math.Sin(angle);
              X = Math.Asin(Y1);
            return X;
        }
    }



    /// <summary>
    /// Возращает область определения для сложной функции f(x) = arcsin(sin(x))
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque6", "f(x) = arcsin(sin(x))")]
    public static class CBody_in
    {
        public static string Body_in()
        {
            string s = "(-Pi/2, Pi/2)";
            return s;
        }
    }



    /// <summary>
    /// Реализует сложную функцию    f(x) = arccos(cos(x)), 0 ≤ x ≤ π,  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>

    [OpaqueFunction()]
    [FunctionName("Opaque7", "f(x) = arccos(cos(x))")]
    [EquivalentIntConstant(1)]
    public static class Opaque7ArcCosCos
    {
        public static double Body(double angle)
        {
            double X = 1;
            double Y1;
              Y1 = Math.Cos(angle);
              X = Math.Acos(Y1);
            return X;
        }
    }



    /// <summary>
    /// Возращает область определения для сложной функции f(x) = arccos(cos(x))
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque7", "f(x) = arccos(cos(x))")]
    public static class CBody_in
    {
        public static string Body_in()
        {
            string s = "(0, Pi)";
            return s;
        }
    }



    /// <summary>
    /// Реализует сложную функцию    f(x) = arctg(tg(x)), -π/2 ≤ x ≤ π/2,  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>

    [OpaqueFunction()]
    [FunctionName("Opaque8", "f(x) = arctg(tg(x))")]
    [EquivalentIntConstant(1)]
    public static class Opaque8ArcTgTg
    {
        public static double Body(double angle)
        {
            double X = 1;
            double Y1;
              Y1 = Math.Tan(angle);
              X = Math.Atan(Y1);
            return X;
        }
    }



    /// <summary>
    /// Возращает область определения для сложной функции f(x) = arctg(tg(x))
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque8", "f(x) = arctg(tg(x))")]
    public static class CBody_in
    {
        public static string Body_in()
        {
            string s = "(-Pi/2, Pi/2)";
            return s;
        }
    }



    /// <summary>
    /// Реализует сложную функцию    f(x) = arcctg(ctg(x)), -1 ≤ x ≤ 1,  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>

    [OpaqueFunction()]
    [FunctionName("Opaque9", "f(x) = arcctg(ctg(x))")]
    [EquivalentIntConstant(1)]
    public static class Opaque9ArcCtgCtg
    {
        public static double Body(double angle)
        {
            double X = 1;
            double Y1;
              Y1 = 1.0 / Math.Tan(angle);
              X = Math.PI / 2 - Math.Atan(Y1);
            return X;
        }
    }



    /// <summary>
    /// Возращает область определения для сложной функции f(x) = arcctg(ctg(x))
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque9", "f(x) = arcctg(ctg(x))")]
    public static class CBody_in
    {
        public static string Body_in()
        {
            string s = "(-1, 1)";
            return s;
        }
    }



    /// <summary>
    /// Реализует сложную функцию    f(x) = (x^n)^(1/n), x > 0 нат. число,  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>

    [OpaqueFunction()]
    [FunctionName("Opaque10", "f(x) = (x^n)^(1/n)")]
    [EquivalentIntConstant(1)]
    public static class CBody
    {
        public static double Body(double angle, int n = 10)
        {
            double X = 1;
            double Y1, Y2;
              Y1 = 1/n;
              Y2 = Math.Pow(angle, n);
              X = Math.Pow(Y2, Y1);
            return X;
        }
    }



    /// <summary>
    /// Возращает область определения для сложной функции f(x) = (x^n)^(1/n)
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque10", "f(x) = (x^n)^(1/n)")]
    public static class CBody_in
    {
        public static string Body_in()
        {
            string s = "(0, w)";
            return s;
        }
    }



    /// <summary>
    /// Реализует сложную функцию    f(x) = (x^(1/n))^n, x > 0 нат. число,  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>

    [OpaqueFunction()]
    [FunctionName("Opaque11", "f(x) = (x^(1/n))^n")]
    [EquivalentIntConstant(1)]
    public static class Opaque11Power
    {
        public static double Body(double angle, int n = 10)
        {
            double X = 1;
            double Y1, Y2;
              Y1 = 1/n;
              Y2 = Math.Pow(angle, Y1);
              X = Math.Pow(Y2, n);
            return X;
        }
    }



    /// <summary>
    /// Возращает область определения для сложной функции f(x) = (x^(1/n))^n
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque11", "f(x) = (x^(1/n))^n")]
    public static class CBody_in
    {
        public static string Body_in()
        {
            string s = "(0, w)";
            return s;
        }
    }



    /// <summary>
    /// Реализует сложную функцию    f(x) = loga(a^x), a > 0, a ≠ 1,  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>

    [OpaqueFunction()]
    [FunctionName("Opaque12", "f(x) = loga(a^x)")]
    [EquivalentIntConstant(1)]
    public static class Opaque12Log
    {
        public static double Body(double angle, int a = 10)
        {
            double X = 1;
            double Y1;
              Y1 = Math.Pow(a, angle);
              X = Math.Log(a) / Math.Log(Y1); 
            return X;
        }
    }



    /// <summary>
    /// Возращает область определения для сложной функции f(x) = loga(a^x)
    /// a лежит в области a > 0, a ≠ 1.
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque12", "f(x) = loga(a^x)")]
    public static class CBody_in
    {
        public static string Body_in()
        {
            string s = "(-w, w)";///
            return s;
        }
    }



    /// <summary>
    /// Реализует сложную функцию    f(x) = a^(logax), a>0, a ≠ 1,  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>

    [OpaqueFunction()]
    [FunctionName("Opaque13", "f(x) = a^(logax)")]
    [EquivalentIntConstant(1)]
    public static class Opaque13Log
    {
        public static double Body(double angle, int a = 10)
        {
            double X = 1;
            double Y1;
              Y1 = Math.Log(a) / Math.Log(angle);
              X = Math.Pow(a, Y1);
            return X;
        }
    }






    /// <summary>
    /// Реализует сложную функцию    f(x) = ln(e^x),  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>

    [OpaqueFunction()]
    [FunctionName("Opaque14", "f(x) = ln(e^x)")]
    [EquivalentIntConstant(1)]
    public static class Opaque14Ln
    {
        public static double Body(double angle)
        {
            double X = 1;
            double Y1;
              Y1 = Math.Exp(angle);
              X = Math.Log(Y1); 
            return X;
        }
    }






    /// <summary>
    /// Реализует сложную функцию    f(x) = e^(lnx),  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>

    [OpaqueFunction()]
    [FunctionName("Opaque15", "f(x) = e^(lnx)")]
    [EquivalentIntConstant(1)]
    public static class Opaque15Ln
    {
        public static double Body(double angle)
        {
            double X = 1;
            double Y1;
              Y1 = Math.Log(angle);
              X = Math.Exp(Y1);
            return X;
        }
    }







    /// <summary>
    /// Реализует сложную функцию    f(x) = sh(arsh(x)), 
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>

    [OpaqueFunction()]
    [FunctionName("Opaque16", "f(x) = sh(arsh(x))")]
    [EquivalentIntConstant(1)]
    public static class Opaque16ShArsh
    {
        public static double Body(double angle)
        {
            double X = 1;
            double Y1, Y2;
              Y1 = angle + Math.Sqrt(angle * angle + 1);
              Y2 = Math.Log(Y1);
              X = Math.Sinh(Y2);
            return X;
        }
    }






    /// <summary>
    /// Реализует сложную функцию   f(x) = arsh(sh(x)),
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>

    [OpaqueFunction()]
    [FunctionName("Opaque17", "f(x) = arsh(sh(x))")]
    [EquivalentIntConstant(1)]
    public static class Opaque17Arsh
    {
        public static double Body(double angle)
        {
            double X = 1;
            double Y1, Y2;
              Y1 = Math.Sinh(angle);
              Y2 = Y1 + Math.Sqrt(Y1 * Y1 + 1);
              X = Math.Log(Y2);
            return X;
        }
    }







    /// <summary>
    /// Реализует сложную функцию    f(x) = ch(arch(x)), x > 1,
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>

    [OpaqueFunction()]
    [FunctionName("Opaque18", "f(x) = ch(arch(x))")]
    [EquivalentIntConstant(1)]
    public static class Opaque18ShArsh
    {
        public static double Body(double angle)
        {
            double X = 1;
            double Y1, Y2;
              Y1 = angle + Math.Sqrt(angle * angle - 1);
              Y2 = Math.Log(Y1);
              X = Math.Cosh(Y2);
            return X;
        }
    }





    /// <summary>
    /// Реализует сложную функцию   f(x) = arch(ch(x)), x > 0,
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>

    [OpaqueFunction()]
    [FunctionName("Opaque19", "f(x) = arch(ch(x))")]
    [EquivalentIntConstant(1)]
    public static class Opaque19Arsh
    {
        public static double Body(double angle)
        {
            double X = 1;
            double Y1, Y2;
              Y1 = Math.Cosh(angle);
              Y2 = Y1 + Math.Sqrt(Y1 * Y1 - 1);
              X = Math.Log(Y2);
            return X;
        }
    }










    /// <summary>
    /// Реализует сложную функцию    f(x) = th(arth(x)), -1 < x < 1, 
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>

    [OpaqueFunction()]
    [FunctionName("Opaque20", "f(x) = th(arth(x))")]
    [EquivalentIntConstant(1)]
    public static class Opaque20ShArsh
    {
        public static double Body(double angle)
        {
            double X = 1;
            double Y1, Y2;
              Y1 = (1 + angle) / (1 - angle);
              Y2 = 0.5 * Math.Log(Y1);
              X = Math.Tanh(Y2);
            return X;
        }
    }









    /// <summary>
    /// Реализует сложную функцию   f(x) = arth(th(x)), 
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>

    [OpaqueFunction()]
    [FunctionName("Opaque21", "f(x) = arth(th(x))")]
    [EquivalentIntConstant(1)]
    public static class Opaque21Arsh
    {
        public static double Body(double angle)
        {
            double X = 1;
            double Y1, Y2;
              Y1 = Math.Tanh(angle);
              Y2 = (1 + Y1) / (1 - Y1);
              X = 0.5 * Math.Log(Y2);         
            return X;
        }
    }








    /// <summary>
    /// Реализует сложную функцию    f(x) = сth(arсth(x)), x < -1, x > 1,  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>

    [OpaqueFunction()]
    [FunctionName("Opaque22", "f(x) = cth(arcth(x))")]
    [EquivalentIntConstant(1)]
    public static class Opaque22ShArsh
    {
        public static double Body(double angle)
        {
            double X = 1;
            double Y1, Y2;
              Y1 = (angle + 1) / (angle - 1);
              Y2 = 0.5 * Math.Log(Y1);
              X = 1 / Math.Tanh(Y2); 
            return X;
        }
    }









    /// <summary>
    /// Реализует сложную функцию   f(x) = arcth(cth(x)), 
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>

    [OpaqueFunction()]
    [FunctionName("Opaque23", "f(x) = arcth(cth(x))")]
    [EquivalentIntConstant(1)]
    public static class Opaque23Arsh
    {
        public static double Body(double angle)
        {
            double X = 1;
            double Y1, Y2;
              Y1 = 1 / Math.Tanh(angle);
              Y2 = (Y1 + 1) / (Y1 - 1);
              X = 0.5 * Math.Log(Y2);
            
            return X;
        }
    }











}

