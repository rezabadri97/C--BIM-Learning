using System;
class TrackedElement
{
    private int elementId;
    public int ElementId
    {
        get
        {
            return elementId;
        }
        set
        {
            if(value>0)
            {
                elementId = value;
            }
        }
    }
    private string elementName;
    public string ElementName
    {
        get
        {
            return elementName;
        }
        set
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Please Enter The Element Name:");
                return;
            }
            elementName= value;
        }
    }
    private string elementCategory;
    public string ElementCategory
    {
        get
        {
            return elementCategory;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Please Enter The Element Category:");
                return;
            }
            elementCategory = value;
        }
    }
    public bool IsActive { get; set; }
    public string NameCleaner(string name)
    {
        return name.Trim().ToUpper();
    }
    public bool ChangeActive()
    {
        return IsActive = !IsActive;
    }
    public bool IsSpatial(string category)
    {
        if(NameCleaner(category)=="WALL" || NameCleaner(category) =="FLOOR" || NameCleaner(category) == "ROOF")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void DisplayInformation()
    {
        Console.WriteLine($"------------------------------------------------");
        Console.WriteLine($"Element ID: {elementId}");
        Console.WriteLine($"Element Name: {NameCleaner (elementName)}");
        Console.WriteLine($"Element Category: {NameCleaner(elementCategory)}");
        Console.WriteLine($"Element Is Active: {IsActive}");
        Console.WriteLine($"Is Spatial: {IsSpatial(elementCategory)}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        TrackedElement element1= new TrackedElement();
        TrackedElement element2 = new TrackedElement();
        TrackedElement element3 = new TrackedElement();
        TrackedElement element4 = new TrackedElement();

        element1.ElementId = 1;
        element1.ElementName = "  Exterior wall";
        element1.ElementCategory = "Wall";
        element1.IsActive = true;

        element2.ElementId = 2;
        element2.ElementName = " bathroom floor";
        element2.ElementCategory = "floor";
        element2.IsActive = false;

        element3.ElementId = 3;
        element3.ElementName = "   warm roof";
        element3.ElementCategory = "roof";
        element3.IsActive = false;

        element4.ElementId = 4;
        element4.ElementName = " tree";
        element4.ElementCategory = "component";
        element4.IsActive = true;

        int spatialcount = 0;

        TrackedElement[] elements = { element1, element2, element3, element4 };

        foreach(TrackedElement element in elements )
        {
            element.DisplayInformation();
            if (element.IsSpatial(element.ElementCategory))
            {
                spatialcount++;
            }
        }
        Console.WriteLine($"Spatial Count: {spatialcount}");
    }
}