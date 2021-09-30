using System;

class IntegerLiterals {
	
	static void Main(){
		//The following variables are initialized with the same value
		int numberInDec = 16;
		int numberInHex = 0x10;
		
		int longInt = 234L; // cannot convert type long to int
		
		Console.WriteLine("numberInDec is : " + numberInDec);
		Console.WriteLine("numberInHex is : " + numberInHex);
	}
	
}