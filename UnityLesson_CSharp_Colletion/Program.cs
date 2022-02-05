using System;
using System.Collections.Generic;

namespace UnityLesson_CSharp_Colletion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List
            //Dictionary
            //Queue
            //Stack

            //List
            List<string> list_string = new List<string>(); 
            List<int> list_int = new List<int>();
            
            list_string.Add("0");
            list_string.Add("1");
            list_string.Add("2");
            list_string.Add("3");

            list_string.Remove("0");

            list_int.Add(0);
            list_int.Add(0);
            list_int.Add(0);
            list_int.Add(0);
            list_int.Add(0);
            list_int.Add(1);
            list_int.Add(2);
            list_int.Add(3);
            list_int.Add(3);

            

            // Console.WriteLine(list_int.Count);
            // list_int.Remove(0);
            // Console.WriteLine(list_int[0]);
            // Console.WriteLine(list_int.Count);

            foreach ( int i in list_int)
            {
                Console.WriteLine(i);
            }
        }
    }
}
