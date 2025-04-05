public class BreathingActivity : BaseActivity
{
    public override void Start()
    {
        base.Start();
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
    }

    public override void RunActivity()
    {
        Console.WriteLine("Starting Breathing Activity...");
        for (int i = 0; i < Duration; i++)
        {
            Console.WriteLine("Breathe in...");
            Pause(3);
            Console.WriteLine("Breathe out...");
            Pause(3);
        }
        End();
    }
}

// BreathingActivity Class
// This class is for the breathing activity. It inherits from BaseActivity and it does a few specific things:

// Start() calls the BaseActivity Start() method and adds a message to explain the breathing exercise.

// RunActivity() is where the breathing part happens. It alternates between showing “Breathe in…” and “Breathe out…” every few seconds.
// It will continue to do that until the total time (the Duration) has passed.

// The idea here is that the user should focus on breathing slowly, and the program will help pace that by giving them those "Breathe in" and "Breathe out" prompts.