using System;
using System.Collections.Generic;

namespace BimExercises
{
    internal class ModelCategory
    {
        public string CategoryName { get; set; }
        public int Count { get; set; }

        public ModelCategory(string categoryName, int count)
        {
            CategoryName = categoryName;
            Count = count;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<ModelCategory> categories = new List<ModelCategory>();

            Console.WriteLine("Enter number of categories:");
            int categoryCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= categoryCount; i++)
            {
                Console.WriteLine($"Enter category name #{i}:");
                string categoryName = Console.ReadLine();

                Console.WriteLine($"Enter count for {categoryName}:");
                int count = int.Parse(Console.ReadLine());

                ModelCategory category = new ModelCategory(categoryName, count);
                categories.Add(category);
            }

            int totalElements = 0;

            Console.WriteLine();
            Console.WriteLine("===== Model Element Report =====");

            foreach (ModelCategory category in categories)
            {
                Console.WriteLine($"Category: {category.CategoryName}, Count: {category.Count}");
                totalElements += category.Count;
            }

            Console.WriteLine();
            Console.WriteLine($"Total Model Elements: {totalElements}");
        }
    }
}
