using System;
using System.Collections.Generic;
namespace W4D2_01_RoomDictionaryPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> roomNumberToName = new Dictionary<string, string>();
            roomNumberToName.Add("R-101", "Office 101");
            roomNumberToName.Add("R-102", "Meeting Room");
            roomNumberToName.Add("R-201", "MEP Room");
            roomNumberToName.Add("R-301", "Storage");

            foreach (KeyValuePair<string, string> item in roomNumberToName)
            {
                Console.WriteLine($"Room Number: {item.Key}, Room Name: {item.Value}");
                Console.WriteLine();
            }
            if (roomNumberToName.ContainsKey("R-201"))
            {
                Console.WriteLine($"R-201 found: {roomNumberToName["R-201"]}");
            }
            else
            {
                Console.WriteLine("R-201 not found.");
            }
            if (roomNumberToName.ContainsKey("R-999"))
            {
                Console.WriteLine($"R-999 found: {roomNumberToName["R-999"]}");
            }
            else
            {
                Console.WriteLine("R-999 not found.");
            }

            Console.WriteLine();
            Console.WriteLine($"Total number of rooms: {roomNumberToName.Count}");
        }
    }
}
