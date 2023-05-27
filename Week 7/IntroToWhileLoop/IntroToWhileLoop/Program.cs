using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro to while loops
            //while loop syntax
            //while(boolean){}
            int counter = 0;
            while( counter < 5)
            {
                Console.WriteLine($"The counter is {counter}");
                counter++;
            }
            Console.WriteLine("Exited loop 1");
            //while loop example 2
            int counter2 = 1;
            while (counter2 < 100)
            {
                Console.WriteLine($"The counter2 is {counter2}");
                counter2 *= 2;
            }
            //lets do a quick exercise
            //create while loop that prints all odd numbers between 1 and 20
            int counter3 = 1;
            while (counter3 < 20)
            {
                if (counter3 % 2 == 1)
                {
                    Console.WriteLine($"Counter3 is {counter3}");
                }
                counter3++;
            }
            Console.ReadLine();
        }
    }
}
