using System;

namespace UnityLesson_ClassIncludingVariablesFunctions
{
    internal class Program
    {

        // Camel case - 띄어쓰기 대신 대문자로
        // 변수는 소문자로 시작한다
        // class, method, namespace 등은 대문자로 시작한다

        // 코드 작성시 유의사항
        // 줄임말은 되도록 사용하지 않는다.
        // 이름을 보았을 때 어떤 기능이나 목적인지 알 수 있도록 선정한다.
        // 애마하거나 복잡한 내용이 있으면 주석을 달아준다.

        // 클래스 정의 형태
        /*
        class 클래스이름
        {
            멤버 변수
            멤버 함수
        }
        */

        class Person
        {
            int age = 17;
            double height = 180.1;
            bool isResting = true;
            char genderChar = 'M';
            string name = "홍길동";

            public void SayAge()
            {
                Console.WriteLine("나이는 " + age);
                Console.WriteLine("키는" + height);

                if (isResting)
                {
                    Console.WriteLine("쉬는 중");
                } else
                {
                    Console.WriteLine("일하는 중");
                }
                
                if (genderChar == 'm')
                {

                }
                Console.WriteLine(genderChar);
                Console.WriteLine(name);
            }

            public void SayAll()
            {
                SayAge();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person person = new Person();
            //person.SayAge();
            person.SayAll();
        }
    }
}
