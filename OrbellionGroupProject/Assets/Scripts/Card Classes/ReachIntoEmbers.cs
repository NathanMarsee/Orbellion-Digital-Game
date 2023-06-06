using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ReachIntoEmbers : Card
{
    public override string cardName { get { return "Reach Into Embers"; } }

    public override int baseCost { get { return 2; } }

    public override string cardDescription { get { return "Draw 2 cards, then discard a card. Your active Hellion loses 1 HP."; } }

    public override CardType type { get { return CardType.Action; } }

    public override Element element { get { return Element.Fire; } }

    public override Target validTarge { get { return Target.Player; } }


    override public void OnPlay(GameObject target)
    {
        owner.draw();
        owner.draw();
        owner.discard();
        owner.team.getActive().loseHP(2);
    }

}
