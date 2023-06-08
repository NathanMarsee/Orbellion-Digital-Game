using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UnparalleledMight : Card
{
    public override string cardName { get { return "Unparalleled Might"; } }

    public override int baseCost { get { return 4; } }

    public override string cardDescription { get { return "While affected Hellion is active, each of your hits do 1 additional damage."; } }

    public override CardType type { get { return CardType.Status; } }

    public override Element element { get { return Element.Light; } }

    public override Target validTarget { get { return Target.YourHellion; } }

    override public void OnPlay(GameObject target)
    {
        //implement status
    }

}