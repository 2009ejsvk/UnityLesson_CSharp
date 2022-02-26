using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_dice
{
    // 게임 시작시 맵을 생성하고
    // 맵에 대한 정보를 가지고 있을 클래스
    internal class TileMap
    {
        public Dictionary<int, TileInfo> mapInfo = new Dictionary<int, TileInfo>();

        //맵을 세팅하고 맵에대한 정보를 가지고 있을 클래스
        public void MapSetup(int maxTileNum)
        {
            for (int i = 0; i<=maxTileNum; i ++)
            {
                if(i % 5 == 0 && i != 0)
                {
                    TileInfo tileInfo_Star = new TileInfo_Star();
                    //TileInfo_Star tileInfo_Star = new TileInfo_Star();
                    tileInfo_Star.index = i;
                    tileInfo_Star.name = "샛별";
                    tileInfo_Star.discription = "샛별타일";
                    mapInfo.Add(i, tileInfo_Star);
                    //상속 시 가능 -
                }
                else
                {
                    TileInfo tileInfo = new TileInfo();
                    tileInfo.index = i;
                    tileInfo.name = "더미";
                    tileInfo.discription = "더미타일";
                    mapInfo.Add(i, tileInfo);
                }

            }
        }
    }
}
