using System;
namespace Practice02_WallLengthArrayAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] lengths = new double[5];
            for (int i=0; i< lengths.Length;  i++)
            {
                Console.WriteLine("Enter wall length " + (i + 1) + ":");
                lengths[i] = Convert.ToDouble(Console.ReadLine());
            }
            Sum(lengths);
            



        }
        static void Sum(double[] lengths)
        {
            double sum = 0;
            double longest = lengths[0];
            foreach(double length in lengths)
            {
                sum+= length;
                if (length>longest)
                {
                    longest = length;
                }
            }
            double average = sum / lengths.Length;

            Console.WriteLine($"Wall Sum Length: {sum}");
            Console.WriteLine();
            Console.WriteLine($"Longest Wall: {longest}");
            Console.WriteLine();
            Console.WriteLine($"Wall Average Length: {average}");
            Console.WriteLine();
        }
    }



}