using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Deck : MonoBehaviour
{
    List<Card> cards = new List<Card>();

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

    public Card DrawCard()
    {
        // Remove and return the top card from the deck
        if (cards.Count > 0)
        {
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }
        else
        {
            return null;
        }
    }

    void consider()
    {

    }

    void search()
    {

    }
}
