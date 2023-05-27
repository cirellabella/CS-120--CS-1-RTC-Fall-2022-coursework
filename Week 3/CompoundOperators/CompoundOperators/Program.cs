using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 25;
            //++ this is a shortcut for total = total + 1
            total++; //26
            //-- this is a shortcut for total = total - 1
            total--; //25
            //+= this is a shortcut for total = total + 5
            total += 5; //30

            //declare a 2nd variable
            int number = 7;
            //-= this is a shortcut for total = total - number
            total-= number; //23
            //*= this is a shortcut for total = total * 5
            total *= 5; //115

            // /= this is a shortcut for total = total / 10
            total /= 10; //11- not 11.5, since it's integer type

            // %= this is a shortcut for total = total % 3
            total %= 3; //2 (remainder/ mod for division by 3)
            Console.WriteLine($"The total is {total}");

            Console.ReadLine();
        }
    }
}
