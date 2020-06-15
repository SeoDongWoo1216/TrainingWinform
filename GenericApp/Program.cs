using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    public class SimpleGeneric<T>
    {
        private T[] values;  // T타입(아무 타입이 가능한)의 배열 생성
        private int index;

        public SimpleGeneric(int len)  // 클래스 안에서 Alt + 엔터를 누르면 생성자를 생성할 수 있다.
        {
            values = new T[len];
            index = 0;
        }

        public void Add(params T[] args)
        {
            foreach (T item in args)  // foreach를 쓰고 탭 두번누르면 형식이 자동으로 완성된다
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

            gDouble.Add(10.0, 20.0, 30.0)
            gDouble.Print();
        }
    }
}
