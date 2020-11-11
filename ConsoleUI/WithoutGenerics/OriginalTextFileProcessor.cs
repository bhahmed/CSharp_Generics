using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleUI.Models;

namespace ConsoleUI.WithoutGenerics
{
    class OriginalTextFileProcessor
    {
        public static void SavePeople(List<Person> people, string file)
        {
            List<string> lines = new List<string>();

            // Add a header row
            lines.Add("FirstName,IsAlive,LastName");

            foreach (var p in people)
            {
                lines.Add($"{ p.FirstName },{ p.IsAlive },{ p.LastName }");
            }

            System.IO.File.WriteAllLines(file, lines);
        }

        public static List<Person> LoadPeople(string file)
        {
            List<Person> output = new List<Person>();
            Person p;
            var lines = System.IO.File.ReadAllLines(file).ToList();

            // Remove the header
            lines.RemoveAt(0);

            foreach (var line in lines)
            {
                var vals = line.Split(',');
                p = new Person
                {
                    FirstName = vals[0],
                    IsAlive = bool.Parse(vals[1]),
                    LastName = vals[2]
                };

                output.Add(p);
            }

            return output;
        }
    }
}
