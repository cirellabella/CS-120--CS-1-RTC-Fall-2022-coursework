using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelGoTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A label is a point in your code that you can jump to
            //We create a label by giving it a name and then :
            prompt:
            Console.WriteLine("Please enter a number between 0 and 100");
            int userNumber;
            try
            {
                userNumber = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You did not enter a whole number");
                //I'm going to send the user back
                goto prompt;
            }
            //If I make it down here what do I know logically
            //userNumber is an integer and it has a value
            //lets find out is it is between 0 and 100
            if(userNumber < 0 || userNumber > 100)
            {
                Console.WriteLine("That number was not between 0 and 100");
                goto prompt;
            }
            //now logically what do I know
            //we know it is between 0 and 100
            if(userNumber < 50)
            {
                Console.WriteLine($"{userNumber} is between 0 and 49");
            }
            else
            {
                //I know that the number must be between 50 and 100
                Console.WriteLine($"{userNumber} is between 50 and 100");
            }

            Console.ReadLine();
            
        }
    }
}
