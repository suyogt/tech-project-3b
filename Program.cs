/*
 Author: Suyog Thengale
 Date: 09/27/2020
 Course: ISM 4300
 Comments: This C# concsole application executes an array of 1-25 without any user input.
 
*/

using System;

namespace tech_project_3b
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputing values manually 
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            Console.WriteLine("Element value = " + numbers + " ");

            // iterate through the array with foreach loop 
            foreach (int i in numbers)

            {
                Console.WriteLine("Element value = " + i + " "); //print value
            }


        } //end of main 
    } //end of class
} //end of namespace
