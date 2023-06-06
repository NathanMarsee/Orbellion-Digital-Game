using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Singe : Card
{
    public override string cardName { get { return "Singe"; } }

    public override int baseCost { get { return 2; } }

    public override string cardDescription { get { return "At the beginning of affected Hellion's owner's upkeep, affected Hellion loses 1 HP. Then, its owner may pay energy to remove this status."; } }

    public override CardType type { get { return CardType.Status; } }

    public override Element element { get { return Element.Fire; } }

    public override Target validTarge { get { return Target.EnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().loseHP(1);
    }

}
