using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OngoingExcavation : Card
{
    public override string cardName { get { return "Ongoing Excavation"; } }

    public override int baseCost { get { return 6; } }

    public override string cardDescription { get { return "Whenever you play an Earth card, you may return another card from your discard pile to your hand."; } }

    public override CardType type { get { return CardType.Terrain; } }

    public override Element element { get { return Element.Earth; } }

    public override Target validTarget { get { return Target.Player; } }

    override public void OnPlay(GameObject target)
    {
        //implement
    }

}