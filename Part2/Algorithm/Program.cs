﻿using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.Initialize();

            Console.CursorVisible = false;
            //커서 끄기


            const int WAIT_TICK = 1000 / 30;
            const char CIRCLE = '\u25cf';

            int lastTick = 0;
            
            while (true)
            {
                #region 프레임 관리
                // FPS 프레임
                int currentTick = System.Environment.TickCount;
                //시스템이 켜진 후 얼마나 시간이 지났는지 저장(밀리세컨드 단위)
                if (currentTick - lastTick < WAIT_TICK)
                    continue;
                lastTick = currentTick;
                #endregion
                // 입력

                // 로직

                // 렌더링
                Console.SetCursorPosition(0, 0);

                for(int i = 0; i < 25; i++)
                {
                    for(int j = 0; j < 25; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(CIRCLE);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}