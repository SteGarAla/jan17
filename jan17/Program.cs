using System;

namespace jan17
{
    class Program
    {
        static void GuessingGame()
        {
            Random rando = new Random();
            int randomNumber = rando.Next(0, 100);
            Console.WriteLine("Welcome to the guessing Game");
       
            string userInput;
            int userNumber = 0;
           
 
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
            }
            Console.WriteLine("You guessed the number !!!");
        }
        static void Main(string[] args)
        {
            GuessingGame();
        }
    }
}
