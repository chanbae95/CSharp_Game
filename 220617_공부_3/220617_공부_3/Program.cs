using System;

namespace CSharp
{
    class Knight
    {
        protected int hp;

        // 프로퍼티
        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }

        // 더 줄인 문법
        // public int Hp { get; set; } = 100;

    }

    class Program
    {
        static void Main(string[] args)
        {
            // 프로퍼티
            Knight knight = new Knight();
            knight.Hp = 100;
            int hp = knight.Hp;

        }
    }
}