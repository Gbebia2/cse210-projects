using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalScore = 0;

    public static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest - Goal Tracking");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Progress");
            Console.WriteLine("3. View Goals and Score");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordProgress();
                    break;
                case "3":
                    ViewGoals();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    LoadGoals();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("\nChoose Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose an option: ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for completion: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, points, targetCount, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
        Console.WriteLine("Goal created! Press Enter to continue.");
        Console.ReadLine();
    }

    static void RecordProgress()
    {
        Console.WriteLine("\nSelect a goal to record progress:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].DisplayStatus()}");
        }
        Console.Write("Choose a goal number: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            goals[goalIndex].RecordProgress();
            totalScore += goals[goalIndex].Points;
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
        Console.WriteLine("Progress recorded! Press Enter to continue.");
        Console.ReadLine();
    }

    static void ViewGoals()
    {
        Console.WriteLine("\nCurrent Goals and Progress:");
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.DisplayStatus());
        }
        Console.WriteLine($"\nTotal Score: {totalScore}");
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(totalScore);
            foreach (Goal goal in goals)
            {
                string goalType = goal.GetType().Name;
                writer.WriteLine($"{goalType}|{goal.Name}|{goal.Description}|{goal.Points}");
                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"{checklistGoal.TargetCount}|{checklistGoal.Bonus}");
                }
            }
        }
        Console.WriteLine("Goals saved! Press Enter to continue.");
        Console.ReadLine();
    }

    static void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved goals found! Press Enter to continue.");
            Console.ReadLine();
            return;
        }

        using (StreamReader reader = new StreamReader("goals.txt"))
        {
            totalScore = int.Parse(reader.ReadLine());
            goals.Clear();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                string goalType = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                switch (goalType)
                {
                    case "SimpleGoal":
                        goals.Add(new SimpleGoal(name, description, points));
                        break;
                    case "EternalGoal":
                        goals.Add(new EternalGoal(name, description, points));
                        break;
                    case "ChecklistGoal":
                        int targetCount = int.Parse(parts[4]);
                        int bonus = int.Parse(parts[5]);
                        goals.Add(new ChecklistGoal(name, description, points, targetCount, bonus));
                        break;
                }
            }
        }
        Console.WriteLine("Goals loaded! Press Enter to continue.");
        Console.ReadLine();
    }
}
