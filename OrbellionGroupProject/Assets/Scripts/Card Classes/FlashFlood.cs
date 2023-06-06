using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FlashFlood : Card
{
    public override string cardName { get { return "Flash Flood"; } }

    public override int baseCost { get { return 6; } }

    public override string cardDescription { get { return "Swap opponent's active Hellion. Then, hit that active Hellion for 4 Elemental damage."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Water; } }

    public override Target validTarge { get { return Target.ActiveEnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        //swap enemy hellion
        target.GetComponent<Hellion>().elemHit(4);
    }

}