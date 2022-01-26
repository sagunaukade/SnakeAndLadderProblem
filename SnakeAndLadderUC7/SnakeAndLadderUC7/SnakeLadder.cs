using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderUC7
{
    internal class SnakeLadder
    {
        public const int No_Play = 0, Ladder = 1, Snake = 2, Winning_Posi = 100;
        public static int DiceRoll, players = 1;

        public static int[] player = new int[3] { 0, 0, 0 };
        public static int[] playerDiceCount = new int[3] { 0, 0, 0 };

        public static Random rand = new Random();

        public static void PlayerSwitch()
        {

            while (player[1] < Winning_Posi && player[2] < Winning_Posi)
            {
                if (players == 1)
                {
                    PlayGame(1);
                    players = 2;
                    continue;

                }
                if (players == 2)
                {
                    PlayGame(2);
                    players = 1;
                    continue;
                }
            }
        }
        public static void PlayGame(int playerNum)
        {
            DiceRoll = rand.Next(1, 7);
            Console.WriteLine("\n Player {0} get Dice value {1}", playerNum, DiceRoll);
            playerDiceCount[playerNum]++;
            switch (rand.Next(0, 3))
            {
                case No_Play:
                    Console.WriteLine("\n No Play Player Position: " + player[playerNum]);
                    break;

                case Ladder:
                    player[playerNum] += DiceRoll;

                    if (player[playerNum] > Winning_Posi)
                    {
                        player[playerNum] -= DiceRoll;   //Player stays at same position if player position is more than 100
                    }
                    Console.WriteLine("\n Ladder Player Position: " + player[playerNum]);
                    if (player[playerNum] == Winning_Posi)
                    {
                        Console.WriteLine("\nPlayer {0} Won the Game With Dice Count Of {1} ", playerNum, playerDiceCount[playerNum]);
                        break;
                    }
                    PlayGame(playerNum);
                    break;

                case Snake:
                    player[playerNum] -= DiceRoll;

                    if (player[playerNum] < 0)
                    {
                        player[playerNum] = 0;
                    }
                    Console.WriteLine("(Snake) Player Position " + player[playerNum]);
                    break;
            }
        }
    }
}




