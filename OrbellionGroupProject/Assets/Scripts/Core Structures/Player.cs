using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Deck deck;
    public Hand hand;
    public Discard discardPile;
    public Team team;
    public Player opponent;

    public int maxEnergy;
    public int baseEnergy;
    public int currentEnergy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Player draws a card by addind a drawn card from their deck to their hand. Retuns said card in case it is needed
    public Card draw()
    {
        Card card = deck.removeTop();
        if(card == null)
        {
            shuffleWithDiscard();
            card = deck.removeTop();
        }
        return hand.addCard(card);
    }

    public void shuffle()
    {
        deck.shuffle();
    }

    public void shuffleWithDiscard()
    {
        foreach(Card card in discardPile.cards)
        {
            deck.putOnBottom(discardPile.remove(card));
        }
        shuffle();
    }

    void swap(int newActive)
    {
        team.swap(newActive);
    }

    void replenish()
    {
        
    }

    void playCard()
    {

    }

    // Player chooses which card to discard
    public Card discard()
    {
        Card card = null; //placeholder, implement way to choose which card to discard
        return hand.remove(card);
    }

    // Card to discard is already known
    Card discard(Card card)
    {
        return hand.remove(card);
    }

    // ToDo
    public void consider()
    {

    }

    // ToDo
    public Card searchDeck()
    {
        return null;
    }

    // ToDo
    public void viewDiscardPile()
    {
        
    }

    // ToDo 
    public void mill()
    {

    }

    // ToDo
    void nextPhase()
    {

    }

    //ToDo
    void quit()
    {

    }
}
