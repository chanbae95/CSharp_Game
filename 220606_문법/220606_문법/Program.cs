using System;

namespace CSharp
{
    class Program
    {
        //가장높은 점수 반환
        static int GetHighestScore(int[] scores)
        {
            int highestScore = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if(scores[i] > highestScore)
                    highestScore = scores[i];
            }

            return highestScore;
        }

        //평균점수 변환
        static int GetAverageScore(int[] scores)
        {
            if (scores.Length == 0)
                return 0;

            int totalScore = 0;
            foreach(int score in scores)
            {
                totalScore += score;
            }

            

            return totalScore/scores.Length;
        }

        //찾는 숫자가 있는지 있으면 해당 인덱스번호 반환없으면 -1
        static int GetInexOf(int[] scores, int value)
        {
            for(int i = 0; i <scores.Length; i++)
            {
                if (scores[i] == value)
                {
                    return i + 1;
                }
            }

            return -1;
        }

        //오른차순 정렬
        static int[] Sort(int[] scores)
        {
            int temp = 0;
            for (int j = 0; j < scores.Length; j++)
            {
                for (int i = 0; i < scores.Length - 1; i++)
                {

                    if (scores[i] > scores[i + 1])
                    {
                        temp = scores[i];
                        scores[i] = scores[i + 1];
                        scores[i + 1] = temp;
                    }
                }
            }

            return scores;
        }

        static void Main(string[] args)
        {
            //배열
            //int[] scores = new int[5] {10, 20, 30, 40, 50};
            //int[] scores = new int[] { 10, 20, 30, 40, 50 };
            //int[] scores = { 10, 20, 30, 40, 50 };
            
            //scores[0] = 10;
            //scores[1] = 20;
            //scores[2] = 30;
            //scores[3] = 40;
            //scores[4] = 50;

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine(scores[i]);
            //}

            //foreach(int a in scores)
            //{
            //    Console.WriteLine(a);
            //}


            //연습문제
            int[] scores = new int[5] { 10, 30, 40, 20, 50 };
            int high = GetHighestScore(scores);
            Console.WriteLine("가장 높은 수 : " + high);

            int aver = GetAverageScore(scores);
            Console.WriteLine("평군" + aver);

            int index = GetInexOf(scores, 40);
            Console.WriteLine("찾는 수 40은 " + index + "번째에 있습니다.");

            int[] sortScore = Sort(scores);
            foreach(int i in sortScore)
            {
                Console.WriteLine(i);
            }

        }
    }
}