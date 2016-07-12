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
    public class test_L00_2 
    {
        [TestMethod]
        public void test_L00_2_1()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg = angle.NextDouble();
            double X = L00_2_1.L00_2_1_tg_sin_cos(Math.PI / 2 - 3 * arg);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg = angle.NextDouble();

                X = L00_2_1.L00_2_1_tg_sin_cos(Math.PI / 2 - 3 * arg);
                average += X;
                if (X > max)
                    max = X;    
            }
            average=average / 10.0;
            
            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_2_1.L00_2_1_tg_sin_cos_in(), "(-Pi/2, Pi/2)");
        }
    }

    [TestClass]
    public class test_L00_3
    {
        [TestMethod]
        public void test_L00_3_1()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg = angle.NextDouble();
            double X = L00_3_1.L00_3_1_ctg_cos_sin(Math.PI - 3 * arg);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg = angle.NextDouble();

                X = L00_3_1.L00_3_1_ctg_cos_sin(Math.PI - 3 * arg);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_3_1.L00_3_1_ctg_cos_sin_in(), "(0, Pi)");
        }
    }

    [TestClass]
    public class test_L00_4
    {
        [TestMethod]
        public void test_L00_4_1()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg = angle.NextDouble();
            double X = L00_4_1.L00_4_1_sec_cos(Math.PI / 2 - 3 * arg);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg = angle.NextDouble();

                X = L00_4_1.L00_4_1_sec_cos(Math.PI / 2 - 3 * arg);
                average += X;
                if (X > max)
                    max = X;
            }
            average=average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_4_1.L00_4_1_sec_cos_in(), "(-Pi/2, Pi/2)");
        }
    }

    [TestClass]
    public class test_L00_5
    {
        [TestMethod]
        public void test_L00_5_1()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg = angle.NextDouble();
            double X = L00_5_1.L00_5_1_cosec_sin(Math.PI - 3 * arg);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg = angle.NextDouble();

                X = L00_5_1.L00_5_1_cosec_sin(Math.PI - 3 * arg);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_5_1.L00_5_1_cosec_sin_in(), "(0, Pi)");
        }
    }

    [TestClass]
    public class test_L00_6
    {
        [TestMethod]
        public void test_L00_6_2()
        {
            double precision = 1e-10;
            Random angle=new Random();
            double arg1 = angle.NextDouble();
            double arg2 = angle.NextDouble();            
            double X = L00_6_2.L00_6_2_sin_cos(arg1*10,arg2*10);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg1 = angle.NextDouble();
                arg2 = angle.NextDouble();
                X = L00_6_2.L00_6_2_sin_cos(arg1*10, arg2*10);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_6_2.L00_6_2_sin_cos_in(), "(w, w) (w, w)");
           
        }
    }

    [TestClass]
    public class test_L00_7
    {
        [TestMethod]
        public void test_L00_7_2()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg1 = angle.NextDouble();
            double arg2 = angle.NextDouble();
            double X = L00_7_2.L00_7_2_sin_cos(arg1*10,arg2*10);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg1 = angle.NextDouble();
                arg2 = angle.NextDouble();
                X = L00_7_2.L00_7_2_sin_cos(arg1 * 10, arg2 * 10);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_7_2.L00_7_2_sin_cos_in(), "(w, w) (w, w)");
        }
    }

    [TestClass]
    public class test_L00_8
    {
        [TestMethod]
        public void test_L00_8_2()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg1 = angle.NextDouble();
            double arg2 = angle.NextDouble();
            double X = L00_8_2.L00_8_2_sin_cos(arg1 * 10, arg2 * 10);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg1 = angle.NextDouble();
                arg2 = angle.NextDouble();
                X = L00_8_2.L00_8_2_sin_cos(arg1 * 10, arg2 * 10);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_8_2.L00_8_2_sin_cos_in(), "(w, w) (w, w)");
        }
    }

    [TestClass]
    public class test_L00_9
    {
        [TestMethod]
        public void test_L00_9_2()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg1 = angle.NextDouble();
            double arg2 = angle.NextDouble();
            double X = L00_9_2.L00_9_2_cos_sin(arg1 * 10, arg2 * 10);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg1 = angle.NextDouble();
                arg2 = angle.NextDouble();
                X = L00_9_2.L00_9_2_cos_sin(arg1 * 10, arg2 * 10);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_9_2.L00_9_2_cos_sin_in(), "(w, w) (w, w)");
        }
    }

    [TestClass]
    public class test_L00_10
    {
        [TestMethod]
        public void test_L00_10_2()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg1 = angle.NextDouble();
            double arg2 = angle.NextDouble();
            double X = L00_10_2.L00_10_2_tg(0.78 - 1.5 * arg1, 0.78 - 1.5 * arg2);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg1 = angle.NextDouble();
                arg2 = angle.NextDouble();
                X = L00_10_2.L00_10_2_tg(0.78 - 1.5 * arg1, 0.78 - 1.5 * arg2);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_10_2.L00_10_2_tg_in(), "(-Pi/4, Pi/4) (-Pi/4, Pi/4)");
        }
    }

    [TestClass]
    public class test_L00_11
    {
        [TestMethod]
        public void test_L00_11_2()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg1 = angle.NextDouble();
            double arg2 = angle.NextDouble();
            double X = L00_11_2.L00_11_2_tg(0.78 - 1.5 * arg1, 0.78 - 1.5 * arg2);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg1 = angle.NextDouble();
                arg2 = angle.NextDouble();
                X = L00_11_2.L00_11_2_tg(0.78 - 1.5 * arg1, 0.78 - 1.5 * arg2);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_11_2.L00_11_2_tg_in(), "(-Pi/4, Pi/4) (-Pi/4, Pi/4)");
        }
    }

    [TestClass]
    public class test_L00_12
    {
        [TestMethod]
        public void test_L00_12_2()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg1 = angle.NextDouble();
            double arg2 = angle.NextDouble();
            double X = L00_12_2.L00_12_2_ctg(Math.PI/2 - 1.57 * arg1, Math.PI - 1.57 * arg2);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg1 = angle.NextDouble();
                arg2 = angle.NextDouble();
                X = L00_12_2.L00_12_2_ctg(Math.PI - 1.57 * arg1, Math.PI - 1.57 * arg2);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_12_2.L00_12_2_ctg_in(), "(0, Pi/2) (0, Pi/2)");
        }
    }

    [TestClass]
    public class test_L00_13
    {
        [TestMethod]
        public void test_L00_13_2()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg1 = angle.NextDouble();
            double arg2 = angle.NextDouble();
            double X = L00_13_2.L00_13_2_ctg(Math.PI / 2 - 1.57 * arg1, Math.PI - 1.57 * arg2);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg1 = angle.NextDouble();
                arg2 = angle.NextDouble();

                X = L00_13_2.L00_13_2_ctg(Math.PI / 2 - 1.57 * arg1, Math.PI - 1.57 * arg2);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_13_2.L00_13_2_ctg_in(), "(0, Pi/2) (0, Pi/2)");
        }
    }

    [TestClass]
    public class test_L00_14
    {
        [TestMethod]
        public void test_L00_14_2()
        {

            double precision = 1e-10;
            Random angle = new Random();
            double arg1 = angle.NextDouble();
            double arg2 = angle.NextDouble();
            double X = L00_14_2.L00_14_2_sin_cos(arg1 * 10, arg2 * 10);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg1 = angle.NextDouble();
                arg2 = angle.NextDouble();
                X = L00_14_2.L00_14_2_sin_cos(arg1 * 10, arg2 * 10);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_14_2.L00_14_2_sin_cos_in(), "(w, w) (w, w)");
        }
    }

    [TestClass]
    public class test_L00_15
    {
        [TestMethod]
        public void test_L00_15_2()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg1 = angle.NextDouble();
            double arg2 = angle.NextDouble();
            double X = L00_15_2.L00_15_2_cos(arg1 * 10, arg2 * 10);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg1 = angle.NextDouble();
                arg2 = angle.NextDouble();
                X = L00_15_2.L00_15_2_cos(arg1 * 10, arg2 * 10);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_15_2.L00_15_2_cos_in(), "(w, w) (w, w)");
        }
    }

    [TestClass]
    public class test_L00_16
    {
        [TestMethod]
        public void test_L00_16_2()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg1 = angle.NextDouble();
            double arg2 = angle.NextDouble();
            double X = L00_16_2.L00_16_2_sin(arg1 * 10, arg2 * 10);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg1 = angle.NextDouble();
                arg2 = angle.NextDouble();
                X = L00_16_2.L00_16_2_sin(arg1 * 10, arg2 * 10);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_16_2.L00_16_2_sin_in(), "(w, w) (w, w)");
        }
    }

    [TestClass]
    public class test_L00_17
    {
        [TestMethod]
        public void test_L00_17_2()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg1 = angle.NextDouble();
            double arg2 = angle.NextDouble();
            double X = L00_17_2.L00_17_2_sin_cos(arg1 * 10, arg2 * 10);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg1 = angle.NextDouble();
                arg2 = angle.NextDouble();
                X = L00_17_2.L00_17_2_sin_cos(arg1 * 10, arg2 * 10);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_17_2.L00_17_2_sin_cos_in(), "(w, w) (w, w)");
        }
    }

    [TestClass]
    public class test_L00_18
    {
        [TestMethod]
        public void test_L00_18_2()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg1 = angle.NextDouble();
            double arg2 = angle.NextDouble();
            double X = L00_18_2.L00_18_2_sin_cos(arg1 * 10, arg2 * 10);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg1 = angle.NextDouble();
                arg2 = angle.NextDouble();
                X = L00_18_2.L00_18_2_sin_cos(arg1 * 10, arg2 * 10);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_18_2.L00_18_2_sin_cos_in(), "(w, w) (w, w)");
        }
    }

    [TestClass]
    public class test_L00_19
    {
        [TestMethod]
        public void test_L00_19_2()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg1 = angle.NextDouble();
            double arg2 = angle.NextDouble();
            double X = L00_19_2.L00_19_2_cos_sin(arg1 * 10, arg2 * 10);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg1 = angle.NextDouble();
                arg2 = angle.NextDouble();
                X = L00_19_2.L00_19_2_cos_sin(arg1 * 10, arg2 * 10);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_19_2.L00_19_2_cos_sin_in(), "(w, w) (w, w)");
        }
    }

    [TestClass]
    public class test_L00_20
    {
        [TestMethod]
        public void test_L00_20_2()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg1 = angle.NextDouble();
            double arg2 = angle.NextDouble();
            double X = L00_20_2.L00_20_2_cos(arg1 * 10, arg2 * 10);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg1 = angle.NextDouble();
                arg2 = angle.NextDouble();
                X = L00_20_2.L00_20_2_cos(arg1 * 10, arg2 * 10);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_20_2.L00_20_2_cos_in(), "(w, w) (w, w)");
        }
    }

    [TestClass]
    public class test_L00_21
    {
        [TestMethod]
        public void test_L00_21_2()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg1 = angle.NextDouble();
            double arg2 = angle.NextDouble();
            double X = L00_21_2.L00_21_2_tg_sin_cos(Math.PI / 2 - 3 * arg1, Math.PI / 2 - 3 * arg2);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg1 = angle.NextDouble();
                arg2 = angle.NextDouble();
                X = L00_21_2.L00_21_2_tg_sin_cos(Math.PI / 2 - 3 * arg1, Math.PI / 2 - 3 * arg2);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_21_2.L00_21_2_tg_sin_cos_in(), "(-Pi/2, Pi/2) (-Pi/2, Pi/2)");
        }
    }

    [TestClass]
    public class test_L00_22
    {
        [TestMethod]
        public void test_L00_22_2()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg1 = angle.NextDouble();
            double arg2 = angle.NextDouble();
            double X = L00_22_2.L00_22_2_tg_sin_cos(Math.PI / 2 - 3 * arg1, Math.PI / 2 - 3 * arg2);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg1 = angle.NextDouble();
                arg2 = angle.NextDouble();
                X = L00_22_2.L00_22_2_tg_sin_cos(Math.PI / 2 - 3 * arg1, Math.PI / 2 - 3 * arg2);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_22_2.L00_22_2_tg_sin_cos_in(), "(-Pi/2, Pi/2) (-Pi/2, Pi/2)");
        }
    }

    [TestClass]
    public class test_L00_23
    {
        [TestMethod]
        public void test_L00_23_2()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg1 = angle.NextDouble();
            double arg2 = angle.NextDouble();
            double X = L00_23_2.L00_23_2_ctg_sin(Math.PI - 3 * arg1, Math.PI - 3 * arg2);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg1 = angle.NextDouble();
                arg2 = angle.NextDouble();
                X = L00_23_2.L00_23_2_ctg_sin(Math.PI - 3 * arg1, Math.PI - 3 * arg2);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_23_2.L00_23_2_ctg_sin_in(), "(0, Pi) (0, Pi)");
        }
    }

    [TestClass]
    public class test_L00_24
    {
        [TestMethod]
        public void test_L00_24_2()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg1 = angle.NextDouble();
            double arg2 = angle.NextDouble();
            double X = L00_24_2.L00_24_2_ctg_sin(Math.PI - 3 * arg1, Math.PI - 3 * arg2);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg1 = angle.NextDouble();
                arg2 = angle.NextDouble();
                X = L00_24_2.L00_24_2_ctg_sin(Math.PI - 3 * arg1, Math.PI - 3 * arg2);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_24_2.L00_24_2_ctg_sin_in(), "(0, Pi) (0, Pi)");
        }
    }

    [TestClass]
    public class test_L00_25
    {
        [TestMethod]
        public void test_L00_25_1()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg = angle.NextDouble();
            double X = L00_25_1.L00_25_1_sin_cos(10 * arg);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg = angle.NextDouble();
                X = L00_25_1.L00_25_1_sin_cos(10 * arg);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_25_1.L00_25_1_sin_cos_in(), "(w, w)");
        }
    }

    [TestClass]
    public class test_L00_26
    {
        [TestMethod]
        public void test_L00_26_1()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg = angle.NextDouble();
            double X = L00_26_1.L00_26_1_sin(10 * arg);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg = angle.NextDouble();
                X = L00_26_1.L00_26_1_sin(10 * arg);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_26_1.L00_26_1_sin_in(), "(w, w)");
        }
    }

    [TestClass]
    public class test_L00_27
    {
        [TestMethod]
        public void test_L00_27_1()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg = angle.NextDouble();
            double X = L00_27_1.L00_27_1_sin_arcsin(2 * arg - 1);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg = angle.NextDouble();
                X = L00_27_1.L00_27_1_sin_arcsin(2 * arg - 1);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_27_1.L00_27_1_sin_arcsin_in(), "(-1, 1)");
        }
    }

    [TestClass]
    public class test_L00_28
    {
        [TestMethod]
        public void test_L00_28_1()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg = angle.NextDouble();
            double X = L00_28_1.L00_28_1_cos_arccos(2 * arg - 1);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg = angle.NextDouble();
                X = L00_28_1.L00_28_1_cos_arccos(2 * arg - 1);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_28_1.L00_28_1_cos_arccos_in(), "(-1, 1)");
        }
    }

    [TestClass]
    public class test_L00_29
    {
        [TestMethod]
        public void test_L00_29_1()
        {
            double precision = 1e-10;
            Random angle = new Random();
            double arg = angle.NextDouble();
            double X = L00_29_1.L00_29_1_sin_arccos_cos_arcsin(2 * arg - 1);
            double max = X;
            double average = X;

            for (int i = 1; i < 10; ++i)
            {
                arg = angle.NextDouble();
                X = L00_29_1.L00_29_1_sin_arccos_cos_arcsin(2 * arg - 1);
                average += X;
                if (X > max)
                    max = X;
            }
            average = average / 10.0;

            Assert.IsTrue(Math.Abs(max - 0) < precision && Math.Abs(average - 0) < precision, "Значение функции не ноль!");
            Assert.AreEqual(L00_29_1.L00_29_1_sin_arccos_cos_arcsin_in(), "(-1, 1)");
        }
    }
}