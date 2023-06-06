using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CrystalShield : Card
{
    public override string cardName { get { return "Crystal Shield"; } }

    public override int baseCost { get { return 3; } }

    public override string cardDescription { get { return "One of your Hellions has +1 Physical Defense until the beginning of your next turn."; } }

    public override CardType type { get { return CardType.Action; } }

    public override Element element { get { return Element.Earth; } }

    public override Target validTarget { get { return Target.YourHellion; } }

    override public void OnPlay(GameObject target)
    {
        //target.GetComponent<Hellion>().setPhysDef(1);
    }

}