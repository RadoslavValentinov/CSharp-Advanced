using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Birthday_Celebration
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> guest = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            
            Stack<int> plateFood = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));


            int excessfood = 0;
   
            while (guest.Count > 0 && plateFood.Count > 0)
            {
                int guests = guest.Peek();
                int food = plateFood.Peek();

                if (guests > food)
                {
                    guests -= food;
                    food = plateFood.Pop();
                    
                    while (guests > 0)
                    {
                        food = plateFood.Peek();

                        if (food > guests)
                        {
                            food -= Math.Abs(guests);
                            guests = guest.Dequeue();
                            excessfood += food;
                            food = plateFood.Pop();
                            break;
                        }
                        else if (guests >= food)
                        {
                            guests -= food;
                            plateFood.Pop();
                            if (guests==0)
                            {
                                guest.Dequeue();
                                break;
                            }
                        }
                        else if (guests == food)
                        {
                            plateFood.Pop();
                            guest.Dequeue();
                        }
                    }
                }
                else if (food > guests)
                {
                    food -= guests;
                    excessfood += food;
                    guest.Dequeue();
                    plateFood.Pop();
                }
                else if (guests==food)
                {
                    plateFood.Pop();
                    guest.Dequeue();
                }
            }
            if (guest.Count > 0)
            {
                Console.Write("Guests: ");
                foreach (var item in guest)
                {
                    Console.Write($"{item+" "}");
                }

                Console.WriteLine();
                Console.WriteLine($"Wasted grams of food: {excessfood}");
            }
           
            if (plateFood.Count > 0)
            {
                Console.Write($"Plates: ");
                foreach (var item in plateFood)
                {
                    Console.Write($"{item+" "}");
                }
                Console.WriteLine();
                Console.WriteLine($"Wasted grams of food: {excessfood}");
            }
        }
    }
}
