using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FreezeSolid : Card
{
    public override string cardName { get { return "Freeze Solid"; } }

    public override int baseCost { get { return 4; } }

    public override string cardDescription { get { return "Play when an opponent plays a card. Counter that card."; } }

    public override CardType type { get { return CardType.Reaction; } }

    public override Element element { get { return Element.Water; } }

    public override Target validTarget { get { return Target.EnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        //implement 
    }

}