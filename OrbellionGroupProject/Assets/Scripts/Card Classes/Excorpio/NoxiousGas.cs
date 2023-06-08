using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NoxiousGas : Card
{
    public override string cardName { get { return "Noxious Gas"; } }

    public override int baseCost { get { return 4; } }

    public override string cardDescription { get { return "At the beginning of each player's upkeep, each of their Hellions with a \"Poison\" Status loses 1 HP."; } }

    public override CardType type { get { return CardType.Terrain; } }

    public override Element element { get { return Element.Dark; } }

    public override Target validTarget { get { return Target.Opponent; } }

    override public void OnPlay(GameObject target)
    {
        //implement
    }

}
