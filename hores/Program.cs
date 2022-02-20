using System;
using System.Linq;
using System.Threading;

namespace hores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hores[] hores = new Hores[5];
            int[] rankings = new int[5];
            for (int i = 0; i < hores.Length; i++)
            {
                hores[i] = new Hores();
            }
            
            bool arrive = true;
            while (arrive)
            {
                int[] hores_distance = new int[5];

                for (int i = 0; i < hores.Length; i++)
                {
                    hores[i].speed();
                    hores[i].hores_distance += hores[i].hores_speed;

                    Console.WriteLine((i + 1) + "번 말 / 속도 : " + hores[i].hores_speed + " / 거리 : " + hores[i].hores_distance);

                    hores_distance[i] = hores[i].hores_distance;
                }

                Console.WriteLine();

                int min = hores_distance[0];
                for (int i = 0; i < hores_distance.Length; i++)
                {
                    if (min > hores_distance[i])
                    {
                        min = hores_distance[i];
                    }
                }

                if (min >= 200)
                {
                    arrive = false;

                    for (int i = 0; i < rankings.Length; i++)
                    {
                        rankings[i] = 1;
                        for (int j=0; j < hores_distance.Length; j++)
                        {
                            if (hores_distance[j] > hores_distance[i])
                            {
                                rankings[i] += 1;
                            }
                        }

                        Console.WriteLine((i+1) + "번 말 : " + rankings[i] + " 등");

                    }
                }




                Thread.Sleep(1000);
            }

        }
    }
}
