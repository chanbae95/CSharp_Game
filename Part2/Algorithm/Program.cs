using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            Player player = new Player();
            board.Initialize(25, player);
            player.Initialize(1, 1, board);

            Console.CursorVisible = false;
            //커서 끄기


            const int WAIT_TICK = 1000 / 30;
           

            int lastTick = 0;

            while (true)
            {
                #region 프레임 관리
                // FPS 프레임
                int currentTick = System.Environment.TickCount;
                //시스템이 켜진 후 얼마나 시간이 지났는지 저장(밀리세컨드 단위)
                if (currentTick - lastTick < WAIT_TICK)
                    continue;
                int deltaTick = currentTick - lastTick;
                lastTick = currentTick;
                #endregion
                // 입력

                // 로직
                player.Update(deltaTick);

                // 렌더링
                board.Rendor();
                Console.SetCursorPosition(0, 0);


            }



        }
    }
}