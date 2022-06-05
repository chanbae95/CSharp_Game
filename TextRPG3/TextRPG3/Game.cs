using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG3
{
    enum GameNow
    {
        None = 0,
        Lobby = 1,
        Town = 2,
        Field = 3
    }

    class Game
    {
        public GameNow GameNow = GameNow.None;
        Random rand = new Random();
        Creture Player = null;
        Creture Monster = null;

        public Game()
        {
            
            GameNow = GameNow.Lobby;

        }


        public void GameProcess()
        {
            switch (GameNow)
            {
                case GameNow.Lobby:
                    Console.Clear();
                    GameLobbyRand();
                    GameSelectJop();
                    break;
                case GameNow.Town:
                    Console.Clear();
                    PlayerStatue();
                    GameTownRand();
                    GameTownMove();
                    break;
                case GameNow.Field:
                    Console.Clear(); 
                    GameFieldRand();
                    GameFieldFightReady();
                    break;
            }
            
        }

        //로비
        private void GameLobbyRand()
        {
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("                                                                               ");
            Console.WriteLine("                             직업을 선택해 주세요                              ");
            Console.WriteLine("                                   [1] 기사                                    ");
            Console.WriteLine("                                   [2] 궁수                                    ");
            Console.WriteLine("                                   [3] 법사                                    ");
            Console.WriteLine("                                                                               ");
            Console.WriteLine("*******************************************************************************");
        }

        private void GameSelectJop()
        {
            Console.Write("                                   입력 : ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Player = new Knight();
                    GameNow = GameNow.Town;
                    break;
                case "2":
                    Player = new Archer();
                    GameNow = GameNow.Town;
                    break;
                case "3":
                    Player = new Mage();
                    GameNow = GameNow.Town;
                    break;
                default:
                    break;
            }
        }


        //마을
        private void GameTownRand()
        {
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("                                                                               ");
            Console.WriteLine("                                어디로 가실까요?                               ");
            Console.WriteLine("                                   [1] 필드                                    ");
            Console.WriteLine("                                   [2] 로비(직업 재선택)                       ");
            Console.WriteLine("                                                                               ");
            Console.WriteLine("*******************************************************************************");
        }

        private void GameTownMove()
        {
            Console.Write("                                   입력 : ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    GameNow = GameNow.Field;
                    break;
                case "2":
                    GameNow = GameNow.Lobby;
                    break;
            }
        }

        //필드
        private void GameFieldRand()
        {
            Console.WriteLine("*******************************************************************************");
            int monsterRand = rand.Next(0,3);
            switch (monsterRand)
            {
                case 0:
                    Monster = new Slime();
                    Console.WriteLine("                                " + Monster.Jop + " 를 만났습니다.");
                    break;
                case 1:
                    Monster = new Orc();
                    Console.WriteLine("                                " + Monster.Jop + " 를 만났습니다.");
                    break;
                case 2:
                    Monster = new Skeleon();
                    Console.WriteLine("                                " + Monster.Jop + " 를 만났습니다.");
                    break;
            }
            
           
            Console.WriteLine("                                                                               ");
            Console.WriteLine("                                   [1] 싸운다                                  ");
            Console.WriteLine("                                   [2] 도망간다(실패시 싸움)                   ");
            Console.WriteLine("                                                                               ");
            Console.WriteLine("*******************************************************************************");
        }

        private void GameFieldFightReady()
        {
            Console.Write("                                   입력 : ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    GameFieldFight();
                    break;
                case "2":
                    int runRand = rand.Next(1, 101);
                    if(runRand < 31)
                    {
                        Console.WriteLine("도망쳤습니다!");
                        Console.ReadLine();
                        GameNow = GameNow.Town;
                    }
                    else
                    {
                        Console.WriteLine("도망에 실패 했습니다. 전투 시작! ");
                        GameFieldFight();
                    }
                    break;
                default:
                    break;
            }
        }

        private void PlayerStatue()
        {
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("                    HP : " + Player.Hp + " MP : " + Player.Mp + " Att : " + Player.Att + " 직업 : " + Player.Jop + " Exp : " + Player.Exp);
        }

        private void GameFieldFight()
        {
            while (true)
            {
                Player.Fight(Monster.Att);
                if (Monster.Hp < 1)
                {
                    Console.WriteLine("몬스터를 해치웠습니다!");
                    Player.Exp += Monster.Exp;
                    Console.ReadLine();
                    break;
                }

                Monster.Fight(Player.Att);
                if (Player.Hp < 1)
                {
                    Console.WriteLine("패배하였습니다!");
                    Player.Hp = 100;
                    Console.ReadLine();
                    break;
                }
            }
            GameNow = GameNow.Town;
        }
    }
}
