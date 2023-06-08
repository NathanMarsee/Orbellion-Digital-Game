using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RadiantInsight : Card
{
    public override string cardName { get { return "Radiant Insight"; } }

    public override int baseCost { get { return 1; } }

    public override string cardDescription { get { return "Whenever you play a Status card this turn, draw a card."; } }

    public override CardType type { get { return CardType.Action; } }

    public override Element element { get { return Element.Light; } }

    public override Target validTarget { get { return Target.Player; } }

    override public void OnPlay(GameObject target)
    {
        //implement
    }

}