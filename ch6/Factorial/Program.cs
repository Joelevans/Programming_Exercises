using System;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
	  
        
	    // Using an infinite loop
	    /*
	     
            Console.WriteLine("Enter a positive integer: ");
            int input = int.Parse(Console.ReadLine());
            
            //128 bit integer maximum value of input is 27!
            decimal factorial = 1;
            
            while(true)
            {
	      if(input <= 1)
	      {
		break;
	      }
	      
	      factorial *=input;
	      input--;
	      
            }
            Console.WriteLine("n! =  " + factorial);
	    */
	      
	      
	    // Using a do while loop
	    Console.WriteLine("Enter a positive integer: ");
	    int input = int.Parse(Console.ReadLine());
	    
	    //new datatype to store big integers, OverflowException will not occur
	    BigInteger factorial = 1;
	    
	    do
	    {
	      factorial *= input;
	      input--;
	    } while(input > 0);
	    
	    Console.WriteLine("n! = " + factorial);
	    
	}
    }
}
