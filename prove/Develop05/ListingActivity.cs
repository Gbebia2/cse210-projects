using System;
using System.Threading;

public class ListingActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration) : base(duration) { }

    public void StartListing()
    {
        StartMessage("Listing Activity", 
                     "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        PauseWithSpinner(3);

        Console.WriteLine("Start listing your items below:");
        int itemCount = 0;
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                itemCount++;
            }
        }

        Console.WriteLine($"You listed {itemCount} items.");
        EndMessage("Listing Activity");
    }
}
