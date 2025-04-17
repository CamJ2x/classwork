namespace BasicStringProcessing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence: ");
        var userResponse = Console.ReadLine();
        Console.WriteLine(userResponse.Split(' ', StringSplitOptions.None).First());
        
    }
}