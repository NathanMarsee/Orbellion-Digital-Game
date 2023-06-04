using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

// A Deck is primarily a list of cards, with the top card represented by index 0 of the list. However, it is also responsible for its own shuffling, 
public class Deck : MonoBehaviour
{
    public List<Card> cards = new List<Card>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ToDo
    public void shuffle()
    {
        // We need to find a shuffling algorithm and implement it here
    }

    // FINISHED: returns the top card
    public Card getTop() 
    { 
        return cards[0];
    }

    // FINISHED: returns the top i cards
    public List<Card> getTop(int i) 
    { 
        List<Card> list = new List<Card>();
        for(int j = 0; j < cards.Count && j < i; j++)
        {
            list.Add(cards[j]);
        }
        return list;
    }

    // FINISHED: remove the card that is passed in. Returns that card if successful, null if unseccessful
    public Card remove(Card card)
    {
        if (cards.Remove(card))
        {
            return card;
        }
        else
        {
            return null;
        }
    }

    // FINISHED: Remove and return the top card
    public Card removeTop()
    {
        if (cards.Count < 0)
        {
            return null;
        }
        Card card = cards[0];
        cards.RemoveAt(0);
        return card;
    }

    // FINISHED: Remove and return the top i cards
    public List<Card> removeTop(int i)
    {
        List<Card> list = new List<Card>();
        for (int j = 0; j < cards.Count && j < i; j++)
        {
            list.Add(cards[j]);
            cards.RemoveAt(j);
        }
        return list;
    }

    // FINISHED
    public void putOnBottom(Card card)
    {
        if (card != null)
        {
            cards.Add(card);
        }
    }
}
