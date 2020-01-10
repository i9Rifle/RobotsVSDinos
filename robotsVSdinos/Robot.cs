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

        public string Name;
        public int Health;
        public int Power;
        public string RobotWeapon;
        public int RobotAttackDamage;
        public int RobotAttackPowerCost;

        //Constructor

        public Robot(string type, int health, int power, string robotWeapon, int robotAttackDmg, int PowerCost)
        {
            Name = type;
            Health = health;
            Power = power;
            RobotWeapon = robotWeapon;
            RobotAttackDamage = robotAttackDmg;
            RobotAttackPowerCost = PowerCost;

        }
        //MemMethods

        public void CharacterSelection()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "Tank":
                    Robot Tank = new Robot(Tank, 230, 150, Melee, 5, 2);
                    break;
                case "Mage":
                    Robot Mage = new Robot(Mage, 150, 225, Staff, 15, 12);
                    break;
                case "Guard":
                    Robot Guard = new Robot(Guard, 185, 185, Bow, 10, 7);
                    break;
                default:
                    Console.WriteLine("")
            }



        }
    }
}    
