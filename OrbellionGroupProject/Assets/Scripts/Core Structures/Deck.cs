using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public int x;
    public static int deckSize;
    public List<Card> container = new List<Card>();
    public static List<Card> staticDeck = new List<Card>();

    public GameObject cardInDeck1;
    public GameObject cardInDeck2;
    public GameObject cardInDeck3;
    public GameObject cardInDeck4;
    public GameObject cardInDeck5;

    public GameObject Hand;
    public GameObject[] Clones;
    public GameObject hand;

    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        deckSize = 10;

        for(int i = 0; i < deckSize; i++)
        {
            x = Random.Range(1,4);
            deck[i] = CardDatabase.cardList[x];
        }

        StartCoroutine(StartGame());
    }

    // Update is called once per frame
    void Update()
    {
        staticDeck = deck;

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

    public void Shuffle()
    {
        for(int i = 0; i < deckSize; i++)
        {
            container[0] = deck[i];
            int randomIndex = Random.Range(i, deckSize);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = container[0];
        }
    }

    IEnumerator StartGame()
    {
        for(int i = 0; i <= 6; i++)
        {
            yield return new WaitForSeconds(1);

            Instantiate(Hand, transform.position, transform.rotation);
        }
    }
}
