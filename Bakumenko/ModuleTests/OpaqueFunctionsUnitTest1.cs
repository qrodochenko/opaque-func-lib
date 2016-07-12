using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpaqueFunctions;

namespace ModuleTests
{
    //стандартный подход:
    //var rnd = new Random(); 
    //l + rnd.nextDouble() * (r - l)
    //Где l и r - левый и правый концы промежутка


    //-----------------------
    //L00_30_1_sin_arccos(_in)

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


    //-----------------------
    //L00_31_1_cos_arcsin(_in)

    [TestClass]
    public class CTest_L00_31_1_cos_arcsin
    {
        [TestMethod]
        public void Test_L00_31_1_cos_arcsin()
        {
            double sum = 0;
            double max = double.MinValue;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = -1 + rnd.NextDouble() * 2;

                double F = CL00_31_1_cos_arcsin.L00_31_1_cos_arcsin(arg);
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
            string F = CL00_31_1_cos_arcsin_in.L00_31_1_cos_arcsin_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_32_1_sin_arctg_cos_arcctg

    [TestClass]
    public class CTest_L00_32_1_sin_arctg_cos_arcctg
    {
        [TestMethod]
        public void Test_L00_32_1_sin_arctg_cos_arcctg()
        {
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = rnd.NextDouble() * double.MaxValue;

                double F = CL00_32_1_sin_arctg_cos_arcctg.L00_32_1_sin_arctg_cos_arcctg(arg);
                Assert.IsTrue(Math.Abs(F - 0) < double.Epsilon, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_32_1_sin_arctg_cos_arcctg_in()
        {
            string str = "(w, w)";
            string F = CL00_32_1_sin_arctg_cos_arcctg_in.L00_32_1_sin_arctg_cos_arcctg_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }
}
