using System;

namespace LoopsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1*/
            /*
            Console.WriteLine("Enter a range");
            int input = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= input; i++)
            {
	      Console.WriteLine(i);
            }
            */

            /*2*/
            /*
            Console.WriteLine("Enter a range");
            int input = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= input; i++)
            {
	      bool divisibleBy3 = (i%3==0);
	      bool divisibleBy7 = (i%7==0);
	      
	      if (!divisibleBy3 && !divisibleBy7)
	      {
		Console.WriteLine(i);
	      }
	      else
	      {
		Console.WriteLine("divisible by either 3 or 7");
	      }
            }
            */

            /*3*/
            /*
            Console.WriteLine("Enter a series of positive integers: ");
            int smallest = 1;
            int largest = 0;
            int input = 0;
            for(int i = 0; i < 5; i++)
            {
	      input = int.Parse(Console.ReadLine());
            
	      
	      
	      if (input > largest)
	      {
		largest = input;
	      }
	      else
	      {
		smallest = input;
	      }
	      
            }
            
            Console.WriteLine($"smallest is : {smallest} and largest is : {largest}");
            */

            /*4*/
            /*
            for (int suit = 1; suit <= 4; suit++)
            {

                switch (suit)
                {
                    case 1:
                        Console.Write("club:\t\t");
                        break;

                    case 2:
                        Console.Write("diamond:\t");
                        break;

                    case 3:
                        Console.Write("heart:\t\t");
                        break;

                    case 4:
                        Console.Write("spades:\t\t");
                        break;

                    default:
                        Console.Write("invalid");
                        break;
                }

                for (int card = 2; card <= 14; card++)
                {
                    switch (card)
                    {
                        case 11:
                            continue;
                        case 12:
                            Console.Write("Q"); break;
                        case 13:
                            Console.Write("K"); break;
                        case 14:
                            Console.Write("A"); break;
                        default:
                            Console.Write(card); break;
                    }
                }

                Console.WriteLine();

            }*/

            /*5*/
            /*
            Console.Write("Input number N: ");
            int input = int.Parse(Console.ReadLine());

            int previousNumber = 0;
            int currentNumber = 1;
            int sum = 1;
            int nextNumber = 0;

            Console.Write($"{previousNumber} {currentNumber} ");
            for (int i = 0; i < input; i++)
            {
                nextNumber = previousNumber + currentNumber;
                sum += nextNumber;
                Console.Write(nextNumber + " ");

                previousNumber = currentNumber;
                currentNumber = nextNumber;
            }

            Console.WriteLine("Sum is :" + sum);
			*/

        }

    }
}
