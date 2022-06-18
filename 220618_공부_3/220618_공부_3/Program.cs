using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 1. 0으로 나눌 때
                // 2. 잘못된 메모리를 참조
                // 3. 오버플로우

                int a = 10;
                int b = 0;
                int result = a / b;
            }
            catch (Exception e)
            {


            }
            finally
            {
                //무조건 실행되어야하는 코드 입력
            }

        }
    }
}