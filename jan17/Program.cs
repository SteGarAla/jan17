using System;

namespace jan17
{
    class Program
    {
        static void GuessingGame()
        {
           
            Console.WriteLine("Welcome to the guessing Game");
            Console.WriteLine("Enter start value of the range of numbers: ");
            string userInputForStartRange = Console.ReadLine();
            int startRange = Int32.Parse(userInputForStartRange);

            Console.WriteLine("Enter end value of the range of numbers: ");
            string userInputForEndRange = Console.ReadLine();
            int endRange= Int32.Parse(userInputForEndRange);
            Random rando = new Random();
            
            int randomNumber = rando.Next(startRange, endRange);
            string userInput;
            int userNumber = 0;
            int counter = 0;
 
           while(userNumber != randomNumber)
            {
                //ask user for number
                Console.WriteLine("Enter a number 1-100: ");
                userInput = Console.ReadLine();
                userNumber = Int32.Parse(userInput);

                if(userNumber > randomNumber)
                {
                    Console.WriteLine($"{userNumber} is bigger than random number \n");
                }
                else if(userNumber < randomNumber)
                {
                    Console.WriteLine($"{userNumber} is smaller than random number \n");
                }
                counter++;
            }
            Console.WriteLine("You guessed the number!!!");
            Console.WriteLine($"It took you {counter} amount of tries :O ");
        }
        static void Main(string[] args)
        {
            GuessingGame();
            
        }
    }
}
