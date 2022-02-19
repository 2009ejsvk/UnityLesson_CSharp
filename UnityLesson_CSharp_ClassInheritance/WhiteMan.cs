using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_ClassInheritance
{
    internal class WhiteMan : Human
    {
        int plus_age = 1;

        public override void Breath()
        {
            // 부모에 있는거 불러올때 base
            base.Breath();
            age += plus_age;
            height += (float)0.2;
        }
    }
}
