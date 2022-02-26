using System;
using System.Collections.Generic;

namespace UnityLesson_CSharp_dice
{
    internal class Program
    {
        static private int totalTile        = 20;   // 칸의 갯수
        static private int previousTileIndex = 0; // 이전 칸의 번호 ( 플레이어가 샛별칸을 지나는지 비교하기위함 )
        static private int currentTileIndex = 0; // 현재 칸의 번호
        static private int currentStarPoint = 0;    // 현재 샛별점수
        static private int totalDiceNumber  = 20;   // 총 주사위 갯수
        static private Random random;

        static void Main(string[] args)
        {
            int currentTileIndex = 0;    // 현재 칸의 인덱스
            int currentStarIndex = 0;    // 현재 샛별
            
            TileMap map = new TileMap();
            map.MapSetup(totalTile);

            int currentDiceNum = totalDiceNumber;
            
            while(currentDiceNum > 0)
            {
                Console.WriteLine();
                Console.WriteLine("주사위를 굴리려면 Enter 를 누르세요.");
                Console.WriteLine();
                while (Console.ReadKey().Key != ConsoleKey.Enter) { Console.ReadLine(); Console.WriteLine("Enter 를 누르세요."); }

                random = new Random();
                int diceValue = random.Next(1,6) + 1;
                Console.WriteLine("주사위 : " + diceValue);
                DisplayDice(diceValue);
                totalDiceNumber--;
                currentTileIndex += diceValue; // 주사위 눈금만큼 플레이어 전진
                currentTileIndex += diceValue;
                if (currentTileIndex > totalTile) {
                    currentTileIndex -= totalTile;
                }
                Console.WriteLine("현재 위치 : " + currentTileIndex);
                TileInfo info = map.mapInfo.GetValueOrDefault(currentTileIndex);
                if (info == null)
                {
                    return;
                }

                if (previousTileIndex/5 < currentTileIndex / 5)
                {
                    int passdSatrTileIndex = currentTileIndex / 5 * 5;
                    TileInfo_Star tileInfo_Star = (TileInfo_Star)map.mapInfo.GetValueOrDefault(passdSatrTileIndex);
                    Console.WriteLine("TEST : " + tileInfo_Star.starValue);
                    if (tileInfo_Star != null)
                    {
                        currentStarPoint += tileInfo_Star.starValue;
                    }
                }

                info.TileEvent();

                previousTileIndex = currentTileIndex;
                Console.WriteLine("현재 샛별 : " + currentStarPoint);
                Console.WriteLine("남은 주사위 : " + totalDiceNumber);
                
                if (totalDiceNumber == 0)
                {  
                    Console.WriteLine(currentStarPoint);
                    break;
                }


            }


        }

        static void DisplayDice(int diceValue)
        {
            switch (diceValue)
            {
                case 1:
                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│     ●    │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("└───────────┘");
                    break;
                case 2:
                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●        │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│         ●│");
                    Console.WriteLine("└───────────┘");
                    break;
                case 3:
                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●        │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│     ●    │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│         ●│");
                    Console.WriteLine("└───────────┘");
                    break;
                case 4:
                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("└───────────┘");
                    break;
                case 5:
                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│     ●    │");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("└───────────┘");
                    break;
                case 6:
                    Console.WriteLine("┌───────────┐");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("│           │");
                    Console.WriteLine("│ ●      ●│");
                    Console.WriteLine("└───────────┘");
                    break;
                default:
                    break;
            }
        }

        static int CalcPassedStarTileIndex(int currentTileIndex)
        {
            int index = currentTileIndex / 5 * 5;
            return index;
        }
    }
}
