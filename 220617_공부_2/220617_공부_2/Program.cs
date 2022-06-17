using System;

namespace CSharp
{
    class Program
    {
        //추상클래스 abstract
        abstract class Monster
        {
            //추상으로 만드면 여기서 구현은 하지않고 선언 함
            //이제 상속받은 애들은 이 함수를 무조건 사용해야함
            public abstract void Shout();
            
        }

        // C#에서 다중상속 하지못함, 이에 대응으로 interface문법 사용, 여기도 구현은 안하고 선언만함
        // 얘를 받으면 받은곳에서 구현 무조건 해야함
        interface IFlyable
        {
            void Fly();

        }

        class Orc : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("asd");
            }
        }
        
        class FlyableOrc : Orc, IFlyable
        {
            public void Fly()
            {

            }
        }

        class Skeleton : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("sdf");
            }
        }

        static void Main(string[] args)
        {


        }
    }
}