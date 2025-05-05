using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing.ConsoleText
{
    internal class consoletxt
    {

     public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Number Guessing Game! \n" +
                "I'm thinking of a number between 1 and 100.\n" +
                "You have 5 chances to guess the correct number.\n");
        }

        public int EnterNumber()
        {
            int number;
            Console.Write("\nEnter your guess: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.\n");
                Console.Write("Enter valid guess again: ");
            }
            return number;
        }
        public int ChooseDifficulty()
        {
            int difficulty;
            Console.WriteLine("Please select the difficulty level:\n" +
                "1. Easy (10 chances)\n" +
                "2. Medium (5 chances)\n3. Hard (3 chances)\n");
            
            Console.Write("Enter your choice: ");

            while(!int.TryParse(Console.ReadLine(), out difficulty) || difficulty < 1 || difficulty > 3)
            {
                Console.WriteLine("Invalid choice. Please select a valid difficulty level.\n");
                Console.Write("Enter your choice again: ");
            }

            return difficulty;
        }
        public int ShowDifficulty(int difficulty)
        {
           
            switch (difficulty) { 
            
                case 1:
                    Console.WriteLine(" \nYou have selected Easy mode. You have 10 chances to guess the number.");
                    return 10;
                  
                case 2:
                    Console.WriteLine(" \nYou have selected Medium mode. You have 5 chances to guess the number.");
                    return 5;
                  
                case 3:
                    Console.WriteLine(" \nYou have selected Hard mode. You have 3 chances to guess the number.");
                    return 3;
                default:
                    return 5;// Default to Medium if invalid input
            }
        }

        public int DisplayGuessResults(int guessNumber, int CompNumber)
        {
            if (guessNumber < CompNumber)
            {
                Console.WriteLine($" Incorrect! The number is greater than {guessNumber}");
                return 0;
            }
            else if (guessNumber > CompNumber)
            {
                Console.WriteLine($" Incorrect! The number is lower than {guessNumber}");
                return 0;
            }
            else
            {
                Console.WriteLine(" Congratulations! You guessed the correct number.");
                return 1;
            }
        }
    }
}
