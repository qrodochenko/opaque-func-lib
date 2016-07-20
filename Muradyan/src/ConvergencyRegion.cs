using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Collections.Generic;

namespace TestingSystem
{
    /// <summary>
    /// Класс, представляющий n-мерную точку
    /// </summary>
    public class Point
    {
        /// <summary>
        /// Координаты точки
        /// </summary>
        public double[] coords;

        /// <summary>
        /// Задаёт точку её размерностью и значением каждой координаты
        /// </summary>
        /// <param name="n">Размерность пространства</param>
        /// <param name="defaultVal">Значение каждой координаты точки</param>
        public Point(int n, double defaultVal = 0)
        {
            coords = new double[n];
            for (int i = 0; i < n; ++i)
            {
                coords[i] = defaultVal;
            }
        }

        /// <summary>
        /// Конструктор копии
        /// </summary>
        /// <param name="pt">Точка для копирования</param>
        public Point(Point pt)
        {
            coords = new double[pt.coords.Length];
            Array.Copy(pt.coords, coords, coords.Length);
        }

        /// <summary>
        /// Позволяет получить i-ю координату точки
        /// </summary>
        /// <param name="i">Номер координаты</param>
        /// <returns>Значение координаты</returns>
        public double this[int i]
        {
            get
            {
                return coords[i];
            }
            set
            {
                coords[i] = value;
            }
        }
    }

    /// <summary>
    /// Пробегает по всем узлам квадратной сетки некоторой
    /// области в виде параллелепипеда произвольной размерности
    /// </summary>
    public class PointCounter
    {
        /// <summary>
        /// Текущее значение точки
        /// </summary>
        public Point Cur { get; set; }
        Point Offset;
        Interval[] Limits;
        double Incer;

        /// <summary>
        /// Задаёт новый экземляр PointCounter
        /// </summary>
        /// <param name="lim">Массив интевалов, описывающих параллелепипед, в котором расчерчивается сетка</param>
        /// <param name="incer">Длинна стороны кубика сетки</param>
        /// <param name="offset">Начальные значения сдвига сетки относительно левой вершины lim</param>
        public PointCounter(Interval[] lim, double incer, Point offset = null)
        {
            Offset = offset ?? new Point(lim.Length, incer / 2);
            Limits = lim;
            Cur = new Point(lim.Length);
            Incer = incer;
            for (int i = 0; i < lim.Length; ++i)
            {
                Cur[i] = lim[i].left + Offset[i];
            }
        }

        /// <summary>
        /// Переход к следующей точке в сетке
        /// </summary>
        /// <returns>true, если точка Cur корректна. false, если нет (перечислены все точки сетки)</returns>
        public bool inc()
        {
            for (int i = 0; i < Limits.Length; ++i)
            {
                if (Cur[i] + Incer > Limits[i].right)
                {
                    if (i == Limits.Length - 1)
                        return false;
                    Cur[i] = Limits[i].left + Offset[i];
                    continue;
                }
                Cur[i] += Incer;
                break;
            }
            return true;
        }
    }

    /// <summary>
    /// Представляет прямоугольную n-мерную область сходимости
    /// </summary>
    public class ConvergencyRegion
    {
        /// <summary>
        /// Массив интервалов, произведение которых даёт искомую область
        /// </summary>
        public Interval[] Intervals;

        /// <summary>
        /// Инициализирует область массивом интервалов
        /// </summary>
        /// <param name="intervals">Массив интервалов, задающий область</param>
        public ConvergencyRegion(Interval[] intervals)
        {
            Intervals = intervals;
        }

        /// <summary>
        /// Получает размерность области сходимости
        /// </summary>
        /// <returns></returns>
        public int GetDim()
        {
            return Intervals.Length;
        }

        /// <summary>
        /// Получает объём области
        /// </summary>
        /// <returns></returns>
        public double Volume()
        {
            double sq = 1;
            foreach (var interv in Intervals)
            {
                sq *= interv.Length();
            }
            return sq;
        }

        /// <summary>
        /// Получает примерно <paramref name="maxPoints"/> точек области,
        /// находящихся в вершинах квадратной сетки.
        /// Для одномерного случая +-1 точка, для больших размерностей разброс больше
        /// </summary>
        /// <param name="maxPoints"></param>
        /// <returns></returns>
        public List<Point> GetPoints(int maxPoints)
        {
            List<Point> res = new List<Point>();

            double area = Volume();
            double sqArea = area / maxPoints;
            double sqSide = Math.Pow(sqArea, 1 / GetDim());
            PointCounter cnt = new PointCounter(Intervals, sqSide, new Point(GetDim(), sqSide / 2));

            do
            {
                res.Add(new Point(cnt.Cur));
            }
            while (cnt.inc());

            return res;
        }
    }

    /// <summary>
    /// Класс, представляющий интервал
    /// </summary>
    public struct Interval
    {
        /// <summary>
        /// Константа, представляющая самое большое положительное значение для концов интервала
        /// </summary>
        public const double almostInfinity = 10e4;

        /// <summary>
        /// Левый конец интервала
        /// </summary>
        public double left;

        /// <summary>
        /// Правый конец интервала
        /// </summary>
        public double right;

        /// <summary>
        /// Возвращает длину интервала
        /// </summary>
        /// <returns></returns>
        public double Length()
        {
            return right - left;
        }
    }

    //Считаем, что внутри выражений скобок нет
    /// <summary>
    /// Класс, отвечающий за выполнение интервальных методов
    /// </summary>
    public class IntervalMethod
    {
        //TODO:
        //Параметризованные интервалы
        //Замена маленьких идентификаторов на большие

        /// <summary>
        /// По узлу дереву, представлящему интервальный метод, возвращает массив интервалов, представленный этим методом
        /// </summary>
        /// <param name="meth">Узел интервального метода</param>
        /// <returns></returns>
        public static Interval[] Evaluate(MethodDeclarationSyntax meth)
        {
            var methName = meth.Identifier.ValueText;
            var methCode = meth.GetText().ToString();
            string methodResult = "";
            try
            {
                methodResult = CSharpScript.EvaluateAsync<string>(methCode + "\n return " + methName + "();").Result;
            }
            catch (Exception)
            {
                return null;
            }
            var intervalsList = new List<string>();
            int cBracket = 0, oBracket = 0;
            string cS = "";
            foreach (char c in methodResult)
            {
                if (c == '(') ++cBracket;
                else if (c == ')') --cBracket;
                else cS += c;

                if (cBracket == 0 && oBracket == 1)
                {
                    intervalsList.Add(cS);
                    cS = "";
                }
                oBracket = cBracket;
            }
            string[] intervalsStrs = intervalsList.ToArray();

            Interval[] intervals = new Interval[intervalsStrs.Length];

            int k = 0;
            foreach (var interval in intervalsStrs)
            {
                var lnr = interval.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (lnr.Length != 2) throw new Exception();

                double[] corners = new double[2];
                for (int i = 0; i < 2; ++i)
                {
                    var upperText = lnr[i].ToUpper();
                    corners[i] = upperText.IndexOf('W') == -1 ?
                        CSharpScript.EvaluateAsync<double>(upperText, ScriptOptions.Default.WithImports("System.Math")).Result :
                        (i == 0 ? -Interval.almostInfinity : Interval.almostInfinity);

                }
                intervals[k] = new Interval { left = corners[0], right = corners[1] };
                ++k;
            }

            return intervals;
        }
    }
}