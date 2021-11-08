using System;

class OperatorsEx
{
    static void Main(string[] args)
    {
        //1. Expression that checks whether an integer is odd or even
        /*
        int i = 6;
        Console.WriteLine((i % 2) == 0 ? "even" : "odd"); //odd
        */

        /*2. Write a Boolean expression that checks whether a given integer is
             divisible by both 5 and 7 without a remainder */

        /*
        int i = 35;
        Console.WriteLine(((i % 5) == 0) && ((i % 7) == 0) ? "Divisible by both 5 and 7" : "Not divisble");
        */

        /*3. Write an expression that looks for a given integer if its third digit(right to left) is 7 */
        // int i = 100507;
        // int hundreds = (i/100) % 10;
        // Console.WriteLine(hundreds == 7 ? "Third digit is 7" : "Third digit is not 7");

        /*4. Write an expresion that checks whether the third bit in a given integer is 1 or 0 */
        // int num = 25;
        // Console.WriteLine((num & 8) == 0 ? "Third bit is 0" : "Third bit is 1");

        /*5. Write an expressin that calcualtes the area of a trapezoid by given sides a, b and height h*/
        // float a,b,h, area;
        // a = 5;
        // b = 10;
        // h = 15;
        // area = (a + b) * (h/2);
        // Console.WriteLine(area);

        /*6.Program that prints perimeter and area of a rectangle given side and height by the user*/
        // int height = int.Parse(Console.ReadLine());
        // Console.Write(height);
        // int width = int.Parse(Console.ReadLine());
        // Console.WriteLine("Height is {0} and width is {1}", height, width);
        // int area = width * height;
        // int perimeter = (width + height) * 2;
        // Console.WriteLine("Area is {0} and Perimeter is {1}", area, perimeter);

        /*7.The gravitational field of the moon is approximately 17% of that on the Earth.
          Write a program that calculates the weight of a man on the moon by a given weight 
          on the earth
        */
        // Console.Write("Enter Weight: ");
        // int weight = int.Parse(Console.ReadLine());
        // float weightOnTheMoon = weight * 0.17f;
        // Console.Write("Weight on the moon is {0}", weightOnTheMoon);

        /*8*/
        // int x = 0;
        // int y = 0;
        // int r = 5;
        // bool withinCircle = ( (x * x) + (y * y) ) <= (r * r);
        // Console.Write(withinCircle ? "The point is within the circle" : "The point is not in the circle");

        /*9*/
        // int x = 0;
        // int y = 0;
        // int radius = 5;
        // bool withinCircle = ((x * x) + (y * y) <= (radius * radius));

        // //rectangle bottom left co-ordinate
        // int coordDx = -1;
        // int coordDy = 1;

        // //rectangle top right co-ordinate
        // int coordBx = 5;
        // int coordBy = 5;

        // /*
        //  *Point lies inside the rectangle if its x co-ordinate lies between
        //  *the given bottom left and top right
        //  *AND
        //  *if its y co-ordinate lies between the given bottom left and top right
        //  */

        //  bool withinRectangle = ((coordDx <= x) & (x <= coordBx)) & ((coordDy <= y ) & (y <= coordBy));

        //  Console.WriteLine(withinCircle & withinRectangle ? "The points are within Circle and Rectangle" : "The points are outside circle or rectangle");


        // /*10*/
        // int num = int.Parse(Console.ReadLine());
        // string numString = num.ToString();
        // char firstChar = numString[0];
        // char secondChar = numString[1];
        // char thirdChar = numString[2];
        // char fourthChar = numString[3];

        // //sum
        // int sum = int.Parse(firstChar.ToString()) + int.Parse(secondChar.ToString())
        //           + int.Parse(thirdChar.ToString()) + int.Parse(fourthChar.ToString());

        // Console.WriteLine(sum);

        // //last digit in the first position
        // string lastDigitInFirst = 
        //   fourthChar.ToString()
        //   + firstChar.ToString()
        //   + secondChar.ToString()
        //   + thirdChar.ToString();

        // Console.WriteLine(lastDigitInFirst);

        // //exchange second and third digits
        // string exchangeSecondAndThird =
        //   firstChar.ToString()
        //   + thirdChar.ToString()
        //   + secondChar.ToString()
        //   + fourthChar.ToString();

        // Console.WriteLine(exchangeSecondAndThird);


        // /*11*/
        // Console.Write("Enter a number: ");
        // int num = int.Parse(Console.ReadLine());

        // Console.Write("Enter a position: ");
        // int pos = int.Parse(Console.ReadLine());

        // int i = 1;
        // int mask = i << pos; // Move the 1st bit left by p positions
        // Console.WriteLine( (num & mask) != 0 ? 1 : 0);

        /*12*/
        //similar to the above question

        // /*13*/
        // //Given
        // int n = 35;
        // int v = 1;
        // int p = 2;
        // //output n = 3;

        // if (v == 0)
        // {
        //     n = n & (~(1 << p));
        // }
        // else
        // {
        //     n = n | (1 << p);
        // }
        // Console.Write(n);

        // /*14*/
        // int n;
        // bool isPrime = false;

        // Console.Write("Enter a number that is greater than 1 and less than 100 : ");
        //  n = int.Parse(Console.ReadLine());

        // while (n <= 1 | n >= 100)
        // {
        //     Console.WriteLine("You entered an incorrect number");
        //     n = int.Parse(Console.ReadLine());
        // }

        // Console.WriteLine("{0} is greater than 1 and less than 100", n);

        // for (int i = 2; i < Math.Sqrt(n); i++)
        // {
        //     if (n % i == 0)
        //     {
        //         isPrime = false;
        //         break;
        //     }
        //     else
        //     {
        //         isPrime = true;
        //     }
        // }
        // Console.WriteLine(isPrime);
        
    }
}