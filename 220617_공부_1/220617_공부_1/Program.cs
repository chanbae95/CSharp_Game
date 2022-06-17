using System;

namespace CSharp
{
    class Program
    {
        //일반화 클래스
        class MyList<T>
        {
            T[] arr = new T[10];

            public T GetItem(int i)
            {
                return arr[i];
            }
        }

        // 일반화 함수
        static void Test<T>(T input)
        {

        }

        class Monster
        {

        }

        //조건 걸기 (C#문법)
        class MyList2<T> where T : Monster //만들때 몬스터 형식만 받겠다.
        {
            T[] arr = new T[10];

            public T GetItem(int i)
            {
                return arr[i];
            }
        }
        static void Main(string[] args)
        {
            //Generic 일반화
            object obj = 3;
            object obj2 = "hello world";
            int num = (int)obj;

            MyList<int> myIntList = new MyList<int>();

            Test<int>(3);



        }
    }
}