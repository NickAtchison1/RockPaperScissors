using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class ProgramUI
    {
        private void Run()
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
            Console.WriteLine("Select:\n" +
                "1. Rock\n" +
                "2. Paper\n" +
                "3. Scissors\n");
            string actionString = Console.ReadLine();
            int actionNumber = Convert.ToInt32(actionString);
            GameActions action = new GameActions();
            switch (actionNumber)
            {
                case 1:
                    action.Actions = GameActions.Action.ROCK;
                    break;
                case 2:
                    action.Actions = GameActions.Action.PAPER;
                    break;
                case 3:
                    action.Actions = GameActions.Action.SCISSORS;
                    break;
            }
        }

        //private void UserAction ()
        //{
        //    GameActions gameAction = new GameActions();
        //    gameAction.action = Convert.ToInt32(Console.ReadLine());
        //    //int userInput = Convert.ToInt32(Console.ReadLine());
        //    if (gameAction.action == 1)
        //    {
        //        gameAction.action.ROCK;
        //    };
        //}

        private void WaitForKey()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
