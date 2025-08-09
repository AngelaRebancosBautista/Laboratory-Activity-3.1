using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> studentNames = new List<string>();
            int aNamesCount = 0;

            Console.WriteLine("Enter student names (type 'done' to finish):");

            while (true)

            {
                string input = Console.ReadLine();

                if (input?.ToLower() == "done")
                {
                    break;
                }

                if (!string.IsNullOrWhiteSpace(input))
                {
                    string uppercaseName = input.ToUpper();
                    studentNames.Add(uppercaseName);

                    if (uppercaseName.StartsWith("A"))
                    {
                        aNamesCount++;
                    }
                }
            }
            Console.WriteLine("\nAll student names in uppercase:");
            foreach (string name in studentNames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"\nNumber of names starting with 'A': {aNamesCount}");
        }
    }
}
            
