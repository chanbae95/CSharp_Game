using System;

namespace TextRPG3
{
    class Program
    {
        static void Main(string[] args)
        {
            Game GameMain = new Game();

            while (true)
            {
                GameMain.GameProcess();
            }
            

        }
    }
}