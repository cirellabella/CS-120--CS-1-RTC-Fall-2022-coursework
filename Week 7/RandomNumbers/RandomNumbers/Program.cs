using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generating random numbers
            //create an instance of the random class
            //you only do this once
            Random rand = new Random();
            //To get a value out of the random class we use the Next Method()
            //get a random number between 1 and 100
            int randomNumber = rand.Next(1, 101);
            //we could make a decision based on this number
            if(randomNumber > 50)
            {
                Console.WriteLine($"You won! {randomNumber}");
            }
            else
            {
                //what do I know inside of this else
                Console.WriteLine($"You lose: {randomNumber}");
            }

            //Lets start rolling some dice
            int die1 = rand.Next(1, 7);
            int die2 = rand.Next(1, 7);
            //counter to keep track how many times I've rolled 
            int rollCount = 1;
            //this loop is going to repeat until die1 and die2 are equal
            while(die1!= die2)
            {
                die1 = rand.Next(1, 7);
                die2 = rand.Next(1, 7);
                rollCount++;
            }
            //what do we know down here?
            Console.WriteLine($"You rolled the same number. It took {rollCount} tries.");

            //lets win the powerball
            int winningNumber = 1;
            int numberOfTickets = 1;
            //get the random number between 1 ans 292, 201, 338
            int ourNumber = rand.Next(1, 292201339);
            //we set up our loop
            while(ourNumber != winningNumber)
            {
                ourNumber = rand.Next(1, 292201339);
                numberOfTickets++;
            }
            //we won the powerball
            Console.WriteLine($"You won! You only had to buy {numberOfTickets:n}.");
            Console.WriteLine($"Which cost: {numberOfTickets * 2:c2}.");
            Console.ReadLine();
        }
    }
}
