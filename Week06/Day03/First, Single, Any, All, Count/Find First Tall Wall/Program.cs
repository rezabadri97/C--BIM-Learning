using System;
using System.Collections.Generic;
using System.Linq;

class Wallinfo
{
    public string Name {  get; set; }
    public double Hieght { get; set; }
}
class Program
{
    public static void Main(string[] args)
    {
        List<Wallinfo> walls = new List<Wallinfo>
        {
            new Wallinfo{Name="Wall A",Hieght=2900},
            new Wallinfo{Name="Wall B",Hieght=3000},
            new Wallinfo{Name="Wall C",Hieght=3100},
            new Wallinfo{Name="Wall D",Hieght=3200}
        };

        var firstWall = walls.First(w => w.Hieght > 3000);

       Console.WriteLine(firstWall.Name);




    }
}