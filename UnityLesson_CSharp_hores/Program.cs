using System;
using System.Threading;

namespace UnityLesson_CSharp_hores
{
    internal class Program
    {

        static Random random;
        static bool isGameFinished = false;
        static int minSpeed = 10;
        static int maxSpeed = 20;
        static int finishDistance = 100;


        static void Main(string[] args)
        {
            Horse[] arr_horse = new Horse[5];
            String[] arr_FinishedHorseName = new string[5];
            int currentGrade = 1;

            int length = arr_horse.Length;
            for (int i = 0; i < length; i++)
            {
                arr_horse[i] = new Horse();
                arr_horse[i].name = "경주마_" + (i+1);
            }
            Console.WriteLine("경주 시작 !");
            int count = 0;
            while (isGameFinished == false)
            {
                Thread.Sleep(1000);
                count++;
                Console.WriteLine(count + " 초");
                for (int i = 0; i < length; i++)
                {
                    if (arr_horse[i].available)
                    {
                        random = new Random();
                        int tmpMoveDistance = random.Next(minSpeed, maxSpeed + 1);
                        arr_horse[i].Run(tmpMoveDistance);
                        Console.WriteLine(arr_horse[i].name + " 이(가) 달린 거리 : " + arr_horse[i].distance);

                        if (arr_horse[i].distance >= finishDistance)
                        {
                            arr_FinishedHorseName[currentGrade - 1] = arr_horse[i].name;
                            arr_horse[i].available = false;
                            currentGrade++;
                        }
                    }

                }
                if (currentGrade > length)
                {
                    isGameFinished = true;
                    Console.WriteLine("경주 끝 !");
                }
            }

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(arr_FinishedHorseName[i]);
            }

        }
    }
}
