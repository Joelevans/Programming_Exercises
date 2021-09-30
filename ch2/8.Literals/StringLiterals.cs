using System;

class StringLiterals
{
	static void Main()
	{
		string quotation = "\"Hello, Jude\", he said.";
		Console.WriteLine(quotation);
		
		string path = "C:\\Windows\\Notepad.exe";
		Console.WriteLine(path);
		
		string verbatim = @"The \ is not escaped as \\.
		I am at a new line.";
		Console.WriteLine(verbatim);
	}
	
	
}