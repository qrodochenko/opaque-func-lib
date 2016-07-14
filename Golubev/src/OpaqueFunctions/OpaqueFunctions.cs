using System;

namespace OpaqueFunctions
{
    /// <summary>
    /// Реализует основное тригонометрическое тождество sin^2 (x) + cos^2 (x) = 1,  
    /// где угол X задается параметром в радианах <paramref name="angle"/>. 
    /// Результатом функции является целое число X - результат умножения левой части тождества само на себя столько раз,
    /// сколько задано параметром <paramref name="count"/>.
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <param name="count">Количество требуемых перемножений</param>
    /// <returns>1</returns>
    [OpaqueFunction()]
    [FunctionName("Opaque1", "sin^2 + cos^2 = 1")]
    [EquivalentIntConstant(1)]
    public static class Opaque1SinCos
    {
        public static double Body(double angle, int count)
        {
            double X = 1;
            for (int i = 0; i < count; i++)
            {
                X *= Math.Sin(angle)*Math.Sin(angle) + Math.Cos(angle)*Math.Cos(angle);
            }
            return X;
        }

      
    }
    /// <summary>
    /// Структура содержит информацию для построения тригонометрической функции.
    /// Структура содержит следующее поля:
    /// <paramref name="function"/> имя тригонометрической функции;
    /// <paramref name="argument"/> аргумент тригонометрической функции в радианах;
    /// <paramref name="sign"/> знак тригонометрической функции;
    /// </summary>

    public struct C_build_func
    {
        public string function;
        public double argument;
        public String sign;
    }
    
    /// <summary>
    /// Реализует приведение аргумента функции синуса к интервалу [-Pi/2; Pi/2],
    /// где аргумент функции задается в радианах <paramref name="x"/>.
    /// Результатом функции является структура C_build_func - содержащая новый аргумент функции,
    /// который удолетворяет интервалу [-Pi/2; Pi/2],
    /// содержит имя новой функции,
    /// содержит знак новой функции.
    /// </summary>
    /// <param name="x">Аргумент в радианах</param>
    [OpaqueFunction()]
    [FunctionName("priv_sin_2", "sin(x)=+-sin(y), y in [-Pi/2; Pi/2]")]
    public static class Cpriv_sin_2
    {
        

        public static C_build_func priv_sin_2(double x)
        {
            double N = Math.Round(x / Math.PI);
            C_build_func result;
            result.argument = x - N * Math.PI;
            if (Math.Pow(-1, N) == -1)
                result.sign = "-";
            else
                result.sign = "+";
            result.function = "sin";
            return result;

        }
    }
    /// <summary>
    /// Реализует приведение аргумента функции косинуса к интервалу [-Pi/2; Pi/2],
    /// где аргумент функции задается в радианах <paramref name="x"/>.
    /// Результатом функции является структура C_build_func - содержащая новый аргумент функции,
    /// который удолетворяет интервалу [-Pi/2; Pi/2],
    /// содержит имя новой функции,
    /// содержит знак новой функции.
    /// </summary>
    /// <param name="x">Аргумент в радианах</param>
    [OpaqueFunction()]
    [FunctionName("priv_cos_2", "cos(x)=+-cos(y), y in [-Pi/2; Pi/2]")]

    public static class Cpriv_cos_2
    {
       

        public static C_build_func priv_cos_2(double x)
        {
            double N = Math.Round(x / Math.PI);
            C_build_func result;
            result.argument = x - N * Math.PI;
            if (Math.Pow(-1, N) == -1)
                result.sign = "-";
            else
                result.sign = "+";
            result.function = "cos";
            return result;

        }
    }



    /// <summary>
    /// Реализует приведение аргумента функции синуса к интервалу [0; Pi/4],
    /// где аргумент функции задается в радианах <paramref name="x"/>.
    /// Результатом функции является структура C_build_func - содержащая новый аргумент функции,
    /// который удолетворяет интервалу [0; Pi/4],
    /// содержит имя новой функции,
    /// содержит знак новой функции.
    /// </summary>
    /// <param name="x">Аргумент в радианах</param>
    [OpaqueFunction()]
    [FunctionName("priv_sin_3", "sin(x)=+-cos(y)/+-sin(y), y in [0; Pi/4]")]

    public static class Cpriv_sin_3
    {
      

        public static C_build_func priv_sin_3(double x)
        {
            double z = Math.Abs(x) * 4 / Math.PI;
            double q = Math.Truncate(z);
            double r = z - q;
            if (x < Double.Epsilon)
                q += 4;

            C_build_func result;
            if (q % 2 == 0)
                z = r;
            else
                z = 1 - r;
            int q0 = (int)q % 8;
            switch (q0)
            {
                case 0:
                    result.argument = z * Math.PI / 4;
                    result.function = "sin";
                    result.sign = "+";
                    break;
                case 1:
                    result.argument = z * Math.PI / 4;
                    result.function = "cos";
                    result.sign = "+";
                    break;
                case 2:
                    result.argument = z * Math.PI / 4;
                    result.function = "cos";
                    result.sign = "+";
                    break;
                case 3:
                    result.argument = z * Math.PI / 4;
                    result.function = "sin";
                    result.sign = "+";
                    break;
                case 4:
                    result.argument = z * Math.PI / 4;
                    result.function = "sin";
                    result.sign = "-";
                    break;
                case 5:
                    result.argument = z * Math.PI / 4;
                    result.function = "cos";
                    result.sign = "-";
                    break;
                case 6:
                    result.argument = z * Math.PI / 4;
                    result.function = "cos";
                    result.sign = "-";
                    break;
                case 7:
                    result.argument = z * Math.PI / 4;
                    result.function = "sin";
                    result.sign = "-";
                    break;
                default:
                    result.argument = x;
                    result.function = "sin";
                    result.sign = "+";
                    break;
            }

            return result;

        }
    }


    /// <summary>
    ///  Реализует приведение аргумента функции косинуса к интервалу [0; Pi/4],
    /// где аргумент функции задается в радианах <paramref name="x"/>.
    /// Результатом функции является структура C_build_func - содержащая новый аргумент функции,
    /// который удолетворяет интервалу [0; Pi/4],
    /// содержит имя новой функции,
    /// содержит знак новой функции.
    /// </summary>
    /// <param name="x">Аргумент в радианах</param>
    [OpaqueFunction()]
    [FunctionName("priv_sin_3", "cos(x)=+-cos(y)/+-sin(y), y in [0; Pi/4]")]

    public static class Cpriv_cos_3
    {
        

        public static C_build_func priv_cos_3(double x)
        {
            double z = Math.Abs(x) * 4 / Math.PI;
            double q = Math.Truncate(z);
            double r = z - q;
            C_build_func result;
            if (q % 2 == 0)
                z = r;
            else
                z = 1 - r;
            int q0 = (int)q % 8;
            switch (q0)
            {
                case 0:
                    result.argument = z * Math.PI / 4;
                    result.function = "cos";
                    result.sign = "+";
                    break;
                case 1:
                    result.argument = z * Math.PI / 4;
                    result.function = "sin";
                    result.sign = "+";
                    break;
                case 2:
                    result.argument = z * Math.PI / 4;
                    result.function = "sin";
                    result.sign = "-";
                    break;
                case 3:
                    result.argument = z * Math.PI / 4;
                    result.function = "cos";
                    result.sign = "-";
                    break;
                case 4:
                    result.argument = z * Math.PI / 4;
                    result.function = "cos";
                    result.sign = "-";
                    break;
                case 5:
                    result.argument = z * Math.PI / 4;
                    result.function = "sin";
                    result.sign = "-";
                    break;
                case 6:
                    result.argument = z * Math.PI / 4;
                    result.function = "sin";
                    result.sign = "+";
                    break;
                case 7:
                    result.argument = z * Math.PI / 4;
                    result.function = "cos";
                    result.sign = "+";
                    break;
                default:
                    result.argument = x;
                    result.function = "cos";
                    result.sign = "+";
                    break;
            }

            return result;

        }
    }


    /// <summary>
    /// Реализует приведение аргумента функции тангенса к интервалу [-Pi/4; Pi/4],
    /// где аргумент функции задается в радианах <paramref name="x"/>.
    /// Результатом функции является структура C_build_func - содержащая новый аргумент функции,
    /// который удолетворяет интервалу [0; Pi/4],
    /// содержит имя новой функции,
    /// содержит знак новой функции.
    /// </summary>
    /// <param name="x">Аргумент в радианах</param>
    [OpaqueFunction()]
    [FunctionName("priv_tan_6", "tg(x)=+-tg(y)/+-ctg(y), y in [0; Pi/4]")]
    public static class Cpriv_tan_6
    {
       
        public static C_build_func priv_tan_6(double x)
        {
            double z = Math.Abs(x) * 4 / Math.PI;
            double q = Math.Truncate(z);
            double r = z - q;
            C_build_func result;
            if (q % 2 == 0)
                z = r;
            else
                z = 1 - r;
            int sign = 1;
            if (x < double.Epsilon)
                sign = -1;
            int q0 = (int)q % 4;
            switch(q0)
            {
                case 0:
                    result.argument = z * Math.PI / 4;
                    result.function = "tan";
                    if (sign == 1)
                        result.sign = "+";
                    else
                        result.sign = "-";
                    break;
                case 1:
                    result.argument =  z * Math.PI / 4;
                    result.function = "ctg";
                    if (sign == 1)
                        result.sign = "+";
                    else
                        result.sign = "-";
                    break;
                case 2:
                    result.argument =  z * Math.PI / 4;
                    result.function = "ctg";
                    if (sign == 1)
                        result.sign = "-";
                    else
                        result.sign = "+";
                    break;
                case 3:
                    result.argument =  z * Math.PI / 4;
                    result.function = "tan";
                    if (sign == 1)
                        result.sign = "-";
                    else
                        result.sign = "+";
                    break;
                default:
                    result.argument = x;
                    result.function = "tan";
                    result.sign = "+";
                    break;
            }
            return result;

        }
    }

    /// <summary>
    /// Реализует приведение аргумента функции котангенса к интервалу [-Pi/4; Pi/4],
    /// где аргумент функции задается в радианах <paramref name="x"/>.
    /// Результатом функции является структура C_build_func - содержащая новый аргумент функции,
    /// который удолетворяет интервалу [-Pi/4; Pi/4],
    /// содержит имя новой функции,
    /// содержит знак новой функции.
    /// </summary>
    /// <param name="x">Аргумент в радианах</param>
    [OpaqueFunction()]
    [FunctionName("priv_ctg_6", "ctg(x)=+-tg(y)/+-ctg(y), y in [0; Pi/4]")]

    public static class Cpriv_ctg_6
    {
        
        public static C_build_func priv_ctg_6(double x)
        {
            double z = Math.Abs(x) * 4 / Math.PI;
            double q = Math.Truncate(z);
            double r = z - q;
            C_build_func result;
            if (q % 2 == 0)
                z = r;
            else
                z = 1 - r;
            int sign = 1;
            if (x < double.Epsilon)
                sign = -1;

            int q0 = (int)q % 4;
            switch (q0)
            {
                case 0:
                    result.argument =  z * Math.PI / 4;
                    result.function = "ctg";
                    if (sign == 1)
                        result.sign = "+";
                    else
                        result.sign = "-";
                    break;
                case 1:
                    result.argument =  z * Math.PI / 4;
                    result.function = "tan";
                    if (sign == 1)
                        result.sign = "+";
                    else
                        result.sign = "-";
                    break;
                case 2:
                    result.argument =  z * Math.PI / 4;
                    result.function = "tan";
                    if (sign == 1)
                        result.sign = "-";
                    else
                        result.sign = "+";
                    break;
                case 3:
                    result.argument =  z * Math.PI / 4;
                    result.function = "ctg";
                    if (sign == 1)
                        result.sign = "-";
                    else
                        result.sign = "+";
                    break;
                default:
                    result.argument = x;
                    result.function = "ctg";
                    result.sign = "+";
                    break;
            }
            return result;

        }
    }
}

