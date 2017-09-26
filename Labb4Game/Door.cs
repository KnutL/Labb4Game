using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Labb4Game
{
    public class Map
    {
        public Map()
        {
            int[,] Map = new int[6, 9];
            for(int y=0; y < 6; y++)
            {
                for(int x = 0; x < 9; x++)
                {
                    Map[y, x] = x * y;
                    Console.WriteLine("-");
                }
                Console.WriteLine("#");
            }
        }
    }
    public class Door : Map
    {

    }
    public class Room : Map
    {

    }
    public class Wall : Map
    {

    }
}
