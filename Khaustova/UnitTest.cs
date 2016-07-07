using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunctionsLibrary;
namespace UnitTest
{
    [TestClass]
    public class Test_interval_ww_ww_1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Random R = new Random();
            for (int i=1; i<=10; i++)
            {
                double x = Convert.ToDouble(R.Next(-1000, 1000) / 100.0);
                double A = Convert.ToDouble(R.Next(-1000, 1000) / 100.0);
                double B = Convert.ToDouble(R.Next(-1000, 1000) / 100.0);
                int k = R.Next(-10, 10);

                double n_inv = Cinterval_ww_ww_1_inv.interval_ww_ww_1_inv(x, A, B, k);
                double n = Cinterval_ww_ww_1.interval_ww_ww_1(n_inv, A, B, k);

                double m = Cinterval_ww_ww_1.interval_ww_ww_1(x, A, B, k);
                double m_inv = Cinterval_ww_ww_1_inv.interval_ww_ww_1_inv(m, A, B, k);

                Assert.IsTrue((Math.Abs(n - x) < 0.00001) && (Math.Abs(m_inv - x) < 0.00001), "false");
            }
        }
    }

    [TestClass]
    public class Test_interval_ww_finfin_2
    {
        [TestMethod]
        public void TestMethod2()
        {
            Random R = new Random();
            for (int i = 1; i <= 10; i++)
            {
                double x = Convert.ToDouble(R.Next(-10000, 10000) / 100.0);
                double C = Convert.ToDouble(R.Next(-1000, 1000) / 10.0);

                double k_inv = Cinterval_ww_finfin_2_inv.interval_ww_finfin_2_inv(x,C);
                double k = Cinterval_ww_finfin_2.interval_ww_finfin_2(k_inv, C);

                double m = Cinterval_ww_finfin_2.interval_ww_finfin_2(x, C);
                double m_inv = Cinterval_ww_finfin_2_inv.interval_ww_finfin_2_inv(m, C);

                Assert.IsTrue((Math.Abs(k - x) < 0.000000001) && (Math.Abs(m_inv - x) < 0.000000001), "false");
            }
        }
    }

    [TestClass]
    public class Test_interval_finfin_ww_3
    {
        [TestMethod]
        public void TestMethod3()
        {
            Random R = new Random();
            for (int i = 1; i <= 10; i++)
            {
                double x = Convert.ToDouble(R.Next(-1570796326, 1570796327)/1000000000.0);

                double k_inv = Cinterval_finfin_ww_3_inv.interval_finfin_ww_3_inv(x);
                double k = Cinterval_finfin_ww_3.interval_finfin_ww_3(k_inv);

                double m = Cinterval_finfin_ww_3.interval_finfin_ww_3(x);
                double m_inv = Cinterval_finfin_ww_3_inv.interval_finfin_ww_3_inv(m);
                Assert.IsTrue((Math.Abs(k - x) < double.Epsilon) && (Math.Abs(m_inv - x) < double.Epsilon), "false");
            }
        }
    }

    [TestClass]
    public class Test_interval_finw_finw_4
    {
        [TestMethod]
        public void TestMethod4()
        {
            Random R = new Random();
            for (int i = 1; i <= 10; i++)
            {
                double x = Convert.ToDouble(R.Next(10000000) / 1000.0);

                double k_inv = Cinterval_finw_finw_4_inv.interval_finw_finw_4_inv(x);
                double k = Cinterval_finw_finw_4.interval_finw_finw_4(k_inv);

                double m = Cinterval_finw_finw_4.interval_finw_finw_4(x);
                double m_inv = Cinterval_finw_finw_4_inv.interval_finw_finw_4_inv(m);
                Assert.IsTrue((Math.Abs(k - x) < double.Epsilon) && (Math.Abs(m_inv - x) < double.Epsilon), "false");
            }
        }
    }

    [TestClass]
    public class Test_interval_finw_wfin_5
    {
        [TestMethod]
        public void TestMethod5()
        {
            double k_inv = Cinterval_finw_wfin_5_inv.interval_finw_wfin_5_inv(5);
            double k = Cinterval_finw_wfin_5.interval_finw_wfin_5(k_inv);

            double m = Cinterval_finw_wfin_5.interval_finw_wfin_5(5);
            double m_inv = Cinterval_finw_wfin_5_inv.interval_finw_wfin_5_inv(m);
            Assert.IsTrue((Math.Abs(k - 5) < double.Epsilon) && (Math.Abs(m_inv - 5) < double.Epsilon), "false");
        }
    }

    [TestClass]
    public class Test_interval_ww_finw_6
    {
        [TestMethod]
        public void TestMethod6()
        {
            double k_inv = Cinterval_ww_finw_6_inv.interval_ww_finw_6_inv(3, 4, 5);
            double k = Cinterval_ww_finw_6.interval_ww_finw_6(3, 4, k_inv);

            double m = Cinterval_ww_finw_6.interval_ww_finw_6(3, 4, 5);
            double m_inv = Cinterval_ww_finw_6_inv.interval_ww_finw_6_inv(3, 4, m);
            Assert.IsTrue((Math.Abs(k - 5) < 0.000000000000001) && (Math.Abs(m_inv - 5) < double.Epsilon), "false");
        }
    }

    [TestClass]
    public class Test_interval_finfin_finfin_7
    {
        [TestMethod]
        public void TestMethod7()
        {
            double k_inv = Cinterval_finfin_finfin_7_inv.interval_finfin_finfin_7_inv(1, 4, 5, 6, 2);
            double k = Cinterval_finfin_finfin_7.interval_finfin_finfin_7(1, 4, 5, 6, k_inv);

            double m = Cinterval_finfin_finfin_7.interval_finfin_finfin_7(1, 4, 5, 6, 2);
            double m_inv = Cinterval_finfin_finfin_7_inv.interval_finfin_finfin_7_inv(1, 4, 5, 6, m);
            Assert.IsTrue((Math.Abs(k - 2) < 0.000000000000001) && (Math.Abs(m_inv - 2) < double.Epsilon), "false");
        }
    }

    [TestClass]
    public class Test_interval_finfin_finfin_8
    {
        [TestMethod]
        public void TestMethod8()
        {
            double k_inv = Cinterval_finfin_finfin_8_inv.interval_finfin_finfin_8_inv(1, 4, 5, 6, 2);
            double k = Cinterval_finfin_finfin_8.interval_finfin_finfin_8(1, 4, 5, 6, k_inv);

            double m = Cinterval_finfin_finfin_8.interval_finfin_finfin_8(1, 4, 5, 6, 2);
            double m_inv = Cinterval_finfin_finfin_8_inv.interval_finfin_finfin_8_inv(1, 4, 5, 6, m);
            Assert.IsTrue((Math.Abs(k - 2) < double.Epsilon) && (Math.Abs(m_inv - 2) < double.Epsilon), "false");
        }
    }

    [TestClass]
    public class Test_interval_finfin_finfin_9
    {
        [TestMethod]
        public void TestMethod9()
        {
            double k_inv = Cinterval_finfin_finfin_9_inv.interval_finfin_finfin_9_inv(Math.PI/6);
            double k = Cinterval_finfin_finfin_9.interval_finfin_finfin_9(k_inv);

            double m = Cinterval_finfin_finfin_9.interval_finfin_finfin_9(Math.PI / 6);
            double m_inv = Cinterval_finfin_finfin_9_inv.interval_finfin_finfin_9_inv(m);
            Assert.IsTrue((Math.Abs(k - Math.PI / 6) < double.Epsilon) && (Math.Abs(m_inv - Math.PI / 6) < double.Epsilon), "false");
        }
    }

    [TestClass]
    public class Test_interval_finfin_finfin_10
    {
        [TestMethod]
        public void TestMethod10()
        {
            double k_inv = Cinterval_finfin_finfin_10_inv.interval_finfin_finfin_10_inv(Math.PI / 4);
            double k = Cinterval_finfin_finfin_10.interval_finfin_finfin_10(k_inv);

            double m = Cinterval_finfin_finfin_10.interval_finfin_finfin_10(Math.PI / 4);
            double m_inv = Cinterval_finfin_finfin_10_inv.interval_finfin_finfin_10_inv(m);
            Assert.IsTrue((Math.Abs(k - Math.PI / 4) < double.Epsilon) && (Math.Abs(m_inv - Math.PI / 4) < double.Epsilon), "false");
        }
    }
}
