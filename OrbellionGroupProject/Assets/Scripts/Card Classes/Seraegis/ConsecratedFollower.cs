using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ConsecratedFollower : Card
{
    public override string cardName { get { return "Consecrated Follower"; } }

    public override int baseCost { get { return 2; } }

    public override string cardDescription { get { return "Whenever affected Hellion loses HP from a source other than a hit, draw a card."; } }

    public override CardType type { get { return CardType.Status; } }

    public override Element element { get { return Element.Light; } }

    public override Target validTarget { get { return Target.Hellion; } }

    override public void OnPlay(GameObject target)
    {
        //implement status
    }

}