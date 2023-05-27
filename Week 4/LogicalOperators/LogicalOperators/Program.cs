using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get input from the user
            Console.WriteLine("Please input a number between 0 and 100");
            //create a variable and capture what they typed in
            int number = Convert.ToInt32(Console.ReadLine());
            //how can i check if the number is between 0 and 100
            if(number >= 0 && number <= 100)
            {
                //we know logically inside of this code block
                //number is greater than 0 and less than 100
                Console.WriteLine($"{number} is between 0 and 100");
            }
            else if(number < 0)
            {
                //I know that number is less than 0
                Console.WriteLine($"{number} is less than 0");
            }
            else
            {
                //What do i know logically here?
                //number has to be greater than 100
                Console.WriteLine($"{number} is greater than 100");
            }

            Console.ReadLine();
        }
    }
}
