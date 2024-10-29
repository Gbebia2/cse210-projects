public class ChecklistGoal : Goal
{
    public int TargetCount { get; private set; }
    public int CurrentCount { get; private set; }
    public int Bonus { get; private set; }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        TargetCount = targetCount;
        Bonus = bonus;
        CurrentCount = 0;
    }

    public override void RecordProgress()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
            Console.WriteLine($"Progress recorded for {Name}. Earned {Points} points.");

            if (CurrentCount == TargetCount)
            {
                IsComplete = true;
                Console.WriteLine($"Congratulations! You completed {Name} and earned a bonus of {Bonus} points!");
            }
        }
    }

    public override string DisplayStatus()
    {
        return IsComplete ? $"[X] {Name} (Completed)" : $"[ ] {Name} (Completed {CurrentCount}/{TargetCount} times)";
    }
}
