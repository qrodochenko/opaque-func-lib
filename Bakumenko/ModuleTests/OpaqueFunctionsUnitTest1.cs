using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpaqueFunctions;

namespace ModuleTests
{
    [TestClass] 
    public class CTest_L00_30_1_sin_arccos
    { 
        [TestMethod] 
        public void Test_L00_30_1_sin_arccos()
        { 
            //выбрал собственный порог ошибки 
            double treshold = 1e-14; 
            var rnd = new Random(); 
            var arg = rnd.NextDouble() * double.MaxValue;

            double F = CL00_30_1_sin_arccos.L00_30_1_sin_arccos(arg);
            Assert.IsTrue(Math.Abs(F - 0) < treshold, "Значение функции не ноль!");
            //Assert.IsTrue(Math.Abs(F - 1) < double.Epsilon, "Значение функции не единица!");
        }

        [TestMethod] 
        public void Test_L00_103_3_log_in()
        { 
            string str = "(0, w)";
            string F = CL00_30_1_sin_arccos_in.L00_30_1_sin_arccos_in();
            Assert.IsTrue(F == str, "Область определения задана неверно!"); 
        } 
    } 

}
