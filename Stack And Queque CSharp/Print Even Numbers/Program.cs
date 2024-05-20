using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] sdplited = new int[input.Length];
            Queue<string> evenNumber = new Queue<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2==0)
                {
                    evenNumber.Enqueue(input[i].ToString());
                }
            }

            Console.WriteLine(string.Join(", ",evenNumber));
        }
    }
}
