#define DEBUG
using System;

namespace OpaqueFunctions
{
    public class OpaqueException : Exception
    {
        public OpaqueException():base("Argument is out of range"){
            
        }
    }

    
    //##################################################################################################
    /// <summary>
    /// Реализует тождество 58 f(x) = arctg(x) – arcctg(1/x)
    /// </summary>
    /// <param name="x">Положительное число</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_58_1_arctg_arcctg", "f(x) = arctg(x) – arcctg(1/x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_58_1_arctg_arcctg
    {
        public static double L00_58_1_arctg_arcctg(double x)
        {
            #if DEBUG
            if (x <= 0)                
                throw new OpaqueException();
            #endif
            double X, Y1, Y2;
            Y1 = Math.Atan(x);
            Y2 = Math.PI / 2 - Math.Atan(1 / x);
            X = Y1 - Y2;
            return X;
        }
    }
    
    /// <summary>
    /// Возвращает область определения тождества 58 f(x) = arctg(x) – arcctg(1/x)
    /// </summary>    
    /// <returns>(0, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_58_1_arctg_arcctg_in", "(0, w)")]
    public static class CL00_58_1_arctg_arcctg_in
    {
        public static string L00_58_1_arctg_arcctg_in()
        {
            return "(0, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 59 f(x) = arctg(x) – arccos(1/((1+x*x)^1/2))
    /// </summary>
    /// <param name="x">Положительное число</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_59_1_arctg_arccos", "f(x) = arctg(x) – arccos(1/((1+x*x)^1/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_59_1_arctg_arccos
    {
        public static double L00_59_1_arctg_arccos(double x)
        {
#if DEBUG
            if (x <= 0)
                throw new OpaqueException();
#endif
            double X, Y1, Y2, Y3, Y4, Y5;
            Y1 = Math.Atan(x);
            Y2 = 1 + x * x;
            Y3 = Math.Pow(Y2, 0.5);
            Y4 = 1 / Y3;
            Y5 = Math.Acos(Y4);
            X = Y1 - Y5;
            return X;
        }
    }
    
    /// <summary>
    /// Возвращает область определения тождества 59 f(x) = arctg(x) – arccos(1/((1+x*x)^1/2))
    /// </summary>    
    /// <returns>(0, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_59_1_arctg_arccos_in", "(0, w)")]
    public static class CL00_59_1_arctg_arccos_in
    {
        public static string L00_59_1_arctg_arccos_in()
        {
            return "(0, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 60 f(x) = arcctg(1/x) - arccos(1/((1+x*x)^1/2))
    /// </summary>
    /// <param name="x">Положительное число</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_60_1_arcctg_arccos", "f(x) = arcctg(1/x) - arccos(1/((1+x*x)^1/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_60_1_arcctg_arccos
    {
        public static double L00_60_1_arcctg_arccos(double x)
        {
#if DEBUG
            if (x <= 0)
                throw new OpaqueException();
#endif
            double X, Y1, Y2, Y3;
            Y1 = Math.PI / 2 - Math.Atan(1 / x);
            Y2 = 1 / Math.Pow(1 + x * x, 0.5);
            Y3 = Math.Acos(Y2);
            X = Y1 - Y3;
            return X;
        }
    }
    
    /// <summary>
    /// Возвращает область определения тождества 60 f(x) = arcctg(1/x) - arccos(1/((1+x*x)^1/2))
    /// </summary>    
    /// <returns>(0, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_60_1_arcctg_arccos_in", "(0, w)")]
    public static class CL00_60_1_arcctg_arccos_in
    {
        public static string L00_60_1_arcctg_arccos_in()
        {
            return "(0, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 61 f(x) = arcctg(x) - arccos(x/((1+x*x)^1/2))
    /// </summary>
    /// <param name="x">Положительное число</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_61_1_arcctg_arccos", "f(x) = arcctg(x) - arccos(x/((1+x*x)^1/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_61_1_arcctg_arccos
    {
        public static double L00_61_1_arcctg_arccos(double x)
        {
            double X, Y1, Y2, Y3;
            Y1 = Math.PI / 2 - Math.Atan(x);
            Y2 = x / Math.Pow(1 + x * x, 0.5);
            Y3 = Math.Acos(Y2);
            X = Y1 - Y3;
            return X;
        }
    }
    
    /// <summary>
    /// Возвращает область определения тождества 61 f(x) = arcctg(x) - arccos(x/((1+x*x)^1/2))
    /// </summary>    
    /// <returns>(0, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_61_1_arcctg_arccos_in", "(0, w)")]
    public static class CL00_61_1_arcctg_arccos_in
    {
        public static string L00_61_1_arcctg_arccos_in()
        {
            return "(0, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 62 f(x) = arcctg(x) – arcsin(1/((1+x*x)^1/2))
    /// </summary>
    /// <param name="x">Положительное число</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_62_1_arcctg_arcsin", "f(x) = arcctg(x) – arcsin(1/((1+x*x)^1/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_62_1_arcctg_arcsin
    {
        public static double L00_62_1_arcctg_arcsin(double x)
        {
#if DEBUG
            if (x <= 0)
                throw new OpaqueException();
#endif
            double X, Y1, Y2, Y3;
            Y1 =  Math.PI/2 - Math.Atan(x);
            Y2 = Math.Pow(1 + x * x, 0.5);
            Y2 = 1 / Y2;
            Y3 = Math.Asin(Y2);
            X = Y1 - Y3;
            return X;
        }
    }
    
    /// <summary>
    /// Возвращает область определения тождества 62 f(x) = arcctg(x) – arcsin(1/((1+x*x)^1/2))
    /// </summary>    
    /// <returns>(0, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_62_1_arcctg_arcsin_in", "(0, w)")]
    public static class CL00_62_1_arcctg_arcsin_in
    {
        public static string L00_62_1_arcctg_arcsin_in()
        {
            return "(0, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 63 f(x) = cos(2x) – 2*cos(x)*cos(x) + 1
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_63_1_cos", "f(x) = cos(2x) – 2*cos(x)*cos(x) + 1")]
    [EquivalentIntConstant(0)]
    public static class CL00_63_1_cos
    {
        public static double L00_63_1_cos(double x)
        {
            double Y1, Y2, Y3, X;
            Y3 = 2 * x;
            Y1 = Math.Cos(Y3);
            Y2 = Math.Cos(x);
            X = Y1 - 2 * Y2 * Y2 + 1;
            return X;
        }
    }
   
    /// <summary>
    /// Возвращает область определения тождества 63 f(x) = cos(2x) – 2*cos(x)*cos(x) + 1
    /// </summary>    
    /// <returns>(w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_63_1_cos_in", "(0, w)")]
    public static class CL00_63_1_cos_in
    {
        public static string L00_63_1_cos_in()
        {
            return "(w, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 64 f(x) = cos(2x) – 1 + 2*sin(x)*sin(x)
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_64_1_cos_sin", "f(x) = cos(2x) – 1 + 2*sin(x)*sin(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_64_1_cos_sin
    {
        public static double L00_64_1_cos_sin(double x)
        {
            double Y1, Y2, Y3, X;
            Y3 = 2 * x;
            Y1 = Math.Cos(Y3);
            Y2 = Math.Sin(x);
            X = Y1 - 1 + 2 * Y2 * Y2;
            return X;
        }
    }
   
    /// <summary>
    /// Возвращает область определения тождества 64 f(x) = cos(2x) – 1 + 2*sin(x)*sin(x)
    /// </summary>    
    /// <returns>(w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_64_1_cos_sin_in", "(0, w)")]
    public static class CL00_64_1_cos_sin_in
    {
        public static string L00_64_1_cos_sin_in()
        {
            return "(w, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 65 f(x) = tg(x) – 1/(tg(PI/2-x))
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_65_1_tg", "f(x) = tg(x) – 1/(tg(PI/2-x))")]
    [EquivalentIntConstant(0)]
    public static class CL00_65_1_tg
    {
        public static double L00_65_1_tg(double x)
        {
            double Y1, Y2, Y3, X;
            Y1 = Math.Tan(x);
            Y2 = Math.PI / 2 - x;
            Y3 = Math.Tan(Y2);
#if DEBUG
            if (Math.Abs(Y3) <= double.Epsilon)
                throw new OpaqueException();
#endif
            X = Y1 - 1 / Y3;
            return X;
        }
    }
    
    /// <summary>
    /// Возвращает область определения тождества 65 f(x) = tg(x) – 1/(tg(PI/2-x))
    /// </summary>    
    /// <returns>(w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_65_1_tg_in", "(0, w)")]
    public static class CL00_65_1_tg_in
    {
        public static string L00_65_1_tg_in()
        {
            return "(w, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 66 f(x) = tg(x) – (tg(a) + tg(x-a)/(1 – tg(a)*tg(x-a))
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <param name="y">Произвольный параметр</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_66_2_tg", "f(x) = tg(x) – (tg(a) + tg(x-a)/(1 – tg(a)*tg(x-a))")]
    [EquivalentIntConstant(0)]
    public static class CL00_66_2_tg
    {
        public static double L00_66_2_tg(double x, double y)
        {
            double Y1, Y2, Y3, X;
            Y1 = x - y;
            Y1 = Math.Tan(Y1);
            Y2 = Math.Tan(x);
            Y3 = Math.Tan(y);
#if DEBUG
            if (Math.Abs(1 - Y3 * Y1)  <= double.Epsilon)
                throw new OpaqueException();
#endif
            X = Y2 - (Y3+ Y1) / (1 - Y3 * Y1);
            return X;
        }
    }
    
    /// <summary>
    /// Возвращает область определения тождества 66 f(x) = tg(x) – (tg(a) + tg(x-a)/(1 – tg(a)*tg(x-a))
    /// </summary>    
    /// <returns>(w, w) (w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_66_2_tg_in", "(0, w)")]
    public static class CL00_66_2_tg_in
    {
        public static string L00_66_2_tg_in()
        {
            return "(w, w) (w, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 67 f(x) = ch(x)*ch(x) – sh(x)*sh(x) – 1
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_67_1_ch_sh", "f(x) = ch(x)*ch(x) – sh(x)*sh(x) – 1")]
    [EquivalentIntConstant(0)]
    public static class CL00_67_1_ch_sh
    {
        public static double L00_67_1_ch_sh(double x)
        {
            double Y1, Y2, X;
            Y1 = Math.Cosh(x);
            Y2 = Math.Sinh(x);
            X = Y1 * Y1 - Y2 * Y2 - 1;
            return X;
        }
    }
    
    /// <summary>
    /// Возвращает область определения тождества 67 f(x) = ch(x)*ch(x) – sh(x)*sh(x) – 1
    /// </summary>    
    /// <returns>(w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_67_1_ch_sh_in", "(0, w)")]
    public static class CL00_67_1_ch_sh_in
    {
        public static string L00_67_1_ch_sh_in()
        {
            return "(w, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 68 f(x) = th(x) – sh(x)/ch(x)
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_68_1_th_sh_ch", "f(x) = th(x) – sh(x)/ch(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_68_1_th_sh_ch
    {
        public static double L00_68_1_th_sh_ch(double x)
        {
            double Y1, Y2, Y3, X;
            Y1 = Math.Tanh(x);
            Y2 = Math.Cosh(x);
            Y3 = Math.Sinh(x);
#if DEBUG
            if (Math.Abs(Y2) <= double.Epsilon)
                throw new OpaqueException();
#endif
            X = Y1 - Y3 / Y2;
            return X;
        }
    }
   
    /// <summary>
    /// Возвращает область определения тождества 68 f(x) = th(x) – sh(x)/ch(x)
    /// </summary>    
    /// <returns>(w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_68_1_th_sh_ch_in", "(0, w)")]
    public static class CL00_68_1_th_sh_ch_in
    {
        public static string L00_68_1_th_sh_ch_in()
        {
            return "(w, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 69 f(x) = cth(x) – ch(x)/sh(x)
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_69_1_cth_sh_ch", "f(x) = cth(x) – ch(x)/sh(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_69_1_cth_sh_ch
    {
        public static double L00_69_1_cth_sh_ch(double x)
        {
            double Y1, Y2, Y3, X;
            Y1 = 1 / Math.Tanh(x);
            Y2 = Math.Cosh(x);
            Y3 = Math.Sinh(x);
#if DEBUG
            if (Math.Abs(Y3) <= double.Epsilon)
                throw new OpaqueException();
#endif
            X = Y1 - Y2 / Y3;
            return X;
        }
    }
 
    /// <summary>
    /// Возвращает область определения тождества 69 f(x) = cth(x) – ch(x)/sh(x)
    /// </summary>    
    /// <returns>(w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_69_1_cth_sh_ch_in", "(0, w)")]
    public static class CL00_69_1_cth_sh_ch_in
    {
        public static string L00_69_1_cth_sh_ch_in()
        {
            return "(w, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 70 f(x) = sch(x) – 1/ch(x)
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_70_1_sch_ch", "f(x) = sch(x) – 1/ch(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_70_1_sch_ch
    {
        public static double L00_70_1_sch_ch(double x)
        {
            double Y1, Y2, X;
            Y1 = 1 / Math.Cosh(x); //sch(x) нет в стандартной библиотеке, выражается только так
            Y2 = 1 / Math.Cosh(x);
            X = Y1 - Y2;
            return X;
        }
    }
   
    /// <summary>
    /// Возвращает область определения тождества 70 f(x) = sch(x) – 1/ch(x)
    /// </summary>    
    /// <returns>(w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_70_1_sch_ch_in", "(0, w)")]
    public static class CL00_70_1_sch_ch_in
    {
        public static string L00_70_1_sch_ch_in()
        {
            return "(w, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 71 f(x) = csch(x) – 1/sh(x)
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_71_1_sch_ch", "f(x) = csch(x) – 1/sh(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_71_1_sch_ch
    {
        public static double L00_71_1_sch_ch(double x)
        {
            double Y1, Y2, X;
            Y1 = 1 / Math.Sinh(x); //csch(x) нет в стандартной библиотеке, выражается только так
            Y2 = 1 / Math.Sinh(x);
            X = Y1 - Y2;
            return X;
        }
    }
    
    /// <summary>
    /// Возвращает область определения тождества 71 f(x) = csch(x) – 1/sh(x)
    /// </summary>    
    /// <returns>(w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_71_1_sch_ch_in", "(0, w)")]
    public static class CL00_71_1_sch_ch_in
    {
        public static string L00_71_1_sch_ch_in()
        {
            return "(w, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 72 f(x,y) = sh(x+y) – (sh(x)*ch(y) + ch(x)*sh(y))
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <param name="y">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_72_2_sh_ch", "f(x,y) = sh(x+y) – (sh(x)*ch(y) + ch(x)*sh(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_72_2_sh_ch
    {
        public static double L00_72_2_sh_ch(double x, double y)
        {
            double Y1, Y2, Y3, Y4, Y5, Y6, X;
            Y1 = x + y;
            Y2 = Math.Sinh(Y1);
            Y3 = Math.Sinh(x);
            Y4 = Math.Cosh(y);
            Y5 = Math.Cosh(x);
            Y6 = Math.Sinh(y);
            X = Y2 - (Y3 * Y4 + Y5 * Y6);
            return X;
        }
    }
   
    /// <summary>
    /// Возвращает область определения тождества 72 f(x,y) = sh(x+y) – (sh(x)*ch(y) + ch(x)*sh(y))
    /// </summary>    
    /// <returns>(w, w) (w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_72_2_sh_ch_in", "(0, w)")]
    public static class CL00_72_2_sh_ch_in
    {
        public static string L00_72_2_sh_ch_in()
        {
            return "(w, w) (w, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 73 f(x,y) = sh(x-y) – (sh(x)*ch(y) - ch(x)*sh(y))
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <param name="y">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_73_2_sh_ch", "f(x,y) = sh(x-y) – (sh(x)*ch(y) - ch(x)*sh(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_73_2_sh_ch
    {
        public static double L00_73_2_sh_ch(double x, double y)
        {
            double Y1, Y2, Y3, Y4, Y5, Y6, X;
            Y1 = x - y;
            Y2 = Math.Sinh(Y1);
            Y3 = Math.Sinh(x);
            Y4 = Math.Cosh(y);
            Y5 = Math.Cosh(x);
            Y6 = Math.Sinh(y);
            X = Y2 - (Y3 * Y4 - Y5 * Y6);
            return X;
        }
    }
    
    /// <summary>
    /// Возвращает область определения тождества 73 f(x,y) = sh(x-y) – (sh(x)*ch(y) - ch(x)*sh(y))
    /// </summary>    
    /// <returns>(w, w) (w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_73_2_sh_ch_in", "(0, w)")]
    public static class CL00_73_2_sh_ch_in
    {
        public static string L00_73_2_sh_ch_in()
        {
            return "(w, w) (w, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 74 f(x,y) = ch(x+y) – (ch(x)*ch(y) + sh(x)*sh(y))
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <param name="y">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_74_2_sh_ch", "f(x,y) = ch(x+y) – (ch(x)*ch(y) + sh(x)*sh(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_74_2_sh_ch
    {
        public static double L00_74_2_sh_ch(double x, double y)
        {
            double Y1, Y2, Y3, Y4, Y5, Y6, X;
            Y1 = x + y;
            Y2 = Math.Cosh(Y1);
            Y3 = Math.Cosh(x);
            Y4 = Math.Cosh(y);
            Y5 = Math.Sinh(x);
            Y6 = Math.Sinh(y);
            X = Y2 - (Y3 * Y4 + Y5 * Y6);
            return X;
        }
    }
    
    /// <summary>
    /// Возвращает область определения тождества 74 f(x,y) = ch(x+y) – (ch(x)*ch(y) + sh(x)*sh(y))
    /// </summary>    
    /// <returns>(w, w) (w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_74_2_sh_ch_in", "(0, w)")]
    public static class CL00_74_2_sh_ch_in
    {
        public static string L00_74_2_sh_ch_in()
        {
            return "(w, w) (w, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 75 f(x,y) = ch(x-y) – (ch(x)*ch(y) - sh(x)*sh(y))
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <param name="y">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_75_2_sh_ch", "f(x,y) = ch(x-y) – (ch(x)*ch(y) - sh(x)*sh(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_75_2_sh_ch
    {
        public static double L00_75_2_sh_ch(double x, double y)
        {
            double Y1, Y2, Y3, Y4, Y5, Y6, X;
            Y1 = x - y;
            Y2 = Math.Cosh(Y1);
            Y3 = Math.Cosh(x);
            Y4 = Math.Cosh(y);
            Y5 = Math.Sinh(x);
            Y6 = Math.Sinh(y);
            X = Y2 - (Y3 * Y4 - Y5 * Y6);
            return X;
        }
    }
    
    /// <summary>
    /// Возвращает область определения тождества 75 f(x,y) = ch(x-y) – (ch(x)*ch(y) - sh(x)*sh(y))
    /// </summary>    
    /// <returns>(w, w) (w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_75_2_sh_ch_in", "(0, w)")]
    public static class CL00_75_2_sh_ch_in
    {
        public static string L00_75_2_sh_ch_in()
        {
            return "(w, w) (w, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 76 f(x,y) = th(x+y) – (th(x) + th(y)/(1 + th(x)*th(y))
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <param name="y">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_76_2_th", "f(x,y) = th(x+y) – (th(x) + th(y)/(1 + th(x)*th(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_76_2_th
    {
        public static double L00_76_2_th(double x, double y)
        {
            double Y1, Y2, Y3, Y4, X;
            Y1 = x + y;
            Y2 = Math.Tanh(Y1);
            Y3 = Math.Tanh(x);
            Y4 = Math.Tanh(y);
#if DEBUG
            if (Math.Abs(1 + Y3 * Y4) <= double.Epsilon)
                throw new OpaqueException();
#endif
            X = Y2 - (Y3 + Y4) / (1 + Y3 * Y4);
            return X;
        }
    }
   
    /// <summary>
    /// Возвращает область определения тождества 76 f(x,y) = th(x+y) – (th(x) + th(y)/(1 + th(x)*th(y))
    /// </summary>    
    /// <returns>(w, w) (w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_76_2_th_in", "(0, w)")]
    public static class CL00_76_2_th_in
    {
        public static string L00_76_2_th_in()
        {
            return "(w, w) (w, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 77 f(x,y) = th(x-y) – (th(x) - th(y)/(1 - th(x)*th(y))
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <param name="y">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_77_2_th", "f(x,y) = th(x-y) – (th(x) - th(y)/(1 - th(x)*th(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_77_2_th
    {
        public static double L00_77_2_th(double x, double y)
        {
            double Y1, Y2, Y3, Y4, X;
            Y1 = x - y;
            Y2 = Math.Tanh(Y1);
            Y3 = Math.Tanh(x);
            Y4 = Math.Tanh(y);
#if DEBUG
            if (Math.Abs(1 - Y3 * Y4) <= double.Epsilon)
                throw new OpaqueException();
#endif
            X = Y2 - (Y3 - Y4) / (1 - Y3 * Y4);
            return X;
        }
    }
   
    /// <summary>
    /// Возвращает область определения тождества 77 f(x,y) = th(x-y) – (th(x) - th(y)/(1 - th(x)*th(y))
    /// </summary>    
    /// <returns>(w, w) (w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_77_2_th_in", "(0, w)")]
    public static class CL00_77_2_th_in
    {
        public static string L00_77_2_th_in()
        {
            return "(w, w) (w, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 78 f(x,y)  = cth(x+y) – (1 + cth(x)*cth(y))/(cth(x) + cth(y))
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <param name="y">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_78_2_cth", "f(x,y)  = cth(x+y) – (1 + cth(x)*cth(y))/(cth(x) + cth(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_78_2_cth
    {
        public static double L00_78_2_cth(double x, double y)
        {
            double Y1, Y2, Y3, Y4, X;
            Y1 = x + y;
            Y2 = Math.Tanh(Y1);
            Y3 = Math.Tanh(x);
            Y4 = Math.Tanh(y);
#if DEBUG
            if (Math.Abs(Y2) <= double.Epsilon || Math.Abs(Y3) <= double.Epsilon || Math.Abs(Y4) <= double.Epsilon || Math.Abs(1 / Y3 + 1 / Y4) <= double.Epsilon)
                throw new OpaqueException();
#endif
            X = 1 / Y2 - (1 + 1 / Y3 * 1 / Y4) / (1 / Y3 + 1 / Y4);
            return X;
        }
    }
   
    /// <summary>
    /// Возвращает область определения тождества 78 f(x,y)  = cth(x+y) – (1 + cth(x)*cth(y))/(cth(x) + cth(y))
    /// </summary>    
    /// <returns>(w, w) (w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_78_2_cth_in", "(0, w)")]
    public static class CL00_78_2_cth_in
    {
        public static string L00_78_2_cth_in()
        {
            return "(w, w) (w, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 79 f(x,y)  = cth(x-y) – (1 - cth(x)*cth(y))/(cth(x) - cth(y))
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <param name="y">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_79_2_cth", "f(x,y)  = cth(x-y) – (1 - cth(x)*cth(y))/(cth(x) - cth(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_79_2_cth
    {
        public static double L00_79_2_cth(double x, double y)
        {
            double Y1, Y2, Y3, Y4, X;
            Y1 = x - y;
            Y2 = Math.Tanh(Y1);
            Y3 = Math.Tanh(x);
            Y4 = Math.Tanh(y);
#if DEBUG
            if (Math.Abs(Y3 - Y4) <= double.Epsilon || Math.Abs(Y2) <= double.Epsilon)
                throw new OpaqueException();
#endif
            X = 1 / Y2 - (1 - 1 / Y3 * 1 / Y4) / (1 / Y3 - 1 / Y4);
            return X;
        }
    }
    
    /// <summary>
    /// Возвращает область определения тождества 79 f(x,y)  = cth(x-y) – (1 - cth(x)*cth(y))/(cth(x) - cth(y))
    /// </summary>    
    /// <returns>(w, w) (w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_79_2_cth_in", "(0, w)")]
    public static class CL00_79_2_cth_in
    {
        public static string L00_79_2_cth_in()
        {
            return "(w, w) (w, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 80 f(x,y) = 2*sh(x)*sh(y) – ch(x+y) + ch(x-y)
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <param name="y">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_80_2_sh_ch", "f(x,y) = 2*sh(x)*sh(y) – ch(x+y) + ch(x-y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_80_2_sh_ch
    {
        public static double L00_80_2_sh_ch(double x, double y)
        {
            double Y1, Y2, Y3, Y4, Y5, Y6, X;
            Y1 = Math.Sinh(x);
            Y2 = Math.Sinh(y);
            Y3 = x + y;
            Y4 = x - y;
            Y5 = Math.Cosh(Y3);
            Y6 = Math.Cosh(Y4);
            X = 2 * Y2 * Y1 - Y5 + Y6;
            return X;
        }
    }
    
    /// <summary>
    /// Возвращает область определения тождества 80 f(x,y) = 2*sh(x)*sh(y) – ch(x+y) + ch(x-y)
    /// </summary>    
    /// <returns>(w, w) (w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_80_2_sh_ch_in", "(0, w)")]
    public static class CL00_80_2_sh_ch_in
    {
        public static string L00_80_2_sh_ch_in()
        {
            return "(w, w) (w, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 81 f(x,y) = 2*ch(x)*ch(y) – ch(x+y) – ch(x-y)
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <param name="y">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_81_2_sh_ch", "f(x,y) = 2*ch(x)*ch(y) – ch(x+y) – ch(x-y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_81_2_sh_ch
    {
        public static double L00_81_2_sh_ch(double x, double y)
        {
            double Y1, Y2, Y3, Y4, Y5, Y6, X;
            Y1 = Math.Cosh(x);
            Y2 = Math.Cosh(y);
            Y3 = x + y;
            Y4 = x - y;
            Y5 = Math.Cosh(Y3);
            Y6 = Math.Cosh(Y4);
            X = 2 * Y2 * Y1 - Y5 - Y6;
            return X;
        }
    }
    
    /// <summary>
    /// Возвращает область определения тождества 81 f(x,y) = 2*ch(x)*ch(y) – ch(x+y) – ch(x-y)
    /// </summary>    
    /// <returns>(w, w) (w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_81_2_sh_ch_in", "(0, w)")]
    public static class CL00_81_2_sh_ch_in
    {
        public static string L00_81_2_sh_ch_in()
        {
            return "(w, w) (w, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 82 f(x,y) = 2*sh(x)*ch(y) – sh(x+y) – sh(x-y)
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <param name="y">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_82_2_sh_ch", "f(x,y) = 2*sh(x)*ch(y) – sh(x+y) – sh(x-y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_82_2_sh_ch
    {
        public static double L00_82_2_sh_ch(double x, double y)
        {
            double Y1, Y2, Y3, Y4, Y5, Y6, X;
            Y1 = Math.Sinh(x);
            Y2 = Math.Cosh(y);
            Y3 = x + y;
            Y4 = x - y;
            Y5 = Math.Sinh(Y3);
            Y6 = Math.Sinh(Y4);
            X = 2 * Y2 * Y1 - Y5 - Y6;
            return X;
        }
    }
   
    /// <summary>
    /// Возвращает область определения тождества 82 f(x,y) = 2*sh(x)*ch(y) – sh(x+y) – sh(x-y)
    /// </summary>    
    /// <returns>(w, w) (w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_82_2_sh_ch_in", "(0, w)")]
    public static class CL00_82_2_sh_ch_in
    {
        public static string L00_82_2_sh_ch_in()
        {
            return "(w, w) (w, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 83 f(x) = ch(2x) – sh(x)*sh(x) + ch(x)*ch(x)
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_83_1_sh_ch", "f(x) = ch(2x) – sh(x)*sh(x) - ch(x)*ch(x)")] //НЕВЕРНАЯ ФОРМУЛА, БЫЛ ПЛЮС
    [EquivalentIntConstant(0)]
    public static class CL00_83_1_sh_ch
    {
        public static double L00_83_1_sh_ch(double x)
        {
            double Y1, Y2, Y3, Y4, X;
            Y1 = 2 * x;
            Y2 = Math.Cosh(Y1);
            Y3 = Math.Sinh(x);
            Y4 = Math.Cosh(x);
            X = Y2 - Y3 * Y3 - Y4 * Y4; //ИСПРАВЛЕНО
            return X;
        }
    }
  
    /// <summary>
    /// Возвращает область определения тождества 83 f(x) = ch(2x) – sh(x)*sh(x) + ch(x)*ch(x)
    /// </summary>    
    /// <returns>(w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_83_1_sh_ch_in", "(0, w)")]
    public static class CL00_83_1_sh_ch_in
    {
        public static string L00_83_1_sh_ch_in()
        {
            return "(w, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 84 f(x) = cth(2x) – (1 + cth(x)*cth(x))/(2*cth(x))
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_84_1_cth", "f(x) = cth(2x) – (1 + cth(x)*cth(x))/(2*cth(x))")]
    [EquivalentIntConstant(0)]
    public static class CL00_84_1_cth
    {
        public static double L00_84_1_cth(double x)
        {
            double Y1, Y2, Y3, Y4, Y5, X;
            Y1 = 2 * x;
            Y2 = Math.Tanh(Y1);
            Y3 = Math.Tanh(x);
#if DEBUG
            if (Math.Abs(Y3) <= double.Epsilon || Math.Abs(Y2) <= double.Epsilon)
                throw new OpaqueException();
#endif
            Y4 = 1 / Y2;
            Y5 = 1 / Y3;
#if DEBUG
            if (Math.Abs(Y5) <= double.Epsilon)
                throw new OpaqueException();
#endif
            X = Y4 - (1 + Y5 * Y5) / (2 * Y5);
            return X;
        }
    }
   
    /// <summary>
    /// Возвращает область определения тождества 84 f(x) = cth(2x) – (1 + cth(x)*cth(x))/(2*cth(x))
    /// </summary>    
    /// <returns>(w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_84_1_cth_in", "(0, w)")]
    public static class CL00_84_1_cth_in
    {
        public static string L00_84_1_cth_in()
        {
            return "(w, w)";
        }
    }



    //##################################################################################################
    /// <summary>
    /// Реализует тождество 85 f(x) = sh(2x) – 2*sh(x)*ch(x)
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_85_1_sh_ch", "f(x) = sh(2x) – 2*sh(x)*ch(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_85_1_sh_ch
    {
        public static double L00_85_1_sh_ch(double x)
        {
            double Y1, Y2, Y3, Y4, X;
            Y1 = 2 * x;
            Y2 = Math.Sinh(Y1);
            Y3 = Math.Sinh(x);
            Y4 = Math.Cosh(x);
            X = Y2 - 2 * Y3 * Y4;
            return X;
        }
    }
    
    /// <summary>
    /// Возвращает область определения тождества 85 f(x) = sh(2x) – 2*sh(x)*ch(x)
    /// </summary>    
    /// <returns>(w, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_85_1_sh_ch_in", "(0, w)")]
    public static class CL00_85_1_sh_ch_in
    {
        public static string L00_85_1_sh_ch_in()
        {
            return "(w, w)";
        }
    }
}

