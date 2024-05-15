using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] sizes = line.Split(", ");
            int sizeRow = int.Parse(sizes[0]);
            int sizeCol = int.Parse(sizes[1]);

            int[,] matrix = new int[sizeRow, sizeCol];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string element = Console.ReadLine();
                string[] splited = element.Split(", ");

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(splited[col]);
                }
            }

            int sum = 0;
            int maxSum = 0;
            int rows = 0;
            int cols = 0;

            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        rows = row;
                        cols = col;
                    }
                }
            }
            for (int row = rows; row < rows+2; row++)
            {
                for (int i = cols; i < cols+2; i++)
                {
                    Console.Write(matrix[row,i] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
