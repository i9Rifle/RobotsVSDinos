using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVSdinos
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "Mage":
                    Robot Mage = new Robot("Mage", 4, "Staff", 2, 5);
                    break;
            
            }
        }
    }
}
