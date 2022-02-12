using System;

namespace UnityLesson_CSharp_Structure_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Equipment equipment_only = new Equipment();
            Equipment[] equipment = new Equipment[10];

            equipment_only.stats._DEX = 1;
            equipment_only._equipmentAbility._DEF = 1;
            Console.WriteLine(equipment_only.stats._DEX + " / " + equipment_only._equipmentAbility._DEF);

            for (int i = 0; i < equipment.Length; i++)
            {
                equipment[i] = new Equipment();
                equipment[i].stats._DEX = 1;
                equipment[i]._equipmentAbility._DEF = 1;

                Console.WriteLine(equipment[i].stats._DEX + " / " + equipment[i]._equipmentAbility._DEF);
            }
        }
    }
}
