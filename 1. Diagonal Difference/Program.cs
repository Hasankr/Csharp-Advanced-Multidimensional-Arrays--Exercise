using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int leftRightsum = 0;
            int rightLeftsum = 0;
            for (int row = 0; row < size; row++)
            {
                int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = numbers[col];
                }
                
                
                
            }
            for (int i = 0, j = size - 1; i < size; i++, j--)
            {
                leftRightsum += matrix[i, i];
                rightLeftsum += matrix[j, i];
            }

            Console.WriteLine(Math.Abs(leftRightsum - rightLeftsum));

        }
    }
}
