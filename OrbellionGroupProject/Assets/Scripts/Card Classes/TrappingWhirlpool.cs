using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TrappingWhirlpool : Card
{
    public override string cardName { get { return "Trapping Whirlpool"; } }

    public override int baseCost { get { return 5; } }

    public override string cardDescription { get { return "Hit all enemy Hellions for 2 Elemental damage. Until your next turn, any time an enemy Hellion becomes active, hit that Hellion for 2 Elemental damage."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Water; } }

    public override Target validTarget { get { return Target.EachEnemyHellions; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().elemHit(2);
        // implement
    }

}