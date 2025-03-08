using System;

class Program
{
    static void Main(string[] args)
    {
         Random random = new Random();
        bool playAgain = true;
        
        while (playAgain)
        {
            int magicNumber = random.Next(1, 101); // Generate random number from 1 to 100
            int guess = 0;
            int attempts = 0;
            
            Console.WriteLine("Guess My Number Game!");
            
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();
                
                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }
                
                attempts++;
                
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {attempts} attempts.");
                }
            }
            
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            
            playAgain = (response == "yes");
        }
        
        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}