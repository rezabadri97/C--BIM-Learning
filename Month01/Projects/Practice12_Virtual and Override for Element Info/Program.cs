using System;
using System.Collections.Generic;
using System.Xml.Linq;
class BimElement
{
    public int Id { get; set; }
    public string Name { get; set; }

    public BimElement(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Element Id: {Id}");
        Console.WriteLine($"Element Name: {Name}");
    }

}
class BimWall : BimElement
{
    public double Length { get; set; }

    public BimWall(int id, string name, double length) : base(id, name)
    {
        Length = length;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Element Id: {Id}");
        Console.WriteLine($"Element Name: {Name}");
        Console.WriteLine($"Wall Length: {Length}");
        
    }
}
class BimDoor : BimElement
{
    public double Width { get; set; }
    public BimDoor(int id, string name, double width) : base(id, name)
    {
        Width = width;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Element Id: {Id}");
        Console.WriteLine($"Element Name: {Name}");
        Console.WriteLine($"Wall Width: {Width}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<BimElement> elements = new List<BimElement>
        {
            new BimWall(101, "Exterior Wall", 5),
            new BimWall(102, "Interior Wall", 3),
            new BimWall(103, "Exterior facade Wall", 7),

            new BimDoor(201, "External Door", .9),
            new BimDoor(202, "Internal Door", 1),
            new BimDoor(203, "External Iron Door", 1.2)
        };

        foreach (BimElement element in elements)
        {
            element.DisplayInfo();
            Console.WriteLine("*******************************************");
        }
    }
}