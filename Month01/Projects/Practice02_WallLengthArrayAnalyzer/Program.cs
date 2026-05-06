using System;

class Program
{
    static void Main()
    {
        double[] wallLengths = new double[5];

        for (int i = 0; i < wallLengths.Length; i++)
        {
            Console.WriteLine("Enter wall length " + (i + 1) + ":");
            wallLengths[i] = Convert.ToDouble(Console.ReadLine());
        }

        double total = GetTotalLength(wallLengths);
        double max = GetMaxLength(wallLengths);
        double average = total / wallLengths.Length;

        Console.WriteLine("Total Length: " + total);
        Console.WriteLine("Max Length: " + max);
        Console.WriteLine("Average Length: " + average);
    }

    static double GetTotalLength(double[] lengths)
    {
        double sum = 0;

        foreach (double item in lengths)
        {
            sum += item;
        }

        return sum;
    }

    static double GetMaxLength(double[] lengths)
    {
        double max = lengths[0];

        for (int i = 1; i < lengths.Length; i++)
        {
            if (lengths[i] > max)
            {
                max = lengths[i];
            }
        }

        return max;
    }
}
