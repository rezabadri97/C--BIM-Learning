using System;

internal class BimParameterFormatter
{
    public string FormatName(string name)
    {
        return name.Trim().ToUpper();
    }
}

class Program
{
    static void Main()
    {
        BimParameterFormatter formatter = new BimParameterFormatter();

        string result = formatter.FormatName("  door width  ");

        Console.WriteLine(result);
    }
}
