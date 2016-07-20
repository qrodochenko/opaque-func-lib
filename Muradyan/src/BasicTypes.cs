namespace TestingSystem
{
    /// <summary>
    /// Перечисление видов погрешности
    /// </summary>
    public enum EpsilonType
    {
        /// <summary>
        /// Абслютная погрешность
        /// </summary>
        ABSOLUTE,
        /// <summary>
        /// Относительная погрешность
        /// </summary>
        RELATIVE
    }

    /// <summary>
    /// Класс, представляющий тип метода по количеству аргументов и параметров
    /// </summary>
    public class MethodType
    {
        /// <summary>
        /// Число аргументов метода
        /// </summary>
        public int argnum;

        /// <summary>
        /// Число параметров метода
        /// </summary>
        public int parnum;

        /// <summary>
        /// Самый простой тип - с одним аргументом без параметров
        /// </summary>
        public static MethodType X = new MethodType(1, 0);

        /// <summary>
        /// Представляет неопределённый тип
        /// </summary>
        public const MethodType NOT_DETECTED = null;

        /// <summary>
        /// Инициализирует объект класса MethodType
        /// </summary>
        /// <param name="argnum">Число аргументов</param>
        /// <param name="parnum">Число параметров</param>
        public MethodType(int argnum, int parnum)
        {
            this.argnum = argnum;
            this.parnum = parnum;
        }
    }


    /// <summary>
    /// Тип аргументов, передающихся образцовому методу
    /// </summary>
    public class IdealMethodArgs
    {
        /// <summary>
        /// Массив аргументов метода
        /// </summary>
        public double[] args;
        /// <summary>
        /// Массив параметров метода
        /// </summary>
        public double[] param;
    }

    /// <summary>
    /// Тип аргументов для основоного метода
    /// </summary>
    public class IterMethodArgs : IdealMethodArgs
    {
        /// <summary>
        /// Дополнительно передающееся число итераций
        /// </summary>
        public int N;
    }

}