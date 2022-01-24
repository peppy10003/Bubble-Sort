using System;
/*
 * this is a simple sorting algorithm (Bubblesort)
 * 21/01/2022
 * Edwin Tsang
*/
namespace Bubble_Sort
{
    class Program
    {
        static int[] Array = {3, 1, 4, 6, 2, 5, 2, 2, 1, 6, 8, 10, 200}; // the array to sort
        static bool LoopCheck = false;
        static int Placeholder = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("The Inital array is [" + string.Join(", ", Array) + "]");
            while (LoopCheck == false) // checks if everything is sorted
            {
                LoopCheck = true; // creates the check
                for (int i = 0; i < Array.Length - 1; i++) // repeats a number of time the function runs though the list, if left unchecked it doesnt know when to start over from the begining
                {
                    if (Array[i] > Array[i + 1]) // checks if first number is biiger htan second number
                    {
                        LoopCheck = false; // check that it has been done is false
                        Placeholder = Array[i]; // puts the first number into a placeholder
                        Array[i] = Array[i + 1]; // replaces the second number onto the first number
                        Array[i + 1] = Placeholder; // moves first number onto second number
                        Console.WriteLine("[" + string.Join(", ", Array) + "]"); // prints working out
                    }
                }
            }
            Console.WriteLine("the sorted array is: [" + string.Join(", ", Array) + "]"); //prints end result
        }
    }
}
