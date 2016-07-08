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
    public class Ctest_LOX_1_1
    {
        double treshold = 0.0000000000001;
        
        [TestMethod]
        public void test_LOX_1_1()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_1_1.LOX_1_1(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }
            
        }

        [TestMethod]
        public void test_LOX_1_1_in()
        {
            string F = CLOX_1_1_in.LOX_1_1_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_2_1
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_2_1()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_2_1.LOX_2_1(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_2_1_in()
        {
            string F = CLOX_2_1_in.LOX_2_1_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_3_1
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_3_1()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_3_1.LOX_3_1(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_3_1_in()
        {
            string F = CLOX_3_1_in.LOX_3_1_in();
            string s = "(-Pi/2, Pi/2)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_4_1
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_4_1()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_4_1.LOX_4_1(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_4_1_in()
        {
            string F = CLOX_4_1_in.LOX_4_1_in();
            string s = "(-Pi/2, Pi/2)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_5_1
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_5_1()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_5_1.LOX_5_1(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_5_1_in()
        {
            string F = CLOX_5_1_in.LOX_5_1_in();
            string s = "(-Pi/2, Pi/2)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_6_1
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_6_1()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_6_1.LOX_6_1(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_6_1_in()
        {
            string F = CLOX_6_1_in.LOX_6_1_in();
            string s = "(0, Pi)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_7_1
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_7_1()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_7_1.LOX_7_1(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_7_1_in()
        {
            string F = CLOX_7_1_in.LOX_7_1_in();
            string s = "(-Pi/2, Pi/2)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_8_1
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_8_1()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_8_1.LOX_8_1(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_8_1_in()
        {
            string F = CLOX_8_1_in.LOX_8_1_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_9_2
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_9_2()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_9_2.LOX_9_2(param, 2);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
                Console.WriteLine(F);
            }

        }

        [TestMethod]
        public void test_LOX_9_2_in()
        {
            string F = CLOX_9_2_in.LOX_9_2_in();
            string s = "(0, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_10_2
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_10_2()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_10_2.LOX_10_2(param, 5);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_10_2_in()
        {
            string F = CLOX_10_2_in.LOX_10_2_in();
            string s = "(0, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_11_2
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_11_2()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_11_2.LOX_11_2(param, 5);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_11_2_in()
        {
            string F = CLOX_11_2_in.LOX_11_2_in();
            string s = "(w, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_12_2
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_12_2()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_12_2.LOX_12_2(param, 5);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_12_2_in()
        {
            string F = CLOX_12_2_in.LOX_12_2_in();
            string s = "(0, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_13_1
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_13_1()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_13_1.LOX_13_1(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_13_1_in()
        {
            string F = CLOX_13_1_in.LOX_13_1_in();
            string s = "(w, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_14_1
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_14_1()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_14_1.LOX_14_1(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_14_1_in()
        {
            string F = CLOX_14_1_in.LOX_14_1_in();
            string s = "(w, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_15_1
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_15_1()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_15_1.LOX_15_1(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_15_1_in()
        {
            string F = CLOX_15_1_in.LOX_15_1_in();
            string s = "(w, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_16_1
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_16_1()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_16_1.LOX_16_1(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_16_1_in()
        {
            string F = CLOX_16_1_in.LOX_16_1_in();
            string s = "(w, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_17_1
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_17_1()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = 1 + random.NextDouble();
                double F = CLOX_17_1.LOX_17_1(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, String.Format("Значение функции в точке {0} с индексом {1} не x!", param, i));
            }

        }

        [TestMethod]
        public void test_LOX_17_1_in()
        {
            string F = CLOX_17_1_in.LOX_17_1_in();
            string s = "(1, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_18_1
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_18_1()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_18_1.LOX_18_1(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_18_1_in()
        {
            string F = CLOX_18_1_in.LOX_18_1_in();
            string s = "(0, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_19_1
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_19_1()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_19_1.LOX_19_1(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_19_1_in()
        {
            string F = CLOX_19_1_in.LOX_19_1_in();
            string s = "(-1, 1)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }



    [TestClass]
    public class Ctest_LOX_20_1
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_20_1()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_20_1.LOX_20_1(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_20_1_in()
        {
            string F = CLOX_20_1_in.LOX_20_1_in();
            string s = "(1, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }


    [TestClass]
    public class Ctest_LOX_21_1
    {
        double treshold = 0.00001;

        [TestMethod]
        public void test_LOX_21_1()
        {
            Random random = new Random();
            double param = random.NextDouble(); /// нужно растягивающее отображение со сдвигом, чтобы интервал (0, 1) перевести в (1, w)
            for (int i = 1; i <= 10; i++)
            {
                param = 1 + random.NextDouble();
                double F = CLOX_21_1.LOX_21_1(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }
          
        }

        [TestMethod]
        public void test_LOX_21_1_in()
        {
            string F = CLOX_21_1_in.LOX_21_1_in();
            string s = "(1, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }




    [TestClass]
    public class Ctest_LOX_22_1
    {
        double treshold = 0.0000000000001;

        [TestMethod]
        public void test_LOX_22_1()
        {
            Random random = new Random();
            double param = random.NextDouble();
            for (int i = 1; i <= 10; i++)
            {
                param = random.NextDouble();
                double F = CLOX_22_1.LOX_22_1(param);
                Assert.IsTrue(Math.Abs(F - param) < treshold, "Значение функции не x!");
            }

        }

        [TestMethod]
        public void test_LOX_22_1_in()
        {
            string F = CLOX_22_1_in.LOX_22_1_in();
            string s = "(0, w)";
            Assert.IsTrue((F == s), "Интервалы не совпадают");

        }
    }
}
