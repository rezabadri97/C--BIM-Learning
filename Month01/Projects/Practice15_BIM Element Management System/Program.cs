using System;
using System.Collections.Generic;

interface IExportable
{
    string ExportData();
}

abstract class BimElement : IExportable
{
    private string _name;

    public int Id { get; set; }

    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                _name = "Unnamed Element";
            }
            else
            {
                _name = value.Trim();
            }
        }
    }

    public string Category { get; set; }

    protected BimElement(int id, string name, string category)
    {
        Id = id;
        Name = name;
        Category = category;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Id: " + Id);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Category: " + Category);
    }

    public abstract double CalculateValue();

    public virtual string ExportData()
    {
        return "Id=" + Id + ", Name=" + Name + ", Category=" + Category;
    }
}

class BimWall : BimElement
{
    public double Length { get; set; }
    public double Height { get; set; }

    public BimWall(int id, string name, double length, double height)
        : base(id, name, "Wall")
    {
        Length = length;
        Height = height;
    }

    public override double CalculateValue()
    {
        return Length * Height;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Length: " + Length);
        Console.WriteLine("Height: " + Height);
        Console.WriteLine("Area Value: " + CalculateValue());
        Console.WriteLine("-------------------------");
    }

    public override string ExportData()
    {
        return base.ExportData() + ", Length=" + Length + ", Height=" + Height;
    }
}

class BimDoor : BimElement
{
    public double Width { get; set; }
    public double Height { get; set; }

    public BimDoor(int id, string name, double width, double height)
        : base(id, name, "Door")
    {
        Width = width;
        Height = height;
    }

    public override double CalculateValue()
    {
        return Width * Height;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Width: " + Width);
        Console.WriteLine("Height: " + Height);
        Console.WriteLine("Opening Area: " + CalculateValue());
        Console.WriteLine("-------------------------");
    }

    public override string ExportData()
    {
        return base.ExportData() + ", Width=" + Width + ", Height=" + Height;
    }
}

class BimWindow : BimElement
{
    public double Width { get; set; }
    public double Height { get; set; }

    public BimWindow(int id, string name, double width, double height)
        : base(id, name, "Window")
    {
        Width = width;
        Height = height;
    }

    public override double CalculateValue()
    {
        return Width * Height;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Width: " + Width);
        Console.WriteLine("Height: " + Height);
        Console.WriteLine("Glass Area: " + CalculateValue());
        Console.WriteLine("-------------------------");
    }

    public override string ExportData()
    {
        return base.ExportData() + ", Width=" + Width + ", Height=" + Height;
    }
}

class ElementManager
{
    private List<BimElement> _elements = new List<BimElement>();

    public void AddElement(BimElement element)
    {
        if (element == null)
        {
            Console.WriteLine("Cannot add null element.");
            return;
        }

        if (element.Id <= 0)
        {
            Console.WriteLine("Invalid element id.");
            return;
        }

        _elements.Add(element);
    }

    public void ShowAllElements()
    {
        foreach (BimElement element in _elements)
        {
            element.DisplayInfo();
        }
    }

    public double GetTotalValue()
    {
        double total = 0;

        foreach (BimElement element in _elements)
        {
            total += element.CalculateValue();
        }

        return total;
    }

    public void ShowCategoryCounts()
    {
        Dictionary<string, int> counts = new Dictionary<string, int>();

        foreach (BimElement element in _elements)
        {
            if (counts.ContainsKey(element.Category))
            {
                counts[element.Category] = counts[element.Category] + 1;
            }
            else
            {
                counts.Add(element.Category, 1);
            }
        }

        Console.WriteLine("Category Counts:");
        foreach (var item in counts)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }

    public void ExportAll()
    {
        Console.WriteLine("Export Data:");
        foreach (BimElement element in _elements)
        {
            Console.WriteLine(element.ExportData());
        }
    }
}

class Program
{
    static void Main()
    {
        ElementManager manager = new ElementManager();

        manager.AddElement(new BimWall(1, "Exterior Wall", 10, 3));
        manager.AddElement(new BimDoor(2, "Main Door", 1.2, 2.1));
        manager.AddElement(new BimWindow(3, "South Window", 2.4, 1.5));
        manager.AddElement(new BimWall(4, "Core Wall", 7, 3.2));

        manager.ShowAllElements();
        Console.WriteLine("Total Value: " + manager.GetTotalValue());
        Console.WriteLine();

        manager.ShowCategoryCounts();
        Console.WriteLine();

        manager.ExportAll();
    }
}
