using System;

class CharacterLiterals
{
	
	public static void Main ()
	{
		//an ordinary character
		char character = 'a';
		Console.WriteLine(character);
		
		//Unicode character code in a hexadecimal format
		character = '\u003A';
		Console.WriteLine(character);
		
		//Assigning the single quotation character (escaped as \')
		character = '\'';
		Console.WriteLine(character);
		
		//Assigning the backslash character (escaped as \\)
		character = '\\';
		Console.WriteLine(character);
		
		// Console output: // a // : // ' // \
	}
	
}