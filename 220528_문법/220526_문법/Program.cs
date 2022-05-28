using System;

namespace CSharp
{

    class Knight
    {
        // public protected private

        public int hp;
        //공용
        private int hp2;
        //나만
        protected int hp3;
        //상속 받았으면 사용가능
        int hp4;
        //아무지정 안할 경우 private으로 설정됨

        public void SetHp(int hp)
        {
            this.hp2 = hp;
        }
    }

    class SuperKnight : Knight
    {
        void Test()
        {
            hp3 = 10;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("asdasd");
            Console.Clear();

            Knight knight = new Knight();
            knight.SetHp(14);
            //이렇게 public 함수로 변경가능


        }
    }
}