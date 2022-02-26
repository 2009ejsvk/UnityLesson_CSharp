using System;

namespace dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board_img board_img = new Board_img();
            Console.WriteLine("시작합니다.");
            Console.WriteLine("▣ : 본인");
            int star_cnt = 0;
            Console.WriteLine("▩ : 샛별");
            int dice_cnt = 20;
            Console.WriteLine("주사위 갯수 : " + dice_cnt);
            Console.WriteLine("주사위를 굴리려면 Enter 를 누르세요.");
            Console.WriteLine();
            board_img.board_img_print();

            while (true)
            {
                Console.WriteLine();
                while (Console.ReadKey().Key != ConsoleKey.Enter) { Console.WriteLine("Enter 를 누르세요."); }

                Dice_img dice_Img = new Dice_img();
                Random random = new Random();
                int dice_num = random.Next(0, 6);

                dice_Img.dice_img_pring(dice_num);

                board_img.board_dice_num += (dice_num + 1);
                if (board_img.board_dice_num > 20)
                {
                    board_img.board_dice_num = 1;
                    Console.WriteLine("20을 넘겨 다시 돌아옵니다.");
                }
                if (board_img.board_dice_num % 5 == 0)
                {
                    star_cnt++;
                }

                dice_cnt--;
                Console.WriteLine("주사위 갯수 : " + dice_cnt);
                Console.WriteLine("샛별 갯수 : " + star_cnt);
                Console.WriteLine();
                
                board_img.board_img_print();

                if (dice_cnt == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("총 모은 샛별 갯수는 " + star_cnt + " 개 입니다 !");
                    break;
                }


            }

        }
    }
}
