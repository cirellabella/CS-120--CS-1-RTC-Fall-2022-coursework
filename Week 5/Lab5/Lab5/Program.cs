//Cirella Smith
//Lab 5
//October 23, 2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Number 1---");
            //declare variables
            float a = 3.2f;
            int b = 500000000;
            decimal c = 22.31m;
            long d = -9452675543234;
            double e = 2.42425252423;
            //output the variables to the console
            Console.WriteLine($"The float is {a}, the integer is {b}, the decimal is {c}, the long is {d} and the double is {e}");

            Console.WriteLine("---Number 2---");
            //declare two variables and assign a number to them
            int num1 = 34;
            int num2 = 43;
            //create bool variable for each of the bool expressions-1: num1 < 25 return false
            bool lessThan25 = num1 < 25;
            Console.WriteLine($"{num1} is less than 25: " + lessThan25);
            //bool variable 2: num2 is not 15 and is odd
            bool not15AndOdd = num2 != 15 && num2 % 2 == 1;
            Console.WriteLine($"{num2} is not 15 and is odd: " + not15AndOdd);
            //bool 3: num2 is not even and is positive
            bool notEvenAndPositive = num2 % 2 == 1 && num2 >= 0;
            Console.WriteLine($"{num2} is not even and is positive: " + notEvenAndPositive);
            //bool 4: num1 is between 25 and 35
            bool between25and35 = num1 < 35 && num1 > 25;
            Console.WriteLine($"{num1} is between 25 and 35: " + between25and35);
            //bool 5: num2 is greater than num1 and num2 does not equal 10 and also does not equal -2
            bool equal = num2 > num1 && num2 != 10 && num2 != -2;
            Console.WriteLine($"{num2} is greater than {num1} and {num2} does not equal 10 and does not equal -2: " + equal);


            Console.WriteLine("---Number 3---");
            //request an integer from the user
            prompt3:
            Console.WriteLine("Please enter a whole number");
            int divisible;
            //try to ensure that user put in whole numbers
            try
            {
                divisible = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You did not enter an integer.");
                goto prompt3;
            }
            //if statement to ensure that the number is evenly divisible y 5 with no remainder- use modulus
            if(divisible % 5 == 0)
            {
                Console.WriteLine($"{divisible} divides evenly by 5.");
            }
            else
            {
                Console.WriteLine($"{divisible} does not divide evenly by 5.");
            }

            Console.WriteLine("---Number 4---");
            //request quantity and price of an item from a user
            prompt4:
            Console.WriteLine("Please enter the quantity and price of the item");
            //declare variables
            decimal quantity;
            decimal price;
            //try to ensure user input is numbers and convert it to integer and decimal
            try
            {
                quantity = Convert.ToInt32(Console.ReadLine());
                price = Convert.ToDecimal(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter number values.");
                goto prompt4;
            }
            //equation to calculate subtotal by multiplying user given quantity and price
            decimal subtotal = quantity * price;
            //create variable for tax constant
            decimal tax = 0.10m; 
            //variable for tax constant multiplied by subtotal to come up with taxTotal
            decimal taxTotal =  subtotal * tax;
            //Total equation by adding taxTotal and subtotal
            decimal total = subtotal + taxTotal;
            //output the subtotal, tax due, and total using currency formatter
            Console.WriteLine($"Subtotal: {subtotal:c2}, Tax: {taxTotal:c2}, Total: {total:c2}");

            Console.WriteLine("---Number 5---");
            //request two integer values from the user
            prompt5:
            Console.WriteLine("Please enter two whole numbers");
            //create variables for the user input
            int number1;
            int number2;
            //try to ensure input is able to be converted to integer
            try
            {
                number1 = Convert.ToInt32(Console.ReadLine());
                number2 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Incorrect input. Try again.");
                goto prompt5;
            }
            if(number1 >= 0 && number2 >= 0)
            {
                Console.WriteLine($"{number1} and {number2} are both positive");
            }
            else if(number1 < 0 && number2 >= 0 || number2 < 0 && number1 >= 0)
            {
                int add = number1 + number2;
                Console.WriteLine($"{add}");
            }
            else
            {
                int multiply = number1 * number2;
                Console.WriteLine($"{multiply}");
            }

            Console.WriteLine("---Number 6---");
            //use switch to allow a customer to make a selection at the ATM
            prompt6:
            Console.WriteLine("===ATM Menu Selection===");
            Console.WriteLine("Please make a selection");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Make a deposit");
            Console.WriteLine("3. Make a withdrawal");
            Console.WriteLine("4. Apply for a credit card");
            //declare a variable to store user input
            int userInput;
            //try to ensure user input is 
            try
            {
                userInput = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You did not enter a whole number");
                goto prompt6;
            }
            //create the switch and output what the user has selected
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("You selected check balance");
                    break;
                case 2:
                    Console.WriteLine("You selected make a deposit");
                    break;
                case 3:
                    Console.WriteLine("You selected make a withdrawal");
                    break;
                case 4:
                    Console.WriteLine("You selected apply for a credit card");
                    break;
            }

            Console.WriteLine("---Number 7---");
            //prompt user to input the radius of the circle
            prompt7:
            Console.WriteLine("Enter the radius of a circle");
            double radius;
            //try to ensure that the user input can be converted
            try
            {
                radius = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Incorrect input. Try again.");
                goto prompt7;
            }
            //equation for the area: pi * r squared using in-built math
            double area = Math.PI * Math.Pow(radius, 2);
            //output the area to the 3rd decimal place
            Console.WriteLine($"The area of the circle is {area:f3}");


            Console.ReadLine();
        }
    }
}
