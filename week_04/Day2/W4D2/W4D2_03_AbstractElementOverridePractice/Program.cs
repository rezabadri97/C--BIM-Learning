using System;
using System.Collections.Generic;
namespace W4D2_03_AbstractElementOverridePractice
{

    abstract class BimElement
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public BimElement(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public abstract void DisplayInfo();
    }
    class RoomElement:BimElement
    {
        public double Area {  get; set; }

        public RoomElement(int id, string name, double area): base(id,name)
        {
            Area = area;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Room ID: {Id} | Room Name: {Name} | Area: {Area}");
        }
    }
    class WallElement: BimElement
    {
        public double Length {  get; set; }

        public WallElement(int id,string name,double length): base(id,name)
        {
            Length = length;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Wall ID: {Id} | Wall Name: {Name} | Length: {Length}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BimElement> bimelements = new List<BimElement>();
            bimelements.Add(new WallElement(101,"Exterior Wall",5));
            bimelements.Add(new WallElement(201, "Interior Wall", 3.5));
            bimelements.Add(new RoomElement(102, "Kitchen", 15));
            bimelements.Add(new RoomElement(202, "Bedroom", 18));

            foreach(BimElement element in bimelements)
            {
                Console.WriteLine("************************************");
                Console.WriteLine();
                element.DisplayInfo();
                Console.WriteLine();
            }







        }
    }







}