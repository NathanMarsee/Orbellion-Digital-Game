using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MudBath : Card
{
    public override string cardName { get { return "Mud Bath"; } }

    public override int baseCost { get { return 3; } }

    public override string cardDescription { get { return "You may put the top 6 cards of your deck into your dicsard pile. For each Earth card that enters your discard pile this way, you may remove a Status card."; } }

    public override CardType type { get { return CardType.Action; } }

    public override Element element { get { return Element.Earth; } }

    public override Target validTarget { get { return Target.Player; } }

    override public void OnPlay(GameObject target)
    {
        for(int i = 0; i < 6; i++)
        {
            owner.discard();
        }
        //count num of earth cards in top 6 of discard pile
        //remove that many status cards
    }

}