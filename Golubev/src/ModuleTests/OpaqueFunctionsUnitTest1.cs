using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpaqueFunctions;

namespace ModuleTests
{

    [TestClass]
    public class OpaqueFunctionsUnitTest1
    {
        [TestMethod]
        public void OpaquePriv_Sin_2_Test()
        {

            for (int i = 0; i < 10; i++)
            {
                Random x = new Random();
                double arg = x.NextDouble() * 20000 - 10000;
                OpaqueFunctions.C_build_func func = OpaqueFunctions.Cpriv_sin_2.priv_sin_2(arg);
             
                if (string.Compare(func.sign, "+") == 0)
                     Assert.IsTrue(Math.Abs(Math.Sin(arg) - Math.Sin(func.argument)) < 1e-8, "Значения функций не равны!");
                else
                    Assert.IsTrue(Math.Abs(Math.Sin(arg) + Math.Sin(func.argument)) < 1e-8, "Значения функций не равны!");
               
                Assert.IsTrue(Math.Abs(func.argument) <= Math.PI / 2, "Значение функции не попадает в интервал!");
            }

        }
    }

    [TestClass]
    public class OpaqueFunctionsUnitTest2
    {
        [TestMethod]
        public void OpaquePriv_Cos_2_Test()
        {

            for (int i = 0; i < 10; i++)
            {
                Random x = new Random();
                double arg = x.NextDouble() * 20000 - 10000;
                OpaqueFunctions.C_build_func func = OpaqueFunctions.Cpriv_cos_2.priv_cos_2(arg);

                if (string.Compare(func.sign, "+") == 0)
                    Assert.IsTrue(Math.Abs(Math.Cos(arg) - Math.Cos(func.argument)) < 1e-8, "Значения функций не равны!");
                else
                    Assert.IsTrue(Math.Abs(Math.Cos(arg) + Math.Cos(func.argument)) < 1e-8, "Значения функций не равны!");

                Assert.IsTrue(Math.Abs(func.argument) <= Math.PI / 2, "Значение функции не попадает в интервал!");
            }

        }
    }




    [TestClass]
    public class OpaqueFunctionsUnitTest3
    {
        [TestMethod]
        public void OpaquePriv_Sin_3_Test()
        {

            for (int i = 0; i < 10; i++)
            {
                Random x = new Random();
                double arg = x.NextDouble() * 20000 - 10000;
                OpaqueFunctions.C_build_func func = OpaqueFunctions.Cpriv_sin_3.priv_sin_3(arg);
                if (string.Compare(func.function, "sin") == 0)
                    if (string.Compare(func.sign, "+") == 0)
                        Assert.IsTrue(Math.Abs(Math.Sin(arg) - Math.Sin(func.argument)) < 1e-8, "Значения функций не равны!");
                    else
                        Assert.IsTrue(Math.Abs(Math.Sin(arg) + Math.Sin(func.argument)) < 1e-8, "Значения функций не равны!");
                else
                    if (string.Compare(func.sign, "+") == 0)
                        Assert.IsTrue(Math.Abs(Math.Sin(arg) - Math.Cos(func.argument)) < 1e-8, "Значения функций не равны!");
                    else
                        Assert.IsTrue(Math.Abs(Math.Sin(arg) + Math.Cos(func.argument)) < 1e-8, "Значения функций не равны!");
                Assert.IsTrue(func.argument <= Math.PI/4, "Значение функции не попадает в интервал!");
            }
        
        }
    }

    [TestClass]
    public class OpaqueFunctionsUnitTest4
    {
        [TestMethod]
        public void OpaquePriv_Cos_3_Test()
        {

            for (int i = 0; i < 10; i++)
            {
                Random x = new Random();
                double arg = x.NextDouble() * 20000 - 10000;
                OpaqueFunctions.C_build_func func = OpaqueFunctions.Cpriv_cos_3.priv_cos_3(arg);
                if (string.Compare(func.function, "sin") == 0)
                    if (string.Compare(func.sign, "+") == 0)
                        Assert.IsTrue(Math.Abs(Math.Cos(arg) - Math.Sin(func.argument)) < 1e-8, "Значения функций не равны!");
                    else
                        Assert.IsTrue(Math.Abs(Math.Cos(arg) + Math.Sin(func.argument)) < 1e-8, "Значения функций не равны!");
                else
                    if (string.Compare(func.sign, "+") == 0)
                        Assert.IsTrue(Math.Abs(Math.Cos(arg) - Math.Cos(func.argument)) < 1e-8, "Значения функций не равны!");
                    else
                        Assert.IsTrue(Math.Abs(Math.Cos(arg) + Math.Cos(func.argument)) < 1e-8, "Значения функций не равны!");
                Assert.IsTrue(func.argument <= Math.PI / 4, "Значение функции не попадает в интервал!");
            }

        }
    }


    [TestClass]
    public class OpaqueFunctionsUnitTest5
    {
        [TestMethod]
        public void OpaquePriv_Tan_6_Test()
        {

            for (int i = 0; i < 1000000; i++)
            {
                Random x = new Random();
                double arg = x.NextDouble() * 20000 - 10000;
                OpaqueFunctions.C_build_func func = OpaqueFunctions.Cpriv_tan_6.priv_tan_6(arg);

                if (string.Compare(func.function, "tan") == 0)
                    if (string.Compare(func.sign, "+") == 0)
                        Assert.IsTrue(Math.Abs(Math.Tan(arg) - Math.Tan(func.argument)) < 1e-8, "Значения функций не равны!");
                    else
                        Assert.IsTrue(Math.Abs(Math.Tan(arg) + Math.Tan(func.argument)) < 1e-8, "Значения функций не равны!");
                else
                    if (string.Compare(func.sign, "+") == 0)
                        Assert.IsTrue(Math.Abs(Math.Tan(arg) - 1 / Math.Tan(func.argument)) < 1e-8, "Значения функций не равны!");
                else
                        Assert.IsTrue(Math.Abs(Math.Tan(arg) + 1 / Math.Tan(func.argument)) < 1e-8, "Значения функций не равны!");
                Assert.IsTrue(func.argument <= Math.PI / 4, "Значение функции не попадает в интервал!");
            }

        }
    }


    [TestClass]
    public class OpaqueFunctionsUnitTest6
    {
        [TestMethod]
        public void OpaquePriv_Ctg_6_Test()
        {

            for (int i = 0; i < 10; i++)
            {
                Random x = new Random();
                double arg = x.NextDouble() * 20000 - 10000;
                OpaqueFunctions.C_build_func func = OpaqueFunctions.Cpriv_ctg_6.priv_ctg_6(arg);

                if (string.Compare(func.function, "tan") == 0)
                    if (string.Compare(func.sign, "+") == 0)
                        Assert.IsTrue(Math.Abs(1 / Math.Tan(arg) - Math.Tan(func.argument)) < 1e-8, "Значения функций не равны!");
                    else
                        Assert.IsTrue(Math.Abs(1 / Math.Tan(arg) + Math.Tan(func.argument)) < 1e-8, "Значения функций не равны!");
                else
                    if (string.Compare(func.sign, "+") == 0)
                        Assert.IsTrue(Math.Abs(1 / Math.Tan(arg) - 1 / Math.Tan(func.argument)) < 1e-8, "Значения функций не равны!");
                else
                        Assert.IsTrue(Math.Abs(1 / Math.Tan(arg) + 1 / Math.Tan(func.argument)) < 1e-8 , "Значения функций не равны!");
                Assert.IsTrue(func.argument <= Math.PI / 4, "Значение функции не попадает в интервал!");
            }

        }
    }

}
