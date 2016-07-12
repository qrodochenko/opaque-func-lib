using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpaqueFunctions;

namespace ModuleTests
{
    //стандартный подход:
    //var rnd = new Random(); 
    //l + rnd.nextDouble() * (r - l)
    //Где l и r - левый и правый концы промежутка

    [TestClass] 
    public class CTest_L00_30_1_sin_arccos
    { 
        [TestMethod] 
        public void Test_L00_30_1_sin_arccos()
        {
            double sum = 0;
            double max = double.MinValue;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = -1 + rnd.NextDouble() * 2;

                double F = CL00_30_1_sin_arccos.L00_30_1_sin_arccos(arg);
                sum = sum + F;
                if (F > max)
                    max = F;
            }
            double ave = sum / 10;

            Assert.IsTrue(Math.Abs(max - 0) < double.Epsilon, "Среднее арифметическое не ноль!");
            Assert.IsTrue(Math.Abs(ave - 0) < double.Epsilon, "Максимальное значение не ноль!");
        }

        [TestMethod] 
        public void Test_L00_30_1_sin_arccos_in()
        {
            string str = "(-1, 1)";
            string F = CL00_30_1_sin_arccos_in.L00_30_1_sin_arccos_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!"); 
        } 
    } 

}
