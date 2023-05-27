//Cirella Smith
//Midterm
//Ocotber 28, 2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Number 1--");
            //declare variables for each of the following using the correct data type
            //a: $19.99, b: -120, c: 200,000,000, d: 3.48596758475,
            //e: -9,123,456,798,123, f: 9.784
            decimal a = 19.99m;
            sbyte b = -120;
            int c = 200000000;
            double d = 3.48596758475;
            long e = -9123456798123;
            float f = 9.784f;
            Console.WriteLine($"The decimal is {a:c}, the sbyte is {b}, the integer is {c}, the double is {d}, the long is {e}, and the float is {f}");

            Console.WriteLine("--Number 2--");
            //declare two variables, num1 and num2 and assign any number to them
            int num1 = 5;
            int num2 = 12;
            //a. create a bool for num1 NOT greater than 10
            bool lessThanEqual10 = num1 <= 10;
            Console.WriteLine($"{num1} is not greater than 10: " + lessThanEqual10);
            //b. create a bool for num2 is NOT equal to 5 and is even
            bool not5AndEven = num2 != 5 && num2 % 2 == 0;
            Console.WriteLine($"{num2} is not 5 and is even: " + not5AndEven);
            //c. create a bool for num1 is between 20 and 30
            bool between20And30 = num1 <= 30 && num1 >= 20;
            Console.WriteLine($"{num1} is between 20 and 30: " + between20And30);
            //d. create a bool for num2 is not between 30 and 40
            bool notBetween30And40 = num2 >= 40 || num2 <= 30;
            Console.WriteLine($"{num2} is not between 30 and 40: " + notBetween30And40);
            //e. create a bool for num1 is greater than 5 and num2 OR num2 is less than -3 
            bool equation1 = num1 > 5 && num1 > num2 || num2 < -3;
            Console.WriteLine($"{num1} is greater than 5 and {num2} or {num2} is less than -3: " + equation1);
            //f. create a bool for num1 is not equal to 3 and not equal to 5
            bool not3AndNot5 = num1 != 3 && num1 != 5;
            Console.WriteLine($"{num1} is not 3 and is not 5: " + not3AndNot5);

            Console.WriteLine("--Number 3--");
            //request and read 3 integer values from the user's input
            //goto
            prompt3:
            Console.WriteLine("Please enter 3 whole numbers");
            float N1;
            float N2;
            float N3;
            //try to ensure user input is in whole numbers
            try
            {
                N1 = float.Parse(Console.ReadLine());
                N2 = float.Parse(Console.ReadLine());
                N3 = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Incorrect input. Please try again.");
                goto prompt3;
            }
            //equation for average of the 3 values input by user
            float average = (N1 + N2 + N3) / 3;
           //output the average to the console
            Console.WriteLine($"The average of the three values is {average}");

            Console.WriteLine("--Number 4--");
            //request an integer from the user
            //goto
            prompt4:
            Console.WriteLine("Please input a whole number");
            //declare the variable
            int num4;
            //try to ensure user input is the correct type
            try
            {
                num4 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Incorrect input. Try again.");
                goto prompt4;
            }
            //if statements for various circumstances
            //divisible (modulus) by 3 and 7 with no remainder
            if(num4 % 3 == 0 && num4 % 7 == 0)
            {
                Console.WriteLine($"{num4} is divisible by 3 and by 7");
            }
            //divisible by 3 with no remainder and not 7
            else if(num4 % 3 == 0 && num4 % 7 != 0)
            {
                Console.WriteLine($"{num4} is divisible by 3 only");
            }
            //divisible by 7 with no remainder and not 3
            else if(num4 % 3 != 0 && num4 % 7 == 0)
            {
                Console.WriteLine($"{num4} is divisible by 7 only");
            }
            //divisible by neither using else to handle all other options
            else
            {
                Console.WriteLine($"{num4} is divisible by neither 3 nor 7");
            }

            Console.WriteLine("--Number 5--");
            //request quantity and price of an item from a user
            prompt5:
            Console.WriteLine("Please enter the quantity and price of the item");
            //declare the variables
            decimal quantity;
            decimal price;
            //try to ensure numbers are input
            try
            {
                quantity = Convert.ToDecimal(Console.ReadLine());
                price = Convert.ToDecimal(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Incorrect input. Try again.");
                goto prompt5;
            }
            //equation to calculate subtotal
            decimal subtotal = quantity * price;
            //discount for over 1000 subtotal and over 500 subtotal
            decimal discount15 = 0.15m;
            decimal discount10 = 0.10m;
            //equation for discount on subtotal over 1000
            decimal discountTotal = subtotal * discount15;
            //equation for discount on subtotal over 500
            decimal discountTtl10 = subtotal * discount10;
            //total after discount over 1000
            decimal total = subtotal - discountTotal;
            //total for discount over 500
            decimal total10 = subtotal - discountTtl10;
            //if statements to handle each of the scenarios
            if (subtotal > 1000)
            {
                Console.WriteLine($"Original Total:{subtotal:c2}, discount: {discountTotal:c2}, final discounted total: {total:c2} ");
            }
            else if(subtotal > 500)
            {
                Console.WriteLine($"Original Total: {subtotal:c2}, discount: {discountTtl10:c2}, final discounted total: {total10:c2}");
            }
            else
            {
                Console.WriteLine($"The total is {subtotal:c2}");
            }

            Console.WriteLine("--Number 6--");
            //get user input for values x and y
            prompt6:
            Console.WriteLine("Please input 2 whole numbers");
            //declare variables
            int x;
            int y;
            //try to make sure input is numbers
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Incorrect input. Try again.");
                goto prompt6;
            }
            //if statements for each quadtrant
            //if both are positive- quad 1
            if(x > 0 && y > 0)
            {
                Console.WriteLine($"The point at {x} and {y} is in Quadrant 1");
            }
            //if x is negative while y is still positive- quad 2
            else if(x < 0 && y > 0)
            {
                Console.WriteLine($"The point at {x} and {y} is in Quadrant 2");
            }
            //if both are negative- quad 3
            else if(x < 0 && y < 0)
            {
                Console.WriteLine($"The point at {x} and {y} is in Quadtrant 3");
            }
            //if x is positive and y is negative- quad 4
            else if(x > 0 && y < 0)
            {
                Console.WriteLine($"The point at {x} and {y} is in Quadtrant 4");
            }
            //all other options output
            else
            {
                Console.WriteLine($"The point at {x} and {y} is either on the x-axis, on the y-axis or at the point of origin");
            }

            Console.WriteLine("--Number 7--");
            //request the radius and height of a cone from a user
            prompt7:
            Console.WriteLine("Please input the radius and height of a cone");
            //declare variables
            double radius;
            double height;
            //try to ensure user input numbers
            try
            {
                radius = Convert.ToDouble(Console.ReadLine());
                height = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Incorrect input. Try again.");
                goto prompt7;
            }
            //equation for the volume of a cone
            double volume = (Math.PI * Math.Pow(radius, 2) * (height / 3));
            //output the volume to the 3rd decimal place
            Console.WriteLine($"The volume of the cone is {volume:f3}");

            Console.WriteLine("--Number 8--");
            //request an integer from the user
            prompt8:
            Console.WriteLine("Please enter a whole number");
            //declare variable
            int input8;
            //try to ensure input is a number
            try
            {
                input8 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Incorrect input. Try again.");
                goto prompt8;
            }
            //equations to find the whole number result of division and the modulus/ remainder number
            int divide3 = input8 / 3;
            int modOf3 = input8 % 3;
            //output to the console
            Console.WriteLine($"The number {input8} when divided by 3 returns with {divide3} with a remainder of {modOf3}");

            Console.WriteLine("--Number 9--");
            //use a switch to correspond to the days of the week starting with Monday as 1 and so on
            prompt9:
            Console.WriteLine("====Days of the Week====");
            Console.WriteLine("Please select a day of the week by selecting a number between 1 to 7");
            Console.WriteLine("1. Monday");
            Console.WriteLine("2. Tuesday");
            Console.WriteLine("3. Wednesday");
            Console.WriteLine("4. Thursday");
            Console.WriteLine("5. Friday");
            Console.WriteLine("6. Saturday");
            Console.WriteLine("7. Sunday");
            //declare a variable to store user input
            int userInput;
            //try to make sure a number was entered
            try
            {
                userInput = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Incorrect input. Try again.");
                goto prompt9;
            }
            //create the switch and output what the user has selected
            switch (userInput)
            {
                case 1: 
                    Console.WriteLine("You selected Monday.");
                    break;
                case 2:
                    Console.WriteLine("You selected Tuesday.");
                    break;
                case 3:
                    Console.WriteLine("You selected Wednesday.");
                    break;
                case 4:
                    Console.WriteLine("You selected Thursday.");
                    break;
                case 5:
                    Console.WriteLine("You selected Friday.");
                    break;
                case 6:
                   Console.WriteLine("You selected Saturday.");
                    break;
                case 7:
                    Console.WriteLine("You selected Sunday.");
                    break;
                default:
                    Console.WriteLine("Error: Invalid day of the week. Try again");
                    goto prompt9;
            }


            Console.ReadLine();
        }
    }
}
