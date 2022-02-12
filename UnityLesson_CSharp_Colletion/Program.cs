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

            Dictionary<string, string> _dic = new Dictionary<string, string>();
            _dic.Add("검사", "양손대검을 사용하여 물리공격을 하는 클래스");
            _dic.Add("마법사", "지팡이를 사용하여 마법공격을 하는 클래스");
            _dic.Add("수호자", "창과 방패를 사용하여 물리공격 및 방어를 하는 클래스");
            // _dic.Remove("검사");

            bool isSwordMasterExist = _dic.ContainsKey("검사");
            if (isSwordMasterExist)
            {
                string tmpValue = _dic["검사"];
                Console.WriteLine("검사 : " + tmpValue);
            }

            // dictinonary 도 foreach 구문이 가능
            // dictinonary 의 key, value 도 foreach 구문이 가능
            foreach (var sub in _dic)
            {
                Console.WriteLine(sub);
            }

            foreach (KeyValuePair<string, string> sub in _dic)
            {
                Console.WriteLine(sub.Key);
                Console.WriteLine(sub.Value);
            }

            foreach (string sub in _dic.Keys)
            {
                Console.WriteLine(sub);
            }


            // Queue ( List 와 비슷하나 FIFO ( First Input First Output 체계 )
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Dequeue();
            queue.Peek();

            Console.WriteLine(queue.Peek());


            // Stack ( List 와 비슷하나, LIFO ( Last Input First Output 체계 )
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
        }
    }
}
