public class ReflectionActivity : BaseActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?"
    };

    public override void Start()
    {
        base.Start();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
    }

    public override void RunActivity()
    {
        Console.WriteLine("Starting Reflection Activity...");
        Random rand = new Random();
        int promptIndex = rand.Next(prompts.Length);
        Console.WriteLine(prompts[promptIndex]);

        foreach (var question in questions)
        {
            Console.WriteLine(question);
            Pause(5);  // Pause to reflect on the question
        }
        End();
    }
}

// ReflectionActivity Class
// This is a class that lets users reflect on their life experiences. It’s another activity, and like the BreathingActivity, it inherits from BaseActivity.

// Start() is similar, showing the standard start message and then telling the user that they’ll reflect on their strength and resilience.

// RunActivity() chooses a random prompt (like “Think of a time when you helped someone in need”), then goes through a list of reflection questions one by one, showing them and pausing between each.
// After the user reflects on each question, the program moves to the next one. This continues until the total duration is over.

// The goal of this activity is to get the user thinking about meaningful experiences in their life.
