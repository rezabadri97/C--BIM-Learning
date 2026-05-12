using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter number of doors: ");
        string input = Console.ReadLine();

        bool isValid = int.TryParse(input, out int doorCount);

        if (isValid)
        {
            Console.WriteLine("Door count is: " + doorCount);
        }
        else
        {
            Console.WriteLine("Invalid number. Please enter a valid integer.");
        }
    }
}
