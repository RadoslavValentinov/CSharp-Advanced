using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using Birthdate.classes;
using Birthdate.Interfeces;

namespace Birthdate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var peopleAndReber =new List<IFood>();
           var people = new List<IBuyer>();
         

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input.Length==4)
                {
                    people.Add(new Citizen(input[0], int.Parse(input[1]), input[2], input[3]));
                }
                else if (input.Length==3)
                {
                    people.Add(new Rebel(input[0],int.Parse(input[1]),input[2]));
                }
            }

            string name = Console.ReadLine();

            while (name !="End")
            {
                var res = people.FirstOrDefault(x => x.Name == name);

                if (res != null)
                {
                    res.BuyFood();
                }

                name = Console.ReadLine();
            }

            Console.WriteLine(people.Sum(x=>x.Food));



            //// all.Where(c => c.Birthdate.Year == year)
            //   .Select(c => c.Birthdate)
            //   .ToList()
            //   .ForEach(dt => Console.WriteLine($"{dt:dd/mm/yyyy}"));
        }
    }
}
