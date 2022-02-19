using System;
using System.Collections.Generic;

namespace UnityLesson_CSharp_ClassInheritance
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Creature creature = new Creature();
            for (int i = 0; i < 10; i++)
            {
                creature.Breath();
            }
            Console.WriteLine(creature.age);

            Human human = new Human();
            for (int i = 0;i < 10;i++)
            {
                human.Breath();
            }
            Console.WriteLine(human.age);
            Console.WriteLine(human.height);

            WhiteMan whiteMan = new WhiteMan();
            for (int i = 0; i < 10; i++)
            {
                whiteMan.Breath();
            }
            Console.WriteLine(whiteMan.age);
            Console.WriteLine(whiteMan.height);

            Console.WriteLine();
            human.TwoLeggedWalk();

            WhiteMan[] whiteMan_ = new WhiteMan[10];
            

            for (int i = 0; i < 10; i++)
            {
                whiteMan_[i] = new WhiteMan();
                whiteMan_[i].TwoLeggedWalk();
            }

            Console.WriteLine();
            Console.WriteLine();


            // 자식 객체를 부모 클래스타입으로 인스턴스화 시키고
            // 해당 virtual 멤버 함수를 호출하면
            // 자식 개체의 override 된 함수가 호출된다.
            Human testHuman = new WhiteMan();

            // case : 위 성질을 이용하여 부모클래스(Human) 리스트 하나만 생성
            List<Human> humen = new List<Human>();
            for (int i = 0; i < 20; i++)
            {
                Human tmpHuman1 = new WhiteMan();
                humen.Add(tmpHuman1);
            }
            foreach (Human item in humen)
            {
                item.TwoLeggedWalk();
            }

            Console.WriteLine();
            Console.WriteLine();

            
            // 인터페이스 인스턴스화 예시
            ITwoLeggedWalker iTwoLeggedWalker = new WhiteMan();
            iTwoLeggedWalker.TwoLeggedWalk();
            // case : 인터페이스로 인스턴스화 시키는 방법
            List<ITwoLeggedWalker> walkers = new List<ITwoLeggedWalker>();
            for (int i = 0; i <20; i ++)
            {
                ITwoLeggedWalker tmpwalker1 = new WhiteMan();
                walkers.Add(tmpwalker1);
            }
            foreach (var item in walkers)
            {
                item.TwoLeggedWalk();
            }


        }
    }
}
