using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("Please select an activity:");

        while (true)
        {
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();
            if (choice == "4")
            {
                Console.WriteLine("Thank you for using the Mindfulness Program! Goodbye.");
                break;
            }

            Console.WriteLine("Enter the duration in seconds:");
            if (!int.TryParse(Console.ReadLine(), out int duration))
            {
                Console.WriteLine("Invalid duration. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity(duration);
                    breathing.StartBreathing();
                    break;
                case "2":
                    ReflectionActivity reflection = new ReflectionActivity(duration);
                    reflection.StartReflection();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity(duration);
                    listing.StartListing();
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please choose a valid activity.");
                    break;
            }
        }
    }
}
