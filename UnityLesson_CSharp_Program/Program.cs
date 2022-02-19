using System;
using System.Linq;

namespace UnityLesson_CSharp_Program
{
    internal class Program
    {
        
        delegate int CalcDelegate(int a, int b);
        static int Sum(int a, int b)
        {
            return a +b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static void PrintCalcResult(int a, int b, CalcDelegate sum, CalcDelegate sub)
        {
            Console.WriteLine("Sum : " + sum(a,b));
            Console.WriteLine("Sub : " + sub(a,b));
        }
        static void PrintCalcResult(int a, int b, CalcDelegate sum)
        {
            Console.WriteLine("Sum : " + sum(a, b));
        }
        static void Main(string[] args)
        {
            int a = 4;
            int b = 7;

            /*int sumResult = Sum(a, b);
            int subResult = Sub(a, b);
            PrintCalcResult(sumResult, subResult);*/

            CalcDelegate CD_Sum = Sum;
            CalcDelegate CD_Sub = Sub;
            // 람다식 :
            // 함수를 정의하지 않고, 연산에 필요한 내용만 표현하는 방법

            PrintCalcResult(a,b,CD_Sum,CD_Sub);

            Enumerable.Range(0, 10).ToList().ForEach(System.Console.Write);

        }
    }
}
