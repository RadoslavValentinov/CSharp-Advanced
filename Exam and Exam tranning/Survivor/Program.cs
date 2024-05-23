using System;

namespace _02.Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
             // input row of jadged array
            int row=int.Parse(Console.ReadLine());

            char[][] beach = new char[row][];
            
            for (int i = 0; i < row; i++)
            {
                var line = Console.ReadLine().ToCharArray();
                beach[row] = line;
            }

        }
    }
}
