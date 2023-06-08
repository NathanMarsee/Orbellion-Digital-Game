using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Famine : Card
{
    public override string cardName { get { return "Famine"; } }

    public override int baseCost { get { return 7; } }

    public override string cardDescription { get { return "Hit an enemy Hellion for 10* Elemental damage. This hit does 1 less damage for each card in that Hellion's owner's hand. "; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Dark; } }

    public override Target validTarget { get { return Target.EnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        int numOfCards = 0;
        // count num of cards in opponents hand
        target.GetComponent<Hellion>().elemHit(10 - numOfCards);
    }

}