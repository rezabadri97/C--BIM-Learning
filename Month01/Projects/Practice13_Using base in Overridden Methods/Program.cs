using System;

abstract class BuildingElement
{
    public int Id { get; set; }
    public string Name { get; set; }

    public BuildingElement(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public abstract double CalculateValue();

    public void ShowBasicInfo()
    {
        Console.WriteLine("Id: " + Id);
        Console.WriteLine("Name: " + Name);
    }
}

class WallElement : BuildingElement
{
    public double Length { get; set; }

    public WallElement(int id, string name, double length) : base(id, name)
    {
        Length = length;
    }

    public override double CalculateValue()
    {
        return Length * 2;
    }
}

class DoorElement : BuildingElement
{
    public double Width { get; set; }

    public DoorElement(int id, string name, double width) : base(id, name)
    {
        Width = width;
    }

    public override double CalculateValue()
    {
        return Width * 3;
    }
}

class Program
{
    static void Main()
    {
        WallElement wall = new WallElement(1, "Core Wall", 12);
        DoorElement door = new DoorElement(2, "Exit Door", 1.5);

        wall.ShowBasicInfo();
        Console.WriteLine("Wall Value: " + wall.CalculateValue());
        Console.WriteLine();

        door.ShowBasicInfo();
        Console.WriteLine("Door Value: " + door.CalculateValue());
    }
}
