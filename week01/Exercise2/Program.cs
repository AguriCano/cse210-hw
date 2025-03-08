using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        
        // Convert input to integer
        int grade;
        if (!int.TryParse(input, out grade))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        // Determine letter grade
        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine + or - sign
        string sign = "";
        int lastDigit = grade % 10;
        
        if (letter != "A" && letter != "F") // No A+ or F+/F-
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && lastDigit < 3) // Only allow A-
        {
            sign = "-";
        }

        // Display final grade
        Console.WriteLine($"Your letter grade is: {letter}{sign}");
        
        // Message
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep trying! You can do better next time.");
        }
    }
}