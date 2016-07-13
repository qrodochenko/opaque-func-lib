using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpaqueFunctions;
namespace ModuleTests
{
    [TestClass]
    public class Test_interval_ww_ww_1
    {
        [TestMethod]
        public void Test_interval_ww_ww_1_g_ginvx()
        {
            Random R = new Random();
            int i = 1, p = 1; int k;
            double x, A, B, g_inv, g;

            for (; i <= 10; i++)
            {
                x = p * R.NextDouble();
                p *= -1;
                A = R.NextDouble();
                B = R.NextDouble();
                k = R.Next(-10, 10);

                g_inv = Cinterval_ww_ww_1_inv.interval_ww_ww_1_inv(x, A, B, k);
                g = Cinterval_ww_ww_1.interval_ww_ww_1(g_inv, A, B, k);

                Assert.IsTrue((Math.Abs(g - x) < 0.000001), "false");

            }

        }

        [TestMethod]
        public void Test_interval_ww_ww_1_ginv_gx()
        {
            Random R = new Random();
            int i = 1, p = 1; int k;
            double x, A, B, g_inv, g;

            for (i = 1; i <= 10; i++)
            {
                x = p*R.NextDouble();
                p *= -1;
                A = R.NextDouble();
                B = R.NextDouble();
                k = R.Next(-10, 10);

                g = Cinterval_ww_ww_1.interval_ww_ww_1(x, A, B, k);
                g_inv = Cinterval_ww_ww_1_inv.interval_ww_ww_1_inv(g, A, B, k);

                Assert.IsTrue((Math.Abs(g_inv - x) < 0.000001), "false");
            }
        }

        [TestMethod]
        public void Test_interval_ww_ww_1_in()
        {
            string s = "(w, w)";
            string f = Cinterval_ww_ww_1_in.interval_ww_ww_1_in();
            Assert.IsTrue((f == s), "false");
        }
    }

//-----------------------------------------------------

    [TestClass]
    public class Test_interval_ww_finfin_2
    {
        [TestMethod]
        public void Test_interval_ww_finfin_2_g_ginvx()
        {
            Random R = new Random();
            int i = 1, p = 1;
            double x, C, g_inv, g;

            for (i = 1; i <= 10; i++)
            {
                x = p*R.NextDouble();
                C = R.NextDouble();
                p *= -1;

                g_inv = Cinterval_ww_finfin_2_inv.interval_ww_finfin_2_inv(x,C);
                g = Cinterval_ww_finfin_2.interval_ww_finfin_2(g_inv, C);

                Assert.IsTrue((Math.Abs(g - x) < 0.000001), "false");
            }
        }

        [TestMethod]
        public void Test_interval_ww_finfin_2_ginv_gx()
        {
            Random R = new Random();
            int i = 1, p = 1;
            double x, C, g_inv, g;
            double max = 0;
            double average = 0;
            double sum = 0;
            double eps = 0;

            for (; i <= 10; i++)
            {
                x = p*R.NextDouble();
                p *= -1;
                C = R.NextDouble();


                g = Cinterval_ww_finfin_2.interval_ww_finfin_2(x, C);
                g_inv = Cinterval_ww_finfin_2_inv.interval_ww_finfin_2_inv(g, C);

                Assert.IsTrue((Math.Abs(g_inv - x) < 0.000001), "false");

                eps = Math.Abs(g_inv - x);
                if (eps > max) max = eps;
                sum += eps;
            }

            average = sum / 10.0;
            Assert.IsTrue((Math.Abs(max - average) < 0.000001), "Results are not equal");
        }

        [TestMethod]
        public void Test_interval_ww_finfin_2_in()
        {
            string s = "(w, w)";
            string f = Cinterval_ww_finfin_2_in.interval_ww_finfin_2_in();
            Assert.IsTrue((f == s), "false");
        }
    }

//----------------------------------------------

    [TestClass]
    public class Test_interval_finfin_ww_3
    {
        [TestMethod]
        public void Test_interval_finfin_ww_3_g_ginvx()
        {
            Random R = new Random();
            int i = 1, p = 1;
            double x, g_inv, g;
            double max = 0;
            double average = 0;
            double sum = 0;
            double eps = 0;
            for (; i <= 10; i++)
            {
                x = p * R.NextDouble();
                p *= -1;

                g_inv = Cinterval_finfin_ww_3_inv.interval_finfin_ww_3_inv(x);
                g = Cinterval_finfin_ww_3.interval_finfin_ww_3(g_inv);

                Assert.IsTrue((Math.Abs(g - x) < 0.000001), "false");

                eps = Math.Abs(g - x);
                if (eps > max) max = eps;
                sum += eps;
            }

            average = sum / 10.0;
            Assert.IsTrue((Math.Abs(max - average) < 0.000001), "Results are not equal");
        }
        
        [TestMethod]
        public void Test_interval_finfin_ww_3_ginv_gx()
        {
            Random R = new Random();
            int i = 1, p = 1;
            double x, g_inv, g;
            for (; i <= 10; i++)
            {
                x = p * R.NextDouble() * Math.PI / 2;
                p *= -1;

                g = Cinterval_finfin_ww_3.interval_finfin_ww_3(x);
                g_inv = Cinterval_finfin_ww_3_inv.interval_finfin_ww_3_inv(g);
  

                Assert.IsTrue((Math.Abs(g_inv - x) < 0.000001), "false");
            }
        }

        [TestMethod]
        public void Test_interval_finfin_ww_3_in()
        {
            string s = "(-Pi/2, Pi/2)";
            string f = Cinterval_finfin_ww_3_in.interval_finfin_ww_3_in();
            Assert.IsTrue((f == s), "false");
        }

    }

//-----------------------------------------------

    [TestClass]
    public class Test_interval_finw_finw_4
    {
        [TestMethod]
        public void Test_interval_finw_finw_4_g_ginvx()
        {
            Random R = new Random();
            int i = 1;
            double x, g_inv, g;
            for (; i <= 10; i++)
            {
                x = R.NextDouble();

                g_inv = Cinterval_finw_finw_4_inv.interval_finw_finw_4_inv(x);
                g = Cinterval_finw_finw_4.interval_finw_finw_4(g_inv);

                Assert.IsTrue((Math.Abs(g - x) < 0.000001) , "false");
            }
        }

        [TestMethod]
        public void Test_interval_finw_finw_4_ginv_gx()
        {
            Random R = new Random();
            int i = 1, p = 1;
            double x, g_inv, g;
            for (; i <= 10; i++)
            {
                x = R.NextDouble();

                g = Cinterval_finw_finw_4.interval_finw_finw_4(x);
                g_inv = Cinterval_finw_finw_4_inv.interval_finw_finw_4_inv(g);
                Assert.IsTrue((Math.Abs(g_inv - x) < 0.000001), "false");
            }
        }

        [TestMethod]
        public void Test_interval_finw_finw_4_in()
        {
            string s = "(0, w)";
            string f = Cinterval_finw_finw_4_in.interval_finw_finw_4_in();
            Assert.IsTrue((f == s), "false");
        }
    }

//--------------------------------------------------
    [TestClass]
    public class Test_interval_finw_wfin_5
    {
        [TestMethod]
        public void Test_interval_finw_wfin_5_g_ginvx()
        {

            Random R = new Random();
            int i = 1;
            double x, g_inv, g;
            for (; i <= 10; i++)
            {
                x = -R.NextDouble();

                g_inv = Cinterval_finw_wfin_5_inv.interval_finw_wfin_5_inv(x);
                g = Cinterval_finw_wfin_5.interval_finw_wfin_5(g_inv);

                Assert.IsTrue((Math.Abs(g - x) < 0.000001), "false");
            }
        }

        [TestMethod]
        public void Test_interval_finw_wfin_5_ginv_gx()
        {

            Random R = new Random();
            int i = 1;
            double x, g_inv, g;
            for (; i <= 10; i++)
            {
                x = R.NextDouble();

                g = Cinterval_finw_wfin_5.interval_finw_wfin_5(x);
                g_inv = Cinterval_finw_wfin_5_inv.interval_finw_wfin_5_inv(g);
                Assert.IsTrue((Math.Abs(g_inv - x) < 0.000001), "false");
            }
        }

        [TestMethod]
        public void Test_interval_finw_wfin_5_in()
        {
            string s = "(0, w)";
            string f = Cinterval_finw_wfin_5_in.interval_finw_wfin_5_in();
            Assert.IsTrue((f == s), "false");
        }
    }

//-------------------------------------------------------
    [TestClass]
    public class Test_interval_ww_finw_6
    {
        [TestMethod]
        public void Test_interval_ww_finw_6_g_ginvx()
        {
            Random R = new Random();
            int i = 1;
            double x, A, B, g_inv, g;
            for (; i <= 10; i++)
            {
                x = R.NextDouble();
                A = R.NextDouble();
                B = R.NextDouble();

                g_inv = Cinterval_ww_finw_6_inv.interval_ww_finw_6_inv(x, A, B);
                g = Cinterval_ww_finw_6.interval_ww_finw_6(g_inv, A, B);

                Assert.IsTrue((Math.Abs(g - x) < 0.000001), "false");
            }
        }

        [TestMethod]
        public void Test_interval_ww_finw_6_ginv_gx()
        {
            Random R = new Random();
            int i = 1;
            double x, A, B, g_inv, g; int p = 1;
            for (; i <= 10; i++)
            {
                x = p*R.NextDouble();
                A = R.NextDouble();
                B = R.NextDouble();
                p *= -1;

                g = Cinterval_ww_finw_6.interval_ww_finw_6(x, A, B);
                g_inv = Cinterval_ww_finw_6_inv.interval_ww_finw_6_inv(g, A, B);

                Assert.IsTrue((Math.Abs(g_inv - x) < 0.000001), "false");
            }
        }

        [TestMethod]
        public void Test_interval_ww_finw_6_in()
        {
            string s = "(w, w)";
            string f = Cinterval_ww_finw_6_in.interval_ww_finw_6_in();
            Assert.IsTrue((f == s), "false");
        }
    }
//----------------------------------------------------------------------------
//----------------------------------------------------------------------------
//----------------------------------------------------------------------------

    [TestClass]
    public class Test_interval_finfin_finfin_7
    {
        [TestMethod]
        public void Test_interval_finfin_finfin_7_g_ginvx()
        {

            Random R = new Random();
            int i = 1;
            double x, a, b, c, d, g_inv, g;
            double max = 0;
            double average = 0;
            double sum = 0;
            double eps = 0;
            for (; i <= 10; i++)
            {

                a = R.Next(1, 10) + R.NextDouble();
                b = a + R.Next(2, 10) + R.NextDouble();

                c = R.Next(1, 10) + R.NextDouble();
                d = c + R.Next(2, 10) + R.NextDouble(); ;
                x = c + R.NextDouble();


                g_inv = Cinterval_finfin_finfin_7_inv.interval_finfin_finfin_7_inv(x, a, b, c, d);
                g = Cinterval_finfin_finfin_7.interval_finfin_finfin_7(g_inv, a, b, c, d);

                Assert.IsTrue((Math.Abs(g - x) < 0.000001), "false");

                eps = Math.Abs(g - x);
                if (eps > max) max = eps;
                sum += eps;
            }

            average = sum / 10.0;
            Assert.IsTrue((Math.Abs(max - average) < 0.000001), "Results are not equal");
        }


        [TestMethod]
        public void Test_interval_finfin_finfin_7_ginv_gx()
        {

            Random R = new Random();
            int i = 1;
            double x, a, b, c, d, g_inv, g;
            double max = 0;
            double average = 0;
            double sum = 0;
            double eps = 0;
            for (; i <= 10; i++)
            {
                a = R.Next(1, 10) + R.NextDouble(); ;
                b = a + R.Next(2, 10) + R.NextDouble();
                x = a + R.NextDouble();

                c = R.Next(1, 10) + R.NextDouble();
                d = c + R.Next(2, 10) + R.NextDouble();

                g = Cinterval_finfin_finfin_7.interval_finfin_finfin_7(x, a, b, c, d);
                g_inv = Cinterval_finfin_finfin_7_inv.interval_finfin_finfin_7_inv(g, a, b, c, d);

                Assert.IsTrue((Math.Abs(g_inv - x) < 0.000001), "false");

                eps = Math.Abs(g_inv - x);
                if (eps > max) max = eps;
                sum += eps;
            }

            average = sum / 10.0;
            Assert.IsTrue((Math.Abs(max - average) < 0.000001), "Results are not equal");
        }

        [TestMethod]
        public void Test_interval_finfin_finfin_7_in()
        {
            Random R = new Random();
            double a = R.NextDouble();
            double b = a + R.NextDouble();

            string a1 = Convert.ToString(a);
            string b1 = Convert.ToString(b);
            string s = "(" + a1 + ", " + b1 + ")";

            string f = Cinterval_finfin_finfin_7_in.interval_finfin_finfin_7_in(a, b);
            Assert.IsTrue((f == s), "false");
        }
    }

//-------------------------------------------------------------
    [TestClass]
    public class Test_interval_finfin_finfin_8
    {
        [TestMethod]
        public void Test_interval_finfin_finfin_8_g_ginvx()
        {

            Random R = new Random();
            int i = 1;
            double x, a, b, c, d, g_inv, g;
            double max = 0;
            double average = 0;
            double sum = 0;
            double eps = 0;
            for (; i <= 10; i++)
            {

                a = R.Next(1, 10) + R.NextDouble();
                b = a + R.Next(2, 10) + R.NextDouble();

                c = R.Next(1, 10) + R.NextDouble();
                d = c + R.Next(2, 10) + R.NextDouble();
                x = c + R.NextDouble();


                g_inv = Cinterval_finfin_finfin_8_inv.interval_finfin_finfin_8_inv(x, a, b, c, d);
                g = Cinterval_finfin_finfin_8.interval_finfin_finfin_8(g_inv, a, b, c, d);

                Assert.IsTrue((Math.Abs(g - x) < 0.000001), "false");

                eps = Math.Abs(g - x);
                if (eps > max) max = eps;
                sum += eps;
            }

            average = sum / 10.0;
            Assert.IsTrue((Math.Abs(max - average) < 0.000001), "Results are not equal");
        }


        [TestMethod]
        public void Test_interval_finfin_finfin_8_ginv_gx()
        {

            Random R = new Random();
            int i = 1;
            double x, a, b, c, d, g_inv, g;
            double max = 0;
            double average = 0;
            double sum = 0;
            double eps = 0;
            for (; i <= 10; i++)
            {
                a = R.Next(1, 10) + R.NextDouble();
                b = a + R.Next(2, 10) + R.NextDouble();
                x = a + R.NextDouble();

                c = R.Next(1, 10) + R.NextDouble();
                d = c + R.Next(2, 10) + R.NextDouble();

                g = Cinterval_finfin_finfin_8.interval_finfin_finfin_8(x, a, b, c, d);
                g_inv = Cinterval_finfin_finfin_8_inv.interval_finfin_finfin_8_inv(g, a, b, c, d);

                Assert.IsTrue((Math.Abs(g_inv - x) < 0.000001), "false");

                eps = Math.Abs(g_inv - x);
                if (eps > max) max = eps;
                sum += eps;
            }

            average = sum / 10.0;
            Assert.IsTrue((Math.Abs(max - average) < 0.000001), "Results are not equal");
        }

        [TestMethod]
        public void Test_interval_finfin_finfin_8_in()
        {
            Random R = new Random();
            double a = R.NextDouble();
            double b = a + R.NextDouble();

            string a1 = Convert.ToString(a);
            string b1 = Convert.ToString(b);
            string s = "(" + a1 + ", " + b1 + ")";

            string f = Cinterval_finfin_finfin_8_in.interval_finfin_finfin_8_in(a, b);
            Assert.IsTrue((f == s), "false");
        }
    }
//----------------------------------------------------------------------------
//----------------------------------------------------------------------------
//----------------------------------------------------------------------------

    [TestClass]
    public class Test_interval_finfin_finfin_9
    {
        [TestMethod]
        public void Test_interval_finfin_finfin_9_g_ginvx()
        {
            Random R = new Random();
            int i = 1;
            double x, g_inv, g;
            int p = 1;
            double max = 0;
            double average = 0;
            double sum = 0;
            double eps = 0;
            for (; i <= 10; i++)
            {
                x = p * R.NextDouble();
                p *= -1;

                g_inv = Cinterval_finfin_finfin_9_inv.interval_finfin_finfin_9_inv(x);
                g = Cinterval_finfin_finfin_9.interval_finfin_finfin_9(g_inv);

                Assert.IsTrue((Math.Abs(g - x) < 0.000001)  , "false");

                eps = Math.Abs(g - x);
                if (eps > max) max = eps;
                sum += eps;
            }

            average = sum / 10.0;
            Assert.IsTrue((Math.Abs(max - average) < 0.000001), "Results are not equal");
        }

        [TestMethod]
        public void Test_interval_finfin_finfin_9_ginv_gx()
        {
            Random R = new Random();
            int i = 1;
            double x, g_inv, g;
            int p = 1;
            double max = 0;
            double average = 0;
            double sum = 0;
            double eps = 0;
            for (; i <= 10; i++)
            {
                x = p * R.NextDouble() * Math.PI / 2;
                p *= -1;

                g = Cinterval_finfin_finfin_9.interval_finfin_finfin_9(x);
                g_inv = Cinterval_finfin_finfin_9_inv.interval_finfin_finfin_9_inv(g);
                Assert.IsTrue((Math.Abs(g_inv - x) < 0.000001), "false");

                eps = Math.Abs(g_inv - x);
                if (eps > max) max = eps;
                sum += eps;
            }

            average = sum / 10.0;
            Assert.IsTrue((Math.Abs(max - average) < 0.000001), "Results are not equal");
        } 

        [TestMethod]
        public void Test_interval_finfin_finfin_9_in()
        {
            string s = "(-Pi/2, Pi/2)";
            string f = Cinterval_finfin_finfin_9_in.interval_finfin_finfin_9_in();
            Assert.IsTrue((f == s), "false");
        }
    }

    //--------------------------------------------
    [TestClass]
    public class Test_interval_finfin_finfin_10
    {
        [TestMethod]
        public void Test_interval_finfin_finfin_10_g_ginvx()
        {
            Random R = new Random();
            int i = 1;
            double x, g_inv, g;
            int p = 1;
            double max = 0;
            double average = 0;
            double sum = 0;
            double eps = 0;
            for (; i <= 10; i++)
            {
                x = p * R.NextDouble();
                p *= -1;

                g_inv = Cinterval_finfin_finfin_10_inv.interval_finfin_finfin_10_inv(x);
                g = Cinterval_finfin_finfin_10.interval_finfin_finfin_10(g_inv);

                Assert.IsTrue((Math.Abs(g - x) < 0.000001), "false");

                eps = Math.Abs(g - x);
                if (eps > max) max = eps;
                sum += eps;
            }

            average = sum / 10.0;
            Assert.IsTrue((Math.Abs(max - average) < 0.000001), "Results are not equal");
        }

        [TestMethod]
        public void Test_interval_finfin_finfin_10_ginv_gx()
        {
            Random R = new Random();
            int i = 1;
            double x, g_inv, g;
            double max = 0;
            double average = 0;
            double sum = 0;
            double eps = 0;
            for (; i <= 10; i++)
            {
                x = R.NextDouble()*Math.PI ;

                g = Cinterval_finfin_finfin_10.interval_finfin_finfin_10(x);
                g_inv = Cinterval_finfin_finfin_10_inv.interval_finfin_finfin_10_inv(g);
                Assert.IsTrue((Math.Abs(g_inv - x) < 0.000001), "false");

                eps = Math.Abs(g_inv - x);
                if (eps > max) max = eps;
                sum += eps;
            }

            average = sum / 10.0;
            Assert.IsTrue((Math.Abs(max - average) < 0.000001), "Results are not equal");
        }

        [TestMethod]
        public void Test_interval_finfin_finfin_10_in()
        {
            string s = "(0, Pi)";
            string f = Cinterval_finfin_finfin_10_in.interval_finfin_finfin_10_in();
            Assert.IsTrue((f == s), "false");
        }
    }
}
