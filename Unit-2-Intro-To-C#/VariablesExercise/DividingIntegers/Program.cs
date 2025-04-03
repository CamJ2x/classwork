namespace DividingIntegers;

class Program
{
    static void Main(string[] args)
    {
        // Variables need for code
        int number1 = 0;
        int number2 = 0;
        int sum = 0;
        // Ask the user for an input
        Console.WriteLine("Please enter a number: ");
        string aLine; // stores the input from the user
        aLine = Console.ReadLine(); // Gets a line for the input of the user
        number1 = int.Parse(aLine); // Converts the input into an int
        
        Console.WriteLine("Please enter a number: ");
        aLine = Console.ReadLine();
        number2 = int.Parse(aLine);
        
        sum = number1 / number2;
        Console.WriteLine("Dividing your two numbers you get: " + sum);
    }
}