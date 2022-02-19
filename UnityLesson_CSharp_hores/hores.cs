using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_hores
{
      
    internal class hores
    {
        public int hores_speed;
        public int hores_distance = 0;
        public void speed()
        {
            Random rand = new Random();
            hores_speed = rand.Next(20,30) + 1;
        }
    }
}
