using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FontOfLife : Card
{
    public override string cardName { get { return "Font of Life"; } }

    public override int baseCost { get { return 4; } }

    public override string cardDescription { get { return "At the end of each player's turn, if one or more Hellions they own recovered 3 or more HP this turn, that player draws a card."; } }

    public override CardType type { get { return CardType.Terrain; } }

    public override Element element { get { return Element.Water; } }

    public override Target validTarget { get { return Target.None; } }

    override public void OnPlay(GameObject target)
    {
        //if hp recovered in turn >= 3
        //owner.draw();
    }

}