using System;
interface IPrintable
{
    void Print();
}
interface ISavable
{
    void Save();
}

class RoomReport : IPrintable,ISavable
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
    public void Save()
    {
        Console.WriteLine($"Saved Room-----Room Name: {name} | Room Area: {area}");
    }


}
class Program
{
    static void Main(string[] args)
    {
        RoomReport room = new RoomReport("Living Room", 15);
        room.Print();
        room.Save();
    }
}