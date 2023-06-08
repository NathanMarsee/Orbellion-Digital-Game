using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeakendResolve : Card
{
    public override string cardName { get { return "Weakend Resolve"; } }

    public override int baseCost { get { return 4; } }

    public override string cardDescription { get { return "While affected Hellion is active, each of its owner's hits do 1 less damage."; } }

    public override CardType type { get { return CardType.Status; } }

    public override Element element { get { return Element.Dark; } }

    public override Target validTarget { get { return Target.EnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        //if affected hellion active, damage -1
    }
}