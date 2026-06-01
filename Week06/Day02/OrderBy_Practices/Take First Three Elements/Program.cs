using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main(string[] args)
    {
        List<string> elements = new List<string> { "Wall A", "Door A", "Window A", "Column A", "Floor A" };
        var newElements = elements.Take(3);

        foreach(var element in newElements)
        {
            Console.WriteLine(element);
        }


    }

}