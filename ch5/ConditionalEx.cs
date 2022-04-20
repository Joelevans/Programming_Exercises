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
	 float a, b, c, smallest;
	 a = float.Parse(Console.ReadLine());
	 b = float.Parse(Console.ReadLine());
	 c = float.Parse(Console.ReadLine());
	 
	    
	 if (a < b && a < c)
	 {
	  smallest = a;
	  a = smallest;
	 }
	 else if (b < a && b < c)
	 {
	  smallest = b;
	  b = smallest;
	 }
	 else if (c < a && c < b)
	 {
	  smallest = c;
	  c = smallest;
	 }
	 
	 if (b > c)
	 {
	    float temp;
	    temp = b;
	    b = c;
	    c = temp;
	 }
	 else
	 {
	  
	 }
	  
	 
	 Console.Write(a);
	 Console.Write(b);
	 Console.WriteLine(c);
	 
        
    }
}