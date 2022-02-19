using System;

namespace UnityLesson_CSharp_ClassObjectInstance
{
    internal class Program
    {
        // AA 클래스
        // 접근 제한자
        // public      : 다른 모든 클래스에서 접근할 수 있다.
        // private     : 다른 클래스에서 접근할 수 없다.
        // protected   : 상속받은 클래스에서만 접근할 수가 있다.
        // internal    : 같은 어셈블리 ( 같은 프로젝트 ) 에서만 접근할 수가 있다.
        // 기본적으로 접근제한자를 명시하지 않으면 private
        class AA
        {
            public AA()
            {

            }
            public AA(int a)
            {

            }

            // 안쓰면 C# 에서 지워버림
            // 소멸자
            ~AA()
            {

            }

            public void BB()
            {
                Console.WriteLine("AA - BB");
            }

            public string CC(string word_1)
            {
                string word_2 = "";
                word_2 = word_1;
                return word_2;
            }
        }

        static void Main(string[] args)
        {
            //객체 생성
            AA aa = new AA();  // 생성자
                               // 클래스 이름과 똑같은 함수
                               // 객체를 생성하고 반환

                                // 인스턴스화
                                // 메모리 공간에 객체를 할당
                                // new AA() 로 생성된 객체를 반환한 값(객체)이 AA 타입변수 aa 에 할당됨.
                                // aa 변수를 통해서 생성된 객체에 접근할 수가 있게 됨.
                                // 새로 생성된 객체가 할당된 aa 변수를 인스턴스라고 함.

                                // AA 는 힙 영역에 있음
                                // 힙 영역을 불러야 해서 'AA aa =' 형식으로 스텍으로 주소 찍음
            aa.BB();
            Console.WriteLine(aa.CC("세상"));
        }
    }
}
