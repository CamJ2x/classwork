namespace StringExamples;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Strings in C# are special data type - they don't work like you think they should
         *
         * String literals are enclosed in " "
         *
         * a literal is something that says what it is: 1 , 1.24. "Bob"
         *
         * string variables sometimes require special processing
         *          you can't use < > to compare strings
         *          Beware : Earl versions of C# do not allow use of == with strings
         *
         * C# provides several methods to operate on strings:
         *
         *          .Equals(string) - compare the string to left of the . to string inside () for equals
         *          .CompareTo(string) -return a number indicating how the first string relats to the second
         *                              return a negative number if first string is less than a the second
         *                              return a zero if first string is equal the second
         *                              return a positive number if first string is greater than the second 
         * 
         */
        
        // if (condition {
        string string1 = "a";
        string string2 = "b";
        if (string1.CompareTo(string2) == 0) // if theses are equals
        {
            Console.WriteLine("string1 is equal string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT equal to string2");
        }
        
        
    }
}