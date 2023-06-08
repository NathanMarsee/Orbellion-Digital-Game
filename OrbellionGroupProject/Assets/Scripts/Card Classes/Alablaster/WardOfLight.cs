using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WardOfLight : Card
{
    public override string cardName { get { return "Ward of Light"; } }

    public override int baseCost { get { return 3; } }

    public override string cardDescription { get { return "Play when an opponent plays an Attack card. One of your hellions gains 4 block."; } }

    public override CardType type { get { return CardType.Reaction; } }

    public override Element element { get { return Element.Light; } }

    public override Target validTarget { get { return Target.YourHellion; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().addBlock(4);
    }

}