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
    public class Ctest_LOX_1_1_sin_arcsin
    {
        double treshold = 0.0000000000001;
        
        [TestMethod]
        public void test_LOX_1_1_sin_arcsin()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_1_1_sin_arcsin.LOX_1_1_sin_arcsin(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }
            
        }

        [TestMethod]
        public void test_LOX_1_1_sin_arcsin_in()
        {
            string F = CLOX_1_1_sin_arcsin_in.LOX_1_1_sin_arcsin_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_2_1_cos_arccos
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_2_1_cos_arccos()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_2_1_cos_arccos.LOX_2_1_cos_arccos(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_2_1_cos_arccos_in()
        {
            string F = CLOX_2_1_cos_arccos_in.LOX_2_1_cos_arccos_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_3_1_tg_arctg
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_3_1_tg_arctg()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_3_1_tg_arctg.LOX_3_1_tg_arctg(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_3_1_tg_arctg_in()
        {
            string F = CLOX_3_1_tg_arctg_in.LOX_3_1_tg_arctg_in();
            string s = "(-Pi/2, Pi/2)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_4_1_ctg_arcctg
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_4_1_ctg_arcctg()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_4_1_ctg_arcctg.LOX_4_1_ctg_arcctg(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_4_1_ctg_arcctg_in()
        {
            string F = CLOX_4_1_ctg_arcctg_in.LOX_4_1_ctg_arcctg_in();
            string s = "(-Pi/2, Pi/2)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_5_1_arcsin_sin
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_5_1_arcsin_sin()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_5_1_arcsin_sin.LOX_5_1_arcsin_sin(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_5_1_arcsin_sin_in()
        {
            string F = CLOX_5_1_arcsin_sin_in.LOX_5_1_arcsin_sin_in();
            string s = "(-Pi/2, Pi/2)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_6_1_arccos_cos
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_6_1_arccos_cos()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_6_1_arccos_cos.LOX_6_1_arccos_cos(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_6_1_arccos_cos_in()
        {
            string F = CLOX_6_1_arccos_cos_in.LOX_6_1_arccos_cos_in();
            string s = "(0, Pi)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_7_1_arctg_tg
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_7_1_arctg_tg()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_7_1_arctg_tg.LOX_7_1_arctg_tg(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_7_1_arctg_tg_in()
        {
            string F = CLOX_7_1_arctg_tg_in.LOX_7_1_arctg_tg_in();
            string s = "(-Pi/2, Pi/2)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_8_1_arcctg_ctg
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_8_1_arcctg_ctg()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_8_1_arcctg_ctg.LOX_8_1_arcctg_ctg(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_8_1_arcctg_ctg_in()
        {
            string F = CLOX_8_1_arcctg_ctg_in.LOX_8_1_arcctg_ctg_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_9_2_xpowy_xpown_1divn
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_9_2_xpowy_xpown_1divn()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_9_2_xpowy_xpown_1divn.LOX_9_2_xpowy_xpown_1divn(param, 2);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
                Console.WriteLine(F);
            }

        }

        [TestMethod]
        public void test_LOX_9_2_xpowy_xpown_1divn_in()
        {
            string F = CLOX_9_2_xpowy_xpown_1divn_in.LOX_9_2_xpowy_xpown_1divn_in();
            string s = "(0, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_10_2_xpown_xpown_1divn
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_10_2_xpown_xpown_1divn()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_10_2_xpown_xpown_1divn.LOX_10_2_xpown_xpown_1divn(param, 5);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_10_2_xpown_xpown_1divn_in()
        {
            string F = CLOX_10_2_xpown_xpown_1divn_in.LOX_10_2_xpown_xpown_1divn_in();
            string s = "(0, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_11_2_logax_apowx
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_11_2_logax_apowx()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_11_2_logax_apowx.LOX_11_2_logax_apowx(param, 5);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_11_2_logax_apowx_in()
        {
            string F = CLOX_11_2_logax_apowx_in.LOX_11_2_logax_apowx_in();
            string s = "(w, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_12_2_xpowy_logax
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_12_2_xpowy_logax()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_12_2_xpowy_logax.LOX_12_2_xpowy_logax(param, 5);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_12_2_xpowy_logax_in()
        {
            string F = CLOX_12_2_xpowy_logax_in.LOX_12_2_xpowy_logax_in();
            string s = "(0, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_13_1_lnx_epowx
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_13_1_lnx_epowx()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_13_1_lnx_epowx.LOX_13_1_lnx_epowx(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_13_1_lnx_epowx_in()
        {
            string F = CLOX_13_1_lnx_epowx_in.LOX_13_1_lnx_epowx_in();
            string s = "(w, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_14_1_xpowy_lnx
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_14_1_xpowy_lnx()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_14_1_xpowy_lnx.LOX_14_1_xpowy_lnx(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_14_1_xpowy_lnx_in()
        {
            string F = CLOX_14_1_xpowy_lnx_in.LOX_14_1_xpowy_lnx_in();
            string s = "(w, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_15_1_sh_arsh
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_15_1_sh_arsh()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_15_1_sh_arsh.LOX_15_1_sh_arsh(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_15_1_sh_arsh_in()
        {
            string F = CLOX_15_1_sh_arsh_in.LOX_15_1_sh_arsh_in();
            string s = "(w, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_16_1_arsh_sh
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_16_1_arsh_sh()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_16_1_arsh_sh.LOX_16_1_arsh_sh(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_16_1_arsh_sh_in()
        {
            string F = CLOX_16_1_arsh_sh_in.LOX_16_1_arsh_sh_in();
            string s = "(w, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_17_1_ch_arch
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_17_1_ch_arch()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = 1 + random.NextDouble();
                double F = CLOX_17_1_ch_arch.LOX_17_1_ch_arch(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, String.Format("Значение функции в точке {0} с индексом {1} не x!", param, i));
            }

        }

        [TestMethod]
        public void test_LOX_17_1_ch_arch_in()
        {
            string F = CLOX_17_1_ch_arch_in.LOX_17_1_ch_arch_in();
            string s = "(1, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_18_1_arch_ch
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_18_1_arch_ch()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_18_1_arch_ch.LOX_18_1_arch_ch(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_18_1_arch_ch_in()
        {
            string F = CLOX_18_1_arch_ch_in.LOX_18_1_arch_ch_in();
            string s = "(0, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_19_1_th_arth
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_19_1_th_arth()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_19_1_th_arth.LOX_19_1_th_arth(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_19_1_th_arth_in()
        {
            string F = CLOX_19_1_th_arth_in.LOX_19_1_th_arth_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_20_1_arth_th
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_20_1_arth_th()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = 1 + random.NextDouble();
                double F = CLOX_20_1_arth_th.LOX_20_1_arth_th(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_20_1_arth_th_in()
        {
            string F = CLOX_20_1_arth_th_in.LOX_20_1_arth_th_in();
            string s = "(1, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }


    [TestClass]
    public class Ctest_LOX_21_1_cth_arcth
    {
        double treshold = 0.00001;

        [TestMethod]
        public void test_LOX_21_1_cth_arcth()
        {
            Random random = new Random();
            double param = random.NextDouble(); 
            for (int i = 1; i <= 10; i++)
            {
                param = 1 + random.NextDouble();
                double F = CLOX_21_1_cth_arcth.LOX_21_1_cth_arcth(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }
          
        }

        [TestMethod]
        public void test_LOX_21_1_cth_arcth_in()
        {
            string F = CLOX_21_1_cth_arcth_in.LOX_21_1_cth_arcth_in();
            string s = "(1, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }




    [TestClass]
    public class Ctest_LOX_22_1_arcth_cth
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_22_1_arcth_cth()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_22_1_arcth_cth.LOX_22_1_arcth_cth(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_22_1_arcth_cth_in()
        {
            string F = CLOX_22_1_arcth_cth_in.LOX_22_1_arcth_cth_in();
            string s = "(0, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }
}
