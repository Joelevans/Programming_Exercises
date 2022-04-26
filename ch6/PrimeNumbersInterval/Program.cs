using System;

namespace PrimeNumbersInterval
{
    class Program
    {
        static void Main(string[] args)
        {
           //Print all prime numbers in the interval n..m
           Console.Write("n: ");
           int n = int.Parse(Console.ReadLine());
           
           Console.Write("m: ");
           int m = int.Parse(Console.ReadLine());

            for (int i = n; i <= m; i++)
            {
                bool isPrime = true;
                int divider = 2;
                int maxDivider = (int)Math.Sqrt(i);

                while (isPrime && divider <= maxDivider)
                {
                    if(i % divider == 0)
                    {
                        isPrime = false;
                    }

                    divider++;               
                }

                if (isPrime)
                {
                   Console.Write(i + " ");    
                }
            }
        }
    }
}
