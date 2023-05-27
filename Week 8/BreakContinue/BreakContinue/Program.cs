using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Break and Continue
            //The break keyword exits the loop
            //This is commonly used if you found the value
            //you were looking for
            Console.WriteLine("====Break Example====");
            //create a counter
            int counter = 1;
            //while loop that runs as long as the counter is less than 10
            while(counter < 10)
            {
                //if the number divides evenly by 5
                //we break out of the loop
                if(counter % 5 == 0)
                {
                    break;
                }
                Console.WriteLine(counter);
                counter++;
            }
            Console.WriteLine("Exited the first loop");
            //Continue skips to the next iteration of the loop

            for(int i = 0; i < 20; i++)
            {
                //lets skip every number that divided evenly by 3
                if(i % 3 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("Exited loop 2");
            Console.ReadLine();
        }
    }
}
