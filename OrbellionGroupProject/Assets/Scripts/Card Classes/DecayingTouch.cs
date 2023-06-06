using System.Collections;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DecayingTouch : Card
{
    public override string cardName { get { return "Decaying Touch"; } }

    public override int baseCost { get { return 3; } }

    public override string cardDescription { get { return "Remove all Status cards from an enemy Hellion. Your active Hellion recovers 1 HP for each Status removed this way."; } }

    public override CardType type { get { return CardType.Action; } }

    public override Element element { get { return Element.Dark; } }

    public override Target validTarge { get { return Target.EachOfYourHellions; } }

    override public void OnPlay(GameObject target)
    {
        /*
         * remove status cards
         * for each status removed
         * player active hellion HP +1
         */
    }

}