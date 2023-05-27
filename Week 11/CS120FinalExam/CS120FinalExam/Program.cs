//Cirella Smith
//CS 120
//Final Exam
//Dec 7, 2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS120FinalExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problem #1
            Console.WriteLine("---Number 1---");
            //declare a variable for 'Z'
            char letter = 'Z';
            Console.WriteLine($"{letter}");
            //declare a variable for 3.7
            float number1 = 3.7f;
            Console.WriteLine($"{number1}");
            //declare a variable for 2 < 5
            bool compare = 2 < 5;
            Console.WriteLine($"{compare}");
            //declare a variable for $12.25
            decimal money = 12.25m;
            Console.WriteLine($"{money:c2}");
            //declare a variable for 300,000
            int number2 = 300000;
            Console.WriteLine($"{number2:n0}");
            //declare a variable for -9,123,456,798,123
            long number3 = - 9123456798123;
            Console.WriteLine($"{number3:n0}");
            //declare a variable for 15.12345678910
            double number4 = 15.12345678910;
            Console.WriteLine($"{number4}");

            //Problem #2
            Console.WriteLine("---Number 2---");
            //Calculate daily shipping needs, profits, and costs for local dairy
        //a. prompt the user to enter the amount of milk produced in the morning
        prompt2:
            Console.WriteLine("How many liters of milk is produced in the morning?");
            //variable for user input
            float liters;
            //shipping carton holds 3.78 liters of milk
            float cartonHolds = 3.78f;
            //cost of producing a liter of milk is $0.38
            decimal costOfLiter = 0.38m;
            //profit per liter is $0.27
            decimal profitPerLiter = 0.27m;
            //try/ catch to parse the user input into integer
            try
            {
                liters = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Incorrect input. Please try again.");
                goto prompt2;
            }
            //equation for number of cartons needed to hold milk
            float cartons = liters / cartonHolds;
            //b. output the number of cartons needed to hold milk
            Console.WriteLine($"You will need {cartons:f0} cartons to hold the milk.");
            //equation for total cost for all liters produced
            decimal totalCost = (decimal)liters * costOfLiter;
            //c. output the cost of producing milk
            Console.WriteLine($"The total cost of producing the milk is {totalCost:c2}");
            //equation for total profit from producing the milk
            decimal totalProfit = (decimal)liters * profitPerLiter;
            //d. output the total profit from producing milk
            Console.WriteLine($"The total profit for producing the milk is {totalProfit:c2}");

            //Problem #3
            Console.WriteLine("---Number 3---");
            //write a loop to add all the consecutive numbers between 5 and 45
            //except 12, 25, and 40
            //display the final sum
            //create a variable for total of addition of all numbers 5-45 excluding 12, 25, and 40
            int total = 0;
            //create a for loop to iterate between 5 and 45
            for(int i = 5; i < 46; i++)
            {
                //if statement to exclude each number: 12, 25, and 40- continuing thru without adding to total
                if(i == 12 || i == 25 || i == 40)
                {
                    continue;
                }
                //add to total if not those numbers
                else
                {
                    total += i;
                }
            }
            //output the result to the console
            Console.WriteLine($"The total of numbers between 5 and 45, excluding 12, 25, and 40 is {total}");

            //Problem #4
            Console.WriteLine("---Number 4---");
            //request two integers from the user
            Console.WriteLine("Please enter two whole numbers");
            //create variable to hold the user input
            int rows;
            int columns;
            //while loop and parse
            while(!int.TryParse(Console.ReadLine(), out rows) || !int.TryParse(Console.ReadLine(), out columns))
            {
                Console.WriteLine("Incorrect input. Enter two integers.");
            }
            //parse success
            //nested loop to print stars to console
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Problem #5
            Console.WriteLine("---Number 5---");
            //in main, prompt the user to input a temperature
            int tempInput;
            Console.WriteLine("Enter a temperature");
            while(!int.TryParse(Console.ReadLine(), out tempInput))
            {
                Console.WriteLine("Incorrect input. Please enter a whole number");
            }
            //call your method with the temp and display the result from main
            Problem5(tempInput);

            //Problem #6
            Console.WriteLine("---Number 6---");
            //call the method and display the result from main
            Problem6(46, true);
            Problem6(98, false);

            //Problem #7
            Console.WriteLine("---Number 7---");
            //create an empty array of doubles with a size of 7
            double[] hoursWorked = new double[7];
            //prompt the user to input hours for each day of the week
            prompt7: 
            Console.WriteLine("Please enter how many hours worked for each day of the week.");
            while (!double.TryParse(Console.ReadLine(), out hoursWorked[0]))
            {
                Console.WriteLine("Incorrect input. Please try again.");
                goto prompt7;
            }
            while (!double.TryParse(Console.ReadLine(), out hoursWorked[1]))
            {
                Console.WriteLine("Incorrect input. Please try again.");
                goto prompt7;
            }
            while (!double.TryParse(Console.ReadLine(), out hoursWorked[2]))
            {
                Console.WriteLine("Incorrect input. Please try again.");
                goto prompt7;
            }
            while (!double.TryParse(Console.ReadLine(), out hoursWorked[3]))
            {
                Console.WriteLine("Incorrect input. Please try again.");
                goto prompt7;
            }
            while (!double.TryParse(Console.ReadLine(), out hoursWorked[4]))
            {
                Console.WriteLine("Incorrect input. Please try again.");
                goto prompt7;
            }
            while (!double.TryParse(Console.ReadLine(), out hoursWorked[5]))
            {
                Console.WriteLine("Incorrect input. Please try again.");
                goto prompt7;
            }
            while (!double.TryParse(Console.ReadLine(), out hoursWorked[6]))
            {
                Console.WriteLine("Incorrect input. Please try again.");
                goto prompt7;
            }

            foreach (double x in hoursWorked)
            {
                if(x < 0 || x > 24)
                {
                    Console.WriteLine("Please enter numbers greater than 0 and less than 24 ONLY.");
                    goto prompt7;
                }
            }


            //Problem #8
            Console.WriteLine("---Number 8---");
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            //call method 8 passing the array from #7            
            Problem8(hoursWorked, days);

            //Problem #9
            Console.WriteLine("---Number 9---");
            //call the method 9 and pass the array from #7 and input a value for wage
            double paycheck = Problem9(hoursWorked, 10.00);
            //write to the console and output as currency
            Console.WriteLine($"{paycheck:c2}");

            //Problem #10
            Console.WriteLine("---Number 10---");
            //create a new array and pass it thru method 10
            int[] result10 = Problem10(new int[] { 4, 7, 9, 2, 6, 5 });
            //display the reversed array to the console
            foreach(int x in result10)
            {
                Console.WriteLine($"{x}");
            }
            

            //Problem #11
            Console.WriteLine("---Number 11---");
            //create a new array
            int[] array11 = { 1, 3, 4, 5, 6, 2 };
            //pass the array thru the method from #11
            int result11 = Problem11(2, array11);
            //output to the console
            Console.WriteLine($"{result11}");

            //Problem #12
            Console.WriteLine("---Number 12---");
            //pass the number into the method
            string result12 = Problem12(514);
            //output to the console
            Console.WriteLine($"{result12}");


            Console.ReadLine();
        }

        //Prob 5 Method: freezing point of alcohol is -173 F
        //boiling point of alcohol is 172 F
        //create a method that takes in the temperature in F and returns either
        //"below freezing," "above boiling," or "in between" 
        static void Problem5(int num1)
        {
            if(num1 < -173)
            {
                Console.WriteLine("Below freezing");
            }
            else if(num1 > 172)
            {
                Console.WriteLine("Above boiling");
            }
            else
            {
                Console.WriteLine("In between");
            }
        }

        //Prob 6 Method: use the formula to convert f to c --> C = (F-32) * 5/9
        //modify method from #5 to take two parameters, temp and bool to indicate
        //whether temp was passed as F or C
        static void Problem6(int num1, bool isF)
        {
            int celciusTemp = 0;
            int fahrTemp = 0;
            if (isF)
            {
                celciusTemp = (num1 - 32) * 5 / 9;
                Console.WriteLine($"{celciusTemp} degrees celcius");
            }
            else
            {
                fahrTemp = (num1 * 9 / 5) + 32;
                Console.WriteLine($"{fahrTemp} degrees fahrenheit");
            }
        }

        //Prob 8 Method: create a method to display an employee's hours worked
        //the method will take a double[] as a parameter and will display each
        //element from the array as well as the day of the week starting with Monday
        static void Problem8(double[] hours, string[] daysOfWeek)
        {
            for (int i = 0; i < hours.Length; i++)
            {
                Console.WriteLine($"{daysOfWeek[i]}: {hours[i]} hours worked");
            }
        }

        //Prob 9: create a method to return an employee's total weekly paycheck 
        //the method will take a double[] and an hourly wage as parameters
        //hours worked saturday are 1.5X pay and sunday are 1.75X pay
        static double Problem9(double[] hours, double hourlyWage)
        {
            //extracting saturday hours
            double saturday = hours[5];
            //extracting sunday hours
            double sunday = hours[6];
            //create a variable for the total hours to be calculated by the for loop
            double total = 0;
            for (int i = 0; i < hours.Length - 2; i++)
            {
                total += hours[i];
                continue;
            }
            //total earned for Mon thru Friday
            double total2 = total * hourlyWage;
            //creating saturday total earned
            double satTotal = saturday * 1.5 * hourlyWage;
            //creating sunday total earned
            double sunTotal = sunday * 1.75 * hourlyWage;
            //creating final total earned for all days
            double finalTotal = total2 + satTotal + sunTotal;
            //return the finalTotal
            return finalTotal;

        }

        //Prob 10: Create a method that takes an int[] as a parameter and reverses the array
        //Do not use any in-built methods for this and don't print the array backwards
        static int[] Problem10(int[] array)
        {
            //create a for loop to iterate thru the array to the halfway point
            for(int i = 0; i < array.Length / 2; i++)
            {
                //store an element in temp
                int temp = array[i];
                //replace the element stored
                array[i] = array[array.Length - 1 - i];
                //then replace the other element with temp
                array[array.Length - 1 - i] = temp;
            }
            return array;
        }

        //Prob 11: Create a method that takes int[] as a parameter and a searchValue
        //search the array and return the index of the value if it exists
        //if it doesn't exist, return -1
        static int Problem11(int number, int[] array)
        {
            //create a for loop to iterate thru the array
            for(int i = 0; i < array.Length; i++)
            {
                //if the element is the same as the searchValue (number), return i
                if(array[i] == number)
                {
                    return i;
                }
            }
            return -1;
        }

        //Prob 12: Create a method that takes an int as a parameter
        //the int is going to be between 0 and 999-- assume it is, no need to test
        //method should convert the number to words, such as 9 to "Nine," etc
        static string Problem12(int number)
        {
            //return if given zero
            if(number == 0)
            {
                return "Zero";
            }

            //create variable for the string of words to return
            string numberAsWords = "";

            //check if the number is larger than 100 as it can reach up to 999
            if(number / 100 > 0)
            {
                int numdiv100 = number / 100; 
                //if it is, find the modulus 100 of the number and make that number
                numberAsWords += Problem12(numdiv100) + " hundred";
                number %= 100;
            }
            
            //if that number is still larger than 0
            if(number > 0)
            {
                //and if the string variable has words in it (which it should
                //if the new number is larger than 0), add and to the string
                if (numberAsWords != "")
                    numberAsWords += " and ";

                //create two arrays to hold the numbers less than 20 and
                //another to hold the groups of tens
                string[] numInWords = new[] {
                    "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", 
                    "Nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", 
                    "sixteen", "seventeen", "eighteen", "nineteen" };
                string[] tensInWords = new[] { 
                    "zero", "ten", "twenty", "thirty", "fourty", 
                    "fifty", "sixty", "seventy", "eighty", "ninety"};

                //if the remaining number is less than 20, add that to the string
                if (number < 20)
                    numberAsWords += numInWords[number];
                else
                {
                    //or if not, add the tens word, then add hyphen and the less than 20
                    //number to the string
                    numberAsWords += tensInWords[number / 10];
                    if ((number % 10) > 0)
                        numberAsWords += "-" + numInWords[number % 10];
                }
            }
            //return the string created within this method
            return numberAsWords;
        }
        
    }
}
