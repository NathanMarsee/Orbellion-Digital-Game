using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ToxicGaze : Card
{
    public override string cardName { get { return "Toxic Gaze"; } }

    public override int baseCost { get { return 3; } }

    public override string cardDescription { get { return "Create a \"Poison\" Special card and put it on any Hellion"; } }

    public override CardType type { get { return CardType.Action; } }

    public override Element element { get { return Element.Dark; } }

    public override Target validTarge { get { return Target.EnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        //inflict poison
    }

}