using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Labb4Game
{
    abstract class Map
    {
        public const int RAD = 10;
        public const int KOLUMN = 19;

        public string[,] table = new string[RAD, KOLUMN];
        public Map()
        {
            //Skapar kartan
            for (int i = 0; i < RAD; i++)
            {
                for (int j = 0; j < KOLUMN; j++)
                {
                    table[i, j] = ".";
                }
            }

            //Ritar ut kartan
            for (int i = 0; i < RAD; i++)
            {
                for (int j = 0; j < KOLUMN; j++)
                {
                    Console.Write(table[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

