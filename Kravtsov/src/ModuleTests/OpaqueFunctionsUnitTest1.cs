using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpaqueFunctions;

namespace ModuleTests
{
    [TestClass]
    public class CTest_Sin_1
    {
        [TestMethod]
        public void Test_Sin_1()
        {

            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                double threshold = 1e-2;
                double arg = (rnd.NextDouble() - 0.5) * (Math.PI - 1e-17);
                double X = OpaqueFunctions.CSin_1.Sin_1(arg, 20);
                Assert.IsTrue(Math.Abs(X - Math.Sin(arg)) < threshold, "Значение функции недостаточно близко к реальному");
                Assert.IsTrue(Math.Abs((X - Math.Sin(arg)) / Math.Sin(arg)) < double.Epsilon, "Относительная погрешность слишком велика");
            }
        }
    }
    [TestClass]
    public class CTest_Cos_1
    {
        [TestMethod]
        public void Test_Cos_1()
        {

            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                double threshold = 1e-3;
                double arg = rnd.NextDouble() * (Math.PI - 1e-17);
                double X = OpaqueFunctions.CCos_1.Cos_1(arg, 20);
                Assert.IsTrue(Math.Abs(X - Math.Cos(arg)) < threshold, "Значение функции недостаточно близко к реальному");
                Assert.IsTrue(Math.Abs((X - Math.Cos(arg)) / Math.Cos(arg)) < threshold, "Относительная погрешность слишком велика");
            }
        }
    }
    [TestClass]
    public class CTestArcsin_1
    {
        [TestMethod]
        public void Test_Arcsin_1()
        {
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                double threshold = 1e-1;
                double arg = ((rnd.NextDouble() - 0.5) * 2) - 1e-17;
                double X = CArcsin_1.Arcsin_1(arg, 4000000);
                Assert.IsTrue(Math.Abs(X - Math.Asin(arg)) < threshold, "Значение функции недостаточно близко к реальному");
                Assert.IsTrue(Math.Abs((X - Math.Asin(arg)) / Math.Asin(arg)) < threshold, "Относительная погрешность слишком велика");
            }
        }
    }
    [TestClass]
    public class CTestArccos_1
    {
        [TestMethod]
        public void Test_Arccos_1()
        {
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                double threshold = 1e-1;
                double arg = (rnd.NextDouble() - 0.5) * 2 - 1e-17;
                double X = CArccos_1.Arccos_1(arg, 4000000);
                Assert.IsTrue(Math.Abs(X - Math.Acos(arg)) < threshold, "Значение функции недостаточно близко к реальному");
                Assert.IsTrue(Math.Abs((X - Math.Acos(arg)) / Math.Acos(arg)) < threshold, "Относительная погрешность слишком велика");
            }
        }
    }
    [TestClass]
    public class CTestTg_1
    {
        [TestMethod]
        public void Test_Tg_1()
        {
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                double threshold = 1e-2;
                double arg = (rnd.NextDouble() - 0.5) * (Math.PI - 1e-17);
                double X = CTg_1.Tg_1(arg, 10);
                Assert.IsTrue(Math.Abs(X - Math.Tan(arg)) < threshold, "Значение функции недостаточно близко к реальному");
                Assert.IsTrue(Math.Abs((X - Math.Tan(arg)) / Math.Tan(arg)) < threshold, "Относительная погрешность слишком велика");
            }
        }
    }
    [TestClass]
    public class CTestCtg_1
    {
        [TestMethod]
        public void Test_Ctg_1()
        {
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                double threshold = 1e-2;
                double arg = (rnd.NextDouble()) * (Math.PI - 1e-17);
                double X = Cctg_1.Сtg_1(arg, 10);
                Assert.IsTrue(Math.Abs(X - 1 / Math.Tan(arg)) < threshold, "Значение функции недостаточно близко к реальному");
                Assert.IsTrue(Math.Abs((X - 1 / Math.Tan(arg)) / (1 / Math.Tan(arg))) < threshold, "Относительная погрешность слишком велика");
            }
        }
    }
    [TestClass]
    public class CTestArctg_1
    {
        [TestMethod]
        public void Test_Arctg_1()
        {
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                double threshold = 1e-2;
                double arg = (rnd.NextDouble() - 0.5) * 2;
                double X = CArctg_1.Arctg_1(arg, 4000000);
                Assert.IsTrue(Math.Abs(X - Math.Atan(arg)) < threshold, "Значение функции недостаточно близко к реальному");
                Assert.IsTrue(Math.Abs((X - Math.Atan(arg)) / Math.Atan(arg)) < threshold, "Относительная погрешность слишком велика");
            }
        }
    }
    [TestClass]
    public class CTestArcctg_1
    {
        [TestMethod]
        public void Test_Arcctg_1()
        {
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                double threshold = 1e-2;
                double arg = (rnd.NextDouble() - 0.5) * 2 - 1e-17;
                double X = CArcctg_1.Arcctg_1(arg, 4000000);
                Assert.IsTrue(Math.Abs(X - (Math.PI / 2.0 - Math.Atan(arg))) < threshold, "Значение функции недостаточно близко к реальному");
                Assert.IsTrue(Math.Abs((X - (Math.PI / 2.0 - Math.Atan(arg))) / (Math.PI / 2.0 - Math.Atan(arg))) < threshold, "Значение функции недостаточно близко к реальному");
            }
        }
    }
    [TestClass]
    public class CTestCosec_1
    {
        [TestMethod]
        public void Test_Cosec_1()
        {
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                double threshold = 1e-3;
                double arg = (rnd.NextDouble()) * (Math.PI - 1e-17);
                double X = CCosec_1.Cosec_1(arg, 12);
                Assert.IsTrue(Math.Abs(X - 1 / Math.Sin(arg)) < threshold, "Значение функции недостаточно близко к реальному");
                Assert.IsTrue(Math.Abs((X - 1 / Math.Sin(arg)) / (1 / Math.Sin(arg))) < threshold, "Значение функции недостаточно близко к реальному");
            }
        }
    }
    [TestClass]
    public class CTestXpow2_Sin_1
    {
        [TestMethod]
        public void TestXpow2_Sin_1()
        {
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                double threshold = 1e-2;
                double arg = (rnd.NextDouble() - 0.5) * (Math.PI - 1e-17);
                double X = OpaqueFunctions.CXpow2_Sin_1.Xpow2_Sin_1(arg, 20);
                Assert.IsTrue(Math.Abs(X - Math.Sin(arg) * Math.Sin(arg)) < threshold, "Значение функции недостаточно близко к реальному");
                Assert.IsTrue(Math.Abs((X - Math.Sin(arg) * Math.Sin(arg)) / (Math.Sin(arg) * Math.Sin(arg))) < threshold, "Значение функции недостаточно близко к реальному");
            }
        }
    }
    [TestClass]
    public class CTestXpow2_Cos_1
    {
        [TestMethod]
        public void TestXpow2_Cos_1()
        {
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                double threshold = 1e-2;
                double arg = (rnd.NextDouble()) * (Math.PI - 1e-17);
                double X = OpaqueFunctions.CXpow2_Cos_1.Xpow2_Cos_1(arg, 20);
                Assert.IsTrue(Math.Abs(X - Math.Cos(arg) * Math.Cos(arg)) < threshold, "Значение функции недостаточно близко к реальному");
                Assert.IsTrue(Math.Abs((X - Math.Cos(arg) * Math.Cos(arg)) / (Math.Cos(arg) * Math.Cos(arg))) < threshold, "Значение функции недостаточно близко к реальному");
            }
        }
    }
    [TestClass]
    public class CTestXpow3_Sin_1
    {
        [TestMethod]
        public void TestXpow3_Sin_1()
        {
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                double threshold = 1e-2;
                double arg = (rnd.NextDouble() - 0.5) * (Math.PI - 1e-17);
                double X = OpaqueFunctions.CXpow3_Sin_1.Xpow3_Sin_1(arg, 20);
                Assert.IsTrue(Math.Abs(X - Math.Sin(arg) * Math.Sin(arg) * Math.Sin(arg)) < threshold, "Значение функции недостаточно близко к реальному");
                Assert.IsTrue(Math.Abs((X - Math.Sin(arg) * Math.Sin(arg) * Math.Sin(arg)) / (Math.Sin(arg) * Math.Sin(arg) * Math.Sin(arg))) < threshold, "Значение функции недостаточно близко к реальному");
            }
        }
    }
    [TestClass]
    public class CTestXpow3_Cos_1
    {
        [TestMethod]
        public void TestXpow3_Cos_1()
        {
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                double threshold = 1e-2;
                double arg = (rnd.NextDouble() - 0.5) * (Math.PI - 1e-17);
                double X = OpaqueFunctions.CXpow3_Cos_1.Xpow3_Cos_1(arg, 20);
                Assert.IsTrue(Math.Abs(X - Math.Cos(arg) * Math.Cos(arg) * Math.Cos(arg)) < threshold, "Значение функции недостаточно близко к реальному");
                Assert.IsTrue(Math.Abs((X - Math.Cos(arg) * Math.Cos(arg) * Math.Cos(arg)) / (Math.Cos(arg) * Math.Cos(arg) * Math.Cos(arg))) < threshold, "Значение функции недостаточно близко к реальному");
            }
        }
    }
}