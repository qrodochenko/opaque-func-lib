using System;

namespace TestingSystem
{

    /// <summary>
    /// Класс предоставляет некоторые дополнительные математические
    /// функции, такие как возведение в квадрат, дополнительные тригонометрические
    /// и гиперболические функции, а также обратные к ним
    /// </summary>
    public static class ExtendedMath
    {
        /// <summary>
        /// Возвращает квадрат указанного аргумента
        /// </summary>
        public static double Sqr(double x)
        {
            return x * x;
        }

        /// <summary>
        /// Возвращает котангенс указанного аргумента
        /// </summary>
        public static double Ctg(double x)
        {
            return 1 / Math.Tan(x);
        }

        /// <summary>
        /// Возвращает косеканс указанного аргумента
        /// </summary>
        public static double Cosec(double x)
        {
            return 1 / Math.Sin(x);
        }

        /// <summary>
        /// Возвращает секанс указанного аргумента
        /// </summary>
        public static double Sec(double x)
        {
            return 1 / Math.Cos(x);
        }

        /// <summary>
        /// Возвращает гиперболический котангенс указанного аргумента
        /// </summary>
        public static double Cth(double x)
        {
            return 1 / Math.Tanh(x);
        }

        /// <summary>
        /// Возвращает гиперболический косеканс указанного аргумента
        /// </summary>
        public static double Csch(double x)
        {
            return 1 / Math.Sinh(x);
        }

        /// <summary>
        /// Возвращает гиперболический секанс указанного аргумента
        /// </summary>
        public static double Sech(double x)
        {
            return 1 / Math.Cosh(x);
        }

        /// <summary>
        /// Возвращает арккотангенс указанного аргумента
        /// </summary>
        public static double Arcctg(double x)
        {
            return Math.PI / 2 - Math.Atan(x);
        }

        /// <summary>
        /// Возвращает арксеканс указанного аргумента
        /// </summary>
        public static double Arcsec(double x)
        {
            return Math.Acos(1 / x);
        }

        /// <summary>
        /// Возвращает арккосеканс указанного аргумента
        /// </summary>
        public static double Arccosec(double x)
        {
            return Math.Asin(1 / x);
        }

        /// <summary>
        /// Возвращает гиперболический арсинус указанного аргумента
        /// </summary>
        public static double Arsh(double x)
        {
            return Math.Log(x + Math.Sqrt(x * x + 1));
        }

        /// <summary>
        /// Возвращает гиперболический аркосинус указанного аргумента
        /// </summary>
        public static double Arch(double x)
        {
            return Math.Log(x + Math.Sqrt(x * x - 1));
        }

        /// <summary>
        /// Возвращает гиперболический артангенс указанного аргумента
        /// </summary>
        public static double Arth(double x)
        {
            return .5 * Math.Log((1 + x) / (1 - x));
        }

        /// <summary>
        /// Возвращает гиперболический аркотангенс указанного аргумента
        /// </summary>
        public static double Arcth(double x)
        {
            return .5 * Math.Log((1 + x) / (x - 1));
        }

        /// <summary>
        /// Возвращает гиперболический арсеканс указанного аргумента
        /// </summary>
        public static double Arsech(double x)
        {
            return Math.Log(1 / x + Math.Sqrt(1 / (x * x) - 1));
        }

        /// <summary>
        /// Возвращает гиперболический аркосеканс указанного аргумента
        /// </summary>
        public static double Arcsch(double x)
        {
            return Math.Log(1 / x + Math.Sqrt(1 / (x * x) + 1));
        }
    }
}