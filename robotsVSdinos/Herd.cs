using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVSdinos
{
    public class Herd
    {
        //MemVars
        public List<Dino> GoodGuys = new List<Dino>();

        //Construct
        
        public Herd(int Rex, int Raptor, int Stegosaurus)
        {
            GoodGuys = new List<Dino>();
        }
        //MemMethods
        public void CharacterSelection()
        {
            Console.WriteLine("Select Dino Type: Rex, Raptor, Stegosaurus");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "Rex":
                    Dino Rex = new Dino("Rex", 200, 150, "Chomp", 15, 12);
                    break;
                case "Raptor:":
                    Dino Raptor = new Dino("Raptor", 155, 215, "QuickAttack", 10, 7);
                    break;
                case "Stegosaurus":
                    Dino Stegosaurus = new Dino("Stegosaurus", 230, 150, "Bite", 5, 2);
                    break;
                default:
                    Console.WriteLine("You Must Choose A Dino Type: Rex, Raptor, Stegosaurus");
                    break;
            }
        }
    }
}
