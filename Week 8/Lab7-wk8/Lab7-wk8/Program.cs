//Cirella Smith
//Lab 7
//November 13, 2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_wk8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Number 1---");
            //create for loop starting at 1 and less than 25
            for (int i = 1; i < 25; i++)
            {
                //if the number is evenly divisible by 3 or 7, skip it and don't write to the console
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                //write the numbers to the console
                Console.Write(i + " ");
            }

            Console.WriteLine("\t");

            Console.WriteLine("---Number 2---");
            //if their entry matches the string "SecretPassword" exit the loop and tell the user the
            //password was correct
            //create an infinite loop prompting user to enter a password
            Console.WriteLine("Enter a password");
            //create variable for the secret password
            string SecretPassword = "SecretPassword";
            //create infinite loop when use input is not the secret password, prompt user to input a password
            while (Console.ReadLine() != SecretPassword)
            {
                //user input is incorrect, re-prompt to enter password
                Console.WriteLine("Enter a password");                
            }
            //exited loop-- correct password entered. Success!
            Console.WriteLine("Correct password. Access Granted.");


            Console.WriteLine("---Number 3---");
            //request an integer number from the user
            Console.WriteLine("Enter an integer number");
            //using tryParse and a while loop verify user input an integer number
            //then print out all positive integer numbers less than the input number
            string input3 = Console.ReadLine();
            int number3;
            //parse the number
            bool parseSuccess = int.TryParse(input3, out number3);
            //repeat the process if parse fails
            while (!parseSuccess)
            {
                //parse failed
                Console.WriteLine("Incorrect input, please enter an integer number");
                //repeat the parse process
                input3 = Console.ReadLine();
                parseSuccess = int.TryParse(input3, out number3);
            }
            //parse success
            for (int i = 1; i < number3; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---Number 4---");
            //request two integer numbers from the user
            Console.WriteLine("Enter two integer numbers, the first must be smaller than the second number");
            //create variable to parse the user input to
            int firstNum;
            int secondNum;
            //go to while loop and parse
            while (!int.TryParse(Console.ReadLine(), out firstNum) || !int.TryParse(Console.ReadLine(), out secondNum))
            {
                //parse failed
                Console.WriteLine("Incorrect input, Enter two integer numbers, the first must be smaller than the second number");
            }
            //the parse succeeded
            //will use this variable to keep track of all the even numbers
            int total = 0;
            for(int i = firstNum; i < secondNum; i++)
            {
                //if firstNum is even, add to total
                if(i % 2 == 0)
                {
                    total += i;
                }
                else
                {
                    //i is odd since the if failed
                    Console.WriteLine(i);
                }
            }
            //output the total
            Console.WriteLine($"The total of even numbers is {total}");


            Console.WriteLine("---Number 5---");
            //request two integers from the user
            Console.WriteLine("Enter two integer numbers, one for rows and one for columns");
            //create variables to parse user input to
            int rows;
            int columns;
            //while loop and parse
            while(!int.TryParse(Console.ReadLine(), out rows) || !int.TryParse(Console.ReadLine(),out columns))
            {
                //parse failed
                Console.WriteLine("Incorrect input, Enter two integer numbers, one for rows and one for columns");
            }
            //parse success
            //nested loop to print stars to console to reflect the number of rows and columns user input
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("---Number 6---");
            //request integer input from user
            Console.WriteLine("Enter an integer number for the number of rows");
            //create variable for user input number
            int rows6;
            //while loop and parse
            while(!int.TryParse(Console.ReadLine(), out rows6))
            {
                //parse failed
                Console.WriteLine("Incorrect input. Enter a number for the number of rows");
            }
            for(int i = 0; i < rows6; i++)
            {
                for(int j = rows6; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            


            


            

            Console.ReadLine();
        }
    }
}
