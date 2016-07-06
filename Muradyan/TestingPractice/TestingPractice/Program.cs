#define TEST_TAYLOR

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTest
{
    delegate double TaylorFunc(double x, int N, TaylorTestingEntry tst);

    class Utility {
        public static void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }
        public static void SwapArr<T>(ref System.Collections.Generic.List<T> array, int ind1, int ind2)
        {
            T t = array[ind1];
            array[ind1] = array[ind2];
            array[ind2] = t;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {/*
            Heap h = new Heap();
            int sgn = 1;
            double s = 0;
            for(int i=1; i<=10000000; ++i)
            {
                h.AddElem(sgn*1.0 / i);
                s += sgn*1.0 / i;
                sgn = -sgn;
            }
            Console.WriteLine(h.Sum() + " " + s);
            Console.ReadKey();
            */
            TaylorTestingEntry t = new TaylorTestingEntry();
            TaylorFunc f = TaylorFuncTest.Sin;
            Console.WriteLine(t.TestFunction(f, 1000000, 1e-10, -1, 1, 20));
            Console.ReadKey();
        }
    }

    class Heap
    {
        private int elnum = 0;
        private List<double> ar = new List<double>();

        public static bool less (double a, double b)
        {
            return (Math.Abs(a) < Math.Abs(b));
        }
        public static bool more (double a, double b)
        {
            return (Math.Abs(a) > Math.Abs(b));
        }
        public static bool lesseq (double a, double b)
        {
            return (Math.Abs(a) <= Math.Abs(b));
        }
        public static bool moreeq (double a, double b)
        {
            return (Math.Abs(a) >= Math.Abs(b));
        }

        private void Heapify(int index = 1)
        {
            int l = index << 1;
            int r = l + 1;

            if (index > elnum || l > elnum )
            {
                return;
            }
            else
            {
                if( r > elnum)
                {
                    if (less(ar[l-1] , ar[index-1]))
                        Utility.SwapArr(ref ar, l-1, index-1);
                }
                else
                {
                    if ( lesseq(ar[index-1], ar[r-1]) && lesseq(ar[index-1],ar[l-1]) )
                        return;
                    if( less(ar[r-1],ar[l-1]) )
                    {
                        Utility.SwapArr(ref ar, r-1, index-1);
                        Heapify(r);
                    }
                    else{
                        Utility.SwapArr(ref ar, l-1, index-1);
                        Heapify(l);
                    }
                }
            }
        }

        private double ExtractMin()
        {
            double m = ar[0];
            ar[0] = ar[--elnum];
            ar.RemoveAt(elnum);
            Heapify();
            return m;
        }
        
        private void AddTwoMin()
        {
            double m = ExtractMin();
            m += ExtractMin();
            //Console.WriteLine(m);
            elnum++;
            ar.Add(m);
            int cn = elnum;
            int p = cn >> 1;
            while(p > 0 && more(ar[p-1],ar[cn-1]) )
            {
                Utility.SwapArr<double>(ref ar, p - 1, cn - 1);
                cn = p;
                p = p >> 1;
            }
        }

        public void Clear()
        {
            ar.Clear();
            elnum = 0;
        }

        public double Sum()
        {
            for(int i=elnum>>1; i>=1; --i)
            {
                Heapify(i);
            }
            while (elnum > 1) AddTwoMin();
            return ar[0];
        }

        public void ChangeArray(ref List<double> a)
        {
            ar = a;
            elnum = a.Count();
        }

        public void AddElem(double el)
        {
            //Console.WriteLine(elnum);
            ar.Add(el);
            ++elnum;
        }

    }

    class TaylorTestingEntry
    {
        private Heap h = new Heap();
        //private double eps;

        public void AddElement(double el)
        {
            h.AddElem(el);
        }

        public String MatchResult(double res, double eps)
        {
            double sum = h.Sum();
            double current_eps = Math.Abs(res - sum);
            h.Clear();
            if (current_eps <= eps)
                return "OK";
            else return "Error, mistake is " + current_eps;
        }

        public string TestFunction(TaylorFunc f, int N, double eps, double l, double r, int pointsNumber)
        {

            Random rand = new Random();
            String res = "Testing...\n";
            for(int i=0; i<pointsNumber; ++i)
            {
                double arg = l + rand.NextDouble() * (r - l);
                double val = f(arg, N, this);
                res += "f(" + arg + ") = " + val + " : " + MatchResult(val, eps) + "\n";

            }
            return res;
        }
    }

    class TaylorFuncTest
    {
        static public double Sin(double x, int N
                            #if TEST_TAYLOR
                                , TaylorTestingEntry  tst
                            #endif
            )
        {
            double s = 0.0;
            double k = x;
            x *= x;
            long t;
            int sgn = 1;
            for(int i=1; i < N; ++i)
            {
                s += k;
                #if TEST_TAYLOR
                    tst.AddElement(k);
                #endif
                k *= x;
                sgn = -sgn;
                k *= sgn;
                t = i << 1;
                k /= t * (t + 1);
            }

            return s;
        }
    }

    class TaylorTestingUnit
    {
        private List<TaylorTestingEntry> entries = new List<TaylorTestingEntry>();

        
    }
}
