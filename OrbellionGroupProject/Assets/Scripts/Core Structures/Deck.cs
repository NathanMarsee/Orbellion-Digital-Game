using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

// A Deck is primarily a list of cards, with the top card represented by index 0 of the list.
public class Deck : MonoBehaviour
{
    public List<Card> cards = new List<Card>();
    public int x;
    public List<Card> container = new List<Card>();

    public GameObject cardInDeck1;
    public GameObject cardInDeck2;
    public GameObject cardInDeck3;
    public GameObject cardInDeck4;
    public GameObject cardInDeck5;

    public GameObject CardBack;
    //public GameObject playerDeck;
    public GameObject[] Clones;

    // Start is called before the first frame update
    void Start()
    {
        /*x = 0;

        for(int i = 0; i < cards.Count; i++)
        {
            x = Random.Range(1,7);
            cards[i] = CardDatabase.cardList[x];
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        if(cards.Count < 9)
        {
            cardInDeck1.SetActive(false);
        }

        if(cards.Count < 7)
        {
            cardInDeck2.SetActive(false);
        }

        if(cards.Count < 5)
        {
            cardInDeck3.SetActive(false);
        }

        if(cards.Count < 3)
        {
            cardInDeck4.SetActive(false);
        }

        if(cards.Count < 1)
        {
            cardInDeck5.SetActive(false);
        }
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(1);
        Clones = GameObject.FindGameObjectsWithTag("Clone");

        foreach(GameObject Clone in Clones)
        {
            Destroy(Clone);
        }
    }

    // FINISHED: find a shuffling algorithm and implement it here
    public void shuffle()
    {
        for(int i = 0; i < cards.Count; i++)
        {
            Card temp = cards[i];
            int randomIndex = Random.Range(i, cards.Count);
            cards[i] = cards[randomIndex];
            cards[randomIndex] = temp;
        }

        Instantiate(CardBack, transform.position, transform.rotation);
        StartCoroutine(Example());

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
