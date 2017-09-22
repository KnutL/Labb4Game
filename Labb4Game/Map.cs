using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Labb4Game
{
    class Map
    {
        public Map()
        {
            int[,] table = new int[5,6];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        table[i, j] = i*j;
                    }
                    else
                    {
                        table[i, j] = i*j;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(table[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
