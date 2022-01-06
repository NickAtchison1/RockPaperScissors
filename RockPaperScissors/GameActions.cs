using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class GameActions
    {
        public enum Action
        {
            ROCK = 1,
            PAPER = 2,
            SCISSORS = 3
        }

        public GameActions()
        {}
        public GameActions Actions { get; set; }
    }
}
