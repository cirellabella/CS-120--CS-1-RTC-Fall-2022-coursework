//Cirella Smith
//Lab 6
//November 6, 2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.WriteLine("---Number 1---");
            //declare variable
            int counter = 0;
            //introduce the while loop and condition
            while(counter < 10)
                //output loop results
            {
                Console.WriteLine($"{counter}");
                counter++;
            }

            Console.WriteLine("---Number 2---");
            //compose for loop
            for(int i = 1; i < 10; i += 2)
                //output the results
            {
                Console.WriteLine($"{i}");
            }

            Console.WriteLine("---Number 3---");
            //get user input
            Console.WriteLine("Please enter a positive integer");            
            //declare variable and convert user input into integer inside of variable
            int number3 = Convert.ToInt32(Console.ReadLine());
            //declare variable for sum of the numbers less than the user's number
            int sum = 0;
            //for loop to determine the sum of the numbers below the user's number
            for(int total = 0; total < number3; total++)
            {
                sum += total;
            }
            //output the result to the console
            Console.WriteLine($"The total is {sum}");



            Console.WriteLine("---Number 4---");
            //get user input
            Console.WriteLine("Please enter a number to check if it's prime");
            //declare variable and parse user input into the variable
            long number4 = long.Parse(Console.ReadLine());
            //create a bool- assume the number is prime, then try to prove it's not
            bool isPrime = true;
            //check the number
            //2 is a special case (prime) so it needs to be handled first
            if(number4 == 2)
            {
                goto displayResult;
            }
            //if number is even, not prime so you can skip to results
            else if(number4 % 2 == 0)
            {
                isPrime = false;
                goto displayResult;
            }
            //check if it divides evenly by any odd number between 3 and the square root of the user input
            else
            {
                for(long i = 3; i <= Math.Sqrt(number4); i += 2)
                {
                    //check to see if it divides evenly
                    if(number4 % i == 0)
                    {
                        //it's not prime
                        isPrime = false;
                        goto displayResult;
                    }
                }
            }

            displayResult:
            if (isPrime)
            {
                Console.WriteLine($"{number4} is prime");
            }
            else
            {
                Console.WriteLine($"{number4} is not prime");
            }


            Console.WriteLine("---Number 5---");
            //declare variable
            int count = 1;
            //write loop to go 10 times
            while(count < 11)
            {
                //call for random number between 0 and 99 each time
                int num1 = rand.Next(0, 100);
                //write the number to the console
                Console.WriteLine($"{num1}");
                //add to the count to go through the loop again
                count++;
            }

            Console.WriteLine("---Number 6---");
            int numberOfGuesses = 0;
            //generate random number between 0 and 99
            int num6 = rand.Next(0, 100);
            //prompt user to guess the number
            prompt6:
            Console.WriteLine("Please guess what the random number is");
            //variable to house the user's guess
            int guess = int.Parse(Console.ReadLine());
            //the loop to see what happens depending on the guess
            while(guess != num6)
            {
                numberOfGuesses++;
                if (guess > num6)
                {
                    Console.WriteLine("Your guess was too high");
                    Console.WriteLine("Please try again");
                    goto prompt6;
                }
                else if(guess < num6)
                {
                    Console.WriteLine("Your guess was too low");
                    Console.WriteLine("Please try again");
                    goto prompt6;
                }
                else
                {
                    goto result6;
                }

            }
            
            result6:
            Console.WriteLine($"Correct guess. The number was {num6}");
            Console.WriteLine($"It took you {numberOfGuesses} guesses to get the correct number");



            Console.ReadLine(); 
        }
    }
}
