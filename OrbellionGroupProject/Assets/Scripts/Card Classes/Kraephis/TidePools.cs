using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TidePools : Card
{
    public override string cardName { get { return "Tide Pools"; } }

    public override int baseCost { get { return 3; } }

    public override string cardDescription { get { return "At the beginning of your upkeep, affected Hellion recovers 1 HP. Then if that Hellion is at its maximum HP, draw a card."; } }

    public override CardType type { get { return CardType.Status; } }

    public override Element element { get { return Element.Water; } }

    public override Target validTarget { get { return Target.YourHellion; } }

    override public void OnPlay(GameObject target)
    {
        //check if hellion has max health
        target.GetComponent<Hellion>().addHp(1);
        //else
        //owner.draw();
    }

}