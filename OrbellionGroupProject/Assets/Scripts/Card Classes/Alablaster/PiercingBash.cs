using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PiercingBash : Card
{
    public override string cardName { get { return "Piercing Bash"; } }

    public override int baseCost { get { return 3; } }

    public override string cardDescription { get { return "Hit an active enemy Hellion for 2 Physical damage. This damage cannot be reduced and ignores block."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Light; } }

    public override Target validTarget { get { return Target.ActiveEnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().loseHP(2);
    }

}