using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rockslide : Card
{
    public override string cardName { get { return "Rockslide"; } }

    public override int baseCost { get { return 5; } }

    public override string cardDescription { get { return "Hit an active enemy Hellion for 4* Physical damage. Then, that Hellion's owner puts the top 6 cards of their deck into their discard pile. For each Attack card that enters their discard pile this way, this attack does 1 additional damage."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Earth; } }

    public override Target validTarget { get { return Target.ActiveEnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        int numOfAttack = 0;
        //discard 6 cards from opponent
        //count num of attack cards discarded
        target.GetComponent<Hellion>().physHit(4 + numOfAttack);
    }

}