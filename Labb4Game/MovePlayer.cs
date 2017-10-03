using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4Game
{
    class MovePlayer : Player
    {
        private int PlayerRow = 5, PlayerColumn = 5;

        public MovePlayer()
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
