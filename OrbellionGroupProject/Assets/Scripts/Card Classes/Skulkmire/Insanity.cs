using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Insanity : Card
{
    public override string cardName { get { return "Insanity"; } }

    public override int baseCost { get { return 5; } }

    public override string cardDescription { get { return "Affected hellion's Physical Defense and Elemental Defense are each reduced by 1. (This can cause Defense to become negative)"; } }

    public override CardType type { get { return CardType.Status; } }

    public override Element element { get { return Element.Dark; } }

    public override Target validTarget { get { return Target.EnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        //lower elemDef and physDef by 1
    }

}