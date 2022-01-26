using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Welcome to Snake and Ladder programs ");
            Console.WriteLine("\n Start the game");
            Console.WriteLine("\n Starting position player 1 and 2 is 0 0");
            SnakeLadder.PlayerSwitch();
            Console.ReadLine();
        }
    }
}
