namespace StringExamples;

class Program
{
    static void Main(string[] args)
    {
        /***************************************************************************************************
         * Strings in C# are a special data type - they don't work like you think they should
         *
         * String literals are enclosed in " "
         *
         * A literal is something that says what it is:  1 1.24 "Bob"
         *
         * string variables sometimes require special processing
         *        you can't use < > to compare strings
         *        Beware: Early versions of C# do not allow use of == with strings
         *
         * a method () is a program that process data in an object/variable
         *
         * C# provides several methods to operate on strings:
         *
         *     .Equals(string)    - compare the string to left of the . to string inside () for equals
         *     .CompareTo(string) - return a number indicating how the first string relates to the second
         *                          return a negative number if first string is less than the second
         *                          return a zero if first string is equal the second
         *                          return a positive number if first string is greater than the second
         ***************************************************************************************************/
        // if (condition) {
        //    What to do if condition is true
        // }
        // else {
        //    What to do if condition is false
        // }
        string string1 = "a";
        string string2 = "b";
        
        Console.WriteLine("string1 is: " + string1);
        Console.WriteLine("string2 is: " + string2);
        
        if (string1.CompareTo(string2) > 0) // if the first string is greater than second string
        {
            Console.WriteLine("string1 is greater than string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT greater than string2");
        }
        if (string1.CompareTo(string2) < 0) // if the first string is greater than second string
        {
            Console.WriteLine("string1 is less than string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT less than string2");
        }
        if (string1.CompareTo(string2) == 0) // if the first string is equal second string
        {
            Console.WriteLine("string1 is equal string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT equal string2");
        }
        // Some methods that process strings 
        //to see a list of all methods available to an object - just type the objectName.
        // .Length - returns the number of character in a string 
        // .Contains(string) - returns true if the string given is inside the in a string
        // .SubString(start-index, length) - extract characters from the string starting ar the start index
        //                                   for the number characters indicated by the length
        //                                   satrt-index starts at 0 NOT 1
        //                                   whenever you see the position - start counting at 1
        // .StartWith(string) - return true if the string starts with the specified chars (case-sensitive)
        // .EndsWith(string) - return true if the string ends with the specified chars (case-sensitive)
        // .Trim() - remove any leading or tailing spaces 
        
        //string1.T
        
        string sentence = "    I'm the cooler than ice    ";
        Console.WriteLine("There are " + sentence.Length + " characters in the sentence");
        
        bool contains = sentence.Contains("cooler");
        Console.WriteLine("Does sentence contain cooler: " + contains);
        
        Console.WriteLine("Does sentence contain fart : " + sentence.Contains("fart"));

        string nameInSentence = sentence.Substring(8, 6);
        Console.WriteLine("extract this word: " + nameInSentence);
        
        Console.WriteLine("Does the sentence start with I'm? " + sentence.StartsWith("I'm"));
        Console.WriteLine("Does the sentence end with i'm? " + sentence.StartsWith("i'm"));
        Console.WriteLine("Does the sentence end with ice? " + sentence.EndsWith("ice"));
        
        Console.WriteLine("Result when sentence.Trim() is used");
        Console.WriteLine("Does the sentence start with I'm? " + sentence.Trim().StartsWith("I'm"));
        Console.WriteLine("Does the sentence end with i'm? " + sentence.Trim().StartsWith("i'm"));
        Console.WriteLine("Does the sentence end with ice? " + sentence.Trim().EndsWith("ice"));
        
        // When C# sees a statement with chained operations (operations seperated by .)
        // C# Process the statement from left to right, one operation at a time
        // Uses the result of the operation in the next one 
        //
        // sentence.trim().EndsWith("C#")
        //
        // 1. sentence.Trim() - returns a string with the leading and trailing spaces removed 
        // 2. result-from-step-1.EndsWith() -  return true or false depending on if string actually ends with chars
        // 
        
        
        
        

    } // End of Main()
    
}  // End of class Program