using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    public class SimpleGeneric<T>
    {
        private T[] values;
        private int index;

        public SimpleGeneric(int len)
        {
            values = new T[len];
            index = 0;
        }

        public void Add(params T[] args)
        {
            foreach (T item in args)
            {
                values[index++] = item;
            }
        }

        public void Print()
        {
            foreach (T item in values)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            SimpleGeneric<Int32> gInterger = new SimpleGeneric<int>(10);
            SimpleGeneric<Double> gDouble = new SimpleGeneric<Double>(10);

            gInterger.Add(1, 2);
            gInterger.Add(1, 2, 3, 4, 5, 6, 7);
            gInterger.Add(0);
            gInterger.Print();

            gDouble.Add(10.0, 20.0, 30.0);
            gDouble.Print();





        }
    }
}
