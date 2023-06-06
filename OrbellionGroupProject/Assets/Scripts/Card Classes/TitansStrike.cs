using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TitansStrike : Card
{
    public override string cardName { get { return "Titan\'s Strike"; } }

    public override int baseCost { get { return 6; } }

    public override string cardDescription { get { return "Hit an active enemy Hellion for 4 Physical damage. This hit does additonal damage equal to the Physical Defense of your active Hellion."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Earth; } }

    public override Target validTarge { get { return Target.ActiveEnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        //target.GetComponent<Hellion>().physHit(4 + owner.getActive().getPhysDef());
    }

}
