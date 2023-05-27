using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nested loops
            //When a loop is contained w/in another loop
            //the inner runs in its entirety for each iteraction
            //of the outer loop

            //Lets print i and j to the console
            for(int i = 0; i < 3; i++)
            {
                //this inner loop will run 3 times
                //each time the outer loop runs
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"I: {i}, J: {j}\t");
                }
                //the outer loop is making a new line
                Console.WriteLine();
            }
            //Try and print the following to the console
            //***
            //***
            //***
            //***
            int rows = 4;
            int stars = 3;
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < stars; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //*****
            //****
            //***
            //**
            //*
            for(int i = 0; i < 5; i++)
            {
                for(int j = 5; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("End of nested loop 2");

            //   *   
            //  * *  
            // * * * 
            //* * * * 
            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {                   
                    Console.Write("* ");                    
                }
                Console.WriteLine("");
            }


            Console.ReadLine();
        }
    }
}
