using System;

class Iterations{
	
	static void Main (){
		//For loops
		
		//every integer from 0 to 99
		/*
		for (int i = 0; i < 100; i++)
		{
			Console.Write(i);
		}
		*/
		
		//given some positive integer, compute the factorial of n and assign it
		// to the variable factorial.
		// Factorial of 5
		/*
		int n = 6;
		int factorial = 1;
		for (int i = 1; i < n; i++)
		{
			factorial *= i;
		}
		Console.Write(factorial);
		*/
		
		//print a triangle made of asterisks seperated by spaces. Triangle should consist of n rows,
		// where n is a given positive integer, and consecutive rows should contain 1,2,..n.
		/*
			for n = 4 then
			*
			**
			***
			****
		
		*/
				//soln use two loops, outer loop should print one row in each step,
				// and the inner should print one asterisk in each step.
				/*
				int n = 4;
				for (int i = 0; i < n; i++)
				{
					
					for (int j = 0; j <= i; j++)
					{
						Console.Write("*");
					}
					Console.WriteLine();
				}
				*/
		//print  a triangle made of asterisks seperated by spaces and consisting of n rows
		// but upside down, make it symmetrical. Consecutive rows should contain
		// 2n-1, 2n-3,...,3
		// should be indented by 0,2,4,..., 2(n-1) spaces
		/*
		the triangle should have n rows, where n is a given positive integer.
		for n = 4
		then
			* * * * * * *
			  * * * * * 
			    * * *
				  *
		*/
			//soln  three loops, one outer and two inner loops. outer loop prints one row of the triangle.
			//first inner loop is responsible for printing indentations
			// second inner loop for printing the asterisks
			int n = 4;
			for(int i = n; i > 0; i--)
			{
				//incomplete
				Console.WriteLine(i);
			}
				
				
				
				
				
				
				
				
				
				
				
				
				
				
				
				
				
				
				
				
				
				
	}
}