using System;
using System.Collections.Generic;
class BimElement
{
     public int Id {  get; set; }
     public string Name { get; set; }
    
    public BimElement(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Element Id: {Id} | Element Name: {Name}");
    }

}
class BimWall:BimElement
{
    public double Length {  get; set; }

    public BimWall(int id,string name, double length):base(id,name)
    {
        Length = length;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Element Id: {Id} | Element Name: {Name} | Length: {Length}");
    }
}
class BimDoor:BimElement
{
    public double Width {  get; set; }
    public BimDoor(int id,string name,double width):base(id,name)
    {
        Width=width;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Element Id: {Id} | Element Name: {Name} | Width: {Width}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<BimElement> elements=new List<BimElement>();
        BimWall wall1 = new BimWall(101, "Exterior Wall", 5);
        BimWall wall2 = new BimWall(102, "Interior Wall", 3);
        BimWall wall3 = new BimWall(103, "Exterior facade Wall", 7);

        BimDoor door1 = new BimDoor(201, "External Door", .9);
        BimDoor door2 = new BimDoor(202, "Internal Door", 1);
        BimDoor door3 = new BimDoor(203, "External Iron Door", 1.2);
        elements.Add(wall1);
        elements.Add(wall2);
        elements.Add(wall3);
        elements.Add(door1);
        elements.Add(door2);
        elements.Add(door3);

        foreach(BimElement element in elements)
        {
            element.DisplayInfo();
        }
    }
}