using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInputandOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prompt the user - give them instructions
            Console.WriteLine("Please enter your name");
            //capture the user input and store in a string variable
            string name = Console.ReadLine();
            //Print out the result using string concatenation
            Console.WriteLine("Your name is " + name);

            //Show what happens when you try to do math with strings
            //We give them instructions
            Console.WriteLine("Enter two numbers");
            //capture the user input and put in a string
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();
            //Output the result
            Console.WriteLine(number1 + number2);
            //We did not get math, instead we got concatenation
            //You cannot do math with strings

            //Keep the window open until we hit enter
            Console.ReadLine();
        }
    }
}
