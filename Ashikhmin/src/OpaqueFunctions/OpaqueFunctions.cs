#define _DBG
using System;

namespace OpaqueFunctions
{
    public class OpaqueException : Exception
    {
        public OpaqueException()
            : base("Argument is out of domain")
        {

        }
    }

    /// <summary>
    /// Реализует основное тригонометрическое тождество sin^2 (x) + cos^2 (x) = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_1_1_SinCos", "sin^2(x) + cos^2(x) = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_1_1_SinCos
    {
        public static double L01_1_1_SinCos(double x)
        {
#if _DBG
            if ((x < -1) || (x > 1)){
                throw new OpaqueException();
            }
#endif
            double F, f1, f2;
            f1 = Math.Sin(x);
            f2 = Math.Cos(x);
            F = f1 * f1 + f2 * f2;
            return F;
        }
    }

    public static class CL01_1_1_SinCos_in
    {
        public static string L01_1_1_SinCos_in()
        {
            string s;
            s = "(-1, 1)";
            return s;
        }
    }

    /// <summary>
    /// Реализует тригонометрическое тождество tg(x) * cos(x) / sin(x) = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_2_1_TgCosSin", "tg(x) * cos(x) / sin(x) = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_2_1_TgCosSin
    {
        public static double L01_2_1_TgCosSin(double x)
        {
#if _DBG
            if ((x < 0) || (x > Math.PI / 2))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2, f3;
            f1 = Math.Tan(x);
            f2 = Math.Cos(x);
            f3 = Math.Sin(x);
            F = f1 * f2 / f3;
            return F;
        }
    }

    public static class CL01_2_1_TgCosSin_in
    {
        public static string L01_2_1_TgCosSin_in()
        {
            string s;
            s = "(0, Pi/2)";
            return s;
        }
    }

    /// <summary>
    /// Реализует тригонометрическое тождество ctg(x) * sin(x) / cos(x) = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_3_1_CtgSinCos", "ctg(x) * sin(x) / cos(x) = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_3_1_CtgSinCos
    {
        public static double L01_3_1_CtgSinCos(double x)
        {
#if _DBG
            if ((x < 0) || (x > Math.PI / 2))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2, f3;
            f1 = 1 / Math.Tan(x);
            f2 = Math.Sin(x);
            f3 = Math.Cos(x);
            F = f1 * f2 / f3;
            return F;
        }
    }

    public static class CL01_3_1_CtgSinCos_in
    {
        public static string L01_3_1_CtgSinCos_in()
        {
            string s;
            s = "(0, Pi/2)";
            return s;
        }
    }

    /// <summary>
    /// Реализует тригонометрическое тождество sec(x) * cos(x) = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_4_1_SecCos", "sec(x) * cos(x) = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_4_1_SecCos
    {
        public static double L01_4_1_SecCos(double x)
        {
#if _DBG
            if ((x < -Math.PI / 2) || (x > Math.PI / 2))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2; 
            f1 = 1 / Math.Cos(x);
            f2 = Math.Cos(x);
            F = f1 * f2;
            return F;
        }
    }

    public static class CL01_4_1_SecCos_in
    {
        public static string L01_4_1_SecCos_in()
        {
            string s;
            s = "(-Pi/2, Pi/2)";
            return s;
        }
    }

    /// <summary>
    /// Реализует тригонометрическое тождество cosec(x) * sin(x) = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_5_1_CosecSin", "cosec(x) * sin(x) = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_5_1_CosecSin
    {
        public static double L01_5_1_CosecSin(double x)
        {
#if _DBG
            if ((x < 0) || (x > Math.PI))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2;
            f1 = 1 / Math.Sin(x);
            f2 = Math.Sin(x);
            F = f1 * f2;
            return F;
        }
    }

    public static class CL01_5_1_CosecSin_in
    {
        public static string L01_5_1_CosecSin_in()
        {
            string s;
            s = "(0, Pi)";
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество (sin (x) * cos(y) + cos(x) * sin(y)) / sin(x + y) = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_6_2_SinCosPlusCosSinSin", "(sin(x) * cos(y) + cos(x) * sin(y)) / sin(x + y) = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_6_2_SinCosPlusCosSinSin
    {
        public static double L01_6_2_SinCosPlusCosSinSin(double x, double y)
        {
#if _DBG
            if (((x < 0) || (x > Math.PI / 2))&&((y < 0) || (y > Math.PI / 2)))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2, f3, f4, f5;
            f1 = Math.Sin(x);
            f2 = Math.Cos(y);
            f3 = Math.Cos(x);
		    f4 = Math.Sin(y);
			f5 = Math.Sin(x + y);
            F = (f1 * f2 + f3 * f4) / f5;
            return F;
        }
    }

    public static class CL01_6_2_SinCosPlusCosSinSin_in
    {
        public static string L01_6_2_SinCosPlusCosSinSin_in()
        {
            string s;
            s = "(0, Pi/2) (0, Pi/2)";
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество (sin(x) * cos(y) - cos(x) * sin(y)) / sin(x - y) = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_7_2_SinCosMinusCosSinSin", "(sin(x) * cos(y) - cos(x) * sin(y)) / sin(x - y) = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_7_2_SinCosMinusCosSinSin
    {
        public static double L01_7_2_SinCosMinusCosSinSin(double x, double y)
        {
#if _DBG
            if (((x < Math.PI / 2) || (x > Math.PI)) && ((y < 0) || (y > Math.PI / 2)))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2, f3, f4, f5;
            f1 = Math.Sin(x);
            f2 = Math.Cos(y);
     		f3 = Math.Cos(x);
			f4 = Math.Sin(y);
			f5 = Math.Sin(x - y);
            F = (f1 * f2 - f3 * f4) / f5;
            return F;
        }
    }

    public static class CL01_7_2_SinCosMinusCosSinSin_in
    {
        public static string L01_7_2_SinCosMinusCosSinSin_in()
        {
            string s;
            s = "(Pi/2, Pi) (0, Pi/2)";
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество (cos(x) * cos(y) + sin(x) * sin(y)) / cos(x + y) = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_8_2_CosCosSinSinCos", "(cos(x) * cos(y) - sin(x) * sin(y)) / cos(x + y) = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_8_2_CosCosSinSinCos
    {
        public static double L01_8_2_CosCosSinSinCos(double x, double y)
        {
#if _DBG
            if (((x < -Math.PI / 4) || (x > Math.PI / 4)) && ((y < -Math.PI / 4) || (y > Math.PI / 4)))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2, f3, f4, f5;
            f1 = Math.Cos(x);
            f2 = Math.Cos(y);
		    f3 = Math.Sin(x);
		    f4 = Math.Sin(y);
			f5 = Math.Cos(x + y);
            F = (f1 * f2 - f3 * f4) / f5;
            return F;
        }
    }

    public static class CL01_8_2_CosCosSinSinCos_in
    {
        public static string L01_8_2_CosCosSinSinCos_in()
        {
            string s;
            s = "(-Pi/4, Pi/4) (-Pi/4, Pi/4)";
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество (tg(x) + tg(y)) / ((1 + tg(x) * tg(y)) * tg(x + y)) = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_9_2_Tg", "(tg(x) + tg(y)) / ((1 + tg(x) * tg(y)) * tg(x + y)) = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_9_2_Tg
    {
        public static double L01_9_2_Tg(double x, double y)
        {
#if _DBG
            if (((x < -Math.PI / 4) || (x > Math.PI / 4)) && ((y < -Math.PI / 4) || (y > Math.PI / 4)))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2, f3;
            f1 = Math.Tan(x);
            f2 = Math.Tan(y);
			f3 = Math.Tan(x + y);
            F = (f1 + f2) / ((1 - f1 * f2) * f3);
            return F;
        }
    }

    public static class CL01_9_2_Tg_in
    {
        public static string L01_9_2_Tg_in()
        {
            string s;
            s = "(-Pi/4, Pi/4) (-Pi/4, Pi/4)";
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество (ctg(x) * ctg(y) + 1) / ((ctg(y) + ctg(x)) * ctg(x + y)) = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_10_2_Ctg", "(ctg(x) * ctg(y) - 1) / ((ctg(y) + ctg(x)) * ctg(x + y)) = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_10_2_Ctg
    {
        public static double L01_10_2_Ctg(double x, double y)
        {
#if _DBG
            if (((x < 0) || (x > Math.PI / 2)) && ((y < 0) || (y > Math.PI / 2)))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2, f3;
            f1 = 1 / Math.Tan(x);
            f2 = 1 / Math.Tan(y);
			f3 = 1 / Math.Tan(x + y);
            F = (f1 * f2 - 1) / ((f2 + f1) * f3);
            return F;
        }
    }

    public static class CL01_10_2_Ctg_in
    {
        public static string L01_10_2_Ctg_in()
        {
            string s;
            s = "(0, Pi/2) (0, Pi/2)";
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество (cos(x - y) + cos(x + y)) / 2 * sin(x) * cos(x) = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_11_2_CosCosCosCos", "(cos(x - y) + cos(x + y)) / (2 * cos(x) * cos(y)) = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_11_2_CosCosCosCos
    {
        public static double L01_11_2_CosCosCosCos(double x, double y)
        {
#if _DBG
            if (((x < 0) || (x > Math.PI / 2)) && ((y < 0) || (y > Math.PI / 2)))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2, f3, f4;
            f1 = Math.Cos(x - y);
            f2 = Math.Cos(x + y);
			f3 = Math.Cos(x);
			f4 = Math.Cos(y);
            F = (f1 + f2) / (2 * f3 * f4);
            return F;
        }
    }

    public static class CL01_11_2_CosCosCosCos_in
    {
        public static string L01_11_2_CosCosCosCos_in()
        {
            string s;
            s = "(0, Pi/2) (0, Pi/2)";
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество (cos(x - y) + cos(x + y)) / 2 * sin(x) * cos(x) = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_12_2_CosCosSinSin", "(cos(x - y) - cos(x + y)) / (2 * sin(x) * sin(y)) = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_12_2_CosCosSinSin
    {
        public static double L01_12_2_CosCosSinSin(double x, double y)
        {
#if _DBG
            if (((x < -Math.PI / 2) || (x > Math.PI / 2)) && ((y < -Math.PI / 2) || (y > Math.PI / 2)))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2, f3, f4;
            f1 = Math.Cos(x - y);
            f2 = Math.Cos(x + y);
			f3 = Math.Sin(x);
			f4 = Math.Sin(y);
            F = (f1 - f2) / (2 * f3 * f4);
            return F;
        }
    }

    public static class CL01_12_2_CosCosSinSin_in
    {
        public static string L01_12_2_CosCosSinSin_in()
        {
            string s;
            s = "(-Pi/2, Pi/2) (-Pi/2, Pi/2)";
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество (sin(x - y) – sin(x + y)) / 2 * sin(x) * cos(y) = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_13_2_SinSinSinCos", "(sin(x - y) – sin(x + y)) / (-2 * cos(x) * sin(y)) = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_13_2_SinSinSinCos
    {
        public static double L01_13_2_SinSinSinCos(double x, double y)
        {
#if _DBG
            if (((x < 0) || (x > Math.PI / 2)) && ((y < -Math.PI / 2) || (y > Math.PI / 2)))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2, f3, f4;
            f1 = Math.Sin(x - y);
            f2 = Math.Sin(x + y);
			f3 = Math.Cos(x);
			f4 = Math.Sin(y);
            F = (f1 - f2) / (-2 * f3 * f4);
            return F;
        }
    }

    public static class CL01_13_2_SinSinSinCos_in
    {
        public static string L01_13_2_SinSinSinCos_in()
        {
            string s;
            s = "(0, Pi) (-Pi/2, Pi/2)";
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество 2 * sin(x) * cos(x) / sin(2x) = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_14_1_SinCosSin", "2 * sin(x) * cos(x) / sin(2x) = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_14_1_SinCosSin
    {
        public static double L01_14_1_SinCosSin(double x)
        {
#if _DBG
            if ((x < 0) || (x > Math.PI / 2))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2, f3;
            f1 = Math.Sin(x);
            f2 = Math.Cos(x);
			f3 = Math.Sin(2 * x);
            F = 2 * f1 * f2 / f3;
            return F;
        }
    }

    public static class CL01_14_1_SinCosSin_in
    {
        public static string L01_14_1_SinCosSin_in()
        {
            string s;
            s = "(0, Pi/2)";
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество (3 * sin(x) + 4 * sin(x) * sin(x) * sin(x)) / sin(3x) = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_15_1_Sin", "(3 * sin(x) - 4 * sin(x) * sin(x) * sin(x)) / sin(3x) = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_15_1_Sin
    {
        public static double L01_15_1_Sin(double x)
        {
#if _DBG
            if ((x < 0) || (x > Math.PI / 3))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2;
            f1 = Math.Sin(x);
            f2 = Math.Sin(3 * x);
            F = (3 * f1 - 4 * f1 * f1 * f1) / f2;
            return F;
        }
    }

    public static class CL01_15_1_Sin_in
    {
        public static string L01_15_1_Sin_in()
        {
            string s;
            s = "(0, Pi/3)";
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество sin(arcsin(x)) / x = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_16_1_SinArcsin", "sin(arcsin(x)) / x  = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_16_1_SinArcsin
    {
        public static double L01_16_1_SinArcsin(double x)
        {
#if _DBG
            if ((x < 0) || (x > 1))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2;
            f1 = Math.Sin(Math.Asin(x));
            f2 = x;
            F = f1 / f2;
            return F;
        }
    }

    public static class CL01_16_1_SinArcsin_in
    {
        public static string L01_16_1_SinArcsin_in()
        {
            string s;
            s = "(0, 1)";
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество cos(arccos(x)) / x = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_17_1_CosArccos", "cos(arccos(x)) / x   = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_17_1_CosArccos
    {
        public static double L01_17_1_CosArccos(double x)
        {
#if _DBG
            if ((x < 0) || (x > 1))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2;
            f1 = Math.Cos(Math.Acos(x));
            f2 = x;
            F = f1 / f2;
            return F;
        }
    }

    public static class CL01_17_1_CosArccos_in
    {
        public static string L01_17_1_CosArccos_in()
        {
            string s;
            s = "(0, 1)";
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество cos(arcsin(x)) / sin(arccos(x)) = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_18_1_CosArcsin", "cos(arcsin(x)) / sin(arccos(x)) = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_18_1_CosArcsin
    {
        public static double L01_18_1_CosArcsin(double x)
        {
#if _DBG
            if ((x < -1) || (x > 1))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2;
            f1 = Math.Cos(Math.Asin(x));
            f2 = Math.Sin(Math.Acos(x));
            F = f1 / f2;
            return F;
        }
    }

    public static class CL01_18_1_CosArcsin_in
    {
        public static string L01_18_1_CosArcsin_in()
        {
            string s;
            s = "(-1, 1)";
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество sin(arccos(x)) / (1 – x * x)^1/2 = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_19_1_SinArccos", "sin(arccos(x)) / (1 – x * x)^1/2 = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_19_1_SinArccos
    {
        public static double L01_19_1_SinArccos(double x)
        {
#if _DBG
            if ((x < -1) || (x > 1))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2;
            f1 = Math.Sin(Math.Acos(x));
            f2 = Math.Sqrt(1 - x * x);
            F = f1 / f2;
            return F;
        }
    }

    public static class CL01_19_1_SinArccos_in
    {
        public static string L01_19_1_SinArccos_in()
        {
            string s;
            s = "(-1, 1)";
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество cos(arcsin(x)) / (1 – x * x)^1/2 = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_20_1_CosArcsin", "cos(arcsin(x)) / (1 – x * x)^1/2 = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_20_1_CosArcsin
    {
        public static double L01_20_1_CosArcsin(double x)
        {
#if _DBG
            if ((x < -1) || (x > 1))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2;
            f1 = Math.Cos(Math.Asin(x));
            f2 = Math.Sqrt(1 - x * x);
            F = f1 / f2;
            return F;
        }
    }

    public static class CL01_20_1_CosArcsin_in
    {
        public static string L01_20_1_CosArcsin_in()
        {
            string s;
            s = "(-1, 1)";
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество cos(arcctg(x)) / sin(arctg(x)) = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_21_1_CosArcctg", "cos(arcctg(x)) / sin(arctg(x)) = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_21_1_CosArcctg
    {
        public static double L01_21_1_CosArcctg(double x)
        {
#if _DBG
            if ((x < 0) || (x > Math.PI / 2))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2;
            f1 = Math.Cos(Math.PI / 2 - Math.Atan(x));
            f2 = Math.Sin(Math.Atan(x));
            F = f1 / f2;
            return F;
        }
    }

    public static class CL01_21_1_CosArcctg_in
    {
        public static string L01_21_1_CosArcctg_in()
        {
            string s;
            s = "(0, Pi/2)";
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество sin(arctg(x)) * ((1 + x * x)^1/2) / x = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_22_1_SinArctg", "sin(arctg(x)) * ((1 + x * x)^1/2) / x = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_22_1_SinArctg
    {
        public static double L01_22_1_SinArctg(double x)
        {
#if _DBG
            if (x < 0)
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2, f3;
            f1 = Math.Sin(Math.Atan(x));
            f2 = Math.Sqrt(1 + x * x);
		    f3 = x;
            F = f1 * f2 / f3;
            return F;
        }
    }

    public static class CL01_22_1_SinArctg_in
    {
        public static string L01_22_1_SinArctg_in()
        {
            string s;
            s = "(0, w)"; //Здесь х не равен нулю. Выбрана правая часть числовой оси.
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество cos(arcctg(x)) * ((1 + x * x)^1/2) / x = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_23_1_CosArcctg", "cos(arcctg(x)) * ((1 + x * x)^1/2) / x = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_23_1_CosArcctg
    {
        public static double L01_23_1_CosArcctg(double x)
        {
#if _DBG
            if (x < 0)
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2, f3;
            f1 = Math.Cos(Math.PI / 2 - Math.Atan(x));
            f2 = Math.Sqrt(1 + x * x);
		    f3 = x;
            F = f1 * f2 / f3;
            return F;
        }
    }

    public static class CL01_23_1_CosArcctg_in
    {
        public static string L01_23_1_CosArcctg_in()
        {
            string s;
            s = "(0, w)"; //Здесь х не равен нулю. Выбрана положительная часть числовой оси.
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество cos(arctg(x)) * ((1 + x * x)^1/2) = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_24_1_CosArctg", "cos(arctg(x)) * ((1 + x * x)^1/2) = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_24_1_CosArctg
    {
        public static double L01_24_1_CosArctg(double x)
        {
#if _DBG
            if (x < 0)
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2;
            f1 = Math.Cos(Math.Atan(x));
            f2 = Math.Sqrt(1 + x * x);
            F = f1 * f2;
            return F;
        }
    }

    public static class CL01_24_1_CosArctg_in
    {
        public static string L01_24_1_CosArctg_in()
        {
            string s;
            s = "(0, w)";
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество sin(arcctg(x)) * ((1 + x * x)^1/2) = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_25_1_SinArcctg", "sin(arcctg(x)) * ((1 + x * x)^1/2) = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_25_1_SinArcctg
    {
        public static double L01_25_1_SinArcctg(double x)
        {
#if _DBG
            if (x < 0)
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2;
            f1 = Math.Sin(Math.PI / 2 - Math.Atan(x));
            f2 = Math.Sqrt(1 + x * x);
            F = f1 * f2;
            return F;
        }
    }

    public static class CL01_25_1_SinArcctg_in
    {
        public static string L01_25_1_SinArcctg_in()
        {
            string s;
            s = "(0, w)";
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество tg(arcsin(x)) * ((1 - x*x)^1/2) / x  = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_26_1_TgArcsin", "tg(arcsin(x)) * ((1 - x*x)^1/2) / x = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_26_1_TgArcsin
    {
        public static double L01_26_1_TgArcsin(double x)
        {
#if _DBG
            if ((x < 0) || (x > 1))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2, f3;
            f1 = Math.Tan(Math.Asin(x));
            f2 = Math.Sqrt(1 - x * x);
		    f3 = x;
            F = f1 * f2 / f3;
            return F;
        }
    }

    public static class CL01_26_1_TgArcsin_in
    {
        public static string L01_26_1_TgArcsin_in()
        {
            string s;
            s = "(0, 1)"; //Также интервал (-1, 0)
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество ctg(arccos(x)) * ((1 - x * x)^1/2) / x = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_27_1_CtgArccos", "ctg(arccos(x)) * ((1 - x * x)^1/2) / x = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_27_1_CtgArccos
    {
        public static double L01_27_1_CtgArccos(double x)
        {
#if _DBG
            if ((x < 0) || (x > 1))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2, f3;
            f1 = 1 / Math.Tan(Math.Acos(x));
            f2 = Math.Sqrt(1 - x * x);
		    f3 = x;
            F = f1 * f2 / f3;
            return F;
        }
    }

    public static class CL01_27_1_CtgArccos_in
    {
        public static string L01_27_1_CtgArccos_in()
        {
            string s;
            s = "(0, 1)"; //Также интервал (-1, 0)
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество tg(arccos(x)) * x / ((1 - x * x)^1/2) = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_28_1_TgArccos", "tg(arccos(x)) * x / ((1 - x * x)^1/2) = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_28_1_TgArccos
    {
        public static double L01_28_1_TgArccos(double x)
        {
#if _DBG
            if ((x < 0) || (x > 1))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2, f3;
            f1 = Math.Tan(Math.Acos(x));
		    f2 = x;
			f3 = Math.Sqrt(1 - x * x);
            F = f1 * f2 / f3;
            return F;
        }
    }

    public static class CL01_28_1_TgArccos_in
    {
        public static string L01_28_1_TgArccos_in()
        {
            string s;
            s = "(0, 1)";
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество ctg(arcsin(x)) * x / ((1 - x * x)^1/2) = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_29_1_CtgArcsin", "ctg(arcsin(x)) * x / ((1 - x * x)^1/2) = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_29_1_CtgArcsin
    {
        public static double L01_29_1_CtgArcsin(double x)
        {
#if _DBG
            if ((x < 0) || (x > 1))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2, f3;
            f1 = 1 / Math.Tan(Math.Asin(x));
			f2 = x;
			f3 = Math.Sqrt(1 - x * x);
            F = f1 * f2 / f3;
            return F;
        }
    }

    public static class CL01_29_1_CtgArcsin_in
    {
        public static string L01_29_1_CtgArcsin_in()
        {
            string s;
            s = "(0, 1)";
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество cos(arctg(x)) / sin(arcctg(x)) = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_30_1_CosArctg", "cos(arctg(x)) / sin(arcctg(x)) = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_30_1_CosArctg
    {
        public static double L01_30_1_CosArctg(double x)
        {
#if _DBG
            if ((x < 0) || (x > Math.PI / 2))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2;
            f1 = Math.Cos(Math.Atan(x));
			f2 = Math.Sin(Math.PI / 2 - Math.Atan(x));
            F = f1 / f2;
            return F;
        }
    }

    public static class CL01_30_1_CosArctg_in
    {
        public static string L01_30_1_CosArctg_in()
        {
            string s;
            s = "(0, Pi/2)";
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество tg(arctg(x)) / x = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_31_1_TgArctg", "tg(arctg(x)) / x = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_31_1_TgArctg
    {
        public static double L01_31_1_TgArctg(double x)
        {
#if _DBG
            if (x < 0)
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2;
            f1 = Math.Tan(Math.Atan(x));
			f2 = x;
            F = f1 / f2;
            return F;
        }
    }

    public static class CL01_31_1_TgArctg_in
    {
        public static string L01_31_1_TgArctg_in()
        {
            string s;
            s = "(0, w)"; //Здесь х не равен нулю. Выбрана правая часть числовой оси.
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество ctg(arcctg(x)) / x = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_32_1_CtgArcctg", "ctg(arcctg(x)) / x = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_32_1_CtgArcctg
    {
        public static double L01_32_1_CtgArcctg(double x)
        {
#if _DBG
            if (x < 0)
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2;
            f1 = 1 / Math.Tan(Math.PI / 2 - Math.Atan(x));
			f2 = x;
            F = f1 / f2;
            return F;
        }
    }

    public static class CL01_32_1_CtgArcctg_in
    {
        public static string L01_32_1_CtgArcctg_in()
        {
            string s;
            s = "(0, w)"; //Здесь х не равен нулю. Выбрана правая часть числовой оси.
            return s;
        }
    }
	
	/// <summary>
    /// Реализует тригонометрическое тождество arcsin(sin(x)) / x = 1,  
    /// где угол X задается параметром в радианах <paramref name="a"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="a">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L01_33_1_ArcsinSin", "arcsin(sin(x)) / x = 1")]
    [EquivalentIntConstant(1)]
    public static class CL01_33_1_ArcsinSin
    {
        public static double L01_33_1_ArcsinSin(double x)
        {
#if _DBG
            if ((x < 0) || (x > Math.PI / 2))
            {
                throw new OpaqueException();
            }
#endif
            double F, f1, f2;
            f1 = Math.Asin(Math.Sin(x));
			f2 = x;
            F = f1 / f2;
            return F;
        }
    }

    public static class CL01_33_1_ArcsinSin_in
    {
        public static string L01_33_1_ArcsinSin_in()
        {
            string s;
            s = "(0, Pi/2)";
            return s;
        }
    }

}