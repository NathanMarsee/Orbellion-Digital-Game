using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

// A Deck is primarily a list of cards, with the top card represented by index 0 of the list. However, it is also responsible for its own shuffling, 
public class Deck : MonoBehaviour
{
    public List<Card> cards = new List<Card>();
    public int x;
    public int deckSize;
    public List<Card> container = new List<Card>();

    public GameObject cardInDeck1;
    public GameObject cardInDeck2;
    public GameObject cardInDeck3;
    public GameObject cardInDeck4;
    public GameObject cardInDeck5;

    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        deckSize = 10;

        for(int i = 0; i < deckSize; i++)
        {
            x = Random.Range(1,7);
            cards[i] = CardDatabase.cardList[x];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(deckSize < 9)
        {
            cardInDeck1.SetActive(false);
        }

        if(deckSize < 7)
        {
            cardInDeck2.SetActive(false);
        }

        if(deckSize < 5)
        {
            cardInDeck3.SetActive(false);
        }

        if(deckSize < 3)
        {
            cardInDeck4.SetActive(false);
        }

        if(deckSize < 1)
        {
            cardInDeck5.SetActive(false);
        }
    }

    // FINISHED: find a shuffling algorithm and implement it here
    public void shuffle()
    {
        for(int i = 0; i < deckSize; i++)
        {
            container[0] = cards[i];
            int randomIndex = Random.Range(i, deckSize);
            cards[i] = cards[randomIndex];
            cards[randomIndex] = container[0];
        }
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
