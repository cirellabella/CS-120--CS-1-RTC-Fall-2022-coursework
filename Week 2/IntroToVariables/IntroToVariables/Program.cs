using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables are declared by giving them a data
            //type and a name
            int number;
            //int is for integer and stores whole numbers
            //Here we are assigning the value 10 to the number variable
            number = 10;
            //We can print to the console
            Console.WriteLine(number);
            //Assign a new value to number
            number = 20;
            //We can print out the new value
            Console.WriteLine(number);


            //Initialization - Declaring and assigning in one step
            int x = 22;

            //It is also possible to declare multiple variables 
            double length, width, area;
            //this is the same as
            //double length;
            //double width;
            //double area;
            length = 10.2;
            width = 5.4;
            area = length * width;
            //Lets print out what the area is
            Console.WriteLine("The Area is");
            Console.WriteLine(area);

            //Strings are for text and they use double quotes
            string firstName = "Gianni";

            //Char - stores one character only and uses single quotes
            char letter = 'a';

            //bool stores only true or false
            bool isOdd = true;


            //Keep the console open until I hit enter
            Console.ReadLine();
        }
    }
}
