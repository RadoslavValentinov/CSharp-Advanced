using System;
using System.Text;
using Microsoft.VisualBasic;

namespace _4._Symbol_in_Matrix_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeMatrix = int.Parse(Console.ReadLine());
            char[,] matrix = new char[sizeMatrix, sizeMatrix];
            bool isFind = false;
            for (int row = 0; row < sizeMatrix; row++)
            {
                string comand = Console.ReadLine();
                for (int col = 0; col < sizeMatrix; col++)
                {
                    matrix[row, col] = comand[col];
                }
            }
            char simbol = char.Parse(Console.ReadLine());
            int rowind = 0;
            int colind = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col]==simbol)
                    {
                        rowind = row;
                        colind = col;
                        isFind = true;
                        break;
                    }
                }
                if (isFind)
                {
                    break;
                }
            }

            if (isFind)
            {
                Console.WriteLine($"{(rowind,colind)}");
            }
            else
            {
                Console.WriteLine($"{simbol} does not occur in the matrix");
            }
        }
    }
}
