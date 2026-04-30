using System;
internal class BimParameterFormatter
{
    public string RawName(string name)
    {
        return name.ToUpper().Trim();
    }
}
class Program
{
    static void Main(string[] args)
    {
        BimParameterFormatter element1= new BimParameterFormatter();

        
        Console.WriteLine(element1.RawName(" door width "));
        
        
    }
}