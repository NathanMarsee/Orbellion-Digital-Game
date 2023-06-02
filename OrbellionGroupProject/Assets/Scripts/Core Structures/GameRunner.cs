using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRunner : MonoBehaviour
{
    public Deck deck;
    private Hand playerHand;
    private Hand opponentHand;

    public void Start()
    {
        // Initialize the deck
        deck = new Deck();
        deck.shuffle();

        // Deal cards to the player and opponent
        playerHand = new Hand();
        opponentHand = new Hand();
        DealCards(5, playerHand);
        DealCards(5, opponentHand);
    }

    private void Update()
    {
        // Left for inputs, Game logic, etc.
    }

    private void DealCards(int numCards, Hand hand)
    {
        for (int i = 0; i < numCards; i++)
        {
            Card card = deck.DrawCard();
            hand.AddCard(card);
        }
    }
}
