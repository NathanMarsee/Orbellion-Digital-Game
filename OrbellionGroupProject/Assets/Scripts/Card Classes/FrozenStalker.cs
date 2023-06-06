using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FrozenStalker : Card
{
    public override string cardName { get { return "Frozen Stalker"; } }

    public override int baseCost { get { return 3; } }

    public override string cardDescription { get { return "Whenever a Hellion an opponent owns becomes active, affected Hellion recovers 2 HP."; } }

    public override CardType type { get { return CardType.Status; } }

    public override Element element { get { return Element.Water; } }

    public override Target validTarge { get { return Target.YourHellion; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().addHp(2);
    }

}
