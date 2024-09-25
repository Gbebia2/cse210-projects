using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        List<int> numbers = new List<int>();

        int numb = -1;
        while (numb != 0)
        {
            Console.Write("Enter a number: ");
            string listOfNumbers = Console.ReadLine();
            numb = int.Parse(listOfNumbers);

            if (numb != 0)
            {
                numbers.Add(numb);
            }
        }

        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }

        Console.WriteLine($"The sum is {total}");

        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        
        int maximum = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                maximum = number;
            }
        }

        Console.WriteLine($"The largest number is: {maximum}");
    }
}