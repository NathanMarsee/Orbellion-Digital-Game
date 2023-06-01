using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(0, "Fireball", 2, 3, "Shoot a fireball at the enemy", CardType.Type.Attack, Element.Elem.Fire));
        cardList.Add(new Card(1, "Lightning", 3, 4, "Summon a lightning strike on the enemy", CardType.Type.Attack, Element.Elem.Air));
        cardList.Add(new Card(2, "Freeze", 1, 3, "Freeze the enemy", CardType.Type.Attack, Element.Elem.Water));
        cardList.Add(new Card(3, "Heal", 1, 0, "Heal your own Hellion for 2 HP", CardType.Type.Action, Element.Elem.Light));
        cardList.Add(new Card(4, "Swamp", 1, 0, "Change the terrain the a swamp", CardType.Type.Terrain, Element.Elem.Water));
    }
}
