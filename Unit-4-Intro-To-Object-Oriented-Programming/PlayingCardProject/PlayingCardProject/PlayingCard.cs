namespace PlayingCardProject;

public class PlayingCard
{
    /*******************************************************************************
     * Data for the class - Instance Data
     *
     * Instance data means every object has it's own copy of the data
     ******************************************************************************/

    private string suit;
    private string color;
    private int    value;
    
    // Constructor for a PlayingCard - get all the values from the user
    public PlayingCard(string suitName, string theColor, int theValue)
    {
        suit = suitName;
        value = theValue;
        color = theColor;
    }
    // ToString() so we can use a PlayingCard as String
    public string ToString()
    {
        return $"Value: {value} Color: {color} Suit: {suit}";
    }
}