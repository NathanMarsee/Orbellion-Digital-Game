using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FlamingDelerium : Card
{
    public override string cardName { get { return "Flaming Delerium"; } }

    public override int baseCost { get { return 8; } }

    public override string cardDescription { get { return "Hit an active enemy Hellion for 7 Physical damage. This hit does 1 additional damage if your active Hellion has 10 or less HP, and another 2 additional damage if it has 5 HP or less."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Fire; } }

    public override Target validTarget { get { return Target.ActiveEnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        if (owner.team.getActive().getHP() <= 10)
        {
            if (owner.team.getActive().getHP() <= 5)
                target.GetComponent<Hellion>().physHit(9);
            else
                target.GetComponent<Hellion>().physHit(8);
        }
        else
            target.GetComponent<Hellion>().physHit(7);
    }

}