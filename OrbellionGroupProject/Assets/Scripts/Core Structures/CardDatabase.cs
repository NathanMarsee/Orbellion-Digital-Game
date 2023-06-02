using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        // id, name, cost, physicalPower, elementalPower, description, type, element, frame, artwork
       cardList.Add(new Card(0, "Red Slash", 3, 4, 0, "Hit an active enemy Hellion for 4 Physical damage.", CardType.Type.Attack, Element.Elem.Fire, Resources.Load<Sprite>("fire"), Resources.Load<Sprite>("red_slash")));
       cardList.Add(new Card(1, "Bone Claw", 2, 3, 0, "Hit an active enemy Hellion for 3 Physical damage. Your active Hellion loses 1 HP.", CardType.Type.Attack, Element.Elem.Fire, Resources.Load<Sprite>("fire"), 
           Resources.Load<Sprite>("bone_claw")));
       cardList.Add(new Card(2, "Reach Into Embers", 2, 0, 0, "Draw 2 cards, then discard a card. Your active Hellion loses 2 HP.", CardType.Type.Action, Element.Elem.Fire, Resources.Load<Sprite>("fire"), 
           Resources.Load<Sprite>("reach_into_embers")));
       cardList.Add(new Card(3, "Singe", 2, 0, 0, "At the beginning of opponent's upkeep, affected Hellion loses 1 HP. Opponenet may pay 2 energy to remove this status", CardType.Type.Status, Element.Elem.Fire, 
           Resources.Load<Sprite>("fire"), Resources.Load<Sprite>("singe")));
       cardList.Add(new Card(4, "Burn Off", 4, 4, 0, "Hit an active enemy Hellion for 4 Physical damage. You may remove a Status from your active Hellion.", CardType.Type.Attack, Element.Elem.Fire, 
           Resources.Load<Sprite>("fire"), Resources.Load<Sprite>("burn_off")));
       cardList.Add(new Card(5, "Bite Back", 2, 3, 0, "Play when an opponent plays an Attack card. Hit the opponent's active Hellion for 3 Physical damage.", CardType.Type.Reaction, Element.Elem.Fire, 
           Resources.Load<Sprite>("fire"), Resources.Load<Sprite>("bite_back")));
       cardList.Add(new Card(6, "Scorch the Earth", 6, 0, 0, "Cards you play this turn cost 4 less energy. For each card played this turn, each of your Hellions lose 1 HP.", CardType.Type.Action, 
           Element.Elem.Fire, Resources.Load<Sprite>("fire"), Resources.Load<Sprite>("scorch_the_earth")));
       cardList.Add(new Card(7, "Red Slash", 8, 7, 0, "Hit an active enemy Hellion for 7 Physical damage. This hit does 1 additional damage if your active Hellion has 10 HP or less, 2 additional damage if your active Hellion has 5 HP or less.",
           CardType.Type.Attack, Element.Elem.Fire, Resources.Load<Sprite>("fire"), Resources.Load<Sprite>("flaming_delerium")));
    }
}
