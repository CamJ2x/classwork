namespace Boolin;

class Program
{
    static void Main(string[] args)
    {
        bool input = true;
        
        Console.WriteLine("Enter a boolean value: ");
        input = bool.TryParse(Console.ReadLine(), out input); // Turns the user input into a bool and
                                                                         // places it into the input variables 
        Console.WriteLine("The opposite is " + !input); // ! will make the input the opposite 
        
    }
}