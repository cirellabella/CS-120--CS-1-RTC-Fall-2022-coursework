using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Try catch is a way of running code
            //that might cause an exception

            //Lets do int
            //first prompt
            Console.WriteLine("Please enter a whole number");
            //create a string and set it equal to Console.ReadLine()
            string input1 = Console.ReadLine();
            //declare the integer variable
            int number1;
            //Try block
            try
            {
                number1 = Convert.ToInt32(input1);
                //Now logically if I make it here
                //Here we know logically that the convert
                //was a success
                Console.WriteLine($"Convert Success {number1}");
            }
            catch
            {
                //Logically if I get down here, what do I know?
                //We know the conversion failed
                Console.WriteLine($"Conversion failed {input1} cannot convert to int");
            }
            //lets calculate totalPrice from a quantity and unitPrice
            //quantity and unitPrice are going to come from the user
            //we need our prompt
            Console.WriteLine("Please enter a quantity of products to buy");
            string qtyString = Console.ReadLine();
            Console.WriteLine("Please enter the price of each product");
            string priceString = Console.ReadLine();
            //declare my numeric variables
            int quantity;
            decimal price;
            //now we need to convert the strings to int and decimal
            //and this might not work
            try
            {
                //lets try to do the conversions
                quantity = Convert.ToInt32(qtyString);
                price = Convert.ToDecimal(priceString);
                //logically if I make it down here, 
                //we know that our conversions worked
                decimal totalPrice = quantity * price;
                //output the results
                Console.WriteLine($"The quantity: {quantity}, The price: {price}, Total: {totalPrice}");
            }
            //the catch is what runs when something goes wrong
            catch
            {
                Console.WriteLine("Conversion failed. Please follow instructions.");
            }

            Console.ReadLine();
        }
    }
}
