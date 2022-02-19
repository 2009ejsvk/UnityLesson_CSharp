using System;

namespace UnityLesson_CSharp_hores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hores[] hores = new hores[5];
            for (int i = 0; i < hores.Length; i++)
            {
                hores[i] = new hores();
            }
            while (true)
            {
                for (int i = 0; i < 5; i++)
                {
                    hores[i].speed();
                    hores[i].hores_distance += (int)hores[i].hores_speed;
                    Console.WriteLine((i+1) + "번 말 : " + hores[i].hores_speed);

                    if (hores[i].hores_distance <= 200)
                    {

                    }
                }


                

            }


                                    
                

        }
    }
}
