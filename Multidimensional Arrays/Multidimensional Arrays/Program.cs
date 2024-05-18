using System;
using System.Linq;

namespace Multidimensional_Arrays_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];
            int primaryDiag = 0;
            int secDiag = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                primaryDiag += matrix[i, i];
            }

            int count = matrix.GetLength(1) - 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                secDiag += matrix[row, count];
                count--;
            }

            Console.WriteLine($"{Math.Abs(primaryDiag-secDiag)}");
        }
    }
}
