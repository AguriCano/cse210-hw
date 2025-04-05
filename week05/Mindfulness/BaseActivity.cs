using System;
using System.Threading;

public abstract class BaseActivity
{
    public int Duration { get; set; }

    public virtual void Start()
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("Please set the duration of the activity in seconds:");
        Duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Preparing to begin...");
        Pause(3);
    }

    public virtual void End()
    {
        Console.WriteLine("Good job! You've completed the activity.");
        Console.WriteLine($"You spent {Duration} seconds.");
        Pause(3);
    }

    protected void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void RunActivity();
}

// BaseActivity Class
// This class is the base for all activities. It has some shared behaviors that every activity need, like Duration, and Start() and End() methods.

// Duration is the time that the activity should run in seconds.

// Start() method is where the program asks for the duration, show the starting message and wait a few seconds before the activity begins.

// End() is called after the activity is done, giving a final message with the time spent and then pausing again.

// Pause() just makes the program stop for a few seconds, showing a simple “.” on screen while it waits.

// So, this class is like a template that all other activities can use. Each specific activity (like Breathing, Reflection, and Listing) will just need to fill in what’s specific for them (like their description or steps).