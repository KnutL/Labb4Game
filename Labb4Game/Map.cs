using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Labb4Game
{
    public class Map
    {
        public const int RAD = 10;
        public const int KOLUMN = 19;

        public string[,] table = new string[RAD, KOLUMN];
        public Map()
        {
            for (int i = 0; i < RAD; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    table[i, j] = ".";
                }
            }
            for (int i = 0; i < RAD; i++)
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
    public enum Rooms
    {
        KeyRoom,
        ExitRoom,
        MonsterRoom,
        DoorRoom,
        EmptyRoom
    }
}

