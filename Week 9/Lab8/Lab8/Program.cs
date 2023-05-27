//Cirella Smith
//Lab 8
//November 20, 2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Number 1- output to console
            Console.WriteLine("---Number 1---");
            //Call the second method for problem 1 and capture the result
            string message = StartLab8();
            //pass the string to the first method to display "Start Lab 8" to the console
            Display(message);

            //Number 2- output to console
            Console.WriteLine("---Number 2---");
            //Call the method for problem 2
            double totalAvg = Average(4, 7, 12);
            //Display the result
            Console.WriteLine($"The average is {totalAvg}");

            //Number 3- output to the console
            Console.WriteLine("---Number 3---");
            //call the method to main and display the result
            Problem3(4, 7, 9);

            //Number 4- output to the console
            Console.WriteLine("---Number 4---");
            //call the method and capture the result
            bool result4 = IsOddLessTen(7);
            //Display the result
            Console.WriteLine(result4);

            //Number 5-output to the console
            Console.WriteLine("---Number 5---");
            //Call the method and capture the result
            decimal result = Problem5(3.4m, 5.7m, 2.4m);
            //Display the result
            Console.WriteLine(result);

            //Number 6- output to the console
            Console.WriteLine("---Number 6---");
            //Using a for loop, call the method for all numbers from -100 to 100
            //if the number is positive, skip to the next iteration of the loop
            //if it is 0 or less, output the number to the console
            for(int i = 100; i > -101; i--)
            {
                bool result6 = IsPositive(i);
                if (result6)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            //Number 7- output to the console
            Console.WriteLine("---Number 7---");
            //Display a grid of stars to the console that has width columns and height rows
            Stars(8, 3);



            Console.ReadLine();


        }
        //first method for problem 1
        //create a method that takes a string as a parameter and displays the string to the console
        static void Display(string input)
        {
            Console.WriteLine(input);
        }
        //second method for problem 1
        //create a second method that returns a string "Start Lab 8"
        static string StartLab8()
        {
            return "Start Lab 8";
        }

        //method for problem 2
        //Create a method that takes 3 double numbers as parameters and returns the average of them
        static double Average(double num1, double num2, double num3)
        {
            double avg = (num1 + num2 + num3) / 3;
            return avg;
        }

        //method for problem 3
        //Create a method that takes 3 integer numbers as parameters and displays the numbers to the console
        static void Problem3(int numx, int numy, int numz)
        {
            Console.WriteLine($"The three integer numbers are: {numx}, {numy}, {numz}");
        }

        //method for problem 4
        //Create a method that takes 1 integer number as a parameter and returns true if the number is 1, 3, 5, 7, or 9
        //return false if the number is any other value
        static bool IsOddLessTen(int number1)
        {
            if(number1 < 10 && number1 > 0 && number1 % 2 == 1)
            {
                return true;
            }
            return false;
        }

        //method for problem 5
        //Create a method that takes 3 decimal numbers as parameters and returns the largest of them 
        static decimal Problem5(decimal num1, decimal num2, decimal num3)
        {
            if(num1 > num2 && num1 > num3)
            {
                return num1;
            }
            if(num2 > num1 && num2 > num3)
            {
                return num2;
            }
            return num3;
        }

        //method for problem 6
        //Create a method that takes one int as a parameter and returns
        //true if the number is positive and false if the number is 0 or less
        static bool IsPositive(int num1)
        {
            if(num1 > 0)
            {
                return true;
            }
            return false;
        }

        //method for problem 7
        //Create a method that takes two integers, width and height, as a parameter
        static void Stars(int width, int height)
        {
            //height for rows
            for (int i = 0; i < height; i++)
            {
                //width for columns
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


    }
}
