using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>()
            {
                {"name", "Titilayo"},
                {"age", "26"}
            });

            myFamily.Add("father", new Dictionary<string, string>()
            {
                {"name", "Timothy"},
                {"age", "56"}
            });

            myFamily.Add("brother", new Dictionary<string, string>()
            {
                {"name", "Oluwaseun"},
                {"age", "33"}
            });

            foreach(var member in myFamily)
            {
                Console.WriteLine($"{member.Value["name"]} is my {member.Key} and is {member.Value["age"]} years old");
            }
            Console.Read();
        }
    }
}
