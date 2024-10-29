public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public override void RecordProgress()
    {
        Console.WriteLine($"You recorded progress on {Name} and earned {Points} points!");
    }

    public override string DisplayStatus()
    {
        return $"[∞] {Name}";
    }
}
