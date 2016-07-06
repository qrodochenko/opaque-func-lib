using System;

namespace OpaqueFunctions
{
    /// <summary>
    /// Реализует нахождение логарифмической функции ln((1+x)/(1-x)),  
    /// где число x задается параметром, удовлетворяющим области определения <paramref name="x"/>. 
    /// Результатом функции является число F , вычисляющее логарифм через цепную дробь,
    /// количество итераций задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="x">число, удовлетворяющее области определения</param>
    /// <param name="count">Количество требуемых итераций</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("С_Math_1_2_ln", "ln((1+x)/(1-x))")]
    [EquivalentIntConstant(1)]
    public static class С_Math_1_2_ln
    {
        public static double Math_1_2_ln(double x, int count)
        {
            double F = 0;
       
            for (int i = count; i > 0; i--)
            {

                F = x * x * i * i / ((2 * i + 1) - F);
            }
            F = 2 * x / (1 - F);
            return F;
        }
    }

    /// <summary>
    /// Реализует нахождение логарифмической функции ln(1+x),  
    /// где число x задается параметром, удовлетворяющим области определения <paramref name="x"/>. 
    /// Результатом функции является число F , вычисляющее логарифм через цепную дробь,
    /// количество итераций задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="x">число, удовлетворяющее области определения</param>
    /// <param name="count">Количество требуемых итераций</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("С_Math_2_2_ln", "ln(1+x)")]
    [EquivalentIntConstant(1)]
    public static class С_Math_2_2_ln
    {
        public static double Math_2_2_ln(double x, int count)
        {
            double F = 0;

            for (int i = count; i > 0; i--)
            {

                F = i * i * x / (2*i + i * i * x / ( 2 * i + 1 + F));
            }
            F =  x / (1 + F);
            return F;
        }
    }



    /// <summary>
    /// Реализует нахождение логарифмической функции ln(1/sqrt(1-sqr(x))),  
    /// где число x задается параметром, удовлетворяющим области определения <paramref name="x"/>. 
    /// Результатом функции является число F , вычисляющее логарифм через цепную дробь,
    /// количество итераций задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="x">число, удовлетворяющее области определения</param>
    /// <param name="count">Количество требуемых итераций</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("С_Math_3_2_ln", "ln(1/sqrt(1-sqr(x)))")]
    [EquivalentIntConstant(1)]
    public static class С_Math_3_2_ln
    {
        public static double Math_3_2_ln(double x, int count)
        {
            double F = 0;

            for (int i = count; i > 0; i--)
            {

                F = i*x*x/(1-i*x*x/(2*(2*i+1)-F));
            }
            F = x * x / (2 - F);
            return F;
        }
    }


    /// <summary>
    /// Реализует нахождение логарифмической функции ln(1+x),  
    /// где число x задается параметром, удовлетворяющим области определения <paramref name="x"/>. 
    /// Результатом функции является число F , вычисляющее логарифм через цепную дробь,
    /// количество итераций задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="x">число, удовлетворяющее области определения</param>
    /// <param name="count">Количество требуемых итераций</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("С_Math_4_2_ln", "ln(1+x)")]
    [EquivalentIntConstant(1)]
    public static class С_Math_4_2_ln
    {
        public static double Math_4_2_ln(double x, int count)
        {
            double F = 0;

            for (int i = count; i > 0; i--)
            {

                F = i * i*x * x /( (2* i +1)*(2+x)- F);
            }
            F = 2 * x / (2+x - F);
            return F;
        }
    }


    //// <summary>
    /// Реализует нахождение логарифмической функции ln(1+x),  
    /// где число x задается параметром, удовлетворяющим области определения <paramref name="x"/>. 
    /// Результатом функции является число F , вычисляющее логарифм через цепную дробь,
    /// количество итераций задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="x">число, удовлетворяющее области определения</param>
    /// <param name="count">Количество требуемых итераций</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("С_Math_5_2_ln", "ln(1+x)")]
    [EquivalentIntConstant(1)]
    public static class С_Math_5_2_ln
    {
        public static double Math_5_2_ln(double x, int count)
        {
            double F = 0;

            for (int i = count; i > 1; i--)
            {

                F = (i * i - 1) * (i * i - 1) * (i * i - 1) * x * x / ((2 * i + 1) * (2 * i * (i + 1) + (i * i + i + 1) * x));
            }
            F = x -  x * x / (2+4*x*x*x/(3*(4+3*x)-F));
            return F;
        }
    }


    /// <summary>
    /// Реализует нахождение логарифмической функции ln(1+x),  
    /// где число x задается параметром, удовлетворяющим области определения <paramref name="x"/>. 
    /// Результатом функции является число F , вычисляющее логарифм через цепную дробь,
    /// количество итераций задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="x">число, удовлетворяющее области определения</param>
    /// <param name="count">Количество требуемых итераций</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("С_Math_6_2_ln", "ln(1+x)")]
    [EquivalentIntConstant(1)]
    public static class С_Math_6_2_ln
    {
        public static double Math_6_2_ln(double x, int count)
        {
            double F = 0;

            for (int i = count; i > 1; i--)
            {

                F = i *( i -1)*(2*i-3)*(2*i+1)* x * x / (2*(4*i * i - 1) + 4*i*i*x - F);
            }
            F = x -3*x*x/(6+4*x- F);
            return F;
        }
    }

    /*
    /// <summary>
    /// Реализует нахождение логарифмической функции ln(1+x),  
    /// где число x задается параметром, удовлетворяющим области определения <paramref name="x"/>. 
    /// Результатом функции является число F , вычисляющее логарифм через цепную дробь,
    /// количество итераций задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="x">число, удовлетворяющее области определения</param>
    /// <param name="count">Количество требуемых итераций</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("С_Math_6_2_ln", "ln(1+x)")]
    [EquivalentIntConstant(1)]
    public static class С_Math_7_3_ln
    {
        public static double Math_7_3_ln(double x,double a, int count)
        {
            double F = 0, X = x / (2 * a + x), z = 1;

            for (int i = 0; i < count; i++)
            {

                X =X*z;
                F =X/(2*i+1) + F;
                z = (x / (2 * a + x)) * (x / (2 * a + x));
            }
            F = Math.Log(a)+2*F;
            return F;
        }
    }*/
}

