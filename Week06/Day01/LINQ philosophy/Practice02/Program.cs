using System;
List<string> names=new List<string> { "Ali", "Sara", "Amir", "Mina" };
var newNames = names.Where(name => name.StartsWith("A"));
foreach(var name in newNames)
{
    Console.WriteLine(name);
}