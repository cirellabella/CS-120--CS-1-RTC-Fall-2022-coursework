using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandDataConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lets create some variables
            int a = 5;
            int b = 4;
            int c = 10;
            //lets make a variable to store the result
            double result;
            //lets add b and c
            result = b + c;
            Console.WriteLine("Result is " + result);
            //lets divide a and b
            result = a / b;
            Console.WriteLine("The result is " + result);
            //lets add a and b then mod by c
            result = a + b % c;
            Console.WriteLine("Result is " + result);
            result = c * b - c / a;
            Console.WriteLine("Result is " + result);

            Console.ReadLine();
        }
    }
}
