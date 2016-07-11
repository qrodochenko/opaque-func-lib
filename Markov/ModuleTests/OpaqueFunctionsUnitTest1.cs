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
            double X = Opaque1SinCos.Body(360, 10);
            Assert.IsTrue(Math.Abs(X - 1) < double.Epsilon, "Значение функции не единица!");
            
        }

        
    }
}
