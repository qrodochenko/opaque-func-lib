using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpaqueFunctions;

namespace ModuleTests
{
    //стандартный подход:
    //var rnd = new Random(); 
    //l + rnd.nextDouble() * (r - l)
    //Где l и r - левый и правый концы промежутка


    //-----------------------
    //L00_30_1_sin_arccos(_in)

    [TestClass]
    public class CTest_L00_30_1_sin_arccos
    {
        [TestMethod]
        public void Test_L00_30_1_sin_arccos()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = (rnd.NextDouble() - 0.5) * 2;

                double F = CL00_30_1_sin_arccos.L00_30_1_sin_arccos(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_30_1_sin_arccos_in()
        {
            string str = "(-1, 1)";
            string F = CL00_30_1_sin_arccos_in.L00_30_1_sin_arccos_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_31_1_cos_arcsin(_in)

    [TestClass]
    public class CTest_L00_31_1_cos_arcsin
    {
        [TestMethod]
        public void Test_L00_31_1_cos_arcsin()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = (rnd.NextDouble() - 0.5) * 2;

                double F = CL00_31_1_cos_arcsin.L00_31_1_cos_arcsin(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_30_1_sin_arccos_in()
        {
            string str = "(-1, 1)";
            string F = CL00_31_1_cos_arcsin_in.L00_31_1_cos_arcsin_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_32_1_sin_arctg_cos_arcctg(_in)

    [TestClass]
    public class CTest_L00_32_1_sin_arctg_cos_arcctg
    {
        [TestMethod]
        public void Test_L00_32_1_sin_arctg_cos_arcctg()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = (rnd.NextDouble() - 0.5) * 2;

                double F = CL00_32_1_sin_arctg_cos_arcctg.L00_32_1_sin_arctg_cos_arcctg(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");

            }
        }

        [TestMethod]
        public void Test_L00_32_1_sin_arctg_cos_arcctg_in()
        {
            string str = "(-1, 1)";
            string F = CL00_32_1_sin_arctg_cos_arcctg_in.L00_32_1_sin_arctg_cos_arcctg_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_33_1_sin_arctg(_in)

    [TestClass]
    public class CTest_L00_33_1_sin_arctg
    {
        [TestMethod]
        public void Test_L00_33_1_sin_arctg()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = (rnd.NextDouble() - 0.5) * 2;

                double F = CL00_33_1_sin_arctg.L00_33_1_sin_arctg(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_33_1_sin_arctg_in()
        {
            string str = "(-1, 1)";
            string F = CL00_33_1_sin_arctg_in.L00_33_1_sin_arctg_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_34_1_cos_arcctg(_in)

    [TestClass]
    public class CTest_L00_34_1_cos_arcctg
    {
        [TestMethod]
        public void Test_L00_34_1_cos_arcctg()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = (rnd.NextDouble() - 0.5) * 2;

                double F = CL00_34_1_cos_arcctg.L00_34_1_cos_arcctg(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_34_1_cos_arcctg_in()
        {
            string str = "(-1, 1)";
            string F = CL00_34_1_cos_arcctg_in.L00_34_1_cos_arcctg_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_35_1_cos_arctg(_in)

    [TestClass]
    public class CTest_L00_35_1_cos_arctg
    {
        [TestMethod]
        public void Test_L00_34_1_cos_arcctg()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = (rnd.NextDouble() - 0.5) * 2;

                double F = CL00_35_1_cos_arctg.L00_35_1_cos_arctg(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_35_1_cos_arctg_in()
        {
            string str = "(-1, 1)";
            string F = CL00_35_1_cos_arctg_in.L00_35_1_cos_arctg_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_36_1_sin_arcctg(_in)

    [TestClass]
    public class CTest_L00_36_1_sin_arcctg
    {
        [TestMethod]
        public void Test_L00_36_1_sin_arcctg()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = (rnd.NextDouble() - 0.5) * 2;

                double F = CL00_36_1_sin_arcctg.L00_36_1_sin_arcctg(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Tast_L00_36_1_sin_arcctg_in()
        {
            string str = "(-1, 1)";
            string F = CL00_36_1_sin_arcctg_in.L00_36_1_sin_arcctg_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_37_1_tg_arcsin(_in)

    [TestClass]
    public class CTest_L00_37_1_tg_arcsin
    {
        [TestMethod]
        public void Test_L00_37_1_tg_arcsin()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = (rnd.NextDouble() - 0.5) * 2;

                double F = CL00_37_1_tg_arcsin.L00_37_1_tg_arcsin(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_37_1_tg_arcsin_in()
        {
            string str = "(-1, 1)";
            string F = CL00_37_1_tg_arcsin_in.L00_37_1_tg_arcsin_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_38_1_ctg_arccos(_in)

    [TestClass]
    public class CTest_L00_38_1_ctg_arccos
    {
        [TestMethod]
        public void Test_L00_38_1_ctg_arccos()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = (rnd.NextDouble() - 0.5) * 2;

                double F = CL00_38_1_ctg_arccos.L00_38_1_ctg_arccos(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_38_1_ctg_arccos_in()
        {
            string str = "(-1, 1)";
            string F = CL00_38_1_ctg_arccos_in.L00_38_1_ctg_arccos_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_39_1_tg_arccos_in(_in)

    [TestClass]
    public class CTest_L00_39_1_tg_arccos
    {
        [TestMethod]
        public void Test_L00_39_1_tg_arccos()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = rnd.NextDouble() - 1;

                double F = CL00_39_1_tg_arccos.L00_39_1_tg_arccos(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_39_1_tg_arccos_in()
        {
            string str = "(-1, 0)";
            string F = CL00_39_1_tg_arccos_in.L00_39_1_tg_arccos_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    //-----------------------
    //L00_40_1_ctg_arcsin_in(_in)

    [TestClass]
    public class CTest_L00_40_1_ctg_arcsin
    {
        [TestMethod]
        public void Test_L00_40_1_ctg_arcsin()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = rnd.NextDouble() - 1;

                double F = CL00_40_1_ctg_arcsin.L00_40_1_ctg_arcsin(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_40_1_ctg_arcsin_in()
        {
            string str = "(-1, 0)";
            string F = CL00_40_1_ctg_arcsin_in.L00_40_1_ctg_arcsin_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_41_1_sin_arcctg_cos_arctg(_in)

    [TestClass]
    public class CTest_L00_41_1_sin_arcctg_cos_arctg
    {
        [TestMethod]
        public void Test_L00_41_1_sin_arcctg_cos_arctg()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = (rnd.NextDouble() - 0.5) * 2;

                double F = CL00_41_1_sin_arcctg_cos_arctg.L00_41_1_sin_arcctg_cos_arctg(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_41_1_sin_arcctg_cos_arctg_in()
        {
            string str = "(-1, 1)";
            string F = CL00_41_1_sin_arcctg_cos_arctg_in.L00_41_1_sin_arcctg_cos_arctg_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_42_1_tg_arctg(_in)

    [TestClass]
    public class CTest_L00_42_1_tg_arctg
    {
        [TestMethod]
        public void Test_L00_42_1_tg_arctg()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = (rnd.NextDouble() - 0.5) * Math.PI;

                double F = CL00_42_1_tg_arctg.L00_42_1_tg_arctg(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_42_1_tg_arctg_in()
        {
            string str = "(-Pi/2, Pi/2)";
            string F = CL00_42_1_tg_arctg_in.L00_42_1_tg_arctg_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_43_1_tg_arcsin_ctg_arccos(_in)

    [TestClass]
    public class CTest_L00_43_1_tg_arcsin_ctg_arccos
    {
        [TestMethod]
        public void Test_L00_43_1_tg_arcsin_ctg_arccos()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = (rnd.NextDouble() - 0.5) * 2;

                double F = CL00_43_1_tg_arcsin_ctg_arccos.L00_43_1_tg_arcsin_ctg_arccos(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_43_1_tg_arcsin_ctg_arccos_in()
        {
            string str = "(-1, 1)";
            string F = CL00_43_1_tg_arcsin_ctg_arccos_in.L00_43_1_tg_arcsin_ctg_arccos_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_44_1_tg_arccos_ctg_arcsin(_in)

    [TestClass]
    public class CTest_L00_44_1_tg_arccos_ctg_arcsin
    {
        [TestMethod]
        public void Test_L00_44_1_tg_arccos_ctg_arcsin()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = rnd.NextDouble() - 1;

                double F = CL00_44_1_tg_arccos_ctg_arcsin.L00_44_1_tg_arccos_ctg_arcsin(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_44_1_tg_arccos_ctg_arcsin_in()
        {
            string str = "(-1, 0)";
            string F = CL00_44_1_tg_arccos_ctg_arcsin_in.L00_44_1_tg_arccos_ctg_arcsin_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_45_1_ctg_arcctg(_in)

    [TestClass]
    public class CTest_L00_45_1_ctg_arcctg
    {
        [TestMethod]
        public void Test_L00_45_1_ctg_arcctg()
        {
            double treshold = 1e-9;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = (rnd.NextDouble() - 0.5) * 2 * 10000;

                double F = CL00_45_1_ctg_arcctg.L00_45_1_ctg_arcctg(arg);
                double err = Math.Abs(F - 0);
                Assert.IsTrue(err < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_45_1_ctg_arcctg_in()
        {
            string str = "(w, w)";
            string F = CL00_45_1_ctg_arcctg_in.L00_45_1_ctg_arcctg_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_46_1_arcsin_sin(_in)

    [TestClass]
    public class CTest_L00_46_1_arcsin_sin
    {
        [TestMethod]
        public void Test_L00_46_1_arcsin_sin()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = (rnd.NextDouble() - 0.5) * Math.PI;

                double F = CL00_46_1_arcsin_sin.L00_46_1_arcsin_sin(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_46_1_arcsin_sin_in()
        {
            string str = "(-Pi/2, Pi/2)";
            string F = CL00_46_1_arcsin_sin_in.L00_46_1_arcsin_sin_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_47_1_arccos_cos(_in)

    [TestClass]
    public class CTest_L00_47_1_arccos_cos
    {
        [TestMethod]
        public void Test_L00_47_1_arccos_cos()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = rnd.NextDouble() * Math.PI;

                double F = CL00_47_1_arccos_cos.L00_47_1_arccos_cos(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_47_1_arccos_cos_in()
        {
            string str = "(0, Pi)";
            string F = CL00_47_1_arccos_cos_in.L00_47_1_arccos_cos_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_48_1_arctg_tg(_in)

    [TestClass]
    public class CTest_L00_48_1_arctg_tg
    {
        [TestMethod]
        public void Test_L00_48_1_arctg_tg()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = (rnd.NextDouble() - 0.5) * Math.PI;

                double F = CL00_48_1_arctg_tg.L00_48_1_arctg_tg(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_48_1_arctg_tg_in()
        {
            string str = "(-Pi/2, Pi/2)";
            string F = CL00_48_1_arctg_tg_in.L00_48_1_arctg_tg_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_49_1_arcctg_ctg(_in)

    [TestClass]
    public class CTest_L00_49_1_arcctg_ctg
    {
        [TestMethod]
        public void Test_L00_49_1_arcctg_ctg()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = (rnd.NextDouble() - 0.5) * 2;

                double F = CL00_49_1_arcctg_ctg.L00_49_1_arcctg_ctg(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_49_1_arcctg_ctg_in()
        {
            string str = "(-1, 1)";
            string F = CL00_49_1_arcctg_ctg_in.L00_49_1_arcctg_ctg_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_50_1_arctg_arcctg(_in)

    [TestClass]
    public class CTest_L00_50_1_arctg_arcctg
    {
        [TestMethod]
        public void Test_L00_50_1_arctg_arcctg()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = (rnd.NextDouble() - 0.5) * 2 * double.MaxValue;

                double F = CL00_50_1_arctg_arcctg.L00_50_1_arctg_arcctg(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_50_1_arctg_arcctg_in()
        {
            string str = "(w, w)";
            string F = CL00_50_1_arctg_arcctg_in.L00_50_1_arctg_arcctg_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_51_1_arctg_arcsin(_in)

    [TestClass]
    public class CTest_L00_51_1_arctg_arcsin
    {
        [TestMethod]
        public void Test_L00_51_1_arctg_arcsin()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = (rnd.NextDouble() - 0.5) * 2;

                double F = CL00_51_1_arctg_arcsin.L00_51_1_arctg_arcsin(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_51_1_arctg_arcsin_in()
        {
            string str = "(-1, 1)";
            string F = CL00_51_1_arctg_arcsin_in.L00_51_1_arctg_arcsin_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_52_1_arcsin_arccos(_in)

    [TestClass]
    public class CTest_L00_52_1_arcsin_arccos
    {
        [TestMethod]
        public void Test_L00_52_1_arcsin_arccos()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = rnd.NextDouble();

                double F = CL00_52_1_arcsin_arccos.L00_52_1_arcsin_arccos(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_52_1_arcsin_arccos_in()
        {
            string str = "(0, 1)";
            string F = CL00_52_1_arcsin_arccos_in.L00_52_1_arcsin_arccos_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_53_1_arcctg_arcsin(_in)

    [TestClass]
    public class CTest_L00_53_1_arcctg_arcsin
    {
        [TestMethod]
        public void Test_L00_53_1_arcctg_arcsin()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = rnd.NextDouble();

                double F = CL00_53_1_arcctg_arcsin.L00_53_1_arcctg_arcsin(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_53_1_arcctg_arcsinn_in()
        {
            string str = "(0, 1)";
            string F = CL00_53_1_arcctg_arcsin_in.L00_53_1_arcctg_arcsin_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_54_1_arccos_arcctg(_in)

    [TestClass]
    public class CTest_L00_54_1_arccos_arcctg
    {
        [TestMethod]
        public void Test_L00_54_1_arccos_arcctg()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = rnd.NextDouble();

                double F = CL00_54_1_arccos_arcctg.L00_54_1_arccos_arcctg(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_54_1_arccos_arcctg_in()
        {
            string str = "(0, 1)";
            string F = CL00_54_1_arccos_arcctg_in.L00_54_1_arccos_arcctg_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_55_1_arccos_arcctg(_in)

    [TestClass]
    public class CTest_L00_55_1_arccos_arcctg
    {
        [TestMethod]
        public void Test_L00_55_1_arccos_arcctg()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = (rnd.NextDouble() - 0.5) * 2;

                double F = CL00_55_1_arccos_arcctg.L00_55_1_arccos_arcctg(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_55_1_arccos_arcctg_in()
        {
            string str = "(-1, 1)";
            string F = CL00_55_1_arccos_arcctg_in.L00_55_1_arccos_arcctg_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_56_1_arccos_arctg(_in)

    [TestClass]
    public class CTest_L00_56_1_arccos_arctg
    {
        [TestMethod]
        public void Test_L00_56_1_arccos_arctg()
        {
            double treshold = 1e-14;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = rnd.NextDouble();

                double F = CL00_56_1_arccos_arctg.L00_56_1_arccos_arctg(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_56_1_arccos_arctg_in()
        {
            string str = "(0, 1)";
            string F = CL00_56_1_arccos_arctg_in.L00_56_1_arccos_arctg_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }


    //-----------------------
    //L00_57_1_arctg_arcsin(_in)

    [TestClass]
    public class CTest_L00_57_1_arctg_arcsin
    {
        [TestMethod]
        public void Test_L00_57_1_arctg_arcsin()
        {
            double treshold = 1e-12;
            for (int i = 1; i <= 10; i++)
            {
                var rnd = new Random();
                var arg = (rnd.NextDouble() - 0.5) * 2 * 10000;

                double F = CL00_57_1_arctg_arcsin.L00_57_1_arctg_arcsin(arg);
                double err = Math.Abs(F - 0);
                Assert.IsTrue(err < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_57_1_arctg_arcsin_in()
        {
            string str = "(w, w)";
            string F = CL00_57_1_arctg_arcsin_in.L00_57_1_arctg_arcsin_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }
}
