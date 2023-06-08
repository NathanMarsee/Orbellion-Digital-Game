using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Earthquake : Card
{
    public override string cardName { get { return "Earthquake"; } }

    public override int baseCost { get { return 7; } }

    public override string cardDescription { get { return "Hit all enemy Hellions for 4 Physical damage. You may remove a Terrain or a Status card."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Earth; } }

    public override Target validTarget { get { return Target.EachEnemyHellions; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().physHit(4);
        //remove terrain or status card
    }

}