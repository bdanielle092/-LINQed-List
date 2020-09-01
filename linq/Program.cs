using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            // List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            // IEnumerable<string> query = fruits.Where(fruit => fruit.StartsWith("L"));
            // foreach (string fruit in query)
            // {
            //     Console.WriteLine(fruit);
            // }

            // Which of the following numbers are multiples of 4 or 6
            // List<int> numbers = new List<int>()
            // {
            //     15,
            //     8,
            //     21,
            //     24,
            //     32,
            //     13,
            //     30,
            //     12,
            //     7,
            //     54,
            //     48,
            //     4,
            //     49,
            //     96
            // };

            // IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0);
            // fourSixMultiples.ToList().ForEach(number => Console.WriteLine(number));

            // Order these student names alphabetically, in descending order (Z to A)
            //     List<string> names = new List<string>()
            //     {
            //         "Heather",
            //         "James",
            //         "Xavier",
            //         "Michelle",
            //         "Brian",
            //         "Nina",
            //         "Kathleen",
            //         "Sophia",
            //         "Amir",
            //         "Douglas",
            //         "Zarley",
            //         "Beatrice",
            //         "Theodora",
            //         "William",
            //         "Svetlana",
            //         "Charisse",
            //         "Yolanda",
            //         "Gregorio",
            //         "Jean-Paul",
            //         "Evangelina",
            //         "Viktor",
            //         "Jacqueline",
            //         "Francisco",
            //         "Tre"
            //     };

            //     List<string> descend = names.OrderByDescending(name => name).ToList();
            //     descend.ForEach(descend => Console.WriteLine(descend));
            // }

            // Build a collection of these numbers sorted in ascending order
            // List<int> numbers = new List<int>()
            // {
            //     15,
            //     8,
            //     21,
            //     24,
            //     32,
            //     13,
            //     30,
            //     12,
            //     7,
            //     54,
            //     48,
            //     4,
            //     49,
            //     96
            // };
            // List<int> sortedNumbers = numbers.OrderBy(number => number).ToList();
            // sortedNumbers.ForEach(sorted => Console.WriteLine(sorted));

            // Output how many numbers are in this list
            List<int> numbers = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

        }

    }
}