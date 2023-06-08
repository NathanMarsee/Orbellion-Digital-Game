using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BlindingPower : Card
{
    public override string cardName { get { return "Blinding Power"; } }

    public override int baseCost { get { return 2; } }

    public override string cardDescription { get { return "While affected Hellion is active, each of your hits from Light sources do 1 additional damage."; } }

    public override CardType type { get { return CardType.Status; } }

    public override Element element { get { return Element.Light; } }

    public override Target validTarget { get { return Target.YourHellion; } }

    override public void OnPlay(GameObject target)
    {
        //implement
    }

}