//Cirella Smith
//October 16, 2022
//Lab 4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Number 1--");
            //prompt the user to input two numbers and add label
            prompt:
            Console.WriteLine("Enter two integer numbers");
            //declare variables           
            int num1;
            int num2;
            //try to ensure the numbers are integers 
            try
            {
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                //if the input was not integer numbers, output this and send the user back using goto
                Console.WriteLine("Incorrect input. Make sure you are entering two whole numbers");
                goto prompt;
            }
            if (num1 > num2)
            {
                //we know here logically that num1 is greater than num2
                Console.WriteLine($"{num1} is greater than {num2}");
            }
            else if (num1 < num2)
            {
                //we know logically that num1 is less than num2 here
                Console.WriteLine($"{num1} is less than {num2}");
            }
            else
            {
                //we know logically that num1 and num2 must be equal here
                Console.WriteLine($"{num1} is equal to {num2}");
            }

            Console.WriteLine("--Number 2--");
            //prompt user to enter an integer number and leave a label to return
            prompt2:
            Console.WriteLine("Enter an integer number");
            //declare variable
            int number;
            //try block to ensure input is integer
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                //user has not entered an integer, let them know and return them to the beginning
                Console.WriteLine("Incorrect input, make sure you are entering a whole number");
                goto prompt2;
            }
            if(number % 2 == 0)
            {
                //we know that this is an even number
                Console.WriteLine($"{number} is even");
            }
            else
            {
                //know that logically if it's not even, it's odd, so we don't need an else if statement, just else
                Console.WriteLine($"{number} is not even");
            }

            Console.WriteLine("--Number 3--");
            //prompt user to enter an integer number and leave a label to return
            prompt3:
            Console.WriteLine("Enter an integer number");
            int number2;
            //try block to ensure input is integer
            try
            {
                number2 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                //user didn't enter an integer, let them know and return to the prompt at home
                Console.WriteLine("Incorrect input, make sure you are entering a whole number");
                goto prompt3;
            }
            if(number2 > 0)
            {
                //logically this will be a positive number
                Console.WriteLine($"{number2} is positive");
            }
            else if(number2 < 0)
            {
                //logically this will be a negative number
                Console.WriteLine($"{number2} is negative");
            }
            else
            {
                //logically this would only be zero
                Console.WriteLine($"{number2} is not positive or negative");
            }

            Console.WriteLine("--Number 4--");            
            //prompt user to enter an integer number and enter a label to return
            prompt4:
            Console.WriteLine("Enter your age");
            int age;
            //try block to ensure input is integer
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                //user input is incorrect, output to them and return to start
                Console.WriteLine("Incorrect input, make sure you are entering a whole number");
                goto prompt4;
            }
            if(age >= 18)
            {
                //user is old enough to vote
                Console.WriteLine("Congratulations! You are eligible for casting your vote.");
            }
            else
            {
                //user is less than 18 and unable to vote
                Console.WriteLine("You are not eligible to vote.");
            }

            Console.WriteLine("--Number 5--");
            //prompt the user to enter scores and return here if incorrect input
            prompt5:
            Console.WriteLine("Enter a math score, science score, and a language score (0-100)");
            //capture the scores in variables
            int mathScore;
            int scienceScore;
            int languageScore;
            try
            {
                mathScore = Convert.ToInt32(Console.ReadLine());
                scienceScore = Convert.ToInt32(Console.ReadLine());
                languageScore = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Incorrect input. Please try again.");
                goto prompt5;
            }

            //compare scores to see if they qualify for a scholarship average greater than or equal to 80
            if ((mathScore + scienceScore + languageScore) / 3 >= 80 || languageScore >= 90 && scienceScore >= 90 || mathScore == 95 || scienceScore == 95)
            {
                Console.WriteLine("These scores qualify for a scholarship");
            }
            else
            {
                Console.WriteLine("These scores do not qualify for a scholarship");
            }

            Console.WriteLine("--Number 6--");
            //prompt the user for input and leave a label to return
            prompt6:
            Console.WriteLine("Enter three different integer numbers for x, y, and z");
            //capture the input in variables
            int x;
            int y;
            int z;
            //try statement to verify input is integers
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                z = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                //user input wrong data type
                Console.WriteLine("Incorrect input. Please try again.");
                goto prompt6;
            }
            if(x > y && x > z)
            {
                //logically we know x will be the greatest
                Console.WriteLine($"{x} is the greatest");
            }
            else if(y > x && y > z)
            {
                //logically we know y will be the greatest at this point in code block
                Console.WriteLine($"{y} is the greatest");
            }
            else
            {
                //logically here we know z must be the greatest at this point in code
                Console.WriteLine($"{z} is the greatest");
            }

            Console.WriteLine("--Number 7--");
            //prompt the user to input how much is purchased
            prompt7:
            Console.WriteLine("Enter the dollar amount purchased");
            //declare variable
            decimal purchased;
            //try statement to convert to decimal (money)
            try
            {
                purchased = Convert.ToDecimal(Console.ReadLine());
            }
            catch
            {
                //we know the conversion did not work, go back to prompt
                Console.WriteLine("Incorrect input. Please try again.");
                goto prompt7;
            }
            decimal shipping;
            if(purchased > 5000)
            {
                //the decimal number is between 0 and 250, so should be charged $5 for shipping
                shipping = 20;
            }
            else if(purchased > 1000)
            {
                //the decimal number is between 250 and 500, so should be charged $8 for shipping
                shipping = 15;
            }
            else if(purchased > 500)
            {
                //the decimal number is between 500 and 1000, so should be charged $10 for shipping
                shipping = 10;
            }
            else if(purchased > 250)
            {
                //the decimal number is between 1000 and 5000, so should be charged $15 for shipping
                shipping = 8;
            }
            else if(purchased > 0)
            {
                shipping = 5;
            }
            else
            {
                //the decimal number is negative. prompt user to return to input a positive number to determine shipping
                Console.WriteLine("Invalid purchase amount.");
                goto prompt7;
            }
            Console.WriteLine($"Shipping charges are ${shipping}");

            Console.ReadLine();
        }
    }
}
