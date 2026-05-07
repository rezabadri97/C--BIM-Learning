using System;
using System.Collections.Generic;

class ModelElement
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Comment { get; set; }
    public string Category {  get; set; }

    public ModelElement(int id,string name, string comment,string category)
    {
        Id = id;
        Name = name;
        Comment = comment;
        Category = category;
    }
    public bool ISCommentValid()
    {
        if (string.IsNullOrWhiteSpace(Comment))
        {
            return false;
        }
        if (Comment.Length<5)
        {
            return false;
        }
        return true;
    }
    public void ShowCategoryMessage()
    {
        switch(Category)
        {
            case "Wall":
                Console.WriteLine("This element is a wall. Check wall comments carefully.");
                break;
            case "Room":
                Console.WriteLine("This element is a room. Room data must be clean.");
                break;
            case "Door":
                Console.WriteLine("This element is a door. Door comments affect schedules.");
            break;
            default:
                Console.WriteLine("Unknown category.");
                break;
        }
    }
    public void DisplayInfo()
    {
        Console.WriteLine("Id: " + Id);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Category: " + Category);
        Console.WriteLine("Comment: " + Comment);
        Console.WriteLine("Comment Valid: " + ISCommentValid());
        ShowCategoryMessage();
        Console.WriteLine("--------------------------");
    }
}
class Program
{
    static void Main(string[] args)
    {
        ModelElement e1 = new ModelElement(1, "Basic Wall", "Wall", "Exterior wall");
        ModelElement e2 = new ModelElement(2, "Room 101", "Room", "");
        ModelElement e3 = new ModelElement(3, "Door A", "Door", "Main");
        ModelElement e4 = new ModelElement(4, "Generic Model", "Furniture", "Chair family");


        e1.DisplayInfo();
        e2.DisplayInfo();
        e3.DisplayInfo();
        e4.DisplayInfo();
    }
}