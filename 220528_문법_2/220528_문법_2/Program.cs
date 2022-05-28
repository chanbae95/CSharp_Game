using System;

namespace CSharp
{
    class Program
    {
        class Player
        {
            protected int hp;
            protected int attack;

            public virtual void Move()
            {
                Console.WriteLine("Player 이동!");
            }

        }

        class Knight : Player
        {
            public override void Move()
            {
                base.Move();
                Console.WriteLine("Knight 이동!");
            }
        }

        class SuperKnight : Knight
        {
            public override void Move()
            {
                base.Move();
                Console.WriteLine("SuperKnight 이동!");
            }
        }

        class Mage : Player
        {
            public int mp = 10;

            public override void Move()
            {
                Console.WriteLine("Mage 이동!");
            }

            public void GetMp()
            {
                Console.WriteLine(this.mp);
            }
        }

        static void EnterGame(Player player)
        {
            player.Move();


        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            //knight.Move();
            // mage.Move();

           EnterGame(mage);

            //SuperKnight Sknight = new SuperKnight();
            //Sknight.Move();


        }
    }
}