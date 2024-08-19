using System;
using System.ComponentModel.Design;
using System.Net.Sockets;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        
        {
            //TODO:

            // Create an int array and populate it with numbers 1-10
            /* Create a list of type int
             * Name the list "evens"
                    /* Create another list of type int
             * Name the list "odds"
             */
            int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();
            
            /* Using either a foreach or for loop,
             * iterate through the array you populated with 10 numbers.
             * Inside the scope of the loop,
             * check to see if each number in the array is even or odd.
             * If the number is even, add it to the evens list.
             * If the number is odd, add it to the odds list.
             */
            for (int i = 0; i <= 9; i++)
            {
                if (numbers[i] % 2 == 0)
                    evens.Add(numbers[i]);
            }

            for (int i = 0; i <= 9; i++)
            {
                if (numbers[i] % 2 != 0)
                    odds.Add(numbers[i]);
            }


            /* Using a foreach loop,
             * display the numbers in your "evens" list
             */
            Console.WriteLine("Here is the list of even numbers:");
            foreach (var number in evens)
            { 
                Console.WriteLine(number);
            }

            /* Using a for loop,
             * display the numbers in your "odds" list
             */
            
            Console.WriteLine("Here is the list of odd numbers:");
            for(int i = 0; i <= 9; i++)
            {
                Console.WriteLine(odds[i]);
            }
        }
    }
}
