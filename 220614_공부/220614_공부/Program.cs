using System;

namespace CSharp
{
    class Program
    {
        class Monster
        {

            public int id;

            public Monster(int id)
            {
                this.id = id;
            }

         }
        static void Main(string[] args)
        {
            // Dictionary

            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();

            for(int i = 0; i < 10000; i++)
            {
                dic.Add(i, new Monster(i));
            }

            //추가
            //dic.Add(1, new Monster(1));
            //dic[5] = new Monster(5);

            //찾아서 넣어주는 기능
            Monster mon;
            bool found = dic.TryGetValue(7777, out mon);

            //삭제
            dic.Remove(7777);

            //전체삭제
            dic.Clear();

            Console.WriteLine();

        }
    }
}