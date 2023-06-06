using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChanneltheInferno : Card
{
    public override string cardName { get { return "Channel the Inferno"; } }

    public override int baseCost { get { return 3; } }

    public override string cardDescription { get { return "Until end of turn, whenever you discarfd a card that isn't \"Ash,\" draw a card."; } }

    public override CardType type { get { return CardType.Action; } }

    public override Element element { get { return Element.Fire; } }

    public override Target validTarge { get { return Target.You; } }

    override public void OnPlay(GameObject target)
    {
        //implement
    }

}