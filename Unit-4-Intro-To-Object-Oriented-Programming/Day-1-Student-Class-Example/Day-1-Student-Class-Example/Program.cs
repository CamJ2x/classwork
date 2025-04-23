namespace Day_1_Student_Class_Example;

class Program
{
    // This is an application program 
    // It instantiates and uses objects to preform processing 
    // Every application has exactly one method called Main()
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Student Class Example");
        
        
    // Instantiates (define) a Student class object 
    // A class is data type 
    // Define an object of a class like any other variable with slight differance 
    
    // data-type name = intializer; int sum = 0;
    
    // A class is instantiated with the new keyword 
    //          is initialzed using one of its constructors 
    // className name = new className(initializer);
    
    List<int> scores = new List<int>();
    scores.Add(100);
    scores.Add(90);
    scores.Add(80);
    
    // Instantiate a Student using the data we want to store in the Student object
    Student aStudent = new Student("Frank", scores);
    
    Console.WriteLine("aStudent" + aStudent);
    
    // Display the Student object 
    Console.WriteLine("aStudent: " + aStudent);
    aStudent.ShowStudent();
    }
}