using System;

namespace CSharp
{
    class Program
    {
        static void OnInputTest()
        {
            Console.WriteLine("input received");
        }

        static void Main(string[] args)
        {
            inputManager inputManager = new inputManager();

            inputManager.InputKey += OnInputTest;

            while (true)
            {
                inputManager.Update();
            }

        }
    }
}