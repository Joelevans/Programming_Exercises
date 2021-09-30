using System;

namespace ExerciseOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program that prints your first and last name
            /*
                Console.Write("Evans");
                Console.Write("Joel");
            */
            //----------------------------------------------------------------------------------



            //Program that prints the following numbers on the console 
            //1, 101, 1001 each on a new line.
            /*
                Console.WriteLine(1);
                Console.WriteLine(101);
                Console.WriteLine(1001);
            */
            //----------------------------------------------------------------------------------



            //Program that prints current date and time
            /*
                Console.WriteLine(DateTime.Now);
            */
            //----------------------------------------------------------------------------------



            //Program that prints the square root of 12345
            /*
                Console.WriteLine(Math.Sqrt(12345));
            */
            //----------------------------------------------------------------------------------



            //Program that prints the first 100 members of the squence 2, -3, 4, -5, 6, -7, 8

            for (int i = 2; i < 51; i = i + 2)
            {

                Console.WriteLine(i);
                var neg = -1 - i;
                Console.WriteLine(neg);

            }

            //----------------------------------------------------------------------------------



            //Program that reads your age from the console and prints your age after 10 years
            /*
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            int newAge = age + 10;
            Console.WriteLine("In 10 years time, you will be" + " " + newAge +" " + "years old !");
            */
            //----------------------------------------------------------------------------------


            /*---------------------------END--------------------------------------*/

        }
    }
}
