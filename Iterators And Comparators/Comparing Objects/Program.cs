using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
          
            List<Person> persons = new List<Person>();

            while (input !="END")
            {
                string[] splited = input.Split();
                string name = splited[0];
                int age = int.Parse(splited[1]);
                string town = splited[2];

                persons.Add(new Person(name, age, town));

                input = Console.ReadLine();
            }

            int index = int.Parse(Console.ReadLine())-1;

            var equal = 0;
            var noequel = 0;

            foreach (Person item in persons)
            {
                if (persons[index].CompareTo(item)==0)
                {
                    equal++;
                }
                else
                {
                    noequel++;
                }
            }

            if (equal <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equal} {noequel} {persons.Count}");
            }
        }
    }
}
