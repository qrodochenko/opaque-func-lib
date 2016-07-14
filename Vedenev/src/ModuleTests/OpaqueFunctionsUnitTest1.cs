using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpaqueFunctions;

namespace ModuleTests
{
    [TestClass]
    public class Ctest_L00_58_1_arctg_arcctg
    {
        double persicion = 1E-8;
        [TestMethod]
        public void test_L00_58_1_arctg_arcctg_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20000;
                t = CL00_58_1_arctg_arcctg.L00_58_1_arctg_arcctg(x);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            mid = mid / 10;
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_58_1_arctg_arcctg_2_in()
        {
            Assert.IsTrue(CL00_58_1_arctg_arcctg_in.L00_58_1_arctg_arcctg_in() == "(0, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_59_1_arctg_arccos
    {
        double persicion = 1E-8;
        [TestMethod]
        public void test_L00_59_1_arctg_arccos_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20000;
                t = CL00_59_1_arctg_arccos.L00_59_1_arctg_arccos(x);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            mid = mid / 10;
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_59_1_arctg_arccos_2_in()
        {
            Assert.IsTrue(CL00_59_1_arctg_arccos_in.L00_59_1_arctg_arccos_in() == "(0, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_60_1_arcctg_arccos
    {
        double persicion = 1E-8;
        [TestMethod]
        public void test_L00_60_1_arcctg_arccos_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20000;
                t = CL00_60_1_arcctg_arccos.L00_60_1_arcctg_arccos(x);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            mid = mid / 10;
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_60_1_arcctg_arccos_2_in()
        {
            Assert.IsTrue(CL00_60_1_arcctg_arccos_in.L00_60_1_arcctg_arccos_in() == "(0, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_61_1_arcctg_arccos
    {
        double persicion = 1E-8;
        [TestMethod]
        public void test_L00_61_1_arcctg_arccos_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20000 - 10000;
                t = CL00_61_1_arcctg_arccos.L00_61_1_arcctg_arccos(x);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            mid = mid / 10;
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_61_1_arcctg_arccos_2_in()
        {
            Assert.IsTrue(CL00_61_1_arcctg_arccos_in.L00_61_1_arcctg_arccos_in() == "(0, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_62_1_arctg_arcsin
    {
        double persicion = 1E-8;
        [TestMethod]
        public void test_L00_62_1_arctg_arcsin_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20000;
                t = CL00_62_1_arcctg_arcsin.L00_62_1_arcctg_arcsin(x);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            mid = mid / 10;
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_62_1_arctg_arcsin_2_in()
        {
            Assert.IsTrue(CL00_62_1_arcctg_arcsin_in.L00_62_1_arcctg_arcsin_in() == "(0, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_63_1_cos
    {
        double persicion = 1E-8;
        [TestMethod]
        public void test_L00_63_1_cos_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20000 - 10000;
                t = CL00_63_1_cos.L00_63_1_cos(x);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            mid = mid / 10;
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_63_1_cos_2_in()
        {
            Assert.IsTrue(CL00_63_1_cos_in.L00_63_1_cos_in() == "(w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_64_1_cos_sin
    {
        double persicion = 1E-8;
        [TestMethod]
        public void test_L00_64_1_cos_sin_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20000 - 10000;
                t = CL00_64_1_cos_sin.L00_64_1_cos_sin(x);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            mid = mid / 10;
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_64_1_cos_sin_2_in()
        {
            Assert.IsTrue(CL00_64_1_cos_sin_in.L00_64_1_cos_sin_in() == "(w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_65_1_tg
    {
        double persicion = 1E-8;
        [TestMethod]
        public void test_L00_65_1_tg_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20000 - 10000;
                t = CL00_65_1_tg.L00_65_1_tg(x);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            mid = mid / 10;
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_65_1_tg_2_in()
        {
            Assert.IsTrue(CL00_65_1_tg_in.L00_65_1_tg_in() == "(w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_66_2_tg
    {
        double persicion = 1E-7;
        [TestMethod]
        public void test_L00_66_2_tg_2()
        {
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20000 - 10000;
                y = random.NextDouble() * 20000 - 10000;
                t = CL00_66_2_tg.L00_66_2_tg(x, y);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_66_2_tg_2_in()
        {
            Assert.IsTrue(CL00_66_2_tg_in.L00_66_2_tg_in() == "(w, w) (w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_67_1_ch_sh
    {
        double persicion = 1E-7;
        [TestMethod]
        public void test_L00_67_1_ch_sh_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20 - 10;
                t = CL00_67_1_ch_sh.L00_67_1_ch_sh(x);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            mid = mid / 10;
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_67_1_ch_sh_2_in()
        {
            Assert.IsTrue(CL00_67_1_ch_sh_in.L00_67_1_ch_sh_in() == "(w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_68_1_th_sh_ch
    {
        double persicion = 1E-8;
        [TestMethod]
        public void test_L00_68_1_th_sh_ch_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 200 - 100;
                t = CL00_68_1_th_sh_ch.L00_68_1_th_sh_ch(x);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            mid = mid / 10;
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_68_1_th_sh_ch_2_in()
        {
            Assert.IsTrue(CL00_68_1_th_sh_ch_in.L00_68_1_th_sh_ch_in() == "(w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_69_1_cth_sh_ch
    {
        double persicion = 1E-8;
        [TestMethod]
        public void test_L00_69_1_cth_sh_ch_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 200 - 100;
                t = CL00_69_1_cth_sh_ch.L00_69_1_cth_sh_ch(x);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            mid = mid / 10;
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_69_1_cth_sh_ch_2_in()
        {
            Assert.IsTrue(CL00_69_1_cth_sh_ch_in.L00_69_1_cth_sh_ch_in() == "(w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_70_1_sch_ch
    {
        double persicion = 1E-8;
        [TestMethod]
        public void test_L00_70_1_sch_ch_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20000 - 10000;
                t = CL00_70_1_sch_ch.L00_70_1_sch_ch(x);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            mid = mid / 10;
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_70_1_sch_ch_2_in()
        {
            Assert.IsTrue(CL00_70_1_sch_ch_in.L00_70_1_sch_ch_in() == "(w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_71_1_sch_ch
    {
        double persicion = 1E-8;
        [TestMethod]
        public void test_L00_71_1_sch_ch_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20000 - 10000;
                t = CL00_71_1_sch_ch.L00_71_1_sch_ch(x);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            mid = mid / 10;
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_71_1_sch_ch_2_in()
        {
            Assert.IsTrue(CL00_71_1_sch_ch_in.L00_71_1_sch_ch_in() == "(w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_72_2_sh_ch
    {
        double persicion = 1E-8;
        [TestMethod]
        public void test_L00_72_2_sh_ch_2()
        {
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 2 - 1;
                y = random.NextDouble() * 2 - 1;
                t = CL00_72_2_sh_ch.L00_72_2_sh_ch(x, y);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_72_2_sh_ch_2_in()
        {
            Assert.IsTrue(CL00_72_2_sh_ch_in.L00_72_2_sh_ch_in() == "(w, w) (w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_73_2_sh_ch
    {
        double persicion = 1E-8;
        [TestMethod]
        public void test_L00_73_2_sh_ch_2()
        {
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 2 - 1;
                y = random.NextDouble() * 2 - 1;
                t = CL00_73_2_sh_ch.L00_73_2_sh_ch(x, y);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_73_2_sh_ch_2_in()
        {
            Assert.IsTrue(CL00_73_2_sh_ch_in.L00_73_2_sh_ch_in() == "(w, w) (w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_74_2_sh_ch
    {
        double persicion = 1E-8;
        [TestMethod]
        public void test_L00_74_2_sh_ch_2()
        {
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 2 - 1;
                y = random.NextDouble() * 2 - 1;
                t = CL00_74_2_sh_ch.L00_74_2_sh_ch(x, y);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_74_2_sh_ch_2_in()
        {
            Assert.IsTrue(CL00_74_2_sh_ch_in.L00_74_2_sh_ch_in() == "(w, w) (w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_75_2_sh_ch
    {
        double persicion = 1E-7;
        [TestMethod]
        public void test_L00_75_2_sh_ch_2()
        {
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20 - 10;
                y = random.NextDouble() * 20 - 10;
                t = CL00_75_2_sh_ch.L00_75_2_sh_ch(x, y);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_75_2_sh_ch_2_in()
        {
            Assert.IsTrue(CL00_75_2_sh_ch_in.L00_75_2_sh_ch_in() == "(w, w) (w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_76_2_th
    {
        double persicion = 1E-8;
        [TestMethod]
        public void test_L00_76_2_th_2()
        {
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20 - 10;
                y = random.NextDouble() * 20 - 10;
                t = CL00_76_2_th.L00_76_2_th(x, y);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_76_2_th_2_in()
        {
            Assert.IsTrue(CL00_76_2_th_in.L00_76_2_th_in() == "(w, w) (w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_77_2_th
    {
        double persicion = 1E-8;
        [TestMethod]
        public void test_L00_77_2_th_2()
        {
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20 - 10;
                y = random.NextDouble() * 20 - 10;
                t = CL00_77_2_th.L00_77_2_th(x, y);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_77_2_th_2_in()
        {
            Assert.IsTrue(CL00_77_2_th_in.L00_77_2_th_in() == "(w, w) (w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_78_2_cth 
    {
        double persicion = 1E-6;
        [TestMethod]
        public void test_L00_78_2_cth_2()
        {
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20 - 10;
                y = random.NextDouble() * 20 - 10;
                t = CL00_78_2_cth.L00_78_2_cth(x, y);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_78_2_cth_2_in()
        {
            Assert.IsTrue(CL00_78_2_cth_in.L00_78_2_cth_in() == "(w, w) (w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_79_2_cth
    {
        double persicion = 1E-6;
        [TestMethod]
        public void test_L00_79_2_cth_2()
        {
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20 - 10;
                y = random.NextDouble() * 20 - 10;
                t = CL00_79_2_cth.L00_79_2_cth(x, y);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_79_2_cth_2_in()
        {
            Assert.IsTrue(CL00_79_2_cth_in.L00_79_2_cth_in() == "(w, w) (w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_80_2_sh_ch
    {
        double persicion = 1E-8;
        [TestMethod]
        public void test_L00_80_2_sh_ch_2()
        {
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 2 - 1;
                y = random.NextDouble() * 2 - 1;
                t = CL00_80_2_sh_ch.L00_80_2_sh_ch(x, y);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_80_2_sh_ch_2_in()
        {
            Assert.IsTrue(CL00_80_2_sh_ch_in.L00_80_2_sh_ch_in() == "(w, w) (w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_81_2_sh_ch
    {
        double persicion = 1E-8;
        [TestMethod]
        public void test_L00_81_2_sh_ch_2()
        {
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 2 - 1;
                y = random.NextDouble() * 2 - 1;
                t = CL00_81_2_sh_ch.L00_81_2_sh_ch(x, y);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_81_2_sh_ch_2_in()
        {
            Assert.IsTrue(CL00_81_2_sh_ch_in.L00_81_2_sh_ch_in() == "(w, w) (w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_82_2_sh_ch
    {
        double persicion = 1E-6;
        [TestMethod]
        public void test_L00_82_2_sh_ch_2()
        {
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20 - 10;
                y = random.NextDouble() * 20 - 10;
                t = CL00_82_2_sh_ch.L00_82_2_sh_ch(x, y);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_82_2_sh_ch_2_in()
        {
            Assert.IsTrue(CL00_82_2_sh_ch_in.L00_82_2_sh_ch_in() == "(w, w) (w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_83_1_sh_ch
    {
        double persicion = 1E-7;
        [TestMethod]
        public void test_L00_83_1_sh_ch_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20 - 10;
                t = CL00_83_1_sh_ch.L00_83_1_sh_ch(x);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            mid = mid / 10;
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_83_1_sh_ch_2_in()
        {
            Assert.IsTrue(CL00_83_1_sh_ch_in.L00_83_1_sh_ch_in() == "(w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_84_1_cth
    {
        double persicion = 1E-8;
        [TestMethod]
        public void test_L00_84_1_cth_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20000 - 10000;
                t = CL00_84_1_cth.L00_84_1_cth(x);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            mid = mid / 10;
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_84_1_cth_2_in()
        {
            Assert.IsTrue(CL00_84_1_cth_in.L00_84_1_cth_in() == "(w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_85_1_sh_ch
    {
        double persicion = 1E-7;
        [TestMethod]
        public void test_L00_85_1_sh_ch_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20 - 10;
                t = CL00_85_1_sh_ch.L00_85_1_sh_ch(x);
                mid += t;
                if (t > mx)
                    mx = t;
            }
            mid = mid / 10;
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" + mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" + mid.ToString());
        }

        [TestMethod]
        public void test_L00_85_1_sh_ch_2_in()
        {
            Assert.IsTrue(CL00_85_1_sh_ch_in.L00_85_1_sh_ch_in() == "(w, w)", "Интервалы не совпадают");
        }

    }

    
}
