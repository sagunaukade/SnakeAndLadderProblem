using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderUC6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Simulator program \n");
            SnakeLadder player = new SnakeLadder();
            player.PlayGame();
            Console.ReadLine();
        }
    }
}
