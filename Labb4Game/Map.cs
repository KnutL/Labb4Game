using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Labb4Game
{
    class Map
    {
        public string[,] table = new string[6, 14];
        public Map()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    table[i, j] = ".";
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    Console.Write(table[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

