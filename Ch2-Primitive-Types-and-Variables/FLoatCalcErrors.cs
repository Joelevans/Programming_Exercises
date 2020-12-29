using System;

class FloatCalcErrors {
	
	static void Main ()
	{
		float f = 0.1f;
		Console.WriteLine(f); // 0.1 (correct due to rounding)
		
		double d = 0.1f;
		Console.WriteLine(d); // 0.100000001490116 (incorrect)
		
		float ff = 1.0f/3;
		Console.WriteLine(ff); // 0.3333333 (correct due to rounding)
		
		double dd = ff;
		Console.WriteLine(dd); // 0.333333343267441 (incorrect)
	}
	
	
}