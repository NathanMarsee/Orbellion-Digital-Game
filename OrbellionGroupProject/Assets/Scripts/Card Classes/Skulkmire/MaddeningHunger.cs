using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MaddeningHunger : Card
{
    public override string cardName { get { return "Maddening Hunger"; } }

    public override int baseCost { get { return 4; } }

    public override string cardDescription { get { return "Hit an enemy Hellion for 3 Physical damage. That Hellion's owner must discard a card."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Dark; } }

    public override Target validTarget { get { return Target.EnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().physHit(3);
        //opponent discard
    }

}