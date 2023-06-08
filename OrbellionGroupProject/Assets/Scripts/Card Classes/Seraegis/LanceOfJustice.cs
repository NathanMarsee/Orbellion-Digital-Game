using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LanceOfJustice : Card
{
    public override string cardName { get { return "Lance of Justice"; } }

    public override int baseCost { get { return 4; } }

    public override string cardDescription { get { return "Hit a Hellion for 4 Physical damage. If that hellion was Earth, Dark or Water, draw a card."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Light; } }

    public override Target validTarget { get { return Target.EnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().physHit(4);
        if(target.GetComponent<Hellion>().GetElement() == Element.Earth || target.GetComponent<Hellion>().GetElement() == Element.Dark || target.GetComponent<Hellion>().GetElement() == Element.Water)
        {
            owner.draw();
        }
    }

}