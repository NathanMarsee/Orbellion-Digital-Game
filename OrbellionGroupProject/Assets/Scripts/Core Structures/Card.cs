using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{
    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDescription;
    public CardType.Type type;
    public Element.Elem element;

    public Card()
    {

    }

    public Card(int Id, string CardName, int Cost, int Power, string CardDescription, CardType.Type Type, 
        Element.Elem Element)
    {
        id = Id;
        cardName = CardName;
        cost = Cost;
        power = Power;
        cardDescription = CardDescription;
        type = Type;
        element = Element;
    }

}
