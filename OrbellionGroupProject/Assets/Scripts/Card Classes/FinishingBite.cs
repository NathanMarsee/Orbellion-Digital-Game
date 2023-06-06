using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FinishingBite : Card
{
    public override string cardName { get { return "Finishing Bite"; } }

    public override int baseCost { get { return 6; } }

    public override string cardDescription { get { return "Hit an active enemy Hellion for 4* Physical damage. For every Status on that Hellion, this hit does an additional 2 damage."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Dark; } }

    public override Target validTarge { get { return Target.ActiveEnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        //modify to account for status cards
        target.GetComponent<Hellion>().physHit(4);
    }

}
