using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OpportunisticAquisition : Card
{
    public override string cardName { get { return "Opportunistic Aquisition"; } }

    public override int baseCost { get { return 3; } }

    public override string cardDescription { get { return "Play when a card enters a player's discard pile from that player's deck. You may play that card without paying its cost."; } }

    public override CardType type { get { return CardType.Reaction; } }

    public override Element element { get { return Element.Earth; } }

    public override Target validTarget { get { return Target.Opponent; } }

    override public void OnPlay(GameObject target)
    {
        //implement
    }

}