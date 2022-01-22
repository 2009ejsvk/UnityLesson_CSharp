using System;

namespace UnityLesson_CSharp_if
{
    internal class Program
    {

        static bool condition1;
        static bool condition2;
        static bool condition3;

        static void Main(string[] args)
        {

            condition1 = false;
            condition2 = false;
            condition3 = true;

            if (condition1)
            {
                Console.WriteLine(condition1 + " 은 참이다");
            }
            else if (condition2)
            {
                Console.WriteLine(condition2 + " 은 참이다");
            }
            else if (condition3)
            {
                Console.WriteLine(condition3 + " 은 참이다");
            }
            else
            {
                Console.WriteLine("전부 거짓이다.");
            }
            
        }
    }
}
