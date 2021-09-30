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
		/*	ushort numberA = 52130;
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
			ulong numberN = 123456789123456789; */
		//-------------------------------------
		
		
		
		//---Qsn 2--
		//-------------------------------------
		/*
		Which of the following values can be assigned to variables of type float, double and decimal: 5, -5.01,
		34.567839023, 12.345; 8923.1234857; 3456.091124875956542151256683467?
		*/
			/*	float floatA = 5f;
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
				Console.WriteLine(decimalA); */
		//-------------------------------------
		
		//---Qsn-3--
		//-------------------------------------
		/*Write a program, which compares correctly two real numbers with accuracy at least 0.000001.
		*/
		/// Two floating point variables are considered equal if their difference is less than some 
		/// predefined precision (e.g 0.000001):
		/// bool equal = Math.Abs(a - b) < 0.000001;
			/*
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
			*/	
		//-------------------------------------
		
		//---Qsn-4--
		//-------------------------------------
		/*
		Initialize a variable of type int with a value of 256 in hexadecimal format (256 is 100 in a numeral system with base 16).
		*/
			/*
				int numberInHex = 0x100;
				Console.Write(numberInHex);
			*/
		//-------------------------------------
		
	
		//---Qsn-5--
		//-------------------------------------
		/*
			Declare a variable of type char and assign it as a value the character,
			which has Unicode code, 72 (use the Windows calculator in order to find hexadecimal representation of 72).
		*/
			/*
			char charInUnicode = '\u0048';
			Console.Write(charInUnicode);
			*/
		
		//-------------------------------------
		
		//---Qsn-6--
		//-------------------------------------
		/* Declare a variable isMale of type bool and assign a value to it depending on your gender.
		*/
			//bool isMale = true;
		
		//-------------------------------------
		
		
		//---Qsn-7--
		//-------------------------------------
		/*
		Declare two variables of type string with values "Hello" and "World". Declare a variable of type object. 
		Assign the value obtained of concatenation of the two string variables (add space if necessary) to this variable. Print the variable of type object.
		*/
		/*
				string hello = "Hello";
				string world = "World";
				object helloWorld = hello + " " + world;
				
				Console.Write(helloWorld);
		*/		
		//-------------------------------------
		
		
		//---Qsn-8--
		//-------------------------------------
		/*
		Declare two variables of type string and give them values "Hello" and "World". Assign the value obtained by the concatenation 
		of the two variables of type string (do not miss the space in the middle) 
		to a variable of type object. Declare a third variable of type string and initialize it with the 
		value of the variable of type object (you should use type casting).
		*/
			/*
				string hello = "Hello";
				string world = "World";
				object helloWorld = hello + " " + world;
				string newHelloWorld = (string)helloWorld;
				
				Console.Write(newHelloWorld);
			*/
		//-------------------------------------
		
		
		//---Qsn-9--
		//-------------------------------------
		/*
		Declare two variables of type string and assign them a value
		“The "use" of quotations causes difficulties.” (without the outer quotes). 
		In one of the variables use quoted string and in the other do not use it.
		*/
		//-------------------------------------
		/*
			string one = "The \"use\" of quotations causes difficulties";
			string two = @"The ""use"" of quotations causes difficulties";
			
			Console.WriteLine(one);
			Console.WriteLine(two);
		*/
		
		
		//---Qsn-10--
		//-------------------------------------
		/*
		Write a program to print a figure in the shape of a heart by the sign "o".
		*/
			/*
				char o = 'o';
				
				Console.WriteLine( "  " + o + "  " + o + "    " + o + "  " + o );
				Console.WriteLine(" " + o +"\t" + o + "     " + o);
				Console.WriteLine("  " + o + "\t" + "     " + o);
				Console.WriteLine("   " + o + "\t" + "    " + o);
				Console.WriteLine("    " + o + "\t" + "   " + o);
				Console.WriteLine("     " + o + "\t" + "  " + o);
				Console.WriteLine("\t"  + o);
		*/
		
		//---Qsn-11--
		//-------------------------------------
		/*
		Write a program that prints on the console isosceles triangle which sides consist of the copyright character "©".
		*/
		
		//-------------------------------------
			/*
				char copyright = '\u00A9';
				Console.OutputEncoding = System.Text.Encoding.UTF8;
				Console.WriteLine(copyright + "  " + copyright + "  " + copyright + "  " + copyright);
				Console.WriteLine(copyright + "      " + copyright);
				Console.WriteLine(copyright + "   " + copyright);
				Console.WriteLine(copyright);
			*/
			
	
	
		//---Qsn-12--
		//-------------------------------------	
		/*
		A company dealing with marketing wants to keep a data record of its employees. Each record should have the following 
		characteristic – first name, last name, age, gender (‘m’ or ‘f’) and unique employee number (27560000 to 27569999). 
		Declare appropriate variables needed to maintain the information for an employee by using the appropriate data types and attribute names.
		*/
			/*
				string firstName, lastName;
				byte age;
				char genderM = 'm';
				char genderF = 'f';
				int uniqueNumber;
			*/
			
			
		//---Qsn-13--
		//-------------------------------------		
		/*
		Declare two variables of type int. Assign to them values 5 and 10 respectively. Exchange (swap) their values and print them.
		*/		
			
			//First method using temporary variable
			/*	int A,B,C;
				A = 5;
				B = 10;
				
				C = A;
				A = B;
				B = C;
				
				Console.WriteLine("A:"+ A +"\n" + "B:" + B + "\n" + "C:" + C);
			*/
			
			//Second method
			/*	int A, B;
				A = 5;
				B = 10;
				
				A = A + B;
				B = A - B;
				A = A - B;
				
				Console.WriteLine("A:"+ A +"\n" + "B:" + B );
			*/
			
	
			
		}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
}