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
                        break
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
            throw new NotImplementedException();
        }

        private void WaitForKey()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
