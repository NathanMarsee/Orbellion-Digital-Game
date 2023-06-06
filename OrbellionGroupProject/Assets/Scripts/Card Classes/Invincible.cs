using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Invincible : Card
{
    public override string cardName { get { return "Invincible"; } }

    public override int baseCost { get { return 4; } }

    public override string cardDescription { get { return "Play when an opponent plays an Attack card. Your active Hellion gains 10 block."; } }

    public override CardType type { get { return CardType.Reaction; } }

    public override Element element { get { return Element.Earth; } }

    public override Target validTarge { get { return Target.YourActiveHellion; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().addBlock(10);
    }

}