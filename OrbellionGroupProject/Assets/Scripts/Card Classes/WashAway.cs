using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WashAway : Card
{
    public override string cardName { get { return "Wash Away"; } }

    public override int baseCost { get { return 3; } }

    public override string cardDescription { get { return "Remove all Status cards from any Hellion"; } }

    public override CardType type { get { return CardType.Action; } }

    public override Element element { get { return Element.Water; } }

    public override Target validTarget { get { return Target.YourHellion; } }

    override public void OnPlay(GameObject target)
    {
        //implement
    }

}
