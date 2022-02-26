using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_dice
{
    internal class TileInfo
    {
        //각 칸들의 정보를 멤버로 가지는 클래스
        public int index; //몇번째 칸인지
        public string name;
        public string discription;

        public virtual void TileEvent()
        {
            Console.WriteLine("칸 : " + index);
            Console.WriteLine("이름 : " + name);
            Console.WriteLine(discription);
        }
    }
}
