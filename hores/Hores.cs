using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hores
{
    internal class Hores
    {
        public int hores_speed;
        public int hores_distance;
        public void speed()
        {
            Random random = new Random();
            hores_speed = random.Next(20,30) + 1;
        }
    }
}
