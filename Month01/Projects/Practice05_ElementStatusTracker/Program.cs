using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

class TrackedElement
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Categoty { get; set; }
    public bool IsActive { get; set; }

   public TrackedElement(int id, string name, string category)
    {
        Id= id;
        Name= name;
        Categoty= category;
        IsActive = false;
    }
   public void Activate()
    {
        IsActive = true;
    }
    public void Deactivate()
    {
        IsActive= false;
    }
   public void DisplayInfo()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Category: {Categoty}");
        Console.WriteLine($"Is Active: {IsActive}");
        Console.WriteLine("----------------------");
    }
}
class Program
{
    static void Main( string[] args )
    {
       List <TrackedElement> elements = new List<TrackedElement>();
        TrackedElement wall = new TrackedElement(101, "Basic Wall", "Wall");
        TrackedElement door = new TrackedElement(102, "Single Door", "Door");
        TrackedElement room = new TrackedElement(103, "Office 201", "Room");

        wall.Activate();
        room.Activate();
        door.Deactivate();

        foreach(TrackedElement element in elements)
        {
            element.DisplayInfo();
        }



    }
}