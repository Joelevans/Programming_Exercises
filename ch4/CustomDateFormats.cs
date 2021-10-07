using System;

class CustomDateFormats
{
    static void Main()
    {
        DateTime d = new DateTime(2012, 02, 27, 17, 30, 22);
        Console.WriteLine(d);
        //Output: 27/02/2012 17:30:22

        Console.WriteLine("{0:dd/MM/yyyy hh:mm:ss}", d);
        //Output: 27/02/2012 05:30:22
    }
}