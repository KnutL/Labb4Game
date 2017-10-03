using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4Game
{
    class MovePlayer : Player
    {
        public void movePlayer()
        {
            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.W:
                    break;
                case ConsoleKey.A:
                    break;
                case ConsoleKey.S:
                    break;
                case ConsoleKey.D:
                    break;
                default:
                    break;
            }
        }
    }
}
