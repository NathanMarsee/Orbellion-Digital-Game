using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Scraps : Card
{
    public override string cardName { get { return "Scraps"; } }

    public override int baseCost { get { return 2; } }

    public override string cardDescription { get { return "Choose an opponent. That player reveals all cards in their hand, then discards a card of your choice."; } }

    public override CardType type { get { return CardType.Action; } }

    public override Element element { get { return Element.Dark; } }

    public override Target validTarget { get { return Target.Opponent; } }

    override public void OnPlay(GameObject target)
    {
        //reveal opponent cards
        //discard opponent card of player choice
    }

}