using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpaqueFunctions;

namespace ModuleTests
{
    [TestClass]
    public class OpaqueFunctionsUnitTest1
    {
        [TestMethod]
        public void Opaque1SinCosTest1()
        {
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                double X = Opaque1SinCos.Body(0.00314 * rnd.Next(100), 0);
                Assert.IsTrue(Math.Abs(X - 1) < double.Epsilon, "Значение функции не единица!");
            }
        }
    }

    [TestClass]
    public class Ctest_Math_Sin
    {
        [TestMethod]
        public void test_Math_Sin_error()
        {
            for (int j = 0; j < 10000000; j++)
                for (int i = 0; i < 10; i++)
                {
                    Random rnd = new Random();
                    double arg = 0.0314 * (rnd.Next(100) - 49);                   
                    double X = CMathApprox_1.MathApprox_1_1(arg);
                    Assert.IsTrue(Math.Abs(X - Math.Sin(arg)) < 0.000000092, "Значение функции недостаточно близко к реальному");
                }
        }

        [TestMethod]
        public void test_Math_Sin_Pow_error()
        {
            for (int j = 0; j < 1000000; j++)
                for (int i = 0; i < 10; i++)
                {
                    Random rnd = new Random();
                    double arg = 0.00314 * rnd.Next(100);
                    double X = CMathApprox_1.MathApprox_1_1_Pow(arg);
                    Assert.IsTrue(Math.Abs(X - Math.Sin(arg)) < 0.00000005, "Значение функции недостаточно близко к реальному");
                }
        }

       
    }

    [TestClass]
    public class Ctest_Math_Exp
    {
        [TestMethod]
        public void Ctest_Math_Exp_error()
        {
            for (int j = 0; j < 1000000; j++)
                for (int i = 0; i < 10; i++)
                {
                    Random rnd = new Random();
                    double arg = 0.001 * rnd.Next(1000);
                    double X = CMathApprox_2.MathApprox_2_1(arg);
                    Assert.IsTrue(Math.Abs(X - Math.Exp(arg)) < 0.00000005, "Значение функции недостаточно близко к реальному");
                }
        }
    }

    [TestClass]
    public class Ctest_Comparison_Pow_NotPow
    {
        [TestMethod]
        public void Sin_Pow()
        {
            for (int i = 0; i < 50; i++)
            {
                double arg = -1.57 + i * 3.14 / 50;
                double X = CMathApprox_1.MathApprox_1_1_Pow(arg);
                Assert.IsTrue(Math.Abs(X - Math.Sin(arg)) < 0.0009, "Значение функции недостаточно близко к реальному");

            }
        }

        [TestMethod]
        public void Sin()
        {
            for (int j = 0; j < 1000000; j++)
            for (int i = 0; i < 50; i++)
            {
                double arg = -1.57 + i * 3.14 / 50;
                double X = CMathApprox_1.MathApprox_1_1(arg);
                Assert.IsTrue(Math.Abs(X - Math.Sin(arg)) < 0.000000092, "Значение функции недостаточно близко к реальному");

            }
        }
    }
}
