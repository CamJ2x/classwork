namespace Day_1_Student_Class_Example;

// internal attribute was removed so we can use the class anywhere
// public - anyone can is this class
// class - this is the definition of a C# class
// Student - name of the class - Classname are in PascalCase

// A class is a description of an object used in object oriented programming 
// A class contains data (class member/class data and methods (class methods)
// A class is a programmer defined data type ( much like int, string, double, List <>)
// Because it is a PROGRAMMER defined data type, the programmer is responsible for:
//
//      the data in the class
//      the methods that manipulate the class data
//
// class can do whatever a programmer decides it should or shouldn't do
public class Student
{
    //Define the datat for out class
    // private indicates only members of the class can access the data
    // private implements the object-oriented principle of Encapsulation
    // Encapsulation - class should protect the data from outside access
    //                 only methods in the class can access the data
    //
    //                 Users of the class access the data using methods
    //                 defined in the class
    
    // Note: the data is defined without an initial value 
    //       Class data should be intialized in constructors
    private string    studnetName;
    private List<int> testScores;
    
    // Define methods for the class
    
    // One special methods for a class is called a constructor
    // A constructor is responsible for intializing the data in a class\
    // (data should never be unintialized - the starting value needs to be known)
    
    // a constructor is special because:
    //
    // it has no return type; not even void
    // it has the same name as the Class 
    // it may or may not receive parameters (intializers)
    //      (a constructers with no parameters is called a default construcor)
    // usually public
    
    
    // Define a constructor to intialize our data with values 
    //          specified  by the user

    public Student(string name, List<int> scores)
    {
        studnetName = name;  // Set the class data to the data passed in from the user 
        testScores = scores; // Set the class data to the data passed in from the user 

        foreach (int score in testScores)
        {
            Console.WriteLine(score);
        }
    }


}