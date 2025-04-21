using System;
using System.Collections.Generic;
using System.Net; // Give me access to the systems generic collections stuff

namespace Day_2_Dictionary_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*********************************************************
             * Example use of a Dictionary with array/List value
             *********************************************************/
                
            // Ask the user for a name and a grade
            // Store them in a Dictionary
            
            // Dictionary to hold name (key) and grade (value)
            //         key     value
            //         type    type    name      = new Dictionary<key-type, value>();
            Dictionary<string, double> gradeBook = new Dictionary<string, double>();
            
            // Let add students and grades until the user indicates they are done
            // Loop until the user satifies a condition instead of specific # of times
            // Replace the for-loop with either a while-loop or do-while()
            // Do we want to loop at least one? Yes - do while
            // Is OK to loop 0-times? Yes - while loop
            //
            // In this case we have to ask the user at least once to enter some data
            string userResponse = "";
            do 
            {
                // Ask the user for the student name and grade
                Console.Write("Enter student name: ");
                string studentName = Console.ReadLine(); // Get student name// Ask the user for the student name
                Console.Write("Enter grade: ");
                double grade = Double.Parse(Console.ReadLine()); // Get student grade

                // Add the data to our Dictionary
                // Dictionary[key}     = value;
                gradeBook[studentName] = grade; // gradeBook.Add(studentName, grade) // may cause an exception
                
                Console.WriteLine("Are you done? (y/n) ");
                userResponse = Console.ReadLine().ToLower();
                if (userResponse != "y" || userResponse != "n")
                {
                    Console.WriteLine("Sorry we only accept 'y' or 'n' ");
                } 
            } while (userResponse != "y");
            
            
            // Display the entries in our Dictionary
            // Use a KeyValuePair type to get an entry from teh Dictionary
            foreach (KeyValuePair<string, double> anEntry in gradeBook)
            {
                Console.WriteLine(anEntry.Key + " has a grade of " + anEntry.Value);
            }
            
            Console.WriteLine("Please press enter to end program...");
            Console.Read();
        }
    }
}