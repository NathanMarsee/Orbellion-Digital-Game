using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Meditate : Card
{
    public override string cardName { get { return "Meditate"; } }

    public override int baseCost { get { return 4; } }

    public override string cardDescription { get { return "Choose a player. Your active Hellion recovers HP equal to the number of cards in that player's hand."; } }

    public override CardType type { get { return CardType.Action; } }

    public override Element element { get { return Element.Water; } }

    public override Target validTarget { get { return Target.YourActiveHellion; } }

    override public void OnPlay(GameObject target)
    {
        //select player
        int numCards = 0;
        //count num cards in players hand
        target.GetComponent<Hellion>().addHp(numCards);
    }

}