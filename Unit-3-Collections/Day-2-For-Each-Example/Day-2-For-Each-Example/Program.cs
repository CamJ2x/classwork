namespace Day_2_For_Each_Example;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to an Example of a For-Each Loop");
        // Ask the user to enter a sentence
        // (series of words seperated by whitespace - space, tab, something you cant see)
        // Display each word in the sentence

        Console.WriteLine("Please enter a sentence: ");
        string sentence = Console.ReadLine(); // Get what they type and put it into a string 

        // .split() will extract parts of string into an array based on character inside ()
        // string[] splitSentence = sentence.Split(" "); // split the sentence into words 

        List<string> splitSentence = sentence.Split(" ").ToList(); // Convert the array to a list 

        // Display each word in the sentence - arrayName.Length returns the number of elements 
        // for (int i = 0; i < splitSentence.Length; i++) // to process an array use .length to get # of elements 
        for (int i=0; i < splitSentence.Count; i++) // to process a List - use .Count
        {
            // Note: to add 1 to i and us e in the string we have to put it in ()
            //          + for a string means  concatentate
            //          + for a numeric means add
            //          i+1 in the output for WriteLine,
            //          it thinks I want to take the value of i and stick a 1 after it 
            //          (i+1) - () indicate do this first - add 1 to i and then use it in WriteLine output
            Console.WriteLine(splitSentence[i]);
        }

        Console.WriteLine("----- for each loop -----");
        // for-each loop can also process arrays and lists 
        //
        // Syntax: foreach(datatype variable-name in array-or-List)
        //         datatype is the type of data in the array or List
        //         use the variable name inside the foreach loop to access an element in the array
        //
        //
        // Foreach goes through the array or List from start to end assigning each element in the variable 
        //
        // for-loop vs for-each
        //
        // Both can process a  array or List from beginning to end
        // for-loop can start and end at any element by setting int i= and changing the condition
        // for-each AlWAYS processes from the beginning to end 
        // for-loop you know which element you're process by using the value in i 
        // for each you do not know what element number you're processing 


        foreach (string aWord in splitSentence)
        {
            Console.WriteLine(aWord);
        }

        // Display all the words using a do-while loop
        //
        //
        // do 
        // {
        // loop processing 
        // } while 



}
}