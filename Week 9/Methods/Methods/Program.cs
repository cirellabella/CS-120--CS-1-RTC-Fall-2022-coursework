using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {//This is the start of the Class
        static void Main(string[] args)
        {//This is the start of Main

            //Calling a Greeting Method
            Greeting("Tabitha");

            //Calling the SumNumbs method
            int total = SumNumbs(4, 8);
            Console.WriteLine($"The total is {total}");

            Console.ReadLine();

        }//This is the end of Main

        //Here I am still inside of the class, but outside of the Main Method
        //This is where I can create my own methods
        //Syntax for creating/ defining a method
        //static returnType NameOfMethod(parameters)
        //This method will print a greeting to the console (display method is void)
        static void Greeting(string name)
        {
            Console.WriteLine($"Welcome {name}");
        }
        //Lets make another method
        //Take two ints as parameters, add them together and return the sum
        static int SumNumbs(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

    }//This is the end of the Class
}
