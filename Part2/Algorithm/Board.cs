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
        public Tiletype[,] _tile;
        public int _size;
        public enum Tiletype
        {
            Empty,
            Wall,
        }
        public void Initialize(int size)
        {
            if (size % 2 == 0)
                return;

            _tile = new Tiletype[size, size];
            _size = size;

            //GenerateByBinaryTree();            
            GenerateBySideWinder();
        }
        public void Rendor()
        {
            ConsoleColor precolor = Console.ForegroundColor;

            for (int y = 0; y < _size; y++)
            {
                for (int x = 0; x < _size; x++)
                {
                    Console.ForegroundColor = GetTileColor(_tile[y, x]);
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
            for (int y = 0; y < _size; y++)
            {
                for (int x = 0; x < _size; x++)
                {
                    if (y % 2 == 0 || x % 2 == 0)
                    {
                        _tile[y, x] = Tiletype.Wall;
                    }
                    else
                    {
                        _tile[y, x] = Tiletype.Empty;
                    }
                }
            }

            //랜덤으로 우측 혹은 아래로 길 뚫는 작업
            //Binary Tree Algorithm
            Random random = new Random();
            for (int y = 0; y < _size; y++)
            {
                for (int x = 0; x < _size; x++)
                {
                    if (y % 2 == 0 || x % 2 == 0)
                        continue;
                    if (y == _size - 2 && x == _size - 2)
                        continue;

                    if (y == _size - 2)
                    {
                        _tile[y, x + 1] = Tiletype.Empty;
                        continue;
                    }

                    if (x == _size - 2)
                    {
                        _tile[y + 1, x] = Tiletype.Empty;
                        continue;
                    }

                    if (random.Next(0, 2) == 0)
                    {
                        _tile[y, x + 1] = Tiletype.Empty;
                    }
                    else
                    {
                        _tile[y + 1, x] = Tiletype.Empty;
                    }
                }
            }
        }

        public void GenerateBySideWinder()
        {
            //길을 다 막아버리는 작업
            for (int y = 0; y < _size; y++)
            {
                for (int x = 0; x < _size; x++)
                {
                    if (y % 2 == 0 || x % 2 == 0)
                    {
                        _tile[y, x] = Tiletype.Wall;
                    }
                    else
                    {
                        _tile[y, x] = Tiletype.Empty;
                    }
                }
            }

            //랜덤으로 우측 혹은 아래로 길 뚫는 작업
            //Binary Tree Algorithm
            Random random = new Random();
            for (int y = 0; y < _size; y++)
            {
                int count = 1;
                for (int x = 0; x < _size; x++)
                {
                    if (y % 2 == 0 || x % 2 == 0)
                        continue;

                    if (y == _size - 2 && x == _size - 2)
                        continue;

                    if (y == _size - 2)
                    {
                        _tile[y, x + 1] = Tiletype.Empty;
                        continue;
                    }

                    if (x == _size - 2)
                    {
                        _tile[y + 1, x] = Tiletype.Empty;
                        continue;
                    }


                    if (random.Next(0, 2) == 0)
                    {
                        _tile[y, x + 1] = Tiletype.Empty;
                        count++;
                    }
                    else
                    {
                        int randomIndex = random.Next(0, count);
                        _tile[y + 1, x - randomIndex * 2] = Tiletype.Empty;
                        count = 1;
                    }
                }
            }
        }
    }
}
