using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GlacierCrash : Card
{
    public override string cardName { get { return "Glacier Crash"; } }

    public override int baseCost { get { return 4; } }

    public override string cardDescription { get { return "Attack an active enemy Hellion for 4 damage. The owner of that Hellion cannot willingly swap their active Hellion during their next turn."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Water; } }

    public override Target validTarget { get { return Target.ActiveEnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().physHit(4);
        //make so opponent cant swap hellion
    }

}