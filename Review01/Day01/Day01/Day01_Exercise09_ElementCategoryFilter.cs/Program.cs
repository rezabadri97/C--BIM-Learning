using System;
using System.Collections.Generic;

namespace BimExercises
{
    internal class ModelElement
    {
        public string Name { get; set; }
        public string Category { get; set; }

        public ModelElement(string name, string category)
        {
            Name = name;
            Category = category;
        }
    }

    internal class Program
    {
        static List<ModelElement> FilterByCategory(List<ModelElement> elements, string targetCategory)
        {
            List<ModelElement> filteredElements = new List<ModelElement>();

            foreach (ModelElement element in elements)
            {
                if (element.Category == targetCategory)
                {
                    filteredElements.Add(element);
                }
            }

            return filteredElements;
        }

        static void Main(string[] args)
        {
            List<ModelElement> elements = new List<ModelElement>();

            Console.WriteLine("Enter number of model elements:");
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"Enter element name #{i}:");
                string name = Console.ReadLine();

                Console.WriteLine($"Enter element category #{i}:");
                string category = Console.ReadLine();

                ModelElement element = new ModelElement(name, category);
                elements.Add(element);
            }

            Console.WriteLine("Enter category to filter:");
            string filterCategory = Console.ReadLine();

            List<ModelElement> result = FilterByCategory(elements, filterCategory);

            Console.WriteLine();
            Console.WriteLine("===== Filtered Elements =====");

            foreach (ModelElement element in result)
            {
                Console.WriteLine($"Name: {element.Name}, Category: {element.Category}");
            }

            Console.WriteLine($"Matched Elements: {result.Count}");
        }
    }
}
