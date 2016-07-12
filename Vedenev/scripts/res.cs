 //##################################################################################################
    /// <summary>
    /// –еализует тождество 58 f(x) = arctg(x) Ц arcctg(1/x)
    /// </summary>
    /// <param name="x">ѕоложительное число</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_58_1_arctg_arcctg", "f(x) = arctg(x) Ц arcctg(1/x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_58_1_arctg_arcctg
    {
        public static double Body(double x)
        {            
            double  X, Y1, Y2;
            Y1 = Math.Atan(x);
Y2 = Math.PI/2 - Math.Atan(1/x);
X = Y1 - Y2;
            return X;
        }
    }

    /// <summary>
    /// –еализует тождество 58 f(x) = arctg(x) Ц arcctg(1/x),
    /// –езультатом функции €вл€етс€ целое число X - результат умножени€ левой части тождества само на себ€ столько раз,
    /// сколько задано параметр <paramref name="count"/>.
    /// </summary>
    /// <param name="x">ѕоложительное число</param>
    /// <param name="count"> оличество требуемых перемножений</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_58_2_arctg_arcctg", "f(x) = arctg(x) Ц arcctg(1/x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_58_2_arctg_arcctg
    {
        public static double Body(double x, int count)
        {
            double  X, Y1, Y2;
            for (int i = 0; i < count; ++i) {
                Y1 = Math.Atan(x);
Y2 = Math.PI/2 - Math.Atan(1/x);
X = Y1 - Y2;
            }
            return X;
        }
    }

    /// <summary>
    /// ¬озвращает область определени€ тождества 58 f(x) = arctg(x) Ц arcctg(1/x)
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
        