using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //use switch to make a customer service routing program
            promptUser:
            Console.WriteLine("---Customer support menu---");
            Console.WriteLine("Enter 1 to place an order");
            Console.WriteLine("Enter 2 for sales");
            Console.WriteLine("Enter 3 for marketing");
            Console.WriteLine("Enter 4 for tech support");
            //declare a variable to store user input
            int userInput;
            try
            {
                userInput = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You did not enter a whole number");
                goto promptUser;
            }
            //now we can create our switch
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Here you can place an order");
                    break;
                case 2:
                    Console.WriteLine("Welcome to the sales department");
                    break;
            }
            Console.ReadLine();
        }
    }
}
