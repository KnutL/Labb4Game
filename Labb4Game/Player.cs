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
       

        private string Name { get; set; } = "Player";

        public char PlayerIcon = '@';

        public static Player p1 { get; set; }
        private void button1_click(object sender, EventArgs e)
        {
            p1 = new Player();
        }

        private int turn;
        public void Increase()
        {
            turn++;
        }
    }
}
