using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for loop
            //syntax
            //for (statement1; statement2; statement3;)
            //statement1 runs only once at the beginning
            //statement2 is the boolean value that gets tested, it's a pre- test loop
            //statement3 runs at the end of each iterationof the loop
            //usually you will change the variable in statement3
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"I equals {i}");
            }
            Console.WriteLine("End loop 1");
            //lets try to write a for loop 3, 6, 9, 12, 15, 18
            //print out all numbers divisible by 3 and less than 20
            for(int i = 3; i < 20; i += 3)
            {
                Console.WriteLine($"I equals {i}");
            }
            Console.WriteLine("End loop 2");

            Console.ReadLine();
        }
    }
}
