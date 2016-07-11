using System;
using OpaqueFunctions;


namespace SummerPractice_2016
{
    class Program
    {
        static void Main(string[] args)
        {

/*            var rnd = new Random();
            var x = (rnd.NextDouble() - 0.5) * double.MaxValue;

            var rnd2 = new Random();
            var y = (rnd2.NextDouble() - 0.5) * double.MaxValue;
*/

//            double F95 = CL00_95_2_sh.L00_95_2_sh(12, 5);
//            double F95 = CL00_95_2_sh.L00_95_2_sh(x, y);

//            Console.WriteLine(x);
//            Console.WriteLine(y);
//            Console.WriteLine(F95);



            double left_range_border = -100.0;
            double right_range_border = 100.0;
            double range = Math.Abs(left_range_border) + Math.Abs(right_range_border);
            int number_of_points = 100;
            double dx = range / 100;
            double dy = range / 100;
            double benchmark = 0;

            double x = 0;
            double y = 0;

            double absoluteError = 0;
            double relativeError = 0;
            //-------------------------------------


            
            System.IO.StreamWriter file86 =
            new System.IO.StreamWriter(@"csv\L00_86_1_th.csv");
            file86.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F86 = CL00_86_1_th.L00_86_1_th(x);
                absoluteError = Math.Abs((F86 - benchmark));
                relativeError = Math.Abs((F86 - benchmark) / F86);
                file86.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file86.Close();
            //-------------------------------------//1,11E-16


            System.IO.StreamWriter file87 =
                        new System.IO.StreamWriter(@"csv\L00_87_2_sh_ch.csv");
            file87.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                y = left_range_border + i * dy;
                double F87 = CL00_87_2_sh_ch.L00_87_2_sh_ch(x, y);
                absoluteError = Math.Abs((F87 - benchmark));
                relativeError = Math.Abs((F87 - benchmark) / F87);
                file87.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file87.Close();
            //-------------------------------------

            System.IO.StreamWriter file88 =
                        new System.IO.StreamWriter(@"csv\L00_88_2_sh_ch.csv");
            file88.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                y = left_range_border + i * dy;
                double F88 = CL00_88_2_sh_ch.L00_88_2_sh_ch(x, y);
                absoluteError = Math.Abs((F88 - benchmark));
                relativeError = Math.Abs((F88 - benchmark) / F88);
                file88.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file88.Close();
            //-------------------------------------

            System.IO.StreamWriter file89 =
                        new System.IO.StreamWriter(@"csv\L00_89_2_ch.csv");
            file89.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                y = left_range_border + i * dy;
                double F89 = CL00_89_2_ch.L00_89_2_ch(x, y);
                absoluteError = Math.Abs((F89 - benchmark));
                relativeError = Math.Abs((F89 - benchmark) / F89);
                file89.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file89.Close();
            //-------------------------------------

            System.IO.StreamWriter file90 =
            new System.IO.StreamWriter(@"csv\L00_90_2_ch_sh.csv");
            file90.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                y = left_range_border + i * dy;
                double F90 = CL00_90_2_ch_sh.L00_90_2_ch_sh(x, y);
                absoluteError = Math.Abs((F90 - benchmark));
                relativeError = Math.Abs((F90 - benchmark) / F90);
                file90.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file90.Close();
            //-------------------------------------

            System.IO.StreamWriter file91 =
            new System.IO.StreamWriter(@"csv\L00_91_2_th_sh_ch.csv");
            file91.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                y = left_range_border + i * dy;
                double F91 = CL00_91_2_th_sh_ch.L00_91_2_th_sh_ch(x, y);
                absoluteError = Math.Abs((F91 - benchmark));
                relativeError = Math.Abs((F91 - benchmark) / F91);
                file91.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file91.Close();
            //-------------------------------------//4,44E-16

            System.IO.StreamWriter file92 =
            new System.IO.StreamWriter(@"csv\L00_92_2_th_sh_ch.csv");
            file92.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                y = left_range_border + i * dy;
                double F92 = CL00_92_2_th_sh_ch.L00_92_2_th_sh_ch(x, y);
                absoluteError = Math.Abs((F92 - benchmark));
                relativeError = Math.Abs((F92 - benchmark) / F92);
                file92.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file92.Close();
            //-------------------------------------

            System.IO.StreamWriter file93 =
            new System.IO.StreamWriter(@"csv\L00_93_2_cth_sh.csv");
            file93.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                y = left_range_border + i * dy;
                double F93 = CL00_93_2_cth_sh.L00_93_2_cth_sh(x, y);
                absoluteError = Math.Abs((F93 - benchmark));
                relativeError = Math.Abs((F93 - benchmark) / F93);
                file93.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file93.Close();
            //-------------------------------------//4,44E-16 //NaN

            System.IO.StreamWriter file94 =
            new System.IO.StreamWriter(@"csv\L00_94_2_cth_sh.csv");
            file94.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                y = left_range_border + i * dy;
                double F94 = CL00_94_2_cth_sh.L00_94_2_cth_sh(x, y);
                absoluteError = Math.Abs((F94 - benchmark));
                relativeError = Math.Abs((F94 - benchmark) / F94);
                file94.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file94.Close();
            //-------------------------------------//NaN

            System.IO.StreamWriter file95 =
                        new System.IO.StreamWriter(@"csv\L00_95_2_sh.csv");
            file95.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                y = left_range_border + i * dy;
                double F95 = CL00_95_2_sh.L00_95_2_sh(x, y);
                absoluteError = Math.Abs((F95 - benchmark));
                relativeError = Math.Abs((F95 - benchmark) / F95);
                file95.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file95.Close();
            //-------------------------------------

            System.IO.StreamWriter file96 =
                        new System.IO.StreamWriter(@"csv\L00_96_2_ch_sh.csv");
            file96.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                y = left_range_border + i * dy;
                double F96 = CL00_96_2_ch_sh.L00_96_2_ch_sh(x, y);
                absoluteError = Math.Abs((F96 - benchmark));
                relativeError = Math.Abs((F96 - benchmark) / F96);
                file96.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file96.Close();
            //-------------------------------------

            System.IO.StreamWriter file97 =
                        new System.IO.StreamWriter(@"csv\L00_97_2_sh_ch.csv");
            file97.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                y = left_range_border + i * dy;
                double F97 = CL00_97_2_sh_ch.L00_97_2_sh_ch(x, y);
                absoluteError = Math.Abs((F97 - benchmark));
                relativeError = Math.Abs((F97 - benchmark) / F97);
                file97.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file97.Close();
            //-------------------------------------

            System.IO.StreamWriter file98 =
                        new System.IO.StreamWriter(@"csv\L00_98_2_sh_ch.csv");
            file98.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                y = left_range_border + i * dy;
                double F98 = CL00_98_2_sh_ch.L00_98_2_sh_ch(x, y);
                absoluteError = Math.Abs((F98 - benchmark));
                relativeError = Math.Abs((F98 - benchmark) / F98);
                file98.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file98.Close();
            //-------------------------------------//5,52E+70

            System.IO.StreamWriter file99 =
                        new System.IO.StreamWriter(@"csv\L00_99_2_log.csv");
            file99.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx - left_range_border;
                y = left_range_border + i * dy - left_range_border;
                double F99 = CL00_99_2_log.L00_99_2_log(x, y);
                absoluteError = Math.Abs((F99 - benchmark));
                relativeError = Math.Abs((F99 - benchmark) / F99);
                file99.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file99.Close();
            //-------------------------------------//2,22E-16 //NaN

            System.IO.StreamWriter file100 =
                        new System.IO.StreamWriter(@"csv\L00_100_3_log.csv");
            file100.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");

            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx - left_range_border;
                y = left_range_border + i * dy - left_range_border;
                double F100 = CL00_100_3_log.L00_100_3_log(x, y);
                absoluteError = Math.Abs((F100 - benchmark));
                relativeError = Math.Abs((F100 - benchmark) / F100);
                file100.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file100.Close();
            //-------------------------------------//NaN





/*            Random rnd = new Random(), rnd2 = new Random();
            double x = rnd.NextDouble() * 100, y = rnd.NextDouble() * 100;

            double F86 = CL00_86_1_th.L00_86_1_th(x);
            double F87 = CL00_87_2_sh_ch.L00_87_2_sh_ch(x, y);
            double F88 = CL00_88_2_sh_ch.L00_88_2_sh_ch(x, y);
            double F89 = CL00_89_2_ch.L00_89_2_ch(x, y);
            double F90 = CL00_90_2_ch_sh.L00_90_2_ch_sh(x, y);
            double F91 = CL00_91_2_th_sh_ch.L00_91_2_th_sh_ch(x, y);
            double F92 = CL00_92_2_th_sh_ch.L00_92_2_th_sh_ch(x, y);
            double F93 = CL00_93_2_cth_sh.L00_93_2_cth_sh(x, y);
            double F94 = CL00_94_2_cth_sh.L00_94_2_cth_sh(x, y); 
            double F95 = CL00_95_2_sh.L00_95_2_sh(x, y);
            double F96 = CL00_96_2_ch_sh.L00_96_2_ch_sh(x, y);
            double F97 = CL00_97_2_sh_ch.L00_97_2_sh_ch(x, y);
            double F98 = CL00_98_2_sh_ch.L00_98_2_sh_ch(x, y);
            double F99 = CL00_99_2_log.L00_99_2_log(x);
            double F100 = CL00_100_3_log.L00_100_3_log(x, y);
            double F101 = CL00_101_3_log.L00_101_3_log(x, y);
            double F102 = CL00_102_3_log.L00_102_3_log(x);
            double F103 = CL00_103_3_log.L00_103_3_log(x);
            double F104 = CL00_104_1_ln_arsh.L00_104_1_ln_arsh(x);
            double F105 = CL00_105_1_ln_arch.L00_105_1_ln_arch(x);
            double F106 = CL00_106_1_ln_arth.L00_106_1_ln_arth(x);
            double F107 = CL00_107_2_pow_exp.L00_107_2_pow_exp(x);
            double F108 = CL00_108_3_pow.L00_108_3_pow(x, y);
            double F109 = CL00_109_3_pow.L00_109_3_pow(x, y);
            double F110 = CL00_110_3_pow.L00_110_3_pow(x, y);
            double F111 = CL00_111_1_exp_th.L00_111_1_exp_th(x);
            double F112 = CL00_112_1_exp_ch_sh.L00_112_1_exp_ch_sh(x);
            double F113 = CL00_113_1_ch_sh_th.L00_113_1_ch_sh_th(x);
            Console.WriteLine(F86); 

            Console.WriteLine(F86); 
            Console.WriteLine(F87);//
            Console.WriteLine(F88);//
            Console.WriteLine(F89);  //
            Console.WriteLine(F90);//
            Console.WriteLine(F91);//
            Console.WriteLine(F92);  
            Console.WriteLine(F93);  //   yt
            Console.WriteLine(F94);    //? 
            Console.WriteLine(F95);//
            Console.WriteLine(F96);  //
            Console.WriteLine(F97);  //
            Console.WriteLine(F98);  //
            Console.WriteLine(F99);    //   \/ yt
            Console.WriteLine(F100);
            Console.WriteLine(F101);    
            Console.WriteLine(F102);
            Console.WriteLine(F103);  //   /\ yt
            Console.WriteLine(F104);
            Console.WriteLine(F105); // yt
            Console.WriteLine(F106);    
            Console.WriteLine(F107); //
            Console.WriteLine(F108); //
            Console.WriteLine(F109);//
            Console.WriteLine(F110);//
            Console.WriteLine(F111); //
            Console.WriteLine(F112);  //
            Console.WriteLine(F113); //


     */       





            //Убрать вызов от нуля там, где NaN
            //Дописать файлы
        }
    }
}
