using System;

namespace CSharp
{
    class Program
    {
        // 주석
        /* 
        여러줄 주석
         */
        static void Main(string[] args)
        {
            // 정수형식
            // byte(1바이트 0~255), short(2바이트 -3만~3만), int(4바이트 -21억~21억), long(8바이트)
            // sbyte(1바이트 -128~127), ushort(2바이트 0~6만), uint(4바이트 0~43억), ulong(8바이트)zr
            //int hp;
            short level = 100;
            long id;
            //hp = 100;

            byte attack = 0;
            attack--;

            //Console.WriteLine("Hellow Number ! {0}", hp);
           // Console.WriteLine(hp);
            Console.WriteLine(attack);
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hi");
            Console.WriteLine("Bye");

            // 10진수
            // 0 1 2 3 4 5 6 7 8 9 10

            // 2진수
            // 0 ~ 1
            // 0b00 0b01(1) 0b10(2) 0b11(3) 0b100(4)

            // 16진수
            // 0 ~ 9 a b c d e f
            // 0x00 0x01 0x02 .. 0x0F(15) 0x10(16)

            // 2진수 16진수로 변환
            // 0b10001111 => 0x 1000 1111 => 0x8F

            bool b;
            // 1바이트 크기 임(참/거짓)
            b = true;
            b = false;


            // 소수 
            // 4.0 1.3
            float f = 3.14f;
            // 4바이트
            
            double d = 3.14;
            // 8바이트


            char c = 'a';
            // 2바이트

            string str = "Hello World string";


            Console.WriteLine(str);



            int choice = 0; // 0:가위 1:바위 2:보

            if(choice == 0) {
                Console.WriteLine("가위입니다.");
            }
            else if (choice == 1) {
                Console.WriteLine("바위입니다.");
            }
            else {
                Console.WriteLine("보입니다.");
            }

            switch (choice)
            {
                case 0:
                    Console.WriteLine("가위입니다");
                    break;

                case 1:
                    Console.WriteLine("바위입니다.");
                    break;

                case 2:
                    Console.WriteLine("보입니다.");
                    break;

                default:
                    Console.WriteLine("다 실패했습니다");
                    break;

            }


        }
    }
}