using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ConsiderateClobbering : Card
{
    public override string cardName { get { return "Considerate Clobbering"; } }

    public override int baseCost { get { return 7; } }

    public override string cardDescription { get { return "Your opponent chooses one of their Hellions. Hit that Hellion for 8 Physical damage."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Earth; } }

    public override Target validTarge { get { return Target.EnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().physHit(8);
    }

}