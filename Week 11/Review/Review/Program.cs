using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calling method for lab 9 number 7
            ReverseArray(new double[] { 5.2, 10.2, 6.4, 5.3, 2.1 });

            int[] numbers = { 7, 10, 3, 12, 5, 9 };
            //Calling method for lab 9 number 6
            int largestIndex = IndexOfLargest(numbers);
            Console.WriteLine($"The index of the largest number is {largestIndex}");
            Console.WriteLine($"The largest element is {numbers[largestIndex]}");

            //Calling method for extra credit on lab 8
            int total = SumOfDigits(827);
            Console.WriteLine(total);

            Console.ReadLine();
        }

       //Method for lab 9 number 7
       static double[] ReverseArray(double[] numbers)
        {
            for(int i = 0; i < numbers.Length / 2; i++)
            {
                //store an element in temp
                double temp = numbers[i];
                //replace whatever element you stored
                numbers[i] = numbers[numbers.Length - 1 - i];
                //then replace the other elements with temp
                numbers[numbers.Length - 1 - i] = temp;
            }
            return numbers;
        }

        //Method for Lab 9 number 6
        //method that takes an int[] as a parameter
        //and returns the index of the largest element
        static int IndexOfLargest(int[] numbers)
        {
            //we need a variable to track the largest index
            int largestIndex = 0;
            //for loop that starts at 1
            for(int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] > numbers[largestIndex])
                {
                    largestIndex = i;
                }
            }
            return largestIndex;
        }

        //method for extra credit on lab 8
        static int SumOfDigits(int number)
        {
            int total = 0;
            while(number > 0)
            {
                total += number % 10;
                 number /= 10;
            }
            return total;

            //the below is the same but without using loop
            ////this gets us the digit in the ones place
            //int firstNum = number % 10;
            ////this removes the digit in the ones place
            //firstNum /= 10;
            ////add the digit to total
            //total += firstNum;
            ////repeat this process two more times
            //int secondNum = number % 10;
            //secondNum /= 10;
            //total += secondNum;
            //int thirdNum = number % 10;
            //thirdNum /= 10;
            //total += thirdNum;



        }

    }
}
