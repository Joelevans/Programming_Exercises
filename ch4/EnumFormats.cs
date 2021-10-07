using System;

class EnumFormats
{
    static void Main()
    {
        Console.WriteLine(DayOfWeek.Wednesday);
        //Output: Wednesday
        Console.WriteLine("{0:G}", DayOfWeek.Wednesday);
        //Output: Wednesday
        Console.WriteLine("{0:D}", DayOfWeek.Wednesday);
        //Output: 3
        Console.WriteLine("{0:X}", DayOfWeek.Wednesday);
    }
}