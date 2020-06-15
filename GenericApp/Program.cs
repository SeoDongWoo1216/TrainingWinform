using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    public class SimpleGeneric<T>
    {
        private T[] values; // T타입(아무 자료형)의 배열 생성
        private int index;
        public SimpleGeneric(int len)  // 생성자 생성
        {
            values = new T[len];
            index = 0;
        }
        public void Add(params T[] args)
        {
            foreach (T item in args)  // foreach적고 탭 두번누르면 형식이 자동 완성
            {
                values[index++] = item;
            }
        }
        public void Print()
        {
            foreach(T item in values)
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
            SimpleGeneric<Int32> gInteger = new SimpleGeneric<Int32>(10); // 크기가 10인 배열 생성
            SimpleGeneric<Double> gDouble = new SimpleGeneric<Double>(10);
            // 자료형에따라 클래스는 몇개씩 만들던게 1개로 통일해서 쓸 수 있다.
            // 소스코드가 줄어들고 중복이 줄어든다.

            gInteger.Add(1, 2);
            gInteger.Add(1, 2, 3, 4, 5, 6, 7);
            gInteger.Add(0);
            gInteger.Add(1, 2);

            gDouble.Add(10.0, 20.0, 30.0);
            gInteger.Print();
            gDouble.Print();
        }
    }
}
