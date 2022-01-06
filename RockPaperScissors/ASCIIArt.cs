using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class ASCIIArt
    {
        public ASCIIArt()
        {
        }
        public Dictionary<int, string> Artwork
        {
            get
            {
                return new Dictionary<int, string>()
                {
                    {1, " \n" +
                "" +
                "    .--.--._\n" +
                " __ |  |  | `|\n" +
                "/   |  |  |  |\n" +
                "|  /|__|__|__/\n" +
                "| /  /      |\n" +
                "|   /       |\n" +
                "(  ,       /\n" +
                " \\        |\n" +
                "  |       |\n" +
                "  |       |\n"
            },



                    { 2, "Paper!!!!"},
                    { 3, "" +
                "" +
                ".--.   .--,\n" +
                "|  |  /  /\n" +
                "|  | /  /\n" +
                "|  |/  .--._\n" +
                "|   ._ |  | `|\n" +
                "|  /  )|  |  |\n" +
                "| /  / '--'--'\n" +
                "|/  /       |\n" +
                "(  ' \\      |  \n" +
                " \\    `.   /  \n" +
                "  |       |    \n" +
                "  |       |\n"
},
                };


            }
        }
         
    }
}
