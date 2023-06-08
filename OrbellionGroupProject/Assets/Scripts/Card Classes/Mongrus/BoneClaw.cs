using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BoneClaw : Card
{
    public override string cardName { get { return "Bone Claw"; } }

    public override int baseCost { get { return 2; } }

    public override string cardDescription { get { return "Hit an active enemy hellion for 3 Physical damage. Your active Hellion loses 1 HP."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Fire; } }

    public override Target validTarget { get { return Target.ActiveEnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().physHit(3);
        owner.team.getActive().loseHP(1);
    }
}
