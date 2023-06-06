using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BurnOff : Card
{
    public override string cardName { get { return "Burn Off"; } }

    public override int baseCost { get { return 4; } }

    public override string cardDescription { get { return "Hit an active enemy Hellion for 4 Physical damage. You may remove a Status from your active Hellion."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Fire; } }

    public override Target validTarge { get { return Target.ActiveEnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().physHit(4);
        //owner.team.getActive()
    }

}