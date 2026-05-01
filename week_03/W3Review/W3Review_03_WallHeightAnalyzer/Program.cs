using System;
internal class Program
{
    static void Main(string[] args)
    {
        double[] wallHeights = {3.2,4.1,5.3,2.9,3.6,4};

        double sum = 0;
        double maxHeight = wallHeights[0];
        double minHeight = wallHeights[0];
        int highHeight = 0;
        
        for (int i=0; i<wallHeights.Length; i++)
        {
            sum += wallHeights[i];
            if (wallHeights[i]>maxHeight)
            {
                maxHeight = wallHeights[i];
            }
            if (wallHeights[i]<minHeight)
            {
                minHeight=wallHeights[i];
            }
            if (wallHeights[i] > 3)
            {
                highHeight++;
            }
            Console.WriteLine($"Wall {i+1} Height: {wallHeights[i]}");
        }
        int wallCount = wallHeights.Length;
        double averageHeight = Average(sum,wallCount);
        
        Console.WriteLine($"Wall count: {wallCount}");
        Console.WriteLine($"Wall Average Height: {averageHeight}");
        Console.WriteLine($"Wall Max Height: {maxHeight}");
        Console.WriteLine($"Wall Min Height: {minHeight}");
        Console.WriteLine($"Wall With Height More Than 3m: {highHeight}");


    }
    static double Average(double sum,int count)
    {
        return sum / count;
    }
}