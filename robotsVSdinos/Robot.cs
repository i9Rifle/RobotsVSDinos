using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVSdinos
{
    public class Robot 
    {
        //MemVars

        string name1;
        int health1;
        int power1;
        string robotWeapon1;
        int robotAttackDamage1;
        int robotAttackPowerCost1;

        string name2;
        int health2;
        int power2;
        string robotWeapon2;
        int robotAttackDamage2;
        int robotAttackPowerCost2;

        string name3;
        int health3;
        int power3;
        string robotWeapon3;
        int robotAttackDamage3;
        int robotAttackPowerCost3;

        //Constructor

        public Robot()
        {
            name1 = ("Tank");
            health1 = 220;
            power1 = 165;
            robotWeapon1 = ("Mecro Melee");
            robotAttackDamage1 = 4;
            robotAttackPowerCost1 = 1;

            name2 = ("Mage");
            health2 = 135;
            power2 = 210;
            robotWeapon2 = ("Mecro Blast");
            robotAttackDamage2 = 22;
            robotAttackPowerCost2 = 14;

            name3 = ("Guard");
            health3 = 170;
            power3 = 185;
            robotWeapon3 = ("Mecro Bow");
            robotAttackDamage3 = 13;
            robotAttackPowerCost3 = 8;
        }
        //MemMethods
        public void RobotSelect()
        {
            Console.WriteLine("Select Guard, Mage, or Tank \n");
            string character = Console.ReadLine();

            switch (character)
            {
                case "Tank":
                    Console.WriteLine("Selected " + character);
                    break;
                case "Mage":
                    Console.WriteLine("Selected " + character);
                    break;
                case "Guard":
                    Console.WriteLine("Selected " + character);
                    break;
                default:
                    Console.WriteLine("Must Select Guard, Mage, or Tank");
                    break;
            }
        }
        public void Use()
        {
            RobotSelect();
        }
            
        
    }
}
