using System;

namespace PrintTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
           int numberOfLines = int.Parse(Console.ReadLine());
           
           for(int i = 1; i <= numberOfLines; i++)
           {
	      for(int j = 1; j <= i; j++)
	      {
		Console.Write(j + " ");
	      }
	      
	      Console.WriteLine();
           }
        }
    }
}
