namespace FirstProgram;

// This program will ask for 3 numbers
//      add them together and display the total

// Programming Solution - Human thinking 
//
// Ask the numbers one at a time
// Write down each number as its given
// Add the numbers together create and sum/total
// Tell the requester the total (display)
//
// 1. A place to write down each number - a variable in a program
// 2. A place  to hold the sum/total -  a variable in a program
// 3. A way to ask for the numbers - a method in a program (object.method())
// 4. A way to receive the numbers - a method in a program (object.method())    
// 5. A way to report the sum/total - a method in a program (object.method())

//  Place the steps in the order we need to solve the program 
//  1. Ask for the numbers one at a time (x3)
//      a. Tell whatever is giving us the numbers to give me the first number
//      b. Receive the first number from sender
//      c. Write down number
//  2. Add the numbers together create a sum/total
//  3. Tell the requester the total of all 3 numbers 

class Program
{
    static void Main(string[] args)
    {   // Commonly used data types in C#:
        // int -  Numeric data that is whole number +/- 2 billion
        // long - A whole number that's greater than +/- 2 billion
        // double - Numeric value with decimal places
        // char - a single alpha-numeric character
        // string - a series of ahpla-numeric characters (words or sentences)
        // bool -  ture or false value for conditions 
        
        // Variable names C# are usually spelled in camelCase
        
        // Define the 
        int number1 = 0;
        int number2 = 0;
        int number3 = 0;
        
        // Define a variable to hold the sum of the numbers 
        int sum = 0;
        
        
        Console.WriteLine("--- Starting program ---");
        
        // Ask for the numbers one at time using the C# Console 
        Console.WriteLine("Please enter a number ");
        string aLine;  // String to hold the line of input from the keyboard
        aLine = Console.ReadLine(); // Get a line from the keyboard
        // We need an int value to store our numbers 
        //Console.ReadLine() only returns string 
        // So we need to covert the string from Console.ReadLine() to an int
        // int.Parse(string) will convert a string to a int 
        number1 = int.Parse(aLine);
        
        
        Console.WriteLine("--- Ending program ----");
    }
}