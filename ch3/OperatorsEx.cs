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
    }
}