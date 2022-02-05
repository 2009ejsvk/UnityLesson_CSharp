using System;
using System.Collections.Generic;


namespace Mine
{
    internal class Program
    {

        static string bit_write(int num)
        {
            int result = 0;
            string bit_write = "";

            for (int i = 7; i >= 0; --i)
            { //8자리 숫자까지 나타냄
                result = num >> i & 1;
                bit_write += result;
            }

            
            return bit_write;
        }

 

        static void Main(string[] args)
        {

            // Console.WriteLine(bit_write(1));
            // Console.WriteLine(bit_write(2));
            // Console.WriteLine(bit_write(3));
            // Console.WriteLine(bit_write(4));
            // Console.WriteLine(bit_write(5));
            // Console.WriteLine(bit_write(6));




            Random randomObj = new Random();
            var myTable_random = new Dictionary<int, int>();

            for (int i = 0; i < 52; i++)
            {
                myTable_random.Add(i, randomObj.Next(52));

                for (int j = 0; j < myTable_random.Count; j++)
                {
                    if (i != j)
                    {
                        if (myTable_random[i] == myTable_random[j])
                        {
                            // Console.WriteLine("중복");
                            myTable_random.Remove(i);
                            i--;
                        }
                    }

                }
 
            }

            var myTable_card = new Dictionary<int, string>();
            for (int i = 0; i < 13; i++)
            {

                string card_num = (i+1).ToString();
                if (i + 1 == 1)
                {
                    card_num = "A";
                }
                else if (i+1 == 11)
                {
                    card_num = "J";
                }
                else if (i + 1 == 12)
                {
                    card_num = "Q";
                }
                else if (i + 1 == 13)
                {
                    card_num = "K";
                }

                myTable_card.Add(i, "♤" + card_num);
                myTable_card.Add(i + 13, "♡" + card_num);
                myTable_card.Add(i + 26, "♧" + card_num);
                myTable_card.Add(i + 39, "◇" + card_num);
            }

            Console.Write("상대 : " + myTable_card[myTable_random[0]] + " / " + myTable_card[myTable_random[2]]);
            Console.WriteLine();
            Console.Write("필드 : " + myTable_card[myTable_random[4]] + " / " + myTable_card[myTable_random[5]] + " / " + myTable_card[myTable_random[6]] + " / " + myTable_card[myTable_random[7]] + " / " + myTable_card[myTable_random[8]]);
            Console.WriteLine();
            Console.Write("자신 : " + myTable_card[myTable_random[1]] + " / " + myTable_card[myTable_random[3]]);
            Console.WriteLine();

        } 
    }
}
