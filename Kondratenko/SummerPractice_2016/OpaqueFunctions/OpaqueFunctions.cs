#define Debug 
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
    [FunctionName("Opaque0", "sin^2 + cos^2 = 1")]
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
    [FunctionName("Opaque1", "f(x) = sin(arcsin(x))")]
    [EquivalentIntConstant(1)]
    public static class CLOX_1_1_sin_arcsin
    {

        public static double LOX_1_1_sin_arcsin(double angle)
        {
            #if Debug
            if ((angle > 1) || (angle < -1))
            {
                throw new Exception("Значение 'x' не принадлежит области определения!");
            }
            #endif
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
    [FunctionName("Opaque1", "f(x) = sin(arcsin(x))")]
    public static class CLOX_1_1_sin_arcsin_in
    {
        public static string LOX_1_1_sin_arcsin_in()
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
    [FunctionName("Opaque2", "f(x) = cos(arccos(x))")]
    [EquivalentIntConstant(1)]
    public static class CLOX_2_1_cos_arccos
    {
        public static double LOX_2_1_cos_arccos(double angle)
        {
            #if Debug
                if ((angle > 1) || (angle < -1))
                {
                     throw new Exception("Значение 'x' не принадлежит области определения!");
                }
            #endif
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
    [FunctionName("Opaque2", "f(x) = cos(arccos(x))")]
    public static class CLOX_2_1_cos_arccos_in
    {
        public static string LOX_2_1_cos_arccos_in()
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
    [FunctionName("Opaque3", "f(x) = tg(arctg(x))")]
    [EquivalentIntConstant(1)]
    public static class CLOX_3_1_tg_arctg
    {
        public static double LOX_3_1_tg_arctg(double angle)
        {
            #if Debug
                if ((angle > Math.PI / 2) || (angle < -Math.PI / 2))
                {
                    throw new Exception("Значение 'x' не принадлежит области определения!");
                }
            #endif
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
    [FunctionName("Opaque3", "f(x) = tg(arctg(x))")]
    public static class CLOX_3_1_tg_arctg_in
    {
        public static string LOX_3_1_tg_arctg_in()
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
    [FunctionName("Opaque4", "f(x) = ctg(arcctg(x))")]
    [EquivalentIntConstant(1)]
    public static class CLOX_4_1_ctg_arcctg
    {
        public static double LOX_4_1_ctg_arcctg(double angle) 
        {
            #if Debug
                if ((angle > Math.PI / 2) || (angle < -Math.PI / 2))
                {
                    throw new Exception("Значение 'x' не принадлежит области определения!");
                }
            #endif
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
    [FunctionName("Opaque4", "f(x) = ctg(arcctg(x))")]
    public static class CLOX_4_1_ctg_arcctg_in
    {
        public static string LOX_4_1_ctg_arcctg_in()
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
    [FunctionName("Opaque5", "f(x) = arcsin(sin(x))")]
    [EquivalentIntConstant(1)]
    public static class CLOX_5_1_arcsin_sin
    {
        public static double LOX_5_1_arcsin_sin(double angle)
        {
            #if Debug
                if ((angle > Math.PI / 2) || (angle < -Math.PI / 2))
                {
                    throw new Exception("Значение 'x' не принадлежит области определения!");
                }
            #endif
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
    [FunctionName("Opaque5", "f(x) = arcsin(sin(x))")]
    public static class CLOX_5_1_arcsin_sin_in
    {
        public static string LOX_5_1_arcsin_sin_in()
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
    [FunctionName("Opaque6", "f(x) = arccos(cos(x))")]
    [EquivalentIntConstant(1)]
    public static class CLOX_6_1_arccos_cos
    {
        public static double LOX_6_1_arccos_cos(double angle)
        {
            #if Debug
                if ((angle > Math.PI) || (angle < 0))
                {
                    throw new Exception("Значение 'x' не принадлежит области определения!");
                }
            #endif
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
    [FunctionName("Opaque6", "f(x) = arccos(cos(x))")]
    public static class CLOX_6_1_arccos_cos_in
    {
        public static string LOX_6_1_arccos_cos_in()
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
    [FunctionName("Opaque7", "f(x) = arctg(tg(x))")]
    [EquivalentIntConstant(1)]
    public static class CLOX_7_1_arctg_tg
    {
        public static double LOX_7_1_arctg_tg(double angle)
        {
            #if Debug
                if ((angle > Math.PI / 2) || (angle < -Math.PI / 2))
                {
                    throw new Exception("Значение 'x' не принадлежит области определения!");
                }
            #endif
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
    [FunctionName("Opaque7", "f(x) = arctg(tg(x))")]
    public static class CLOX_7_1_arctg_tg_in
    {
        public static string LOX_7_1_arctg_tg_in()
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
    [FunctionName("Opaque8", "f(x) = arcctg(ctg(x))")]
    [EquivalentIntConstant(1)]
    public static class CLOX_8_1_arcctg_ctg
    {
        public static double LOX_8_1_arcctg_ctg(double angle)
        {
            #if Debug
                if ((angle < 0) || (angle > Math.PI))
                {
                    throw new Exception("Значение 'x' не принадлежит области определения!");
                }
            #endif
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
    [FunctionName("Opaque8", "f(x) = arcctg(ctg(x))")]
    public static class CLOX_8_1_arcctg_ctg_in
    {
        public static string LOX_8_1_arcctg_ctg_in()
        {
            string s = "(0, Pi)";
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
    [FunctionName("Opaque9", "f(x) = (x^n)^(1/n)")]
    [EquivalentIntConstant(1)]
    public static class CLOX_9_2_xpowy_xpown_1divn
    {
        public static double LOX_9_2_xpowy_xpown_1divn(double x, int n = 10)
        {
            #if Debug
                if  (x < 0)
                {
                    throw new Exception("Значение 'x' не принадлежит области определения!");
                }
            #endif
            double F = 1;
            double Y1, Y2;
              Y1 = Math.Pow(n, -1.0);
              Y2 = Math.Pow(x, n);
              F = Math.Pow(Y2, Y1);

            return F;
        }
    }



    /// <summary>
    /// Возращает область определения для сложной функции f(x) = (x^n)^(1/n)
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque9", "f(x) = (x^n)^(1/n)")]
    public static class CLOX_9_2_xpowy_xpown_1divn_in
    {
        public static string LOX_9_2_xpowy_xpown_1divn_in()
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
    [FunctionName("Opaque10", "f(x) = (x^(1/n))^n")]
    [EquivalentIntConstant(1)]
    public static class CLOX_10_2_xpown_xpown_1divn
    {
        public static double LOX_10_2_xpown_xpown_1divn(double angle, int n = 10)
        {
            #if Debug
                if (angle < 0)
                {
                    throw new Exception("Значение 'x' не принадлежит области определения!");
                }
            #endif
            double X = 1;
            double Y1, Y2;
              Y1 = 1.0/n;
              Y2 = Math.Pow(angle, Y1);
              X = Math.Pow(Y2, n);
            return X;
        }
    }



    /// <summary>
    /// Возращает область определения для сложной функции f(x) = (x^(1/n))^n
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque10", "f(x) = (x^(1/n))^n")]
    public static class CLOX_10_2_xpown_xpown_1divn_in
    {
        public static string LOX_10_2_xpown_xpown_1divn_in()
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
    [FunctionName("Opaque11", "f(x) = loga(a^x)")]
    [EquivalentIntConstant(1)]
    public static class CLOX_11_2_logax_apowx
    {
        public static double LOX_11_2_logax_apowx(double angle, int a = 10)
        {
            #if Debug
                if (a < 0)
                {
                    throw new Exception("Значение 'x' не принадлежит области определения!");
                }
            #endif
            double X = 1;
            double Y1;
              Y1 = Math.Pow(a, angle);
              X = Math.Log(Y1) / Math.Log(a); 
            return X;
        }
    }



    /// <summary>
    /// Возращает область определения для сложной функции f(x) = loga(a^x)
    /// a лежит в области a > 0, a ≠ 1.
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque11", "f(x) = loga(a^x)")]
    public static class CLOX_11_2_logax_apowx_in
    {
        public static string LOX_11_2_logax_apowx_in()
        {
            string s = "(w, w)";
            return s;
        }
    }



    /// <summary>
    /// Реализует сложную функцию    f(x) = a^(logax), a > 0, a ≠ 1,  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>

    [OpaqueFunction()]
    [FunctionName("Opaque12", "f(x) = a^(logax)")]
    [EquivalentIntConstant(1)]
    public static class CLOX_12_2_xpowy_logax
    {
        public static double LOX_12_2_xpowy_logax(double angle, int a = 10)
        {
            #if Debug
                if (a < 0)
                {
                    throw new Exception("Значение 'x' не принадлежит области определения!");
                }
            #endif
            double X = 1;
            double Y1;
              Y1 = Math.Log(angle) / Math.Log(a);
              X = Math.Pow(a, Y1);
            return X;
        }
    }



    /// <summary>
    /// Возращает область определения для сложной функции f(x) = a^(logax)
    /// a лежит в области a > 0, a ≠ 1.
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque12", "f(x) = a^(logax)")]
    public static class CLOX_12_2_xpowy_logax_in
    {
        public static string LOX_12_2_xpowy_logax_in()
        {
            string s = "(0, w)";
            return s;
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
    [FunctionName("Opaque13", "f(x) = ln(e^x)")]
    [EquivalentIntConstant(1)]
    public static class CLOX_13_1_lnx_epowx
    {
        public static double LOX_13_1_lnx_epowx(double angle)
        {
            double X = 1;
            double Y1;
              Y1 = Math.Exp(angle);
              X = Math.Log(Y1); 
            return X;
        }
    }



    /// <summary>
    /// Возращает область определения для сложной функции f(x) = ln(e^x)
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque13", "f(x) = ln(e^x)")]
    public static class CLOX_13_1_lnx_epowx_in
    {
        public static string LOX_13_1_lnx_epowx_in()
        {
            string s = "(w, w)";
            return s;
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
    [FunctionName("Opaque14", "f(x) = e^(lnx)")]
    [EquivalentIntConstant(1)]
    public static class CLOX_14_1_xpowy_lnx
    {
        public static double LOX_14_1_xpowy_lnx(double angle)
        {
            double X = 1;
            double Y1;
              Y1 = Math.Log(angle);
              X = Math.Exp(Y1);
            return X;
        }
    }



    /// <summary>
    /// Возращает область определения для сложной функции f(x) = e^(lnx)
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque14", "f(x) = e^(lnx)")]
    public static class CLOX_14_1_xpowy_lnx_in
    {
        public static string LOX_14_1_xpowy_lnx_in()
        {
            string s = "(w, w)";
            return s;
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
    [FunctionName("Opaque15", "f(x) = sh(arsh(x))")]
    [EquivalentIntConstant(1)]
    public static class CLOX_15_1_sh_arsh
    {
        public static double LOX_15_1_sh_arsh(double angle)
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
    /// Возращает область определения для сложной функции f(x) = sh(arsh(x))
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque15", "f(x) = sh(arsh(x))")]
    public static class CLOX_15_1_sh_arsh_in
    {
        public static string LOX_15_1_sh_arsh_in()
        {
            string s = "(w, w)";
            return s;
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
    [FunctionName("Opaque16", "f(x) = arsh(sh(x))")]
    [EquivalentIntConstant(1)]
    public static class CLOX_16_1_arsh_sh
    {
        public static double LOX_16_1_arsh_sh(double angle)
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
    /// Возращает область определения для сложной функции f(x) = arsh(sh(x))
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque16", "f(x) = arsh(sh(x))")]
    public static class CLOX_16_1_arsh_sh_in
    {
        public static string LOX_16_1_arsh_sh_in()
        {
            string s = "(w, w)";
            return s;
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
    [FunctionName("Opaque17", "f(x) = ch(arch(x))")]
    [EquivalentIntConstant(1)]
    public static class CLOX_17_1_ch_arch
    {
        public static double LOX_17_1_ch_arch(double angle)
        {
            #if Debug
                if (angle < 1)
                {
                    throw new Exception("Значение 'x' не принадлежит области определения!");
                }
            #endif
            double X = 1;
            double Y1, Y2;
              Y1 = angle + Math.Sqrt(angle * angle - 1.0);
              Y2 = Math.Log(Y1);
              X = Math.Cosh(Y2);
            return X;
        }
    }



    /// <summary>
    /// Возращает область определения для сложной функции f(x) = ch(arch(x))
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque17", "f(x) = ch(arch(x))")]
    public static class CLOX_17_1_ch_arch_in
    {
        public static string LOX_17_1_ch_arch_in()
        {
            string s = "(1, w)";
            return s;
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
    [FunctionName("Opaque18", "f(x) = arch(ch(x))")]
    [EquivalentIntConstant(1)]
    public static class CLOX_18_1_arch_ch
    {
        public static double LOX_18_1_arch_ch(double angle)
        {
            #if Debug
                if (angle < 0 )
                {
                    throw new Exception("Значение 'x' не принадлежит области определения!");
                }
            #endif
            double X = 1;
            double Y1, Y2;
              Y1 = Math.Cosh(angle);
              Y2 = Y1 + Math.Sqrt(Y1 * Y1 - 1);
              X = Math.Log(Y2);
            return X;
        }
    }



    /// <summary>
    /// Возращает область определения для сложной функции f(x) = arch(ch(x))
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque18", "f(x) = arch(ch(x))")]
    public static class CLOX_18_1_arch_ch_in
    {
        public static string LOX_18_1_arch_ch_in()
        {
            string s = "(0, w)";
            return s;
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
    [FunctionName("Opaque19", "f(x) = th(arth(x))")]
    [EquivalentIntConstant(1)]
    public static class CLOX_19_1_th_arth
    {
        public static double LOX_19_1_th_arth(double angle)
        {
            #if Debug
                if ((angle > 1) || (angle < -1))
                {
                    throw new Exception("Значение 'x' не принадлежит области определения!");
                }
            #endif
            double X = 1;
            double Y1, Y2;
              Y1 = (1 + angle) / (1 - angle);
              Y2 = 0.5 * Math.Log(Y1);
              X = Math.Tanh(Y2);
            return X;
        }
    }



    /// <summary>
    /// Возращает область определения для сложной функции f(x) = th(arth(x))
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque19", "f(x) = th(arth(x))")]
    public static class CLOX_19_1_th_arth_in
    {
        public static string LOX_19_1_th_arth_in()
        {
            string s = "(-1, 1)";
            return s;
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
    [FunctionName("Opaque20", "f(x) = arth(th(x))")]
    [EquivalentIntConstant(1)]
    public static class CLOX_20_1_arth_th
    {
        public static double LOX_20_1_arth_th(double angle)
        {
            #if Debug
                if ((angle > -1) & (angle < 1))
                {
                    throw new Exception("Значение 'x' не принадлежит области определения!");
                }
            #endif
            double X = 1;
            double Y1, Y2;
              Y1 = Math.Tanh(angle);
              Y2 = (1 + Y1) / (1 - Y1);
              X = 0.5 * Math.Log(Y2);         
            return X;
        }
    }



    /// <summary>
    /// Возращает область определения для сложной функции f(x) = arth(th(x))
    /// работает и для левой ветки (w, -1)
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque20", "f(x) = arth(th(x))")]
    public static class CLOX_20_1_arth_th_in
    {
        public static string LOX_20_1_arth_th_in()
        {
            string s = "(1, w)";
            return s;
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
    [FunctionName("Opaque21", "f(x) = cth(arcth(x))")]
    [EquivalentIntConstant(1)]
    public static class CLOX_21_1_cth_arcth
    {
        public static double LOX_21_1_cth_arcth(double angle)
        {
            #if Debug
                if ((angle > -1) & (angle < 1))
                {
                    throw new Exception("Значение 'x' не принадлежит области определения!");
                }
            #endif
            double X = 1;
            double Y1, Y2;
              Y1 = (angle + 1.0) / (angle - 1.0);
              Y2 = 0.5 * Math.Log(Y1);
              X = 1.0 / Math.Tanh(Y2); 
            return X;
        }
    }



    /// <summary>
    /// Возращает область определения для сложной функции f(x) = сth(arсth(x))
    /// работает и для левой ветки (w, -1)
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque21", "f(x) = cth(arcth(x))")]
    public static class CLOX_21_1_cth_arcth_in
    {
        public static string LOX_21_1_cth_arcth_in()
        {
            string s = "(1, w)";
            return s;
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
    [FunctionName("Opaque22", "f(x) = arcth(cth(x))")]
    [EquivalentIntConstant(1)]
    public static class CLOX_22_1_arcth_cth
    {
        public static double LOX_22_1_arcth_cth(double angle)
        {
            double X = 1;
            double Y1, Y2;
              Y1 = 1 / Math.Tanh(angle);
              Y2 = (Y1 + 1) / (Y1 - 1);
              X = 0.5 * Math.Log(Y2);
            
            return X;
        }
    }



    /// <summary>
    /// Возращает область определения для сложной функции f(x) = arcth(cth(x))
    /// работает и для левой ветки (w, 0)
    /// </summary>

    [OpaqueFunction()]
    [FunctionName("Opaque22", "f(x) = arcth(cth(x))")]
    public static class CLOX_22_1_arcth_cth_in
    {
        public static string LOX_22_1_arcth_cth_in()
        {
            string s = "(0, w)";
            return s;
        }
    }







}

