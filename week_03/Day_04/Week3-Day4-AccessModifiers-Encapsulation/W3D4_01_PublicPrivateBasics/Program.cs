using System;

class BimWall
{
    public string WallName;
    private double height;

    public void SetHeight(double value)
    {
        if (value > 0)
        {
            height = value;
        }
    }

    public double GetHeight()
    {
        return height;
    }
}

class Program
{
    static void Main()
    {
        BimWall wall = new BimWall();

        wall.WallName = "Core Wall";
        wall.SetHeight(4.2);

        Console.WriteLine("Wall Name: " + wall.WallName);
        Console.WriteLine("Height: " + wall.GetHeight());
    }
}
