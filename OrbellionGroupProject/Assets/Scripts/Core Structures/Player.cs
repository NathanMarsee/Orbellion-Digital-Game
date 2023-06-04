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
        return hand.AddCard(deck.DrawCard());
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
    Card discard()
    {
        Card card = null; //placeholder, implement way to choose which card to discard
        return hand.discard(card);
    }

    // Card to discard is already known
    Card discard(Card card)
    {
        return hand.discard(card);
    }

    void endPhase()
    {

    }

    void quit()
    {

    }
}
