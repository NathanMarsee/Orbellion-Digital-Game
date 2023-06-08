using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SlipBelow : Card
{
    public override string cardName { get { return "Slip Below"; } }

    public override int baseCost { get { return 3; } }

    public override string cardDescription { get { return "Play when an opponent plays a card. If that card's cost is 3 or less, counter that card. Otherwise, draw a card."; } }

    public override CardType type { get { return CardType.Reaction; } }

    public override Element element { get { return Element.Water; } }

    public override Target validTarget { get { return Target.Opponent; } }

    override public void OnPlay(GameObject target)
    {
        //if card cost <= 3, counter it
        //else owner.draw();
    }

}