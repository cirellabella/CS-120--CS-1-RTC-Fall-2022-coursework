using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try parse with while loop
            //the longer but easier to understand way
            //prompt the user
            Console.WriteLine("Please enter a number");
            //capture the input store it in a string
            string input = Console.ReadLine();
            int number;
            //now we parse the number
            bool parseSuccess = int.TryParse(input, out number);
            //now i want to repeat the process if parse failed
            while (!parseSuccess)//can also use parseSuccess == false
            {
                //if this runs, parse failed
                Console.WriteLine("Incorrect input. Please enter a whole number.");
                //repeat the process
                input = Console.ReadLine();
                parseSuccess = int.TryParse(input, out number);
            }
            //if we get down here we know number is an int and
            //they followed instructions
            Console.WriteLine($"Parse success: {number}");
            //Lets write that the short way
            Console.WriteLine("Please enter a number");
            int number2;
            //go straight to the while loop
            while(!int.TryParse(Console.ReadLine(), out number2))
            {
                //I know here that the parse failed
                Console.WriteLine("Invalid input. You did not enter a whole number.");
            }
            //Here we know the parse succeeded
            Console.WriteLine($"Parse success: {number2}");
            
            Console.ReadLine();
        }
    }
}
