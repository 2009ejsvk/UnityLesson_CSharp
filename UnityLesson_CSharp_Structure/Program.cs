using System;
// structure (구조체)
// 멤버 변수들을 가지는 타입
namespace UnityLesson_CSharp_Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Random random = new Random();

            Worrior worrior = new Worrior();    
            worrior.stats._STR = random.Next(0, 10) + 1;
            worrior.stats._DEX = random.Next(0, 10) + 1;
            worrior.stats._CON = random.Next(0, 10) + 1;
            worrior.stats._WIS = random.Next(0, 10) + 1;
            worrior.stats._INT = random.Next(0, 10) + 1;
            worrior.stats._REG = random.Next(0, 10) + 1;


            Monk monk = new Monk(); 
            monk.stats._STR = random.Next(0, 10) + 1;
            monk.stats._DEX = random.Next(0, 10) + 1;
            monk.stats._CON = random.Next(0, 10) + 1;
            monk.stats._WIS = random.Next(0, 10) + 1;
            monk.stats._INT = random.Next(0, 10) + 1;
            monk.stats._REG = random.Next(0, 10) + 1;

            Worrior[] arr_Worrior = new Worrior[10];
            int length = arr_Worrior.Length;
            // 멤버 변수 stats 의 멤버 변수를 for 문에서 초기화하는 방법
            for (int i = 0; i < length; i++)
            {
                arr_Worrior[i] = new Worrior();
                arr_Worrior[i].stats._STR = random.Next(0, 10);
            }

            // 지역변수 stats 초기화한 후 for 문에서 stats 을 초기화
            for (int i = 0; i < arr_Worrior.Length; i++)
            {
                Stats tmpstats = new Stats();
                tmpstats._STR = random.Next(0, 10) + 1;
                tmpstats._DEX = random.Next(0, 10) + 1;
                tmpstats._CON = random.Next(0, 10) + 1;
                tmpstats._WIS = random.Next(0, 10) + 1;
                tmpstats._INT = random.Next(0, 10) + 1;
                tmpstats._REG = random.Next(0, 10) + 1;

                arr_Worrior[i].stats = tmpstats;

                Console.WriteLine("전사_" + i + " 의 STR 은 " + arr_Worrior[i].stats._STR);
            }

            
            Console.WriteLine();

            Console.WriteLine("전사의 STR 은 " + worrior.stats._STR);
            Console.WriteLine("몽크의 STR 은 " + monk.stats._STR);

            if (worrior.stats._STR > monk.stats._STR)
            {
                Console.WriteLine("전사가 이겼습니다.");
            }
            else if (worrior.stats._STR < monk.stats._STR)
            {
                Console.WriteLine("몽크가 이겼습니다.");
            }
            else
            {
                Console.WriteLine("비김");
            }

            Console.WriteLine();

            for (int i = 0; i < arr_Worrior.Length; i++)
            {
                arr_Worrior[i].SetStats(random.Next(0, 10) + 1, random.Next(0, 10) + 1, random.Next(0, 10) + 1, random.Next(0, 10) + 1, random.Next(0, 10) + 1, random.Next(0, 10) + 1);

                Console.WriteLine("전사_" + i + " 의 STR 은 " + arr_Worrior[i].stats._STR);
            }


        }
    }
}
