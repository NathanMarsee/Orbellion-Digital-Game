using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LocustSwarm : Card
{
    public override string cardName { get { return "Locust Swarm"; } }

    public override int baseCost { get { return 2; } }

    public override string cardDescription { get { return "Hit an active enemy Hellion for 2 Elemental damage. If that Hellion's owner has 3 or fewer cards in hand, you may remove a Status from that Hellion."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Dark; } }

    public override Target validTarget { get { return Target.ActiveEnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().elemHit(2);
        //if opponent has <= 3 cards, may remove status
    }

}