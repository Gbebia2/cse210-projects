using System;
using System.Threading;

public class MindfulnessActivity
{
    protected int duration;

    public MindfulnessActivity(int duration)
    {
        this.duration = duration;
    }

    public void StartMessage(string activityName, string description)
    {
        Console.WriteLine($"Starting {activityName}...");
        Console.WriteLine(description);
        Console.WriteLine("Press Enter to begin.");
        Console.ReadLine();
        PauseWithSpinner(3);
    }

    public void EndMessage(string activityName)
    {
        Console.WriteLine($"Good job! You have completed the {activityName} activity for {duration} seconds.");
        PauseWithSpinner(3);
    }

    public void PauseWithSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
