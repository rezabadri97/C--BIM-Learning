using System;
interface IPrintable
{
    void Print();
}

class RoomReport : IPrintable
{
    private string name;
    private double area;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                name = value;
            }
        }
    }
    public double Area
    {
        get
        {
            return area;
        }
        set
        {
            if (value > 0)
            {
                area = value;
            }
        }
    }
    public RoomReport(string name, double area)
    {
        Name = name;
        Area = area;
    }
    public void Print()
    {
        Console.WriteLine($"Printed Room-----Room Name: {name} | Room Area: {area}");
    }
}
class Wall : IPrintable
{
    private string name;
    private double length;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                name = value;
            }
        }
    }
    public double Length
    {
        get
        {
            return length;
        }
        set
        {
            if (value > 0)
            {
                length = value;
            }
        }
    }
    public Wall(string name, double area)
    {
        Name = name;
        Length = area;
    }
    public void Print()
    {
        Console.WriteLine($"Printed Wall-----Wall Name: {name} | Wall Length: {length}");
    }
}
class Door : IPrintable
{
    private string name;
    private double width;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                name = value;
            }
        }
    }
    public double Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value > 0)
            {
                width = value;
            }
        }
    }
    public Door(string name, double width)
    {
        Name = name;
        Width = width;
    }
    public void Print()
    {
        Console.WriteLine($"Printed Door-----Door Name: {name} | Door Width: {width}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<IPrintable> Ilist = new List<IPrintable>();
        Ilist.Add(new RoomReport("Living Room", 15));
        Ilist.Add(new Door("Wooden", 2));
        Ilist.Add(new Wall("Exterior", 3));

        foreach (IPrintable item in Ilist)
        {
            item.Print();
        }        
    }
}