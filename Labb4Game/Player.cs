using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4Game
{
    class Player : Map
    {
        public List<String> Inventory = new List<String>();
        public string Name { get; set; } = "Player";

        public static Player p1 { get; set; }
        private void button1_click(object sender, EventArgs e)
        {
            p1 = new Player();
        }

        public int turn = 0;
        public int testnummer = 1;
        public void Increase(int testnummer)
        {
            this.turn = turn + 1;
        }

        //För att få spelare att röra på sig

    
        static int PlayerRow = 5, PlayerColumn = 5;
       
        //För att få spelare att röra på sig
        public static void PlayerMove()
        {
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.W)
                PlayerRow--;
            else if (key.Key == ConsoleKey.A)
                PlayerColumn--;
            else if (key.Key == ConsoleKey.S)
                PlayerRow++;
            else if (key.Key == ConsoleKey.D)
                PlayerColumn++;
        }
    }
}
