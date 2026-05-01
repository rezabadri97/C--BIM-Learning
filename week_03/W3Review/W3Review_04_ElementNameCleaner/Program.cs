using System;
using System.Linq;
using System.Reflection.Emit;
using System.Xml.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Element Name: ");
        string elementName=Console.ReadLine();
        string cleanName = elementName.Trim().ToLower();
        
        if (cleanName.Contains("room"))
        {
            Console.WriteLine("This Is A Room");
        }
        if (cleanName.Contains(" "))
        { 
            cleanName.Replace(" ", "_");
        }
        if (string.IsNullOrEmpty(elementName))
        {
            Console.WriteLine("Name cannot be empty.");
        }
        if (cleanName.Contains("level"))
        {
            Console.WriteLine("This looks like a level - related element name.");
        }
        int count = cleanName.Length;
        Console.WriteLine($"Name: {cleanName.ToUpper()}");
        Console.WriteLine($"Index Number:{count}");


    }

}