using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SurveilingLight : Card
{
    public override string cardName { get { return "Surveiling Light"; } }

    public override int baseCost { get { return 1; } }

    public override string cardDescription { get { return "Choose an opponent. That player reveals their hand. Draw a card."; } }

    public override CardType type { get { return CardType.Action; } }

    public override Element element { get { return Element.Light; } }

    public override Target validTarget { get { return Target.Opponent; } }

    override public void OnPlay(GameObject target)
    {
        //reveal hand
        owner.draw();
    }

}