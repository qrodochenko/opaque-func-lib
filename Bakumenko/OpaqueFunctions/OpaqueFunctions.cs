using System;

namespace OpaqueFunctions
{
    /// <summary>
    /// Реализует 30.	f(x) = sin(arccos(x)) – (1 – x*x)^1/2
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// arcctg(x)=pi-arctg(x) 
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_30_1_sin_arccos", "f(x) = sin(arccos(x)) – (1 – x*x)^1/2")]
    [EquivalentIntConstant(0)]
    public static class CL00_30_1_sin_arccos
    {
        public static double L00_30_1_sin_arccos(double angle)
        {
            double X, sinX, sqrtX;
            sinX = Math.Sin(Math.Acos(angle));
            sqrtX = Math.Sqrt(1 - angle * angle);
            X = sinX - sqrtX;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 30.  f(x) = sin(arccos(x)) – (1 – x*x)^1/2
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_30_1_sin_arccos", "f(x) = sin(arccos(x)) – (1 – x*x)^1/2")]
    [EquivalentIntConstant(0)]
    public static class CL00_30_1_sin_arccos_in
    {
        public static string L00_30_1_sin_arccos_in()
        {
            string str = "(-1, 1)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 31.  f(x) = cos(arcsin(x)) – (1 – x*x)^1/2  
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// arcctg(x)=pi-arctg(x) 
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_31_1_cos_arcsin", "f(x) = cos(arcsin(x)) – (1 – x*x)^1/2")]
    [EquivalentIntConstant(0)]
    public static class CL00_31_1_cos_arcsin
    {
        public static double L00_31_1_cos_arcsin(double angle)
        {
            double X, sinX, sqrtX;
            sinX = Math.Cos(Math.Asin(angle));
            sqrtX = Math.Sqrt(1 - angle * angle);
            X = sinX - sqrtX;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 31.	f(x) = cos(arcsin(x)) – (1 – x*x)^1/2  
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_31_1_cos_arcsin", "f(x) = cos(arcsin(x)) – (1 – x*x)^1/2")]
    [EquivalentIntConstant(0)]
    public static class CL00_31_1_cos_arcsin_in
    {
        public static string L00_31_1_cos_arcsin_in()
        {
            string str = "(w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 32.	f(x) = sin(arctg(x)) – cos(arcctg(x))
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// arcctg(x)=pi-arctg(x) 
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_32_1_sin_arctg_cos_arcctg", "f(x) = sin(arctg(x)) – cos(arcctg(x))")]
    [EquivalentIntConstant(0)]
    public static class CL00_32_1_sin_arctg_cos_arcctg
    {
        public static double L00_32_1_sin_arctg_cos_arcctg(double angle)
        {
            double X, sinX, cosX;
            sinX = Math.Sin(Math.Atan(angle));
            cosX = Math.Cos(Math.PI - Math.Atan(angle));
            X = sinX - cosX;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 32.	f(x) = sin(arctg(x)) – cos(arcctg(x))
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_32_1_sin_arctg_cos_arcctg", "f(x) = sin(arctg(x)) – cos(arcctg(x))")]
    [EquivalentIntConstant(0)]
    public static class CL00_32_1_sin_arctg_cos_arcctg_in
    {
        public static string L00_32_1_sin_arctg_cos_arcctg_in()
        {
            string str = "(w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 33. f(x) = sin(arctg(x)) – x/((1+x*x)^1/2)
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_33_1_sin_arctg", "f(x) = sin(arctg(x)) – x/((1+x*x)^1/2)")]
    [EquivalentIntConstant(0)]
    public static class CL00_33_1_sin_arctg
    {
        public static double L00_33_1_sin_arctg(double angle)
        {
            double X, sinX, sqrtX;
            sinX = Math.Sin(Math.Atan(angle));
            sqrtX = angle / Math.Sqrt(1 + angle * angle);
            X = sinX - sqrtX;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 33.	f(x) = sin(arctg(x)) – x/((1+x*x)^1/2)
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_33_1_sin_arctg", "f(x) = sin(arctg(x)) – x/((1+x*x)^1/2)")]
    [EquivalentIntConstant(0)]
    public static class CL00_33_1_sin_arctg_in
    {
        public static string L00_33_1_sin_arctg_in()
        {
            string str = "(w, w)";
            return str;
        }
    }


    /// <summary>
    /// Реализует 34. f(x) = cos(arcctg(x))  – x/((1+x*x)^1/2)
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_34_1_cos_arcctg", "f(x) = cos(arcctg(x))  – x/((1+x*x)^1/2)")]
    [EquivalentIntConstant(0)]
    public static class CL00_34_1_cos_arcctg
    {
        public static double L00_34_1_cos_arcctg(double angle)
        {
            double X, cosX, sqrtX;
            cosX = Math.Cos(Math.PI - Math.Atan(angle));
            sqrtX = angle / Math.Sqrt(1 + angle * angle);
            X = cosX - sqrtX;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 34.	f(x) = cos(arcctg(x))  – x/((1+x*x)^1/2)
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_34_1_cos_arcctg", "f(x) = cos(arcctg(x))  – x/((1+x*x)^1/2)")]
    [EquivalentIntConstant(0)]
    public static class CL00_34_1_cos_arcctg_in
    {
        public static string L00_34_1_cos_arcctg_in()
        {
            string str = "(w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 35. f(x) = cos(arctg(x)) – 1/((1+x*x)^1/2)
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_35_1_cos_arctg", "f(x) = cos(arctg(x)) – 1/((1+x*x)^1/2)")]
    [EquivalentIntConstant(0)]
    public static class CL00_35_1_cos_arctg
    {
        public static double L00_35_1_cos_arctg(double angle)
        {
            double X, cosX, sqrtX;
            cosX = Math.Cos(Math.Atan(angle));
            sqrtX = 1 / Math.Sqrt(1 + angle * angle);
            X = cosX - sqrtX;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 35.	f(x) = cos(arctg(x)) – 1/((1+x*x)^1/2)
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_35_1_cos_arctg", "f(x) = cos(arctg(x)) – 1/((1+x*x)^1/2)")]
    [EquivalentIntConstant(0)]
    public static class CL00_35_1_cos_arctg_in
    {
        public static string L00_35_1_cos_arctg_in()
        {
            string str = "(w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 36. f(x) = sin(arcctg(x)) – 1/((1+x*x)^1/2)
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_36_1_sin_arcctg", "f(x) = sin(arcctg(x)) – 1/((1+x*x)^1/2)")]
    [EquivalentIntConstant(0)]
    public static class CL00_36_1_sin_arcctg
    {
        public static double L00_36_1_sin_arcctg(double angle)
        {
            double X, sinX, sqrtX;
            sinX = Math.Sin(Math.PI - Math.Atan(angle));
            sqrtX = 1 / Math.Sqrt(1 + angle * angle);
            X = sinX - sqrtX;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 36.	f(x) = sin(arcctg(x)) – 1/((1+x*x)^1/2)
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_36_1_sin_arcctg", "f(x) = sin(arcctg(x)) – 1/((1+x*x)^1/2)")]
    [EquivalentIntConstant(0)]
    public static class CL00_36_1_sin_arcctg_in
    {
        public static string L00_36_1_sin_arcctg_in()
        {
            string str = "(w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 37. f(x) = tg(arcsin(x)) – x/((1-x*x)^1/2)  
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_37_1_tg_arcsin", "f(x) = tg(arcsin(x)) – x/((1-x*x)^1/2)  ")]
    [EquivalentIntConstant(0)]
    public static class CL00_37_1_tg_arcsin
    {
        public static double L00_37_1_tg_arcsin(double angle)
        {
            double X, tgX, sqrtX;
            tgX = Math.Tan(Math.Asin(angle));
            sqrtX = angle / Math.Sqrt(1 - angle * angle);
            X = tgX - sqrtX;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 37.	f(x) = tg(arcsin(x)) – x/((1-x*x)^1/2)  
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_37_1_tg_arcsin", "f(x) = tg(arcsin(x)) – x/((1-x*x)^1/2)")]
    [EquivalentIntConstant(0)]
    public static class CL00_37_1_tg_arcsin_in
    {
        public static string L00_37_1_tg_arcsin_in()
        {
            string str = "(-1, 1)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 38. f(x) = ctg(arccos(x)) – x/((1-x*x)^1/2)  
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_38_1_ctg_arccos", "f(x) = ctg(arccos(x)) – x/((1-x*x)^1/2)")]
    [EquivalentIntConstant(0)]
    public static class CL00_38_1_ctg_arccos
    {
        public static double L00_38_1_ctg_arccos(double angle)
        {
            double X, ctgX, sqrtX;
            ctgX = 1 / Math.Tan(Math.Acos(angle));
            sqrtX = angle / Math.Sqrt(1 - angle * angle);
            X = ctgX - sqrtX;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 38.	f(x) = ctg(arccos(x)) – x/((1-x*x)^1/2)  
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_38_1_ctg_arccos", "f(x) = ctg(arccos(x)) – x/((1-x*x)^1/2)")]
    [EquivalentIntConstant(0)]
    public static class CL00_38_1_ctg_arccos_in
    {
        public static string L00_38_1_ctg_arccos_in()
        {
            string str = "(-1, 1)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 39. f(x) = tg(arccos(x)) – ((1-x*x)^1/2)/x  
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_39_1_tg_arccos", "f(x) = tg(arccos(x)) – ((1-x*x)^1/2)/x")]
    [EquivalentIntConstant(0)]
    public static class CL00_39_1_tg_arccos
    {
        public static double L00_39_1_tg_arccos(double angle)
        {
            double X, tgX, sqrtX;
            tgX = Math.Tan(Math.Acos(angle));
            sqrtX = Math.Sqrt(1 - angle * angle) / angle;
            X = tgX - sqrtX;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 39.	f(x) = tg(arccos(x)) – ((1-x*x)^1/2)/x  
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_39_1_tg_arccos", "f(x) = tg(arccos(x)) – ((1-x*x)^1/2)/x")]
    [EquivalentIntConstant(0)]
    public static class CL00_39_1_tg_arccos_in
    {
        public static string L00_39_1_tg_arccos_in()
        {
            string str = "(-1, 0)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 40. f(x) = ctg(arcsin(x)) – ((1-x*x)^1/2)/x  
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_40_1_ctg_arcsin", "f(x) = ctg(arcsin(x)) – ((1-x*x)^1/2)/x")]
    [EquivalentIntConstant(0)]
    public static class CL00_40_1_ctg_arcsin
    {
        public static double L00_40_1_ctg_arcsin(double angle)
        {
            double X, sinX, sqrtX;
            sinX = 1 / Math.Tan(Math.Asin(angle));
            sqrtX = Math.Sqrt(1 - angle * angle) / angle;
            X = sinX - sqrtX;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 40.	f(x) = ctg(arcsin(x)) – ((1-x*x)^1/2)/x  
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_40_1_ctg_arcsin", "f(x) = ctg(arcsin(x)) – ((1-x*x)^1/2)/x")]
    [EquivalentIntConstant(0)]
    public static class CL00_40_1_ctg_arcsin_in
    {
        public static string L00_40_1_ctg_arcsin_in()
        {
            string str = "(-1, 0)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 41. f(x) = sin(arcctg(x)) – cos(arctg(x))  
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_41_1_sin_arcctg_cos_arctg", "f(x) = sin(arcctg(x)) – cos(arctg(x))")]
    [EquivalentIntConstant(0)]
    public static class CL00_41_1_sin_arcctg_cos_arctg
    {
        public static double L00_41_1_sin_arcctg_cos_arctg(double angle)
        {
            double X, sinX, cosX;
            sinX = Math.Sin(Math.PI - Math.Atan(angle));
            cosX = Math.Cos(Math.Tan(angle));
            X = sinX - cosX;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 41.	f(x) = sin(arcctg(x)) – cos(arctg(x))
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_41_1_sin_arcctg_cos_arctg", "f(x) = sin(arcctg(x)) – cos(arctg(x))")]
    [EquivalentIntConstant(0)]
    public static class CL00_41_1_sin_arcctg_cos_arctg_in
    {
        public static string L00_41_1_sin_arcctg_cos_arctg_in()
        {
            string str = "(w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 42. f(x) = tg(arctg(x)) – x  
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_42_1_tg_arctg", "f(x) = tg(arctg(x)) – x")]
    [EquivalentIntConstant(0)]
    public static class CL00_42_1_tg_arctg
    {
        public static double L00_42_1_tg_arctg(double angle)
        {
            double X, tgX;
            tgX = Math.Tan(Math.Atan(angle));
            X = tgX - angle;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 42.	f(x) = tg(arctg(x)) – x
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_42_1_tg_arctg", "f(x) = tg(arctg(x)) – x")]
    [EquivalentIntConstant(0)]
    public static class CL00_42_1_tg_arctg_in
    {
        public static string L00_42_1_tg_arctg_in()
        {
            string str = "(w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 43. f(x) = tg(arcsin(x)) – ctg(arccos(x))    
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_43_1_tg_arcsin_ctg_arccos", "f(x) = tg(arcsin(x)) – ctg(arccos(x))")]
    [EquivalentIntConstant(0)]
    public static class CL00_43_1_tg_arcsin_ctg_arccos
    {
        public static double L00_43_1_tg_arcsin_ctg_arccos(double angle)
        {
            double X, tgX, ctgX;
            tgX = Math.Tan(Math.Asin(angle));
            ctgX = 1 / Math.Tan(Math.Acos(angle));
            X = tgX - ctgX;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 43.	f(x) = tg(arcsin(x)) – ctg(arccos(x))  
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_43_1_tg_arcsin_ctg_arccos", "f(x) = tg(arcsin(x)) – ctg(arccos(x))")]
    [EquivalentIntConstant(0)]
    public static class CL00_43_1_tg_arcsin_ctg_arccos_in
    {
        public static string L00_43_1_tg_arcsin_ctg_arccos_in()
        {
            string str = "(-1, 1)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 44. f(x) = tg(arccos(x)) – ctg(arcsin(x))    
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_44_1_tg_arccos_ctg_arcsin", "f(x) = tg(arccos(x)) – ctg(arcsin(x))")]
    [EquivalentIntConstant(0)]
    public static class CL00_44_1_tg_arccos_ctg_arcsin
    {
        public static double L00_44_1_tg_arccos_ctg_arcsin(double angle)
        {
            double X, tgX, ctgX;
            tgX = Math.Tan(Math.Acos(angle));
            ctgX = 1 / Math.Tan(Math.Asin(angle));
            X = tgX - ctgX;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 44.	f(x) = tg(arccos(x)) – ctg(arcsin(x))  
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_44_1_tg_arccos_ctg_arcsin", "f(x) = tg(arccos(x)) – ctg(arcsin(x))")]
    [EquivalentIntConstant(0)]
    public static class CL00_44_1_tg_arccos_ctg_arcsin_in
    {
        public static string L00_44_1_tg_arccos_ctg_arcsin_in()
        {
            string str = "(-1, 0)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 45. f(x) = ctg(arcctg(x)) – x 
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_45_1_ctg_arcctg", "f(x) = ctg(arcctg(x)) – x")]
    [EquivalentIntConstant(0)]
    public static class CL00_45_1_ctg_arcctg
    {
        public static double L00_45_1_ctg_arcctg(double angle)
        {
            double X, ctgX;
            ctgX = 1 / Math.Tan(Math.PI - Math.Atan(angle));
            X = ctgX - angle;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 45.	f(x) = ctg(arcctg(x)) – x
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_45_1_ctg_arcctg", "f(x) = ctg(arcctg(x)) – x")]
    [EquivalentIntConstant(0)]
    public static class CL00_45_1_ctg_arcctg_in
    {
        public static string L00_45_1_ctg_arcctg_in()
        {
            string str = "(w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 46. f(x) = arcsin(sin(x)) – x    
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_46_1_arcsin_sin", "f(x) = arcsin(sin(x)) – x")]
    [EquivalentIntConstant(0)]
    public static class CL00_46_1_arcsin_sin
    {
        public static double L00_46_1_arcsin_sin(double angle)
        {
            double X, arcsinX;
            arcsinX = Math.Asin(Math.Sin(angle));
            X = arcsinX - angle;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 46.	f(x) = arcsin(sin(x)) – x  
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_46_1_arcsin_sin", "f(x) = arcsin(sin(x)) – x")]
    [EquivalentIntConstant(0)]
    public static class CL00_46_1_arcsin_sin_in
    {
        public static string L00_46_1_arcsin_sin_in()
        {
            string str = "(-Pi / 2, Pi / 2)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 47. f(x) = arccos(cos(x)) – x    
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_47_1_arccos_cos", "f(x) = arccos(cos(x)) – x")]
    [EquivalentIntConstant(0)]
    public static class CL00_47_1_arccos_cos
    {
        public static double L00_47_1_arccos_cos(double angle)
        {
            double X, arccosX;
            arccosX = Math.Acos(Math.Cos(angle));
            X = arccosX - angle;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 47.	f(x) = arccos(cos(x)) – x  
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_47_1_arccos_cos", "f(x) = arccos(cos(x)) – x")]
    [EquivalentIntConstant(0)]
    public static class CL00_47_1_arccos_cos_in
    {
        public static string L00_47_1_arccos_cos_in()
        {
            string str = "(0, Pi)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 48. f(x) = arctg(tg(x)) – x  
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_48_1_arctg_tg", "f(x) = arctg(tg(x)) – x")]
    [EquivalentIntConstant(0)]
    public static class CL00_48_1_arctg_tg
    {
        public static double L00_48_1_arctg_tg(double angle)
        {
            double X, arctgX;
            arctgX = Math.Atan(Math.Tan(angle));
            X = arctgX - angle;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 48.	f(x) = arctg(tg(x)) – x
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_48_1_arctg_tg", "f(x) = arctg(tg(x)) – x")]
    [EquivalentIntConstant(0)]
    public static class CL00_48_1_arctg_tg_in
    {
        public static string L00_48_1_arctg_tg_in()
        {
            string str = "(-Pi / 2, Pi / 2)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 49. f(x) = arcctg(ctg(x)) – x  
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_49_1_arcctg_ctg", "f(x) = arcctg(ctg(x)) – x")]
    [EquivalentIntConstant(0)]
    public static class CL00_49_1_arcctg_ctg
    {
        public static double L00_49_1_arcctg_ctg(double angle)
        {
            double X, arcctgX;
            arcctgX = Math.PI - Math.Atan(1 / Math.Tan(angle));
            X = arcctgX - angle;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 49.	f(x) = arcctg(ctg(x)) – x
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_49_1_arcctg_ctg", "f(x) = arcctg(ctg(x)) – x")]
    [EquivalentIntConstant(0)]
    public static class CL00_49_1_arcctg_ctg_in
    {
        public static string L00_49_1_arcctg_ctg_in()
        {
            string str = "(-1, 1)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 50. f(x) = arctg(x) + arcctg(x) – π/2 
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_50_1_arctg_arcctg", "f(x) = arctg(x) + arcctg(x) – π/2")]
    [EquivalentIntConstant(0)]
    public static class CL00_50_1_arctg_arcctg
    {
        public static double L00_50_1_arctg_arcctg(double angle)
        {
            double X;
            X = Math.Atan(angle) + (Math.PI - Math.Atan(angle)) - Math.PI / 2;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 50.	f(x) = arctg(x) + arcctg(x) – π/2
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_50_1_arctg_arcctg", "f(x) = arctg(x) + arcctg(x) – π/2")]
    [EquivalentIntConstant(0)]
    public static class CL00_50_1_arctg_arcctg_in
    {
        public static string L00_50_1_arctg_arcctg_in()
        {
            string str = "(w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 51. f(x) = arctg(x/(1-x*x)^1/2) – arcsin(x) 
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_51_1_arctg_arcsin", "f(x) = arctg(x/(1-x*x)^1/2) – arcsin(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_51_1_arctg_arcsin
    {
        public static double L00_51_1_arctg_arcsin(double angle)
        {
            double X, arctgX;
            arctgX = Math.Atan(angle / Math.Sqrt(1 - angle * angle));   
            X = arctgX - Math.Asin(angle);
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 51.	f(x) = arctg(x/(1-x*x)^1/2) – arcsin(x)
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_51_1_arctg_arcsin", "f(x) = arctg(x/(1-x*x)^1/2) – arcsin(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_51_1_arctg_arcsin_in
    {
        public static string L00_51_1_arctg_arcsin_in()
        {
            string str = "(-1, 1)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 52. f(x) = arcsin(x) – arccos((1-x*x)^1/2) 
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_52_1_arcsin_arccos", "f(x) = arcsin(x) – arccos((1-x*x)^1/2)")]
    [EquivalentIntConstant(0)]
    public static class CL00_52_1_arcsin_arccos
    {
        public static double L00_52_1_arcsin_arccos(double angle)
        {
            double X, arccosX;
            arccosX = Math.Acos(Math.Sqrt(1 - angle * angle));
            X = Math.Asin(angle) - arccosX;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 52.	f(x) = arcsin(x) – arccos((1-x*x)^1/2)
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_52_1_arcsin_arccos", "f(x) = arcsin(x) – arccos((1-x*x)^1/2)")]
    [EquivalentIntConstant(0)]
    public static class CL00_52_1_arcsin_arccos_in
    {
        public static string L00_52_1_arcsin_arccos_in()
        {
            string str = "(0, 1)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 53. f(x) = arcctg(((1-x*x)^1/2)/x) – arcsin(x) 
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_53_1_arcctg_arcsin", "f(x) = arcctg(((1-x*x)^1/2)/x) – arcsin(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_53_1_arcctg_arcsin
    {
        public static double L00_53_1_arcctg_arcsin(double angle)
        {
            double X, arcctgX;
            arcctgX = Math.PI - Math.Atan(Math.Sqrt(1 - angle * angle) / angle);
            X = arcctgX -Math.Asin(angle);
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 53.	f(x) = arcctg(((1-x*x)^1/2)/x) – arcsin(x)
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_53_1_arcctg_arcsin", "f(x) = arcctg(((1-x*x)^1/2)/x) – arcsin(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_53_1_arcctg_arcsin_in
    {
        public static string L00_53_1_arcctg_arcsin_in()
        {
            string str = "(0, 1)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 54. f(x) = arccos((1-x*x)^1/2) - arcctg(((1-x*x)^1/2)/x) 
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_54_1_arccos_arcctg", "f(x) = arccos((1-x*x)^1/2) - arcctg(((1-x*x)^1/2)/x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_54_1_arccos_arcctg
    {
        public static double L00_54_1_arccos_arcctg(double angle)
        {
            double X, arccosX, arcctgX;
            arccosX = Math.Acos(Math.Sqrt(1 - angle * angle));
            arcctgX = Math.PI - Math.Atan(Math.Sqrt(1 - angle * angle) / angle);
            X = arccosX - arcctgX;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 54.	f(x) = arccos((1-x*x)^1/2) - arcctg(((1-x*x)^1/2)/x) 
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_54_1_arccos_arcctg", "f(x) = arccos((1-x*x)^1/2) - arcctg(((1-x*x)^1/2)/x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_54_1_arccos_arcctg_in
    {
        public static string L00_54_1_arccos_arcctg_in()
        {
            string str = "(0, 1)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 55. f(x) = arccos(x) – arcctg(x/((1-x*x)^1/2))
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_55_1_arccos_arcctg", "f(x) = arccos(x) – arcctg(x/((1-x*x)^1/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_55_1_arccos_arcctg
    {
        public static double L00_55_1_arccos_arcctg(double angle)
        {
            double X, arcctgX;
            arcctgX = Math.PI - Math.Atan(angle / Math.Sqrt(1 - angle * angle));
            X = Math.Acos(angle) - arcctgX;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 55.	f(x) = arccos(x) – arcctg(x/((1-x*x)^1/2))
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_55_1_arccos_arcctg", "f(x) = arccos(x) – arcctg(x/((1-x*x)^1/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_55_1_arccos_arcctg_in
    {
        public static string L00_55_1_arccos_arcctg_in()
        {
            string str = "(-1, 1)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 56. f(x) = arccos(x) – arctg(((1-x*x)^1/2)/x) 
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_56_1_arccos_arctg", "f(x) = arccos(x) – arctg(((1-x*x)^1/2)/x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_56_1_arccos_arctg
    {
        public static double L00_56_1_arccos_arctg(double angle)
        {
            double X, arctgX;
            arctgX = Math.Atan(Math.Sqrt(1 - angle * angle) / angle);
            X = Math.Acos(angle) - arctgX;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 56.	f(x) = arccos(x) – arctg(((1-x*x)^1/2)/x)
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_56_1_arccos_arctg", "f(x) = arccos(x) – arctg(((1-x*x)^1/2)/x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_56_1_arccos_arctg_in
    {
        public static string L00_56_1_arccos_arctg_in()
        {
            string str = "(0, 1)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 57. f(x) = arctg(x) – arcsin(x/((1+x*x)^1/2)) 
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_57_1_arctg_arcsin", "f(x) = arctg(x) – arcsin(x/((1+x*x)^1/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_57_1_arctg_arcsin
    {
        public static double L00_57_1_arctg_arcsin(double angle)
        {
            double X, arcsinX;
            arcsinX = Math.Asin(angle / Math.Sqrt(1 + angle * angle));
            X = Math.Atan(angle) - arcsinX;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 57.	f(x) = arctg(x) – arcsin(x/((1+x*x)^1/2))
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_57_1_arctg_arcsin", "f(x) = arctg(x) – arcsin(x/((1+x*x)^1/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_57_1_arctg_arcsin_in
    {
        public static string L00_57_1_arctg_arcsin_in()
        {
            string str = "(w, w)";
            return str;
        }
    }
}

