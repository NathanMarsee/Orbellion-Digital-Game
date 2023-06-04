using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

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

    public void shuffle()
    {
        // We need to find a shuffling algorithm and implement it here
    }

    void shuffleWithDiscard()
    {

    }

    void mill()
    {

    }

    // Remove and return the top card from the deck.
    public Card DrawCard()
    {
        if (cards.Count < 0)
        {
            shuffleWithDiscard();
        }
        Card card = cards[0];
        cards.RemoveAt(0);
        return card;

    }

    void consider()
    {

    }

    void search()
    {

    }
}
