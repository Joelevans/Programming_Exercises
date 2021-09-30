using System;

class RealLiterals{
	
	static void Main(){
		//The following is the correct way of assigning a value
		float realNumber = 12.5f;
		
		//This is the same value in exponential format
		float realNumberExponential = 1.25e+1f;
		
		//causes an error
		float realNumberDouble = 12.5;// Literal of type double cannot be implicitly converted to type 'float';
									 // use an 'F' suffix to create a literal of this type.
		
		Console.WriteLine("realNumber is : " + realNumber);
		Console.WriteLine("realNumberExponential is : " + realNumberExponential);
		
	}
	
}