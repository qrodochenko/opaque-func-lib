using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpaqueFunctions;

namespace ModuleTests
{
    [TestClass]
    public class Ctest_Math_1_2
    {
        [TestMethod]
        public void test_Math_1_2()
        {            
            for (int i = -84; i < 87; i++)
            {
                double x = i * 0.01;
                double Eps = 1e-10;
                double F = CMath_1_2.Math_1_2(x, 100);
                double benchmark = Math.Pow(1 + x, (1.0 / 3.0));
                double error = Math.Abs(F - benchmark);                
                Assert.IsTrue((error < Eps), "Погрешность больше нужной!");                
            }
            
        }

        [TestMethod]
        public void test_Math_1_2_in()
        {
            string F = CMath_1_2_in.Math_1_2_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }

    }

    [TestClass]
    public class Ctest_Math_2_2
    {
        [TestMethod]
        public void test_Math_2_2()
        {
            for (int i = -86; i < 84; i++)
            {
                double x = i * 0.01;
                double Eps = 0.0000000001;
                double F = CMath_2_2.Math_2_2(x, 100);                
                double benchmark = Math.Pow(1 - x, (1.0 / 3.0));
                double error = Math.Abs(F - benchmark);
                Assert.IsTrue((error < Eps), "Погрешность больше нужной!");
            }

        }
        [TestMethod]
        public void test_Math_2_2_in()
        {
            string F = CMath_2_2_in.Math_2_2_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }




    };

    [TestClass]
    public class Ctest_Math_3_2
    {
        [TestMethod]
        public void test_Math_3_2()
        {
            for (int i = -84; i < 87; i++)
            {
                double x = i * 0.01;
                double Eps = 0.0000000001;
                double F = CMath_3_2.Math_3_2(x, 100);                
                double benchmark = Math.Pow(1 + x, (1.0 / 2.0));
                double error = Math.Abs(F - benchmark);
                Assert.IsTrue((error < Eps), "Погрешность больше нужной!");                       
            }

        }

        [TestMethod]
        public void test_Math_3_2_in()
        {
            string F = CMath_3_2_in.Math_3_2_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }

    };


    [TestClass]
    public class Ctest_Math_4_2
    {
        [TestMethod]
        public void test_Math_4_2()
        {
            for (int i = -86; i < 85; i++)
            {
                double x = i * 0.01;
                double Eps = 0.0000000001;
                double F = CMath_4_2.Math_4_2(x, 100);
                Assert.IsTrue(Math.Abs(F - Math.Pow(1 - x, 1.0 / 2.0)) < Eps, "Погрешность больше нужной!");
            }

        }

        [TestMethod]
        public void test_Math_4_2_in()
        {
            string F = CMath_4_2_in.Math_4_2_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }

    };

    [TestClass]
    public class Ctest_Math_5_2
    {
        [TestMethod]
        public void test_Math_5_2()
        {
            for (int i = -84; i < 87; i++)
            {
                double x = i * 0.01;
                double Eps = 0.0000000001;
                double F = CMath_5_2.Math_5_2(x, 100);
                double benchmark = Math.Pow(1 + x, (1.0 / 4.0));
                double error = Math.Abs(F - benchmark);
                Assert.IsTrue((error < Eps), "Погрешность больше нужной!");       
            }

        }

        [TestMethod]
        public void test_Math_5_2_in()
        {
            string F = CMath_5_2_in.Math_5_2_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }

    };

    [TestClass]
    public class Ctest_Math_6_2
    {
        [TestMethod]
        public void test_Math_6_2()
        {
            for (int i = -86; i < 84; i++)
            {
                double x = i * 0.01;
                double Eps = 0.0000000001;
                double F = CMath_6_2.Math_6_2(x, 100);
                double benchmark = Math.Pow((1 - x), (1.0 / 4.0));
                double error = Math.Abs(F - benchmark);
                Assert.IsTrue((error < Eps), "Погрешность больше нужной!");                
            }

        }
        [TestMethod]
        public void test_Math_6_2_in()
        {
            string F = CMath_6_2_in.Math_6_2_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }

    };

    [TestClass]
    public class Ctest_Math_7_2
    {
        [TestMethod]
        public void test_Math_7_2()
        {
            for (int i = -78; i < 81; i++)
            {
                double x = i * 0.01;
                double Eps = 0.0000000001;
                double F = CMath_7_2.Math_7_2(x, 100000);
                double benchmark = Math.Pow(1 + x, -1);
                double error = Math.Abs(F-benchmark);                
                Assert.IsTrue((error < Eps), "Погрешность больше нужной!");
            }

        }


        public void test_Math_7_2_in()
        {
            string F = CMath_7_2_in.Math_7_2_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }

    };

    [TestClass]
    public class Ctest_Math_8_2
    {
        [TestMethod]
        public void test_Math_8_2()
        {
            for (int i = -80; i < 79; i++)
            {
                double x = i * 0.01;
                double Eps = 0.0000000001;
                double F = CMath_8_2.Math_8_2(x, 100);
                double benchmark = Math.Pow(1 - x, -1);
                double error = Math.Abs(F - benchmark);
                Assert.IsTrue((error < Eps), "Погрешность больше нужной!");                
            }

        }
        [TestMethod]
        public void test_Math_8_2_in()
        {
            string F = CMath_8_2_in.Math_8_2_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }

    };

    [TestClass]
    public class Ctest_Math_9_2
    {
        [TestMethod]
        public void test_Math_9_2()
        {
            for (int i = -74; i < 77; i++)
            {
                double x = i * 0.01;
                double Eps = 0.0000000001;
                double F = CMath_9_2.Math_9_2(x, 100);
                double benchmark = Math.Pow(1 + x, -2);
                double error = Math.Abs(F - benchmark);                
                Assert.IsTrue((error < Eps), "Погрешность больше нужной!");                
            }

        }
        [TestMethod]
        public void test_Math_9_2_in()
        {
            string F = CMath_9_2_in.Math_9_2_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }

    };

    [TestClass]
    public class Ctest_Math_10_2
    {
        [TestMethod]
        public void test_Math_10_2()
        {
            for (int i = -76; i < 75; i++)
            {
                double x = i * 0.01;
                double Eps = 0.0000000001;
                double F = CMath_10_2.Math_10_2(x, 100);
                double benchmark = Math.Pow(1 - x, -2);
                double error = Math.Abs(F - benchmark);                
                Assert.IsTrue((error < Eps), "Погрешность больше нужной!");                                
            }

        }
        [TestMethod]
        public void test_Math_10_2_in()
        {
            string F = CMath_10_2_in.Math_10_2_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }

    };

    [TestClass]
    public class Ctest_Math_11_2
    {
        [TestMethod]
        public void test_Math_11_2()
        {
            for (int i = -72; i < 74; i++)
            {
                double x = i * 0.01;
                double Eps = 0.0000000001;
                double F = CMath_11_2.Math_11_2(x, 100);
                double benchmark = Math.Pow(1 + x, -3);
                double error = Math.Abs(F - benchmark);                
                Assert.IsTrue((error < Eps), "Погрешность больше нужной!");                
            }

        }
        [TestMethod]
        public void test_Math_11_2_in()
        {
            string F = CMath_11_2_in.Math_11_2_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }

    };

    [TestClass]
    public class Ctest_Math_12_2
    {
        [TestMethod]
        public void test_Math_12_2()
        {
            for (int i = -73; i < 73; i++)
            {
                double x = i * 0.01;
                double Eps = 0.0000000001;
                double F = CMath_12_2.Math_12_2(x, 100);
                double benchmark = Math.Pow(1 - x, -3);
                double error = Math.Abs(F - benchmark);                
                Assert.IsTrue((error < Eps), "Погрешность больше нужной!");
            }

        }
        [TestMethod]
        public void test_Math_12_2_in()
        {
            string F = CMath_12_2_in.Math_12_2_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }

    };

    [TestClass]
    public class Ctest_Math_13_2
    {
        [TestMethod]
        public void test_Math_13_2()
        {
            for (int i = -69; i < 71; i++)
            {
                double x = i * 0.01;
                double Eps = 0.0000000001;
                double F = CMath_13_2.Math_13_2(x, 100);
                double benchmark = Math.Pow(1 + x, -4);
                double error = Math.Abs(F - benchmark);                
                Assert.IsTrue((error < Eps), "Погрешность больше нужной!");
            }

        }
        [TestMethod]
        public void test_Math_13_2_in()
        {
            string F = CMath_13_2_in.Math_13_2_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }

    };

    [TestClass]
    public class Ctest_Math_14_2
    {
        [TestMethod]
        public void test_Math_14_2()
        {
            for (int i = -70; i < 70; i++)
            {
                double x = i * 0.01;
                double Eps = 0.0000000001;
                double F = CMath_14_2.Math_14_2(x, 100);
                double benchmark = Math.Pow(1 - x, -4);
                double error = Math.Abs(F - benchmark);                
                Assert.IsTrue((error < Eps), "Погрешность больше нужной!");
            }

        }
        [TestMethod]
        public void test_Math_14_2_in()
        {
            string F = CMath_14_2_in.Math_14_2_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }

    };

    [TestClass]
    public class Ctest_Math_15_2
    {
        [TestMethod]
        public void test_Math_15_2()
        {
            for (int i = -80; i < 83; i++)
            {
                double x = i * 0.01;
                double Eps = 0.0000000001;
                double F = CMath_15_2.Math_15_2(x, 100);
                double benchmark = Math.Pow(1 + x, -1.0/2.0);
                double error = Math.Abs(F - benchmark);                
                Assert.IsTrue((error < Eps), "Погрешность больше нужной!");
            }

        }
        [TestMethod]
        public void test_Math_15_2_in()
        {
            string F = CMath_15_2_in.Math_15_2_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }

    };

    [TestClass]
    public class Ctest_Math_16_2
    {
        [TestMethod]
        public void test_Math_16_2()
        {
            for (int i = -82; i < 81; i++)
            {
                double x = i * 0.01;
                double Eps = 0.0000000001;
                double F = CMath_16_2.Math_16_2(x, 100);
                double benchmark = Math.Pow(1 - x, -1.0 / 2.0);
                double error = Math.Abs(F - benchmark);                
                Assert.IsTrue((error < Eps), "Погрешность больше нужной!");
            }

        }
        [TestMethod]
        public void test_Math_16_2_in()
        {
            string F = CMath_16_2_in.Math_16_2_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }

    };

    [TestClass]
    public class Ctest_Math_17_2
    {
        [TestMethod]
        public void test_Math_17_2()
        {
            for (int i = -81; i < 84; i++)
            {
                double x = i * 0.01;
                double Eps = 0.0000000001;
                double F = CMath_17_2.Math_17_2(x, 100);
                double benchmark = Math.Pow(1 + x, -1.0 / 3.0);
                double error = Math.Abs(F - benchmark);                
                Assert.IsTrue((error < Eps), "Погрешность больше нужной!");
            }

        }
        [TestMethod]
        public void test_Math_17_2_in()
        {
            string F = CMath_17_2_in.Math_17_2_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }

    };

    [TestClass]
    public class Ctest_Math_18_2
    {
        [TestMethod]
        public void test_Math_18_2()
        {
            for (int i = -83; i < 82; i++)
            {
                double x = i * 0.01;
                double Eps = 0.0000000001;
                double F = CMath_18_2.Math_18_2(x, 100);
                double benchmark = Math.Pow(1 - x, -1.0 / 3.0);
                double error = Math.Abs(F - benchmark);                
                Assert.IsTrue((error < Eps), "Погрешность больше нужной!");
            }

        }
        [TestMethod]
        public void test_Math_18_2_in()
        {
            string F = CMath_18_2_in.Math_18_2_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }

    };

    [TestClass]
    public class Ctest_Math_19_2
    {
        [TestMethod]
        public void test_Math_19_2()
        {
            for (int i = -82; i < 84; i++)
            {
                double x = i * 0.01;
                double Eps = 0.0000000001;                
                double F = CMath_19_2.Math_19_2(x, 100);
                double benchmark = Math.Pow(1 + x, -1.0 / 4.0);
                double error = Math.Abs(F - benchmark);                
                Assert.IsTrue((error < Eps), "Погрешность больше нужной!");
            }

        }
        [TestMethod]
        public void test_Math_19_2_in()
        {
            string F = CMath_19_2_in.Math_19_2_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }

    };

    [TestClass]
    public class Ctest_Math_20_2
    {
        [TestMethod]
        public void test_Math_20_2()
        {
            for (int i = -83; i < 83; i++)
            {
                double x = i * 0.01;
                double Eps = 0.0000000001;
                double F = CMath_20_2.Math_20_2(x, 100);
                double benchmark = Math.Pow(1 - x, -1.0 / 4.0);
                double error = Math.Abs(F - benchmark);                
                Assert.IsTrue((error < Eps), "Погрешность больше нужной!");
            }

        }
        [TestMethod]
        public void test_Math_20_2_in()
        {
            string F = CMath_20_2_in.Math_20_2_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают!");
        }

    };

}
