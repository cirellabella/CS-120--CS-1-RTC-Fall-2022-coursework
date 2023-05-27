using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //When calling a method, I have to consider what the return is
            //and what parameters the method requires
            string name = FullName("Gilbert", "Juarez", 3.8);
            Console.WriteLine(name);
            //Calling the IsEven method
            bool even = IsEven(7);
            Console.WriteLine(even);
            //Could we call this method from inside a loop
            for(int i = 50; i <= 75; i++)
            {
                bool result = IsEven(i);
                if (result)
                {
                    Console.WriteLine($"{i} is even");
                }
                else
                {
                    Console.WriteLine($"{i} is odd");
                }
            }
            //calling the ValidatePassword method
            bool valid = ValidatePassword("password1");
            Console.WriteLine(valid);
            Console.WriteLine("Please enter a password");
            string input = Console.ReadLine();
            bool valid2 = ValidatePassword(input);
            Console.WriteLine(valid2);

            //calling the Greeting method
            Greeting("Kasey");

            //calling the Compare method
            int biggest = Compare(20, 10);
            Console.WriteLine(biggest);

            //calling the volume method
            double vol = Volume(3.4, 7.8);
            Console.WriteLine($"The volume is {vol}");

            Console.ReadLine();

            
        }
        //inside the class and outside of main
        //we define outside of main
        //we call them inside of main
        //create a method that takes two strings as parameters
        //and returns a new string with a space between the two parameters
        static string FullName(string firstName, string lastName, double gpa)
        {
            string fullName = firstName + " " + lastName + $" has a gpa of {gpa}";
            return fullName;
        }
        //could we make a method that takes an int as a parameter
        //and returns true if the int is even and false if the int is odd?
        static bool IsEven(int number)
        {
            bool result = number % 2 == 0;
            return result;
        }
        //lets make a method that takes a password string as a parameter
        //and returns true if the password is valid and false if the password is not valid
        static bool ValidatePassword(string password)
        {
            //check if the password is empty
            if(password == "")
            {
                return false;
            }
            //because we have a return inside of the if check, the else is implied
            if(password.Length < 5 || password.Length > 45)
            {
                return false;
            }
            return true;
        }

        //lets make a method that takes a string name
        //as a parameter and prints "welcome to my program"
        //and then the name to the console
        static void Greeting(string name)
        {
            Console.WriteLine($"Welcome to my program {name}");
        }

        //lets make a method that takes in two integer numbers 
        //and returns the larger number
        static int Compare(int num1, int num2)
        {
            if(num1 > num2)
            {
                return num1;
            }                       
            return num2;
            
        }

        //lets make a method to calculate the volume of a cyclinder
        //take in the radius and the height and return the volume
        //V = PI * R^2 * H
        static double Volume(double radius, double height)
        {
            double vol = Math.PI * Math.Pow(radius, 2) * height;
            return vol;
        }
    }
}
