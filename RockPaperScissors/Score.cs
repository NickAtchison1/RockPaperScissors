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

        public bool BestTwoOutOfThree()
        {
            int userScore = 0;
            int cpuScore = 0;
            bool twoGamesWon = false;
            if (UserScore < 2)
            {
                userScore = UserScore;
                cpuScore = ComputerScore;
            }
            else if (UserScore == 2)
            {
                userScore = UserScore;
                cpuScore = ComputerScore;
                Console.WriteLine("You Win!");
                twoGamesWon = true;
            }
            else if (ComputerScore == 2)
            {
                userScore = UserScore;
                cpuScore = ComputerScore;
                Console.WriteLine("CPU Wins!");
                twoGamesWon = true;
            }
            return twoGamesWon;
        }
    }
}
