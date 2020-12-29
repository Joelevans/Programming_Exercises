using System;

class BooleanType{

	static void Main(){
		int a = 1;
		int b = 2;
		//Which one is greater?
		
		bool greaterAB = (a > b); //false
		bool equalA1 = (a == 1); //true
		
		//Print results on the console
		if(greaterAB)
		{
			Console.WriteLine("A > B");
		}
		else
		{
			Console.WriteLine("A <= B");
		}
			
		Console.WriteLine("greaterAB =" + greaterAB);
		Console.WriteLine("equalA1 =" + equalA1);
		
		//Console output:
		// A <= B
		//greaterAB = False
		//equalA1 = True
	}

}	
