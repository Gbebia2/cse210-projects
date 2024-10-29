public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public override void RecordProgress()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            Console.WriteLine($"You completed {Name} and earned {Points} points!");
        }
    }

    public override string DisplayStatus()
    {
        return IsComplete ? $"[X] {Name}" : $"[ ] {Name}";
    }
}
