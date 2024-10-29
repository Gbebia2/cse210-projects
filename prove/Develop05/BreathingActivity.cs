using System;
using System.Threading;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int duration) : base(duration) { }

    public void StartBreathing()
    {
        StartMessage("Breathing Activity", 
                     "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing.");

        int timePassed = 0;
        while (timePassed < duration)
        {
            Console.WriteLine("Breathe in...");
            PauseWithCountdown(3);
            Console.WriteLine("Breathe out...");
            PauseWithCountdown(3);
            timePassed += 6;
        }

        EndMessage("Breathing Activity");
    }

    private void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
