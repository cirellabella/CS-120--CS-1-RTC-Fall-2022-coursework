using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Number 1---");
            int[] array = CreateRandomArray(25);
            DisplayArray(array);
            Console.WriteLine("---Number 2---");
            bool found1 = IsPresent(7, array);
            bool found2 = IsPresent(50, array);
            bool found3 = IsPresent(71, array);
            Console.WriteLine($"7 {found1} 50 {found2} 71 {found3}");
            Console.WriteLine("---Number 3---");
            int index1 = FindIndexOf(7, array);
            int index2 = FindIndexOf(50, array);
            int index3 = FindIndexOf(71, array);
            Console.WriteLine($"7 {index1} 50 {index2} 71 {index3}");

            Console.ReadLine();
        }

        //Lets make a method that takes a size as a parameter
        //and returns an array[size] of random integers
        static int[] CreateRandomArray(int size)
        {
            //create an int array of given size
            int[] numbers = new int[size];
            //create a new instance of random class
            Random random = new Random();
            //loop
            //foreach cannot change the array
            for(int i = 0; i < numbers.Length; i++)
            {
                //set each element to a random number between 0 and 100
                numbers[i] = random.Next(101);
            }
            return numbers;
        }

        //display method to show the array
        static void DisplayArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Index: {i}, Element: {array[i]}");
            }
        }

        //lets make a method that takes an int as a parameter and an int[]
        //and searches thru the array and returns true if it's in array
        //and false if it's not in the array
        static bool IsPresent(int number, int[] array)
        {
            //before the loop, I haven't found what I'm looking for
            bool found = false;
            //now we have our loop
            foreach(int element in array)
            {
                //if the element matches the number we found it
                if(element == number)
                {
                    found = true;
                }
            }
            return found;
        }

        //make a method that takes an int to search for and an int[] to find the
        //int in. return the index of that element. return -1 if you do not find it
        static int FindIndexOf(int number, int[] array)
        {
            //must use for loop because we want the index
            for(int i = 0; i < array.Length; i++)
            {
                //if we find the element at a given index, return index
                if(array[i] == number)
                {
                    return i;
                }
            }
            //since we returned if we found it, if we make it down here, we didn't find it
            return -1;
        }
    }
}
