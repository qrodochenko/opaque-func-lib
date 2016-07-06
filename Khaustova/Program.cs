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
            k = C_interval_ww_ww_1.interval_ww_ww_1(0.5, 2, 2, 1.5);
            Console.WriteLine(k);

            k_inv = C_interval_ww_ww_1_inv.interval_ww_ww_1_inv(0.5, 2, 2, 1.5);
            Console.WriteLine(k_inv);

            k = C_interval_ww_ww_1.interval_ww_ww_1(0.5, 2, 2, k_inv);
            Console.WriteLine(k);

            m = C_interval_ww_ww_1.interval_ww_ww_1(0.5, 2, 2, 1.5);
            m_inv = C_interval_ww_ww_1_inv.interval_ww_ww_1_inv(0.5, 2, 2, m);
            Console.WriteLine(m_inv);

            s = C_interval_ww_ww_1_in.interval_ww_ww_1_in();
            Console.WriteLine(s);

            Console.WriteLine();

            //----------------------------------------
            Console.WriteLine("Function 2");
            k = C_interval_ww_finfin_2.interval_ww_finfin_2(2, 5);
            Console.WriteLine(k);

            k_inv = C_interval_ww_finfin_2_inv.interval_ww_finfin_2_inv(2, 0.5);
            Console.WriteLine(k_inv);

            k = C_interval_ww_finfin_2.interval_ww_finfin_2(2, k_inv);
            Console.WriteLine(k);

            m = C_interval_ww_finfin_2.interval_ww_finfin_2(2, 0.5);
            m_inv = C_interval_ww_finfin_2_inv.interval_ww_finfin_2_inv(2, m);
            Console.WriteLine(m_inv);

            s = C_interval_ww_finfin_2_in.interval_ww_finfin_2_in();
            Console.WriteLine(s);

            Console.WriteLine();

            //----------------------------------------
            Console.WriteLine("Function 3");
            k = C_interval_finfin_ww_3.interval_finfin_ww_3(Math.PI/4);
            Console.WriteLine(k);

            k_inv = C_interval_finfin_ww_3_inv.interval_finfin_ww_3_inv(Math.PI/4);
            Console.WriteLine(k_inv);

            k = C_interval_finfin_ww_3.interval_finfin_ww_3(k_inv);
            Console.WriteLine(k);

            m = C_interval_finfin_ww_3.interval_finfin_ww_3(Math.PI/4);
            m_inv = C_interval_finfin_ww_3_inv.interval_finfin_ww_3_inv(m);
            Console.WriteLine(m_inv);

            s = C_interval_finfin_ww_3_in.interval_finfin_ww_3_in();
            Console.WriteLine(s);

            Console.WriteLine();

            //----------------------------------------
            Console.WriteLine("Function 4");
            k = C_interval_finw_finw_4.interval_finw_finw_4(5);
            Console.WriteLine(k);

            k_inv = C_interval_finw_finw_4_inv.interval_finw_finw_4_inv(5);
            Console.WriteLine(k_inv);

            k = C_interval_finw_finw_4.interval_finw_finw_4(k_inv);
            Console.WriteLine(k);

            m = C_interval_finw_finw_4.interval_finw_finw_4(5);
            m_inv = C_interval_finw_finw_4_inv.interval_finw_finw_4_inv(m);
            Console.WriteLine(m_inv);

            s = C_interval_finw_finw_4_in.interval_finw_finw_4_in();
            Console.WriteLine(s);

            Console.WriteLine();

            //----------------------------------------
            Console.WriteLine("Function 5");
            k = C_interval_finw_wfin_5.interval_finw_wfin_5(5);
            Console.WriteLine(k);

            k_inv = C_interval_finw_wfin_5_inv.interval_finw_wfin_5_inv(5);
            Console.WriteLine(k_inv);

            k = C_interval_finw_wfin_5.interval_finw_wfin_5(k_inv);
            Console.WriteLine(k);

            m = C_interval_finw_wfin_5.interval_finw_wfin_5(5);
            m_inv = C_interval_finw_wfin_5_inv.interval_finw_wfin_5_inv(m);
            Console.WriteLine(m_inv);

            s = C_interval_finw_wfin_5_in.interval_finw_wfin_5_in();
            Console.WriteLine(s);

            Console.WriteLine();

            //----------------------------------------
            Console.WriteLine("Function 6");
            k = C_interval_ww_finw_6.interval_ww_finw_6(3, 4, 5);
            Console.WriteLine(k);

            k_inv = C_interval_ww_finw_6_inv.interval_ww_finw_6_inv(3, 4, 5);
            Console.WriteLine(k_inv);

            k = C_interval_ww_finw_6.interval_ww_finw_6(3, 4, k_inv);
            Console.WriteLine(k);

            m = C_interval_ww_finw_6.interval_ww_finw_6(3, 4, 5);
            m_inv = C_interval_ww_finw_6_inv.interval_ww_finw_6_inv(3, 4, m);
            Console.WriteLine(m_inv);

            s = C_interval_ww_finw_6_in.interval_ww_finw_6_in();
            Console.WriteLine(s);

            Console.WriteLine();

            //----------------------------------------
            Console.WriteLine("Function 7");
            k = C_interval_finfin_finfin_7.interval_finfin_finfin_7(1, 4, 5, 6, 2);
            Console.WriteLine(k);

            k_inv = C_interval_finfin_finfin_7_inv.interval_finfin_finfin_7_inv(1, 4, 5, 6, 2);
            Console.WriteLine(k_inv);

            k = C_interval_finfin_finfin_7.interval_finfin_finfin_7(1, 4, 5, 6, k_inv);
            Console.WriteLine(k);

            m = C_interval_finfin_finfin_7.interval_finfin_finfin_7(1, 4, 5, 6, 2);
            m_inv = C_interval_finfin_finfin_7_inv.interval_finfin_finfin_7_inv(1, 4, 5, 6, m);
            Console.WriteLine(m_inv);

            s = C_interval_finfin_finfin_7_in.interval_finfin_finfin_7_in(1, 4);
            Console.WriteLine(s);

            Console.WriteLine();

            //----------------------------------------
            Console.WriteLine("Function 8");
            k = C_interval_finfin_finfin_8.interval_finfin_finfin_8(1, 4, 5, 6, 2);
            Console.WriteLine(k);

            k_inv = C_interval_finfin_finfin_8_inv.interval_finfin_finfin_8_inv(1, 4, 5, 6, 2);
            Console.WriteLine(k_inv);

            k = C_interval_finfin_finfin_8.interval_finfin_finfin_8(1, 4, 5, 6, k_inv);
            Console.WriteLine(k);

            m = C_interval_finfin_finfin_8.interval_finfin_finfin_8(1, 4, 5, 6, 2);
            m_inv = C_interval_finfin_finfin_8_inv.interval_finfin_finfin_8_inv(1, 4, 5, 6, m);
            Console.WriteLine(m_inv);

            s = C_interval_finfin_finfin_8_in.interval_finfin_finfin_8_in(1, 4);
            Console.WriteLine(s);

            Console.WriteLine();

            //----------------------------------------
            Console.WriteLine("Function 9");
            k = C_interval_finfin_finfin_9.interval_finfin_finfin_9(Math.PI/6);
            Console.WriteLine(k);

            k_inv = C_interval_finfin_finfin_9_inv.interval_finfin_finfin_9_inv(Math.PI/6);
            Console.WriteLine(k_inv);

            k = C_interval_finfin_finfin_9.interval_finfin_finfin_9(Math.PI/6);
            Console.WriteLine(k);

            m = C_interval_finfin_finfin_9.interval_finfin_finfin_9(Math.PI/6);
            m_inv = C_interval_finfin_finfin_9_inv.interval_finfin_finfin_9_inv(Math.PI/6);
            Console.WriteLine(m_inv);

            s = C_interval_finfin_finfin_9_in.interval_finfin_finfin_9_in();
            Console.WriteLine(s);

            Console.WriteLine();

            //----------------------------------------
            Console.WriteLine("Function 10");
            k = C_interval_finfin_finfin_10.interval_finfin_finfin_10(Math.PI/4);
            Console.WriteLine(k);

            k_inv = C_interval_finfin_finfin_10_inv.interval_finfin_finfin_10_inv(Math.PI/4);
            Console.WriteLine(k_inv);

            k = C_interval_finfin_finfin_10.interval_finfin_finfin_10(Math.PI/4);
            Console.WriteLine(k);

            m = C_interval_finfin_finfin_10.interval_finfin_finfin_10(Math.PI/4);
            m_inv = C_interval_finfin_finfin_10_inv.interval_finfin_finfin_10_inv(Math.PI/4);
            Console.WriteLine(m_inv);

            s = C_interval_finfin_finfin_10_in.interval_finfin_finfin_10_in();
            Console.WriteLine(s);

            Console.WriteLine();

            Console.ReadKey();
            
        }
    }
}
