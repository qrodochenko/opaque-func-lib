def generator1(n, name, trig, var, code, dom, arg):
    #0 - номер, 1 название, 2 тригонометрический ф-ции, 3 объявление переменных, 4 код, 5 обл-ть определения, 6 аргумент
    s = """//##################################################################################################
    /// <summary>
    /// Реализует тождество {0} {1}
    /// </summary>
    /// <param name="x">{6}</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_{0}_1_{2}", "{1}")]
    [EquivalentIntConstant(0)]
    public static class CL00_{0}_1_{2}
    {{
        public static double Body(double x)
        {{            
            double {3};
            {4}
            return X;
        }}
    }}
    /// <summary>
    /// Реализует тождество {0} {1},
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметр <paramref name="count"/>.
    /// </summary>
    /// <param name="x">{6}</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_{0}_2_{2}", "{1}")]
    [EquivalentIntConstant(0)]
    public static class CL00_{0}_2_{2}
    {{
        public static double Body(double x, int count)
        {{
            double {3};
            for (int i = 0; i < count; ++i) {{
                {4}
            }}
            return X;
        }}
    }}
    /// <summary>
    /// Возвращает область определения тождества {0} {1}
    /// </summary>    
    /// <returns>{5}</returns>
    [OpaqueFunction()]
    [FunctionName("L00_{0}_1_{2}_in", "(0, w)")]
    public static class CL00_{0}_1_{2}_in
    {{
        public static string Body()
        {{
            return "{5}";
        }}
    }}


    
    """.format(n, name, trig, var, code, dom, arg)
    return s
	
def generator2(n, name, trig, var, code, dom, arg1, arg2):
    #0 - номер, 1 название, 2 тригонометрический ф-ции, 3 объявление переменных, 4 код, 5 обл-ть определения, 6 аргумент
    s = """//##################################################################################################
    /// <summary>
    /// Реализует тождество {0} {1}
    /// </summary>
    /// <param name="x">{6}</param>
	/// <param name="y">{7}</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_{0}_2_{2}", "{1}")]
    [EquivalentIntConstant(0)]
    public static class CL00_{0}_2_{2}
    {{
        public static double Body(double x, double y)
        {{            
            double {3};
            {4}
            return X;
        }}
    }}
    /// <summary>
    /// Реализует тождество {0} {1},
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметр <paramref name="count"/>.
    /// </summary>
    /// <param name="x">{6}</param>
	/// <param name="y">{7}</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_{0}_3_{2}", "{1}")]
    [EquivalentIntConstant(0)]
    public static class CL00_{0}_3_{2}
    {{
        public static double Body(double x, double y, int count)
        {{
            double {3};
            for (int i = 0; i < count; ++i) {{
                {4}
            }}
            return X;
        }}
    }}
    /// <summary>
    /// Возвращает область определения тождества {0} {1}
    /// </summary>    
    /// <returns>{5}</returns>
    [OpaqueFunction()]
    [FunctionName("L00_{0}_2_{2}_in", "(0, w)")]
    public static class CL00_{0}_2_{2}_in
    {{
        public static string Body()
        {{
            return "{5}";
        }}
    }}	



   """.format(n, name, trig, var, code, dom, arg1, arg2)
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
f = open("res70.cs", "w")
f.write(s)
f.close()
