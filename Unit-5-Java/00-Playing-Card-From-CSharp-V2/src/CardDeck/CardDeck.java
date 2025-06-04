//namespace Playing_Card_Poker_Game;
package CardDeck; // Packname must match the folder name containing package components
// In Java you must import any class you use that is in a different package
// C# you must code a using for any class you use that is in a different namespace
import PlayingCard.PlayingCard;

import java.util.ArrayList;
import java.util.List;

public class CardDeck
{
    /*************************************************************************************************
	 * CardDeck has a set of PLayingCards - "has-a" relationship - define the object in the class
	 ***************************************************************************************************/

	List<PlayingCard> deckOfCards = new ArrayList<PlayingCard>();  // Define a List to hold PlayingCards

	/***************************************************************************************************
	 * Number of non-Joker cards per suit
	 ***************************************************************************************************/
	private final int numberCardsForSuit = 13;

	/***************************************************************************************************
	 * Default Constructor
	 ***************************************************************************************************/

	public CardDeck()
	{
		resetDeck(true); // create deck with Jokers
	}

	/***************************************************************************************************
	 * Display cards in deck
	 ***************************************************************************************************/

	public void showDeck() {
		System.out.println("Number of Cards in Deck: " + deckOfCards.Count);
		// C#: foreach (PlayingCard aCard in deckOfCards)
		// Java: for(datatype variable : CollectionClassObject)
		for(PlayingCard aCard : deckOfCards)
		{
			aCard.ShowCardWithHash();
		}
	}
	/***************************************************************************************************
	 * Answer question are they any cards in the deck
	 ***************************************************************************************************/

	public boolean anyCardsInDeck() {
		if (deckOfCards.Count > 0)
		{
			return true;
		}
		else
		{
			return false;
		}
	}

	/***************************************************************************************************
	 * Deal a card from the top of the deck
	 ***************************************************************************************************/
	public PlayingCard dealCard() {
		if (deckOfCards.size() > 0) // C# uses .Count(), Java uses .size()
		{
			// Simulate queue behavior (remove from head)
			PlayingCard cardToDeal = deckOfCards[0];
			deckOfCards.RemoveAt(0);
			return cardToDeal;
		}
		else
		{
			 return null;
		}
	}
	/***************************************************************************************************
	 * Create a deck with or without Jokers
	 ***************************************************************************************************/
	public void resetDeck(boolean withJoker) {
		deckOfCards.Clear();              // Remove any existing cards from the deck

		for (int i = 1; i <= numberCardsForSuit; i++)
		{    // Generate a set of clubs
			deckOfCards.Add(new PlayingCard(i, PlayingCard.CardSuit.Club));
		}
		for (int i = 1; i <= numberCardsForSuit; i++)
		{    // Generate a set of hearts
			deckOfCards.Add(new PlayingCard(i, PlayingCard.CardSuit.Heart));
		}
		for (int i = 1; i <= numberCardsForSuit; i++)
		{    // Generate a set of spades
			deckOfCards.Add(new PlayingCard(i, PlayingCard.CardSuit.Spade));
		}
		for (int i = 1; i <= numberCardsForSuit; i++)
		{     // Generate a set of diamonds
			deckOfCards.Add(new PlayingCard(i, PlayingCard.CardSuit.Diamond));
		}

		if (withJoker)
		{  // If Jokers requested, add them
			deckOfCards.Add(new PlayingCard(PlayingCard.CardValue.Joker, PlayingCard.CardSuit.Joker));
			deckOfCards.Add(new PlayingCard(PlayingCard.CardValue.Joker, PlayingCard.CardSuit.Joker));
		}
	}
	/***************************************************************************************************
	 * Create New Deck with Shuffled Cards
	 ***************************************************************************************************/
	public void shuffleDeck() {
		resetDeck(false);                  // Reload deck without Jokers
		// Use a standard Fisher-Yates shuffle algorithim 
		//
		// 1. Start with position of last item in a List or Array
		// 2. Loop thru the entire List or Array backwards
		// 3. Adjust current position to previous item in List or Array
		// 4. Generate a random position number
		// 5. Remember item in random position 
		// 6. Assign item in current position to random position
		// 7. Assign item in current position the remember card from random position
		
		// Instantiate Random object to generate random card positions
		// 
		// To generate a Random value: .Next(largest-value-desired + 1)
		Random randomNumberGenerator = new Random();
		
		int currentCardPosition = deckOfCards.size();
		while (currentCardPosition > 1) {
			currentCardPosition--;
			int randomCardPosition = randomNumberGenerator.nextInt(currentCardPosition + 1);
			PlayingCard holdCard = deckOfCards[randomCardPosition];
			deckOfCards[randomCardPosition] = deckOfCards[currentCardPosition];
			deckOfCards[currentCardPosition] = holdCard;
		}
	}

	/***************************************************************************************************
	 * Remove any Jokers from a Deck
	 ***************************************************************************************************/
	public int removeJokers() {
		int numCardsBefore = deckOfCards.Count;                       // Remember # cards before removal
		// Use RemoveAll with a predicate to remove cards matching the Joker criteria
		// This is the C# equivalent of C#'s removeAll(Collection) when the collection
		// contains the items to be removed.
		int numRemoved = deckOfCards.RemoveAll(card => card.Value == PlayingCard.CardValue.Joker && card.Suit == PlayingCard.CardSuit.Joker);
		// The C# code calculates removed count differently, but the result is the same
		// if RemoveAll returns the count, or by comparing sizes before and after.
		// Let's return the difference in size to match the C# logic exactly.
		return numCardsBefore - deckOfCards.Count;                    // Return # of Jokers removed
	}
}