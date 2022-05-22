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

        
        enum MonsterType
        {
            None = 0,
            Slime =1,
            Orc = 2,
            Skeleton = 3
        }

        struct Monster
        {
            public int hp;
            public int attack;
            public MonsterType type;
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

        static void CreateRandomMonster(out Monster monster)
        {
            Random random = new Random();
            int randMonster = random.Next(1, 4);

            switch (randMonster)
            {
                case (int)MonsterType.Slime:
                    Console.WriteLine("슬라임이 스폰되었습니다.");
                    monster.hp = 20;
                    monster.attack = 2;
                    monster.type = MonsterType.Slime;
                    break;
                case (int)MonsterType.Orc:
                    Console.WriteLine("오크가 스폰되었습니다.");
                    monster.hp = 40;
                    monster.attack = 4;
                    monster.type = MonsterType.Orc;
                    break;
                case (int)MonsterType.Skeleton:
                    Console.WriteLine("스켈레톤이 스폰되었습니다.");
                    monster.hp = 30;
                    monster.attack = 3;
                    monster.type = MonsterType.Skeleton;
                    break;
                default:
                    monster.hp = 0;
                    monster.attack = 0;
                    monster.type = MonsterType.None;
                    break;
            }

        }

        static void Fight(ref Player player, ref Monster monster)
        {
            while (true)
            {
                // 플레이어가 몬스터 공격
                monster.hp -= player.attack;
                if (monster.hp <= 0)
                {
                    Console.WriteLine("승리했습니다.");
                    Console.WriteLine("직업 : " + player.type + "   체력 : " + player.hp + "   공격력 : " + player.attack);
                    break;
                }

                player.hp -= monster.attack;
                if(player.hp <= 0)
                {
                    Console.WriteLine("패배했습니다.");
                    break;
                }
            }
        }

        static void EnterField(ref Player player)
        {
            while (true)
            {
                Console.WriteLine("필드에 접속했습니다!");
                // 랜덤으로 1~3 몬스터 중 하나를 리스폰
                Monster monster;
                CreateRandomMonster(out monster);

                Console.WriteLine("[1] 전투 모드로 돌입");
                Console.WriteLine("[2] 일정 확률로 마을로 도망");

                string input = Console.ReadLine();
                if(input == "1")
                {
                    Fight(ref player, ref monster);
                }
                else if(input == "2")
                {
                    Random rand = new Random();
                    int randValue = rand.Next(0, 101);
                    if (randValue <= 33)
                    {
                        Console.WriteLine("도망치느데 성공했습니다.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("도망치느데 실패했습니다.");
                        Fight(ref player, ref monster);
                    }
                }

            }


        }

        static void EnterGame(ref Player player)
        {
            while (true)
            {
                Console.WriteLine("마을의 접속했습니다.");
                Console.WriteLine("[1] 필드로 간다");
                Console.WriteLine("[2] 로비로 간다");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        EnterField(ref player);
                        break;
                    case "2":
                        return;

                }
            }
           
        }

        static void Main(string[] args)
        {
            // 직업 선택
            while (true)
            {
                ClassType MyJop = SelectJop();

                // 캐틱터 생성
                Player player;
                CreatePlayer(MyJop, out player);

                // 게임진입
                EnterGame(ref player);
            }
            
        }
    }
}