using System;

namespace LotteryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find all possible combinations of the lottery game "6/49"
            /*
            *Find and print all possible extracts of 6 different numbers,
            *in the range [1...49]
            *the numbers cannot be repeated
            
            */
            
            for(int a = 1; a <= 44; a++)
            {
	      for(int b = a + 1; b <= 45; b++)
	      {
		for(int c = b + 1; c <= 46; c++)
		{
		  for(int d = c + 1; d <= 47; d++)
		  {
		    for(int e = d + 1; e <= 48; e++)
		    {
		      for(int f = e + 1; f <= 49; f++)
		      {
			Console.WriteLine(a + "" + b + "" + c + "" + d + "" + e + "" + f);
		      }
		    }
		  }
		}
	      }
            }
        }
    }
}
