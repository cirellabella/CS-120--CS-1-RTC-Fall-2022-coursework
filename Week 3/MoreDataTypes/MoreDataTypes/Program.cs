using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Whole number data types
            //sbyte-- 8-bits -128 to 127
            sbyte smallNumber = 100;
            //lets output the value and data type using string interpolation
            Console.WriteLine($"The small number is {smallNumber} and the data type is {smallNumber.GetType()}");

            //Short is a 16-bit whole number data type
            //-32,000 to 32,000 2^16 different values
            short shortNumber = 1000;
            Console.WriteLine($"The short number is {shortNumber} and the data type is {shortNumber.GetType()}");

            //Long 64 bit whole number
            //2^64 different values
            //10 billion is too long for an int
            long longNumber = 10000000000;
            Console.WriteLine($"The long number is {longNumber} and the data type is {longNumber.GetType()}");

            //New Decimal number data types
            //float 7-8 significant digits
            //have to put f after the number
            float floatNumber = 2.72f;
            Console.WriteLine($"The float number is {floatNumber} and the data type is {floatNumber.GetType()}");

            //Decimal data type
            //Always use decimal for money
            //128 bit data type 27-28 significant digits
            decimal decimalNumber = 3.14972097386m;
            Console.WriteLine($"The decimal number is {decimalNumber} and the data type is {decimalNumber.GetType()}");


            Console.ReadLine();
        }
    }
}
