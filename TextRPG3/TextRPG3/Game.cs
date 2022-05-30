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
            //크리쳐 생성자로 플레이어 생성(경우에따라 생성해야겟지? input값에 따라)
            GameNow = GameNow.Town;
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
            //크리처로 랜덤 몬스터 생성(몬스터이름도 변수로 넣어주자)
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("                                @@@를 만났습니다.                              ");
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
                    //GameFieldFight()만들어서 싸우는 로직 사용
                    break;
                case "2":
                    //일정확률로 마을로 이동 실패시 싸우기
                    GameNow = GameNow.Town;
                    break;
            }
        }
    }
}
