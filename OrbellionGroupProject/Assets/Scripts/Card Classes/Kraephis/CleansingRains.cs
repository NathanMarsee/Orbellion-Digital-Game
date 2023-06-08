using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CleansingRains : Card
{
    public override string cardName { get { return "Cleansing Rains"; } }

    public override int baseCost { get { return 2; } }

    public override string cardDescription { get { return "Remove a Status from any Hellion. It recovers 2 HP."; } }

    public override CardType type { get { return CardType.Action; } }

    public override Element element { get { return Element.Water; } }

    public override Target validTarget { get { return Target.YourHellion; } }

    override public void OnPlay(GameObject target)
    {
        //remove status
        target.GetComponent<Hellion>().addHp(2);
    }

}