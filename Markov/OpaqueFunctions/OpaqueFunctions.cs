using System;

namespace OpaqueFunctions
{
    /// <summary>
    /// хРеализует основное тригонометрическое тождество sin^2 (x) + cos^2 (x) = 1,  
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

    public class CSin_1
    {
        public static double Sin_1(double x, int count)
        {
            
            double fact = 1;
            double sum = x;
            for (int k=1; k<=count; k++)
            {
                fact = fact*(2*k + 1)*(2*k);
                if (Math.Abs(Math.Pow(-1, k) * Math.Pow(x, 2 * k + 1) / fact) < 1e-15) break;
                sum = sum + Math.Pow(-1, k) * Math.Pow(x, 2 * k + 1) / fact;
            }
            if (Math.Abs(sum) < 1e-15) sum = 0;
            return (sum);
        }
    }
    public class CSin_1_in
    {
        public static string Sin_1_in()
        {
            return ("(w, w)");
        }
    }
    public class CSin_1_inv
    {
        public static string Sin_1_inv()
        {
            return ("арксинус");
        }
    }
    public class CSin_2
    {
        public static double Sin_2(double x, double er, double cnst=0.9)
        {
            double fact = 1;
            double fact2 = 1;
            double sum = 0;
            double residue = 10;
            int k = 0;
            while ((Math.Abs(residue) > er)&&(k<=100))
            {
                fact2 = fact2 * (k + 1);
                sum = sum + Math.Pow(-1, k) * Math.Pow(x, 2 * k + 1) / fact;
                k++;
                fact = fact * (2 * k + 1)*(2*k);
                residue = (Math.Pow(x, k) / fact2) * Math.Pow(-1, k) * Math.Pow(cnst*x, 2 * k + 1) / fact;
            }
            sum = sum + residue;
            return (sum);
        }
    }
    public class CSin_2_in
    {
        public static string Sin_2_in()
        {
            return ("(w, w)");
        }
    }
    public class CSin_2_inv
    {
        public static string Sin_2_inv()
        {
            return ("арксинус");
        }
    }
    public class CCos_3
    {
        public static double Cos_3(double x, int count)
        {
            double fact = 1;
            double sum = 1;
            for (int k = 1; k <= count; k++)
            {
                fact = fact * (2 * k)*(2*k-1);
                if (Math.Abs(Math.Pow(-1, k) * Math.Pow(x, 2 * k) / fact) < 1e-15) break;
                sum = sum + Math.Pow(-1, k) * Math.Pow(x, 2 * k) / fact;
            }
            if (Math.Abs(sum) < 1e-15) sum = 0;
            return (sum);
        }
    }
    public class CCos_3_in
    {
        public static string Cos_3_in()
        {
            return ("(w, w)");
        }
    }
    public class CCos_3_inv
    {
        public static string Cos_3_inv()
        {
            return ("арккосинус");
        }
    }
    public class CCos_4
    {
        public static double Cos_4(double x, double er, double cnst = 0.8)
        {
            double fact = 1;
            double fact2 = 1;
            double sum = 0;
            double residue = 10;
            int k = 0;
            while ((Math.Abs(residue) > er) && (k <= 100))
            {
                fact2 = fact2 * (k + 1);
                sum = sum + Math.Pow(-1, k) * Math.Pow(x, 2 * k) / fact;
                k++;
                fact = fact * (2 * k)*(2*k-1);
                residue = (Math.Pow(x, k) / fact2) * Math.Pow(-1, k) * Math.Pow(cnst * x, 2 * k) / fact;
            }
            sum = sum + residue;
            return (sum);
        }
    }
    public class CCos_4_in
    {
        public static string Cos_4_in()
        {
            return ("(w, w)");
        }
    }
    public class CCos_4_inv
    {
        public static string Cos_4_inv()
        {
            return ("арккосинус");
        }
    }

    public class CSin_5
    {
        public static double Sin_5(double x, int count, double y0 = 1)
        {
            int k = 0;
            double fact = 1;
            double fact2 = 1;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double z0 = Math.Asin(y0) - x;
            while (k <= count)
            {
                if (Math.Abs(Math.Pow(-1, k) * Math.Pow(z0, 2 * k+1) / fact) < 1e-15) break;
                sum1 = sum1 + Math.Pow(-1, k) * Math.Pow(z0, 2 * k + 1) / fact;
                k++;
                fact = fact * (2 * k + 1) * (2 * k);
                fact2 = fact2 * (2 * k) * (2 * k - 1);
                sum2 = sum2 + Math.Pow(-1, k) * Math.Pow(z0, 2 * k) / fact2;
            }
            sum3 = y0 * (1 + sum2) - Math.Sqrt(1 - y0 * y0) * sum1;
            if (Math.Abs(sum3) < 1e-15) sum3 = 0;
            return (sum3);
        }
    }
    public class CSin_5_in
    {
        public static string Sin_5_in()
        {
            return ("(w, w)");
        }
    }
    public class CSin_5_inv
    {
        public static string Sin_5_inv()
        {
            return ("арксинус");
        }
    }

    public class CSin_6
    {
        public static double Sin_6(double x, double er, double y0 = 1, double cnst=0.8)
        {
            int k = 0;
            double fact = 1;
            double fact2 = 1;
            double fact3 = 1;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double z0 = Math.Asin(y0) - x;
            double residue = 10;
            while ((Math.Abs(residue) > er) && (k <= 100))
            {
                fact3 = fact3 * (k + 1);
                sum1 = sum1 + Math.Pow(-1, k) * Math.Pow(z0, 2 * k + 1) / fact;
                k++;
                fact2 = fact2 * (2 * k) * (2 * k - 1);
                sum2 = sum2 + Math.Pow(-1, k) * Math.Pow(z0, 2 * k) / fact2;
                fact = fact * (2 * k + 1)*(2*k);
                residue = (Math.Pow(x, k) / fact3) * Math.Pow(-1, k) * Math.Pow(cnst * z0, 2 * k+1) / fact;
            }
            sum3 = y0 * (1 + sum2) - Math.Sqrt(1 - y0 * y0) * sum1;
            return (sum3);
        }
    }
    public class CSin_6_in
    {
        public static string Sin_6_in()
        {
            return ("(w, w)");
        }
    }
    public class CSin_6_inv
    {
        public static string Sin_6_inv()
        {
            return ("арксинус");
        }
    }

    public class CCos_7
    {
        public static double Cos_7(double x, int count, double y0 = 1)
        {
            int k = 0;
            double fact = 1;
            double fact2 = 1;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double z0 = Math.Acos(y0) - x;
            while (k <= count)
            {
                if (Math.Abs(Math.Pow(-1, k) * Math.Pow(z0, 2 * k + 1) / fact) < 1e-15) break;
                sum1 = sum1 + Math.Pow(-1, k) * Math.Pow(z0, 2 * k + 1) / fact;
                k++;
                fact = fact * (2 * k + 1)*(2*k);
                fact2 = fact2 * (2 * k)*(2*k-1);
                sum2 = sum2 + Math.Pow(-1, k) * Math.Pow(z0, 2 * k) / fact2;
            }
            sum3 = y0 * (1 + sum2) + Math.Sqrt(1 - y0 * y0) * sum1;
            if (Math.Abs(sum3) < 1e-15) sum3 = 0;
            return (sum3);
        }
    }
    public class CCos_7_in
    {
        public static string Cos_7_in()
        {
            return ("(w, w)");
        }
    }
    public class CCos_7_inv
    {
        public static string Cos_7_inv()
        {
            return ("арккосинус");
        }
    }

    public class CCos_8
    {
        public static double Cos_8(double x, double er, double y0 = 1, double cnst = 0.8)
        {
            int k = 0;
            double fact = 1;
            double fact2 = 1;
            double fact3 = 1;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double z0 = Math.Acos(y0) - x;
            double residue = 10;
            while ((Math.Abs(residue) > er) && (k <= 100))
            {
                fact3 = fact3 * (k + 1);
                sum1 = sum1 + Math.Pow(-1, k) * Math.Pow(z0, 2 * k + 1) / fact;
                k++;
                fact2 = fact2 * (2 * k)*(2*k-1);
                sum2 = sum2 + Math.Pow(-1, k) * Math.Pow(z0, 2 * k) / fact2;
                fact = fact * (2 * k + 1)*(2*k);
                residue = (Math.Pow(x, k) / fact3) * Math.Pow(-1, k) * Math.Pow(cnst * z0, 2 * k + 1) / fact;
            }
            sum3 = y0 * (1 + sum2) + Math.Sqrt(1 - y0 * y0) * sum1;
            return (sum3);
        }
    }
    public class CCos_8_in
    {
        public static string Cos_8_in()
        {
            return ("(w, w)");
        }
    }
    public class CCos_8_inv
    {
        public static string Cos_8_inv()
        {
            return ("арккосинус");
        }
    }
    public class Cbernulli
    {
        public static double bernulli(int k)
        {
            double fact1 = 1;
            double fact2 = 1;
            double fact3 = 1;
            for (int i = 1; i <= k; i++)
            {
                fact1 = fact1 * (i + 1);
                fact3 = fact3 * i;
            }
            double sum = 0;
            if (k == 0) return (1);
            if ((k>1)&&(k%2 == 1)) return (0);
            else
            {
                for (int i = 1; i <= k; i++)
                {
                    fact2 = fact2 * (i + 1);
                    fact3 = fact3 / (k - i + 1);
                    if (k == i) sum++;
                    else  sum = sum + bernulli(k - i) * fact1 / fact2 / fact3;
                }
            }
            sum = sum * (-1) / (k + 1);
            return (sum);
        }
    }
    

    public class CTg_9
    {
        public static double Tg_9(double x, int count)
        {
            double fact = 1;
            double sum = 0;
            if (Math.Abs(x) >= (Math.PI / 2))
                return (Convert.ToDouble("ERROR"));
            else
            {
                for (int k=1; k<=count; k++)
                {
                    fact = fact * (2 * k) * (2 * k - 1);
                    double s = Math.Abs(Cbernulli.bernulli(2 * k));
                    if (Math.Abs(Math.Pow(2, 2 * k) * (Math.Pow(2, 2 * k) - 1) / fact * Math.Pow(x, 2 * k - 1) *s) < 1e-15) break;
                    sum = sum + Math.Pow(2, 2 * k) * (Math.Pow(2, 2 * k) - 1) / fact * Math.Pow(x, 2 * k - 1) * s;
                }
            }
            if (Math.Abs(sum) < 1e-15) sum = 0;
            return (sum);
        }
    }
    public class CTg_9_in
    {
        public static string Tg_9_in()
        {
            return ("(-Pi/2, Pi/2)");
        }
    }
    public class CTg_9_inv
    {
        public static string Tg_9_inv()
        {
            return ("арктангенс");
        }
    }

    public class CTg_10
    {
        public static double Tg_10(double x, double er, double cnst = 0.8)
        {
            double fact = 2;
            double fact2 = 1;
            double sum = 0;
            double residue = 10;
            int k = 1;
            if (Math.Abs(x) >= (Math.PI / 2))
                return (Convert.ToDouble("ERROR"));
            else
                while ((Math.Abs(residue) > er) && (k <= 100))
                {
                    fact2 = fact2 * (k + 1);
                    sum = sum + Math.Pow(2, 2 * k) * (Math.Pow(2, 2 * k) - 1) / fact * Math.Pow(x, 2 * k - 1) * Math.Abs(Cbernulli.bernulli(2 * k));
                    k++;
                    fact = fact * (2 * k - 1) * (2 * k);
                    residue = (Math.Pow(x, k) / fact2) * Math.Pow(2, 2 * k) * (Math.Pow(2, 2 * k) - 1) / fact * Math.Pow(cnst*x, 2 * k - 1) * Math.Abs(Cbernulli.bernulli(2 * k));
                }
            return (sum+residue);
        }
    }
    public class CTg_10_in
    {
        public static string Tg_10_in()
        {
            return ("(-Pi/2, Pi/2)");
        }
    }
    public class CTg_10_inv
    {
        public static string Tg_10_inv()
        {
            return ("арктангенс");
        }
    }

    public class CCtg_11
    {
        public static double Ctg_11(double x, int count)
        {
            double fact = 1;
            double sum = 0;
            if ((Math.Abs(x) <= 0)&&(Math.Abs(x)>=Math.PI ))
                return (Convert.ToDouble("ERROR"));
            else
            {
                for (int k = 1; k <= count; k++)
                {
                    fact = fact * (2 * k) * (2 * k - 1);
                    double s = Math.Abs(Cbernulli.bernulli(2 * k));
                    if (Math.Abs(Math.Pow(2, 2 * k) / fact * Math.Pow(x, 2 * k - 1) *s) < 1e-15) break;
                    sum = sum + Math.Pow(2, 2 * k) / fact * Math.Pow(x, 2 * k - 1) * s;
                }
            }
            if (Math.Abs(sum) < 1e-15) sum = 0;
            return ((1/x)-sum);
        }
    }
    public class CCtg_11_in
    {
        public static string Ctg_11_in()
        {
            return ("(0, Pi)");
        }
    }
    public class CCtg_11_inv
    {
        public static string Ctg_11_inv()
        {
            return ("арккотангенс");
        }
    }

    public class CCtg_12
    {
        public static double Ctg_12(double x, double er, double cnst = 0.8)
        {
            double fact = 2;
            double fact2 = 1;
            double sum = 0;
            double residue = 10;
            int k = 1;
            if ((Math.Abs(x) <= 0) && (Math.Abs(x) >= Math.PI))
                return (Convert.ToDouble("ERROR"));
            else
                while ((Math.Abs(residue) > er) && (k <= 100))
                {
                    fact2 = fact2 * (k + 1);
                    sum = sum + Math.Pow(2, 2 * k) / fact * Math.Pow(x, 2 * k - 1) * Math.Abs(Cbernulli.bernulli(2 * k));
                    k++;
                    fact = fact * (2 * k - 1) * (2 * k);
                    residue = (Math.Pow(x, k) / fact2) * Math.Pow(2, 2 * k) / fact * Math.Pow(cnst*x, 2 * k - 1) * Math.Abs(Cbernulli.bernulli(2 * k));
                }
            return ((1/x)-(sum+residue));
        }
    }
    public class CCtg_12_in
    {
        public static string Ctg_12_in()
        {
            return ("(0, Pi)");
        }
    }
    public class CCtg_12_inv
    {
        public static string Ctg_12_inv()
        {
            return ("арккотангенс");
        }
    }

    public class CSec_13
    {
        public static double Sec_13(double x, int count)
        {
            double fact = 1;
            double sum = 1;
            if (Math.Abs(x) > (Math.PI / 2))
                return (Convert.ToDouble("ERROR"));
            else
            {
                for (int k = 1; k <= count; k++)
                {
                    fact = fact * (2 * k) * (2 * k - 1);
                    if (Math.Abs(Math.Pow(x, 2 * k) / fact * ((Math.Pow((4 * Math.Abs(Cbernulli.bernulli(2 * k + 1)) - 1), k)) - (Math.Pow((4 * Math.Abs(Cbernulli.bernulli(2 * k + 1)) - 3), k))) / Math.Pow(2, 2 * k + 1)) < 1e-15) break;
                    sum = sum + Math.Pow(x, 2 * k) / fact*((Math.Pow((4* Math.Abs(Cbernulli.bernulli(2 * k + 1)) - 1), k))- (Math.Pow((4 * Math.Abs(Cbernulli.bernulli(2 * k + 1)) - 3), k)))/Math.Pow(2,2*k+1);
                }
            }
            if (Math.Abs(sum) < 1e-15) sum = 0;
            return (sum);
        }
    }
    public class CSec_13_in
    {
        public static string Sec_13_in()
        {
            return ("[-Pi/2, Pi/2]");
        }
    }
    public class CSec_13_inv
    {
        public static string Sec_13_inv()
        {
            return ("арксеканс");
        }
    }

    public class CSec_14
    {
        public static double Sec_14(double x, double er, double cnst = 0.8)
        {
            double fact = 1;
            double fact2 = 1;
            double sum = 0;
            double residue = 10;
            int k = 1;
            if (Math.Abs(x) > (Math.PI / 2))
                return (Convert.ToDouble("ERROR"));
            else
                while ((Math.Abs(residue) > er) && (k <= 100))
                {
                    fact2 = fact2 * (k + 1);
                    sum = sum + Math.Pow(x, 2 * k) / fact * ((Math.Pow((4 * Math.Abs(Cbernulli.bernulli(2 * k + 1)) - 1), k)) - (Math.Pow((4 * Math.Abs(Cbernulli.bernulli(2 * k + 1)) - 3), k))) / Math.Pow(2, 2 * k + 1);
                    k++;
                    fact = fact * (2 * k - 1) * (2 * k);
                    residue = (Math.Pow(x, k) / fact2) * Math.Pow(cnst*x, 2 * k) / fact * ((Math.Pow((4 * Math.Abs(Cbernulli.bernulli(2 * k + 1)) - 1), k)) - (Math.Pow((4 * Math.Abs(Cbernulli.bernulli(2 * k + 1)) - 3), k))) / Math.Pow(2, 2 * k + 1);
                }
            return (sum);
        }
    }
    public class CSec_14_in
    {
        public static string Sec_14_in()
        {
            return ("[-Pi/2, Pi/2]");
        }
    }
    public class CSec_14_inv
    {
        public static string Sec_14_inv()
        {
            return ("арксеканс");
        }
    }

    public class CCosec_15
    {
        public static double Cosec_15(double x, int count)
        {
            double fact = 1;
            double sum = 1/x;
            if (Math.Abs(x) >= Math.PI)
                return (Convert.ToDouble("ERROR"));
            else
            {
                for (int k = 1; k <= count; k++)
                {
                    fact = fact * (2 * k) * (2 * k - 1);
                    if (Math.Abs(Math.Pow(x, 2 * k - 1) / fact * 2 * (Math.Pow(2, 2 * k - 1)-1) * Math.Abs(Cbernulli.bernulli(2 * k))) < 1e-15) break;
                    sum = sum + Math.Pow(x, 2 * k-1) / fact *2*(Math.Pow(2,2*k-1)-1)* Math.Abs(Cbernulli.bernulli(2 * k));
                }
            }
            if (Math.Abs(sum) < 1e-15) sum = 0;
            return (sum);
        }
    }
    public class CCosec_15_in
    {
        public static string Cosec_15_in()
        {
            return ("(-Pi, Pi)");
        }
    }
    public class CCosec_15_inv
    {
        public static string Cosec_15_inv()
        {
            return ("арккосеканс");
        }
    }

    public class CCosec_16
    {
        public static double Cosec_16(double x, double er, double cnst = 0.8)
        {
            double fact = 2;
            double fact2 = 1;
            double sum = 1/x;
            double residue = 10;
            int k = 1;
            if (Math.Abs(x) >= (Math.PI))
                return (Convert.ToDouble("ERROR"));
            else
                while ((Math.Abs(residue) > er) && (k <= 100))
                {
                    fact2 = fact2 * (k + 1);
                    sum = sum + Math.Pow(x, 2 * k - 1) / fact * 2 * (Math.Pow(2, 2 * k - 1)-1) * Math.Abs(Cbernulli.bernulli(2 * k));
                    k++;
                    fact = fact * (2 * k - 1) * (2 * k);
                    residue = (Math.Pow(x, k) / fact2) * Math.Pow(cnst*x, 2 * k - 1) / fact * 2 * (Math.Pow(2, 2 * k - 1)-1) * Math.Abs(Cbernulli.bernulli(2 * k));
                }
            return (sum+residue);
        }
    }
    public class CCosec_16_in
    {
        public static string Cosec_16_in()
        {
            return ("(-Pi, Pi)");
        }
    }
    public class CCosec_16_inv
    {
        public static string Cosec_16_inv()
        {
            return ("арккосеканс");
        }
    }

    public class CSin_17
    {
        public static double Sin_17(double x, int count)
        {
            double fact = 1;
            double sum = 0;
            for(int k=1; k <= count; k++)
            {
                fact = fact * (2 * k)*(2 * k - 1);
                if (Math.Abs(Math.Pow(-1, k+1) * Math.Pow(2, 2 * k - 1) * Math.Pow(x, 2 * k) / fact) < 1e-15) break;
                sum = sum + Math.Pow(-1, k + 1) * Math.Pow(2, 2 * k - 1) * Math.Pow(x, 2 * k) / fact;
            }
            if (Math.Abs(sum) < 1e-15) sum = 0;
            return (sum);
        }
    }

    public class CSin_17_in
    {
        public static string Sin_17_in()
        {
            return ("(w, w)");
        }
    }
    public class CSin_17_inv
    {
        public static string Sin_17_inv()
        {
            return ("арксинус");
        }
    }
    public class CSin_18
    {
        public static double Sin_18(double x, double er, double cnst = 0.8)
        {
            double fact = 2;
            double fact2 = 1;
            double sum = 0;
            double residue = 10;
            int k = 1;
            while ((Math.Abs(residue) > er) && (k <= 100))
            {
                fact2 = fact2 * (k + 1);
                sum = sum + Math.Pow(-1, k + 1) * Math.Pow(2, 2 * k - 1) * Math.Pow(x, 2 * k) / fact;
                k++;
                fact = fact * (2 * k)*(2*k-1);
                residue = (Math.Pow(x, k) / fact2) * Math.Pow(-1, k + 1) * Math.Pow(2, 2 * k - 1) * Math.Pow(cnst*x, 2 * k) / fact;
            }
            return (sum+residue);
        }
    }

    public class CSin_18_in
    {
        public static string Sin_18_in()
        {
            return ("(w, w)");
        }
    }
    public class CSin_18_inv
    {
        public static string Sin_18_inv()
        {
            return ("арксинус");
        }
    }
    public class CCos_19
    {
        public static double Cos_19(double x, int count)
        {
            double fact = 1;
            double sum = 0;
            for (int k = 1; k <= count; k++)
            {
                fact = fact * (2 * k)*(2*k-1);
                if (Math.Abs(Math.Pow(-1, k + 1) * Math.Pow(2, 2 * k - 1) * Math.Pow(x, 2 * k) / fact) < 1e-15) break;
                sum = sum + Math.Pow(-1, k + 1) * Math.Pow(2, 2 * k - 1) * Math.Pow(x, 2 * k) / fact;
            }
            if (Math.Abs(sum) < 1e-15) sum = 0;
            sum = 1 - sum;
            return (sum);

        }
    }
    public class CCos_19_in
    {
        public static string Cos_19_in()
        {
            return ("(w, w)");
        }
    }
    public class CCos_19_inv
    {
        public static string Cos_19_inv()
        {
            return ("арккосинус");
        }
    }

    public class CCos_20
    {
        public static double Cos_20(double x, double er, double cnst = 0.8)
        {
            double fact = 2;
            double fact2 = 1;
            double sum = 0;
            double residue = 10;
            int k = 1;
            while ((Math.Abs(residue) > er) && (k <= 100))
            {
                fact2 = fact2 * (k + 1);
                sum = sum + Math.Pow(-1, k + 1) * Math.Pow(2, 2 * k - 1) * Math.Pow(x, 2 * k) / fact;
                k++;
                fact = fact * (2 * k)*(2*k-1);
                residue = (Math.Pow(x, k) / fact2) * Math.Pow(-1, k + 1) * Math.Pow(2, 2 * k - 1) * Math.Pow(cnst*x, 2 * k) / fact;
            }
            sum = 1 - (sum+residue);
            return (sum);
        }
    }
    public class CCos_20_in
    {
        public static string Cos_20_in()
        {
            return ("(w, w)");
        }
    }
    public class CCos_20_inv
    {
        public static string Cos_20_inv()
        {
            return ("арккосинус");
        }
    }

    public class CSin_21
    {
        public static double Sin_21(double x, int count)
        {
            double fact = 1;
            double sum = 0;
            for (int k = 1; k <= count; k++)
            {
                fact = fact * (2 * k + 1) * (2 * k);
                if (Math.Abs(Math.Pow(-1, k + 1) * (Math.Pow(3, 2 * k + 1) - 3) * Math.Pow(x, 2 * k + 1)/fact) < 1e-15) break;
                sum = sum + Math.Pow(-1, k + 1) * (Math.Pow(3, 2 * k + 1)-3) * Math.Pow(x, 2 * k + 1) / fact;
            }
            if (Math.Abs(sum) < 1e-15) sum = 0;
            sum = sum/4;
            return (sum);

        }
    }
    public class CSin_21_in
    {
        public static string Sin_21_in()
        {
            return ("(w, w)");
        }
    }
    public class CSin_21_inv
    {
        public static string Sin_21_inv()
        {
            return ("арксинус");
        }
    }
    public class CSin_22
    {
        public static double Sin_22(double x, double er, double cnst = 0.8)
        {
            double fact = 6;
            double fact2 = 1;
            double sum = 0;
            double residue = 10;
            int k = 1;
            while ((Math.Abs(residue) > er) && (k <= 100))
            {
                fact2 = fact2 * (k + 1);
                sum = sum + Math.Pow(-1, k + 1) * (Math.Pow(3, 2 * k + 1) - 3) * Math.Pow(x, 2 * k + 1) / fact;
                k++;
                fact = fact * (2 * k + 1) * (2 * k);
                residue = (Math.Pow(x, k) / fact2) * Math.Pow(-1, k + 1) * (Math.Pow(3, 2 * k + 1) - 3) * Math.Pow(cnst*x, 2 * k + 1) / fact;
            }
            sum = (sum+residue)/4;
            return (sum);
        }
    }
    public class CSin_22_in
    {
        public static string Sin_22_in()
        {
            return ("(w, w)");
        }
    }
    public class CSin_22_inv
    {
        public static string Sin_22_inv()
        {
            return ("арксинус");
        }
    }

    public class CCos_23
    {
        public static double Cos_23(double x, int count)
        {
            double fact = 1;
            double sum = 4;
            for (int k = 1; k <= count; k++)
            {
                fact = fact * (2 * k)*(2*k-1);
                if (Math.Abs(Math.Pow(-1, k) * (Math.Pow(3, 2 * k) + 3) * Math.Pow(x, 2 * k)/fact) < 1e-15) break;
                sum = sum + Math.Pow(-1, k) * (Math.Pow(3, 2 * k) + 3) * Math.Pow(x, 2 * k) / fact;
            }
            if (Math.Abs(sum) < 1e-15) sum = 0;
            sum = sum/4;
            return (sum);

        }
    }
    public class CCos_23_in
    {
        public static string Cos_23_in()
        {
            return ("(w, w)");
        }
    }
    public class CCos_23_inv
    {
        public static string Cos_23_inv()
        {
            return ("арккосинус");
        }
    }

    public class CCos_24
    {
        public static double Cos_24(double x, double er, double cnst = 0.8)
        {
            double fact = 1;
            double fact2 = 1;
            double sum = 0;
            double residue = 10;
            int k = 0;
            while ((Math.Abs(residue) > er) && (k <= 100))
            {
                fact2 = fact2 * (k + 1);
                sum = sum + Math.Pow(-1, k) * (Math.Pow(3, 2 * k) + 3) * Math.Pow(x, 2 * k) / fact;
                k++;
                fact = fact * (2 * k) * (2 * k - 1);
                residue = (Math.Pow(x, k) / fact2) * Math.Pow(-1, k) * (Math.Pow(3, 2 * k) + 3) * Math.Pow(cnst*x, 2 * k) / fact;
            }
            sum = (sum+residue)/4;
            return (sum);
        }
    }
    public class CCos_24_in
    {
        public static string Cos_24_in()
        {
            return ("(w, w)");
        }
    }
    public class CCos_24_inv
    {
        public static string Cos_24_inv()
        {
            return ("арккосинус");
        }
    }

}

