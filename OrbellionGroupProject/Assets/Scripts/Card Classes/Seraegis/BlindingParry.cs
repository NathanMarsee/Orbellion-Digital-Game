using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BlindingParry : Card
{
    public override string cardName { get { return "Blinding Parry"; } }

    public override int baseCost { get { return 3; } }

    public override string cardDescription { get { return "Play when an opponent plays an Attack card. Counter that card."; } }

    public override CardType type { get { return CardType.Reaction; } }

    public override Element element { get { return Element.Light; } }

    public override Target validTarget { get { return Target.EnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        //implement reaction
    }

}