using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderUC5
{
    internal class SnakeLadder
    {
        public const int No_Play = 0, Ladder = 1, Snake = 2, Winning_Posi = 100;
        public int player_Posi = 0, DiceRoll;
        public void PlayGame()
        {
            Console.WriteLine("\n Start the game");
            Console.WriteLine("\n Starting position player is: " + player_Posi);
            Random random = new Random();

            while (player_Posi < Winning_Posi)
            {
                DiceRoll = random.Next(1, 7);
                Console.WriteLine("\n Player get Dice Number " + DiceRoll);

                switch (random.Next(0, 3))
                {
                    case No_Play:
                        Console.WriteLine("\n Player Position " + player_Posi);
                        break;

                    case Ladder:
                        player_Posi += DiceRoll;
                        if (player_Posi > Winning_Posi)
                        {
                            player_Posi -= DiceRoll;
                        }
                        Console.WriteLine("\n Ladder Player Position " + player_Posi);
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
                Console.WriteLine("\n Congratulations you Won");
            }

        }
    }

}
