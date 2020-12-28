using System;

class RealTypeExample{

	static void Main(){
		float floatPI = 3.14f;
		Console.WriteLine(floatPI);  //3.14
		
		double doublePI = 3.14;
		Console.WriteLine(doublePI); //3.14
		
		double nan = Double.NaN;
		Console.WriteLine(nan); //NaN
		
		double infinity = Double.PositiveInfinity;
		Console.WriteLine(infinity); //Infinity
	}

}
