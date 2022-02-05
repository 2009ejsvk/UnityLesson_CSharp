using System;


namespace UnityLesson_CSharp_ForLoop
{
    internal class Program
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

        static void Main(string[] args)
        {

            Random randomObj = new Random();
            Orc[] orc = new Orc[10];

            for (int i = 0; i < 10; i ++)
            {
                orc[i] = new Orc();
                orc[i].name = "오크" + i;

                // Convert.ToBoolean
                if (Convert.ToBoolean(randomObj.Next(2)))
                {
                    orc[i].rest = true;
                    orc[i].jump();
                }
                else
                {
                    orc[i].rest = false;
                    orc[i].brandish();
                }

                
            }

            




        }
    }
}
