//Cirella Smith
//October 9, 2022
//Lab 3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Number 1--");

            //create numeric variable for 100 in the correct data type
            sbyte wholeNum = 100;
            //output the value and data type using string interpolation
            Console.WriteLine($"The number is {wholeNum} and the data type is {wholeNum.GetType()}");

            //$10.45- create a numeric variable in the correct data type
            decimal moneyNum = 10.45m;
            //output the value and the data type using string interpolation
            Console.WriteLine($"The amount is ${moneyNum} and the data type is {moneyNum.GetType()}");

            //2.7182818284590- create a numeric variable in the correct data type
            //chose to use decimal rather than double as double cut off the last 0 in the number
            decimal dNum = 2.7182818284590m;
            //output the value and the data type using string interpolation
            Console.WriteLine($"The number is {dNum} and the data type is {dNum.GetType()}");

            //-28 trillion-- create a numeric variable in the correct data type
            //-28 trillion is too long for int, so used long instead
            //don't use commas or it won't work :)
            long trilNum = -28000000000000;
            //output the value and the data type using string interpolation
            Console.WriteLine($"The number is {trilNum} and the data type is {trilNum.GetType()}");

            //9.784- create a numeric variable in the correct data type
            float fNum = 9.784f;
            //output the balue and the data type using string interpolation
            Console.WriteLine($"The number is {fNum} and the data type is {fNum.GetType()}");



            Console.WriteLine("--Number 2--");
            //prompt the user to input a number
            Console.WriteLine("Please enter a number");
            //create a string and set it equal to user input
            string input1 = Console.ReadLine();
             //try block for int
            try
            {
                //int conversion
                int number1 = Convert.ToInt32(input1);
                //output if conversion is a success
                Console.WriteLine($"Conversion to {number1.GetType()} is successful");
            }
            catch
            {
                Console.WriteLine("Failed to convert to int");
            }
            //try block for double
            try
            {
                //double conversion
                double number1 = Convert.ToDouble(input1);
                //output if conversion is a success
                Console.WriteLine($"Conversion to {number1.GetType()} is successful");
            }
            catch
            {
                Console.WriteLine("Failed to convert to double");
            }
            //try block for float/ single
            try
            {
                //float conversion
                float number1 = Convert.ToSingle(input1);
                //output if conversion is a success
                Console.WriteLine($"Conversion to {number1.GetType()} is successful");
            }
            catch
            {
                Console.WriteLine("Failed to convert to float");
            }



            Console.WriteLine("--Number 3--");
            //prompt the user for price of gas using decimal
            Console.WriteLine("Enter the price of gas");
            //create a string for the user input
            string gas = Console.ReadLine();
            //Parse from string to decimal
            decimal gasPrice = decimal.Parse(gas);
            //prompt the user for miles per gallon of the car using int
            Console.WriteLine("Enter the miles per gallon of the car using a whole number");
            //create a string for the user input
            string mpg = Console.ReadLine();
            //declare the variable as an int and set to zero
            int mpgInt = 0;
            //try block for user input to ensure int used and update the value in the int with user's input
            try
            {
                //int conversion
                mpgInt = Convert.ToInt32(mpg);
            }
            catch
            {
                Console.WriteLine("You entered an incorrect value");
            }
            //prompt the user to enter number of miles driven using int
            Console.WriteLine("Enter the number of miles driven using a whole number");
            //create a string for the user input
            string miles = Console.ReadLine();
            //Parse from string to int
            int milesDriven = int.Parse(miles);
            //calculate the total trip cost
            decimal tripTotal = (milesDriven / mpgInt) * gasPrice;
            Console.WriteLine($"The total cost of the trip is ${tripTotal}");


            Console.WriteLine("--Number 4--");
            //prompt the user to input an amount between 0 and 99
            Console.WriteLine("Enter a number of pennies between 0 and 99");
            //create a string for the user input
            string pennies = Console.ReadLine();
            //convert user input to numeric value
            int pennyValue = 0;
            try
            {
                pennyValue = Convert.ToInt32(pennies);
            }
            catch
            {
                Console.WriteLine("You entered an incorrect value");
            }
            //find the number of quarters in pennyValue
            int quarter = pennyValue / 25;
            //find the number of dimes in pennyValue
            //first determine remaining amount after quarters are extracted by using modulus
            int dime = pennyValue % 25;
            //then determine dime total by dividing that by 10
            int dime2 = dime / 10;
            //determine remaining amount after quarters and dimes are extracted by using modulus
            int nickle = dime % 10;
            //then determine nickle total by dividing that by 5
            int nickle2 = nickle / 5;
            //determine remaining amount after quarters, dimes and nickles are extracted by using modulus
            int penny = nickle % 5;
            //then determine penny total by dividing that by 1
            int penny2 = penny / 1;
            //output the numbers of quarters, dimes, nickles, and pennies
            Console.WriteLine($"That is {quarter} quarters, {dime2} dimes, {nickle2} nickles, {penny2} pennies");


            Console.WriteLine("--Number 5--");
            //create an int variable and assign it the value of 11
            int compound = 11;
            //subtract 1 from the variable using compound operators
            compound--; //10
            //divide the variable by 2
            compound /= 2; //5
            //add 1 to the variable
            compound++; //6
            //multiply the variable by 5
            compound *= 5; //30
            Console.WriteLine($"The compound is {compound}");

            Console.ReadLine();

        }
    }
}
