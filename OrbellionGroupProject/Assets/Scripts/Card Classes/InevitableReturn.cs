using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InevitableReturn : Card
{
    public override string cardName { get { return "Inevitable Return"; } }

    public override int baseCost { get { return 3; } }

    public override string cardDescription { get { return "Choose a card in your discard pile. At the beginning of your next upkeep, return it to your hand."; } }

    public override CardType type { get { return CardType.Action; } }

    public override Element element { get { return Element.Earth; } }

    public override Target validTarge { get { return Target.You; } }

    override public void OnPlay(GameObject target)
    {
        // implement
    }

}