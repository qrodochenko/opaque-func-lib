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
        public static double Body(double x)
        {            
            double  X = 1, Y1, Y2;
            Y1 = Math.Atan(x);
Y2 = Math.PI/2 - Math.Atan(1/x);
X = Y1 - Y2;
            return X;
        }
    }
    /// <summary>
    /// Реализует тождество 58 f(x) = arctg(x) – arcctg(1/x),
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметр <paramref name="count"/>.
    /// </summary>
    /// <param name="x">Положительное число</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_58_2_arctg_arcctg", "f(x) = arctg(x) – arcctg(1/x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_58_2_arctg_arcctg
    {
        public static double Body(double x, int count)
        {
            double  X = 1, Y1, Y2;
            for (int i = 0; i < count; ++i) {
                Y1 = Math.Atan(x);
Y2 = Math.PI/2 - Math.Atan(1/x);
X = Y1 - Y2;
            }
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
        public static string Body()
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
        public static double Body(double x)
        {            
            double  X = 1, Y1, Y2, Y3;
            Y1 = Math.Atan(x);
Y2 = 1/Math.Pow(1+x*x, 1/2);
Y3 = Math.Acos(Y2);
X = Y1 - Y3;
            return X;
        }
    }
    /// <summary>
    /// Реализует тождество 59 f(x) = arctg(x) – arccos(1/((1+x*x)^1/2)),
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметр <paramref name="count"/>.
    /// </summary>
    /// <param name="x">Положительное число</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_59_2_arctg_arccos", "f(x) = arctg(x) – arccos(1/((1+x*x)^1/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_59_2_arctg_arccos
    {
        public static double Body(double x, int count)
        {
            double  X = 1, Y1, Y2, Y3;
            for (int i = 0; i < count; ++i) {
                Y1 = Math.Atan(x);
Y2 = 1/Math.Pow(1+x*x, 1/2);
Y3 = Math.Acos(Y2);
X = Y1 - Y3;
            }
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
        public static string Body()
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
        public static double Body(double x)
        {            
            double  X = 1, Y1, Y2, Y3;
            Y1 = Math.PI/2 - Math.Atan(1/x);
Y2 = 1/Math.Pow(1+x*x, 1/2);
Y3 = Math.Acos(Y2);
X = Y1 - Y3;
            return X;
        }
    }
    /// <summary>
    /// Реализует тождество 60 f(x) = arcctg(1/x) - arccos(1/((1+x*x)^1/2)),
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметр <paramref name="count"/>.
    /// </summary>
    /// <param name="x">Положительное число</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_60_2_arcctg_arccos", "f(x) = arcctg(1/x) - arccos(1/((1+x*x)^1/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_60_2_arcctg_arccos
    {
        public static double Body(double x, int count)
        {
            double  X = 1, Y1, Y2, Y3;
            for (int i = 0; i < count; ++i) {
                Y1 = Math.PI/2 - Math.Atan(1/x);
Y2 = 1/Math.Pow(1+x*x, 1/2);
Y3 = Math.Acos(Y2);
X = Y1 - Y3;
            }
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
        public static string Body()
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
        public static double Body(double x)
        {            
            double  X = 1, Y1, Y2, Y3;
            Y1 = Math.PI/2 - Math.Atan(x);
Y2 = x/Math.Pow(1+x*x, 1/2);
Y3 = Math.Acos(Y2);
X = Y1 - Y3;
            return X;
        }
    }
    /// <summary>
    /// Реализует тождество 61 f(x) = arcctg(x) - arccos(x/((1+x*x)^1/2)),
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметр <paramref name="count"/>.
    /// </summary>
    /// <param name="x">Положительное число</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_61_2_arcctg_arccos", "f(x) = arcctg(x) - arccos(x/((1+x*x)^1/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_61_2_arcctg_arccos
    {
        public static double Body(double x, int count)
        {
            double  X = 1, Y1, Y2, Y3;
            for (int i = 0; i < count; ++i) {
                Y1 = Math.PI/2 - Math.Atan(x);
Y2 = x/Math.Pow(1+x*x, 1/2);
Y3 = Math.Acos(Y2);
X = Y1 - Y3;
            }
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
        public static string Body()
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
    [FunctionName("L00_62_1_arctg_arcsin", "f(x) = arcctg(x) – arcsin(1/((1+x*x)^1/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_62_1_arctg_arcsin
    {
        public static double Body(double x)
        {            
            double  X = 1, Y1, Y2, Y3;
            Y1 = Math.PI/2 - Math.Atan(1/x);
Y2 = 1/Math.Pow(1+x*x, 1/2);
Y3 = Math.Asin(Y2);
X = Y1 - Y3;
            return X;
        }
    }
    /// <summary>
    /// Реализует тождество 62 f(x) = arcctg(x) – arcsin(1/((1+x*x)^1/2)),
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметр <paramref name="count"/>.
    /// </summary>
    /// <param name="x">Положительное число</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_62_2_arctg_arcsin", "f(x) = arcctg(x) – arcsin(1/((1+x*x)^1/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_62_2_arctg_arcsin
    {
        public static double Body(double x, int count)
        {
            double  X = 1, Y1, Y2, Y3;
            for (int i = 0; i < count; ++i) {
                Y1 = Math.PI/2 - Math.Atan(1/x);
Y2 = 1/Math.Pow(1+x*x, 1/2);
Y3 = Math.Asin(Y2);
X = Y1 - Y3;
            }
            return X;
        }
    }
    /// <summary>
    /// Возвращает область определения тождества 62 f(x) = arcctg(x) – arcsin(1/((1+x*x)^1/2))
    /// </summary>    
    /// <returns>(0, w)</returns>
    [OpaqueFunction()]
    [FunctionName("L00_62_1_arctg_arcsin_in", "(0, w)")]
    public static class CL00_62_1_arctg_arcsin_in
    {
        public static string Body()
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
        public static double Body(double x)
        {            
            double  Y1, Y2, Y3, X = 1;
            Y3 = 2*x;
Y1 = Math.Cos(Y3);
Y2 = Math.Cos(x);
X = Y1 - 2*Y2*Y2 + 1;
            return X;
        }
    }
    /// <summary>
    /// Реализует тождество 63 f(x) = cos(2x) – 2*cos(x)*cos(x) + 1,
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметр <paramref name="count"/>.
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_63_2_cos", "f(x) = cos(2x) – 2*cos(x)*cos(x) + 1")]
    [EquivalentIntConstant(0)]
    public static class CL00_63_2_cos
    {
        public static double Body(double x, int count)
        {
            double  Y1, Y2, Y3, X = 1;
            for (int i = 0; i < count; ++i) {
                Y3 = 2*x;
Y1 = Math.Cos(Y3);
Y2 = Math.Cos(x);
X = Y1 - 2*Y2*Y2 + 1;
            }
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
        public static string Body()
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
        public static double Body(double x)
        {            
            double  Y1, Y2, Y3, X = 1;
            Y3 = 2*x;
Y1 = Math.Cos(Y3);
Y2 = Math.Sin(x);
X = Y1 - 1 + 2*Y2*Y2;
            return X;
        }
    }
    /// <summary>
    /// Реализует тождество 64 f(x) = cos(2x) – 1 + 2*sin(x)*sin(x),
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметр <paramref name="count"/>.
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_64_2_cos_sin", "f(x) = cos(2x) – 1 + 2*sin(x)*sin(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_64_2_cos_sin
    {
        public static double Body(double x, int count)
        {
            double  Y1, Y2, Y3, X = 1;
            for (int i = 0; i < count; ++i) {
                Y3 = 2*x;
Y1 = Math.Cos(Y3);
Y2 = Math.Sin(x);
X = Y1 - 1 + 2*Y2*Y2;
            }
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
        public static string Body()
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
        public static double Body(double x)
        {            
            double  Y1, Y2, Y3, X = 1;
            Y1 = Math.Tan(x);
Y2 = Math.PI/2 - x;
Y3 = Math.Tan(Y2);
X = Y1 - 1/Y3;
            return X;
        }
    }
    /// <summary>
    /// Реализует тождество 65 f(x) = tg(x) – 1/(tg(PI/2-x)),
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметр <paramref name="count"/>.
    /// </summary>
    /// <param name="x">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_65_2_tg", "f(x) = tg(x) – 1/(tg(PI/2-x))")]
    [EquivalentIntConstant(0)]
    public static class CL00_65_2_tg
    {
        public static double Body(double x, int count)
        {
            double  Y1, Y2, Y3, X = 1;
            for (int i = 0; i < count; ++i) {
                Y1 = Math.Tan(x);
Y2 = Math.PI/2 - x;
Y3 = Math.Tan(Y2);
X = Y1 - 1/Y3;
            }
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
        public static string Body()
        {
            return "(w, w)";
        }
    }


    
    