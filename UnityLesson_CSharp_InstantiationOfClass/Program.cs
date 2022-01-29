using System;

namespace UnityLesson_CSharp_InstantiationOfClass
{
    internal class Program
    {
        class Person
        {
            public int age;
            public double height;
            public bool isResting;
            public char genderChar;
            public string name;

            public void SayAge()
            {
                //Console.WriteLine("나이는 " + age);
                Console.WriteLine($"나이는 {age}");
                Console.WriteLine("키는" + height);

                if (isResting)
                {
                    Console.WriteLine("쉬는 중");
                }
                else
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
            Person person = new Person();
            person.name = "홍길동";
            person.age = 17;
            person.genderChar = 'm';
            person.height = 180.5;
            person.isResting = true;

            person.SayAll();

            Person person2 = new Person();
            person2.name = "박춘자";
            person2.age = 18;
            person2.genderChar = 'w';
            person2.height = 170.1;
            person2.isResting = false;

            person2.SayAll();
        }
    }
}
