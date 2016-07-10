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
    [FunctionName("Opaque1SinCos", "sin^2 + cos^2 = 1")]
    [EquivalentIntConstant(1)]
    public static class Opaque1SinCos
    {
        public static double Body(double angle, int count)
        {
            double X = 1;
            for (int i = 0; i < count; i++)
            {
                X *= Math.Sin(angle) * Math.Sin(angle) + Math.Cos(angle) * Math.Cos(angle);
            }
            return X;
        }
    }


    /// <summary>
    /// Реализует аппроксимацию Паде функции sin (x),
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является вещественное число X - приближенное значение функции sin(x)
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>sin (x)</returns>
    [OpaqueFunction()]
    [FunctionName("MathApprox_1_1", "sin (x)")]
    public static class CMathApprox_1
    {

        public static double MathApprox_1_1(double angle)
        {
            double P0;
            P0 = 12671.0 / 4363920.0 * angle * angle * angle * angle * angle;
            P0 -= 2363.0 / 18183.0 * angle * angle * angle;
            P0 += angle;

            double P1;
            P1 = 121.0 / 16662240.0 * angle * angle * angle * angle * angle * angle;
            P1 += 601.0 / 872784.0 * angle * angle * angle * angle;
            P1 += 445.0 / 12122.0 * angle * angle;
            P1 += 1.0;

            return P0 / P1;
        }

        public static String MathApprox_1_1_in()
        {
            return "(-Pi/2, Pi/2)";
        }

        public static double MathApprox_1_1_Pow(double angle)
        {
            double P0;
            P0 = 12671.0 / 4363920.0 * Math.Pow(angle, 5);
            P0 -= 2363.0 / 18183.0 * Math.Pow(angle, 3);
            P0 += angle;

            double P1;
            P1 = 121.0 / 1666240.0 * Math.Pow(angle, 6);
            P1 += 601.0 / 872784.0 * Math.Pow(angle, 4);
            P1 += 445.0 / 12122.0 * Math.Pow(angle, 2);
            P1 += 1.0;

            return P0 / P1;
        }
    }

    /// <summary>
    /// Реализует аппроксимацию Паде функции exp (x),
    /// где аргумент X задается параметром <paramref name="arg"/>. 
    /// Результатом функции является вещественное число X - приближенное значение функции exp (x)
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>exp (x)</returns>
    [OpaqueFunction()]
    [FunctionName("MathApprox_2_1", "Exp (x)")]
    public static class CMathApprox_2
    {
        public static double MathApprox_2_1(double arg)
        {
            double P0;
            P0 = 1.0 / 30240.0 * arg * arg * arg * arg * arg;
            P0 += 1.0 / 1008.0 * arg * arg * arg * arg;
            P0 += 1.0 / 72.0 * arg * arg * arg;
            P0 += 1.0 / 9.0 * arg * arg;
            P0 += 1.0 / 2.0 * arg;
            P0 += 1.0;

            double P1;
            P1 = -1.0 / 30240.0 * arg * arg * arg * arg * arg;
            P1 += 1.0 / 1008.0 * arg * arg * arg * arg;
            P1 += -1.0 / 72.0 * arg * arg * arg;
            P1 += 1.0 / 9.0 * arg * arg;
            P1 += -1.0 / 2.0 * arg;
            P1 += 1.0;

            return P0 / P1;
        }
    }



    public static class CMathApprox_Ln
    {
        
        public static double MathApprox_ln_2(double arg, double error)
        {
            int L = 0;
            int M = 1;

            //finding the appropriate L and M for the approximation to meet the adjusted error
            for (;;)
            {
                if (error > MathApprox_ln_CheckError(L, M))
                    break;
                if (L == M)
                    M++;
                else
                    L++;
            }


            //creating suitable approximation;
            //Ln_Numer is the numerator, Ln_Denom is the denominator, C is the Taylor approximation
            double[] C = new double[L + M + 1];
            C[0] = 0;
            for (int i = 1; i < L + M + 1; i++)
                C[i] = 1.0 / i * Math.Pow(-1, i + 1);

            double[] Ln_Numer = new double[L + 1];
            double[] Ln_Denom = new double[M + 1];

            CFind_Pade.Find_Denominator(Ln_Denom, C, L, M);
            CFind_Pade.Find_Numerator(Ln_Numer, Ln_Denom, C, L, M);
            
            //computing requested value (Res)
            double P0 = 0;
            double P1 = 1;
            for (int j = 1; j < L + 1; j++)
            {
                double Tmp = 1;
                for (int k = 0; k < j; k++)
                    Tmp = Tmp * arg;
                P0 += Ln_Numer[j] * Tmp;
                P1 += Ln_Denom[j] * Tmp;
            }
            double Res = P0 / P1;

            return Res;
        }

        public static double MathApprox_ln_CheckError(int L, int M)
        {
            if ((L == 1) && (M == 2))
                return 0.005;
            double[] C = new double[L + M + 1];
            C[0] = 0;
            for (int i = 1; i < L + M + 1; i++)
                C[i] = 1.0 / i * Math.Pow(-1, i + 1);

            double[] Ln_Numer = new double[L + 1];
            double[] Ln_Denom = new double[M + 1];
            CFind_Pade.Find_Denominator(Ln_Denom, C, L, M);
            CFind_Pade.Find_Numerator(Ln_Numer, Ln_Denom, C, L, M);

            double error = 0;

            Random rnd = new Random();
            for (int i = 0; i < 10000; i++)
            {
                double arg = 0.001 * rnd.Next(1000);
                double P0 = 0;
                double P1 = 1;
                for (int j = 1; j < L + 1; j++)
                {
                     double Tmp = 1;
                    for (int k = 0; k < j; k++)
                        Tmp *= arg;
                    P0 += Ln_Numer[j] * Tmp;
                    P1 += Ln_Denom[j] * Tmp;
                }
                double Res = P0 / P1;

                double Temp = Math.Abs(Math.Log(arg + 1) - Res);
                if (error < Temp)
                    error = Temp;
             }

            return error;
        }

        public static double MathApprox_ln_4_in()
        {
            return 1;
        }
    }

    public static class CFind_Pade
    {
        public static void Find_Denominator(double[] Find, double[] Taylor, int L, int M)
        {
            //initialization of the matrix
            double[,] Matrix = new double[M, M];
            for (int i = 0; i < M; i++)
                for (int j = 0; j < M; j++)
                    Matrix[i, j] = Taylor[L - M + (i + j + 1)];

            double[] RightMat = new double[M];
            for (int i = 0; i < M; i++)
                RightMat[i] = -Taylor[L + i + 1];
            //----------------------------------

            //solving
            for (int k = 0; k < M - 1; k++)
            {
                if (Matrix[k, k] == 0)
                    for (int i = 0; i < M; i++)
                        Matrix[i, k] += Matrix[i, k + 1]; 
                    
                for (int i = k + 1; i < M; i++)
                {
                    for (int j = k + 1; j < M; j++)
                        Matrix[i, j] = Matrix[i, j] - Matrix[k, j] * (Matrix[i, k] / Matrix[k, k]);

                    RightMat[i] = RightMat[i] - RightMat[k] * Matrix[i, k] / Matrix[k, k];
                }
            }
                
            double s = 0;
            for (int k = M - 1; k >= 0; k--)
            {
                s = 0;
                for (int j = k + 1; j < M; j++)
                    s = s + Matrix[k, j] * Find[j + 1];
                Find[k + 1] = (RightMat[k] - s) / Matrix[k, k];
            }
            for (int i = 1; i < M/2 + 1; i++)
            {
                double Tmp = Find[i];
                Find[i] = Find[M - i + 1];
                Find[M - i + 1] = Tmp;
            }
            Find[0] = 1.0;
            //----------------------------------
        }

        public static void Find_Numerator(double[] Find, double[] Denom, double[] Taylor, int L, int M)
        {
            int N = Math.Min(L, M);
            for (int i = 0; i <= L; i++)
            {
                double Tmp = 0;
                for (int k = 1; (k <= i)&&(k <= N); k++)
                {
                    Tmp += Denom[k] * Taylor[i - k];
                }
                Find[i] = Taylor[i] + Tmp;
            }
        }

    }

}

