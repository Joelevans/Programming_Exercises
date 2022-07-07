using System;

namespace builderTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int blocks = int.Parse(Console.ReadLine());
            int i = 1;
            int height = 0; 
            
            while(i < blocks)
            {
	      i++;
	      blocks -= i;
	      height = i;
            }
            
            Console.WriteLine("The height of the pyramid is" + height);
        }
    }
}
