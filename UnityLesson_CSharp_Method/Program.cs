using System;

namespace UnityLesson_CSharp_Method
{
    internal class Program
    {
        string test_1;// 필드 변수 - 

        //반환형 함수이름(인자자료형 인자이름)
        //{
        //함수 연산 내용
        //return 반환 
        //}

        static void PrintHelloWord()
        {
            Console.WriteLine("Hello World!");
        }
        static void PrintSometing(string someting) // 인자 (Argument)
        {
            Console.WriteLine(someting); 
        }
        static string ReturnSometing(string someting) // 인자 (Argument)
        {
            return someting;
        }
        static bool PSARF() // 인자 (Argument)
        {
            bool isF = false; // 지역 변수 - 함수 내에서 정의된 변수

            return isF;
        }
        public void anyting_1()
        {

        }

        static void Main(string[] args)
        { 
            Console.WriteLine("Hello World!");
            PrintHelloWord();
            PrintSometing("YES"); // 매개변수(parameter)
            string someting = ReturnSometing("No"); // 매개변수(parameter)
            Console.WriteLine(someting);
            Console.WriteLine(PSARF());
        }
    }
}
