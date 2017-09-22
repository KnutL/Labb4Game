using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4Game
{
    class Player
    {
        private string Name { get; set; } = "Player";


        //Prints the players inventory
        public static void PrintInventory(List<String> Inventory)
        {
            if (Inventory.Count() == 0)
            {
                Console.WriteLine("You have no items in your bag.");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Your inventory contains:");

                foreach (String item in Inventory)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("\n \n Press any key to return...");
                Console.ReadKey();

            }
        }
    }
}
