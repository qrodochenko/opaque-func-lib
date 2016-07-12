using System;
using OpaqueFunctions;

namespace SummerPractice_2016
{
    class Program
    {

        static void Main(string[] args)
        {

            double left_range_border = -100.0;
            double right_range_border = 100.0;
            double range = Math.Abs(left_range_border) + Math.Abs(right_range_border);
            int number_of_points = 100;
            double dx = range / 100;
            double dy = range / 100;
            double benchmark = 0;

            double x = 0;

            double absoluteError = 0;
            double relativeError = 0;

            //-----------------------
            //L00_30_1_sin_arccos

            System.IO.StreamWriter file30 =
            new System.IO.StreamWriter(@"csv\L00_30_1_sin_arccos");
            file30.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F30 = CL00_30_1_sin_arccos.L00_30_1_sin_arccos(x);
                absoluteError = Math.Abs((F30 - benchmark));
                relativeError = Math.Abs((F30 - benchmark) / F30);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file30.Close();


            //-----------------------
            //L00_31_1_cos_arcsin

            System.IO.StreamWriter file31 =
            new System.IO.StreamWriter(@"csv\L00_31_1_cos_arcsin");
            file31.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F31 = CL00_31_1_cos_arcsin.L00_31_1_cos_arcsin(x);
                absoluteError = Math.Abs((F31 - benchmark));
                relativeError = Math.Abs((F31 - benchmark) / F31);
                file31.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file31.Close();


            //-----------------------
            //L00_32_1_sin_arctg_cos_arcctg

            System.IO.StreamWriter file32 =
            new System.IO.StreamWriter(@"csv\L00_32_1_sin_arctg_cos_arcctg");
            file32.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F32 = CL00_32_1_sin_arctg_cos_arcctg.L00_32_1_sin_arctg_cos_arcctg(x);
                absoluteError = Math.Abs((F32 - benchmark));
                relativeError = Math.Abs((F32 - benchmark) / F32);
                file32.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file32.Close();


            //-----------------------
            //L00_33_1_sin_arctg

            System.IO.StreamWriter file33 =
            new System.IO.StreamWriter(@"csv\L00_30_1_sin_arccos");
            file33.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F33 = CL00_33_1_sin_arctg.L00_33_1_sin_arctg(x);
                absoluteError = Math.Abs((F33 - benchmark));
                relativeError = Math.Abs((F33 - benchmark) / F33);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file33.Close();


            //-----------------------
            //L00_34_1_cos_arcctg

            System.IO.StreamWriter file34 =
            new System.IO.StreamWriter(@"csv\L00_34_1_cos_arcctg");
            file34.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F34 = CL00_34_1_cos_arcctg.L00_34_1_cos_arcctg(x);
                absoluteError = Math.Abs((F34 - benchmark));
                relativeError = Math.Abs((F34 - benchmark) / F34);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file34.Close();


            //-----------------------
            //L00_35_1_cos_arctg

            System.IO.StreamWriter file35 =
            new System.IO.StreamWriter(@"csv\L00_35_1_cos_arctg");
            file33.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F35 = CL00_35_1_cos_arctg.L00_35_1_cos_arctg(x);
                absoluteError = Math.Abs((F35 - benchmark));
                relativeError = Math.Abs((F35 - benchmark) / F35);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file35.Close();


            //-----------------------
            //L00_36_1_sin_arcctg

            System.IO.StreamWriter file36 =
            new System.IO.StreamWriter(@"csv\L00_36_1_sin_arcctg");
            file36.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F36 = CL00_36_1_sin_arcctg.L00_36_1_sin_arcctg(x);
                absoluteError = Math.Abs((F36 - benchmark));
                relativeError = Math.Abs((F36 - benchmark) / F36);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file36.Close();


            //-----------------------
            //L00_37_1_tg_arcsin

            System.IO.StreamWriter file37 =
            new System.IO.StreamWriter(@"csv\L00_37_1_tg_arcsin");
            file37.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F37 = CL00_37_1_tg_arcsin.L00_37_1_tg_arcsin(x);
                absoluteError = Math.Abs((F37 - benchmark));
                relativeError = Math.Abs((F37 - benchmark) / F37);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file37.Close();


            //-----------------------
            //L00_38_1_ctg_arccos

            System.IO.StreamWriter file38 =
            new System.IO.StreamWriter(@"csv\L00_38_1_ctg_arccos");
            file38.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F38 = CL00_38_1_ctg_arccos.L00_38_1_ctg_arccos(x);
                absoluteError = Math.Abs((F38 - benchmark));
                relativeError = Math.Abs((F38 - benchmark) / F38);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file38.Close();


            //-----------------------
            //L00_39_1_tg_arccos

            System.IO.StreamWriter file39 =
            new System.IO.StreamWriter(@"csv\L00_39_1_tg_arccos");
            file39.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F39 = CL00_39_1_tg_arccos.L00_39_1_tg_arccos(x);
                absoluteError = Math.Abs((F39 - benchmark));
                relativeError = Math.Abs((F39 - benchmark) / F39);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file39.Close();


            //-----------------------
            //L00_40_1_ctg_arcsin

            System.IO.StreamWriter file40 =
            new System.IO.StreamWriter(@"csv\L00_40_1_ctg_arcsin");
            file40.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F40 = CL00_40_1_ctg_arcsin.L00_40_1_ctg_arcsin(x);
                absoluteError = Math.Abs((F40 - benchmark));
                relativeError = Math.Abs((F40 - benchmark) / F40);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file40.Close();


            //-----------------------
            //L00_41_1_sin_arcctg_cos_arctg

            System.IO.StreamWriter file41 =
            new System.IO.StreamWriter(@"csv\L00_41_1_sin_arcctg_cos_arctg");
            file41.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F41 = CL00_41_1_sin_arcctg_cos_arctg.L00_41_1_sin_arcctg_cos_arctg(x);
                absoluteError = Math.Abs((F41 - benchmark));
                relativeError = Math.Abs((F41 - benchmark) / F41);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file41.Close();


            //-----------------------
            //L00_42_1_tg_arctg

            System.IO.StreamWriter file42 =
            new System.IO.StreamWriter(@"csv\L00_42_1_tg_arctg");
            file42.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F42 = CL00_42_1_tg_arctg.L00_42_1_tg_arctg(x);
                absoluteError = Math.Abs((F42 - benchmark));
                relativeError = Math.Abs((F42 - benchmark) / F42);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file42.Close();


            //-----------------------
            //L00_43_1_tg_arcsin_ctg_arccos

            System.IO.StreamWriter file43 =
            new System.IO.StreamWriter(@"csv\L00_43_1_tg_arcsin_ctg_arccos");
            file43.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F43 = CL00_43_1_tg_arcsin_ctg_arccos.L00_43_1_tg_arcsin_ctg_arccos(x);
                absoluteError = Math.Abs((F43 - benchmark));
                relativeError = Math.Abs((F43 - benchmark) / F43);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file43.Close();


            //-----------------------
            //L00_44_1_tg_arccos_ctg_arcsin

            System.IO.StreamWriter file44 =
            new System.IO.StreamWriter(@"csv\L00_44_1_tg_arccos_ctg_arcsin");
            file44.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F44 = CL00_44_1_tg_arccos_ctg_arcsin.L00_44_1_tg_arccos_ctg_arcsin(x);
                absoluteError = Math.Abs((F44 - benchmark));
                relativeError = Math.Abs((F44 - benchmark) / F44);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file44.Close();


            //-----------------------
            //L00_45_1_ctg_arcctg

            System.IO.StreamWriter file45 =
            new System.IO.StreamWriter(@"csv\L00_45_1_ctg_arcctg");
            file45.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F45 = CL00_45_1_ctg_arcctg.L00_45_1_ctg_arcctg(x);
                absoluteError = Math.Abs((F45 - benchmark));
                relativeError = Math.Abs((F45 - benchmark) / F45);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file45.Close();


            //-----------------------
            //L00_46_1_arcsin_sin

            System.IO.StreamWriter file46 =
            new System.IO.StreamWriter(@"csv\L00_46_1_arcsin_sin");
            file46.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F46 = CL00_46_1_arcsin_sin.L00_46_1_arcsin_sin(x);
                absoluteError = Math.Abs((F46 - benchmark));
                relativeError = Math.Abs((F46 - benchmark) / F46);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file46.Close();


            //-----------------------
            //L00_47_1_arccos_cos

            System.IO.StreamWriter file47 =
            new System.IO.StreamWriter(@"csv\L00_47_1_arccos_cos");
            file47.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F47 = CL00_47_1_arccos_cos.L00_47_1_arccos_cos(x);
                absoluteError = Math.Abs((F47 - benchmark));
                relativeError = Math.Abs((F47 - benchmark) / F47);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file47.Close();


            //-----------------------
            //L00_48_1_arctg_tg

            System.IO.StreamWriter file48 =
            new System.IO.StreamWriter(@"csv\L00_48_1_arctg_tg");
            file48.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F48 = CL00_48_1_arctg_tg.L00_48_1_arctg_tg(x);
                absoluteError = Math.Abs((F48 - benchmark));
                relativeError = Math.Abs((F48 - benchmark) / F48);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file48.Close();


            //-----------------------
            //L00_49_1_arcctg_ctg

            System.IO.StreamWriter file49 =
            new System.IO.StreamWriter(@"csv\L00_49_1_arcctg_ctg");
            file49.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F49 = CL00_49_1_arcctg_ctg.L00_49_1_arcctg_ctg(x);
                absoluteError = Math.Abs((F49 - benchmark));
                relativeError = Math.Abs((F49 - benchmark) / F49);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file49.Close();


            //-----------------------
            //L00_50_1_arctg_arcctg

            System.IO.StreamWriter file50 =
            new System.IO.StreamWriter(@"csv\L00_50_1_arctg_arcctg");
            file50.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F50 = CL00_50_1_arctg_arcctg.L00_50_1_arctg_arcctg(x);
                absoluteError = Math.Abs((F50 - benchmark));
                relativeError = Math.Abs((F50 - benchmark) / F50);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file50.Close();


            //-----------------------
            //L00_51_1_arctg_arcsin

            System.IO.StreamWriter file51 =
            new System.IO.StreamWriter(@"csv\L00_51_1_arctg_arcsin");
            file51.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F51 = CL00_51_1_arctg_arcsin.L00_51_1_arctg_arcsin(x);
                absoluteError = Math.Abs((F51 - benchmark));
                relativeError = Math.Abs((F51 - benchmark) / F51);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file51.Close();


            //-----------------------
            //L00_52_1_arcsin_arccos

            System.IO.StreamWriter file52 =
            new System.IO.StreamWriter(@"csv\L00_52_1_arcsin_arccos");
            file52.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F52 = CL00_52_1_arcsin_arccos.L00_52_1_arcsin_arccos(x);
                absoluteError = Math.Abs((F52 - benchmark));
                relativeError = Math.Abs((F52 - benchmark) / F52);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file52.Close();


            //-----------------------
            //L00_53_1_arcctg_arcsin

            System.IO.StreamWriter file53 =
            new System.IO.StreamWriter(@"csv\L00_53_1_arcctg_arcsin");
            file53.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F53 = CL00_53_1_arcctg_arcsin.L00_53_1_arcctg_arcsin(x);
                absoluteError = Math.Abs((F53 - benchmark));
                relativeError = Math.Abs((F53 - benchmark) / F53);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file53.Close();


            //-----------------------
            //L00_54_1_arccos_arcctg

            System.IO.StreamWriter file54 =
            new System.IO.StreamWriter(@"csv\L00_54_1_arccos_arcctg");
            file54.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F54 = CL00_54_1_arccos_arcctg.L00_54_1_arccos_arcctg(x);
                absoluteError = Math.Abs((F54 - benchmark));
                relativeError = Math.Abs((F54 - benchmark) / F54);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file54.Close();


            //-----------------------
            //L00_55_1_arccos_arcctg

            System.IO.StreamWriter file55 =
            new System.IO.StreamWriter(@"csv\L00_55_1_arccos_arcctg");
            file55.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F55 = CL00_55_1_arccos_arcctg.L00_55_1_arccos_arcctg(x);
                absoluteError = Math.Abs((F55 - benchmark));
                relativeError = Math.Abs((F55 - benchmark) / F55);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file55.Close();


            //-----------------------
            //L00_56_1_arccos_arctg

            System.IO.StreamWriter file56 =
            new System.IO.StreamWriter(@"csv\L00_56_1_arccos_arctg");
            file56.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F56 = CL00_56_1_arccos_arctg.L00_56_1_arccos_arctg(x);
                absoluteError = Math.Abs((F56 - benchmark));
                relativeError = Math.Abs((F56 - benchmark) / F56);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file56.Close();


            //-----------------------
            //L00_57_1_arctg_arcsin

            System.IO.StreamWriter file57 =
            new System.IO.StreamWriter(@"csv\L00_57_1_arctg_arcsin");
            file57.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
            for (int i = 0; i <= number_of_points; i++)
            {
                x = left_range_border + i * dx;
                double F57 = CL00_57_1_arctg_arcsin.L00_57_1_arctg_arcsin(x);
                absoluteError = Math.Abs((F57 - benchmark));
                relativeError = Math.Abs((F57 - benchmark) / F57);
                file30.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
            }
            file57.Close();
        }
    }
}
