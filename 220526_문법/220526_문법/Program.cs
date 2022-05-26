using System;

namespace CSharp
{
    class Player
    {
        static public int counter = 1;
        //static 오로지 1개만 존재!

        public int hp = 10;
        public int attack = 1;
        public int id;

        public Player()
        {
            Console.WriteLine("부모생성자");
        }

    }

    class Mage : Player
    {

    }

    class Archer : Player
    {

    }

    class Knight : Player
    {
        //static public int counter = 1;
        ////static 오로지 1개만 존재!

        //public int hp = 10;
        //public int attack = 1;
        //public int id;

        public Knight(): base()
        {
            base.hp = 555;
            base.attack = 2;
            id = counter;
            counter++;
        }

        static public void Test()
        {
            counter++;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            //Knight knight1 = new Knight();
            //Console.WriteLine(knight1.id);

            //Knight knight2 = new Knight();
            //Console.WriteLine(knight2.id);

            //Knight knight3 = new Knight();
            //Console.WriteLine(knight3.id);

            Knight knight = new Knight();
            Console.WriteLine(knight.hp);

        }
    }
}