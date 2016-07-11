using System;
using OpaqueFunctions;
namespace SummerPractice_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            double Xc = CCos_1.Cos_1(Math.PI / 4.0, 20);
            double X1c = Math.Cos(Math.PI / 4.0);
            Console.WriteLine("Cos check");
            Console.WriteLine(Xc);
            Console.WriteLine(X1c);

            double Xs = CSin_1.Sin_1(Math.PI / 4.0, 20);
            double X1s = Math.Sin(Math.PI / 4.0);
            Console.WriteLine("Sin check");
            Console.WriteLine(Xs);
            Console.WriteLine(X1s);

            double Xarcs = CArcsin_1.Arcsin_1(0.3, 400000);
            double Xarcs1 = Math.Asin(0.3);
            Console.WriteLine("Arcsin check");
            Console.WriteLine(Xarcs);
            Console.WriteLine(Xarcs1);

            double Xarcc = CArccos_1.Arccos_1(0.5, 400000);
            double Xarcc1 = Math.Acos(0.5);
            Console.WriteLine("ArcCos check");
            Console.WriteLine(Xarcc);
            Console.WriteLine(Xarcc1);

            double Xtg = CTg_1.Tg_1(Math.PI / 3.0, 10);
            double Xtg1 = Math.Tan(Math.PI / 3.0);
            Console.WriteLine("Tg check");
            Console.WriteLine(Xtg);
            Console.WriteLine(Xtg1);


            double Xctg = Cctg_1.Сtg_1(Math.PI / 4.0, 10);
            double Xctg1 = 1 / Math.Tan(Math.PI / 4.0);
            Console.WriteLine("Ctg check");
            Console.WriteLine(Xctg);
            Console.WriteLine(Xctg1);

            double Xarctg = CArctg_1.Arctg_1(0.3, 10);
            double Xarctg1 = Math.Atan(0.3);
            Console.WriteLine("Arctg check");
            Console.WriteLine(Xarctg);
            Console.WriteLine(Xarctg1);

            double Xarcctg = CArcctg_1.Arcctg_1(0, 15);
            double Xarcctg1 = Math.PI / 2.0 - Math.Atan(0);
            Console.WriteLine("Arcctg check");
            Console.WriteLine(Xarcctg);
            Console.WriteLine(Xarcctg1);

            double Xcosec = CCosec_1.Cosec_1(Math.PI / 2.0, 13);
            double Xcosec1 = 1 / Math.Sin(Math.PI / 2.0);
            Console.WriteLine("Cosec check");
            Console.WriteLine(Xcosec);
            Console.WriteLine(Xcosec1);

            double Xs2 = CXpow2_Sin_1.Xpow2_Sin_1(Math.PI / 4.0, 10);
            double X1s2 = Math.Sin(Math.PI / 4.0);
            X1s2 *= X1s2;
            Console.WriteLine("Sin^2 check");
            Console.WriteLine(Xs2);
            Console.WriteLine(X1s2);

            double Xc2 = CXpow2_Cos_1.Xpow2_Cos_1(Math.PI / 4.0, 10);
            double X1c2 = Math.Cos(Math.PI / 4.0);
            X1c2 *= X1c2;
            Console.WriteLine("Cos^2 check");
            Console.WriteLine(Xc2);
            Console.WriteLine(X1c2);

            double Xs3 = CXpow3_Sin_1.Xpow3_Sin_1(Math.PI / 4.0, 10);
            double X1s3 = Math.Sin(Math.PI / 4.0);
            X1s3 *= X1s3 * X1s3;
            Console.WriteLine("Sin^3 check");
            Console.WriteLine(Xs3);
            Console.WriteLine(X1s3);

            double Xc3 = CXpow3_Cos_1.Xpow3_Cos_1(Math.PI / 4.0, 10);
            double X1c3 = Math.Cos(Math.PI / 4.0);
            X1c3 *= X1c3 * X1c3;
            Console.WriteLine("Cos^3 check");
            Console.WriteLine(Xc3);
            Console.WriteLine(X1c3);
        }
    }
}
