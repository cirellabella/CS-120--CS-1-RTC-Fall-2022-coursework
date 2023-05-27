using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Do While loop is a post test loop
            //the check to see if the loop runs happens at the end
            //do while loops always run at least once
            do
            {
                Console.WriteLine("This loop will run at least once");
            }
            while (false);
            //do while loop with a COUNTER
            int counter = 15;
            do
            {
                Console.WriteLine($"Counter is {counter}");
                counter--;
            }
            while (counter >= 10);
            //what is the value of counter down here?
            //counter is 9
            Console.WriteLine($"Counter is {counter}");

            Console.ReadLine();
        }
    }
}
