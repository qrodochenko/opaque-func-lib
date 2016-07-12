def generator1(n, name, trig, var, code, dom, arg):
    s="""MakeResultsSummaryFile("L00_{0}_2_{2}_2", CL00_{0}_2_{2}.Body(), 1);
    """.format(n, name, trig, var, code, dom, arg)
    return s
	
def generator2(n, name, trig, var, code, dom, arg1, arg2):
    #0 - номер, 1 название, 2 тригонометрический ф-ции, 3 объявление переменных, 4 код, 5 обл-ть определения, 6 аргумент
    s="""
    [TestClass]
    public class Ctest_L00_{0}_2_{2}
    {{
        double persicion = 0.000000000000001;
        [TestMethod]
        public void test_L00_{0}_2_{2}_2()
        {{
            double mx = 0, mid = 0, x, y, t;
            Random random = new Random();            
            for (int i = 0; i < 10; ++i)
            {{
                x = random.NextDouble() * 20000 + 10000;
                y = random.NextDouble() * 20000 + 10000;
                t = CL00_{0}_2_{2}.Body(x, y);
                mid += t;
                if (t > mx)
                    mx = t;
            }}
            Assert.IsTrue(Math.Abs(mid) < persicion, "Погрешность больше нужной!" +   mid.ToString());
            Assert.IsTrue(Math.Abs(mx) < persicion, "Погрешность больше нужной!" +  mid.ToString());
        }}
        
        [TestMethod]
        public void test_L00_{0}_2_{2}_2_in()
        {{
            Assert.IsTrue(CL00_{0}_2_{2}_in.Body() == "{5}", "Интервалы не совпадают");
        }}
        
    }}

   """.format(n, name, trig, var, code, dom, arg1, arg2)
    s = ''
    return s


f = open("meta.txt", "r")
s = ' '
m = f.read().split('\n')
for i in m:
	t = i.split(';')
	tmpFile = open("code\\{0}.txt".format(t[0]), "r")    
	if 'y' not in t[1] and t[0] != '66':
		s += generator1(t[0], t[1], t[3], t[4], tmpFile.read(), t[2], t[-1])
	else:
		s += generator2(t[0], t[1], t[3], t[4], tmpFile.read(), t[2], t[-2], t[-1])
	tmpFile.close()
	
#print(s)
f.close()
f = open("tests123.cs", "w")
f.write(s)
f.close()
