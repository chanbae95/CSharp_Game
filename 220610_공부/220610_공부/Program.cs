using System;

namespace CSharp
{
    class Play
    {
        string[,] map = new string[10, 10];
        int playerX = 5;
        int playerY = 1;

        public void SetUp()
        {    
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for(int j = 0; j < map.GetLength(1); j++)
                {
                    if (i == 0 || i == 9)
                        this.map[i, j] = "벽";
                    if (j == 0 || j == 9)
                        this.map[i, j] = "벽";
                    if (map[i, j] != "벽")
                        this.map[i, j] = "땅";

                }
            }

            this.map[playerX, playerY] = "★";
            
        }

        public void Render()
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i,j]);
                }
                Console.WriteLine();
            }


        }

        public void PlayerMove()
        {
            Console.WriteLine("w : 위로 a : 왼쪽 s : 아래 d : 오른쪽");
            string input = Console.ReadLine();
            Console.Clear();
            switch (input)
            {
                case "w":
                    if (map[playerX -1,playerY] != "벽")
                    {
                        this.map[playerX, playerY] = "땅";
                        this.playerX -= 1;
                        this.map[playerX, playerY] = "★";
                    }
                    break;
                case "a":
                    if(map[playerX, playerY-1] != "벽")
                    {
                        this.map[playerX, playerY] = "땅";
                        this.playerY -= 1;
                        this.map[playerX, playerY] = "★";
                    }
                    break;
                case "s":
                    if (map[playerX + 1, playerY] != "벽")
                    {
                        this.map[playerX, playerY] = "땅";
                        this.playerX += 1;
                        this.map[playerX, playerY] = "★";
                    }
                    break;
                case "d":
                    if(map[playerX, playerY +1 ] != "벽")
                    {
                        this.map[playerX, playerY] = "땅";
                        this.playerY += 1;
                        this.map[playerX, playerY] = "★";
                    }
                    break;
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Play play = new Play();

            play.SetUp();
            while (true)
            {
                play.Render();
                play.PlayerMove();
            }
            

        }
    }
}