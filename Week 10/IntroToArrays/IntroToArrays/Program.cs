using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating a double array with known values
            double[] numbers = new double[] { 5.2, 10.3, 5, 8.4 };
            //a for loop where i starts at 0 and goes to 3
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            //another one
            Console.WriteLine("We're adding 1 to each element");
            //add one to each element of an array
            for(int i = 0; i < numbers.Length; i++)
            {
                //how can i add 1 to each element in array?
                //i is index
                //numbers[i] is the element
                numbers[i]++;
                //print out the new value for the element
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();
        }
    }
}
