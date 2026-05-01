using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Element Name: ");
        string elementName=Console.ReadLine();

        if (string.IsNullOrWhiteSpace(elementName))
        {
            Console.WriteLine("Name cannot be empty.");
            return;
        }

        string cleanName = elementName.Trim().ToLower();
        
        if (cleanName.Contains("room"))
        {
            Console.WriteLine("This Is A Room");
        }

        cleanName=cleanName.Replace(" ", "_");
        
        if (cleanName.Contains("level"))
        {
            Console.WriteLine("This looks like a level - related element name.");
        }
        int count = cleanName.Length;
        Console.WriteLine($"Name: {cleanName.ToUpper()}");
        Console.WriteLine($"Character Count:{count}");
    }
}