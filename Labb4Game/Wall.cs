using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4Game
{
    class Wall : Map
    {
        
        public Wall()
        {
            //Skapar ytterväggarna
            for (int i = 0; i < RAD; i++)
            {
                for(int j = 0; j < KOLUMN; j++)
                {
                    if (j == 0 || j == KOLUMN-1 || i == 0 || i == RAD-1)
                        table[i, j] = "#";
                }
            }

            //Sakapr ett rum
            for(int i = 1; i < RAD; i++)
            {
                for(int j = 6; j < KOLUMN; j++)
                {
                    table[i, j] = "#";
                }
            }

            //Skriver ut
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
