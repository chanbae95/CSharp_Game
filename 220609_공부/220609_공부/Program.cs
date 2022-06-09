using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] fff = new int[2];
            //fff[0] = 1;
            //fff[1] = 333333;


            //for (int i = 0; i < fff.Length; i++)
            //{
            //    if (fff[i] == 0)
            //        fff[i] = Convert.ToInt32(Console.ReadLine());


            //}
            //for(int i = 0; i < fff.Length; i++)
            //{
            //    Console.WriteLine(fff[i]);
            //}


            //string[] ccc = new string[2];
            //for(int j = 0; j < 2; j++)
            //{
            //    Console.WriteLine(ccc[j]);
            //}


            ////for (int j = 0; j < 5; j++)
            ////{

            ////    for (int i = 0; i < 5; i++)
            ////    {
            ////        if(asd[j, i] == 0);
            ////    }

            ////}

            //for (int j = 0; j < 5; j++)
            //{

            //    for(int i = 0; i < 5; i++)
            //    {
            //        Console.Write(asd[j,i]);
            //    }
            //    Console.WriteLine();
            //}


            int[,] asd = new int[5, 5];

            //asd[0, 0] = 1;
            //asd[1, 1] = 2;
            //asd[2, 2] = 3;
            //asd[3, 3] = 4;
            //asd[4, 4] = 5;

            for (int i = 0; i < asd.GetLength(0); i++)
            {
                for (int j = 0; j < asd.GetLength(1); j++)
                {
                   asd[i, j] = 1;

                }
            }

            for (int i = 0; i < asd.GetLength(0); i++)
            {
                for (int j = 0; j < asd.GetLength(1); j++)
                {
                    if(i == 0 || i == 4)
                    {
                        asd[i, j] = 0;
                    }
                    if(j == 4 || j == 0)
                    {
                        asd[i, j] = 0;
                    }

                }
            }

            for (int i = 0; i < asd.GetLength(0); i++)
            {
                for(int j = 0; j < asd.GetLength(1); j++)
                {
                    Console.Write(asd[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}