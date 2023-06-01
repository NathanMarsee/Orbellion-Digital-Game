using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
   public static List<Card> cardList = new List<Card>();

   void Awake(){
    cardList.Add(new Card(0, "None", 0, 0, "None"));
    cardList.Add(new Card(1, "Human", 1, 1, "This is a Human"));
    cardList.Add(new Card(2, "Elf", 2, 2, "This is an Elf"));
    cardList.Add(new Card(3, "Dwarf", 3, 3, "This is a Dwarf"));
    cardList.Add(new Card(4, "Giant", 4, 4, "This is a Giant"));
    cardList.Add(new Card(5, "Troll", 5, 5, "This is a Troll"));
   }
}
