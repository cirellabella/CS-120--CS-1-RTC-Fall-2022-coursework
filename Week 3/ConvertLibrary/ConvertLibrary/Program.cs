using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The convert library is an alternative to parsing
            //Prompt the user
            Console.WriteLine("Please enter a number");
            //capture the user input and store in a string
            string inputNum = Console.ReadLine();
            //Here is where we convert
            int number = Convert.ToInt32(inputNum);
            Console.WriteLine($"The number is {number} and data type is {number.GetType()}");

            Console.WriteLine("Please enter a decimal number");
            string input2 = Console.ReadLine();
            double number2;
            try
            {
                number2 = Convert.ToDouble(input2);
                Console.WriteLine($"The number is {number2} and data type is {number2.GetType()}");
            }
            catch
            {
                Console.WriteLine("You did not enter a number");
            }
            

            Console.ReadLine();
        }
    }
}
