using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumber = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int elementOfQueue = inputNumber[0];
            int removeElement = inputNumber[1];
            int foundNumber = inputNumber[2];

            int[] elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> number = new Queue<int>(elements);
            bool isFound = false;

            for (int i = 0; i < removeElement; i++)
            {
                number.Dequeue();
            }

            for (int i = 0; i < number.Count; i++)
            {
                if (number.Contains(foundNumber))
                {
                    isFound = true;
                    break;
                }
            }

            if (isFound)
            {
                Console.WriteLine("true");
            }
            else if (!isFound && number.Count > 0)
            {
                Console.WriteLine(number.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
