using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4_Classes
{

    public class Constructors
    {
        public static void Main(string[] args)
        {
            {
                Console.WriteLine("Please write a name and hit enter key (repeat 3 times)");
            }
            int total = 3;
            Person[] persons = new Person[total];
            for (int i = 0; i < total; i++)
            {
                persons[i] = new Person(Console.ReadLine());
            }
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
        }
        public class Person
        {
            public string Name { get; set; }
            public Person(string name)
            {
                Name = name;
            }
            public string ToString()
            {
                return "Hello! My name is " + Name;
            }
            ~Person()
            {
            }
        }
    }
}
