using System;

class ConsoleEx
{
    static void Main()
    {

        /*1.*/
        // int sum = 0;
        // int num = 0;
        // for (int i = 0; i < 3; i++)
        // {
        //     Console.WriteLine("Enter a number");
        //     num = int.Parse(Console.ReadLine());
        //     sum += num;
        // }
        // Console.WriteLine("Sum is {0}", sum);

        /*2.*/
        // Console.Write("Enter radius: ");
        // float r = float.Parse(Console.ReadLine());
        // float perimeter = 3.142f * (r * 2);
        // float area = 3.142f * (r * r);

        // Console.WriteLine("Perimeter is {0} and Area is {1}", perimeter, area);

        /*3.*/
        // Console.Write("Company Name: ");
        // string companyName = Console.ReadLine();
        // Console.Write("Company address: ");
        // string companyAddress = Console.ReadLine();
        // Console.Write("Company Phone number: ");
        // string phoneNumber = Console.ReadLine();
        // Console.Write("Fax Number: ");
        // string faxNumber = Console.ReadLine();
        // Console.Write("Website: ");
        // string website = Console.ReadLine();
        // Console.Write("Manager Name: ");
        // string managerName = Console.ReadLine();
        // Console.Write("Manager surname: ");
        // string managerSurname = Console.ReadLine();
        // Console.Write("Manager Phone Number: ");
        // string managerPhonenumber = Console.ReadLine();

        // Console.WriteLine("Company Name is {0}\nCompanyAddress is {1}\n" +
        //         "Company Phone number is {2}\nFax Number is {3}\n",
        //         companyName, companyAddress, phoneNumber, faxNumber);

        /*4*/
        // int a = 2021;
        // float b = 3.142f;
        // float c = -3.142f;

        // //column width 10
        // Console.Write("{0,0:X}", a); //hexadecimal
        // Console.Write("{0,10:F2}", b);
        // Console.Write("{0,10:F2}", c);

        /*5*/
        // int a = int.Parse(Console.ReadLine());
        // int b = int.Parse(Console.ReadLine());

        // for (int i = a; i <= b; i++)
        // {
        //     if (i % 5 == 0)
        //     {
        //         Console.WriteLine(i);
        //     }
        // }

        /*6*/
        // int a = int.Parse(Console.ReadLine());
        // int b = int.Parse(Console.ReadLine());

        // // Console.WriteLine(Math.Max(a, b)); //Soln 1
        // // Console.Write(((a + b) + Math.Abs(a - b)) / 2); //Soln 2
        // int max = a - ((a - b) & ((a - b) >> 31));
        // Console.WriteLine(max);
        // Console.Write(((a - b) >> 31)); //Soln3

        /*7*/
        // Console.WriteLine("Enter 5 integers :");
        // int sum = 0;
        // int num = 0;
        // for (int i = 0; i < 5; i++)
        // {
        //     String str = Console.ReadLine();
        //     bool parseSuccess = int.TryParse(str, out num);
        //     while (!parseSuccess)
        //     {
        //         Console.WriteLine("Enter valid number");
        //         str = Console.ReadLine();
        //         parseSuccess = int.TryParse(str, out num);
        //     }
        //     sum += num;
        // }
        // Console.WriteLine("Sum is {0}", sum);

        /*8*/

        // int number = 0;
        // int max = 0;

        // for (int i = 0; i < 5; i++)
        // {
        //     Console.Write("Enter a number: ");
        //     int num = int.Parse(Console.ReadLine());
        //     if(num > number & num > max)
        //     {
        //         max = num;
        //     }
        //     number = num;

        // }
        // Console.WriteLine("Largest Number is {0}", max);

        /*9*/

        // int a = 0;
        // int sum = 0;

        // Console.WriteLine("Enter an Integer: ");
        // String str = Console.ReadLine();
        // bool parseSuccess = int.TryParse(str, out a);

        // while(!parseSuccess)
        // {
        //     Console.WriteLine("Enter a valid Integer: ");
        //     str = Console.ReadLine();
        //     parseSuccess = int.TryParse(str, out a);
        // }

        // for (int i = 0; i < 5; i++)
        // {
        //     Console.Write("Enter a number: ");
        //     int num = 0;
        //     String strRead = Console.ReadLine();
        //     bool success = int.TryParse(strRead, out num);

        //     while(!success)
        //     {
        //         Console.WriteLine("Enter a valid Integer: ");
        //         strRead = Console.ReadLine();
        //         success = int.TryParse(strRead, out num);
        //     }

        //     sum += num;
        // }
        // Console.WriteLine("The sum is {0}", sum);
    }
}