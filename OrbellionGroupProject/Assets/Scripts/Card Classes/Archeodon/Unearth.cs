using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Unearth : Card
{
    public override string cardName { get { return "Unearth"; } }

    public override int baseCost { get { return 3; } }

    public override string cardDescription { get { return "Return a card from your discard pile top your hand."; } }

    public override CardType type { get { return CardType.Action; } }

    public override Element element { get { return Element.Earth; } }

    public override Target validTarget { get { return Target.You; } }

    override public void OnPlay(GameObject target)
    {
        //implement
    }

}