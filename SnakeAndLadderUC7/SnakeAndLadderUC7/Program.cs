using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderUC7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Welcome to Snake and Ladder programs \n");
            Console.WriteLine("\n Start the game");

            Console.WriteLine("Starting position player 1 and 2 is 0 0");

            SnakeLadder.PlayerSwitch();
            Console.ReadLine()
        }
    }
}
