using System;
using System.Collections.Generic;
using System.Linq;

public class ElementInfo
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<ElementInfo> elements = new List<ElementInfo>
        {
            new ElementInfo { Id = 101, Name = "Wall A", Category = "Wall" },
            new ElementInfo { Id = 102, Name = "Door A", Category = "Door" },
            new ElementInfo { Id = 103, Name = "Window A", Category = "Window" }
        };

        ElementInfo element = elements.Single(e => e.Id == 102);

        Console.WriteLine("Element found:");
        Console.WriteLine(element.Name);
    }
}
