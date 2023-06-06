using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CripplingToxins : Card
{
    public override string cardName { get { return "Crippling Toxins"; } }

    public override int baseCost { get { return 4; } }

    public override string cardDescription { get { return "Hit an enemy Hellion for 3 Elemental damage. If that Hellion has a \"Poison\" Status, draw a card"; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Dark; } }

    public override Target validTarge { get { return Target.ActiveEnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().elemHit(3);
        //inflict poison
    }

}