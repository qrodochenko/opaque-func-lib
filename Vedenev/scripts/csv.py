def generator1(n, name, trig, var, code, dom, arg):
    s="""MakeResultsSummaryFile("L00_{0}_2_{2}_2", CL00_{0}_2_{2}.Body, 1);
    """.format(n, name, trig, var, code, dom, arg)
    return s
	
def generator2(n, name, trig, var, code, dom, arg1, arg2):
    #0 - номер, 1 название, 2 тригонометрический ф-ции, 3 объявление переменных, 4 код, 5 обл-ть определения, 6 аргумент
    s="""MakeResultsSummaryFile("L00_{0}_2_{2}_2", CL00_{0}_2_{2}.Body);
    """.format(n, name, trig, var, code, dom, arg1)    
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
