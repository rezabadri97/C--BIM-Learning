using System;
class BimElement
{
    public string Category;
    private double height;
    public double Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value > 0)
            {
                height = value;
            }
            else
            {
                height = 1;
            }
        }
    }
    public BimElement()
    {
        Category = "Generic Moder";
        Height = 1;
    }
    public BimElement(string c,double H)
    {
        Category = c;
        Height = H;
    }
    
}
class Program
{
    static void Main(string[] args)
    {
        BimElement Element1=new BimElement();
        Console.WriteLine(Element1.Category);
        Console.WriteLine(Element1.Height);

        BimElement Element2 = new BimElement("Wall", 3);
        Console.WriteLine(Element2.Category);
        Console.WriteLine(Element2.Height);
    }
}