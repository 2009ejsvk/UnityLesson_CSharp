using System;
using System.Collections.Generic;

namespace UnityLesson_CSharp_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] string_array_1 = new string[4];
            int[] int_array_1 = new int[4];

            string_array_1[0] = "0";
            string_array_1[1] = "1";
            string_array_1[2] = "2";
            string_array_1[3] = "3";

            Console.WriteLine(string_array_1[0] + " / " + string_array_1[1]);

            string[] string_array = { "1", "2" };
            Console.WriteLine(string_array[0] + " / " + string_array[1]);

            int[] int_array = { 1, 2 };
            Console.WriteLine(int_array[0] + " / " + int_array[1]);

            var myTable = new Dictionary<string, string>();
            myTable.Add("0", "첫번째 값");
            myTable.Add("1", "두번째 값");
            myTable.Add("2", "세번째 값");
            myTable.Add("3", "네번째 값");
            myTable.Add("4", "다섯번째 값");
            Console.WriteLine(myTable["1"]);

            foreach (KeyValuePair<string, string> kv in myTable)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kv.Key, kv.Value);
            }

        }
    }
}
