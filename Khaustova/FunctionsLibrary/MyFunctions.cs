using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsLibrary
{
    public class MyFunctions
    {
        public static double interval_ww_ww_1(float A, float B, int k, double x)
        {
            double t = x + A;
            int p = 2*k+1;

          /*  for (int i = 0; i <= p; i++ )
            {
                g *= (x + A);
            } */
                return (Math.Pow(t, p) + B);
        }

        public static double interval_ww_ww_1_inv(float A, float B, int k, double x)
        {
            double t = x + B;
            double p = 1/(2*k+1);
            return (Math.Pow(t, p) - A);
        }
    }

}
