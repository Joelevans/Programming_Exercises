using System;

namespace ReverseAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] reversedArray = new int[array.Length];
            
            //reverse the array
            for(int index = 0; index < array.Length; index++)
            {
	      reversedArray[reversedArray.Length - index - 1] = array[index];
            }
            
            //print the reversed array
            for(int index = 0; index < reversedArray.Length; index++)
            {
	      Console.Write(reversedArray[index] + " ");
            }
        }
    }
}
