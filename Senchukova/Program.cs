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

            double k = Cinterval_ww_finfin_1.interval_ww_finfin_1(3);

            Console.WriteLine(k);
            Console.WriteLine(Cinterval_ww_finfin_1_in.interval_ww_finfin_1_in());
            Console.ReadKey();
            
        }
    }
}
