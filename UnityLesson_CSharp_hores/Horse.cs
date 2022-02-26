using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_hores
{
      
    internal class Horse
    {
        public bool available = true;
        public string name;
        public int distance;
        public void Run(int moveDistance)
        {
            distance += moveDistance;
        }
    }
}
