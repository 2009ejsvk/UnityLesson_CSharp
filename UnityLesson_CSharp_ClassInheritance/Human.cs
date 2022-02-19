using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_ClassInheritance
{
    internal class Human : Creature , ITwoLeggedWalker
    {

        public float height;

        public override void Breath()
        {
            // 부모에 있는거 불러올때 base
            base.Breath();
            height += 1;
        }

        public void TwoLeggedWalk()
        {
            Console.WriteLine("두발로 걷는다");
        }
    }
}
