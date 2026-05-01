using System;

class BimElement
{
    public string Category { get; set; }

    private double height;

    public double Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value > 0)
            {
                height = value;
            }
            else
            {
                height = 1;
            }
        }
    }

    public BimElement()
    {
        Category = "Generic Model";
        Height = 1;
    }

    public BimElement(string category, double initialHeight)
    {
        Category = category;
        Height = initialHeight;
    }
}

class Program
{
    static void Main(string[] args)
    {
        BimElement element1 = new BimElement();
        BimElement element2 = new BimElement("Wall", 3.5);
        BimElement element3 = new BimElement("Door", -2);

        Console.WriteLine("Element 1: " + element1.Category + ", " + element1.Height);
        Console.WriteLine("Element 2: " + element2.Category + ", " + element2.Height);
        Console.WriteLine("Element 3: " + element3.Category + ", " + element3.Height);
    }
}
