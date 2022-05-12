using System;

namespace MaxPlatform
{
    //find the sub-matrix of size 2x2 with the maximum sum
    class Program
    {
        static void Main(string[] args)
        {
            //declare and initialize the matrix
            int[,] matrix =
            {
	      {0,2,4,0,9,5},
	      {7,1,3,3,2,1},
	      {1,3,9,8,5,6},
	      {4,6,7,9,1,0},
            };
            
            
            long maxSum = long.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            
            for(int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
	      for(int col = 0; col < matrix.GetLength(1) - 1; col++)
	      {
		long sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + 
		  matrix[row + 1, col + 1];
		if (sum > maxSum)
		{
		  maxSum = sum;
		  bestRow = row;
		  bestCol = col;
		}
	      }
            }
            
            //Output the result
            Console.WriteLine("The best platform is: ");
            Console.WriteLine($"{matrix[bestRow,bestCol]} {matrix[bestRow,bestCol + 1]}");
            Console.WriteLine($"{matrix[bestRow + 1,bestCol]} {matrix[bestRow + 1, bestCol]}");
        }
    }
}
