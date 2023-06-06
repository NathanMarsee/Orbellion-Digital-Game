using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RedSlash : Card
{
    public override string cardName { get { return "Red Slash"; } }

    public override int baseCost { get { return 3; } }

    public override string cardDescription { get { return "Hit an active enemy hellion for 4 Physical damage."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Fire; } }

    public override Target validTarge { get { return Target.ActiveEnemyHellion; } }


    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().physHit(4);
    }

}
