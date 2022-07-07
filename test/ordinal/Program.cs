using System;

namespace ordinal
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong ordinal,input = 1;
            
	  while(input > 0)
	  {
	      Console.WriteLine("Enter an integer: ");
	      
	      input = ulong.Parse(Console.ReadLine());
	      ordinal = input % 10;
	      
	      
	      switch(ordinal)
	      {
		case 1:
		    if(input == 11)
		    {
		      Console.WriteLine(input + "th");
		    }
		    else
		    {
			Console.WriteLine(input + "st");
		    }
		  break;
		  
		case 2:
		    if(input == 12)
		    {
		      Console.WriteLine(input + "th");
		    }
		    else
		    {
		      Console.WriteLine(input + "nd");
		    }
		  break;
		  
		case 3:
		    if(input == 13)
		    {
		      Console.WriteLine(input + "th");
		    }
		    else
		    {
		      Console.WriteLine(input + "rd");
		    }
		  break;
		  
		default:
		    Console.WriteLine(input + "th");
		    break;
	      }
         }
        }
    }
}
