using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare three int variables
            int num1;
            int num2;
            int num3;
            //prompt the user to enter 3 int numbers
            Console.WriteLine("Please enter 3 numbers");
            
            //the old way
            //string num1String = Console.ReadLine();
            //num1 = Convert.ToInt32(num1String);

            //the new way
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            //we have 3 int variables
            //we can ask questions about them
            if (num1 > num2)
            {
                //this code block only runs when num1 is greater
                //than num2
                Console.WriteLine($"{num1} is greater than {num2}");
            }
            //lets ask another question
            if (num2 < num3)
            {
                //what do we know logically if this runs?
                //num2 is less than num3
                Console.WriteLine($"{num2} is less than {num3}");
            }
            //== is for comparison check for equality
            //= is assignment
            if (num3 == 10)
            {
                //inside of this code block, we know num3 is 10
                Console.WriteLine($"{num3} is 10");
            }
            //!= not equal
            //! means NOT
            if (num2 != 20)
            {
                //inside here we know logically num2 is not 20
                Console.WriteLine($"{num2} is not 20");
            }
            Console.ReadLine();

        }
    }
}
