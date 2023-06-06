using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OutwiththeTide : Card
{
    public override string cardName { get { return "Out with the Tide"; } }

    public override int baseCost { get { return 3; } }

    public override string cardDescription { get { return "Hit an active enemy Hellion for 2 Elemental damage. Then, choose opponent's active Hellion"; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Water; } }

    public override Target validTarge { get { return Target.ActiveEnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().elemHit(2);
        //swap opponent active hellion
    }

}