using System;
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
var result = numbers.Select(number => number * number);
foreach(var item in result)
{
    Console.WriteLine(item);
}