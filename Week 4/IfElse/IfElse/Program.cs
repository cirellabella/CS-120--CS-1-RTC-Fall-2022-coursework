using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare and assign 3 int numbers
            int x = 5;
            int y = 10;
            int z = 5;
            //lets ask some questions about these variables
            if(y == 10)
            {
                //logically inside of this code block, I know y is 10
                Console.WriteLine($"{y} is equal to 10");
            }
            else
            {
                //logically inside of else what do i know?
                // y is not 10
                Console.WriteLine($"{y} is not 10");
            }
            //lets compare x and z
            if(x > z)
            {
                //logically inside of this code block i know
                //that x is greater than z
                Console.WriteLine($"{x} is greater than {z}");
            }
            else if(z > x)
            {
                //logically in this code block i know
                //z has to be greater than x
                Console.WriteLine($"{z} is greater than {x}");
            }
            else
            {
                //inside of this code block i know x equals z
                Console.WriteLine($"{x} is equal to {z}");
            }

            Console.ReadLine();
        }
    }
}
