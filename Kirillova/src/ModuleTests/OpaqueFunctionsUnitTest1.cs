using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpaqueFunctions;

namespace ModuleTests
{
    [TestClass]
    public class CTest_СMath_1_2_ln
    {
        [TestMethod]
        public void Test_Math_1_2_ln()
        {
            double max = 0;
            double average = 0;
            double sum = 0;
            double eps = 0;
            double exp = 1e-14;
            for (int i = 0; i < 10; i++)
            {
                var rnd = new Random();
                var x = rnd.NextDouble() * 2 - 1;
                double F = СMath_1_2_ln.Math_1_2_ln(x, 100);
                Assert.IsTrue(Math.Abs(Math.Log((x + 1) / (1 - x)) - F) < exp, "Погрешность больше нужной");

                eps = Math.Abs(Math.Log((x + 1) / (1 - x)) - F);
                if (eps > max) max = eps;
                sum += eps;
            }

            average = sum / 10.0;
            Assert.IsTrue((Math.Abs(max - average) < 0.000001), "Результаты не эквивалентны");
        }

        [TestMethod]
        public void Test_Math_1_2_ln_in()
        {
            string s = СMath_1_2_ln.Math_1_2_ln_in();
            Assert.IsTrue(s == "(-1, 1)", "Область определения задана неверно");

        }
    }

    [TestClass]
    public class CTest_СMath_2_2_ln
    {
        [TestMethod]
        public void Test_Math_2_2_ln()
        {
            double exp = 1e-14;
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                var x = Convert.ToDouble(rnd.Next(-1, 2000) / 100.0);
                double F = СMath_2_2_ln.Math_2_2_ln(x, 100);
                Assert.IsTrue(Math.Abs(Math.Log(x + 1) - F) < exp, "Погрешность больше нужной");

            }
        }

        [TestMethod]
        public void Test_Math_2_2_ln_in()
        {
            string s = СMath_2_2_ln.Math_2_2_ln_in();
            Assert.IsTrue(s == "(-1, w)", "Область определения задана неверно");

        }
    }

    [TestClass]
    public class CTest_СMath_3_2_ln
    {
        [TestMethod]
        public void Test_Math_3_2_ln()
        {
            double max = 0;
            double average = 0;
            double sum = 0;
            double eps = 0;
            double exp = 1e-14;
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                var x = rnd.NextDouble() * 2 - 1;
                double F = СMath_3_2_ln.Math_3_2_ln(x, 100);
                Assert.IsTrue(Math.Abs(Math.Log(1 / Math.Sqrt(1 - x * x)) - F) < exp, "Погрешность больше нужной");

                eps = Math.Abs(Math.Log((x + 1) / (1 - x)) - F);
                if (eps > max) max = eps;
                sum += eps;
            }

            average = sum / 10.0;
            Assert.IsTrue((Math.Abs(max - average) < 0.000001), "Результаты не эквивалентны");

        }
        [TestMethod]
        public void Test_Math_3_2_ln_in()
        {
            string s = СMath_3_2_ln.Math_3_2_ln_in();
            Assert.IsTrue(s == "(-1, 1)", "Область определения задана неверно");

        }
    }


    [TestClass]
    public class CTest_СMath_4_2_ln
    {
        [TestMethod]
        public void Test_Math_4_2_ln()
        {
            double exp = 1e-14;
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                var x = Convert.ToDouble(rnd.Next(-1, 2000) / 100.0);
                double F = СMath_4_2_ln.Math_4_2_ln(x, 100);
                Assert.IsTrue(Math.Abs(Math.Log(1 + x) - F) < exp, "Погрешность больше нужной");

            }
        }

        [TestMethod]
        public void Test_Math_4_2_ln_in()
        {
            string s = СMath_4_2_ln.Math_4_2_ln_in();
            Assert.IsTrue(s == "(-1, w)", "Область определения задана неверно");

        }
    }

    [TestClass]
    public class CTest_СMath_6_2_ln
    {
        [TestMethod]
        public void Test_Math_6_2_ln()
        {
            double exp = 1e-14;
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                var x = Convert.ToDouble(rnd.Next(-1, 2000) / 100.0);
                double F = СMath_6_2_ln.Math_6_2_ln(x, 100);
                Assert.IsTrue(Math.Abs(Math.Log(1 + x) - F) < exp, "Погрешность больше нужной");

            }
        }

        [TestMethod]
        public void Test_Math_6_2_ln_in()
        {
            string s = СMath_6_2_ln.Math_6_2_ln_in();
            Assert.IsTrue(s == "(-1, w)", "Область определения задана неверно");

        }
    }

    [TestClass]
    public class CTest_СMath_7_3_ln
    {
        [TestMethod]
        public void Test_Math_7_3_ln()
        {
            double exp = 1e-14, a = 5;
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                var x = Convert.ToDouble(rnd.Next(-1, 2000) / 100.0);
                double F = СMath_7_3_ln.Math_7_3_ln(a, x, 100);
                Assert.IsTrue(Math.Abs(Math.Log(a + x) - F) < exp, "Погрешность больше нужной");

            }
        }

        [TestMethod]
        public void Test_Math_7_3_ln_in()
        {
            string s = СMath_7_3_ln.Math_7_3_ln_in();
            Assert.IsTrue(s == "(-a, w)", "Область определения задана неверно");

        }
    }

    [TestClass]
    public class CTest_СMath_8_2_ln
    {
        [TestMethod]
        public void Test_Math_8_2_ln()
        {
            double max = 0;
            double average = 0;
            double sum = 0;
            double eps = 0;
            double exp = 1e-4;
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                var x = rnd.NextDouble() * 2 - 1;
                double F = СMath_8_2_ln.Math_8_2_ln(x, 100);
                Assert.IsTrue(Math.Abs(Math.Log(1 + x) - F) < exp, "Погрешность больше нужной");

                eps = Math.Abs(Math.Log((x + 1) / (1 - x)) - F);
                if (eps > max) max = eps;
                sum += eps;
            }

            average = sum / 10.0;
            Assert.IsTrue((Math.Abs(max - average) < 0.000001), "Результаты не эквивалентны");

        }

        [TestMethod]
        public void Test_Math_8_2_ln_in()
        {
            string s = СMath_8_2_ln.Math_8_2_ln_in();
            Assert.IsTrue(s == "(-1, 1)", "Область определения задана неверно");

        }
    }

    [TestClass]
    public class CTest_СMath_9_2_ln
    {
        [TestMethod]
        public void Test_Math_9_2_ln()
        {
            double max = 0;
            double average = 0;
            double sum = 0;
            double eps = 0;
            double exp = 1e-14;
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                var x = rnd.NextDouble() * 2 - 1;
                double F = СMath_9_2_ln.Math_9_2_ln(x, 100);
                Assert.IsTrue(Math.Abs(Math.Log(1 + x) - F) < exp, "Погрешность больше нужной");

                eps = Math.Abs(Math.Log((x + 1) / (1 - x)) - F);
                if (eps > max) max = eps;
                sum += eps;
            }

            average = sum / 10.0;
            Assert.IsTrue((Math.Abs(max - average) < 0.000001), "Результаты не эквивалентны");

        }

        [TestMethod]
        public void Test_Math_9_2_ln_in()
        {
            string s = СMath_9_2_ln.Math_9_2_ln_in();
            Assert.IsTrue(s == "(-1, 1)", "Область определения задана неверно");

        }
    }

    [TestClass]
    public class CTest_СMath_10_2_ln
    {
        [TestMethod]
        public void Test_Math_10_2_ln()
        {
            double max = 0;
            double average = 0;
            double sum = 0;
            double eps = 0;
            double exp = 1e-14;
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                var x = rnd.NextDouble() * 2 - 1;
                double F = СMath_10_2_ln.Math_10_2_ln(x, 100);
                Assert.IsTrue(Math.Abs(Math.Log((x + 1) / (1 - x)) - F) < exp, "Погрешность больше нужной");

                eps = Math.Abs(Math.Log((x + 1) / (1 - x)) - F);
                if (eps > max) max = eps;
                sum += eps;
            }

            average = sum / 10.0;
            Assert.IsTrue((Math.Abs(max - average) < 0.000001), "Результаты не эквивалентны");

        }
        [TestMethod]
        public void Test_Math_10_2_ln_in()
        {
            string s = СMath_10_2_ln.Math_10_2_ln_in();
            Assert.IsTrue(s == "(-1, 1)", "Область определения задана неверно");

        }
    }

    [TestClass]
    public class CTest_СMath_11_2_ln
    {
        [TestMethod]
        public void Test_Math_11_2_ln()
        {
            double exp = 1e-14;
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                var x = Convert.ToDouble(rnd.Next(1, 2000) / 100.0);
                double F = СMath_11_2_ln.Math_11_2_ln(x, 100);
                Assert.IsTrue(Math.Abs(Math.Log(x / (x - 1)) - F) < exp, "Погрешность больше нужной");

            }
        }

        [TestMethod]
        public void Test_Math_11_2_ln_in()
        {
            string s = СMath_11_2_ln.Math_11_2_ln_in();
            Assert.IsTrue(s == "(1, w)", "Область определения задана неверно");

        }
    }
}
