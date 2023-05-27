using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndParsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user
            //cw tab tab
            Console.WriteLine("Enter three whole numbers");
            //We use Console.ReadLine() to get input
            string xString = Console.ReadLine();
            string yString = Console.ReadLine();
            string zString = Console.ReadLine();
            //In order to do math, we have to parse
            //the strings
            int x = int.Parse(xString);
            int y = int.Parse(yString);
            int z = int.Parse(zString);
            //lets multiply x and y and divid by z
            //Casting (dataType)variable
            double result = x * y / (double)z;
            //output the result
            Console.WriteLine("The result is " + result);

            Console.ReadLine();
        }
    }
}
