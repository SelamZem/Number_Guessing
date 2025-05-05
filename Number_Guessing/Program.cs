using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Number_Guessing.ConsoleText;

namespace Number_Guessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            consoletxt consoleText = new consoletxt();
            consoleText.WelcomeMessage();
            int difficulty = consoleText.ChooseDifficulty();
            int round = consoleText.ShowDifficulty(difficulty);
            int ComputerGenerate = new Random().Next(1, 10);
            while(round > 0)
            {
                int userGuess = consoleText.EnterNumber();
                int display = consoleText.DisplayGuessResults(userGuess, ComputerGenerate);
                if(display == 0) round--;
                else { break; }
            }

        }
    }
}
