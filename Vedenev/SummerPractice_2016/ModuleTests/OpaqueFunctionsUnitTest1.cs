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
    public class Ctest_L00_58_1_arctg_arcctg
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_58_1_arctg_arcctg_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20000;
                t = CL00_58_1_arctg_arcctg.Body(x);
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
            Assert.IsTrue(CL00_58_1_arctg_arcctg_in.Body() == "(0, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_59_1_arctg_arccos
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_59_1_arctg_arccos_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20000;
                t = CL00_59_1_arctg_arccos.Body(x);
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
            Assert.IsTrue(CL00_59_1_arctg_arccos_in.Body() == "(0, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_60_1_arcctg_arccos
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_60_1_arcctg_arccos_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20000;
                t = CL00_60_1_arcctg_arccos.Body(x);
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
            Assert.IsTrue(CL00_60_1_arcctg_arccos_in.Body() == "(0, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_61_1_arcctg_arccos
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_61_1_arcctg_arccos_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20000 - 10000;
                t = CL00_61_1_arcctg_arccos.Body(x);
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
            Assert.IsTrue(CL00_61_1_arcctg_arccos_in.Body() == "(0, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_62_1_arctg_arcsin
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_62_1_arctg_arcsin_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20000;
                t = CL00_62_1_arcctg_arcsin.Body(x);
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
            Assert.IsTrue(CL00_62_1_arcctg_arcsin_in.Body() == "(0, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_63_1_cos
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_63_1_cos_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20000 - 10000;
                t = CL00_63_1_cos.Body(x);
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
            Assert.IsTrue(CL00_63_1_cos_in.Body() == "(w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_64_1_cos_sin
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_64_1_cos_sin_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20000 - 10000;
                t = CL00_64_1_cos_sin.Body(x);
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
            Assert.IsTrue(CL00_64_1_cos_sin_in.Body() == "(w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_65_1_tg
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_65_1_tg_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20000 - 10000;
                t = CL00_65_1_tg.Body(x);
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
            Assert.IsTrue(CL00_65_1_tg_in.Body() == "(w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_66_2_tg
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_66_2_tg_2()
        {
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20000 - 10000;
                y = random.NextDouble() * 20000 - 10000;
                t = CL00_66_2_tg.Body(x, y);
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
            Assert.IsTrue(CL00_66_2_tg_in.Body() == "(w, w) (w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_67_1_ch_sh
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_67_1_ch_sh_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20 - 10;
                t = CL00_67_1_ch_sh.Body(x);
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
            Assert.IsTrue(CL00_67_1_ch_sh_in.Body() == "(w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_68_1_th_sh_ch
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_68_1_th_sh_ch_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 200 - 100;
                t = CL00_68_1_th_sh_ch.Body(x);
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
            Assert.IsTrue(CL00_68_1_th_sh_ch_in.Body() == "(w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_69_1_cth_sh_ch
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_69_1_cth_sh_ch_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 200 - 100;
                t = CL00_69_1_cth_sh_ch.Body(x);
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
            Assert.IsTrue(CL00_69_1_cth_sh_ch_in.Body() == "(w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_70_1_sch_ch
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_70_1_sch_ch_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20000 - 10000;
                t = CL00_70_1_sch_ch.Body(x);
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
            Assert.IsTrue(CL00_70_1_sch_ch_in.Body() == "(w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_71_1_sch_ch
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_71_1_sch_ch_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20000 - 10000;
                t = CL00_71_1_sch_ch.Body(x);
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
            Assert.IsTrue(CL00_71_1_sch_ch_in.Body() == "(w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_72_2_sh_ch
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_72_2_sh_ch_2()
        {
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 2 - 1;
                y = random.NextDouble() * 2 - 1;
                t = CL00_72_2_sh_ch.Body(x, y);
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
            Assert.IsTrue(CL00_72_2_sh_ch_in.Body() == "(w, w) (w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_73_2_sh_ch
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_73_2_sh_ch_2()
        {
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 2 - 1;
                y = random.NextDouble() * 2 - 1;
                t = CL00_73_2_sh_ch.Body(x, y);
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
            Assert.IsTrue(CL00_73_2_sh_ch_in.Body() == "(w, w) (w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_74_2_sh_ch
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_74_2_sh_ch_2()
        {
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20 - 10;
                y = random.NextDouble() * 20 - 10;
                t = CL00_74_2_sh_ch.Body(x, y);
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
            Assert.IsTrue(CL00_74_2_sh_ch_in.Body() == "(w, w) (w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_75_2_sh_ch
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_75_2_sh_ch_2()
        {
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20 - 10;
                y = random.NextDouble() * 20 - 10;
                t = CL00_75_2_sh_ch.Body(x, y);
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
            Assert.IsTrue(CL00_75_2_sh_ch_in.Body() == "(w, w) (w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_76_2_th
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_76_2_th_2()
        {
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20 - 10;
                y = random.NextDouble() * 20 - 10;
                t = CL00_76_2_th.Body(x, y);
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
            Assert.IsTrue(CL00_76_2_th_in.Body() == "(w, w) (w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_77_2_th
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_77_2_th_2()
        {
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20 - 10;
                y = random.NextDouble() * 20 - 10;
                t = CL00_77_2_th.Body(x, y);
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
            Assert.IsTrue(CL00_77_2_th_in.Body() == "(w, w) (w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_78_2_cth 
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_78_2_cth_2()
        {
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20 - 10;
                y = random.NextDouble() * 20 - 10;
                t = CL00_78_2_cth.Body(x, y);
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
            Assert.IsTrue(CL00_78_2_cth_in.Body() == "(w, w) (w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_79_2_cth
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_79_2_cth_2()
        {
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20 - 10;
                y = random.NextDouble() * 20 - 10;
                t = CL00_79_2_cth.Body(x, y);
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
            Assert.IsTrue(CL00_79_2_cth_in.Body() == "(w, w) (w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_80_2_sh_ch
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_80_2_sh_ch_2()
        {
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20 - 10;
                y = random.NextDouble() * 20 - 10;
                t = CL00_80_2_sh_ch.Body(x, y);
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
            Assert.IsTrue(CL00_80_2_sh_ch_in.Body() == "(w, w) (w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_81_2_sh_ch
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_81_2_sh_ch_2()
        {
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20 - 10;
                y = random.NextDouble() * 20 - 10;
                t = CL00_81_2_sh_ch.Body(x, y);
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
            Assert.IsTrue(CL00_81_2_sh_ch_in.Body() == "(w, w) (w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_82_2_sh_ch
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_82_2_sh_ch_2()
        {
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20 - 10;
                y = random.NextDouble() * 20 - 10;
                t = CL00_82_2_sh_ch.Body(x, y);
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
            Assert.IsTrue(CL00_82_2_sh_ch_in.Body() == "(w, w) (w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_83_1_sh_ch
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_83_1_sh_ch_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20 - 10;
                t = CL00_83_1_sh_ch.Body(x);
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
            Assert.IsTrue(CL00_83_1_sh_ch_in.Body() == "(w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_84_1_cth
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_84_1_cth_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20000 - 10000;
                t = CL00_84_1_cth.Body(x);
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
            Assert.IsTrue(CL00_84_1_cth_in.Body() == "(w, w)", "Интервалы не совпадают");
        }

    }


    [TestClass]
    public class Ctest_L00_85_1_sh_ch
    {
        double persicion = 0.00000001;
        [TestMethod]
        public void test_L00_85_1_sh_ch_2()
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 20 - 10;
                t = CL00_85_1_sh_ch.Body(x);
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
            Assert.IsTrue(CL00_85_1_sh_ch_in.Body() == "(w, w)", "Интервалы не совпадают");
        }

    }

    
}
