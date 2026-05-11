using System;
class Box<T>
{
    public T Value;

    public Box(T value)
    {
        Value = value;
    }
    public void ShowValue()
    {
        Console.WriteLine(Value);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Box<int> boxNumber = new Box<int>(23);
        
        Console.WriteLine("Box Number: "+boxNumber.Value);

        Box<string> boxName = new Box<string>("Red");
        Console.WriteLine("Box Name: " + boxName.Value);


    }
}