using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace W4D2_02_BimElementInheritancePractice
{
    public class BimElement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BimElement(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void DisplayBasicInfo()
        {
            Console.WriteLine($"Element Id: {Id}");
            Console.WriteLine($"Element Name: {Name}");

        }
    }
    public class WallElement:BimElement
    {
        public double Length { get; set; }
        public  WallElement(int id, string name, double length): base(id,name)
        {
            Length = length;
        }
        public void DisplayWallInfo()
        {
            DisplayBasicInfo();
            Console.WriteLine($"Wall Length: {Length}");
        }
    }
    public class DoorElement:BimElement
    {
        public double Width { get; set; }
        public DoorElement(int id, string name, double width): base(id, name)
        {
            Width = width;
        }
        public void DisplayDoorInfo()
            {
            DisplayBasicInfo();
            Console.WriteLine($"Door Width: {Width}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WallElement wall1 = new WallElement(101,"Exterior Wall",5);
            DoorElement door1 = new DoorElement(102, "Wooden Door", .9);
            Console.WriteLine("*************************************");
            Console.WriteLine();
            wall1.DisplayWallInfo();
            Console.WriteLine();

            Console.WriteLine("*************************************");
            Console.WriteLine();

            door1.DisplayDoorInfo();
            Console.WriteLine();

            Console.WriteLine("*************************************");


        }
      
    }




}