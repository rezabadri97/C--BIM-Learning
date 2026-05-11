using System;
class Printer
{
    public void PrintItem<T>(T item)
    {
        Console.WriteLine(item);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Printer print01= new Printer();
        print01.PrintItem<int>(5);
        print01.PrintItem("Wall");
        print01.PrintItem(true);
    }
}