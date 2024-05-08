using System;
using System.Linq;

namespace Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split(", ")
                .Select(int.Parse)
                .Where(x=>x % 2==0)
                .OrderBy(x=>x)
                .ToArray();
            Console.WriteLine(string.Join(", ",number));
        }
    }
}
