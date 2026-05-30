using System;
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
var evenNumbers = numbers.Where(number => number % 2 == 0).Select(number => number * 100);
foreach(var item in evenNumbers)
{
    Console.WriteLine(item);
}