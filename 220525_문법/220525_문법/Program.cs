using System;

namespace CSharp
{

    class Knight
    {
        public int hp;
        public int attack;

        //생성자
        public Knight()
        {
            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출");
        }

        public Knight(int hp) : this()
        {
            this.hp = hp;
            Console.WriteLine("int 생성자 호출");
        }

        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = this.hp;
            knight.attack = this.attack;
            return knight;
        }

        public void Move()
        {
            Console.WriteLine("Knight Move");
        }

        public void Attack()
        {
            Console.WriteLine("Knight Acttack");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Knight knight2 = new Knight(50);


        }
    }
}