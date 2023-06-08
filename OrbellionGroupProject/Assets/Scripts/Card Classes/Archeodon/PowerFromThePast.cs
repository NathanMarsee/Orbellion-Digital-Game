using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PowerFromThePast : Card
{
    public override string cardName { get { return "Power from the Past"; } }

    public override int baseCost { get { return 5; } }

    public override string cardDescription { get { return "Hit an active enemy Hellion for 1* Physical damage. This hit does additional damage equal to the highest cost among cards in that Hellion's owner's discard pile."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Earth; } }

    public override Target validTarget { get { return Target.ActiveEnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        int highestDiscardCost = 0;
        //find largest cost from discard pile
        target.GetComponent<Hellion>().physHit(1 + highestDiscardCost);
    }

}