using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomExtraLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (number == 0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                Console.WriteLine("Another number");
            }
            //find the last digit of the number
            int lastDigit = number % 10;
            //if statements to determine the number 
            //use mod again to find if positive or negative, then determine the number
            //and output the results 

            number /= 10;
            int middleDigit = number % 10;
            //if statements to determine the number
            number /= 10;
            int firstDigit = number % 10;
            //if statements to determine the number and output the hundreds

            if (firstDigit == 1)
            {
                Console.WriteLine("One hundred ");
            }
            else if (firstDigit == 2)
            {
                Console.WriteLine("Two hundred ");
            }
            else if (firstDigit == 3)
            {
                Console.WriteLine("Three hundred ");
            }
            else if (firstDigit == 4)
            {
                Console.WriteLine("Four hundred ");
            }
            else if (firstDigit == 5)
            {
                Console.WriteLine("Five hundred ");
            }
            else if (firstDigit == 6)
            {
                Console.WriteLine("Six hundred ");
            }
            else if (firstDigit == 7)
            {
                Console.WriteLine("Seven hundred ");
            }
            else if (firstDigit == 8)
            {
                Console.WriteLine("Eight hundred ");
            }
            else if (firstDigit == 9)
            {
                Console.WriteLine("Nine hundred ");
            }
            else
            {
                if (middleDigit > 2)
                {

                }
                else if (middleDigit == 1)
                {
                    if (lastDigit == 1)
                    {
                        Console.WriteLine("and eleven");
                    }
                    else if (lastDigit == 2)
                    {
                        Console.WriteLine("and twelve");
                    }
                    else if (lastDigit == 3)
                    {
                        Console.WriteLine("and thirteen");
                    }
                    else if (lastDigit == 4)
                    {
                        Console.WriteLine("and fourteen");
                    }
                    else
                    {
                        Console.WriteLine("fifteen");
                    }
                }
            }
        }
    }
}
