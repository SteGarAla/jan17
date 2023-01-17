using System;

namespace jan17
{
    class Program
    {
        static void GuessingGame()
        {
           //intro to the game
            Console.WriteLine("Welcome to the guessing Game");
            Console.WriteLine("Enter start value of the range of numbers: ");

            //ask the user for the start of the range of numbers (string)
            string userInputForStartRange = Console.ReadLine();

            //converts that string input into an integer
            int startRange = Int32.Parse(userInputForStartRange);

            Console.WriteLine("Enter end value of the range of numbers: ");

            //ask the user for the end of the range of numbers (string)
            string userInputForEndRange = Console.ReadLine();

            //converts that string input into an integer
            int endRange = Int32.Parse(userInputForEndRange);

            //helps get a random number
            Random rando = new Random();

            //based on user input, we now have a range of numbers 
            int randomNumber = rando.Next(startRange, endRange);

      
            string userInput;
            int userNumber = 0;

            //amount of tries the user has attempted
            int counter = 0;
 
           //while condition has not been met, keep running code inside
           while(userNumber != randomNumber)
            {
                //ask user for number
                Console.WriteLine("Enter a number 1-100: ");
                userInput = Console.ReadLine();
                userNumber = Int32.Parse(userInput);

                //outputs msg based on if guess was higher or lower than number to be guessed
                if(userNumber > randomNumber)
                {
                    Console.WriteLine($"{userNumber} is bigger than random number \n");
                }
                else if(userNumber < randomNumber)
                {
                    Console.WriteLine($"{userNumber} is smaller than random number \n");
                }
                //increments counter to show amount of times they have guessed wrong so far
                counter++;
            }
           //once they are out of the while loop, we send a msg and tell them the amount of times it took them
            Console.WriteLine("You guessed the number!!!");
            Console.WriteLine($"It took you {counter} amount of tries :O ");
        }
        static void Main(string[] args)
        {
            //calls the guessing game in the entry point of the code
            GuessingGame();
            
        }
    }
}
