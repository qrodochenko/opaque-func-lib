using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunctionsLibrary;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double k_inv = Cinterval_ww_ww_1.interval_ww_ww_1_inv(0.5, 2, 2, 1.5);
            double k = Cinterval_ww_ww_1.interval_ww_ww_1(0.5, 2, 2, k_inv);

            double m = Cinterval_ww_ww_1.interval_ww_ww_1(0.5, 2, 2, 1.5);
            double m_inv = Cinterval_ww_ww_1.interval_ww_ww_1_inv(0.5, 2, 2, m);
            Assert.IsTrue((Math.Abs(k - 1.5) < double.Epsilon) && (Math.Abs(m_inv - 1.5) < double.Epsilon), "false");
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            double k_inv = Cinterval_ww_finfin_2.interval_ww_finfin_2_inv(2, 0.5);
            double k = Cinterval_ww_finfin_2.interval_ww_finfin_2(2, k_inv);

            double m = Cinterval_ww_finfin_2.interval_ww_finfin_2(2, 0.5);
            double m_inv = Cinterval_ww_finfin_2.interval_ww_finfin_2_inv(2, m);
            Assert.IsTrue((Math.Abs(k - 0.5) < 0.2) && (Math.Abs(m_inv - 0.5) < 0.2), "false");
        }
    }

    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod3()
        {
            double k_inv = Cinterval_finfin_ww_3.interval_finfin_ww_3_inv(5);
            double k = Cinterval_finfin_ww_3.interval_finfin_ww_3(k_inv);

            double m = Cinterval_finfin_ww_3.interval_finfin_ww_3(5);
            double m_inv = Cinterval_finfin_ww_3.interval_finfin_ww_3_inv(m);
            Assert.IsTrue((Math.Abs(k - 5) < double.Epsilon) && (Math.Abs(m_inv - 5) < double.Epsilon), "false");
        }
    }
}
