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


    
    