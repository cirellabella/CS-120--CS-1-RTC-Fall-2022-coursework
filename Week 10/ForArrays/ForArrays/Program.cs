using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //putting values in the array
            int[] numbers = { 5, 10, 4, 2, 10, -3, 19 };
            int[] numbers2 = { 5, 10, 4, 2, -3, 10, 15 };

            //Calling our displayelements method
            Console.WriteLine("Method 1");
            DisplayElements(numbers);

            //Call method
            Console.WriteLine("Method 2");
            DisplayArrayDetails(numbers2);

            //Calling the ReturnSum method
            Console.WriteLine("Method 3");
            int sum = ReturnSum(numbers);
            int sum2 = ReturnSum(numbers2);
            Console.WriteLine($"The sum of array 1 is {sum}");
            Console.WriteLine($"The sum of array 2 is {sum2}");

            Console.WriteLine("Method 4");
            CompareArray(numbers, numbers2);

            Console.ReadLine();
        }
        //make a method that displays all of the elements
        //in the array
        static void DisplayElements(int[] array)
        {
            //Read only operation with the elements
            //you can use a foreach
            foreach(int number in array)
            {
                Console.WriteLine(number);
            }
        }

        //Display method that shows the index and the element
        static void DisplayArrayDetails(int[] array)
        {
            //because i want to print index, i can't use foreach
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Index: {i} Element: {array[i]}");
            }
        }

        //make a method that takes int array as parameter
        //and returns the sum of all elements in array
        static int ReturnSum(int[] array)
        {
            //variable to track the total
            int total = 0;
            //for
            //for(int i = 0; i < array.Length; i++)
            //{
            //    total += array[i];
            //}
            //return total;
            //foreach
            foreach(int x in array)
            {
                total += x;
            }
            return total;
        }

        //lets write a method that takes in an int[] and returns
        //the average value of the elements in the array
        static double ReturnAvg(int[] array)
        {
            double average = ReturnSum(array) / (double)array.Length;
            return average;
            //can also write one line instead
            //return ReturnSum(array) / (double)array.Length
        }

        //write a method that takes two int[] as parameters
        //and displays each index and element for the array with
        //the higher average element size
        static void CompareArray(int[] array1, int[] array2)
        {
            if (ReturnAvg(array1) > ReturnAvg(array2))
            {
                DisplayArrayDetails(array1);
            }
            DisplayArrayDetails(array2);
        }
    }
}
