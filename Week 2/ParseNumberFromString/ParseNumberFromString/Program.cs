using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseNumberFromString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user
            Console.WriteLine("Enter a length");
            //Capture the length and store in a string
            string lengthString = Console.ReadLine();
            //Prompt for the width
            Console.WriteLine("Enter a width");
            //capture the width and store in a string
            string widthString = Console.ReadLine();
            //what do we do now?
            //We have to parse the strings
            double length = double.Parse(lengthString);
            double width = double.Parse(widthString);
            //Calculate the area
            double area = length * width;
            //output the result
            Console.WriteLine("The area is " + area);

            Console.ReadLine();
        }
    }
}
