using System;

namespace CSharp
{
    class Program
    {
        static int Factorial(int a)
        {
            //5
            int result = 1;
            for(int i = a; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }
        static void Main(string[] args)
        {
            // 1. 구구단 출력
            for(int i = 2; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + i*j);
                }
            }

            // 2. 별찍기
            // ver1
            for(int i = 0; i < 5; i++)
            {
               for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            // ver2
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i < j)
                        continue;
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // 3. Fctorial 함수 만들기
            int result = Factorial(5);
            Console.WriteLine(result);

            //

        }
    }
}