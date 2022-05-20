using System;

namespace CSharp
{
    class Program
    {
        // Method / Function(함수)
        // 한정자 반환형식 이름(매개변수목록)
        static void HelloWorld()
        {
            Console.WriteLine("Hellow World");
        }

        // 덧셈 함수
        // 함수 오버로딩, 함수 이름의 재사용
        // 반환형식은 오버로딩 구분에 들어가지 않음
        static int Add(int firstNum, int seconNum)
        {
            Console.WriteLine("Add int호출");
            return firstNum + seconNum;
        }

        static float Add(float firstNum, float seconNum)
        {
            Console.WriteLine("Add float호출");
            return firstNum + seconNum;
        }

        static void AddOne(ref int a)
        {
            a++;
        }

        static void Divide(int a, int b, out int c, out int d)
        {
            c = a / b;
            d = a % b;
        }



        static void Main(string[] args)
        {
            HelloWorld();
            int total = Add(5, 10);
            Console.WriteLine(total);
            Console.WriteLine(Add(6,7));

            //----------------------
            int a = 0;
            AddOne(ref a);
            Console.WriteLine(a);

            //----------------------
            int c = 10;
            int d = 3;

            int result1;
            int result2;

            Divide(c, d, out result1, out result2);

            Console.WriteLine(result1);
            Console.WriteLine(result2);

            //
            int ret = Add(4, 7);
            Console.WriteLine(ret);

            float ret2 = Add(2.1f, 3.0f);
            Console.WriteLine(ret2);

            Console.WriteLine("8888888888888888888888888");
            Console.WriteLine(3 + 3.1f);
         }
    }
}