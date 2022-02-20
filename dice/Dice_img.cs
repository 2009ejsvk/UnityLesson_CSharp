using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice
{
    internal class Dice_img
    {
        public void dice_img_pring(int dice_num)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            String[] dice_img = new String[6] { "⚀", "⚁", "⚂", "⚃", "⚄", "⚅" } ;
            Console.WriteLine(dice_img[dice_num] + " : " + (dice_num + 1));
        }
    }
}
