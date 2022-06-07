using System;

namespace CSharp
{
    class Program
    {
        class Map
        {
            int[,] tiles = {
                { 1, 1, 1, 1, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 1 },
                { 1, 1, 1, 1, 1 }
            };

            public void Render()
            {
                var defaultColor = Console.ForegroundColor;

                for(int y = 0; y < tiles.GetLength(1); y++)
                {
                    for(int x = 0; x < tiles.GetLength(0); x++)
                    {
                        if (tiles[x, y] == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else
                            Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write('\u25cf');
                    }
                    Console.WriteLine();
                }

                Console.ForegroundColor = defaultColor;
            }
        }
        static void Main(string[] args)
        {
            // 배열
            //int[] scores = new int[5] { 10, 30, 40, 50, 20 };

            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };


            //int[,] arr2 = new int[2, 3];
            //arr2[0, 0] = 1;

            Map map = new Map();
            map.Render();

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]);
                }
                Console.WriteLine();
            }


        }
    }
}