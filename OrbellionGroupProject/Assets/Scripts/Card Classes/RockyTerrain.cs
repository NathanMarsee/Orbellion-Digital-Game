using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RockyTerrain : Card
{
    public override string cardName { get { return "Rocky Terrain"; } }

    public override int baseCost { get { return 4; } }

    public override string cardDescription { get { return "Every Physical hit does additional damage equal to the Physical Defense of it's owner's active Hellion. Negative Physical Defense does not reduce damage this way."; } }

    public override CardType type { get { return CardType.Terrain; } }

    public override Element element { get { return Element.Earth; } }

    public override Target validTarge { get { return Target.None; } }

    override public void OnPlay(GameObject target)
    {
        //implement
    }

}