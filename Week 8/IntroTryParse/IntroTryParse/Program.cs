using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hardcode a few strings
            string intString = "100";
            string doubleString = "3.14";
            string textString = "Hello";
            string longString = "4938405873812";
            //These are the strings we are going to try to parse
            int num1;
            double num2;
            long num3;
            //These are the variables we will try to parse to

            //TryParse() returns a bool, true on success, false on fail
            bool conversion1 = int.TryParse(intString, out num1);
            //check if successful
            if (conversion1)
            {
                Console.WriteLine($"Parse Success: {num1}");
            }
            else
            {
                //what do i know here? i know try parse failed
                Console.WriteLine($"Parse Failed: {num1}");
            }
            bool conversion2 = double.TryParse(doubleString, out num2);
            //check to see if the conversion failed
            if (!conversion2)
            {
                //parse failed
                Console.WriteLine($"Parse failed: {num2}");
            }
            else
            {
                //tryParse success
                Console.WriteLine($"Parse success: {num2}");
            }
            //try parse user input
            Console.WriteLine("Please enter a large whole number");
            bool conversion3 = Int64.TryParse(Console.ReadLine(), out num3);
            //we either get true or false
            if (!conversion3)
            {
                //failed
                Console.WriteLine($"Parse failed: {num3}");
            }
            else
            {
                //success
                Console.WriteLine($"Parse success: {num3}");
            }

            Console.ReadLine();
        }
    }
}
