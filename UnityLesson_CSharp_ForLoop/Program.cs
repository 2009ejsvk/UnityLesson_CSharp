using System;
using System.Collections.Generic;


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


            Dictionary<string, string> _dic = new Dictionary<string, string> ();
            _dic.Add("검사","양손대검을 사용하여 물리공격을 하는 클래스");
            _dic.Add("마법사","지팡이를 사용하여 마법공격을 하는 클래스");
            _dic.Add("수호자","창과 방패를 사용하여 물리공격 및 방어를 하는 클래스");
            // _dic.Remove("검사");

            bool isSwordMasterExist = _dic.ContainsKey("검사");
            if (isSwordMasterExist)
            {
                string tmpValue = _dic["검사"];
                Console.WriteLine("검사 : " + tmpValue);
            }





        }
    }
}
