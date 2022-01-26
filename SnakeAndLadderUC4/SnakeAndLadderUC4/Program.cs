using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderUC4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Welcome to Snake and Ladder programs \n");
            SnakeLadder player = new SnakeLadder();
            player.PlaySnakeAndLadder();
            Console.ReadLine();
        }
    }
}
