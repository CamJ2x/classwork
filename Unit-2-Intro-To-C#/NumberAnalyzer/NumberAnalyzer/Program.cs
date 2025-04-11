namespace NumberAnalyzer;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;
        Console.WriteLine("What's your name? ");
        string name = Console.ReadLine();
        
        Console.WriteLine("Enter a number " + name + " :"); // Prompt user to input a number
        string input = Console.ReadLine(); // store that string into an input
        number = int.Parse(input); // turn the input into int

        if (number % 2 == 1 && number < 60) // If the integer entered is odd and less than 60
        {
            Console.WriteLine(name + " your number is odd and less than 60.");
        } else if (number % 2 == 0 && number <= 24) // If the integer entered is even and in the inclusive range of 2 to 24
        {
            Console.WriteLine(name + " your number is even and less than 25.");
        } else if (number % 2 == 0 && number > 25 && number <= 60) // If the integer entered is even and in the inclusive range of 26 to 60
        {
            Console.WriteLine(name + " your number is even and between 26 and 60 inclusive.");
        } else if (number % 2 == 0 && number > 60) // If the integer entered is even and greater than 60
        {
            Console.WriteLine(name + " your number is even and greater than 60.");
        } else if (number % 2 == 1 && number > 60) // If the integer entered is odd and greater than 60
        {
            Console.WriteLine(name + " your number is odd and greater than 60.");
        }
        
        
    }
}