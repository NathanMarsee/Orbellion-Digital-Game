using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{
    public int id;
    public string cardName;
    public int cost;
    public int physicalPower;
    public int elementalPower;
    public string cardDescription;
    public CardType.Type type;
    public Element.Elem element;

    public Sprite frame;
    public Sprite artwork;

    public Card()
    {

    }

    public Card(int Id, string CardName, int Cost, int PhysicalPower, int ElementalPower, string CardDescription, CardType.Type Type, 
        Element.Elem Element, Sprite Frame, Sprite Artwork)
    {
        id = Id;
        cardName = CardName;
        cost = Cost;
        physicalPower = PhysicalPower;
        elementalPower = ElementalPower;
        cardDescription = CardDescription;
        type = Type;
        element = Element;

        frame = Frame;
        artwork = Artwork;
    }

}
