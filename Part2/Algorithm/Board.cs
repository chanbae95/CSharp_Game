using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Board
    {
        const char CIRCLE = '\u25cf';
        public Tiletype[,] Tile { get; private set; }
        public int Size { get; private set; }

        public int DestY { get; private set; }
        public int DestX { get; private set; }

        Player _player;

        public enum Tiletype
        {
            Empty,
            Wall,
        }
        public void Initialize(int size, Player player)
        {
            if (size % 2 == 0)
                return;

            _player = player;

            Tile = new Tiletype[size, size];
            Size = size;

            DestY = size - 2;
            DestX = size - 2;

            //GenerateByBinaryTree();            
            GenerateBySideWinder();
        }

        public void Rendor()
        {
            ConsoleColor precolor = Console.ForegroundColor;

            for (int y = 0; y < Size; y++)
            {
                for (int x = 0; x < Size; x++)
                {
                    // 플에이어
                    if(y == _player.PosY && x == _player.PosX)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if(y == DestY && x == DestX)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = GetTileColor(Tile[y, x]);
                    }

                    Console.Write(CIRCLE);
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = precolor;
        }

        ConsoleColor GetTileColor(Tiletype type)
        {
            switch (type)
            {
                case Tiletype.Empty:
                    return ConsoleColor.Green;
                case Tiletype.Wall:
                    return ConsoleColor.Red;
                default:
                    return ConsoleColor.Green;
            }

        }

        public void GenerateByBinaryTree()
        {
            //길을 다 막아버리는 작업
            for (int y = 0; y < Size; y++)
            {
                for (int x = 0; x < Size; x++)
                {
                    if (y % 2 == 0 || x % 2 == 0)
                    {
                        Tile[y, x] = Tiletype.Wall;
                    }
                    else
                    {
                        Tile[y, x] = Tiletype.Empty;
                    }
                }
            }

            //랜덤으로 우측 혹은 아래로 길 뚫는 작업
            //Binary Tree Algorithm
            Random random = new Random();
            for (int y = 0; y < Size; y++)
            {
                for (int x = 0; x < Size; x++)
                {
                    if (y % 2 == 0 || x % 2 == 0)
                        continue;
                    if (y == Size - 2 && x == Size - 2)
                        continue;

                    if (y == Size - 2)
                    {
                        Tile[y, x + 1] = Tiletype.Empty;
                        continue;
                    }

                    if (x == Size - 2)
                    {
                        Tile[y + 1, x] = Tiletype.Empty;
                        continue;
                    }

                    if (random.Next(0, 2) == 0)
                    {
                        Tile[y, x + 1] = Tiletype.Empty;
                    }
                    else
                    {
                        Tile[y + 1, x] = Tiletype.Empty;
                    }
                }
            }
        }

        public void GenerateBySideWinder()
        {
            //길을 다 막아버리는 작업
            for (int y = 0; y < Size; y++)
            {
                for (int x = 0; x < Size; x++)
                {
                    if (y % 2 == 0 || x % 2 == 0)
                    {
                        Tile[y, x] = Tiletype.Wall;
                    }
                    else
                    {
                        Tile[y, x] = Tiletype.Empty;
                    }
                }
            }

            //랜덤으로 우측 혹은 아래로 길 뚫는 작업
            //Binary Tree Algorithm
            Random random = new Random();
            for (int y = 0; y < Size; y++)
            {
                int count = 1;
                for (int x = 0; x < Size; x++)
                {
                    if (y % 2 == 0 || x % 2 == 0)
                        continue;

                    if (y == Size - 2 && x == Size - 2)
                        continue;

                    if (y == Size - 2)
                    {
                        Tile[y, x + 1] = Tiletype.Empty;
                        continue;
                    }

                    if (x == Size - 2)
                    {
                        Tile[y + 1, x] = Tiletype.Empty;
                        continue;
                    }


                    if (random.Next(0, 2) == 0)
                    {
                        Tile[y, x + 1] = Tiletype.Empty;
                        count++;
                    }
                    else
                    {
                        int randomIndex = random.Next(0, count);
                        Tile[y + 1, x - randomIndex * 2] = Tiletype.Empty;
                        count = 1;
                    }
                }
            }
        }
    }
}
