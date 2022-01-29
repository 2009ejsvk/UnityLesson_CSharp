using System;

namespace UnityLesson_CSharp_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 14;
            int b = 5;
            int c = 0;

            // 산술 연산
            // 더하기, 빼기, 나누기, 곱하기, 나머지
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a / b);
            Console.WriteLine(a * b);
            Console.WriteLine(a % b);

            Console.WriteLine("");

            double d = 14;
            double e = 5;
            double f = 0;

            // 산술 연산
            // 더하기, 빼기, 나누기, 곱하기, 나머지
            Console.WriteLine(d + e);
            Console.WriteLine(d - e);
            Console.WriteLine(d / e);
            Console.WriteLine(d * e);
            Console.WriteLine(d % e);

            Console.WriteLine("");

            // 증감 연산
            c++;
            f--;
            Console.WriteLine(c);
            Console.WriteLine(f);

            Console.WriteLine("");

            // 관계 연산
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a > b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a < b);
            Console.WriteLine(a <= b);

            // 논리 연산
            // 양측의 피연산자들을 비교해서 연산 수행
            // ar , and , xor , not

            Console.WriteLine("");

            // 조건부 논리연산
            // 왼쪽 피연산자 조건에 따라서 오른쪽 피연산자와 비교할지말지 평가 후에 연산한다.
            // 만약 A 가 TRUE 면, B 의 값에 관계없이 결과값이 TRUE 이므로
            // 연산을 수행하지 않고 A 를 반환함.
            if (a == 1 || a == 2)
            {
                Console.WriteLine("a 는 1 또는 2 입니다.");
            }
            else
            {
                Console.WriteLine("a 는 1 또는 2 가 아닙니다.");
            }
            // 조건부 논리연산
            // 왼쪽 피연산자 조건에 따라서 오른쪽 피연산자와 비교할지말지 평가 후에 연산한다.
            // 만약 A 가 FALSE 면, B 의 값에 관계없이 결과값이 FALSE 이므로
            // 연산을 수행하지 않고 A 를 반환함.
            if (a == 1 && b == 2)
            {
                Console.WriteLine("a 는 1 이고, b 는 2 입니다..");
            }
            else
            {
                Console.WriteLine("a 가 1 이 아니거나, b 가 2 가 아닙니다.");
            }
            if (a == 1 ^ a == 2)
            {
                Console.WriteLine("a 는 1 이거나, 2 입니다.");
            } else
            {
                Console.WriteLine("a 는 1 또는 2 가 아닙니다.");
            }
            if (a != 1)
            {
                Console.WriteLine("a 는 1 이 아닙니다.");
            }
            else
            {
                Console.WriteLine("a 는 1 입니다.");
            }

            // 비트 연산
            // 비트 연산을 하는 이유 : 데이터를 효율적으로 관리하기 위함 
            // or, and, xor, not, shift-let, shift-right

            Console.WriteLine("");

            Console.WriteLine(a | b);
            Console.WriteLine(a & b);
            Console.WriteLine(a ^ b);
            Console.WriteLine(~a);
            Console.WriteLine(a << 3);
            Console.WriteLine(a >> 3);

            Console.WriteLine("");

            int test_num = 1;
            Console.WriteLine(test_num << 1);
            Console.WriteLine(test_num << 2);
            Console.WriteLine(test_num << 3);
            Console.WriteLine(test_num << 125);
            Console.WriteLine(~test_num << 1);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(OperatorMethods.Sum(a, b));
            



        }

        // FSM (Finite State Machine) 유한상태머신
        // 클래스의 상태에 따라서 다른 동작을 하기위해 사용
        [Flags]
        public enum e_FSM
        {
            

        }
    }
}
