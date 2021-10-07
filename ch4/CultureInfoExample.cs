using System;
using System.Threading;
using System.Globalization;

class CultureInfoExample
{
    static void Main()
    {
        DateTime d = new DateTime(2012, 02, 27, 17, 30, 22);
        Thread.CurrentThread.CurrentCulture =
            CultureInfo.GetCultureInfo("en-US");
        Console.WriteLine("{0:N}", 1234.56); //1,234.56
        Console.WriteLine("{0:D}", d); //Monday, February 27, 2012

        Thread.CurrentThread.CurrentCulture =
            CultureInfo.GetCultureInfo("de-de");
        Console.WriteLine("{0:N}", 1234.56); //1.234,56
        Console.WriteLine("{0:D}", d); //Montag, 27. Februar 2012
    }
}