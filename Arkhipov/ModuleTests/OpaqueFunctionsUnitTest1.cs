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
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            double X = Opaque1SinCos.Body(360, 10);
            Assert.IsTrue(Math.Abs(X - 1) < treshold, "Значение функции не единица!");
        }
    }


    [TestClass]
    public class CTest_L00_86_1_th
    {
        [TestMethod]
        public void Test_L00_86_1_th()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            for (int i = 0; i < 10; i++)
            {
                var rnd = new Random();
                var arg = (rnd.NextDouble() - 0.5) * double.MaxValue;

                double F = CL00_86_1_th.L00_86_1_th(arg);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль");
            }
        }
        [TestMethod]
        public void Test_L00_86_1_th_in()
        {
            string str = "(w, w)";
            string F = CL00_86_1_th_in.L00_86_1_th_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    /*
        [TestClass]
        public class CTest_L00_86_1_th
        {
            [TestMethod]
            public void Test_L00_86_1_th()
            {
                double F = CL00_86_1_th.L00_86_1_th(5);
                Assert.IsTrue(Math.Abs(F - 0) < double.Epsilon, "Значение функции не ноль!");
            }

            [TestMethod]
            public void Test_L00_86_1_th_in()
            {
                string str = "(w, w)";
                string F = CL00_86_1_th_in.L00_86_1_th_in();
                Assert.IsTrue(F == str, "Область определения задана неверно!");
            }
        }
    */

    /*  l + rnd.nextDouble()*(r-l)
        Где l и r - левый и правый концы промежутка 
        
        var rnd = new Random();
        var dbl = (rnd.NextDouble() - 0.5) * Math.PI; */


    [TestClass]
    public class CTest_L00_87_2_sh_ch
    {
        [TestMethod]
        public void Test_L00_87_2_sh_ch()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            for (int i = 0; i < 10; i++)
            {
                var rnd = new Random();
                var arg = (rnd.NextDouble() - 0.5) * double.MaxValue;

                var rnd2 = new Random();
                var arg2 = (rnd2.NextDouble() - 0.5) * double.MaxValue;

                double F = CL00_87_2_sh_ch.L00_87_2_sh_ch(arg, arg2);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль");
            }
        }

        [TestMethod]
        public void Test_L00_87_2_sh_ch_in()
        {
            string str = "(w, w) (w, w)";
            string F = CL00_87_2_sh_ch_in.L00_87_2_sh_ch_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_88_2_sh_ch
    {
        [TestMethod]
        public void Test_L00_88_2_sh_ch()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            for (int i = 0; i < 10; i++)
            {
                var rnd = new Random();
                var arg = (rnd.NextDouble() - 0.5) * double.MaxValue;

                var rnd2 = new Random();
                var arg2 = (rnd2.NextDouble() - 0.5) * double.MaxValue;

                double F = CL00_88_2_sh_ch.L00_88_2_sh_ch(arg, arg2);
                Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            }
        }

        [TestMethod]
        public void Test_L00_88_2_sh_ch_in()
        {
            string str = "(w, w)";
            string F = CL00_88_2_sh_ch_in.L00_88_2_sh_ch_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_89_2_ch
    {
        [TestMethod]
        public void Test_L00_89_2_ch()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = (rnd.NextDouble() - 0.5) * double.MaxValue;

            var rnd2 = new Random();
            var arg2 = (rnd2.NextDouble() - 0.5) * double.MaxValue;

            double F = CL00_89_2_ch.L00_89_2_ch(arg, arg2);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_89_2_ch_in()
        {
            string str = "(w, w)";
            string F = CL00_89_2_ch_in.L00_89_2_ch_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_90_2_ch_sh
    {
        [TestMethod]
        public void Test_L00_90_2_ch_sh()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = (rnd.NextDouble() - 0.5) * double.MaxValue;

            var rnd2 = new Random();
            var arg2 = (rnd2.NextDouble() - 0.5) * double.MaxValue;

            double F = CL00_90_2_ch_sh.L00_90_2_ch_sh(arg, arg2);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_90_2_ch_in()
        {
            string str = "(w, w)";
            string F = CL00_90_2_ch_sh_in.L00_90_2_ch_sh_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_91_2_th_sh_ch
    {
        [TestMethod]
        public void Test_L00_91_2_th_sh_ch()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = (rnd.NextDouble() - 0.5) * double.MaxValue;

            var rnd2 = new Random();
            var arg2 = (rnd2.NextDouble() - 0.5) * double.MaxValue;

            double F = CL00_91_2_th_sh_ch.L00_91_2_th_sh_ch(arg, arg2);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_91_2_th_sh_ch_in()
        {
            string str = "(w, w)";
            string F = CL00_91_2_th_sh_ch_in.L00_91_2_th_sh_ch_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_92_2_th_sh_ch
    {
        [TestMethod]
        public void Test_L00_92_2_th_sh_ch()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = (rnd.NextDouble() - 0.5) * double.MaxValue;

            var rnd2 = new Random();
            var arg2 = (rnd2.NextDouble() - 0.5) * double.MaxValue;

            double F = CL00_92_2_th_sh_ch.L00_92_2_th_sh_ch(arg, arg2);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_92_2_th_sh_ch_in()
        {
            string str = "(w, w)";
            string F = CL00_92_2_th_sh_ch_in.L00_92_2_th_sh_ch_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_93_2_cth_sh
    {
        [TestMethod]
        public void Test_L00_93_2_cth_sh()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = rnd.NextDouble() * double.MaxValue;

            var rnd2 = new Random();
            var arg2 = rnd2.NextDouble() * double.MaxValue;

            double F = CL00_93_2_cth_sh.L00_93_2_cth_sh(arg, arg2);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_93_2_cth_sh_in()
        {
            string str = "(0, w) (0, w)";
            string F = CL00_93_2_cth_sh_in.L00_93_2_cth_sh_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_94_2_cth_sh
    {
        [TestMethod]
        public void Test_L00_94_2_cth_sh()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = rnd.NextDouble() * double.MaxValue;

            var rnd2 = new Random();
            var arg2 = rnd2.NextDouble() * double.MaxValue;

            double F = CL00_94_2_cth_sh.L00_94_2_cth_sh(arg, arg2);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_94_2_cth_sh_in()
        {
            string str = "(0, w) (0, w)";
            string F = CL00_94_2_cth_sh_in.L00_94_2_cth_sh_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_95_2_sh
    {
        [TestMethod]
        public void Test_L00_95_2_sh()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = (rnd.NextDouble() - 0.5) * double.MaxValue;

            var rnd2 = new Random();
            var arg2 = (rnd2.NextDouble() - 0.5) * double.MaxValue;

            double F = CL00_95_2_sh.L00_95_2_sh(arg, arg2);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_95_2_sh_in()
        {
            string str = "(w, w)";
            string F = CL00_95_2_sh_in.L00_95_2_sh_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_96_2_ch_sh
    {
        [TestMethod]
        public void Test_L00_96_2_ch_sh()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = (rnd.NextDouble() - 0.5) * double.MaxValue;

            var rnd2 = new Random();
            var arg2 = (rnd2.NextDouble() - 0.5) * double.MaxValue;

            double F = CL00_96_2_ch_sh.L00_96_2_ch_sh(arg, arg2);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_96_2_ch_in()
        {
            string str = "(w, w)";
            string F = CL00_96_2_ch_sh_in.L00_96_2_ch_sh_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_97_2_sh_ch
    {
        [TestMethod]
        public void Test_L00_97_2_sh_ch()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = (rnd.NextDouble() - 0.5) * double.MaxValue;

            var rnd2 = new Random();
            var arg2 = (rnd2.NextDouble() - 0.5) * double.MaxValue;

            double F = CL00_97_2_sh_ch.L00_97_2_sh_ch(arg, arg2);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_97_2_sh_ch_in()
        {
            string str = "(w, w)";
            string F = CL00_97_2_sh_ch_in.L00_97_2_sh_ch_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_98_2_sh_ch
    {
        [TestMethod]
        public void Test_L00_98_2_sh_ch()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = (rnd.NextDouble() - 0.5) * double.MaxValue;

            var rnd2 = new Random();
            var arg2 = (rnd2.NextDouble() - 0.5) * double.MaxValue;

            double F = CL00_98_2_sh_ch.L00_98_2_sh_ch(arg, arg2);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_98_2_sh_ch_in()
        {
            string str = "(w, w)";
            string F = CL00_98_2_sh_ch_in.L00_98_2_sh_ch_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_99_2_log
    {
        [TestMethod]
        public void Test_L00_99_2_log()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = rnd.NextDouble() * double.MaxValue;

            var rnd2 = new Random();
            var arg2 = rnd2.NextDouble() * double.MaxValue;

            double F = CL00_99_2_log.L00_99_2_log(arg, arg2);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_99_2_log_in()
        {
            string str = "(0, w)";
            string F = CL00_99_2_log_in.L00_99_2_log_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_100_3_log
    {
        [TestMethod]
        public void Test_L00_100_3_log()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = rnd.NextDouble() * double.MaxValue;

            var rnd2 = new Random();
            var arg2 = rnd2.NextDouble() * double.MaxValue;

            double F = CL00_100_3_log.L00_100_3_log(arg, arg2);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_100_3_log_in()
        {
            string str = "(0, w) (0, w)";
            string F = CL00_100_3_log_in.L00_100_3_log_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_101_3_log
    {
        [TestMethod]
        public void Test_L00_101_3_log()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = rnd.NextDouble() * double.MaxValue;

            var rnd2 = new Random();
            var arg2 = rnd2.NextDouble() * double.MaxValue;

            double F = CL00_101_3_log.L00_101_3_log(arg, arg2);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_101_3_log_in()
        {
            string str = "(0, w) (0, w)";
            string F = CL00_101_3_log_in.L00_101_3_log_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_102_3_log
    {
        [TestMethod]
        public void Test_L00_102_3_log()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = rnd.NextDouble() * double.MaxValue;

            double F = CL00_102_3_log.L00_102_3_log(arg);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_102_3_log_in()
        {
            string str = "(0, w)";
            string F = CL00_102_3_log_in.L00_102_3_log_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_103_3_log
    {
        [TestMethod]
        public void Test_L00_103_3_log()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = rnd.NextDouble() * double.MaxValue;

            double F = CL00_103_3_log.L00_103_3_log(arg);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_103_3_log_in()
        {
            string str = "(0, w)";
            string F = CL00_103_3_log_in.L00_103_3_log_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_104_1_ln_arsh
    {
        [TestMethod]
        public void Test_L00_104_1_ln_arsh()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = (rnd.NextDouble() - 0.5) * double.MaxValue;

            double F = CL00_104_1_ln_arsh.L00_104_1_ln_arsh(arg);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_104_1_ln_arsh_in()
        {
            string str = "(w, w)";
            string F = CL00_104_1_ln_arsh_in.L00_104_1_ln_arsh_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_105_1_ln_arch
    {
        [TestMethod]
        public void Test_L00_105_1_ln_arch()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = (rnd.NextDouble() * double.MaxValue) + 1;

            double F = CL00_105_1_ln_arch.L00_105_1_ln_arch(arg);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_105_1_ln_arch_in()
        {
            string str = "(1, w)";
            string F = CL00_105_1_ln_arch_in.L00_105_1_ln_arch_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_106_1_ln_arth
    {
        [TestMethod]
        public void Test_L00_106_1_ln_arth()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = (rnd.NextDouble()-0.5) * 2;

            double F = CL00_106_1_ln_arth.L00_106_1_ln_arth(arg);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_106_1_ln_arth_in()
        {
            string str = "(-1, 1)";
            string F = CL00_106_1_ln_arth_in.L00_106_1_ln_arth_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_107_2_pow_exp
    {
        [TestMethod]
        public void Test_L00_107_2_pow_exp()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = (rnd.NextDouble() - 0.5) * double.MaxValue;

            double F = CL00_107_2_pow_exp.L00_107_2_pow_exp(arg);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_107_2_pow_exp_in()
        {
            string str = "(w, w)";
            string F = CL00_107_2_pow_exp_in.L00_107_2_pow_exp_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_108_3_pow
    {
        [TestMethod]
        public void Test_L00_108_3_pow()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = (rnd.NextDouble() - 0.5) * double.MaxValue;

            var rnd2 = new Random();
            var arg2 = (rnd2.NextDouble() - 0.5) * double.MaxValue;

            double F = CL00_108_3_pow.L00_108_3_pow(arg, arg2);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_108_3_pow_in()
        {
            string str = "(w, w) (w, w)";
            string F = CL00_108_3_pow_in.L00_108_3_pow_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_109_3_pow
    {
        [TestMethod]
        public void Test_L00_109_3_pow()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = (rnd.NextDouble() - 0.5) * double.MaxValue;

            var rnd2 = new Random();
            var arg2 = (rnd2.NextDouble() - 0.5) * double.MaxValue;
            double F = CL00_109_3_pow.L00_109_3_pow(arg, arg2);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_109_3_pow_in()
        {
            string str = "(w, w) (w, w)";
            string F = CL00_109_3_pow_in.L00_109_3_pow_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_110_3_pow
    {
        [TestMethod]
        public void Test_L00_110_3_pow()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = (rnd.NextDouble() - 0.5) * double.MaxValue;

            var rnd2 = new Random();
            var arg2 = (rnd2.NextDouble() - 0.5) * double.MaxValue;
            double F = CL00_110_3_pow.L00_110_3_pow(arg, arg2);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_110_3_pow_in()
        {
            string str = "(w, w) (w, w)";
            string F = CL00_110_3_pow_in.L00_110_3_pow_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_111_1_exp_th
    {
        [TestMethod]
        public void Test_L00_111_1_exp_th()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = (rnd.NextDouble() - 0.5) * double.MaxValue;

            double F = CL00_111_1_exp_th.L00_111_1_exp_th(arg);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_111_1_exp_th_in()
        {
            string str = "(w, w)";
            string F = CL00_111_1_exp_th_in.L00_111_1_exp_th_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_112_1_exp_ch_sh
    {
        [TestMethod]
        public void Test_L00_112_1_exp_ch_sh()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = (rnd.NextDouble() * double.MaxValue) * 3;

            double F = CL00_112_1_exp_ch_sh.L00_112_1_exp_ch_sh(arg);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_112_1_exp_ch_sh_in()
        {
            string str = "(0, 2.1226) (2.1226, w)";
            string F = CL00_112_1_exp_ch_sh_in.L00_112_1_exp_ch_sh_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }

    [TestClass]
    public class CTest_L00_113_1_ch_sh_th
    {
        [TestMethod]
        public void Test_L00_113_1_ch_sh_th()
        {
            //выбрал собственный порог ошибки
            double treshold = 1e-14;
            var rnd = new Random();
            var arg = (rnd.NextDouble() * double.MaxValue) + 3;

            double F = CL00_113_1_ch_sh_th.L00_113_1_ch_sh_th(arg);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
        }

        [TestMethod]
        public void Test_L00_113_1_ch_sh_th_in()
        {
            string str = "(0, 2.1226) (2.1226, w)";
            string F = CL00_113_1_ch_sh_th_in.L00_113_1_ch_sh_th_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!");
        }
    }





    

    
}
