using System;

namespace CSharp
{
    class Program
    {
        static int SelectJop()
        {
            
            Console.WriteLine("직업을 선택하세요");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");

            int jop = Convert.ToInt32(Console.ReadLine());
            if(jop <= 0 || jop >= 4)
            {
                Console.WriteLine("선택을 다시 확인해 주세요");
                SelectJop();

            }

            return jop;
        }

        static void Main(string[] args)
        {
            int MyJop = SelectJop();
            
        }
    }
}