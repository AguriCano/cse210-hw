using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            int choice = int.Parse(Console.ReadLine());

            BaseActivity activity = null;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    continue;
            }

            activity.Start();
            activity.RunActivity();
        }
    }
}

// Main Program
// The main part of the program is responsible for showing a menu and allowing the user to select which activity they want to do.

// It keeps showing a simple text menu with options. When the user selects an option, it will create the appropriate activity (Breathing, Reflection, or Listing) and then run the activity.

// It will also call the Start() and RunActivity() methods from the selected activity.

// If the user chooses to exit, the program ends.