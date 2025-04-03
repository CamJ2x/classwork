namespace Adding2Floats;

class Program
{
    static void Main(string[] args)
    {
        float number1 = 0;
        float number2 = 0;
        float sum = 0;
        
        
        Console.WriteLine("Enter the number you want to add: ");
        string aLine;
        aLine = Console.ReadLine();
        number1 = float.Parse(aLine);
        
        Console.WriteLine("Enter another number you want to add: ");
        aLine = Console.ReadLine();
        number2 = float.Parse(aLine);
        
        sum = number1 + number2;
        
        
        Console.WriteLine("The total of the two is: " + sum);

    }
}