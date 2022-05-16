using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0 : 가위 1 : 바위 2 : 보
            Random rand = new Random();
            int aiChoice = rand.Next(0, 3); // 0~2사이 랜덤값

            Console.WriteLine("0 : 가위 / 1 : 바위 / 2 : 보");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                
                case 0:
                    Console.WriteLine("당신의 선택은 가위 입니다.");
                    break;
                case 1:
                    Console.WriteLine("당신의 선택은 바위 입니다.");
                    break;
                case 2:
                    Console.WriteLine("당신의 선택은 보 입니다.");
                    break;

            }

            switch (aiChoice)
            {

                case 0:
                    Console.WriteLine("컴퓨터의 선택은 가위 입니다.");
                    break;
                case 1:
                    Console.WriteLine("컴퓨터의 선택은 바위 입니다.");
                    break;
                case 2:
                    Console.WriteLine("컴퓨터의 선택은 보 입니다.");
                    break;
            }

            // 승리 무승부 패배

            if(choice == aiChoice)
            {
                Console.WriteLine("무승부 입니다.");
            }
            else if(choice == 0 && aiChoice == 2)
            {
                Console.WriteLine("컴퓨터를 이겼습니다.");
            }
            else if (choice == 1 && aiChoice == 0)
            {
                Console.WriteLine("컴퓨터를 이겼습니다.");
            }
            else if (choice == 2 && aiChoice == 1)
            {
                Console.WriteLine("컴퓨터를 이겼습니다.");
            }
            else
            {
                Console.WriteLine("컴퓨터에게 패배했습니다.");
            }
        }


    }
}