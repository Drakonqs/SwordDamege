using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordDamege
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage(RollDice());
            while (true)
            {
                Console.Write("Нажатие 0 - меч обычный, 1 - магический, 2 - огненый, " + "3 - и то и то, любая другая, выход: ");
                char key = Console.ReadKey().KeyChar;
                if (key != '0' && key != '1' && key != '2' && key != '3') return;
                swordDamage.Roll = RollDice();
                swordDamage.Magic = (key == '1' || key == '3');
                swordDamage.Flaming = (key == '2' || key == '3');
                Console.WriteLine($"\nБросок  {swordDamage.Roll} наносит повреждений {swordDamage.Damage} HP\n");
            }
        }
        private static int RollDice()//Бросок кубика
        {
            return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
        }
    }
}
//static void Main(string[] args)
//{
//    while (true)
//    {
//        Random random = new Random();
//        SwordDamage swordDamage = new SwordDamage();
//        Console.Write("Нажатие 0 - меч обычный, 1 - магический, 2 - огненый, " + "3 - и то и то, любая другая, выход: ");
//        char key = Console.ReadKey().KeyChar;
//        if (key != '0' && key != '1' && key != '2' && key != '3') return;
//        int roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
//        swordDamage.Roll = roll;
//        swordDamage.SetMagic(key == '1' || key == '3');
//        swordDamage.SetFlaming(key == '2' || key == '3');
//        Console.WriteLine("\nБросок " + roll + " наносит повреждений " + swordDamage.Damage + " HP\n");

//    }

//}