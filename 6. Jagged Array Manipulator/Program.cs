using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jaggedArray = new double[rows][];
            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                double[] cols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                jaggedArray[row] = cols;
            }
            for (int row = 0; row < jaggedArray.Length - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row +1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;
                    }
                    for (int col = 0; col < jaggedArray[row +1].Length; col++)
                    {
                        jaggedArray[row +1][col] /= 2;
                    }
                }
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(tokens[1]);
                int column = int.Parse(tokens[2]);
                double value = double.Parse(tokens[3]);
                if (tokens[0] == "Add")
                {
                    if (row >= 0 && row < jaggedArray.Length && column >= 0 && column < jaggedArray[row].Length)
                    {
                        jaggedArray[row][column] += value;
                    }
                }
                else
                {
                    if (row >= 0 && row < jaggedArray.Length && column >= 0 && column < jaggedArray[row].Length)
                    {
                        jaggedArray[row][column] -= value;
                    }
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write($"{jaggedArray[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
