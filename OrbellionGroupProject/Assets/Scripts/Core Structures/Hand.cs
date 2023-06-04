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

    // Card is added to the hand from any source. Returns said card in case it is needed.
    public Card AddCard(Card card)
    {
        cards.Add(card);
        return card;
    }    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Card discard(Card card)
    {
        return null;
    }
}
