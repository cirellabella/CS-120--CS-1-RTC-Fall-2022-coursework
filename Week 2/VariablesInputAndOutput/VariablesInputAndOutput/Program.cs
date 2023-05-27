//Cirella Smith
//October 2, 2022
//Lab 2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesInputAndOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Number 1--");
            //Prompt the user
            Console.WriteLine("Enter your first name");
            //Get input from user and store in a variable
            string firstName = Console.ReadLine();
            //Prompt user for last name
            Console.WriteLine("Enter your last name");
            //Get input from user and store in a variable
            string lastName = Console.ReadLine();
            //Print out the full name with a space in between first and last names
            Console.WriteLine(firstName + " " + lastName);

            Console.WriteLine("--Number 2--");
            //prompt the user to input three doubles
            Console.WriteLine("Enter 3 double numbers");
            //Get user input and store in string variables
            string numString1 = Console.ReadLine();
            string numString2 = Console.ReadLine();
            string numString3 = Console.ReadLine();
            //Parse from string to double
            double num1 = double.Parse(numString1);
            double num2 = double.Parse(numString2);
            double num3 = double.Parse(numString3);
            //Calculate the average of the 3 doubles
            //Average = total/ 3
            double average = (num1 + num2 + num3) / 3;
            //Output the result
            Console.WriteLine("The average is " + average);

            Console.WriteLine("--Number 3--");
            //prompt the user to input the length
            Console.WriteLine("Enter the length");
            //Get user input and put it in a string
            string lenString = Console.ReadLine();
            //Parse from string to double
            double len = double.Parse(lenString);
            //prompt the user to input the width
            Console.WriteLine("Enter the width");
            //Get user input and put in a string
            string widString = Console.ReadLine();
            //Parse from string to double
            double wid = double.Parse(widString);
            //Calculate area by multiplying length and width
            double area = len * wid;
            //Output the result
            Console.WriteLine("The length is " + len + ". " + "The width is " + wid + ". " + "The area is " + area + ".");

            Console.WriteLine("--Number 4--");
            //prompt the user to input the hours, minutes, and seconds
            Console.WriteLine("Enter the hours in whole numbers");
            string hoursString = Console.ReadLine();
            //Parse from string to int
            int hours = int.Parse(hoursString);
            //prompt the user to input the minutes
            Console.WriteLine("Enter the minutes in whole numbers");
            //Get user input and put in a string
            string minString = Console.ReadLine();
            //Parse from string to int
            int min = int.Parse(minString);
            //prompt the user to input the seconds
            Console.WriteLine("Enter the seconds in whole numbers");
            //Get user input and put in a string
            string secString = Console.ReadLine();
            //Parse from string to int
            int sec = int.Parse(secString);
            //Calculate the total seconds by multiplying hours times 60 to get to minutes
            //then 60 again to get to seconds total. Then add the value of minutes times 60
            //to get to seconds. Finally add the value of the inital seconds given by user and parsed by code.
            int secTotal = (hours * 60 * 60) + (min * 60) + sec;
            //Output the result
            Console.WriteLine("The total time in seconds is " + secTotal);

            Console.WriteLine("--Number 5--");
            //prompt the user to input the price of the item
            Console.WriteLine("Enter the price of the item");
            string priceString = Console.ReadLine();
            //Parse from string to double
            double price = double.Parse(priceString);
            //prompt the user to input the quantity
            Console.WriteLine("Enter the quantity purchased");
            //Get user input and put in a string
            string quantityString = Console.ReadLine();
            //Parse from string to double
            double quantity = double.Parse(quantityString);
            //Calculate the total cost of the items by multiplying price of one item by total quantity purchased
            double total = price * quantity;
            //Output the result
            Console.WriteLine("The total is: " + total);


            Console.ReadLine();

        }
    }
}
