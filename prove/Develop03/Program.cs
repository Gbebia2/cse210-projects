using System;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("Philippians", 4, 9);
        Scripture scripture = new Scripture(ref1, "Those things, which ye have both learned, and received, and heard, and seen in me, do: and the God of peace shall be with you.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.AreAllWordsHidden())
            {
                Console.WriteLine("All words hidden! Program ends.");
                break;
            }

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords();
        }
    }
}