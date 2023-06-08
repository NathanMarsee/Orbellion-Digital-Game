using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VenomSting : Card
{
    public override string cardName { get { return "Venom Sting"; } }

    public override int baseCost { get { return 2; } }

    public override string cardDescription { get { return "Hit an active enemy Hellion for 2 Physical damage. If that Hellion lost HP this way, create a \"Poison\" Special card and put it on that Hellion."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Dark; } }

    public override Target validTarget { get { return Target.ActiveEnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().physHit(2);
        //inflict poison
    }

}