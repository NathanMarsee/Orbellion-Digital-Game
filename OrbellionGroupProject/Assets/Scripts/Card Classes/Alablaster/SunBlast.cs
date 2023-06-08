using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SunBlast : Card
{
    public override string cardName { get { return "Sun Blast"; } }

    public override int baseCost { get { return 6; } }

    public override string cardDescription { get { return "Hit an active enemy Hellion for 5* Elemental damage. This hit does 1 additional damage for each Status on your active Hellion."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Light; } }

    public override Target validTarget { get { return Target.ActiveEnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        int numActHellStat = 0;
        //count number of status cards on active hellion
        target.GetComponent<Hellion>().elemHit(5 + numActHellStat);
    }

}