﻿namespace Day_6_Arrays_Lists;

// This program will ask for three numbers
//      add them together and display the total

class Program
{   
    static void Main(string[] args)
    {
        // Define an array to hold 3 numbers 
        int[] numbers = new int[3];  // numbers.Length = 3; 2 is the largest allowable index

        // Define a variable to hold the sum of the numbers
        int sum = 0;

        Console.WriteLine("--- Starting program ---");
        
        // Normally we process an array from beginning to end 
        // (from the first element to the last element, one at a time)
        //
        // a for-loop will loop through a process counting as it does so
        // a for-loop is an excellent tool for processing an array from start to end 
        
        // standard syntax: for(i=0, i < arrayName.Length; i++)
        //
        // arrayName.Length represnets the number of elements in the array

        //    index     loop as 
        //    start     long as the index         increment the 
        //    at 0      is not outside array      index for each loop
        for (int i = 0; i < numbers.Length;        i++) // i = 0, 1, 2 inside loop and 3 when it exits the loop
        {
            Console.WriteLine("Please enter a number:  "); // Asking for the number
            numbers[i] = int.Parse(Console.ReadLine());    // get a string from keyboard
        }                                                  // convert it to an int
                                                           // store it in number[i] 

                                                           
                                                           
        // Verify the array received the numbers correctly
        // Go through the array one element at a time and display the element
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Element #"+ i + " is: " + numbers[i]);
            sum += numbers[i]; // add the current numbers in the array to sum
        }

        // Add the numbers together create a sum/total
        // sum = number1 + number2 + number3;
       
        // Tell the requester the sum/total (display)
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average : " + (double)sum / numbers.Length);
        
        // sum / number.length
        // int / int ---> integer arithmetic - divide gives two parts quotient and remainder
        //    int                                   7 / 3 - quotient = 2 remainder = 1
        
        // (double) sum / numbers.Length
        // convert sum
        // to double  / int  ----> floating point arithmetic 
        //      double (2.333333)

        Console.WriteLine("--- Ending program ---");
    }
}