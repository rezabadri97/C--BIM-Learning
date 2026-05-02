using System;

class Wall
{
    private string wallName;
    public string WallName
    {
        get
        {
            return wallName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Name is Invalid");
                return;
            }
            wallName = value;
        }

    }
    private double wallHeight;
    public double WallHeight
    {
        get
        {
            return wallHeight;
        }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Height is Invalid");
                return;
            }
            wallHeight = value;
        }

    }
    private double wallLength;
    public double WallLength
    {
        get
        {
            return wallLength;
        }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Length is Invalid");
                return;
            }
            wallLength = value;
        }

    }
public double WallArea()
    {
         return WallHeight * WallLength;
        
    }
public bool IsValidWall()
    {
        if(string.IsNullOrWhiteSpace(WallName))
        {
            return false;
        }
        if(WallHeight<=0)
        {
            return false;
        }
        if(WallLength<=0)
        {
            return false;
        }
        return true;
    }
public void DisplayWallInfo()
    {
        if (!IsValidWall())
        {
            Console.WriteLine($"Wall Name: {WallName.Trim().ToUpper()}");
            return;
        }
        Console.WriteLine($"Wall Height: {WallHeight}");
        Console.WriteLine($"Wall Length: {WallLength}");
        Console.WriteLine($"Wall Area: {WallArea()}");
        Console.WriteLine($"Wall Is Valid : {IsValidWall()}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Wall wall1 = new Wall();
        Wall wall2 = new Wall();
        Wall wall3 = new Wall();
        wall1.WallName = "Exterior Wall";
        wall1.WallHeight = 3.2;
        wall1.WallLength = 5;
        wall2.WallName = "Interior Wall";
        wall2.WallHeight = 2.8;
        wall2.WallLength = 8;
        wall3.WallName = "Stack Wall";
        wall3.WallHeight = 3;
        wall3.WallLength = 6;
        Wall[] walls = { wall1, wall2, wall3 };

        Wall biggestWall = null;
        double biggestArea = 0;

        foreach (Wall wall in walls)
        {
            wall.DisplayWallInfo();

            Console.WriteLine("----------------");

            if (wall.IsValidWall() && wall.WallArea() > biggestArea)
            {
                biggestArea = wall.WallArea();
                biggestWall = wall;
            }
        }

        if (biggestWall != null)
        {
            Console.WriteLine($"Largest wall by area: {biggestWall.WallName}");
            Console.WriteLine($"Biggest Wall Area: {biggestArea}");
        }
    }
}
