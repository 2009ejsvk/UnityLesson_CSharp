using System;

namespace UnityLesson_CSharp_StaticExample
{
    class Person
    {
        public int age = 17;
        public double height = 180.1;
        public bool isResting = true;
        public char genderChar = 'M';
        public string name = "홍길동";

        public void SayAge()
        {
            Console.WriteLine("나이는 " + age);
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

    class Orc
    {
        static public string typeName;
        public int age;
        public double height;
        public bool isResting;
        public char genderChar;
        public string name;

        static public void SayTypeName()
        {
            Console.WriteLine(typeName);
        }
        public void Jump()
        {
            Console.WriteLine(name + " 이(가) 점프했다.");
        }
        public void Smash()
        {
            Console.WriteLine(name + " 이(가) 휘둘렀다.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
             Orc orc = new Orc();
            orc.name = "김오크";
            orc.Jump();
            orc.Smash();

            orc.age = 12;
            Console.WriteLine(orc.age);

            orc.age += 1;
            Console.WriteLine(orc.age);

            Person person = new Person();
            person.name = "박사람";
            Console.WriteLine(person.name);


            Orc.typeName = "오크타입";
            Orc.SayTypeName();



        }
    }
}
