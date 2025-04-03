namespace AddSomeNumbers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---- Start of Program ----");
        // Ask the user for 3 numbers one at a time
        // to produce a sum

        // Do this 3 times
        //      Ask user to enter a number
        //      Get the number from the user
        //      Add the number to the sum

        // Display the sum of the numbers 

        // Data we need:
        //      a place to hold the number entered by the user
        //      a place to hold the sum of the numbers 

        // Define a place to hold the number entered by the user
        int firstEntry = 0;

        // Define a place to hold the sum of the numbers 
        int sum = 0;

        // Loop through our process 3 times
        // If you know the number of times you want to loop
        //      Use a for-loop
        //
        //Syntax of a for loop:
        //                  (1)                         (2a)                            (2b)
        //
        // for(int variable  = initial-value; variable <#-times-to-loop; variable++) {
        // }

        // 1. int variable=initial-value - intializes the variable  (uasally to 0)
        // 2. the condition following hte variable definition is tested:
        //          a. if ture - preform the process between the {} for the for-loop
        //          increment the variable according the last part of the loop
        //          go back to #2
        //          b. if false - exit the loop after the closing brace }

        for (int i = 0; i < 3; i++)
        {


            // Ask the user to enter a number
            Console.WriteLine("Enter First Entry");
            // Get the number they entered
            string theUserResponse = Console.ReadLine(); // Get data from keyboard
            firstEntry = int.Parse(theUserResponse); // Convert data to an int

            //Alternate way to get the umber without using a string variable 
            // firstEntry = int.Parse(Console.ReadLine()); combines multiple statements into one
            //Add the number to the sum

            sum += firstEntry;
        }
        Console.WriteLine(sum);


        Console.WriteLine("---- End of Program ----");
    }
}