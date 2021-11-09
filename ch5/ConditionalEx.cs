using System;

class ConditionalEx
{
    static void Main(string[] args)
    {
        /*1*/
        // int a = 20;
        // int b = 15;
        // int c = 0;

        // if (a > b)
        // {
        //     c = a;
        //     a = b;
        //     b = c;
        // }
        // Console.WriteLine("a is {0}", a);
        // Console.WriteLine("b is {0}", b);

        /*2*/
        // double a = double.Parse(Console.ReadLine());
        // double b = double.Parse(Console.ReadLine());
        // double c = double.Parse(Console.ReadLine());
        // bool isPositive;

        // if ((a > 0) && (b > 0) && (c > 0)) //all are positive
        // {
        //     isPositive = true;
        // }
        // else if ((a > 0) ^ (b > 0) ^ (c > 0))//one and only one is positive
        // {
        //     isPositive = true;
        // }
        // else if ((a < 0) ^ (b < 0) ^ (c < 0))//one and only one is negative
        // {
        //     isPositive = false;
        // }
        // else
        // {
        //     isPositive = false;
        // }

        // Console.WriteLine(isPositive);

        /*3*/
        // int a = int.Parse(Console.ReadLine());
        // int b = int.Parse(Console.ReadLine());
        // int c = int.Parse(Console.ReadLine());

        // if ((a > b) && (a > c))
        // {
        //     Console.WriteLine(a);
        // }
        // else if ((b > a) && (b > c))
        // {
        //     Console.WriteLine(b);
        // }
        // else if ((c > a) && (c > b))
        // {
        //     Console.WriteLine(c);
        // }
        // else 
        // {
        //     Console.WriteLine("Inputted numbers are equal");
        // }

        /*4*/
        // int a = int.Parse(Console.ReadLine());
        // int b = int.Parse(Console.ReadLine());
        // int c = int.Parse(Console.ReadLine());
        // int largest = 0;
        // int middle = 0;
        // int smallest = 0;

        // if ((a > b) && (a > c))
        // {
        //     largest = a;

        //     if (b > c)
        //     {
        //         middle = b;
        //         smallest = c;
        //     }
        //     else
        //     {
        //         middle = c;
        //         smallest = b;
        //     }
        // }
        // else if ((b > a) && (b > c))
        // {
        //     largest = b;

        //     if (a > c)
        //     {
        //         middle = a;
        //         smallest = c;
        //     }
        //     else
        //     {
        //         middle = c;
        //         smallest = a;
        //     }
        // }
        // else if ((c > a) && (c > b))
        // {
        //     largest = c;
        //     if (a > b)
        //     {
        //         middle = a;
        //         smallest = b;
        //     }
        //     else
        //     {
        //         middle = b;
        //         smallest = a;
        //     }
        // }
        // else 
        // {
        //     Console.WriteLine("Inputted numbers are equal");
        //     largest = a;
        //     middle = a;
        //     smallest = a;
        // }

        // Console.WriteLine(largest);
        // Console.WriteLine(middle);
        // Console.WriteLine(smallest);

        /*5*/
        // Console.WriteLine("Input digit [0 -9] :");
        // int digit = int.Parse(Console.ReadLine());

        // while ((digit < 0) || (digit > 9))
        // {
        //     Console.WriteLine("Please Input digit [0 -9] :");
        //     digit = int.Parse(Console.ReadLine());
        // }

        // switch (digit)
        // {
        //     case 0:
        //     Console.WriteLine("Zero");
        //     break;

        //     case 1:
        //     Console.WriteLine("One");
        //     break;

        //     case 2:
        //     Console.WriteLine("Two");
        //     break;

        //     case 3:
        //     Console.WriteLine("Three");
        //     break;
            
        //     case 4:
        //     Console.WriteLine("Four");
        //     break;
            
        //     case 5:
        //     Console.WriteLine("Five");
        //     break;

        //     case 6:
        //     Console.WriteLine("Six");
        //     break;

        //     case 7:
        //     Console.WriteLine("Seven");
        //     break;

        //     case 8:
        //     Console.WriteLine("Eight");
        //     break;

        //     case 9:
        //     Console.WriteLine("Nine");
        //     break;

        //     default:
        //     Console.Write("out of range");
        //     break;
        // }

        /*6*/
        //out of range

        /*7*/
        // int num = 0;
        // int largest = 0;

        // for (int i = 0; i < 5; i++)
        // {
        //     Console.WriteLine("Enter a number:");
        //     num = int.Parse(Console.ReadLine());
        //     if(num > largest)
        //         largest = num;
        // }

        // Console.WriteLine("{0} is the largest", largest);
    }
}