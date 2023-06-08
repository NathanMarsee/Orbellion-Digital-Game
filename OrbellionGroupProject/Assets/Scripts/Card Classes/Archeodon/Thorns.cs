using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Thorns : Card
{
    public override string cardName { get { return "Thorns"; } }

    public override int baseCost { get { return 4; } }

    public override string cardDescription { get { return "Hit an active enemy Hellion for 4 damage. Each player puts the top card of their deck into their discard pile."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Earth; } }

    public override Target validTarget { get { return Target.ActiveEnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().physHit(4);
        // each player discards top card
    }

}