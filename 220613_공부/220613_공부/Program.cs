using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //List <- 동적배열
            //List는 중간 값 변경은 비효율적임

            List<int> list = new List<int>();

            //끝에 값을 추가
            //list.Add(1);

            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }

            // 삽입 .Insert(넣을 위치, 값)
            list.Insert(3, 999);

            // 값을 찾아서 삭제 .Remove(찾는 숫자) [해당숫자찾아서 삭제, 처음으로 찾은 숫자 삭제해줌, bool 형 반환)
            list.Remove(3);

            // 해당 위치의 값 삭제 .RemoveAt(위치)
            list.RemoveAt(1);

            // 전체 삭제 .Clear()
            //list.Clear();

            //총 개수 .Count
            Console.WriteLine(list.Count());

            foreach (int j in list)
            {
                Console.WriteLine(j);
            }



        }
    }
}