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
            for (int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 14; j++)
                {
                    if (j == 0 || j == 13)
                        table[i, j] = "#";
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    if(i == 0 || i == 5)
                        table[i, j] = "#";
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
