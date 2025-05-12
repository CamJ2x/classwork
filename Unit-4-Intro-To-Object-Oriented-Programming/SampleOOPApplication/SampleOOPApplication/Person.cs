namespace SampleOOPApplication;

/*****************************************************************
 * This class will represent a Person
 *
 * A class has data (attributes) and methods (behavior)
 * 
 * Attributes: Name
 *             Height
 *             Weight
 *             Age
 *             Gender
 *             EyeColor
 *             HairColor
 ****************************************************************/

public class Person
{
    private string _name;  //C# coding convenion is private variables start with _
    private double    _height;
    private double    _weight;
    private int       _age;
    private string    _gender;
    private string    _eyeColor;
    private string    _hairColor;

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double Height
    {
        get => _height;
        set => _height = value;
    }

    public double Weight
    {
        get => _weight;
        set => _weight = value;
    }

    public int Age
    {
        get => _age;
        set => _age = value;
    }

    public string Gender
    {
        get => _gender;
        set => _gender = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string EyeColor
    {
        get => _eyeColor;
        set => _eyeColor = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string HairColor
    {
        get => _hairColor;
        set => _hairColor = value ?? throw new ArgumentNullException(nameof(value));
    }
}