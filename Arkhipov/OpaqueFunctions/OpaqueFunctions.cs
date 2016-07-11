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
                X *= Math.Sin(angle) * Math.Sin(angle) + Math.Cos(angle) * Math.Cos(angle);
            }
            return X;
        }
    }

    /// <summary>
    /// Реализует 86.​ f(x) = th(2x) – (2*th(x))/( 1 + th(x)*th(x))
    /// </summary>
    /// <param name="angle">Угол в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_86_1_th", "f(x) = th(2x) – (2*th(x))/( 1 + th(x)*th(x))")]
    [EquivalentIntConstant(0)]
    public static class CL00_86_1_th
    {
        public static double L00_86_1_th(double angle)
        {
            double X, thX, th2X;
            thX = Math.Tanh(angle);
            th2X = Math.Tanh(2 * angle);
            X = th2X - (2 * thX) / (1 + thX * thX);
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 86.​ f(x) = th(2x) – (2*th(x))/( 1 + th(x)*th(x))
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_86_1_th_in", "f(x) = th(2x) – (2*th(x))/( 1 + th(x)*th(x))")]
    [EquivalentIntConstant(0)]
    public static class CL00_86_1_th_in
    {
        public static string L00_86_1_th_in()
        {
            string str = "(w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 87.​ f(x,y) = sh(x) + sh(y) – 2 * sh((x+y)/2) * ch((x-y)/2)
    /// </summary>
    /// <param name="angle">Угол X в радианах</param>
    /// <param name="angle2">Угол Y в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_87_2_sh_ch", "f(x,y) = sh(x) + sh(y) – 2*sh((x+y)/2)*ch((x-y)/2)")]
    [EquivalentIntConstant(0)]
    public static class CL00_87_2_sh_ch
    {
        public static double L00_87_2_sh_ch(double angle, double angle2)
        {
            double X, shX, shY, shXpY, chXmY;
            shX = Math.Sinh(angle);
            shY = Math.Sinh(angle2);
            shXpY = Math.Sinh((angle + angle2) / 2);
            chXmY = Math.Cosh((angle - angle2) / 2);

            X = shX + shY - 2 * shXpY * chXmY;
            return X;
        }
    }
    /// <summary>
    /// Возвращает область определения 87.​ f(x,y) = sh(x) + sh(y) – 2*sh((x+y)/2)*ch((x-y)/2)
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_87_2_sh_ch_in", "f(x,y) = sh(x) + sh(y) – 2*sh((x+y)/2)*ch((x-y)/2)")]
    [EquivalentIntConstant(0)]
    public static class CL00_87_2_sh_ch_in
    {
        public static string L00_87_2_sh_ch_in()
        {
            string str = "(w, w) (w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 88.​ f(x,y) = sh(x) - sh(y) – 2*sh((x-y)/2)*ch((x+y)/2)
    /// </summary>
    /// <param name="angle">Угол X в радианах</param>
    /// <param name="angle2">Угол Y в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_88_2_sh_ch", "f(x,y) = sh(x) - sh(y) – 2*sh((x-y)/2)*ch((x+y)/2)")]
    [EquivalentIntConstant(0)]
    public static class CL00_88_2_sh_ch
    {
        public static double L00_88_2_sh_ch(double angle, double angle2)
        {
            double X, shX, shY, shXmY, chXpY;
            shX = Math.Sinh(angle);
            shY = Math.Sinh(angle2);
            shXmY = Math.Sinh((angle - angle2) / 2);
            chXpY = Math.Cosh((angle + angle2) / 2);

            X = shX - shY - 2 * shXmY * chXpY;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 88.​ f(x,y) = sh(x) - sh(y) – 2*sh((x-y)/2)*ch((x+y)/2)
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_88_2_sh_ch_in", "f(x,y) = sh(x) - sh(y) – 2*sh((x-y)/2)*ch((x+y)/2)")]
    [EquivalentIntConstant(0)]
    public static class CL00_88_2_sh_ch_in
    {
        public static string L00_88_2_sh_ch_in()
        {
            string str = "(w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 89.​ f(x,y) = ch(x) + ch(y) – 2*ch((x+y)/2)*ch((x-y)/2)
    /// </summary>
    /// <param name="angle">Угол X в радианах</param>
    /// <param name="angle2">Угол Y в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_89_2_ch", "f(x,y) = ch(x) + ch(y) – 2*ch((x+y)/2)*ch((x-y)/2)")]
    [EquivalentIntConstant(0)]
    public static class CL00_89_2_ch
    {
        public static double L00_89_2_ch(double angle, double angle2)
        {
            double X, chX, chY, chXpY, chXmY;
            chX = Math.Cosh(angle);
            chY = Math.Cosh(angle2);
            chXpY = Math.Cosh((angle + angle2) / 2);
            chXmY = Math.Cosh((angle - angle2) / 2);

            X = chX + chY - 2 * chXpY * chXmY;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 89.​ f(x,y) = ch(x) + ch(y) – 2*ch((x+y)/2)*ch((x-y)/2)
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_89_2_ch_in", "f(x,y) = ch(x) + ch(y) – 2*ch((x+y)/2)*ch((x-y)/2)")]
    [EquivalentIntConstant(0)]
    public static class CL00_89_2_ch_in
    {
        public static string L00_89_2_ch_in()
        {
            string str = "(w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 90.​ f(x,y) = ch(x) - ch(y) – 2*sh((x+y)/2)*sh((x-y)/2)
    /// </summary>
    /// <param name="angle">Угол X в радианах</param>
    /// <param name="angle2">Угол Y в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_90_2_ch_sh", "f(x,y) = ch(x) - ch(y) – 2*sh((x+y)/2)*sh((x-y)/2)")]
    [EquivalentIntConstant(0)]
    public static class CL00_90_2_ch_sh
    {
        public static double L00_90_2_ch_sh(double angle, double angle2)
        {
            double X, chX, chY, shXpY, shXmY;
            chX = Math.Cosh(angle);
            chY = Math.Cosh(angle2);
            shXpY = Math.Sinh((angle + angle2) / 2);
            shXmY = Math.Sinh((angle - angle2) / 2);

            X = chX - chY - 2 * shXpY * shXmY;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 90.​ f(x,y) = ch(x) - ch(y) – 2*sh((x+y)/2)*sh((x-y)/2)
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_90_2_ch_sh_in", "f(x,y) = ch(x) - ch(y) – 2*sh((x+y)/2)*sh((x-y)/2)")]
    [EquivalentIntConstant(0)]
    public static class CL00_90_2_ch_sh_in
    {
        public static string L00_90_2_ch_sh_in()
        {
            string str = "(w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 91.​ f(x,y) = th(x) + th(y) – sh(x+y)/(ch(x)*ch(y))
    /// </summary>
    /// <param name="angle">Угол X в радианах</param>
    /// <param name="angle2">Угол Y в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_91_2_th_sh_ch", "f(x,y) = th(x) + th(y) – sh(x+y)/(ch(x)*ch(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_91_2_th_sh_ch
    {
        public static double L00_91_2_th_sh_ch(double angle, double angle2)
        {
            double X, thX, thY, shXpY, chX, chY;
            thX = Math.Tanh(angle);
            thY = Math.Tanh(angle2);
            shXpY = Math.Sinh(angle + angle2);
            chX = Math.Cosh(angle);
            chY = Math.Cosh(angle2);

            X = thX + thY - shXpY / chX / chY;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 91.​ f(x,y) = th(x) + th(y) – sh(x+y)/(ch(x)*ch(y))
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_91_2_th_sh_ch_in", "f(x,y) = th(x) + th(y) – sh(x+y)/(ch(x)*ch(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_91_2_th_sh_ch_in
    {
        public static string L00_91_2_th_sh_ch_in()
        {
            string str = "(w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 92.​ f(x,y) = th(x) - th(y) – sh(x-y)/(ch(x)*ch(y))
    /// </summary>
    /// <param name="angle">Угол X в радианах</param>
    /// <param name="angle2">Угол Y в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_92_2_th_sh_ch", "f(x,y) = th(x) - th(y) – sh(x-y)/(ch(x)*ch(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_92_2_th_sh_ch
    {
        public static double L00_92_2_th_sh_ch(double angle, double angle2)
        {
            double X, thX, thY, shXmY, chX, chY;
            thX = Math.Tanh(angle);
            thY = Math.Tanh(angle2);
            shXmY = Math.Sinh(angle - angle2);
            chX = Math.Cosh(angle);
            chY = Math.Cosh(angle2);

            X = thX - thY - shXmY / (chX * chY);
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 92.​ f(x,y) = th(x) - th(y) – sh(x-y)/(ch(x)*ch(y))
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_92_2_th_sh_ch_in", "f(x,y) = th(x) - th(y) – sh(x-y)/(ch(x)*ch(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_92_2_th_sh_ch_in
    {
        public static string L00_92_2_th_sh_ch_in()
        {
            string str = "(w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 93.​ f(x,y) = cth(x) + cth(y) – sh(y+x)/(sh(x)*sh(y))
    /// </summary>
    /// <param name="angle">Угол X в радианах</param>
    /// <param name="angle2">Угол Y в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_93_2_cth_sh", "f(x,y) = cth(x) + cth(y) – sh(y+x)/(sh(x)*sh(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_93_2_cth_sh
    {
        public static double L00_93_2_cth_sh(double angle, double angle2)
        {
            double X, cthX, cthY, shXpY, shX, shY;
            cthX = 1 / Math.Tanh(angle);
            cthY = 1 / Math.Tanh(angle2);
            shXpY = Math.Sinh(angle + angle2);
            shX = Math.Sinh(angle);
            shY = Math.Sinh(angle2);

            X = cthX + cthY - shXpY / shX / shY;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 93.​ f(x,y) = cth(x) + cth(y) – sh(y+x)/(sh(x)*sh(y))
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_93_2_cth_sh_in", "f(x,y) = cth(x) + cth(y) – sh(y+x)/(sh(x)*sh(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_93_2_cth_sh_in
    {
        public static string L00_93_2_cth_sh_in()
        {

            string str = "(0, w) (0, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 94.​ f(x,y) = cth(x) - cth(y) – sh(y-x)/(sh(x)*sh(y))
    /// </summary>
    /// <param name="angle">Угол X в радианах</param>
    /// <param name="angle2">Угол Y в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_94_2_cth_sh", "f(x,y) = cth(x) - cth(y) – sh(y-x)/(sh(x)*sh(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_94_2_cth_sh
    {
        public static double L00_94_2_cth_sh(double angle, double angle2)
        {
            double X, cthX, cthY, shXmY, shX, shY;
            cthX = 1 / Math.Tanh(angle);
            cthY = 1 / Math.Tanh(angle2);
            shXmY = Math.Sinh(angle - angle2);
            shX = Math.Sinh(angle);
            shY = Math.Sinh(angle2);

            X = cthX - cthY - shXmY / (shX * shY);
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 94.​ f(x,y) = cth(x) - cth(y) – sh(y-x)/(sh(x)*sh(y))
    /// sh(x)*sh(y) = 0 при y = 2*i*Pi*C1 + i * Pi
    /// https://www.wolframalpha.com/input/?i=sh(x)*sh(y)+%3D+0
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_94_2_cth_sh_in", "f(x,y) = cth(x) - cth(y) – sh(y-x)/(sh(x)*sh(y))")]
    [EquivalentIntConstant(0)]
    public static class CL00_94_2_cth_sh_in
    {
        public static string L00_94_2_cth_sh_in()
        {
            string str = "(0, w) (0, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 95.​ f(x,y) = sh(x)*sh(x) – sh(y)*sh(y) – sh(x+y)*sh(x-y)
    /// </summary>
    /// <param name="angle">Угол X в радианах</param>
    /// <param name="angle2">Угол Y в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_95_2_sh", "f(x,y) = sh(x)*sh(x) – sh(y)*sh(y) – sh(x+y)*sh(x-y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_95_2_sh
    {
        public static double L00_95_2_sh(double angle, double angle2)
        {
            double X, shX, shY, shXmY, shXpY;
            shX = Math.Sinh(angle);
            shY = Math.Sinh(angle2);
            shXmY = Math.Sinh(angle - angle2);
            shXpY = Math.Sinh(angle + angle2);

            X = shX * shX - shY * shY - shXpY * shXmY;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 95.​ f(x,y) = sh(x)*sh(x) – sh(y)*sh(y) – sh(x+y)*sh(x-y)
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_95_2_sh_in", "f(x,y) = sh(x)*sh(x) – sh(y)*sh(y) – sh(x+y)*sh(x-y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_95_2_sh_in
    {
        public static string L00_95_2_sh_in()
        {
            string str = "(w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 96.​ f(x,y) = ch(x)*ch(x) – ch(y)*ch(y) – sh(x+y)*sh(x-y)
    /// </summary>
    /// <param name="angle">Угол X в радианах</param>
    /// <param name="angle2">Угол Y в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_96_2_ch_sh", "f(x,y) = ch(x)*ch(x) – ch(y)*ch(y) – sh(x+y)*sh(x-y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_96_2_ch_sh
    {
        public static double L00_96_2_ch_sh(double angle, double angle2)
        {
            double X, chX, chY, shXpY, shXmY;
            chX = Math.Cosh(angle);
            chY = Math.Cosh(angle2);
            shXmY = Math.Sinh(angle - angle2);
            shXpY = Math.Sinh(angle + angle2);

            X = chX * chX - chY * chY - shXpY * shXmY;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 96.​ f(x,y) = ch(x)*ch(x) – ch(y)*ch(y) – sh(x+y)*sh(x-y)
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_96_2_ch_sh_in", "f(x,y) = ch(x)*ch(x) – ch(y)*ch(y) – sh(x+y)*sh(x-y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_96_2_ch_sh_in
    {
        public static string L00_96_2_ch_sh_in()
        {
            string str = "(w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 97.​ f(x,y) = sh(x)*sh(x) – sh(y)*sh(y) – ch(x)*ch(x) + ch(y)*ch(y)
    /// </summary>
    /// <param name="angle">Угол X в радианах</param>
    /// <param name="angle2">Угол Y в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_97_2_sh_ch", "f(x,y) = sh(x)*sh(x) – sh(y)*sh(y) – ch(x)*ch(x) + ch(y)*ch(y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_97_2_sh_ch
    {
        public static double L00_97_2_sh_ch(double angle, double angle2)
        {
            double X, chX, chY, shX, shY;
            chX = Math.Cosh(angle);
            chY = Math.Cosh(angle2);
            shX = Math.Sinh(angle);
            shY = Math.Sinh(angle2);

            X = shX * shX - shY * shY - chX * chX + chY * chY;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 97.​ f(x,y) = sh(x)*sh(x) – sh(y)*sh(y) – ch(x)*ch(x) + ch(y)*ch(y)
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_97_2_sh_ch_in", "f(x,y) = sh(x)*sh(x) – sh(y)*sh(y) – ch(x)*ch(x) + ch(y)*ch(y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_97_2_sh_ch_in
    {
        public static string L00_97_2_sh_ch_in()
        {
            string str = "(w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 98.​ f(x,y) = sh(x)*sh(x) + ch(y)*ch(y) - ch(x+y)*ch(x-y)
    /// </summary>
    /// <param name="angle">Угол X в радианах</param>
    /// <param name="angle2">Угол Y в радианах</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_98_2_sh_ch", "f(x,y) = sh(x)*sh(x) + ch(y)*ch(y) - ch(x+y)*ch(x-y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_98_2_sh_ch
    {
        public static double L00_98_2_sh_ch(double angle, double angle2)
        {
            double X, chY, shX, chXpY, chXmY;
            chY = Math.Cosh(angle2);
            shX = Math.Sinh(angle);
            chXpY = Math.Cosh(angle + angle2);
            chXmY = Math.Cosh(angle - angle2);

            X = shX * shX + chY * chY - chXpY * chXmY;
            return X;
        }
    }

    //?????????????????????????????????????????????????????????????????????????????????????????????????????????
    //?????????????????????????????????????????????????????????????????????????????????????????????????????????
    //?????????????????????????????????????????????????????????????????????????????????????????????????????????
    /// <summary>
    /// Возвращает область определения 98.​ f(x,y) = sh(x)*sh(x) + ch(y)*ch(y) - ch(x+y)*ch(x-y)
    /// Данная функция не тождественный ноль
    /// http://www.wolframalpha.com/input/?i=sh%28x%29*sh%28x%29+%2B+ch%28y%29*ch%28y%29+-+ch%28x%2By%29*ch%28x-y%29
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_98_2_sh_ch_in", "f(x,y) = sh(x)*sh(x) + ch(y)*ch(y) - ch(x+y)*ch(x-y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_98_2_sh_ch_in
    {
        public static string L00_98_2_sh_ch_in()
        {
            string str = "(w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 99.​ f(x) = log_a(x) + log_1/a(x)
    /// </summary>
    /// <param name="arg">Аргумент логарифма</param>
    /// <param name="basis">Основание логарифма a, необязаетльный параметр, из области (0, 1) & (1, w)</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_99_2_log", "f(x) = log_a(x) + log_1/a(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_99_2_log
    {
        public static double L00_99_2_log(double arg, double basis = 5.0)
        {
            double X, logaX, log1aX;
            logaX = Math.Log(arg, basis);
            log1aX = Math.Log(arg, 1 / basis);

            X = logaX + log1aX;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 99.​ f(x) = log_a(x) + log_1/a(x)
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_99_2_log_in", "f(x) = log_a(x) + log_1/a(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_99_2_log_in
    {
        public static string L00_99_2_log_in()
        {
            string str = "(0, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 100.​ f(x,y) = log_a(x*y) – log_a(x) - log_a(y)
    /// </summary>
    /// <param name="arg">Аргумент логарифма X</param>
    /// <param name="arg2">Аргумент логарифма Y</param>
    /// <param name="basis">Основание логарифма a, необязаетльный параметр, из области (0, 1) & (1, w)</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_100_3_log", "f(x,y) = log_a(x*y) – log_a(x) - log_a(y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_100_3_log
    {
        public static double L00_100_3_log(double arg, double arg2, double basis = 5.0)
        {
            double X, logaXY, logaX, logaY;
            logaXY = Math.Log(arg * arg2, basis);
            logaX = Math.Log(arg, basis);
            logaY = Math.Log(arg2, basis);

            X = logaXY - logaX - logaY;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 100.​ f(x,y) = log(x*y) – log_a(x) + log_a(y)
    /// Где первый интервал - это область определения Х, а второй - область определения Y
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_100_3_log_in", "f(x,y) = log(x*y) – log_a(x) + log_a(y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_100_3_log_in
    {
        public static string L00_100_3_log_in()
        {
            string str = "(0, w) (0, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 101.​ f(x,y) = log_a(x/y) – log_a(x) + log_a(y)
    /// </summary>
    /// <param name="arg">Аргумент логарифма X</param>
    /// <param name="arg2">Аргумент логарифма Y</param>
    /// <param name="basis">Основание логарифма a, необязаетльный параметр, из области (0, 1) & (1, w)</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_101_3_log", "f(x,y) = log_a(x/y) – log_a(x) + log_a(y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_101_3_log
    {
        public static double L00_101_3_log(double arg, double arg2, double basis = 5.0)
        {
            double X, logaXY, logaX, logaY;
            logaXY = Math.Log(arg / arg2, basis);
            logaX = Math.Log(arg, basis);
            logaY = Math.Log(arg2, basis);

            X = logaXY - logaX + logaY;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 101.​ f(x,y) = log_a(x/y) – log_a(x) + log_a(y)
    /// Где первый интервал - это область определения Х, а второй - область определения Y
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_101_3_log_in", "f(x,y) = log_a(x/y) – log_a(x) + log_a(y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_101_3_log_in
    {
        public static string L00_101_3_log_in()
        {
            string str = "(0, w) (0, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 102.​ f(x) = log_a(x^n) – n*log_a(x)
    /// </summary>
    /// <param name="arg">Аргумент логарифма X</param>
    /// <param name="n">Степень аргумента, необязательный параметр</param>
    /// <param name="basis">Основание логарифма a, необязаетльный параметр, из области (0, 1) & (1, w)</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_102_3_log", "f(x) = log_a(x^n) – n*log_a(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_102_3_log
    {
        public static double L00_102_3_log(double arg, int n = 10, double basis = 5.0)
        {
            double X, XN = arg, logaXN, logaX;
            for (int i = 1; i < n; i++)
                XN *= arg;
            logaXN = Math.Log(XN, basis);
            logaX = Math.Log(arg, basis);

            X = logaXN - n * logaX;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 102.​ f(x) = log_a(x^n) – n * log_a(x)
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_102_3_log_in", "f(x) = log_a(x^n) – n * log_a(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_102_3_log_in
    {
        public static string L00_102_3_log_in()
        {
            string str = "(0, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 103.​ f(x) = log_a(x) – log_b(x)/log_b(a)
    /// </summary>
    /// <param name="arg">Аргумент логарифма</param>
    /// <param name="basis">Основание логарифма a, необязаетльный параметр, из области (0, 1) & (1, w)</param>
    /// <param name="basis2">Основание логарифма b, необязаетльный параметр</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_103_3_log", "f(x) = log_a(x) – log_b(x)/log_b(a)")]
    [EquivalentIntConstant(0)]
    public static class CL00_103_3_log
    {
        public static double L00_103_3_log(double arg, double basis = 5.0, double basis2 = 10.0)
        {
            double X, logaX, logbX, logbA;
            logaX = Math.Log(arg, basis);
            logbX = Math.Log(arg, basis2);
            logbA = Math.Log(basis, basis2);

            X = logaX - logbX / logbA;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 103.​ f(x) = log_a(x) – log_b(x)/log_b(a)
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_103_3_log_in", "f(x) = log_a(x) – log_b(x)/log_b(a)")]
    [EquivalentIntConstant(0)]
    public static class CL00_103_3_log_in
    {
        public static string L00_103_3_log_in()
        {
            string str = "(0, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 104.​ f(x) = ln(x+(x*x+1)^1/2) – Arsh(x)
    /// Т.к. в С# нет встроеной функции Arsh(x), реализация состоит из разности 
    /// одинаковых логарифмов ln(x+(x*x + 1)^1/2)
    /// </summary>
    /// <param name="arg">Аргумент логарифма</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_104_1_ln_arsh", "f(x) = ln(x+(x*x+1)^1/2) – Arsh(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_104_1_ln_arsh
    {
        public static double L00_104_1_ln_arsh(double arg)
        {
            double X, lnX, sqrt, arsh;
            sqrt = Math.Sqrt(arg*arg + 1);
            lnX = Math.Log(arg + sqrt);
            arsh = lnX;

            X = lnX - arsh;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 104.​ f(x) = ln(x+(x*x+1)^1/2) – Arsh(x)
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_104_1_ln_arsh_in", "f(x) = ln(x+(x*x+1)^1/2) – Arsh(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_104_1_ln_arsh_in
    {
        public static string L00_104_1_ln_arsh_in()
        {
            string str = "(w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 105.​ f(x) = ln(x + (x*x - 1)^1/2) – Arch(x)
    /// Т.к. в С# нет встроеной функции Arch(x), реализация состоит из разности 
    /// одинаковых логарифмов ln(x+(x*x - 1)^1/2)
    /// </summary>
    /// <param name="arg">Аргумент логарифма</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_105_1_ln_arch", "f(x) = ln(x + (x*x - 1)^1/2) – Arch(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_105_1_ln_arch
    {
        public static double L00_105_1_ln_arch(double arg)
        {
            double X, lnX, sqrt, arch;
            sqrt = Math.Sqrt(arg * arg - 1);
            lnX = Math.Log(arg + sqrt);
            arch = lnX;

            X = lnX - arch;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 105.​ f(x) = ln(x + (x*x - 1)^1/2) – Arch(x)
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_105_1_ln_arch_in", "f(x) = ln(x + (x*x - 1)^1/2) – Arch(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_105_1_ln_arch_in
    {
        public static string L00_105_1_ln_arch_in()
        {
            string str = "(1, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 106.​ f(x) = 1/2 * ln((1 + x)/(1 - x)) – Arth(x)
    /// Т.к. в С# нет встроеной функции Arth(x), реализация состоит из разности 
    /// одинаковых логарифмов 1/2 * ln((1 + x)/(1 - x))
    /// </summary>
    /// <param name="arg">Аргумент логарифма</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_106_1_ln_arth", "f(x) = 1/2 * ln((1 + x)/(1 - x)) – Arth(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_106_1_ln_arth
    {
        public static double L00_106_1_ln_arth(double arg)
        {
            double X, lnX, arth;
            lnX = Math.Log((1 + arg)/(1 - arg));
            arth = lnX / 2;

            X = (lnX / 2) - arth;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 106.​ f(x) = 1/2 * ln((1 + x)/(1 - x)) – Arth(x)
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_106_1_ln_arth_in", "f(x) = 1/2 * ln((1 + x)/(1 - x)) – Arth(x)")]
    [EquivalentIntConstant(0)]
    public static class CL00_106_1_ln_arth_in
    {
        public static string L00_106_1_ln_arth_in()
        {
            string str = "(-1, 1)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 107.​ f(x) = a^x – e^(x*ln(a))
    /// </summary>
    /// <param name="arg">Аргумент X</param>
    /// <param name="param">Необязательный параметр А</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_107_2_pow_exp", "f(x) = a^x – e^(x*ln(a))")]
    [EquivalentIntConstant(0)]
    public static class CL00_107_2_pow_exp
    {
        public static double L00_107_2_pow_exp(double arg, double param = 10.0)
        {
            double X, aX, ln, exp;
            ln = Math.Log(param);
            exp = Math.Exp(arg * ln);
            aX = Math.Pow(param, arg);

            X = aX - exp;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 107.​ f(x) = a^x – e^(x*ln(a))
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_107_2_pow_exp_in", "f(x) = a^x – e^(x*ln(a))")]
    [EquivalentIntConstant(0)]
    public static class CL00_107_2_pow_exp_in
    {
        public static string L00_107_2_pow_exp_in()
        {
            string str = "(w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 108.​ f(x,y) = a^x * a^y – a^(x+y)
    /// </summary>
    /// <param name="arg">Аргумент X</param>
    /// <param name="arg2">Аргумент Y</param>
    /// <param name="param">Необязательный параметр А</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_108_3_pow", "f(x,y) = a^x * a^y – a^(x+y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_108_3_pow
    {
        public static double L00_108_3_pow(double arg, double arg2, double param = 10.0)
        {
            double X, aX, aY, aXY;
            aX = Math.Pow(param, arg);
            aY = Math.Pow(param, arg2);
            aXY = Math.Pow(param, arg * arg2);

            X = aX * aY - aXY;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 108.​ f(x,y) = a^x * a^y – a^(x+y)
    /// Где первый интервал - это область определения Х, а второй - область определения Y
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_108_3_pow_in", "f(x,y) = a^x * a^y – a^(x+y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_108_3_pow_in
    {
        public static string L00_108_3_pow_in()
        {
            string str = "(w, w) (w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 109.​ f(x,y) = a^x/a^y – a^(x-y)
    /// </summary>
    /// <param name="arg">Аргумент X</param>
    /// <param name="arg2">Аргумент Y</param>
    /// <param name="param">Необязательный параметр А</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_109_3_pow", "f(x,y) = a^x/a^y – a^(x-y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_109_3_pow
    {
        public static double L00_109_3_pow(double arg, double arg2, double param = 10.0)
        {
            double X, aX, aY, aXY;
            aX = Math.Pow(param, arg);
            aY = Math.Pow(param, arg2);
            aXY = Math.Pow(param, arg - arg2);

            X = (aX / aY) - aXY;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 109.​ f(x,y) = a^x/a^y – a^(x-y)
    /// Где первый интервал - это область определения Х, а второй - область определения Y
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_109_3_pow_in", "f(x,y) = a^x/a^y – a^(x-y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_109_3_pow_in
    {
        public static string L00_109_3_pow_in()
        {
            string str = "(w, w) (w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 110.​ f(x,y) = (a^x)^y – a^(x*y)
    /// </summary>
    /// <param name="arg">Аргумент X</param>
    /// <param name="arg2">Аргумент Y</param>
    /// <param name="param">Необязательный параметр А</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_110_3_pow", "f(x,y) = (a^x)^y – a^(x*y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_110_3_pow
    {
        public static double L00_110_3_pow(double arg, double arg2, double param = 10.0)
        {
            double X, aX, axY, aXY;
            aX = Math.Pow(param, arg);
            axY = Math.Pow(aX, arg2);
            aXY = Math.Pow(param, arg * arg2);

            X = axY - aXY;
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 110.​ f(x,y) = (a^x)^y – a^(x*y)
    /// Где первый интервал - это область определения Х, а второй - область определения Y
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_110_3_pow_in", "f(x,y) = (a^x)^y – a^(x*y)")]
    [EquivalentIntConstant(0)]
    public static class CL00_110_3_pow_in
    {
        public static string L00_110_3_pow_in()
        {
            string str = "(w, w) (w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 111.​ f(x) = e^x – (1 + th(x/2))/(1 – th(x/2))
    /// </summary>
    /// <param name="arg">Аргумент X</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_111_1_exp_th", "f(x) = e^x – (1 + th(x/2))/(1 – th(x/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_111_1_exp_th
    {
        public static double L00_111_1_exp_th(double arg)
        {
            double X, th, exp;
            exp = Math.Exp(arg);
            th = Math.Tanh(arg / 2);

            X = exp - (1 + th) / (1 - th);
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 111.​ f(x) = e^x – (1 + th(x/2))/(1 – th(x/2))
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_111_1_exp_th_in", "f(x) = e^x – (1 + th(x/2))/(1 – th(x/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_111_1_exp_th_in
    {
        public static string L00_111_1_exp_th_in()
        {
            string str = "(w, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 112.​ f(x) = e^x – (ch(x/2) + sh(x/2))/ (ch(x/2) - sh(x/2))
    /// </summary>
    /// <param name="arg">Аргумент X</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_112_1_exp_ch_sh", "f(x) = e^x – (ch(x/2) + sh(x/2))/ (ch(x/2) - sh(x/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_112_1_exp_ch_sh
    {
        public static double L00_112_1_exp_ch_sh(double arg)
        {
            double X, ch, sh, exp;
            exp = Math.Exp(arg);
            ch = Math.Cosh(arg / 2);
            sh = Math.Sinh(arg / 2);

            X = exp - (ch + sh) / (ch - sh);
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 112.​ f(x) = e^x – (ch(x/2) + sh(x/2))/ (ch(x/2) - sh(x/2))
    /// Область определения данной функции симметрична относительно нуля
    /// В действительности, она определена везде, кроме Х = +-2.12255012381007
    /// http://www.wolframalpha.com/input/?i=ch%28x%2F2%29+-+sh%28x%2F2%29+%3D+0
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_112_1_exp_ch_sh_in", "f(x) = e^x – (ch(x/2) + sh(x/2)) / (ch(x/2) - sh(x/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_112_1_exp_ch_sh_in
    {
        public static string L00_112_1_exp_ch_sh_in()   
        {
            string str = "(0, 2.1226) (2.1226, w)";
            return str;
        }
    }

    /// <summary>
    /// Реализует 113.​ f(x) = (ch(x/2) + sh(x/2))/ (ch(x/2) - sh(x/2)) - (1 + th(x/2))/(1 – th(x/2))
    /// </summary>
    /// <param name="arg">Аргумент X</param>
    /// <returns>0</returns>
    [OpaqueFunction()]
    [FunctionName("L00_113_1_ch_sh_th", "f(x) = (ch(x/2) + sh(x/2))/ (ch(x/2) - sh(x/2)) - (1 + th(x/2))/(1 – th(x/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_113_1_ch_sh_th
    {
        public static double L00_113_1_ch_sh_th(double arg)
        {
            double X, ch, sh, th;
            ch = Math.Cosh(arg / 2);
            sh = Math.Sinh(arg / 2);
            th = Math.Tanh(arg / 2);

            X = (ch + sh) / (ch - sh) - (1 + th) / (1 - th);
            return X;
        }
    }

    /// <summary>
    /// Возвращает область определения 113.​ f(x) = (ch(x/2) + sh(x/2))/ (ch(x/2) - sh(x/2)) - (1 + th(x/2))/(1 – th(x/2))
    /// Область определения данной функции симметрична относительно нуля
    /// В действительности, она определена везде, кроме Х = +-2.12255012381007
    /// http://www.wolframalpha.com/input/?i=ch%28x%2F2%29+-+sh%28x%2F2%29+%3D+0
    /// </summary>
    /// <returns>string</returns>
    [OpaqueFunction()]
    [FunctionName("L00_113_1_ch_sh_th_in", "f(x) = (ch(x/2) + sh(x/2))/ (ch(x/2) - sh(x/2)) - (1 + th(x/2))/(1 – th(x/2))")]
    [EquivalentIntConstant(0)]
    public static class CL00_113_1_ch_sh_th_in
    {
        public static string L00_113_1_ch_sh_th_in()
        {
            string str = "(0, 2.1226) (2.1226, w)";
            return str;
        }
    }


    /* 
      todo list
    
        тесты   
    



     done list
      
       количество аргументов
       - циклы
       описание функций
       все области определения 
     тесты 86 - 90
    */
}

