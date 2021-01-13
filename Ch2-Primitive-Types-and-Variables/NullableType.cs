using System;

class NullableType{
	static void Main()
	{
		int i = 5;
		int? ni = i;
		Console.WriteLine(ni);
		
		//i = ni; //this will fail to compile
		Console.WriteLine(ni.HasValue); //True
		i = ni.Value;
		Console.WriteLine(i); //5
		
		ni = null;
		Console.WriteLine(ni.HasValue); //False
		//i = ni.Value; //System.InvalidOperationException
		i = ni.GetValueOrDefault();
		Console.WriteLine(i); //0
	}
}