using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Discard : MonoBehaviour
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
