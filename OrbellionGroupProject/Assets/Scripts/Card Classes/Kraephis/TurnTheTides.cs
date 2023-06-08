using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TurnTheTides : Card
{
    public override string cardName { get { return "Turn the Tides"; } }

    public override int baseCost { get { return 5; } }

    public override string cardDescription { get { return "Hit an active enemy Hellion for 3* Physical damage. This hit does additional damage equal to the amount of HP your active Hellion has recovered this turn."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Water; } }

    public override Target validTarget { get { return Target.ActiveEnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        int healthRecovered = 0;
        //calculate how much health regenerated this turn on active hellion
        target.GetComponent<Hellion>().physHit(3 + healthRecovered);
    }

}