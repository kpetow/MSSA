using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("No", "No");
            dictionary.Add("Pudding", "Pudín");
            dictionary.Add("Library", "Biblioteca");

            Console.WriteLine("English to Spanish Translator\n");
            Console.WriteLine("Press enter to see options.\n");
            Console.ReadKey();

            foreach(string key in dictionary.Keys)
            {
                Console.WriteLine(key);
            }

            Console.Write("\n Choose a word to translate: ");
            string input = Console.ReadLine();

            if (dictionary.ContainsKey(input))
            {
                Console.WriteLine("\n" + dictionary[input] + "\n");
            }
        }
    }
}

