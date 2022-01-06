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
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Let's Play Rock, Paper, Scissors\n" +
                    "\n" +
                    "1. Start Game\n" +
                    "2. Exit\n");


                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        StartGame();
                        break;
                    case "2":
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
            int user = UserAction();
            int cpu = ComputerAction();
            if ((user == 1 && cpu == 3) || (user == 2 && cpu == 1) || (user == 3 && cpu == 2))
            {
                Console.WriteLine("User Wins");
                WaitForKey();
            }

            else if ((user == 3 && cpu == 1) || (user == 1 && cpu == 2) || (user == 2 && cpu == 3))
            {
                Console.WriteLine("CPU Wins!");
                WaitForKey();
            }
            else
            {
                Console.WriteLine("Tie Game");
                WaitForKey();
            }
        }

        private int UserAction()
        {
            Console.WriteLine("Select:\n" +
                "1. Rock\n" +
                "2. Paper\n" +
                "3. Scissors\n");
            string actionString = Console.ReadLine();
            int actionNumber = Convert.ToInt32(actionString);
            GameActions action = new GameActions();
            
            ASCIIArt art = new ASCIIArt();
            string artToDisplay = art.Artwork.FirstOrDefault(a => a.Key == actionNumber).Value.ToString();
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
    }
}
