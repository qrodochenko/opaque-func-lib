using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpaqueFunctions;

namespace ModuleTests
{
    [TestClass]
    public class Test_CSin_1
    {
        [TestMethod]
        public void Test_Sin_1()
        {
            Random R = new Random();
            int i = 1, p = 1;
            int count;
            double x, f, g;

            for (; i <= 10; i++)
            {
                x = p * R.NextDouble();
                p *= -1;
                count = R.Next(4, 100);

                f = Math.Sin(x);
                g = CSin_1.Sin_1(x, count);

                Assert.IsTrue((Math.Abs(g - f) < 0.01), "false");
            }
        }

        [TestMethod]
        public void Test_Sin_1_in()
        {
            string s = "(w, w)";
            string f = CSin_1_in.Sin_1_in();
            Assert.IsTrue((f == s), "false");
        }

        [TestMethod]
        public void Test_Sin_1_inv()
        {
            string s = "арксинус";
            string f = CSin_1_inv.Sin_1_inv();
            Assert.IsTrue((f == s), "false");
        }
    }
    //------------------------------------------------------------------------
    [TestClass]
    public class Test_CSin_2
    {
        [TestMethod]
        public void Test_Sin_2()
        {
            Random R = new Random();
            int i = 1, p = 1;
            double x, er = 0.0001, f, g;

            for (; i <= 10; i++)
            {
                x = p * R.NextDouble();
                p *= -1;
                f = Math.Sin(x);
                g = CSin_2.Sin_2(x, er);

                Assert.IsTrue((Math.Abs(g - f) < 0.01), "false");
            }
        }
        [TestMethod]
        public void Test_Sin_2_in()
        {
            string s = "(w, w)";
            string f = CSin_2_in.Sin_2_in();
            Assert.IsTrue((f == s), "false");
        }

        [TestMethod]
        public void Test_Sin_2_inv()
        {
            string s = "арксинус";
            string f = CSin_2_inv.Sin_2_inv();
            Assert.IsTrue((f == s), "false");
        }
    }
    //------------------------------------------------------------------------
    [TestClass]
    public class Test_CCos_3
    {
        [TestMethod]
        public void Test_Cos_3()
        {
            Random R = new Random();
            int i = 1, p = 1;
            int count;
            double x, f, g;

            for (; i <= 10; i++)
            {
                x = p * R.NextDouble();
                p *= -1;
                count = R.Next(4, 100);

                f = Math.Cos(x);
                g = CCos_3.Cos_3(x, count);

                Assert.IsTrue((Math.Abs(g - f) < 0.01), "false");
            }
        }
        [TestMethod]
        public void Test_Cos_3_in()
        {
            string s = "(w, w)";
            string f = CCos_3_in.Cos_3_in();
            Assert.IsTrue((f == s), "false");
        }

        [TestMethod]
        public void Test_Cos_3_inv()
        {
            string s = "арккосинус";
            string f = CCos_3_inv.Cos_3_inv();
            Assert.IsTrue((f == s), "false");
        }
    }
    //------------------------------------------------------------------------
    [TestClass]
    public class Test_CCos_4
    {
        [TestMethod]
        public void Test_Cos_4()
        {
            Random R = new Random();
            int i = 1, p = 1;
            double x, er = 0.0001, f, g;

            for (; i <= 10; i++)
            {
                x = p * R.NextDouble();
                p *= -1;
                f = Math.Cos(x);
                g = CCos_4.Cos_4(x, er);

                Assert.IsTrue((Math.Abs(g - f) < 0.01), "false");
            }
        }
        [TestMethod]
        public void Test_Cos_4_in()
        {
            string s = "(w, w)";
            string f = CCos_4_in.Cos_4_in();
            Assert.IsTrue((f == s), "false");
        }

        [TestMethod]
        public void Test_Cos_4_inv()
        {
            string s = "арккосинус";
            string f = CCos_4_inv.Cos_4_inv();
            Assert.IsTrue((f == s), "false");
        }
    }
    //------------------------------------------------------------------------
    [TestClass]
    public class Test_CSin_5
    {
        [TestMethod]
        public void Test_Sin_5()
        {
            Random R = new Random();
            int i = 1, p = 1;
            int count;
            double x, f, g;

            for (; i <= 10; i++)
            {
                x = p * R.NextDouble();
                p *= -1;
                count = R.Next(4, 100);

                f = Math.Sin(x);
                g = CSin_5.Sin_5(x, count, Math.Sin(x));

                Assert.IsTrue((Math.Abs(g - f) < 0.01), "false");
            }
        }
        [TestMethod]
        public void Test_Sin_5_in()
        {
            string s = "(w, w)";
            string f = CSin_5_in.Sin_5_in();
            Assert.IsTrue((f == s), "false");
        }

        [TestMethod]
        public void Test_Sin_5_inv()
        {
            string s = "арксинус";
            string f = CSin_5_inv.Sin_5_inv();
            Assert.IsTrue((f == s), "false");
        }
    }
    //------------------------------------------------------------------------
    [TestClass]
    public class Test_CSin_6
    {
        [TestMethod]
        public void Test_Sin_6()
        {
            Random R = new Random();
            int i = 1, p = 1;
            double x, er = 0.0001, f, g;

            for (; i <= 10; i++)
            {
                x = p * R.NextDouble();
                p *= -1;
                f = Math.Sin(x);
                g = CSin_6.Sin_6(x, er, Math.Sin(x));

                Assert.IsTrue((Math.Abs(g - f) < 0.01), "false");
            }
        }
        [TestMethod]
        public void Test_Sin_6_in()
        {
            string s = "(w, w)";
            string f = CSin_6_in.Sin_6_in();
            Assert.IsTrue((f == s), "false");
        }

        [TestMethod]
        public void Test_Sin_6_inv()
        {
            string s = "арксинус";
            string f = CSin_6_inv.Sin_6_inv();
            Assert.IsTrue((f == s), "false");
        }
    }
    //------------------------------------------------------------------------
    [TestClass]
    public class Test_CCos_7
    {
        [TestMethod]
        public void Test_Cos_7()
        {
            Random R = new Random();
            int i = 1, p = 1;
            int count;
            double x, f, g;

            for (; i <= 10; i++)
            {
                x = p * R.NextDouble();
                p *= -1;
                count = R.Next(4, 100);

                f = Math.Cos(x);
                g = CCos_7.Cos_7(x, count, Math.Cos(x));

                Assert.IsTrue((Math.Abs(g - f) < 0.01), "false");
            }
        }
        [TestMethod]
        public void Test_Cos_7_in()
        {
            string s = "(w, w)";
            string f = CCos_7_in.Cos_7_in();
            Assert.IsTrue((f == s), "false");
        }

        [TestMethod]
        public void Test_Cos_7_inv()
        {
            string s = "арккосинус";
            string f = CCos_7_inv.Cos_7_inv();
            Assert.IsTrue((f == s), "false");
        }
    }
    //------------------------------------------------------------------------
    [TestClass]
    public class Test_CCos_8
    {
        [TestMethod]
        public void Test_Cos_8()
        {
            Random R = new Random();
            int i = 1, p = 1;
            double x, er = 0.0001, f, g;

            for (; i <= 10; i++)
            {
                x = p * R.NextDouble();
                p *= -1;
                f = Math.Cos(x);
                g = CCos_8.Cos_8(x, er, Math.Cos(x));
                Assert.IsTrue((Math.Abs(g - f) < 0.01), "false");
            }
        }
        [TestMethod]
        public void Test_Cos_8_in()
        {
            string s = "(w, w)";
            string f = CCos_8_in.Cos_8_in();
            Assert.IsTrue((f == s), "false");
        }

        [TestMethod]
        public void Test_Cos_8_inv()
        {
            string s = "арккосинус";
            string f = CCos_8_inv.Cos_8_inv();
            Assert.IsTrue((f == s), "false");
        }
    }

    //------------------------------------------------------------------------
    [TestClass]
    public class Test_CTg_9
    {
        [TestMethod]
        public void Test_Tg_9()
        {
            double x, max, sum, f, g, a, average;
            int i = 1, count;
            Random R = new Random();
            x = R.NextDouble();
            count = R.Next(4, 25);
            f = Math.Tan(x);
            g = CTg_9.Tg_9(x, count);
            max = Math.Abs(f - g);
            sum = Math.Abs(f - g);

            for (i = 2; i <= 10; i++)
            {
                x = R.NextDouble();
                count = R.Next(4, 25);
                f = Math.Tan(x);
                g = CTg_9.Tg_9(x, count);
                a = Math.Abs(f - g);
                if (a > max) max = a;
                sum += a;
            }

            average = sum / 10.0;
            Assert.IsTrue((Math.Abs(max - average) < 0.01), "false");
        }
        [TestMethod]
        public void Test_Tg_9_in()
        {
            string s = "(-Pi/2, Pi/2)";
            string f = CTg_9_in.Tg_9_in();
            Assert.IsTrue((f == s), "false");
        }

        [TestMethod]
        public void Test_Tg_9_inv()
        {
            string s = "арктангенс";
            string f = CTg_9_inv.Tg_9_inv();
            Assert.IsTrue((f == s), "false");
        }
    }
    //------------------------------------------------------------------------
    [TestClass]
    public class Test_CTg_10
    {
        [TestMethod]
        public void Test_Tg_10()
        {
            double x, max, sum, f, g, a, average, er = 0.000001;
            int i = 1;
            Random R = new Random();
            x = R.NextDouble();
            f = Math.Tan(x);
            g = CTg_10.Tg_10(x, er);
            max = Math.Abs(f - g);
            sum = Math.Abs(f - g);

            for (i = 2; i <= 10; i++)
            {
                x = R.NextDouble();
                f = Math.Tan(x);
                g = CTg_10.Tg_10(x, er);
                a = Math.Abs(f - g);
                if (a > max) max = a;
                sum += a;
            }

            average = sum / 10.0;
            Assert.IsTrue((Math.Abs(max - average) < 0.01), "false");
        }
        [TestMethod]
        public void Test_Tg_10_in()
        {
            string s = "(-Pi/2, Pi/2)";
            string f = CTg_10_in.Tg_10_in();
            Assert.IsTrue((f == s), "false");
        }

        [TestMethod]
        public void Test_Tg_10_inv()
        {
            string s = "арктангенс";
            string f = CTg_10_inv.Tg_10_inv();
            Assert.IsTrue((f == s), "false");
        }
    }

    //------------------------------------------------------------------------
    [TestClass]
    public class Test_CCtg_11
    {
        [TestMethod]
        public void Test_Ctg_11()
        {
            double x, max, sum, f, g, a, average;
            int i = 1, count;
            Random R = new Random();
            x = R.NextDouble();
            count = R.Next(4, 25);
            f = 1.0 / Math.Tan(x);
            g = CCtg_11.Ctg_11(x, count);
            max = Math.Abs(f - g);
            sum = Math.Abs(f - g);

            for (i = 2; i <= 10; i++)
            {
                x = R.NextDouble();
                count = R.Next(4, 25);
                f = 1.0 / Math.Tan(x);
                g = CCtg_11.Ctg_11(x, count);
                a = Math.Abs(f - g);
                if (a > max) max = a;
                sum += a;
            }

            average = sum / 10.0;
            Assert.IsTrue((Math.Abs(max - average) < 0.01), "false");
        }
        [TestMethod]
        public void Test_Ctg_11_in()
        {
            string s = "(0, Pi)";
            string f = CCtg_11_in.Ctg_11_in();
            Assert.IsTrue((f == s), "false");
        }

        [TestMethod]
        public void Test_Ctg_11_inv()
        {
            string s = "арккотангенс";
            string f = CCtg_11_inv.Ctg_11_inv();
            Assert.IsTrue((f == s), "false");
        }
    }
    //------------------------------------------------------------------------
    [TestClass]
    public class Test_CCtg_12
    {
        [TestMethod]
        public void Test_Ctg_12()
        {
            double x, max, sum, f, g, a, average, er = 0.000001;
            int i = 1;
            Random R = new Random();
            x = R.NextDouble();
            f = 1.0 / Math.Tan(x);
            g = CCtg_12.Ctg_12(x, er);
            max = Math.Abs(f - g);
            sum = Math.Abs(f - g);

            for (i = 2; i <= 10; i++)
            {
                x = R.NextDouble();
                f = 1.0 / Math.Tan(x);
                g = CCtg_12.Ctg_12(x, er);
                a = Math.Abs(f - g);
                if (a > max) max = a;
                sum += a;
            }

            average = sum / 10.0;
            Assert.IsTrue((Math.Abs(max - average) < 0.01), "false");
        }
        [TestMethod]
        public void Test_Ctg_12_in()
        {
            string s = "(0, Pi)";
            string f = CCtg_12_in.Ctg_12_in();
            Assert.IsTrue((f == s), "false");
        }

        [TestMethod]
        public void Test_Ctg_12_inv()
        {
            string s = "арккотангенс";
            string f = CCtg_12_inv.Ctg_12_inv();
            Assert.IsTrue((f == s), "false");
        }
    }
    //------------------------------------------------------------------------
    [TestClass]
    public class Test_CCosec_13
    {
        [TestMethod]
        public void Test_Cosec_13()
        {
            double x, max, sum, f, g, a, average;
            int i = 1, count;
            Random R = new Random();
            x = R.NextDouble();
            count = R.Next(4, 25);
            f = 1.0 / Math.Sin(x);
            g = CCosec_13.Cosec_13(x, count);
            max = Math.Abs(f - g);
            sum = Math.Abs(f - g);

            for (i = 2; i <= 10; i++)
            {
                x = R.NextDouble();
                count = R.Next(4, 25);
                f = 1.0 / Math.Sin(x);
                g = CCosec_13.Cosec_13(x, count);
                a = Math.Abs(f - g);
                if (a > max) max = a;
                sum += a;
            }

            average = sum / 10.0;
            Assert.IsTrue((Math.Abs(max - average) < 0.01), "false");
        }
        [TestMethod]
        public void Test_Cosec_13_in()
        {
            string s = "(0, Pi)";
            string f = CCosec_13_in.Cosec_13_in();
            Assert.IsTrue((f == s), "false");
        }

        [TestMethod]
        public void Test_Cosec_13_inv()
        {
            string s = "арккосеканс";
            string f = CCosec_13_inv.Cosec_13_inv();
            Assert.IsTrue((f == s), "false");
        }
    }
    //------------------------------------------------------------------------
    [TestClass]
    public class Test_CCosec_14
    {
        [TestMethod]
        public void Test_Cosec_14()
        {
            double x, max, sum, f, g, a, average, er = 0.000001;
            int i = 1;
            Random R = new Random();
            x = R.NextDouble();
            f = 1.0 / Math.Sin(x);
            g = CCosec_14.Cosec_14(x, er);
            max = Math.Abs(f - g);
            sum = Math.Abs(f - g);

            for (i = 2; i <= 10; i++)
            {
                x = R.NextDouble();
                f = 1.0 / Math.Sin(x);
                g = CCosec_14.Cosec_14(x, er);
                a = Math.Abs(f - g);
                if (a > max) max = a;
                sum += a;
            }

            average = sum / 10.0;
            Assert.IsTrue((Math.Abs(max - average) < 0.01), "false");
        }
        [TestMethod]
        public void Test_Cosec_14_in()
        {
            string s = "(0, Pi)";
            string f = CCosec_14_in.Cosec_14_in();
            Assert.IsTrue((f == s), "false");
        }

        [TestMethod]
        public void Test_Cosec_14_inv()
        {
            string s = "арккосеканс";
            string f = CCosec_14_inv.Cosec_14_inv();
            Assert.IsTrue((f == s), "false");
        }
    }
    //------------------------------------------------------------------------
    [TestClass]
    public class Test_CSin_15
    {
        [TestMethod]
        public void Test_Sin_15()
        {
            Random R = new Random();
            int i = 1, p = 1;
            int count;
            double x, f, g;

            for (; i <= 10; i++)
            {
                x = p * R.NextDouble();
                p *= -1;
                count = R.Next(4, 100);

                f = Math.Sin(x) * Math.Sin(x);
                g = CSin_15.Sin_15(x, count);

                Assert.IsTrue((Math.Abs(g - f) < 0.01), "false");
            }
        }
        [TestMethod]
        public void Test_Sin_15_in()
        {
            string s = "(w, w)";
            string f = CSin_15_in.Sin_15_in();
            Assert.IsTrue((f == s), "false");
        }

        [TestMethod]
        public void Test_Sin_15_inv()
        {
            string s = "арксинус";
            string f = CSin_15_inv.Sin_15_inv();
            Assert.IsTrue((f == s), "false");
        }
    }
    //------------------------------------------------------------------------
    [TestClass]
    public class Test_CSin_16
    {
        [TestMethod]
        public void Test_Sin_16()
        {
            Random R = new Random();
            int i = 1, p = 1;
            double x, er = 0.0001, f, g;

            for (; i <= 10; i++)
            {
                x = p * R.NextDouble();
                p *= -1;
                f = Math.Sin(x) * Math.Sin(x);
                g = CSin_16.Sin_16(x, er);

                Assert.IsTrue((Math.Abs(g - f) < 0.01), "false");
            }
        }
        [TestMethod]
        public void Test_Sin_16_in()
        {
            string s = "(w, w)";
            string f = CSin_16_in.Sin_16_in();
            Assert.IsTrue((f == s), "false");
        }

        [TestMethod]
        public void Test_Sin_16_inv()
        {
            string s = "арксинус";
            string f = CSin_16_inv.Sin_16_inv();
            Assert.IsTrue((f == s), "false");
        }
    }
    //------------------------------------------------------------------------

    [TestClass]
    public class Test_CCos_17
    {
        [TestMethod]
        public void Test_Cos_17()
        {
            Random R = new Random();
            int i = 1, p = 1;
            int count;
            double x, f, g;

            for (; i <= 10; i++)
            {
                x = p * R.NextDouble();
                p *= -1;
                count = R.Next(4, 100);

                f = Math.Cos(x) * Math.Cos(x);
                g = CCos_17.Cos_17(x, count);

                Assert.IsTrue((Math.Abs(g - f) < 0.01), "false");
            }
        }
        [TestMethod]
        public void Test_Cos_17_in()
        {
            string s = "(w, w)";
            string f = CCos_17_in.Cos_17_in();
            Assert.IsTrue((f == s), "false");
        }

        [TestMethod]
        public void Test_Cos_17_inv()
        {
            string s = "арккосинус";
            string f = CCos_17_inv.Cos_17_inv();
            Assert.IsTrue((f == s), "false");
        }
    }
    //------------------------------------------------------------------------
    [TestClass]
    public class Test_CCos_18
    {
        [TestMethod]
        public void Test_Cos_18()
        {
            Random R = new Random();
            int i = 1, p = 1;
            double x, er = 0.0001, f, g;

            for (; i <= 10; i++)
            {
                x = p * R.NextDouble();
                p *= -1;
                f = Math.Cos(x) * Math.Cos(x);
                g = CCos_18.Cos_18(x, er);

                Assert.IsTrue((Math.Abs(g - f) < 0.01), "false");
            }
        }
        [TestMethod]
        public void Test_Cos_18_in()
        {
            string s = "(w, w)";
            string f = CCos_18_in.Cos_18_in();
            Assert.IsTrue((f == s), "false");
        }

        [TestMethod]
        public void Test_Cos_18_inv()
        {
            string s = "арккосинус";
            string f = CCos_18_inv.Cos_18_inv();
            Assert.IsTrue((f == s), "false");
        }
    }
    //------------------------------------------------------------------------

    [TestClass]
    public class Test_CSin_19
    {
        [TestMethod]
        public void Test_Sin_19()
        {
            Random R = new Random();
            int i = 1, p = 1;
            int count;
            double x, f, g;

            for (; i <= 10; i++)
            {
                x = p * R.NextDouble();
                p *= -1;
                count = R.Next(4, 100);

                f = Math.Sin(x) * Math.Sin(x) * Math.Sin(x);
                g = CSin_19.Sin_19(x, count);

                Assert.IsTrue((Math.Abs(g - f) < 0.01), "false");
            }
        }
        public void Test_Sin_19_in()
        {
            string s = "(w, w)";
            string f = CSin_19_in.Sin_19_in();
            Assert.IsTrue((f == s), "false");
        }

        [TestMethod]
        public void Test_Sin_19_inv()
        {
            string s = "арксинус";
            string f = CSin_19_inv.Sin_19_inv();
            Assert.IsTrue((f == s), "false");
        }
    }
    //------------------------------------------------------------------------
    [TestClass]
    public class Test_CSin_20
    {
        [TestMethod]
        public void Test_Sin_20()
        {
            Random R = new Random();
            int i = 1, p = 1;
            double x, er = 0.0001, f, g;

            for (; i <= 10; i++)
            {
                x = p * R.NextDouble();
                p *= -1;
                f = Math.Sin(x) * Math.Sin(x) * Math.Sin(x);
                g = CSin_20.Sin_20(x, er);

                Assert.IsTrue((Math.Abs(g - f) < 0.01), "false");
            }
        }
        public void Test_Sin_20_in()
        {
            string s = "(w, w)";
            string f = CSin_20_in.Sin_20_in();
            Assert.IsTrue((f == s), "false");
        }

        [TestMethod]
        public void Test_Sin_20_inv()
        {
            string s = "арксинус";
            string f = CSin_20_inv.Sin_20_inv();
            Assert.IsTrue((f == s), "false");
        }
    }
    //------------------------------------------------------------------------

    [TestClass]
    public class Test_CCos_21
    {
        [TestMethod]
        public void Test_Cos_21()
        {
            Random R = new Random();
            int i = 1, p = 1;
            int count;
            double x, f, g;

            for (; i <= 10; i++)
            {
                x = p * R.NextDouble();
                p *= -1;
                count = R.Next(4, 100);

                f = Math.Cos(x) * Math.Cos(x) * Math.Cos(x);
                g = CCos_21.Cos_21(x, count);

                Assert.IsTrue((Math.Abs(g - f) < 0.01), "false");
            }
        }
        [TestMethod]
        public void Test_Cos_21_in()
        {
            string s = "(w, w)";
            string f = CCos_21_in.Cos_21_in();
            Assert.IsTrue((f == s), "false");
        }

        [TestMethod]
        public void Test_Cos_21_inv()
        {
            string s = "арккосинус";
            string f = CCos_21_inv.Cos_21_inv();
            Assert.IsTrue((f == s), "false");
        }
    }
    //------------------------------------------------------------------------
    [TestClass]
    public class Test_CCos_24
    {
        [TestMethod]
        public void Test_Cos_22()
        {
            Random R = new Random();
            int i = 1, p = 1;
            double x, er = 0.0001, f, g;

            for (; i <= 10; i++)
            {
                x = p * R.NextDouble();
                p *= -1;
                f = Math.Cos(x) * Math.Cos(x) * Math.Cos(x);
                g = CCos_22.Cos_22(x, er);

                Assert.IsTrue((Math.Abs(g - f) < 0.01), "false");
            }
        }
        public void Test_Cos_22_in()
        {
            string s = "(w, w)";
            string f = CCos_22_in.Cos_22_in();
            Assert.IsTrue((f == s), "false");
        }

        [TestMethod]
        public void Test_Cos_22_inv()
        {
            string s = "арккосинус";
            string f = CCos_22_inv.Cos_22_inv();
            Assert.IsTrue((f == s), "false");
        }
    }
    //------------------------------------------------------------------------
}
