using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card : MonoBehaviour
{
    public abstract string cardName { get; }
    public abstract int baseCost { get; }
    public int cost;
    public abstract string cardDescription { get; }
    public abstract CardType type { get; }
    public abstract Element element { get; }
    public abstract Target validTarge { get; }

    public abstract void OnPlay(GameObject target);

    private void Awake()
    {
        cost = baseCost;
    }


    /*public Card()
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
    }*/



}
