namespace Adding;

class Program
{
    static void Main(string[] args)
    {
        // Variables need for code
        int number1 = 0;
        int number2 = 1;
        int sum = 0;
        // Ask the user for an input
        Console.WriteLine("Please enter a number that I'll add 1 to: ");
        string aLine; // stores the input from the user
        aLine = Console.ReadLine(); // Gets a line for the input of the user
        number1 = int.Parse(aLine); // Converts the input into an int
        sum = number1 + number2;
        Console.WriteLine("Your total is: " + sum);

    }
}