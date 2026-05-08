using System;
abstract class BuildingElement
{
    public int Id { get; set;}
    public string Name { get; set;}
    
    public BuildingElement(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public abstract void CalculateVaule();


}
class WallElement:BuildingElement
{
    public double Length { get; set;}
    public WallElement(int id, string name, double length):base(id, name)
    {
        Length = length;
    }
    public override void CalculateVaule()
    {
        double wallValue = Length * 2;
        Console.WriteLine($"Id: {Id} | Name: {Name} | Wall Value: {wallValue}");
    }

}
class DoorElement:BuildingElement
{
        public double Width { get; set;}

    public DoorElement(int id, string name, double width):base(id,name)
    {
        Width=width;
    }
    public override void CalculateVaule()
    {
        double doorValue = Width * 3;
        Console.WriteLine($"Id: {Id} | Name: {Name} | Door Value: {doorValue}");
    }

}
class Program
{
    static void Main(string[] args)
    {
        WallElement wall = new WallElement(101, "Exterior", 3);
        DoorElement door = new DoorElement(102, "Wooden Door", .9);

        wall.CalculateVaule();
        door.CalculateVaule();

    }
}