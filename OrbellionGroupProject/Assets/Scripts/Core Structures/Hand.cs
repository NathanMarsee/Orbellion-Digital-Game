using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    List<Card> cards = new List<Card>();

    // Start is called before the first frame update
    public Hand()
    {
        cards = new List<Card>();
    }

    public void AddCard(Card card)
    {
        cards.Add(card);
    }    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Card discard()
    {
        return null;
    }
}
