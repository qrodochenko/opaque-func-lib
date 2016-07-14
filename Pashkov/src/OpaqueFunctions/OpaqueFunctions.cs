#define _Debug

using System;
namespace OpaqueFunctions
{
    /// <summary>
    /// Реализует тождество tg(x) - sin(x)/cos(x) = 0,
    /// где угол Х задаётся параметром в радианах <paramref name="angle"/>.
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle"> Угол в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_2_1_tg_sin_cos", "tg - sin/cos = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_2_1
    {
        public static double L00_2_1_tg_sin_cos(double angle)
        {
            #if _Debug
            if (Math.Cos(angle) == 0) 
                throw new Exception("Значение не принадлежит области определения!");
            #endif

            double Y1 = Math.Sin(angle);
            double Y2 = Math.Cos(angle);
            double Y3 = Math.Tan(angle);

            double X = Y3 - Y1 / Y2;
            
            return X;

        }

        public static string L00_2_1_tg_sin_cos_in() 
        {
            return "(-Pi/2, Pi/2)";
        }
    }

    /// <summary>
    /// Реализует тождество ctg(x) - cos(x)/sin(x) = 0,
    /// где угол Х задаётся параметром в радианах <paramref name="angle"/>.
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle"> Угол в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_3_1_ctg_cos_sin", "ctg - cos/sin = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_3_1
    {
        public static double L00_3_1_ctg_cos_sin(double angle)
        {
            #if _Debug
            if (Math.Sin(angle) == 0)
                throw new Exception("Значение не принадлежит области определения!");
            #endif

            double Y1 = Math.Cos(angle);
            double Y2 = Math.Sin(angle);
            double Y3 = 1/Math.Tan(angle);

            double X = Y3 - Y1 / Y2;
            
            return X;

        }

        public static string L00_3_1_ctg_cos_sin_in() 
        {
            return "(0, Pi)";
        }
    }


    /// <summary>
    /// Реализует тождество sec(x) - 1/cos(x)= 0,
    /// где угол Х задаётся параметром в радианах <paramref name="angle"/>.
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle"> Угол в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_4_1_sec_cos", "sec - 1/cos = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_4_1
    {
        public static double L00_4_1_sec_cos(double angle)
        {
            #if _Debug
            if (Math.Cos(angle) == 0)
                throw new Exception("Значение не принадлежит области определения!");
            #endif

            double Y1 = Math.Cos(angle);
            double Y2 = 1/Math.Cos(angle);

            double X = Y2 - 1 / Y1;
            
            return X;

        }

        public static string L00_4_1_sec_cos_in()
        {
            return "(-Pi/2, Pi/2)";
        }
    }

    /// <summary>
    /// Реализует тождество cosec(x) - 1/sin(x)= 0,
    /// где угол Х задаётся параметром в радианах <paramref name="angle"/>.
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle"> Угол в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_5_1_cosec_sin", "cosec - 1/sin = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_5_1
    {
        public static double L00_5_1_cosec_sin(double angle)
        {
            #if _Debug
            if (Math.Sin(angle) == 0)
                throw new Exception("Значение не принадлежит области определения!");
            #endif

            double Y1 = Math.Sin(angle);
            double Y2 = 1 / Math.Sin(angle);

            double X = Y2 - 1 / Y1;
            
            return X;

        }

        public static string L00_5_1_cosec_sin_in()
        {
            return "(0, Pi)";
        }
    }

    /// <summary>
    /// Реализует тождество sin(x+y) – (sin (x)*cos(y) + cos(x)*sin(y))= 0,
    /// где углы Х,Y задаются параметрами в радианах <paramref name="angle1"/>, <paramref name="angle2"/>.
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle1">, <paramref name="angle2"/> Уголы в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_6_2_sin_cos", "sin(x+y) – (sin (x)*cos(y) + cos(x)*sin(y)) = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_6_2
    {
        public static double L00_6_2_sin_cos(double angle1, double angle2)
        {
            double Y1 = Math.Sin(angle1 + angle2);
            double Y2 = Math.Sin(angle1);
            double Y3 = Math.Cos(angle2);
            double Y4 = Math.Cos(angle1);
            double Y5 = Math.Sin(angle2);

            double X = Y1 - (Y2 * Y3 + Y4 * Y5);
            
            return X;

        }

        public static string L00_6_2_sin_cos_in()
        {
            return "(w, w) (w, w)";
        }
    }

    /// <summary>
    /// Реализует тождество sin(x-y) – (sin (x)*cos(y) - cos(x)*sin(y)) = 0,
    /// где углы Х,Y задаются параметрами в радианах <paramref name="angle1"/>, <paramref name="angle2"/>.
    /// Результатом функции является целое число X 
    /// </summary>
    /// <param name="angle1">, <paramref name="angle2"/> Уголы в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_7_2_sin_cos", "sin(x-y) – (sin (x)*cos(y) - cos(x)*sin(y)) = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_7_2
    {
        public static double L00_7_2_sin_cos(double angle1, double angle2)
        {
            double Y1 = Math.Sin(angle1 - angle2);
            double Y2 = Math.Sin(angle1);
            double Y3 = Math.Cos(angle2);
            double Y4 = Math.Cos(angle1);
            double Y5 = Math.Sin(angle2);

            double X = Y1 - (Y2 * Y3 - Y4 * Y5);
            
            return X;

        }

        public static string L00_7_2_sin_cos_in()
        {
            return "(w, w) (w, w)";
        }
    }

    /// <summary>
    /// Реализует тождество sin(x-y) – (sin (x)*cos(y) - cos(x)*sin(y)) = 0,
    /// где углы Х,Y задаются параметрами в радианах <paramref name="angle1"/>, <paramref name="angle2"/>.
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle1">, <paramref name="angle2"/> Уголы в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_8_2_sin_cos", "cos(x+y) – cos(x)*cos(y) + sin(x)*sin(y) = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_8_2
    {
        public static double L00_8_2_sin_cos(double angle1, double angle2)
        {
            double Y1 = Math.Cos(angle1 + angle2);
            double Y2 = Math.Cos(angle1);
            double Y3 = Math.Cos(angle2);
            double Y4 = Math.Sin(angle1);
            double Y5 = Math.Sin(angle2);

            double X = Y1 - Y2 * Y3 + Y4 * Y5;
            
            return X;

        }

        public static string L00_8_2_sin_cos_in()
        {
            return "(w, w) (w, w)";
        }
    }

    /// <summary>
    /// Реализует тождество cos(x-y) – cos(x)*cos(y) - sin(x)*sin(y) = 0,
    /// где углы Х,Y задаются параметрами в радианах <paramref name="angle1"/>, <paramref name="angle2"/>.
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle1">, <paramref name="angle2"/> Уголы в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_9_2_cos_sin", "cos(x-y) – cos(x)*cos(y) - sin(x)*sin(y) = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_9_2
    {
        public static double L00_9_2_cos_sin(double angle1, double angle2)
        {
            double Y1 = Math.Cos(angle1 - angle2);
            double Y2 = Math.Cos(angle1);
            double Y3 = Math.Cos(angle2);
            double Y4 = Math.Sin(angle1);
            double Y5 = Math.Sin(angle2);

            double X = Y1 - Y2 * Y3 - Y4 * Y5;
            
            return X;

        }

        public static string L00_9_2_cos_sin_in()
        {
            return "(w, w) (w, w)";
        }
    }

    /// <summary>
    /// Реализует тождество tg(x+y) – (tg(x)+tg(y))/(1-tg(x)*tg(y)) = 0,
    /// где углы Х,Y задаются параметрами в радианах <paramref name="angle1"/>, <paramref name="angle2"/>.
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle1">, <paramref name="angle2"/> Уголы в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_10_2_tg", "tg(x+y) – (tg(x)+tg(y))/(1-tg(x)*tg(y)) = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_10_2
    {
        public static double L00_10_2_tg(double angle1, double angle2)
        {
            #if _Debug
            if (Math.Cos(angle1) == 0 || Math.Cos(angle2) == 0 || Math.Cos(angle1+angle2) == 0 || Math.Tan(angle1) * Math.Tan(angle1) == 1)
                throw new Exception("Значение не принадлежит области определения!");
            #endif

            double Y1 = Math.Tan(angle1 + angle2);
            double Y2 = Math.Tan(angle1);
            double Y3 = Math.Tan(angle2);
            double Y4 = Math.Tan(angle1);
            double Y5 = Math.Tan(angle2);

            double X = Y1 - (Y2 + Y3) / (1 - Y4 * Y5);
            
            return X;

        }

        public static string L00_10_2_tg_in()
        {
            return "(-Pi/4, Pi/4) (-Pi/4, Pi/4)";
        }
    }

    /// <summary>
    /// Реализует тождество tg(x-y) – (tg(x)-tg(y))/(1+tg(x)*tg(y)) = 0,
    /// где углы Х,Y задаются параметрами в радианах <paramref name="angle1"/>, <paramref name="angle2"/>.
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle1">, <paramref name="angle2"/> Уголы в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_11_2_tg", "tg(x-y) – (tg(x)-tg(y))/(1+tg(x)*tg(y)) = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_11_2
    {
        public static double L00_11_2_tg(double angle1, double angle2)
        {
            #if _Debug
            if ((Math.Cos(angle1) == 0) || (Math.Cos(angle2) == 0) || (Math.Cos(angle1 - angle2) == 0) || (Math.Tan(angle1) * Math.Tan(angle1) == -1))
                throw new Exception("Значение не принадлежит области определения!");
            #endif

            double Y1 = Math.Tan(angle1 - angle2);
            double Y2 = Math.Tan(angle1);
            double Y3 = Math.Tan(angle2);
            double Y4 = Math.Tan(angle1);
            double Y5 = Math.Tan(angle2);

            double X = Y1 - (Y2 - Y3) / (1 + Y4 * Y5);
            
            return X;

        }

        public static string L00_11_2_tg_in() 
        {
            return "(-Pi/4, Pi/4) (-Pi/4, Pi/4)";
        }
    }

    /// <summary>
    /// Реализует тождество ctg(x+y) – (ctg(x)*ctg(y) - 1)/(ctg(y)+ctg(x)) = 0,
    /// где углы Х,Y задаются параметрами в радианах <paramref name="angle1"/>, <paramref name="angle2"/>.
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle1">, <paramref name="angle2"/> Уголы в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_12_2_ctg", "ctg(x+y) – (ctg(x)*ctg(y) - 1)/(ctg(y)+ctg(x)) = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_12_2
    {
        public static double L00_12_2_ctg(double angle1, double angle2)
        {
            #if _Debug
            if ((Math.Sin(angle1) == 0) || (Math.Sin(angle2) == 0) || (Math.Sin(angle1 + angle2) == 0) || (1 / Math.Tan(angle2) + 1 / Math.Tan(angle1) == 0))
                throw new Exception("Значение не принадлежит области определения!");
            #endif

            double Y1 = 1 / Math.Tan(angle1 + angle2);
            double Y2 = 1 / Math.Tan(angle1);
            double Y3 = 1 / Math.Tan(angle2);
            double Y4 = 1 / Math.Tan(angle2);
            double Y5 = 1 / Math.Tan(angle1);

            double X = Y1 - (Y2 * Y3 - 1) / (Y4 + Y5);
            
            return X;

        }

        public static string L00_12_2_ctg_in() 
        {
            return "(0, Pi/2) (0, Pi/2)";
        }
    }

    /// <summary>
    /// Реализует тождество ctg(x-y) – (ctg(x)*ctg(y) + 1)/(ctg(y)-ctg(x)) = 0,
    /// где углы Х,Y задаются параметрами в радианах <paramref name="angle1"/>, <paramref name="angle2"/>.
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle1">, <paramref name="angle2"/> Уголы в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_13_2_ctg", "ctg(x-y) – (ctg(x)*ctg(y) + 1)/(ctg(y)-ctg(x)) = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_13_2
    {
        public static double L00_13_2_ctg(double angle1, double angle2)
        {
            #if _Debug
            if ((Math.Sin(angle1) == 0) || (Math.Sin(angle2) == 0) || (Math.Sin(angle1 - angle2) == 0) || (1 / Math.Tan(angle2) == 1 / Math.Tan(angle1)))
                throw new Exception("Значение не принадлежит области определения!");
            #endif

            double Y1 = 1 / Math.Tan(angle1 - angle2);
            double Y2 = 1 / Math.Tan(angle1);
            double Y3 = 1 / Math.Tan(angle2);
            double Y4 = 1 / Math.Tan(angle2);
            double Y5 = 1 / Math.Tan(angle1);

            double X = Y1 - (Y2 * Y3 + 1) / (Y4 - Y5);
            
            return X;

        }

        public static string L00_13_2_ctg_in()
        {
            return "(0, Pi/2) (0, Pi/2)";
        }
    }

    /// <summary>
    /// Реализует тождество 2*sin(x)*sin(y) – cos(x-y) + cos(x+y) = 0,
    /// где углы Х,Y задаются параметрами в радианах <paramref name="angle1"/>, <paramref name="angle2"/>.
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle1">, <paramref name="angle2"/> Уголы в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_14_2_sin_cos", "2*sin(x)*sin(y) – cos(x-y) + cos(x+y) = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_14_2
    {
        public static double L00_14_2_sin_cos(double angle1, double angle2)
        {
            double Y1 = Math.Sin(angle1);
            double Y2 = Math.Sin(angle2);
            double Y3 = Math.Cos(angle1 - angle2);
            double Y4 = Math.Cos(angle1 + angle2);

            double X = 2 * Y1 * Y2 - Y3 + Y4;
            
            return X;

        }

        public static string L00_14_2_sin_cos_in()
        {
            return "(w, w) (w, w)";
        }
    }

    /// <summary>
    /// Реализует тождество 2*cos(x)*cos(y) – cos(x-y) - cos(x+y) = 0,
    /// где углы Х,Y задаются параметрами в радианах <paramref name="angle1"/>, <paramref name="angle2"/>.
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle1">, <paramref name="angle2"/> Уголы в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_15_2_cos", "2*cos(x)*cos(y) – cos(x-y) - cos(x+y) = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_15_2
    {
        public static double L00_15_2_cos(double angle1, double angle2)
        {
            double Y1 = Math.Cos(angle1);
            double Y2 = Math.Cos(angle2);
            double Y3 = Math.Cos(angle1 - angle2);
            double Y4 = Math.Cos(angle1 + angle2);

            double X = 2 * Y1 * Y2 - Y3 - Y4;
            
            return X;

        }

        public static string L00_15_2_cos_in()
        {
            return "(w, w) (w, w)";
        }
    }
    
    /// <summary>
    /// Реализует тождество 2*sin(x)*cos(y) – sin(x-y) – sin(x+y) = 0,
    /// где углы Х,Y задаются параметрами в радианах <paramref name="angle1"/>, <paramref name="angle2"/>.
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle1">, <paramref name="angle2"/> Уголы в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_16_2_cos", "2*sin(x)*cos(y) – sin(x-y) – sin(x+y) = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_16_2
    {
        public static double L00_16_2_sin(double angle1, double angle2)
        {
            double Y1 = Math.Sin(angle1);
            double Y2 = Math.Cos(angle2);
            double Y3 = Math.Sin(angle1 - angle2);
            double Y4 = Math.Sin(angle1 + angle2);

            double X = 2 * Y1 * Y2 - Y3 - Y4;
            
            return X;

        }

        public static string L00_16_2_sin_in()
        {
            return "(w, w) (w, w)";
        }
    }

    /// <summary>
    /// Реализует тождество sin(x) + sin(y) – 2*sin((x+y)/2)*cos((x-y)/2) = 0,
    /// где углы Х,Y задаются параметрами в радианах <paramref name="angle1"/>, <paramref name="angle2"/>.
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle1">, <paramref name="angle2"/> Уголы в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_17_2_sin_cos", "sin(x) + sin(y) – 2*sin((x+y)/2)*cos((x-y)/2) = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_17_2
    {
        public static double L00_17_2_sin_cos(double angle1, double angle2)
        {
            double Y1 = Math.Sin(angle1);
            double Y2 = Math.Sin(angle2);
            double Y3 = Math.Sin((angle1 + angle2) / 2);
            double Y4 = Math.Cos((angle1 - angle2) / 2);

            double X = Y1 + Y2 - 2 * Y3 * Y4;
           
            return X;

        }

        public static string L00_17_2_sin_cos_in()
        {
            return "(w, w) (w, w)";
        }
    }

    
    /// <summary>
    /// Реализует тождество sin(x) - sin(y) – 2*sin((x-y)/2)*cos((x+y)/2) = 0,
    /// где углы Х,Y задаются параметрами в радианах <paramref name="angle1"/>, <paramref name="angle2"/>.
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle1">, <paramref name="angle2"/> Уголы в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_18_2_sin_cos", "sin(x) - sin(y) – 2*sin((x-y)/2)*cos((x+y)/2) = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_18_2
    {
        public static double L00_18_2_sin_cos(double angle1, double angle2)
        {
            double Y1 = Math.Sin(angle1);
            double Y2 = Math.Sin(angle2);
            double Y3 = Math.Sin((angle1 - angle2) / 2);
            double Y4 = Math.Cos((angle1 + angle2) / 2);

            double X = Y1 - Y2 - 2 * Y3 * Y4;
           
            return X;

        }

        public static string L00_18_2_sin_cos_in()
        {
            return "(w, w) (w, w)";
        }
    }
    
    /// <summary>
    /// Реализует тождество cos(x) – cos(y) + 2* sin((x+y)/2)* sin((x-y)/2) = 0,
    /// где углы Х,Y задаются параметрами в радианах <paramref name="angle1"/>, <paramref name="angle2"/>.
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle1">, <paramref name="angle2"/> Уголы в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_19_2_cos_sin", "cos(x) – cos(y) + 2* sin((x+y)/2)* sin((x-y)/2) = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_19_2
    {
        public static double L00_19_2_cos_sin(double angle1, double angle2)
        {
            double Y1 = Math.Cos(angle1);
            double Y2 = Math.Cos(angle2);
            double Y3 = Math.Sin((angle1 + angle2) / 2);
            double Y4 = Math.Sin((angle1 - angle2) / 2);

            double X = Y1 - Y2 + 2 * Y3 * Y4;
           
            return X;

        }

        public static string L00_19_2_cos_sin_in()
        {
            return "(w, w) (w, w)";
        }
    }

    /// <summary>
    /// Реализует тождество cos(x) + cos(y) – 2* cos((x+y)/2)* cos((x-y)/2) = 0,
    /// где углы Х,Y задаются параметрами в радианах <paramref name="angle1"/>, <paramref name="angle2"/>.
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle1">, <paramref name="angle2"/> Уголы в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_20_2_cos", "cos(x) + cos(y) – 2* cos((x+y)/2)* cos((x-y)/2) = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_20_2
    {
        public static double L00_20_2_cos(double angle1, double angle2)
        {
            double Y1 = Math.Cos(angle1);
            double Y2 = Math.Cos(angle2);
            double Y3 = Math.Cos((angle1 + angle2) / 2);
            double Y4 = Math.Cos((angle1 - angle2) / 2);

            double X = Y1 + Y2 - 2 * Y3 * Y4;

            return X;

        }

        public static string L00_20_2_cos_in()
        {
            return "(w, w) (w, w)";
        }
    }

    /// <summary>
    /// Реализует тождество tg(x) + tg(y) – (sin(x+y))/(cos(x)*cos(y)) = 0,
    /// где углы Х,Y задаются параметрами в радианах <paramref name="angle1"/>, <paramref name="angle2"/>.
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle1">, <paramref name="angle2"/> Уголы в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_21_2_tg_sin_cos", "tg(x) + tg(y) – (sin(x+y))/(cos(x)*cos(y)) = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_21_2
    {
        public static double L00_21_2_tg_sin_cos(double angle1, double angle2)
        {
            #if _Debug
            if ((Math.Cos(angle1) == 0) || (Math.Cos(angle2) == 0))
                throw new Exception("Значение не принадлежит области определения!");
            #endif

            double Y1 = Math.Tan(angle1);
            double Y2 = Math.Tan(angle2);
            double Y3 = Math.Sin(angle1 + angle2);
            double Y4 = Math.Cos(angle1);
            double Y5 = Math.Cos(angle2);

            double X = Y1 + Y2 - Y3 / (Y4 * Y5);

            return X;

        }

        public static string L00_21_2_tg_sin_cos_in()
        {
            return "(-Pi/2, Pi/2) (-Pi/2, Pi/2)";
        }
    }

    /// <summary>
    /// Реализует тождество tg(x) - tg(y) – (sin(x-y))/(cos(x)*cos(y)) = 0,
    /// где углы Х,Y задаются параметрами в радианах <paramref name="angle1"/>, <paramref name="angle2"/>.
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle1">, <paramref name="angle2"/> Уголы в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_22_2_tg_sin_cos", "tg(x) - tg(y) – (sin(x-y))/(cos(x)*cos(y)) = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_22_2
    {
        public static double L00_22_2_tg_sin_cos(double angle1, double angle2)
        {
            #if _Debug
            if ((Math.Cos(angle1) == 0) || (Math.Cos(angle2) == 0))
                throw new Exception("Значение не принадлежит области определения!");
            #endif

            double Y1 = Math.Tan(angle1);
            double Y2 = Math.Tan(angle2);
            double Y3 = Math.Sin(angle1 - angle2);
            double Y4 = Math.Cos(angle1);
            double Y5 = Math.Cos(angle2);

            double X = Y1 - Y2 - Y3 / (Y4 * Y5);

            return X;

        }

        public static string L00_22_2_tg_sin_cos_in()
        {
            return "(-Pi/2, Pi/2) (-Pi/2, Pi/2)";
        }
    }

    /// <summary>
    /// Реализует тождество ctg(x) + ctg(y) - (sin(x+y))/(sin(x)*sin(y)) = 0,
    /// где углы Х,Y задаются параметрами в радианах <paramref name="angle1"/>, <paramref name="angle2"/>.
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle1">, <paramref name="angle2"/> Уголы в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_23_2_ctg_sin", "ctg(x) + ctg(y) - (sin(x+y))/(sin(x)*sin(y)) = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_23_2
    {
        public static double L00_23_2_ctg_sin(double angle1, double angle2)
        {
            #if _Debug
            if ((Math.Sin(angle1) == 0) || (Math.Sin(angle2) == 0))
                throw new Exception("Значение не принадлежит области определения!");
            #endif

            double Y1 = 1 / Math.Tan(angle1);
            double Y2 = 1 / Math.Tan(angle2);
            double Y3 = Math.Sin(angle1 + angle2);
            double Y4 = Math.Sin(angle1);
            double Y5 = Math.Sin(angle2);

            double X = Y1 + Y2 - Y3 / (Y4 * Y5);

            return X;

        }

        public static string L00_23_2_ctg_sin_in()
        {
            return "(0, Pi) (0, Pi)";
        }
    }

    /// <summary>
    /// Реализует тождество ctg(x) - ctg(y) + (sin(x-y))/(sin(x)*sin(y)) = 0,
    /// где углы Х,Y задаются параметрами в радианах <paramref name="angle1"/>, <paramref name="angle2"/>.
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle1">, <paramref name="angle2"/> Уголы в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_24_2_ctg_sin", "ctg(x) - ctg(y) + (sin(x-y))/(sin(x)*sin(y)) = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_24_2
    {
        public static double L00_24_2_ctg_sin(double angle1, double angle2)
        {
            #if _Debug
            if ((Math.Sin(angle1) == 0) || (Math.Sin(angle2) == 0))
                throw new Exception("Значение не принадлежит области определения!");
            #endif

            double Y1 = 1 / Math.Tan(angle1);
            double Y2 = 1 / Math.Tan(angle2);
            double Y3 = Math.Sin(angle1 - angle2);
            double Y4 = Math.Sin(angle1);
            double Y5 = Math.Sin(angle2);

            double X = Y1 - Y2 + Y3 / (Y4 * Y5);

            return X;

        }

        public static string L00_24_2_ctg_sin_in()
        {
            return "(0, Pi) (0, Pi)";
        }
    }

    /// <summary>
    /// Реализует тождество sin(2x) – 2*sin(x)*cos(x) = 0,
    /// где угол Х задаётся параметром в радианах <paramref name="angle"/>
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle">Угол в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_25_1_sin_cos", "sin(2x) – 2*sin(x)*cos(x) = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_25_1
    {
        public static double L00_25_1_sin_cos(double angle)
        {
            double Y1 = Math.Sin(2 * angle);
            double Y2 = Math.Sin(angle);
            double Y3 = Math.Cos(angle);

            double X = Y1 - 2 * Y2 * Y3;

            return X;

        }

        public static string L00_25_1_sin_cos_in()
        {
            return "(w, w)";
        }
    }

    /// <summary>
    /// Реализует тождество sin(3x) – 3*sin(x) + 4*sin(x) *sin(x) *sin(x) = 0,
    /// где угол Х задаётся параметром в радианах <paramref name="angle"/>
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle">Угол в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_26_1_sin", "sin(3x) – 3*sin(x) + 4*sin(x) *sin(x) *sin(x) = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_26_1
    {
        public static double L00_26_1_sin(double angle)
        {
            double Y1 = Math.Sin(3 * angle);
            double Y2 = Math.Sin(angle);
            double Y3 = Math.Sin(angle);
            double Y4 = Math.Sin(angle);
            double Y5 = Math.Sin(angle);

            double X = Y1 - 3 * Y2 + 4 * Y3 * Y4 * Y5;

            return X;

        }

        public static string L00_26_1_sin_in()
        {
            return "(w, w)";
        }
    }

    /// <summary>
    /// Реализует тождество sin(arcsin(x)) – x = 0,
    /// где угол Х задаётся параметром в радианах <paramref name="angle"/>
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle">Угол в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_27_1_sin_arcsin", "sin(arcsin(x)) – x = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_27_1
    {
        public static double L00_27_1_sin_arcsin(double angle)
        {
            #if _Debug
            if ((angle <= -1) || (angle >= 1))
                throw new Exception("Значение не принадлежит области определения!");
            #endif

            double Y1 = Math.Asin(angle);
            double Y2 = Math.Sin(Y1);
            double Y3 = angle;

            double X = Y2 - Y3;

            return X;

        }

        public static string L00_27_1_sin_arcsin_in()
        {
            return "(-1, 1)";
        }
    }

    /// <summary>
    /// Реализует тождество cos(arccos(x)) – x  = 0,
    /// где угол Х задаётся параметром в радианах <paramref name="angle"/>
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle">Угол в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_28_1_cos_arccos", "cos(arccos(x)) – x = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_28_1
    {
        public static double L00_28_1_cos_arccos(double angle)
        {
            #if _Debug
            if ((angle <= -1) || (angle >= 1))
                throw new Exception("Значение не принадлежит области определения!");
            #endif

            double Y1 = Math.Acos(angle);
            double Y2 = Math.Cos(Y1);
            double Y3 = angle;

            double X = Y2 - Y3;

            return X;

        }

        public static string L00_28_1_cos_arccos_in()
        {
            return "(-1, 1)";
        }
    }

    /// <summary>
    /// Реализует тождество sin(arccos(x)) – cos(arcsin(x))    = 0,
    /// где угол Х задаётся параметром в радианах <paramref name="angle"/>
    /// Результатом функции является целое число X
    /// </summary>
    /// <param name="angle">Угол в радианах </param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_29_1_sin_arccos_cos_arcsin", "sin(arccos(x)) – cos(arcsin(x)) = 0")]
    [EquivalentIntConstant(0)]
    public static class L00_29_1
    {
        public static double L00_29_1_sin_arccos_cos_arcsin(double angle)
        {
            #if _Debug
            if ((angle <= -1) || (angle >= 1))
                throw new Exception("Значение не принадлежит области определения!");
            #endif

            double Y1 = Math.Acos(angle);
            double Y2 = Math.Asin(angle);
            double Y3 = Math.Sin(Y1);
            double Y4 = Math.Cos(Y2);

            double X = Y3 - Y4;

            return X;

        }

        public static string L00_29_1_sin_arccos_cos_arcsin_in()
        {
            return "(-1, 1)";
        }
    }
}