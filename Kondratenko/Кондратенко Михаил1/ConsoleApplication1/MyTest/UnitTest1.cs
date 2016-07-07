using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FaishenLip;

namespace MyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x;
            x=MyFunction.SinCos1(Math.PI);
            Assert.IsTrue(x==0, "x<>1");
        }
    }
}
