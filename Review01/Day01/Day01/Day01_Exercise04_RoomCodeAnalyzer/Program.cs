using System;

namespace BimDeveloperExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] roomCodes = new string[5];

            int architecturalCount = 0;
            int mechanicalCount = 0;
            int electricalCount = 0;
            int serviceCount = 0;
            int unknownCount = 0;

            for (int i = 0; i < roomCodes.Length; i++)
            {
                Console.WriteLine($"Enter room code #{i + 1}:");
                string inputCode = Console.ReadLine();

                string cleanCode = inputCode.Trim().ToUpper();

                roomCodes[i] = cleanCode;
            }

            Console.WriteLine();
            Console.WriteLine("Clean Room Codes:");

            foreach (string code in roomCodes)
            {
                Console.WriteLine(code);

                if (code.StartsWith("A"))
                {
                    architecturalCount++;
                }
                else if (code.StartsWith("M"))
                {
                    mechanicalCount++;
                }
                else if (code.StartsWith("E"))
                {
                    electricalCount++;
                }
                else if (code.StartsWith("S"))
                {
                    serviceCount++;
                }
                else
                {
                    unknownCount++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("=========== Room Code Report ===========");
            Console.WriteLine($"Total Rooms: {roomCodes.Length}");
            Console.WriteLine($"Architectural Rooms: {architecturalCount}");
            Console.WriteLine($"Mechanical Rooms: {mechanicalCount}");
            Console.WriteLine($"Electrical Rooms: {electricalCount}");
            Console.WriteLine($"Service Rooms: {serviceCount}");
            Console.WriteLine($"Unknown Rooms: {unknownCount}");
        }
    }
}
