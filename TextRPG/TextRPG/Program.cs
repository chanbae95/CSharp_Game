using System;

namespace CSharp
{

    class Program
    {
        enum ClassType
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3
        }

        struct Player
        {
            public int hp;
            public int attack;
            public ClassType type;
        }

        static ClassType SelectJop()
        {
            
            Console.WriteLine("직업을 선택하세요");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");

            int input = Convert.ToInt32(Console.ReadLine());


            switch (input)
            {
                case 1:
                    return ClassType.Knight;
                case 2:
                    return ClassType.Archer;
                case 3:
                    return ClassType.Mage;
                default:
                    Console.WriteLine("선택을 다시 확인해 주세요.");
                    return SelectJop();
            }

        }

        static void CreatePlayer(ClassType jop, out Player player)
        {
            player.type = jop;
            // 기사 (100/10) 궁수 (75/12) 법사 (50/15)
            switch (jop)
            {
                case ClassType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Archer:
                    player.hp = 75;
                    player.attack = 12;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.attack = 15;
                    break;
                default:
                    player.hp = 0;
                    player.attack = 0;
                    break;
            }

        }

        static void Main(string[] args)
        {
            // 직업 선택
            ClassType MyJop = SelectJop();

            // 캐틱터 생성
            Player player;
            CreatePlayer(MyJop, out player);




            Console.WriteLine("직업 : " + MyJop + "   체력 : " + player.hp + "   공격력 : " + player.attack);
            


            // 필드로 가서 몬스터랑 싸운다
            
        }
    }
}