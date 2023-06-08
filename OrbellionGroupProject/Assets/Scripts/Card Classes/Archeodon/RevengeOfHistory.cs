using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RevengeOfHistory : Card
{
    public override string cardName { get { return "Revenge of History"; } }

    public override int baseCost { get { return 7; } }

    public override string cardDescription { get { return "Choose any number of cards from your discard pile with total cost 6 or less. You may play each of them this turn without paying their cost."; } }

    public override CardType type { get { return CardType.Action; } }

    public override Element element { get { return Element.Earth; } }

    public override Target validTarget { get { return Target.Player; } }

    override public void OnPlay(GameObject target)
    {
        //select cards from discard with cost <= 6
        //play those cards from discard pile
    }

}