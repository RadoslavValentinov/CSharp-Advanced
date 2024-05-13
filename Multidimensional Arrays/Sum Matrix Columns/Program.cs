using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeMatrix = Console.ReadLine().Split(", ")
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[sizeMatrix[0], sizeMatrix[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputnumber = Console.ReadLine().Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputnumber[col];
                }
            }

            int sumcol = 0;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                sumcol = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumcol += matrix[row,col];
                }
                Console.WriteLine(sumcol);
            }

        }
    }
}
