using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public List<Card> cards = new List<Card>();

    // Start is called before the first frame update
    public Hand()
    {
        cards = new List<Card>();
    }

    // FINISHED: Card is added to the hand from any source. Returns said card in case it is needed.
    public Card addCard(Card card)
    {
        if (card != null)
        {
            cards.Add(card);
        }
        return card;
    }    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
