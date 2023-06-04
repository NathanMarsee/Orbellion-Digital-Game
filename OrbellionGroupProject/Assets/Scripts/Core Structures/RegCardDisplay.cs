using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RegCardDisplay : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();
    public int displayId;
    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDescription;
    public CardType.Type type;
    public Element.Elem element;

    public Text nameText;
    public Text costText;
    public Text powerText;
    public Text descriptionText;
    public Text typeText;
    public Text elementText;

    public GameObject hand;
    public int numberOfCardsInDeck;

    void Start()
    {
        numberOfCardsInDeck = Deck.deckSize;
        
        displayCard[0] = CardDatabase.cardList[displayId];
        id = displayCard[0].id;
        cardName = displayCard[0].cardName;
        cost = displayCard[0].cost;
        power = displayCard[0].power;
        cardDescription = displayCard[0].cardDescription;
        type = displayCard[0].type;
        element = displayCard[0].element;

        nameText.text = " " + cardName;
        costText.text = " " + cost;
        powerText.text = " " + power;
        descriptionText.text = " " + cardDescription;
        typeText.text = " " + type;
        elementText.text = " " + element;
    }

    void Update()
    {
        hand = GameObject.Find("PlayerHand");
        /*if(this.transform.parent == hand.transform.parent)
        {
            cardBack = false;
        }

        staticCardBack = cardBack;*///Uncomment this when there is a cardback that I can flip to

        if(this.tag == "Clone")
        {
            displayCard[0] = Deck.staticDeck[numberOfCardsInDeck - 1];
            numberOfCardsInDeck -= 1;
            Deck.deckSize -= 1;
            //cardBack = false;
            this.tag = "Untagged";
        }
        
    }
}
