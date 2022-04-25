using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
	    //Read prime-numbers.txt
        
            //Check whether a given number is prime or not
            
            Console.Write("Enter a positive number: ");
            int input = int.Parse(Console.ReadLine());
            
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(input);
            
            bool prime = true;
            
            while(prime && divider <= maxDivider)
            {
	      if(input % divider == 0)
	      {
		prime = false;
	      }
	      divider++;
	    }
	    
	    Console.WriteLine(input + " is prime?" + prime);
        }
    }
}
