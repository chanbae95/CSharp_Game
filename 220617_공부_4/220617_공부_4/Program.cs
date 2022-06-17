using System;

namespace CSharp
{
    class Program
    {
        delegate int OnClicked();

        static void ButtonPressed(OnClicked clickedFunction /*함수자체를 인자로 넘겨주고*/)
        {
            //함수로 호출();
            clickedFunction();
        }
        static void Main(string[] args)
        {
            // delegate(대리자)

            ButtonPressed(/* */);

        }
    }
}