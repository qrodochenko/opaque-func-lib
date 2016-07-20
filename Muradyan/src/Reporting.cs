using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace TestingSystem
{
    /// <summary>
    /// Представляет запись в отчёте
    /// </summary>
    public class ReportEntry
    {
        /// <summary>
        /// Имя функции
        /// </summary>
        public string FunctionName;
        /// <summary>
        /// Файл, в котором функция была обнаружена
        /// </summary>
        public string FileName;
        /// <summary>
        /// Число итераций для тестируемого метода (N)
        /// </summary>
        public int NumberOfIterations;
        /// <summary>
        /// Массив аргументов для функции
        /// </summary>
        public double[] Arguments;
        /// <summary>
        /// Массив параметров для функции
        /// </summary>
        public double[] Parameters;
        /// <summary>
        /// Значение, которое получилось в результате тестирования
        /// </summary>
        public double Val;
        /// <summary>
        /// Значение, которое вернула образцовая функция или другой "идеальный" метод
        /// </summary>
        public double WantedVal;
        /// <summary>
        /// Абсолютная погрешность вычисления
        /// </summary>
        public double AbsoluteEps;
        /// <summary>
        /// Относительная погрешность вычисления
        /// </summary>
        public double RelativeEps;

        /// <summary>
        /// Создаёт новую запись отчёта
        /// </summary>
        /// <param name="evaluateEps">Если установлен, то погрешности вычисляются сами</param>
        /// <param name="functionName">Имя тестируемой функции</param>
        /// <param name="fileName">Файл, в котором находится тестируемая функция</param>
        /// <param name="N">Количество итераций для тестируемого метода</param>
        /// <param name="args">Аргументы функции</param>
        /// <param name="param">Параметры функции</param>
        /// <param name="val">Тестируемое значение</param>
        /// <param name="wantedVal">Идеальное значение</param>
        /// <param name="absEps">Абсолютная погрешность вычислений</param>
        /// <param name="relEps">Относительна погрешность вычислений</param>
        public ReportEntry(
            bool evaluateEps = true,
            string functionName = "NONAME",
            string fileName = "NOFILE",
            int N = -1,
            double[] args = null,
            double[] param = null,
            double val = double.NaN,
            double wantedVal = double.NaN,
            double absEps = double.NaN,
            double relEps = double.NaN)
        {
            Arguments = args ?? new double[0];
            Parameters = param ?? new double[0];
            FunctionName = functionName;
            FileName = fileName;
            NumberOfIterations = N;
            Val = val;
            WantedVal = wantedVal;

            if (evaluateEps)
            {
                AbsoluteEps = Math.Abs(wantedVal - val);
                RelativeEps = AbsoluteEps / Math.Abs(WantedVal);
            }
            else
            {
                AbsoluteEps = absEps;
                RelativeEps = relEps;
            }
        }

        /// <summary>
        /// Преобразует запись в строку
        /// </summary>
        /// <param name="fieldsSeparator">Разделитель полей записи</param>
        /// <param name="argparamSeparator">Разделитель аргументов и параметров в соответствующих полях</param>
        /// <param name="argnum">Количество аргументов, под которые надо выделить место</param>
        /// <param name="parnum">Количество параметров, под которые надо выделить место</param>
        /// <param name="forCSV">Указывает, надо ли выставлять кавычки перед и после текстовых полей</param>
        /// <returns></returns>
        public string ToString(string fieldsSeparator = " ", string argparamSeparator = ", ", int argnum = 1, int parnum = 0, bool forCSV = false)
        {
            //var joinedargs = Arguments.Take.Aggregate("",(res, cur) => "" + res + ", " + cur.ToString("G5"), (res) => res);
            //var joinedparam = Parameters.Aggregate("", (res, cur) => "" + res + ", " + cur.ToString("G5"), (res) => res);
            var dotOption = CultureInfo.CreateSpecificCulture("ru-RU");


            string joinedargs = Arguments.Length == 0 ? "" : Arguments[0].ToString("G5", dotOption),
                   joinedparam = Parameters.Length == 0 ? "" : Parameters[0].ToString("G5", dotOption);
            for (int i = 1; i < Arguments.Length; ++i)
            {
                joinedargs += argparamSeparator + Arguments[i].ToString("G5", dotOption);
            }
            for (int i = 1; i < Parameters.Length; ++i)
            {
                joinedparam += argparamSeparator + Parameters[i].ToString("G5", dotOption);
            }

            return string.Format(dotOption,
                getFormatString(argnum, parnum, fieldsSeparator, forCSV),
                FunctionName + "(" + FileName + ")",
                NumberOfIterations,
                joinedargs,
                joinedparam,
                Val,
                WantedVal,
                AbsoluteEps,
                RelativeEps);
        }

        /// <summary>
        /// Получает строчку CSV-файла из данной записи
        /// </summary>
        /// <returns></returns>
        public string GetCSVLine()
        {
            return ToString(";", "|", forCSV: true);
        }

        /// <summary>
        /// Получает строку формата необходимго вида
        /// </summary>
        /// <param name="fieldsSeparator">Разделитель полей записи</param>
        /// <param name="argnum">Количество аргументов, под которые надо выделить место</param>
        /// <param name="parnum">Количество параметров, под которые надо выделить место</param>
        /// <param name="forCSV">Указывает, надо ли выставлять кавычки перед и после текстовых полей</param>
        /// <returns></returns>
        public static string getFormatString(int argnum = 1, int parnum = 0, string fieldsSeparator = " ", bool forCSV = false)
        {
            string q = forCSV ? "\"" : "";
            return q + "{0,30}" + q + fieldsSeparator +
                "{1,5}" + fieldsSeparator +
                "{2," + (argnum * 7) + "}" + fieldsSeparator +
                "{3," + (parnum * 7) + "} " + fieldsSeparator +
                "{4,9:G4} " + fieldsSeparator +
                "{5,9:G4}" + fieldsSeparator +
                "{6,9:G4}" + fieldsSeparator +
                "{7,9:G4}\n";
        }
    }

    /// <summary>
    /// Класс, представляющий отчёт тестирования
    /// </summary>
    public class Report : List<ReportEntry>
    {
        /// <summary>
        /// Получает строку формата необходимго вида
        /// </summary>
        /// <param name="argnum">Количество аргументов, под которые надо выделить место</param>
        /// <param name="parnum">Количество параметров, под которые надо выделить место</param>
        /// <param name="forCSV">Указывает, надо ли выставлять кавычки перед и после текстовых полей</param>
        /// <returns></returns>
        public static string getFormatString(int argnum = 1, int parnum = 0, bool forCSV = false)
        {
            string q = forCSV ? "\"" : "";
            string dq = q + (forCSV ? ";" : " ") + q;
            return q + "{0,30}" + dq + "{1,5}" + dq + "{2," + (argnum * 7) + "}" + dq + "{3," + (parnum * 7) + "}" + dq +
                "{4,9}" + dq + "{5,9}" + dq + "{6,9}" + dq + "{7,9}" + q + "\n";
        }

        /// <summary>
        /// Получает строку заголовка необходимго вида
        /// </summary>
        /// <param name="argnum">Количество аргументов, под которые выделяется место в основной таблице</param>
        /// <param name="parnum">Количество параметров, под которые выделяется место в основной таблице</param>
        /// <param name="forCSV">Указывает, надо ли выставлять кавычки перед и после текстовых полей</param>
        /// <returns></returns>
        public static string getTitleString(int argnum = 1, int parnum = 0, bool forCSV = false)
        {
            return string.Format(
                getFormatString(argnum, parnum, forCSV),
                "Function", "N", "Args", parnum == 0 ? "" : "Params", "Val", "Ideal", "Abs", "Rel");
        }

        /// <summary>
        /// Преобразует отчёт в строку для печати на консоль
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            int maxArgs = 0, maxParams = 0;
            foreach (var entry in this)
            {
                maxArgs = Math.Max(maxArgs, entry.Arguments.Length);
                maxParams = Math.Max(maxParams, entry.Parameters.Length);
            }

            string title = getTitleString(maxArgs, maxParams);
            StringBuilder resultingStr = new StringBuilder(title);
            foreach (var entry in this)
            {
                resultingStr.Append(entry.ToString(argnum: maxArgs, parnum: maxParams));
            }
            return resultingStr.ToString();
        }

        /// <summary>
        /// Созраняет отчёт в CSV-файл по указанному пути
        /// </summary>
        /// <param name="path">Путь к файлу отчёта</param>
        public void SaveCSV(string path)
        {
            string title = getTitleString(forCSV: true);
            StringBuilder resultingStr = new StringBuilder(title);
            foreach (var entry in this)
            {
                resultingStr.Append(entry.GetCSVLine());
            }
            var resStr = resultingStr.ToString();
            var file = new StreamWriter(path);

            file.WriteLine(resStr);
            file.Close();
        }

        /// <summary>
        /// Возвращает максимальную абсолютную погрешность среди всех записей данного отчёта
        /// </summary>
        /// <returns></returns>
        public double maxEpsilonAbsolute()
        {
            return this.Max((entry) => entry.AbsoluteEps);
        }

        /// <summary>
        /// Возвращает максимальную относительную погрешность среди всех записей данного отчёта
        /// </summary>
        /// <returns></returns>
        public double maxEpsilonRelative()
        {
            return this.Max((entry) => entry.RelativeEps);
        }
    }
}