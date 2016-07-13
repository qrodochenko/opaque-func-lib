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
    [FunctionName("Math_1_2_ln", "ln((1+x)/(1-x))")]
    [EquivalentIntConstant(1)]
    public static class СMath_1_2_ln
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

        public static string Math_1_2_ln_in()
        {
            return "(-1, 1)";
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
    [FunctionName("Math_2_2_ln", "ln(1+x)")]
    [EquivalentIntConstant(1)]
    public static class СMath_2_2_ln
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

        public static string Math_2_2_ln_in()
        {
            return "(-1, w)";
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
    [FunctionName("Math_3_2_ln", "ln(1/sqrt(1-sqr(x)))")]
    [EquivalentIntConstant(1)]
    public static class СMath_3_2_ln
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

        public static string Math_3_2_ln_in()
        {
            return "(-1, 1)";
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
    [FunctionName("Math_4_2_ln", "ln(1+x)")]
    [EquivalentIntConstant(1)]
    public static class СMath_4_2_ln
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

        public static string Math_4_2_ln_in()
        {
            return "(-1, w)";
        }
    }

/*
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
    [FunctionName("Math_5_2_ln", "ln(1+x)")]
    [EquivalentIntConstant(1)]
    public static class СMath_5_2_ln
    {
        public static double Math_5_2_ln(double x, int count)
        {
            double F = 0;

            for (int i = count; i > 2; i--)
            {

                F = (i * i - 1) * (i * i - 1) * (i * i - 1) * x * x / ((2 * i + 1) * (2 * i * (i + 1) + (i * i + i + 1) * x)-F);
            }
            F = x -  x * x / (2+4*x*x*x/(3*(4+3*x)-27*x*x*x/(5*(12+7*x)-F)));
            return F;
        }

        public static string Math_5_2_ln_in()
        {
            return "(-1, w)";
        }
    }*/


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
    [FunctionName("Math_6_2_ln", "ln(1+x)")]
    [EquivalentIntConstant(1)]
    public static class СMath_6_2_ln
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

        public static string Math_6_2_ln_in()
        {
            return "(-1, w)";
        }
    }

    
    /// <summary>
    /// Реализует нахождение логарифмической функции ln(x+a),  
    /// где число x задается параметром, удовлетворяющим области определения <paramref name="x"/>. 
    /// Результатом функции является число F , вычисляющее логарифм, используя ряд тейлора,
    /// количество итераций задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="x">число, удовлетворяющее области определения</param>
    /// <param name="count">Количество требуемых итераций</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("Math_7_3_ln", "ln(x+a)")]
    [EquivalentIntConstant(1)]
    public static class СMath_7_3_ln
    {
        public static double Math_7_3_ln(double a,double x, int count)
        {
            double F = 0, X = x / (2 * a + x);

            for (int i = 0; i < count; i++)
            {
                F =X/(2*i+1) + F;
                X = X*(x / (2 * a + x)) * (x / (2 * a + x));
            }
            F = Math.Log(a)+2*F;
            return F;
        }

        public static string Math_7_3_ln_in()
        {
            return "(-a, w)";
        }
    }

    /// <summary>
    /// Реализует нахождение логарифмической функции ln(1+x),  
    /// где число x задается параметром, удовлетворяющим области определения <paramref name="x"/>. 
    /// Результатом функции является число F , вычисляющее логарифм, используя ряд тейлора,
    /// количество итераций задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="x">число, удовлетворяющее области определения</param>
    /// <param name="count">Количество требуемых итераций</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("Math_8_2_ln", "ln(1+x)")]
    [EquivalentIntConstant(1)]
    public static class СMath_8_2_ln
    {
        public static double Math_8_2_ln(double x, int count)
        {
            double F = 0, X = x;

            for (int i = 0; i < count; i++)
            {
                F = X / (i + 1) + F;
                X = -X * x;
            }
            return F;
        }

        public static string Math_8_2_ln_in()
        {
            return "(-1, 1)";
        }
    }


    /// <summary>
    /// Реализует нахождение логарифмической функции ln(1+x),  
    /// где число x задается параметром, удовлетворяющим области определения <paramref name="x"/>. 
    /// Результатом функции является число F , вычисляющее логарифм, используя ряд тейлора,
    /// количество итераций задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="x">число, удовлетворяющее области определения</param>
    /// <param name="count">Количество требуемых итераций</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("Math_9_2_ln", "ln(1+x)")]
    [EquivalentIntConstant(1)]
    public static class СMath_9_2_ln
    {
        public static double Math_9_2_ln(double x, int count)
        {
            double F = 0, X = x * x;

            for (int i = 1; i < count; i++)
            {
                F = X / (i * (i + 1)) + F;
                X = -X * x;
            }
            F = (x + F) / (x + 1);
            return F;
        }

        public static string Math_9_2_ln_in()
        {
            return "(-1, 2)";
        }
    }

    /// <summary>
    /// Реализует нахождение логарифмической функции ln((1+x)/(1-x)),  
    /// где число x задается параметром, удовлетворяющим области определения <paramref name="x"/>. 
    /// Результатом функции является число F , вычисляющее логарифм, используя ряд тейлора,
    /// количество итераций задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="x">число, удовлетворяющее области определения</param>
    /// <param name="count">Количество требуемых итераций</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("Math_10_2_ln", "ln((1+x)/(1-x))")]
    [EquivalentIntConstant(1)]
    public static class СMath_10_2_ln
    {
        public static double Math_10_2_ln(double x, int count)
        {
            double F = 0, X = x ;

            for (int i = 0; i < count; i++)
            {
                F = X / (2 * i + 1) + F;
                X = X * x * x;
            }
            F = 2 * F;
            return F;
        }

        public static string Math_10_2_ln_in()
        {
            return "(-1, 1)";
        }
    }

    /// <summary>
    /// Реализует нахождение логарифмической функции ln(x/(1-x)),  
    /// где число x задается параметром, удовлетворяющим области определения <paramref name="x"/>. 
    /// Результатом функции является число F , вычисляющее логарифм, используя ряд тейлора,
    /// количество итераций задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="x">число, удовлетворяющее области определения</param>
    /// <param name="count">Количество требуемых итераций</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("Math_11_2_ln", "ln(x/(1-x))")]
    [EquivalentIntConstant(1)]
    public static class СMath_11_2_ln
    {
        public static double Math_11_2_ln(double x, int count)
        {
            double F = 0, X = x ;

            for (int i = 0; i < count; i++)
            {
                F = 1 / (X * (i + 1)) + F;
                X = X * x;
            }
            return F;
        }

        public static string Math_11_2_ln_in()
        {
            return "(w, -1) U (1, w)";
        }
    }

}

