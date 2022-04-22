using System;

class ConditionalEx
{
    static void Main(string[] args)
    {
        // /*1*/
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

        // /*2*/
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
        //int a,b,c,d;
        //a = int.Parse(Console.ReadLine());
        //b = int.Parse(Console.ReadLine());
        //c = int.Parse(Console.ReadLine());
        
        //d = 0;
        //if (a > b)
	  //{
	    //d = a;
	  //}
	//else
	  //{
	    //d = b;
	  //}
	  
	//if (d > c)
	  //{
	    //Console.WriteLine(d);
	  //}
        //else 
	  //{
	    //Console.WriteLine(c);
	  //}
	  
	  
	  /*4*/
	 //sort 3 real numbers in descending order
	 /*
	 int a, b, c;
	 a = int.Parse(Console.ReadLine());
	 b = int.Parse(Console.ReadLine());
	 c = int.Parse(Console.ReadLine());
	 
	 
	 if(a < b)
	 {
	  int temp = a;
	  a = b;
	  b = temp;
	 }
	 else if (b < c)
	 {
	  int temp2 = b;
	  b = c;
	  c = temp2;
	 
	  if(a < b)
	  {
	    int temp3 = a;
	    a = b;
	    b = temp3;
	  }
	  
	 }
	 
	 
	 Console.Write(a);
	 Console.Write(b);
	 Console.WriteLine(c);
	 */
	 
	 /*5*/
	
	/*
        int a = int.Parse(Console.ReadLine());
        
        switch(a)
	{
	   case 0:
	    Console.WriteLine("Zero"); break;
	   case 1:
	    Console.WriteLine("One"); break;
	   case 2:
	    Console.WriteLine("Two"); break;
	   case 3:
	    Console.WriteLine("Three"); break;
	   case 4:
	    Console.WriteLine("Four"); break;
	   case 5:
	    Console.WriteLine("Five"); break;
	   case 6:
	    Console.WriteLine("Six"); break;
	   case 7:
	    Console.WriteLine("Seven"); break;
	   case 8:
	    Console.WriteLine("Eight"); break;
	   case 9:
	    Console.WriteLine("Nine"); break;
	   case 10:
	      Console.WriteLine("Ten"); break;
	    
	   default:
	    Console.WriteLine("Invalid number"); break;
	 
	}
	*/
	
	/*6*/
	
	//mathematical
	
	/*7*/
	/*
	int previousNumber = 0;
	int maxNumber = 0;
	
	for (int i = 0; i < 5; i++)
	{
	  Console.WriteLine("Enter a number: ");
	  int inputNumber = int.Parse(Console.ReadLine());
	  
	  if (inputNumber > previousNumber)
	  {
	    maxNumber = inputNumber;
	  }
	  
	  previousNumber = inputNumber;
	}
        
        Console.WriteLine(maxNumber);
        */
        
        /*8*/
        /*
        int choice;
        
        Console.Write("Write 0 for int, 1 for double, 2 for string");
        choice = int.Parse(Console.ReadLine());
        
        
        switch(choice)
        {
	  case 0:
	  Console.WriteLine("Enter an integer");
	  int a = int.Parse(Console.ReadLine());
	  a+=1;
	  Console.WriteLine(a);
	  break;
	  
	  case 1:
	  Console.WriteLine("Enter a double");
	  double b = double.Parse(Console.ReadLine());
	  b+=1.5d;
	  Console.WriteLine(b);
	  break;
	  
	  case 2:
	  Console.WriteLine("Enter a String");
	  string str = Console.ReadLine();
	  str += "*";
	  Console.WriteLine(str);
	  break;
	  
	  default:
	    Console.WriteLine("Invalid choice");
	    break;
        }
        */
	
    }
}