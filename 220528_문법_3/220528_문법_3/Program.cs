using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Harry Potter";

            //1. 찾기
            bool found = name.Contains("Harry");
            //Harry라는 글자가 있는지 확인
            int index = name.IndexOf('P');
            //글자위치 반환

            //2. 변형
            name = name + " Junior";
            //문자추가
            string lowerCaseName =  name.ToLower();
            //소문자로 반환
            string luperCaseName = name.ToUpper();
            //대문자로 반환
            string newName = name.Replace("r", "l");
            //특정문자 변경

            //3. 분활
            string[] names = name.Split(new char[] { ' ' });
            //띄어쓰기 기준으로 배열로  나눔
            string subStringName =  name.Substring(5);
            // 5번째뒤로 짤라서 새로운 문자열로 받음
        }
    }
}