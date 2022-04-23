using System;

namespace LoopsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1*/
            /*
            Console.WriteLine("Enter a range");
            int input = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= input; i++)
            {
	      Console.WriteLine(i);
            }
            */
            
            /*2*/
            /*
            Console.WriteLine("Enter a range");
            int input = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= input; i++)
            {
	      bool divisibleBy3 = (i%3==0);
	      bool divisibleBy7 = (i%7==0);
	      
	      if (!divisibleBy3 && !divisibleBy7)
	      {
		Console.WriteLine(i);
	      }
	      else
	      {
		Console.WriteLine("divisible by either 3 or 7");
	      }
            }
            */
        }
    }
}
