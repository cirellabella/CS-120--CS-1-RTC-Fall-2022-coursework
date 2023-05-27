//Cirella Smith
//October 9, 2022
//Lab 3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Number 1--");

            //create numeric variable for 100 in the correct data type
            sbyte wholeNum = 100;
            //output the value and data type using string interpolation
            Console.WriteLine($"The number is {wholeNum} and the data type is {wholeNum.GetType()}");

            //$10.45- create a numeric variable in the correct data type
            decimal moneyNum = 10.45m;
            //output the value and the data type using string interpolation
            Console.WriteLine($"The amount is ${moneyNum} and the data type is {moneyNum.GetType()}");

            //2.7182818284590- create a numeric variable in the correct data type
            //chose to use decimal rather than double as double cut off the last 0 in the number
            decimal dNum = 2.7182818284590m;
            //output the value and the data type using string interpolation
            Console.WriteLine($"The number is {dNum} and the data type is {dNum.GetType()}");

            //-28 trillion-- create a numeric variable in the correct data type
            //-28 trillion is too long for int, so used long instead
            //don't use commas or it won't work :)
            long trilNum = -28000000000000;
            //output the value and the data type using string interpolation
            Console.WriteLine($"The number is {trilNum} and the data type is {trilNum.GetType()}");

            //9.784- create a numeric variable in the correct data type
            float fNum = 9.784f;
            //output the balue and the data type using string interpolation
            Console.WriteLine($"The number is {fNum} and the data type is {fNum.GetType()}");



            Console.WriteLine("--Number 2--");
            //prompt the user to input a number
            Console.WriteLine("Please enter a number");
            //create a string and set it equal to user input
            string input1 = Console.ReadLine();
            //declare the int variable
            int number1;
            //try block
            try
            {
                number1 = Convert.ToInt32(input1);
                //output if conversion is a success
                Console.WriteLine($"Conversion to int successful {number1.GetType()}");
            }
            catch
            {
                Console.WriteLine($"Conversion to {number1.GetType()} failed")
            }


            Console.ReadLine();

        }
    }
}
