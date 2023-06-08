using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PurifyingRay : Card
{
    public override string cardName { get { return "Purifying Ray"; } }

    public override int baseCost { get { return 1; } }

    public override string cardDescription { get { return "Remove up to one Status from any Hellion. That Hellion recovers 2 HP."; } }

    public override CardType type { get { return CardType.Action; } }

    public override Element element { get { return Element.Light; } }

    public override Target validTarget { get { return Target.YourHellion; } }

    override public void OnPlay(GameObject target)
    {
        //remove status
        target.GetComponent<Hellion>().addHp(2);
    }

}