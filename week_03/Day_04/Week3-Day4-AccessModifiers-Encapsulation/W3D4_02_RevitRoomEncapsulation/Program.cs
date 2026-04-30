using System;

class RevitRoom
{
    public string RoomName {  get; set; }
    private double area;

    public void SetArea(double value)
    {
        if (value>0)
        {
            area = value;
        }
    }
    public double GetArea()
    {
        return area;
    }
}
class Program
{
    static void Main(string[] args)
    {
        RevitRoom room=new RevitRoom();
        room.RoomName = "Lobby";
        room.SetArea(120.5);
        Console.WriteLine($"Room Name: {room.RoomName}");
        Console.WriteLine($"Room Area: {room.GetArea()}");

    }
}