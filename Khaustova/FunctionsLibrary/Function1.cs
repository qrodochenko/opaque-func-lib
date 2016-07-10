using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsLibrary
{
    public class Function1
    {
        public static double interval_ww_ww_1(double A, double B, int k, double x)
        {
            double t = x + A;
            double p = 2*k+1;

            return (Math.Pow(t, p) + B);
        }

        public static double interval_ww_ww_1_inv(double A, double B, int k, double x)
        {
            if (x >= B)
            {
                double t = x - B;
                double p = 1f / (double)(2 * k + 1);

                return (Math.Pow(t, p) - A);
            }
            else
            {
                double t = B - x;
                double p = 1f / (double)(2 * k + 1);

                return (-Math.Pow(t, p) - A);
            }
        }

        /*    public static double interval_ww_ww_1_in(double A, double B, int k, double x)
            {

            }
        */

    }

    public class Function2
    {
        public static double interval_ww_finfin_2(double C, double x)
        {
            if (C <= 0) return 0;
            else
            {
                return (x / Math.Sqrt(x * x + C));
            }
        }

        public static double interval_ww_finfin_2_inv(double C,  double x)
        {
            if (C <= 0) return 0;
            if (Math.Abs(x) > 1+double.Epsilon) return 0;  
            else if ((Math.Abs(x) == 1+double.Epsilon) || (Math.Abs(x) == 1 - double.Epsilon))
            {
                return (Math.Sqrt(C) * x * Math.Sqrt(0 + double.Epsilon));
            }
            else return (Math.Sqrt(C) * x * Math.Sqrt(1 - x * x));
        }

        /*    public static double interval_ww_finfin_2_in(double C,  double x)
            {

            }
        */
    }

    public class Function3
    {
        public static double interval_finfin_ww_3(double x)
        {
            if (Math.Cos(x) == 0) return 0;
            else
            {
                return (Math.Tan(x));
            }
        }

        public static double interval_finfin_ww_3_inv(double x)
        {
            return (Math.Atan(x));
        }

        /*    public static double interval_finfin_ww_3_in(double x)
            {

            }
        */
    }

}
