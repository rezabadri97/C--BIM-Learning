using System;
List<int> numbers = new List<int>() { 2, 5, 7, 9, 1, 10 };
var bigNumbers = numbers.Where(number => number > 5);
foreach(var number in bigNumbers)
{
    Console.WriteLine(number);
}