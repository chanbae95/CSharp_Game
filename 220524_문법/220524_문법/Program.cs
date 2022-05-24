using System;

namespace CSharp
{
    // 객체
    
    // Knight
    // 속성 : hp, attack, 
    // 기능 : Move, Attack, Die

    //참조
    class Knight
    {
        public int hp;
        public int attack;

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

    //복사
    struct Mage
    {
        public int hp;
        public int attack;
    }

    class Program
    {
        static void KillMage(Mage mage)
        {
            mage.hp = 0;
        }

        static void KillKnight(Knight knight)
        {
            knight.hp = 0;
        }


        static void Main(string[] args)
        {
            //struck의 경우 복사본으로 넘겨서 계산하게됨(얇은복사)(ref를 쓰지않는이상 복사값으로 이용할뿐)
            Mage mage = new Mage();
            mage.hp = 100;
            mage.attack = 50;
            KillMage(mage);


            //class의 경우 참조값으로 하기때문에 본 데이터가 변경됨(깊은복사)(항상 ref를 쓴 상태)
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;
            knight.Move();
            knight.Attack();
            //KillKnight(knight);

            Knight knight2 = knight.Clone();
            Console.WriteLine(knight2.hp);
            knight2.hp = 0;

        }
    }
}