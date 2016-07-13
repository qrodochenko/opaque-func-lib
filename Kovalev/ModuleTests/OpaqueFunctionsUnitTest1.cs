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

}
