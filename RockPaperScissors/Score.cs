using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Score
    {
        public Score()
        {

        }
        public int UserScore { get; set; } = 0;
        public int ComputerScore { get; set; } = 0;
        public bool LessThanTwoGamesWon { get; set; } = true;

        public void BestTwoOutOfThree(int userScore , int cpuScore)
        {
            if ((userScore < 2) && (cpuScore < 2))
            {
                Console.WriteLine($"Current score is :\n" +
                                  $"-----------------------------------\n" +
                                  $"User: {userScore}\n" +
                                  $"CPU: {cpuScore}\n" +
                                  $"-----------------------------------\n");
                LessThanTwoGamesWon = true;
            }
            else if (userScore == 2)
            { 
                Console.WriteLine("You Win the Best Two out of Three!");
                Console.WriteLine($"Final Score was:\n" +
                                  $"-----------------------------------\n" +
                                  $"User: {userScore}\n" +
                                  $"CPU: {cpuScore}\n" +
                                  $"-----------------------------------\n");
                LessThanTwoGamesWon = false;
            }
            else if (cpuScore == 2)
            {
                Console.WriteLine("CPU Wins the Best Two out of Three!");
                Console.WriteLine($"Final Score was:\n" +
                                 $"-----------------------------------\n" +
                                 $"User: {userScore}\n" +
                                 $"CPU: {cpuScore}\n" +
                                 $"-----------------------------------\n");
                LessThanTwoGamesWon = false;
            }
        }
    }
}
