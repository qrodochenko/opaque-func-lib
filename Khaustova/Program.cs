using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionsLibrary;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            double k; double k_inv;
            double m; double m_inv;
            string s;

            //---------------------------------
            Console.WriteLine("Function 1");
            k = Cinterval_ww_ww_1.interval_ww_ww_1(1.5, 0.5, 2, 2);
            Console.WriteLine(k);

            k_inv = Cinterval_ww_ww_1_inv.interval_ww_ww_1_inv(1.5, 0.5, 2, 2);
            Console.WriteLine(k_inv);

            k = Cinterval_ww_ww_1.interval_ww_ww_1(k_inv, 0.5, 2, 2);
            Console.WriteLine(k);

            m = Cinterval_ww_ww_1.interval_ww_ww_1(1.5, 0.5, 2, 2);
            m_inv = Cinterval_ww_ww_1_inv.interval_ww_ww_1_inv(m, 0.5, 2, 2);
            Console.WriteLine(m_inv);

            s = Cinterval_ww_ww_1_in.interval_ww_ww_1_in();
            Console.WriteLine(s);

            Random R = new Random();
            for (int i = 1; i <= 10; i++)
            {   
                double x = Convert.ToDouble(R.Next(-1000, 1000) / 100.0);
                double A = Convert.ToDouble(R.Next(-1000, 1000) / 100.0);
                double B = Convert.ToDouble(R.Next(-1000, 1000) / 100.0);
                int k1 = R.Next(-10, 10);

                Console.WriteLine("A = " + A.ToString());
                Console.WriteLine("B = " + B.ToString());
                Console.WriteLine("k = " + k1.ToString());

                Console.WriteLine("x = " + x.ToString());
                 k_inv = Cinterval_ww_ww_1_inv.interval_ww_ww_1_inv(x, A, B, k1);
                 k = Cinterval_ww_ww_1.interval_ww_ww_1(k_inv, A, B, k1);

                 m = Cinterval_ww_ww_1.interval_ww_ww_1(x, A, B, k1);
                 m_inv = Cinterval_ww_ww_1_inv.interval_ww_ww_1_inv(m, A, B, k1);

                Console.WriteLine("g_inv(x) = " + k_inv.ToString());
                Console.WriteLine("g(g_inv(x)) = " + k.ToString());
                Console.WriteLine("g(x) = " + m.ToString());
                Console.WriteLine("g_inv(g(x)) = " + m_inv.ToString());
                Console.WriteLine();
            }

            Console.WriteLine();

       /*     //----------------------------------------
            Console.WriteLine("Function 2");
            k = Cinterval_ww_finfin_2.interval_ww_finfin_2(2, 5);
            Console.WriteLine(k);

            k_inv = Cinterval_ww_finfin_2_inv.interval_ww_finfin_2_inv(2, 0.5);
            Console.WriteLine(k_inv);

            k = Cinterval_ww_finfin_2.interval_ww_finfin_2(2, k_inv);
            Console.WriteLine(k);

            m = Cinterval_ww_finfin_2.interval_ww_finfin_2(2, 0.5);
            m_inv = Cinterval_ww_finfin_2_inv.interval_ww_finfin_2_inv(2, m);
            Console.WriteLine(m_inv);

            s = Cinterval_ww_finfin_2_in.interval_ww_finfin_2_in();
            Console.WriteLine(s);


            for (int i = 1; i <= 10; i++)
            {
                double x = Convert.ToDouble(R.Next(-1000000, 1000000) / 1000.0);
                double C = Convert.ToDouble(R.Next(-10000, 10000) / 1000.0);

                Console.WriteLine(x);
                Console.WriteLine(C);

                k_inv = Cinterval_ww_finfin_2_inv.interval_ww_finfin_2_inv(x, C);
                k = Cinterval_ww_finfin_2.interval_ww_finfin_2(k_inv, C);

                m = Cinterval_ww_finfin_2.interval_ww_finfin_2(x, C);
                m_inv = Cinterval_ww_finfin_2_inv.interval_ww_finfin_2_inv(m, C);

                Console.WriteLine(k);
                Console.WriteLine(k_inv);
                Console.WriteLine(m);
                Console.WriteLine(m_inv);
                Console.WriteLine();
            }

                Console.WriteLine();

            //----------------------------------------
            Console.WriteLine("Function 3");
            k = Cinterval_finfin_ww_3.interval_finfin_ww_3(Math.PI/4);
            Console.WriteLine(k);

            k_inv = Cinterval_finfin_ww_3_inv.interval_finfin_ww_3_inv(Math.PI/4);
            Console.WriteLine(k_inv);

            k = Cinterval_finfin_ww_3.interval_finfin_ww_3(k_inv);
            Console.WriteLine(k);

            m = Cinterval_finfin_ww_3.interval_finfin_ww_3(Math.PI/4);
            m_inv = Cinterval_finfin_ww_3_inv.interval_finfin_ww_3_inv(m);
            Console.WriteLine(m_inv);

            s = Cinterval_finfin_ww_3_in.interval_finfin_ww_3_in();
            Console.WriteLine(s);

            for (int i = 1; i <= 10; i++)
            {
                double x = Convert.ToDouble(R.Next(-1570796326, 1570796327) / 1000000000.0);

                k_inv = Cinterval_finfin_ww_3_inv.interval_finfin_ww_3_inv(x);
                k = Cinterval_finfin_ww_3.interval_finfin_ww_3(k_inv);

                m = Cinterval_finfin_ww_3.interval_finfin_ww_3(x);
                m_inv = Cinterval_finfin_ww_3_inv.interval_finfin_ww_3_inv(m);

                Console.WriteLine(k);
                Console.WriteLine(k_inv);
                Console.WriteLine(m);
                Console.WriteLine(m_inv);
                Console.WriteLine();
            }

            Console.WriteLine();

            //----------------------------------------
            Console.WriteLine("Function 4");
            k = Cinterval_finw_finw_4.interval_finw_finw_4(5);
            Console.WriteLine(k);

            k_inv = Cinterval_finw_finw_4_inv.interval_finw_finw_4_inv(5);
            Console.WriteLine(k_inv);

            k = Cinterval_finw_finw_4.interval_finw_finw_4(k_inv);
            Console.WriteLine(k);

            m = Cinterval_finw_finw_4.interval_finw_finw_4(5);
            m_inv = Cinterval_finw_finw_4_inv.interval_finw_finw_4_inv(m);
            Console.WriteLine(m_inv);

            s = Cinterval_finw_finw_4_in.interval_finw_finw_4_in();
            Console.WriteLine(s);

            Console.WriteLine();

            //----------------------------------------
            Console.WriteLine("Function 5");
            k = Cinterval_finw_wfin_5.interval_finw_wfin_5(5);
            Console.WriteLine(k);

            k_inv = Cinterval_finw_wfin_5_inv.interval_finw_wfin_5_inv(5);
            Console.WriteLine(k_inv);

            k = Cinterval_finw_wfin_5.interval_finw_wfin_5(k_inv);
            Console.WriteLine(k);

            m = Cinterval_finw_wfin_5.interval_finw_wfin_5(5);
            m_inv = Cinterval_finw_wfin_5_inv.interval_finw_wfin_5_inv(m);
            Console.WriteLine(m_inv);

            s = Cinterval_finw_wfin_5_in.interval_finw_wfin_5_in();
            Console.WriteLine(s);

            Console.WriteLine();

            //----------------------------------------
            Console.WriteLine("Function 6");
            k = Cinterval_ww_finw_6.interval_ww_finw_6(3, 4, 5);
            Console.WriteLine(k);

            k_inv = Cinterval_ww_finw_6_inv.interval_ww_finw_6_inv(3, 4, 5);
            Console.WriteLine(k_inv);

            k = Cinterval_ww_finw_6.interval_ww_finw_6(3, 4, k_inv);
            Console.WriteLine(k);

            m = Cinterval_ww_finw_6.interval_ww_finw_6(3, 4, 5);
            m_inv = Cinterval_ww_finw_6_inv.interval_ww_finw_6_inv(3, 4, m);
            Console.WriteLine(m_inv);

            s = Cinterval_ww_finw_6_in.interval_ww_finw_6_in();
            Console.WriteLine(s);

            Console.WriteLine();

            //----------------------------------------
            Console.WriteLine("Function 7");
            k = Cinterval_finfin_finfin_7.interval_finfin_finfin_7(1, 4, 5, 6, 2);
            Console.WriteLine(k);

            k_inv = Cinterval_finfin_finfin_7_inv.interval_finfin_finfin_7_inv(1, 4, 5, 6, 2);
            Console.WriteLine(k_inv);

            k = Cinterval_finfin_finfin_7.interval_finfin_finfin_7(1, 4, 5, 6, k_inv);
            Console.WriteLine(k);

            m = Cinterval_finfin_finfin_7.interval_finfin_finfin_7(1, 4, 5, 6, 2);
            m_inv = Cinterval_finfin_finfin_7_inv.interval_finfin_finfin_7_inv(1, 4, 5, 6, m);
            Console.WriteLine(m_inv);

            s = Cinterval_finfin_finfin_7_in.interval_finfin_finfin_7_in(1, 4);
            Console.WriteLine(s);

            Console.WriteLine();

            //----------------------------------------
            Console.WriteLine("Function 8");
            k = Cinterval_finfin_finfin_8.interval_finfin_finfin_8(1, 4, 5, 6, 2);
            Console.WriteLine(k);

            k_inv = Cinterval_finfin_finfin_8_inv.interval_finfin_finfin_8_inv(1, 4, 5, 6, 2);
            Console.WriteLine(k_inv);

            k = Cinterval_finfin_finfin_8.interval_finfin_finfin_8(1, 4, 5, 6, k_inv);
            Console.WriteLine(k);

            m = Cinterval_finfin_finfin_8.interval_finfin_finfin_8(1, 4, 5, 6, 2);
            m_inv = Cinterval_finfin_finfin_8_inv.interval_finfin_finfin_8_inv(1, 4, 5, 6, m);
            Console.WriteLine(m_inv);

            s = Cinterval_finfin_finfin_8_in.interval_finfin_finfin_8_in(1, 4);
            Console.WriteLine(s);

            Console.WriteLine();

            //----------------------------------------
            Console.WriteLine("Function 9");
            k = Cinterval_finfin_finfin_9.interval_finfin_finfin_9(Math.PI/6);
            Console.WriteLine(k);

            k_inv = Cinterval_finfin_finfin_9_inv.interval_finfin_finfin_9_inv(Math.PI/6);
            Console.WriteLine(k_inv);

            k = Cinterval_finfin_finfin_9.interval_finfin_finfin_9(Math.PI/6);
            Console.WriteLine(k);

            m = Cinterval_finfin_finfin_9.interval_finfin_finfin_9(Math.PI/6);
            m_inv = Cinterval_finfin_finfin_9_inv.interval_finfin_finfin_9_inv(Math.PI/6);
            Console.WriteLine(m_inv);

            s = Cinterval_finfin_finfin_9_in.interval_finfin_finfin_9_in();
            Console.WriteLine(s);

            Console.WriteLine();

            //----------------------------------------
            Console.WriteLine("Function 10");
            k = Cinterval_finfin_finfin_10.interval_finfin_finfin_10(Math.PI/4);
            Console.WriteLine(k);

            k_inv = Cinterval_finfin_finfin_10_inv.interval_finfin_finfin_10_inv(Math.PI/4);
            Console.WriteLine(k_inv);

            k = Cinterval_finfin_finfin_10.interval_finfin_finfin_10(Math.PI/4);
            Console.WriteLine(k);

            m = Cinterval_finfin_finfin_10.interval_finfin_finfin_10(Math.PI/4);
            m_inv = Cinterval_finfin_finfin_10_inv.interval_finfin_finfin_10_inv(Math.PI/4);
            Console.WriteLine(m_inv);

            s = Cinterval_finfin_finfin_10_in.interval_finfin_finfin_10_in();
            Console.WriteLine(s);

            Console.WriteLine();

*/

            Console.ReadKey();
            
        }
    }
}
