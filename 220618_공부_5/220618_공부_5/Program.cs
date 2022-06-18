using System;

namespace CSharp
{
    class Program
    {
        static int Find()
        {

            return 0;
        }

        static void Main(string[] args)
        {
            //Nullable 

            int? number = null;

            // number값이 null이 아니면 number값이 들어가고, null이면 0값이 들어감
            int b = number ?? 0;

            //number = 3;
            int a = number.Value;

            Console.WriteLine(a);
        }
    }
}