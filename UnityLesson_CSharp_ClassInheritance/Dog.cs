using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_ClassInheritance
{
    internal class Dog : Creature, IFourLeggedWalker
    {
        public float height;

        public override void Breath()
        {
            // 부모에 있는거 불러올때 base
            base.Breath();
            height += 1;
        }

        public void FourLeggedWalker()
        {
            Console.WriteLine("네발로 걷는다");
        }
    }
}
