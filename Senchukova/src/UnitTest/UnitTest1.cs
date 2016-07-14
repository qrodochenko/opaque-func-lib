using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunctionsLibrary;
namespace UnitTest
{
    [TestClass]
    public class Ctest_interval_ww_finfin_1
    {
        [TestMethod]
        public void test_interval_ww_finfin_1()
        {
            double k = Cinterval_ww_finfin_1.interval_ww_finfin_1(3);
            Assert.IsTrue(Math.Abs(k - 0.3) < Double.Epsilon, "false");
        }
    }
}


    [TestClass]
    public class Ctest_interval_ww_finfin_2
{
        [TestMethod]
        public void test_interval_ww_finfin_2()
        {
            double m = Cinterval_ww_finfin_2.interval_ww_finfin_2(1);
            Assert.IsTrue(Math.Abs(m - 1) < Double.Epsilon, "false");
        }
    }

[TestClass]
public class Ctest_interval_ww_finfin_3
{
    [TestMethod]
    public void test_interval_ww_finfin_3()
    {
        double l = Cinterval_ww_finfin_3.interval_ww_finfin_3(1, 1, 2);
        Assert.IsTrue(Math.Abs(l - 0.25) < Double.Epsilon, "false");
    }
}



[TestClass]
public class Ctest_interval_ww_finfin_4
{
    [TestMethod]
    public void test_interval_ww_finfin_4()
    {
        double p = Cinterval_ww_finfin_4.interval_ww_finfin_4(0);
        Assert.IsTrue(Math.Abs(p - 1) < Double.Epsilon, "false");
    }
}
