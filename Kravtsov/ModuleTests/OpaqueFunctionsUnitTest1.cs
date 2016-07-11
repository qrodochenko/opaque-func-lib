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
                double threshold = 1e-2;
                double arg = (rnd.NextDouble() - 0.5) * (Math.PI-1e-17);
                double X = OpaqueFunctions.CSin_1.Sin_1(arg, 20);
                Assert.IsTrue(Math.Abs(X - Math.Sin(arg)) <threshold, "Значение функции недостаточно близко к реальному");
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
                double threshold = 1e-3;
                double arg = rnd.NextDouble() * (Math.PI - 1e-17);
                double X = OpaqueFunctions.CCos_1.Cos_1(arg, 20);
                Assert.IsTrue(Math.Abs(X - Math.Cos(arg)) < threshold, "Значение функции недостаточно близко к реальному");
            }
        }
    }

}