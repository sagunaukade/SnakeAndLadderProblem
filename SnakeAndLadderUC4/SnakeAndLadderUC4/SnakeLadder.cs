using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderUC4
{
    internal class SnakeLadder
    {
        public const int No_Play = 0, Ladder = 1, Snake = 2, Winning_Posi = 100;
        public int player_Posi = 0, DiceRoll;
        public void PlaySnakeAndLadder()
        {
            Console.WriteLine("\n Start the Game ");
            Console.WriteLine("\n Starting position player is: " + player_Posi);
            Random random = new Random();

            while (player_Posi < Winning_Posi)
            {
                DiceRoll = random.Next(1, 7);
                Console.WriteLine("Player gets Dice Number: " + DiceRoll);

                switch (random.Next(0, 3))
                {
                    case No_Play:
                        Console.WriteLine("\n No Play");
                        break;

                    case Ladder:
                        player_Posi += DiceRoll;
                        Console.WriteLine("\n Ladder " + player_Posi);
                        break;

                    case Snake:
                        player_Posi -= DiceRoll;
                        Console.WriteLine("\n Snake " + player_Posi);
                        if (player_Posi < 0)
                        {
                            player_Posi = 0;
                        }
                        break;
                }
            }
        }
    }
}
