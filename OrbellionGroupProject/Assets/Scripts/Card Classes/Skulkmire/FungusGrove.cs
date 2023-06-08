using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FungusGrove : Card
{
    public override string cardName { get { return "Fungus Grove"; } }

    public override int baseCost { get { return 5; } }

    public override string cardDescription { get { return "Whenever a player discards one or more cards, each other player may draw a card."; } }

    public override CardType type { get { return CardType.Terrain; } }

    public override Element element { get { return Element.Dark; } }

    public override Target validTarget { get { return Target.None; } }

    override public void OnPlay(GameObject target)
    {
        //if player discards, everyone else draws a card
    }

}