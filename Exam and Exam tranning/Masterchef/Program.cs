using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingredient = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> freshness = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int dipping = 0;
            int salad = 0;
            int cake = 0;
            int lopster = 0;

            while (ingredient.Count > 0 && freshness.Count > 0)
            {

                int ingredients = ingredient.Peek();
                int freshnes = freshness.Peek();

                int curentSum = ingredients * freshnes;

                if (curentSum == 150)
                {
                    dipping++;
                    ingredient.Dequeue();
                    freshness.Pop();
                }
                else if (curentSum == 250)
                {
                    salad++;
                    ingredient.Dequeue();
                    freshness.Pop();
                }
                else if (curentSum == 300)
                {
                    cake++;
                    ingredient.Dequeue();
                    freshness.Pop();
                }
                else if (curentSum == 400)
                {
                    lopster++;
                    ingredient.Dequeue();
                    freshness.Pop();
                }
                if (ingredients == 0)
                {
                    ingredient.Dequeue();
                }
                else if (curentSum !=150 && curentSum !=250 && curentSum !=300 && curentSum !=400)
                {
                    freshness.Pop();
                    ingredients += 5;
                    ingredient.Dequeue();
                    ingredient.Enqueue(ingredients);
                }
            }

            if (dipping > 0 && salad > 0 && cake > 0 && lopster > 0)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
                Console.WriteLine($" # Chocolate cake --> {cake}");
                Console.WriteLine($" # Dipping sauce --> {dipping}");
                Console.WriteLine($" # Green salad --> {salad}");
                Console.WriteLine($" # Lobster --> {lopster}");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
                if (ingredient.Count > 0)
                {
                    Console.WriteLine($"Ingredients left: {ingredient.Sum()}");
                }
                if (cake > 0)
                {
                    Console.WriteLine($" # Chocolate cake --> {cake}");
                }
                if (dipping > 0)
                {
                    Console.WriteLine($" # Dipping sauce --> {dipping}");
                }
                if (salad > 0)
                {
                    Console.WriteLine($" # Green salad --> {salad}");
                }
                if (lopster > 0)
                {
                    Console.WriteLine($" # Lobster --> {lopster}");
                }
                // 100/100
            }
        }
    }
}
