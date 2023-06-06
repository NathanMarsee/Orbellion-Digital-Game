using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ProtectingCurrent : Card
{
    public override string cardName { get { return "Protecting Current"; } }

    public override int baseCost { get { return 3; } }

    public override string cardDescription { get { return "Play when an opponent plays an Attack card. You may swap your active Hellion. Then if your active Hellion is Water, it gains 2 block."; } }

    public override CardType type { get { return CardType.Reaction; } }

    public override Element element { get { return Element.Water; } }

    public override Target validTarge { get { return Target.YourActiveHellion; } }

    override public void OnPlay(GameObject target)
    {
        //swap hellion
        if (target.GetComponent<Hellion>().element == Element.Water)
            target.GetComponent<Hellion>().addBlock(2);
    }

}