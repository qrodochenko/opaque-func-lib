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
            Console.WriteLine(Xc);
            Console.WriteLine(X1c);

            double Xs = CSin_1.Sin_1(Math.PI / 4.0, 20);
            double X1s = Math.Sin(Math.PI / 4.0);
            Console.WriteLine(Xs);
            Console.WriteLine(X1s);

            double Xarcs = CArcsin_1.Arcsin_1(0.5, 4000000);
            double Xarcs1 = Math.Asin(0.5);
            Console.WriteLine(Xarcs);
            Console.WriteLine(Xarcs1);

            double Xarcc = CArccos_1.Arccos_1(0.5, 400000);
            double Xarcc1 = Math.Acos(0.5);
            Console.WriteLine(Xarcc);
            Console.WriteLine(Xarcc1);

            double Xtg = CTg_1.Tg_1(Math.PI / 3.0, 10);
            double Xtg1 = Math.Tan(Math.PI / 3.0);
            Console.WriteLine(Xtg);
            Console.WriteLine(Xtg1);

           // double Ber = Bernoulli.Ber(20);
          //  Console.WriteLine(Ber);
        }
    }
}
