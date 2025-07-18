package ApplicationProgram;

import CardDeck.CardDeck;
import PlayingCard.PlayingCard;

import java.util.*;

public class TestCardDeck {
//
    public static void main(String[] args) {

        System.out.println("Welcome to my Second Java program!");

        // Instantiate a CardDeck
        CardDeck aCardDeck = new CardDeck();

        // Display all the cards in the deck
        aCardDeck.showDeck();

        System.out.println("\n--- Removing Jokers ---");

        aCardDeck.removeJokers();
        aCardDeck.showDeck();

        aCardDeck.shuffleTheDeck();

        PlayingCard aCard = aCardDeck.dealCard();  // remove card and return
        aCard.showCard();

        /*****************************************************************************************
         * dealCard() removes a card from the cardDeck and returns it
         *
         * if one would like to create a discard pile of dealt cards, a decision needs to be made:
         *
         *   1. Do you want the discard pile to have the same behaviors as a CardDeck?
         *   2. Do you want the discard pile to just be a simple pile of cards?
         *****************************************************************************************/

        /*****************************************************************************************
         * Discard pile is to have same behaviors as a CardDeck (use CardDeck methods)
         ****************************************************************************************/
        System.out.println("\n--- Discard Pile as CardDeck ---");

        CardDeck discardCardDeck = new CardDeck();  // Instantiate discard pile as new deck of cards
        discardCardDeck.clearDeck();                // Remove all cards form the deck

        discardCardDeck.addACardToTopOfDeck(aCardDeck.dealCard());  // "bury" top card from the deck
        discardCardDeck.addACardToTopOfDeck(aCard);                 // add an existing card to discard pile
        discardCardDeck.showDeck();                                 // Display dicard pile
        discardCardDeck.shuffleTheDeck();                           // Shuffle the discard pile
        discardCardDeck.addACardToEndofDeck(aCardDeck.dealCard());  // Add a card to bottom of discard file
        discardCardDeck.addACardToDeck(aCardDeck.dealCard());       // Insert card in discard pile
        discardCardDeck.showDeck();                                 // Display cards in discard pile

        /*****************************************************************************************
         * Discard pile to be a simple pile of cards (Cannot use CardDeck methods)
         ****************************************************************************************/
        System.out.println("\n--- Discard Pile as Simple Pile of Cards ---");
        List<PlayingCard> discardPile = new ArrayList<>();// Instantiate Discard pile
        discardPile.addFirst(aCardDeck.dealCard());       // "bury" top card from the deck
        discardPile.add(aCard);                           // add an existing card to discard pile

        for (PlayingCard discardPileCard : discardPile) { // Display discard pile
            System.out.println(discardPileCard);
        }
        Collections.shuffle(discardPile);                // Shuffle the discard pile
        discardPile.addLast(aCardDeck.dealCard());       // Add a card to bottom of discard pile

        // Insert card in discard pile
        Random randomNumberGenerator = new Random();
        discardPile.add(randomNumberGenerator.nextInt(discardPile.size()), aCardDeck.dealCard());

        // Display cards in discard pile
        for(PlayingCard discardPileCard : discardPile) {
            System.out.println(discardPileCard);
        }
        /*************************************************************************
         * Demostrate use of the Java Set class
         *
         * A Set is an ArrayList that will not allow duplicates
         *
         */

        // Define an ArrayList
        List<String> names = new ArrayList<>();

        names.add("Frank");
        names.add("Aaron");
        names.add("Jay");
        names.add("frank");

        // // Display all names in list
        for(String aName : names){
            System.out.println(aName);
        }

        // Define an Set class object
        // A Hashset - store the entries in an unknown sequence (by hashCode)
        //             hashCode is a unique representing the data in the object
        //
        Set<String> nameSet = new HashSet<>();

        names.add("Frank");
        names.add("Aaron");
        names.add("Jay");
        names.add("frank");

        // // Display all names in list
        for(String aName : names){
            System.out.println(aName);
        }



    } // End of main() method
} // End of TestPlayingCard CLass