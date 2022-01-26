using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderUC6
{
    internal class SnakeLadder
    {
        public const int No_Play = 0, Ladder = 1, Snake = 2, Winning_Posi = 100;
        public int player_Posi = 0, DiceRoll, DiceCount = 0;
        public void PlayGame()
        {
            Console.WriteLine("\n start the game");
            Console.WriteLine("Starting position player is: " + player_Posi);
            Random rand = new Random();

            while (player_Posi < Winning_Posi)
            {
                DiceRoll = rand.Next(1, 7);
                DiceCount++;
                Console.WriteLine("\n DiceCount {0} \n Player get Dice Number {1}", DiceCount, DiceRoll);

                switch (rand.Next(0, 3))
                {
                    case No_Play:
                        Console.WriteLine("\n No play Player Position: " + player_Posi);
                        break;

                    case Ladder:
                        player_Posi += DiceRoll;
                        if (player_Posi > Winning_Posi)
                        {
                            player_Posi -= DiceRoll;
                        }
                        Console.WriteLine("\n Ladder Player Position: " + player_Posi);
                        break;

                    case Snake:
                        player_Posi -= DiceRoll;
                        if (player_Posi < 0)
                        {
                            player_Posi = 0;
                        }

                        Console.WriteLine("\n Snake Player Position " + player_Posi);
                        break;
                }

            }
            Console.WriteLine("\n Congratulations you Won ");
            Console.WriteLine("Number of times the Dice was played to win game: " + DiceCount);
        }
    }
}

