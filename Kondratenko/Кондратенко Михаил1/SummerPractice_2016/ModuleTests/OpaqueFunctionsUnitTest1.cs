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

    [TestClass]
    public class OpaqueFunctionsUnitTest2
    {
        double tracehold = 0.0000000000001;
        [TestMethod]
        public void Opaque2SinArcSinTest1()
        {
            double X = Opaque2SinArcSin.Body(0, 10);
            Assert.IsTrue(Math.Abs(X - 0) < tracehold, "Значение функции не единица!");
            ///Random random = new Random();
            ///double param = random.NextDouble();
            
        }
    }
}
