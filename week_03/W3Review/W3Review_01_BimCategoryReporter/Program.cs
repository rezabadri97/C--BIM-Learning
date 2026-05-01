using System;
internal class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter BIM category:");
        string category = Console.ReadLine().ToLower().Trim();

        switch (category)
        {
            case "wall":
                Console.WriteLine("This is a vertical building element.");
                break;
            case "door":
                Console.WriteLine("This element allows access between spaces.");
                break;
            case "window":
                Console.WriteLine("This element provides light and visibility.");
                break;
            case "room":
                Console.WriteLine("This element is used for spatial information.");
                break;
            case "":
                Console.WriteLine("Please Enter the Category");
                break;
            default:
                Console.WriteLine("Unknown BIM category.");
                break;
        }
    }
}
