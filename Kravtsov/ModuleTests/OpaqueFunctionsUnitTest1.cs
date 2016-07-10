using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpaqueFunctions;

namespace ModuleTests
{
    [TestClass]
    public class CTest_Sin_1
    {
        [TestMethod]
        public void Test_Sin_1()
        {
            
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                double arg = (rnd.NextDouble() - 0.5) * Math.PI;
                double X = OpaqueFunctions.CSin_1.Sin_1(arg, 500);
                Assert.IsTrue(Math.Abs(X - Math.Sin(arg)) < 0.000000192, "Значение функции недостаточно близко к реальному");
            }
        }
    }
    [TestClass]
    public class CTest_Cos_1
    {
        [TestMethod]
        public void Test_Cos_1()
        {

            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                double arg = rnd.NextDouble() * Math.PI;
                double X = OpaqueFunctions.CCos_1.Cos_1(arg, 10);
                Assert.IsTrue(Math.Abs(X - Math.Cos(arg)) < 0.000000092, "Значение функции недостаточно близко к реальному");
            }
        }
    }

}