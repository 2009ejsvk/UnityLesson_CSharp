using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_ClassInheritance
{
    internal class Creature
    {
        public string DNA;
        public float age;
        public float weight;

        // vritual 오버라이딩 가능 하게끔
        // 부모클래스가 함수라고 해서 전부 X
        // 자식클래스에서 재정의할 때 만
        // overide : 부모의 virtual 키워드가 붙은 함수 재정의
        virtual public void Breath()
        {
            age++;
        }
    }
}
