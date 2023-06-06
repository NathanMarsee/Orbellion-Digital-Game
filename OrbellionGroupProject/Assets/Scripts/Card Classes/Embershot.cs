using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Embershot : Card
{
    public override string cardName { get { return "Embershot"; } }

    public override int baseCost { get { return 3; } }

    public override string cardDescription { get { return "Discard a card, then hit an active enemy hellion for 4 Elemental damage."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Fire; } }

    public override Target validTarge { get { return Target.ActiveEnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        owner.discard();
        target.GetComponent<Hellion>().elemHit(4);
    }

}