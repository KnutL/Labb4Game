using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4Game
{
    //Alla olika sorters rum
    public enum TypeOfRooms
    {
        Exit,
        Monster
    }

    class Program
    {
        static void Main(string[] args)
        {            
            Wall wall = new Wall();

            bool gameRunning = true;
            while (gameRunning)
            {

                Console.WriteLine(wall);
                
                Console.ReadKey();
                
            }
        }
    }
/*
    ##############   n: rum med nyckel,  U: utgång (exit),  D: dörr
    #U.#n...M#@.n#   M: rum med monster
    ##D###D#MM#.M#   @: spelarens position
    #M...........#
    ##############
*/
}