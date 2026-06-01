using System;
using System.Collections.Generic;

List<int> walls = new List<int> { 3000, 1500, 4500, 2500, 2000 };

var newWalls = walls.Order();
foreach(var wall in newWalls)
{
    Console.WriteLine(wall);
}