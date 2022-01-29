 using System;

namespace UnityLesson_CSharp_InstantiationExample1
{

    public class Orc
    {
        public string name;
        public double height;
        public double weight;
        public double age;
        public char sex;
        public bool rest;

        public void brandish()
        {
            Console.WriteLine(name + " 이(가) 휘두른다.");
        }

        public void jump()
        {
            Console.WriteLine(name + " 이(가) 점프한다.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Orc orc1 = new Orc();
            orc1.name = "상급오크";
            orc1.height = 240.2;
            orc1.weight = 200;
            orc1.age = 140;
            orc1.sex = 'm';
            orc1.rest = false;

            Orc orc2 = new Orc();
            orc2.name = "하급오크";
            orc2.height = 140.4;
            orc2.weight =120;
            orc2.age = 60;
            orc2.sex = 'w';
            orc2.rest = true;

            if (orc1.rest)
            {
                orc1.brandish();
                orc1.jump();
            } else
            {
                Console.WriteLine(orc1.name + " 이(가) 바쁘다.");
            }


            if (orc2.rest)
            {
                orc2.brandish();
                orc2.jump();
            }
            else
            {
                Console.WriteLine(orc2.name + " 이(가) 바쁘다.");
            }


        }
    }
}
