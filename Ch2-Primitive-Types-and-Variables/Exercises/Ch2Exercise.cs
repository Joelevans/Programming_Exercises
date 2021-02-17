using System;

class Ch2Exercise
{
	static void Main()
	{
		//---Qsn 1--
		//-------------------------------------
		/*Declare several variables by selecting for each one of them the most appropriate of the types sbyte,
		byte, short, ushort, int, uint, long and ulong in order to assign them the following values: 52,130; -115;
		4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 1990; 123456789123456789.
		*/
		ushort numberA = 52130;
		sbyte numberB = -115;
		int numberC = 4825932;
		sbyte numberD = 97;
		short numberE = -10000;
		short numberF = 20000;
		byte numberG = 224;
		int numberH = 970700000;
		byte numberJ = 112;
		sbyte numberK = -44;
		int numberL = -1000000;
		short numberM = 1990;
		ulong numberN = 123456789123456789;
		//-------------------------------------
		
		
		
		//---Qsn 2--
		//-------------------------------------
		/*
		Which of the following values can be assigned to variables of type float, double and decimal: 5, -5.01,
		34.567839023, 12.345; 8923.1234857; 3456.091124875956542151256683467?
		*/
		float floatA = 5f;
		float floatB = -5.01f;
		double doubleA = 34.567839023;
		float floatC = 12.345f;
		float floatD = 8923.1234857f;
		decimal decimalA = 3456.091124875956542151256683467m;
		
		Console.WriteLine(floatA);
		Console.WriteLine(floatB);
		Console.WriteLine(doubleA);
		Console.WriteLine(floatC);
		Console.WriteLine(floatD);
		Console.WriteLine(decimalA);
		//-------------------------------------
		
		//---Qsn-3--
		//-------------------------------------
		/*Write a program, which compares correctly two real numbers with accuracy at least 0.000001.
		*/
		/// Two floating point variables are considered equal if their difference is less than some 
		/// predefined precision (e.g 0.000001):
		/// bool equal = Math.Abs(a - b) < 0.000001;
		
		float a = 100.000001f;
		float b = 100.000302f;
		bool equal = Math.Abs(a -b) < 0.000001;
		if(equal)
		{
			Console.WriteLine("The numbers are equal");
		}
		else
		{
			Console.WriteLine("The numbers are not equal");
		}
		//-------------------------------------
		
	}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
}