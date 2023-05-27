using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibraryandNumericFormats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The Math library gives you access to some basic math methods
            //and values such as PI
            Console.WriteLine($"Pi is {Math.PI}");
            double radius = 5.2;
            double area = Math.PI * Math.Pow(radius, 2);
            //I can use a numeric formatter. This will round the output
            //to 3 digits
            Console.WriteLine($"The area of the circle is {area:f3}");

            //Sales tax in washington is 10.5% = .105
            double salesTax = .105;
            Console.WriteLine($"Sales tax is {salesTax:p1}");

            //the numeric formatter
            long nationalDebt = 31140000000000;
            Console.WriteLine($"The national debt is {nationalDebt:n0}");

            //currency
            decimal newBMW = 50000m;
            Console.WriteLine($"A new BMW is {newBMW:c2}");

                        
            Console.ReadLine();
        }
    }
}
