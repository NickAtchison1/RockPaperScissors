using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class ProgramUI
    {

        public void Run()
        {
            RunGame();
        }

        private void RunGame()
        {
            Console.Clear();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Let's Play Rock, Paper, Scissors\n" +
                    "\n" +
                    "1. Start a Series of Games\n" +
                    "2. Play a Best Two out of Three\n" +
                    "3. Exit\n");


                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        StartGame();
                        break;
                    case "2":
                        StartBestTwoOutOfThree();
                        break;
                    case "3":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Selection.");
                        WaitForKey();
                        break;
                }
                Console.Clear();
            }
        }

        private void StartGame()
        {
            Score score = new Score();

            int userScore = score.UserScore;
            int cpuScore = score.ComputerScore;

            bool gameIsRunning = true;
            while (gameIsRunning)
            {
                int user = UserAction();
                int cpu = ComputerAction();

                if ((user == 1 && cpu == 3) || (user == 2 && cpu == 1) || (user == 3 && cpu == 2))
                {
                    Console.WriteLine("User Wins!");
                    userScore++;
                    Console.WriteLine($"Current score is:\n" +
                        $"-----------------------------------\n" +
                        $"User: {userScore}\n" +
                        $"CPU: {cpuScore}\n" +
                        $"-----------------------------------\n");
                    GameLoop();
                }
                else if ((user == 3 && cpu == 1) || (user == 1 && cpu == 2) || (user == 2 && cpu == 3))
                {
                    Console.WriteLine("CPU Wins!");
                    cpuScore++;
                    Console.WriteLine($"Current score is:\n" +
                        $"-----------------------------------\n" +
                        $"User: {userScore}\n" +
                        $"CPU: {cpuScore}\n" +
                        $"-----------------------------------\n");
                    GameLoop();
                }
                else
                {
                    Console.WriteLine("Tie Game");
                    Console.WriteLine($"Current score is:\n" +
                        $"-----------------------------------\n" +
                        $"User: {userScore}\n" +
                        $"CPU: {cpuScore}\n" +
                        $"-----------------------------------\n");
                    GameLoop();
                }
            }
        }

        private void StartBestTwoOutOfThree()
        {
            Score score = new Score();

            int userScore = score.UserScore;
            int cpuScore = score.ComputerScore;
            do
            {
                int user = UserAction();
                int cpu = ComputerAction();

                if ((user == 1 && cpu == 3) || (user == 2 && cpu == 1) || (user == 3 && cpu == 2))
                {
                    Console.WriteLine("User Wins");
                    userScore++;
                    score.BestTwoOutOfThree(userScore, cpuScore);
                    if (score.LessThanTwoGamesWon == false)
                    {
                        WaitForKey();
                        RunGame();
                    }
                    WaitForKey();
                }
                else if ((user == 3 && cpu == 1) || (user == 1 && cpu == 2) || (user == 2 && cpu == 3))
                {
                    Console.WriteLine("CPU Wins!");
                    cpuScore++;
                    score.BestTwoOutOfThree(userScore, cpuScore);
                    if (score.LessThanTwoGamesWon == false)
                    {
                        WaitForKey();
                        RunGame();
                    }
                    WaitForKey();
                }
                else
                {
                    Console.WriteLine("Tie Game");
                    score.BestTwoOutOfThree(userScore, cpuScore);
                    WaitForKey();
                }
            }
            while (score.LessThanTwoGamesWon);
        }

        private int UserAction()
        {
            Console.Clear();
            Console.WriteLine("Select:\n" +
                "1. Rock\n" +
                "2. Paper\n" +
                "3. Scissors\n");
            string actionString = Console.ReadLine();
            int actionNumber = Convert.ToInt32(actionString);
            GameActions action = new GameActions();
            ASCIIArt art = new ASCIIArt();
            string artToDisplay = art.Artwork.FirstOrDefault(a => a.Key == actionNumber).Value.ToString();
            Console.Clear();

            switch (actionNumber)
            {
                case 1:
                    Console.WriteLine("You chose Rock!");
                    Console.WriteLine(artToDisplay);
                    action.Actions = GameActions.Action.ROCK;
                    break;
                case 2:
                    Console.WriteLine("You chose Paper!");
                    Console.WriteLine(artToDisplay);
                    action.Actions = GameActions.Action.PAPER;
                    break;
                case 3:
                    Console.WriteLine("You chose Scissors!");
                    Console.WriteLine(artToDisplay);
                    action.Actions = GameActions.Action.SCISSORS;
                    break;
                default:
                    Console.WriteLine("Invalid Selection.");
                    WaitForKey();
                    break;
            }
            Thread.Sleep(1000);
            return actionNumber;
        }

        private int ComputerAction()
        {
            Random random = new Random();
            int cpuChoice = random.Next(1, 4);
            GameActions action = new GameActions();
            ASCIIArt art = new ASCIIArt();
            string artToDisplay = art.Artwork.FirstOrDefault(a => a.Key == cpuChoice).Value.ToString();
            switch (cpuChoice)
            {
                case 1:
                    Console.WriteLine("CPU chose Rock!");
                    Console.WriteLine(artToDisplay);
                    action.Actions = GameActions.Action.ROCK;
                    break;
                case 2:
                    Console.WriteLine("CPU chose Paper!");
                    Console.WriteLine(artToDisplay);
                    action.Actions = GameActions.Action.PAPER;
                    break;
                case 3:
                    Console.WriteLine("CPU chose Scissors!");
                    Console.WriteLine(artToDisplay);
                    action.Actions = GameActions.Action.SCISSORS;
                    break;
                default:
                    Console.WriteLine("Invalid Selection.");
                    WaitForKey();
                    break;
            }
            Thread.Sleep(1000);
            return cpuChoice;
        }

        private void WaitForKey()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private void GameLoop()
        {
            Console.WriteLine("Press 'Q' to quit, otherwise press any other key for a new game.");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "Q":
                    RunGame();
                    break;
                default:
                    break;
            }
        }
    }
}
