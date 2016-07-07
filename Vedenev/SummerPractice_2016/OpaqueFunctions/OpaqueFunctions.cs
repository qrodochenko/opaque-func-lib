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

    
    //##################################################################################################
    /// <summary>
    /// Реализует тригонометрическое тождество arctg(x)-arcctg(1/x) = 0,  
    /// где X некоторое положительное число <paramref name="x"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметр.
    /// </summary>
    /// <param name="x">Положительное число</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L00_58_1_arctg_arcctg", "arctg(x)-arcctg(1/x) = 0")]
    [EquivalentIntConstant(0)]
    public static class CL00_58_1_arctg_arcctg
    {
        public static double Body(double x)
        {
            
            double y1 = Math.Atan(x);
            double y2 = Math.PI/2 - Math.Atan(1/x);
            return y1 - y2;
        }
    }

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
    /// Реализует тригонометрическое тождество arctg(x) – arccos(1/((1+x*x)^1/2)) = 0,  
    /// где X некоторое положительное число <paramref name="x"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметр.
    /// </summary>
    /// <param name="x">Положительное число</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("L00_59_1_arctg_arccos", "arctg(x) – arccos(1/((1+x*x)^1/2)) = 0")]
    [EquivalentIntConstant(0)]
    public static class CL00_59_1_arctg_arccos
    {
        public static double Body(double x)
        {

            double y1 = Math.Atan(x);
            double y2 = Math.Acos(1 /Math.Sqrt((1 + x * x)));
            return y1 - y2;
        }
    }

    [OpaqueFunction()]
    [FunctionName("L00_59_1_arctg_arccos_in", "(0, w)")]
    public static class CL00_58_1_arctg_arcctg_in
    {
        public static string Body()
        {
            return "(0, w)";
        }
    }

}

