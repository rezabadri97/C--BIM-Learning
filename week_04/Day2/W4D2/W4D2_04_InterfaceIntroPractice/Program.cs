using System;
using System.Collections.Generic;

namespace W4D2_04_InterfaceIntroPractice
{
    public interface IExportable
    {
        void ExportData();
    }
    public class RoomElement : IExportable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Area { get; set; }

        public RoomElement(int id, string name, double area)
        {
            Id = id;
            Name = name;
            Area = area;
        }
        public void ExportData()
        {
            Console.WriteLine($"EXPORT ROOM | Id: {Id}, Name: {Name}, Area: {Area}");
        }
    }
    public class DoorElement: IExportable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Width { get; set; }

        public DoorElement(int id, string name, double width)
        {
            Id = id;
            Name = name;
            Width = width;
        }
        public void ExportData()
        {
            Console.WriteLine($"EXPORT DOOR | Id: {Id}, Name: {Name}, Width: {Width}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            RoomElement room1 = new RoomElement(101,"Office",26);
            DoorElement door1 = new DoorElement(102, "Interior", .9);

            room1.ExportData();
            door1.ExportData();


        }
    }







}
