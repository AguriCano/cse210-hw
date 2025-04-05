public class ListingActivity : BaseActivity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public override void Start()
    {
        base.Start();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public override void RunActivity()
    {
        Console.WriteLine("Starting Listing Activity...");
        Random rand = new Random();
        int promptIndex = rand.Next(prompts.Length);
        Console.WriteLine(prompts[promptIndex]);

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        int itemCount = 0;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("List an item:");
            Console.ReadLine();  // User enters an item
            itemCount++;
            Console.WriteLine($"Items listed: {itemCount}");
        }

        Console.WriteLine($"You listed {itemCount} items in total.");
        End();
    }
}

// ListingActivity Class
// This activity is about listing things that the user appreciates or finds meaningful. Again, it’s another activity that inherits from BaseActivity.

// Start() shows the standard start message, but in this case, it tells the user they’ll be listing things related to a prompt, like “Who are people that you appreciate?”

// RunActivity() works by showing the user a prompt (like the ones above) and then waiting for the user to list as many things as they can think of.
// For every item the user lists, it increments a counter. Once the time is up, it will tell them how many items they listed in total.

// This helps the user focus on the good things in their life.
