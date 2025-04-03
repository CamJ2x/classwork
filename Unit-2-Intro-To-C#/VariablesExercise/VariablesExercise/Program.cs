namespace VariablesExercise;

class EchoString
{
    static void Main(string[] args)
    {
        Console.Write("Pick either true or false:"); // Prompts the user to enter text
        string input = Console.ReadLine(); // Store what the user says in the input variable 
        Console.WriteLine(input);   // Spits back out what the user says
        
    }
}