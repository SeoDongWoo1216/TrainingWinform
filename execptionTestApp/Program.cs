using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace execptionTestApp
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            int x = 100;
           // int y = 0;
           int y = 5;
            int Value = 0;

            try    // try를 쓰고 탭 두번 눌러주자
            {
                Value = x / y;
                Console.WriteLine("{1} / {2} = {0}", x, y, Value);
                throw new Exception("사용자 에러");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("2. y의 값을 0보다 크게 입력하세요");
            }
            catch (Exception ex)
            {
                Console.WriteLine("3. " + ex.Message);
            }
            finally
            {
                Console.WriteLine("\n4. 프로그램이 종료했습니다.");   // 에러가 있든없든 무조건 실행하는 구문이다
            }
        }
    }
}


/*
            int x = 100;
            int y = 0;
            int Value = 0;
            Value = x / y;
            Console.WriteLine("{1} / {2} = {0}", x, y, Value);
            Console.WriteLine($"{x}/ {y} = value = {Value}");  // 문자열 처리방식
                                                               // 0으로 나누려고했기때문에 컴파일러는 오류로 인식한다.
                                                               // try-catch-finally구문으로 예외처리가 가능하다.
                                                               */
