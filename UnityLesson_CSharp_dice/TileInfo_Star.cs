using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_dice
{
    internal class TileInfo_Star:TileInfo
    {
        //샛별칸을 위한 클래스. TileInfo 를 상속받고 샛별칸에 대한 특수 정보를 멤버로 추가함
        public int starValue = 3;
        public override void TileEvent()
        {
            base.TileEvent();
            starValue++;
        }
    }
}
