using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BiteBack : Card
{
    public override string cardName { get { return "Bite Back"; } }

    public override int baseCost { get { return 2; } }

    public override string cardDescription { get { return "Play when an opponent plays an Attack card. Hit that opponent's active Hellion for 3 Physical damage."; } }

    public override CardType type { get { return CardType.Reaction; } }

    public override Element element { get { return Element.Fire; } }

    public override Target validTarge { get { return Target.ActiveEnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().physHit(4);
    }

}