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

}

