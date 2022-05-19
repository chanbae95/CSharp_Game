using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 5;

            while (count > 0)
            {
                Console.WriteLine("HW");
                count--;
            }
            Console.WriteLine(count);


            string answer;

            do
            {
                Console.WriteLine("강사님은 잘생기셨나요? (y/n) : ");
                answer = Console.ReadLine();
            } while (answer != "y");
            Console.WriteLine("정답입니다.");

            int num = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            for(int i = 2; i < num; i++)
            {
                if(num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine(num + "은 소수 입니다.");
            }
            else
            {
                Console.WriteLine(num + "은 소수가 아닙니다.");
            }

            for(int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                    continue;

                Console.WriteLine(i + "는 3의 배수 입니다.");
            }


        }
    }
}