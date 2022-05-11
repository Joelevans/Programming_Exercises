using System;

namespace SymmetricArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            
            Console.WriteLine("Enter the values of the array:");
            
            for(int i = 0; i < n; i++)
            {
	      array[i] = int.Parse(Console.ReadLine());
            }
            
            bool symmetric = true;
            
            //iterate through half of the array
            for(int i = 0; i < n/2; i++)
            {
	      if(array[i] != array[n - i - 1])
	      {
		symmetric = false;
		break;
	      }
            }
            
            Console.WriteLine($"Is symmetric? {symmetric}");
        }
    }
}
