using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpaqueFunctions;

namespace ModuleTests
{
    [TestClass]
    public class CTestL01_1_1_SinCos
    {
        [TestMethod]
        public void TestL01_1_1_SinCos()
        {
            var random_point_generator = new Random();
            for(int i=0; i<10; i++)
            { 
                double x = random_point_generator.NextDouble();
                x = x * 2 - 1;
                double F = CL01_1_1_SinCos.L01_1_1_SinCos(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_1_1_SinCos_in()
        {
            string s = "(-1, 1)";
            string F = CL01_1_1_SinCos_in.L01_1_1_SinCos_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_2_1_TgCosSin
    {
        [TestMethod]
        //Погрешность несколько больше машинного эпсилон. Выбрал ошибку 0.000000000000001 
        //на основе информации отладчика.
        public void TestL01_2_1_TgCosSin()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                x = x * Math.PI / 2;
                double F = CL01_2_1_TgCosSin.L01_2_1_TgCosSin(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.000000000000001;
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_2_1_TgCosSin_in()
        {
            string s = "(0, Pi/2)";
            string F = CL01_2_1_TgCosSin_in.L01_2_1_TgCosSin_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_3_1_CtgSinCos
    {
        [TestMethod]
        //Погрешность несколько больше машинного эпсилон. Выбрал ошибку 0.00000000000009 
        //на основе информации отладчика.
        public void TestL01_3_1_CtgSinCos()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                x = x * Math.PI / 2;
                double F = CL01_3_1_CtgSinCos.L01_3_1_CtgSinCos(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_3_1_CtgSinCos_in()
        {
            string s = "(0, Pi/2)";
            string F = CL01_3_1_CtgSinCos_in.L01_3_1_CtgSinCos_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_4_1_SecCos
    {
        [TestMethod]
        public void TestL01_4_1_SecCos()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                x = x * Math.PI - Math.PI / 2;
                double F = CL01_4_1_SecCos.L01_4_1_SecCos(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_4_1_SecCos_in()
        {
            string s = "(-Pi/2, Pi/2)";
            string F = CL01_4_1_SecCos_in.L01_4_1_SecCos_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_5_1_CosecSin
    {
        [TestMethod]
        public void TestL01_5_1_CosecSin()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                x = x * Math.PI;
                double F = CL01_5_1_CosecSin.L01_5_1_CosecSin(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_5_1_CosecSin_in()
        {
            string s = "(0, Pi)";
            string F = CL01_5_1_CosecSin_in.L01_5_1_CosecSin_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_6_2_SinCosPlusCosSinSin
    {
        [TestMethod]
        public void TestL01_6_2_SinCosPlusCosSinSin()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                double y = random_point_generator.NextDouble();
                x = x * Math.PI / 2;
                y = y * Math.PI / 2;
                double F = CL01_6_2_SinCosPlusCosSinSin.L01_6_2_SinCosPlusCosSinSin(x, y);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_6_2_SinCosPlusCosSinSin_in()
        {
            string s = "(0, Pi/2) (0, Pi/2)";
            string F = CL01_6_2_SinCosPlusCosSinSin_in.L01_6_2_SinCosPlusCosSinSin_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_7_2_SinCosMinusCosSinSin
    {
        [TestMethod]
        //Погрешность несколько больше машинного эпсилон. Выбрал ошибку 0.00000000000009 
        //на основе информации отладчика.
        public void TestL01_7_2_SinCosMinusCosSinSin()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                double y = random_point_generator.NextDouble();
                x = x * Math.PI / 2 + Math.PI / 2;
                y = y * Math.PI / 2;
                double F = CL01_7_2_SinCosMinusCosSinSin.L01_7_2_SinCosMinusCosSinSin(x, y);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_7_2_SinCosMinusCosSinSin_in()
        {
            string s = "(Pi/2, Pi) (0, Pi/2)";
            string F = CL01_7_2_SinCosMinusCosSinSin_in.L01_7_2_SinCosMinusCosSinSin_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_8_2_CosCosSinSinCos
    {
        [TestMethod]
        //Погрешность несколько больше машинного эпсилон. Выбрал ошибку 0.00000000000009 
        //на основе информации отладчика.
        public void TestL01_8_2_CosCosSinSinCos()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                double y = random_point_generator.NextDouble();
                x = x * Math.PI / 2 - Math.PI / 4;
                y = y * Math.PI / 2 - Math.PI / 4;
                double F = CL01_8_2_CosCosSinSinCos.L01_8_2_CosCosSinSinCos(x, y);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_8_2_CosCosSinSinCos_in()
        {
            string s = "(-Pi/4, Pi/4) (-Pi/4, Pi/4)";
            string F = CL01_8_2_CosCosSinSinCos_in.L01_8_2_CosCosSinSinCos_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_9_2_Tg
    {
        [TestMethod]
        //Погрешность несколько больше машинного эпсилон. Выбрал ошибку 0.00000000000009 
        //на основе информации отладчика.
        public void TestL01_9_2_Tg()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                double y = random_point_generator.NextDouble();
                x = x * Math.PI / 2 - Math.PI / 4;
                y = y * Math.PI / 2 - Math.PI / 4;
                double F = CL01_9_2_Tg.L01_9_2_Tg(x, y);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;//
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_9_2_Tg_in()
        {
            string s = "(-Pi/4, Pi/4) (-Pi/4, Pi/4)";
            string F = CL01_9_2_Tg_in.L01_9_2_Tg_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_10_2_Ctg
    {
        [TestMethod]
        //Погрешность несколько больше машинного эпсилон. Выбрал ошибку 0.00000000000009 
        //на основе информации отладчика.
        public void TestL01_10_2_Ctg()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                double y = random_point_generator.NextDouble();
                x = x * Math.PI / 2;
                y = y * Math.PI / 2;
                double F = CL01_10_2_Ctg.L01_10_2_Ctg(x, y);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;//
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_10_2_Ctg_in()
        {
            string s = "(0, Pi/2) (0, Pi/2)";
            string F = CL01_10_2_Ctg_in.L01_10_2_Ctg_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_11_2_CosCosCosCos
    {
        [TestMethod]
        public void TestL01_11_2_CosCosCosCos()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                double y = random_point_generator.NextDouble();
                x = x * Math.PI / 2;
                y = y * Math.PI / 2;
                double F = CL01_11_2_CosCosCosCos.L01_11_2_CosCosCosCos(x, y);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;//
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_11_2_CosCosCosCos_in()
        {
            string s = "(0, Pi/2) (0, Pi/2)";
            string F = CL01_11_2_CosCosCosCos_in.L01_11_2_CosCosCosCos_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_12_2_CosCosSinSin
    {
        [TestMethod]
        //Погрешность несколько больше машинного эпсилон. Выбрал ошибку 0.00000000000009 
        //на основе информации отладчика.
        public void TestL01_12_2_CosCosSinSin()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                double y = random_point_generator.NextDouble();
                x = x * Math.PI - Math.PI / 2;
                y = y * Math.PI - Math.PI / 2;
                double F = CL01_12_2_CosCosSinSin.L01_12_2_CosCosSinSin(x, y);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_12_2_CosCosSinSin_in()
        {
            string s = "(-Pi/2, Pi/2) (-Pi/2, Pi/2)";
            string F = CL01_12_2_CosCosSinSin_in.L01_12_2_CosCosSinSin_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_13_2_SinSinSinCos
    {
        [TestMethod]
        //Погрешность несколько больше машинного эпсилон. Выбрал ошибку 0.00000000000009 
        //на основе информации отладчика.
        public void TestL01_13_2_SinSinSinCos()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                double y = random_point_generator.NextDouble();
                x = x * Math.PI;
                y = y * Math.PI - Math.PI / 2;
                double F = CL01_13_2_SinSinSinCos.L01_13_2_SinSinSinCos(x, y);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_13_2_SinSinSinCos_in()
        {
            string s = "(0, Pi) (-Pi/2, Pi/2)";
            string F = CL01_13_2_SinSinSinCos_in.L01_13_2_SinSinSinCos_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_14_1_SinCosSin
    {
        [TestMethod]
        //Погрешность несколько больше машинного эпсилон. Выбрал ошибку 0.00000000000009 
        //на основе информации отладчика.
        public void TestL01_14_1_SinCosSin()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                x = x * Math.PI / 2;
                double F = CL01_14_1_SinCosSin.L01_14_1_SinCosSin(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_14_1_SinCosSin_in()
        {
            string s = "(0, Pi/2)";
            string F = CL01_14_1_SinCosSin_in.L01_14_1_SinCosSin_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_15_1_Sin
    {
        [TestMethod]
        //Погрешность несколько больше машинного эпсилон. Выбрал ошибку 0.00000000000009 
        //на основе информации отладчика.
        public void TestL01_15_1_Sin()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                x = x * Math.PI / 3;
                double F = CL01_15_1_Sin.L01_15_1_Sin(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;//
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_15_1_Sin_in()
        {
            string s = "(0, Pi/3)";
            string F = CL01_15_1_Sin_in.L01_15_1_Sin_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_16_1_SinArcsin
    {
        [TestMethod]
        public void TestL01_16_1_SinArcsin()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                double F = CL01_16_1_SinArcsin.L01_16_1_SinArcsin(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_16_1_SinArcsin_in()
        {
            string s = "(0, 1)";
            string F = CL01_16_1_SinArcsin_in.L01_16_1_SinArcsin_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_17_1_CosArccos
    {
        [TestMethod]
        //Погрешность несколько больше машинного эпсилон. Выбрал ошибку 0.00000000000009 
        //на основе информации отладчика.
        public void TestL01_17_1_CosArccos()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                double F = CL01_17_1_CosArccos.L01_17_1_CosArccos(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.0000000000009;//
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_17_1_CosArccos_in()
        {
            string s = "(0, 1)";
            string F = CL01_17_1_CosArccos_in.L01_17_1_CosArccos_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_18_1_CosArcsin
    {
        [TestMethod]
        //Погрешность несколько больше машинного эпсилон. Выбрал ошибку 0.00000000000009 
        //на основе информации отладчика.
        public void TestL01_18_1_CosArcsin()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                x = x * 2 - 1;
                double F = CL01_18_1_CosArcsin.L01_18_1_CosArcsin(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_18_1_CosArcsin_in()
        {
            string s = "(-1, 1)";
            string F = CL01_18_1_CosArcsin_in.L01_18_1_CosArcsin_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_19_1_SinArccos
    {
        [TestMethod]
        //Погрешность несколько больше машинного эпсилон. Выбрал ошибку 0.00000000000009 
        //на основе информации отладчика.
        public void TestL01_19_1_SinArccos()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                x = x * 2 - 1;
                double F = CL01_19_1_SinArccos.L01_19_1_SinArccos(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_19_1_SinArccos_in()
        {
            string s = "(-1, 1)";
            string F = CL01_19_1_SinArccos_in.L01_19_1_SinArccos_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_20_1_CosArcsin
    {
        [TestMethod]
        public void TestL01_20_1_CosArcsin()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                x = x * 2 - 1;
                double F = CL01_20_1_CosArcsin.L01_20_1_CosArcsin(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_20_1_CosArcsin_in()
        {
            string s = "(-1, 1)";
            string F = CL01_20_1_CosArcsin_in.L01_20_1_CosArcsin_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_21_1_CosArcctg
    {
        [TestMethod]
        //Погрешность несколько больше машинного эпсилон. Выбрал ошибку 0.00000000000009 
        //на основе информации отладчика.
        public void TestL01_21_1_CosArcctg()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                x = x * Math.PI / 2;
                double F = CL01_21_1_CosArcctg.L01_21_1_CosArcctg(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_21_1_CosArcctg_in()
        {
            string s = "(0, Pi/2)";
            string F = CL01_21_1_CosArcctg_in.L01_21_1_CosArcctg_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_22_1_SinArctg
    {
        [TestMethod]
        //Погрешность несколько больше машинного эпсилон. Выбрал ошибку 0.00000000000009 
        //на основе информации отладчика.
        public void TestL01_22_1_SinArctg()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                x = x * 100;
                double F = CL01_22_1_SinArctg.L01_22_1_SinArctg(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_22_1_SinArctg_in()
        {
            string s = "(0, w)";
            string F = CL01_22_1_SinArctg_in.L01_22_1_SinArctg_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_23_1_CosArcctg
    {
        [TestMethod]
        //Погрешность несколько больше машинного эпсилон. Выбрал ошибку 0.00000000000009 
        //на основе информации отладчика.
        public void TestL01_23_1_CosArcctg()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                x = x * 100;
                double F = CL01_23_1_CosArcctg.L01_23_1_CosArcctg(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_23_1_CosArcctg_in()
        {
            string s = "(0, w)";
            string F = CL01_23_1_CosArcctg_in.L01_23_1_CosArcctg_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_24_1_CosArctg
    {
        [TestMethod]
        public void TestL01_24_1_CosArctg()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                x = x * 100;
                double F = CL01_24_1_CosArctg.L01_24_1_CosArctg(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;//
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_24_1_CosArctg_in()
        {
            string s = "(0, w)";
            string F = CL01_24_1_CosArctg_in.L01_24_1_CosArctg_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_25_1_SinArcctg
    {
        [TestMethod]
        public void TestL01_25_1_SinArcctg()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                x = x * 100;
                double F = CL01_25_1_SinArcctg.L01_25_1_SinArcctg(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;//
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_25_1_SinArcctg_in()
        {
            string s = "(0, w)";
            string F = CL01_25_1_SinArcctg_in.L01_25_1_SinArcctg_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_26_1_TgArcsin
    {
        [TestMethod]
        //Погрешность несколько больше машинного эпсилон. Выбрал ошибку 0.00000000000009 
        //на основе информации отладчика.
        public void TestL01_26_1_TgArcsin()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                double F = CL01_26_1_TgArcsin.L01_26_1_TgArcsin(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_26_1_TgArcsin_in()
        {
            string s = "(0, 1)";
            string F = CL01_26_1_TgArcsin_in.L01_26_1_TgArcsin_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_27_1_CtgArccos
    {
        [TestMethod]
        //Погрешность несколько больше машинного эпсилон. Выбрал ошибку 0.00000000000009 
        //на основе информации отладчика.
        public void TestL01_27_1_CtgArccos()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                double F = CL01_27_1_CtgArccos.L01_27_1_CtgArccos(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_27_1_CtgArccos_in()
        {
            string s = "(0, 1)";
            string F = CL01_27_1_CtgArccos_in.L01_27_1_CtgArccos_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_28_1_TgArccos
    {
        [TestMethod]
        //Погрешность несколько больше машинного эпсилон. Выбрал ошибку 0.00000000000009 
        //на основе информации отладчика.
        public void TestL01_28_1_TgArccos()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                double F = CL01_28_1_TgArccos.L01_28_1_TgArccos(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_28_1_TgArccos_in()
        {
            string s = "(0, 1)";
            string F = CL01_28_1_TgArccos_in.L01_28_1_TgArccos_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_29_1_CtgArcsin
    {
        [TestMethod]
        public void TestL01_29_1_CtgArcsin()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                double F = CL01_29_1_CtgArcsin.L01_29_1_CtgArcsin(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_29_1_CtgArcsin_in()
        {
            string s = "(0, 1)";
            string F = CL01_29_1_CtgArcsin_in.L01_29_1_CtgArcsin_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_30_1_CosArctg
    {
        [TestMethod]
        public void TestL01_30_1_CosArctg()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                x = x * Math.PI / 2;
                double F = CL01_30_1_CosArctg.L01_30_1_CosArctg(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_30_1_CosArctg_in()
        {
            string s = "(0, Pi/2)";
            string F = CL01_30_1_CosArctg_in.L01_30_1_CosArctg_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_31_1_TgArctg
    {
        [TestMethod]
        public void TestL01_31_1_TgArctg()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                x = x * 100;
                double F = CL01_31_1_TgArctg.L01_31_1_TgArctg(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;//
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_31_1_TgArctg_in()
        {
            string s = "(0, w)";
            string F = CL01_31_1_TgArctg_in.L01_31_1_TgArctg_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_32_1_CtgArcctg
    {
        [TestMethod]
        //Погрешность несколько больше машинного эпсилон. Выбрал ошибку 0.00000000000009 
        //на основе информации отладчика.
        public void TestL01_32_1_CtgArcctg()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                x = x * 100;
                double F = CL01_32_1_CtgArcctg.L01_32_1_CtgArcctg(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;//
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_32_1_CtgArcctg_in()
        {
            string s = "(0, w)";
            string F = CL01_32_1_CtgArcctg_in.L01_32_1_CtgArcctg_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }

    [TestClass]
    public class CTestL01_33_1_ArcsinSin
    {
        [TestMethod]
        public void TestL01_33_1_ArcsinSin()
        {
            var random_point_generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random_point_generator.NextDouble();
                x = x * Math.PI / 2;
                double F = CL01_33_1_ArcsinSin.L01_33_1_ArcsinSin(x);
                double error = Math.Abs(F - 1);
                double MyEpsilon = 0.00000000000009;
                Assert.IsTrue(Math.Abs(F - 1) < MyEpsilon, "Значение функции не единица!");
            }
        }
        [TestMethod]
        public void TestL01_33_1_ArcsinSin_in()
        {
            string s = "(0, Pi/2)";
            string F = CL01_33_1_ArcsinSin_in.L01_33_1_ArcsinSin_in();
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }
    }
}
