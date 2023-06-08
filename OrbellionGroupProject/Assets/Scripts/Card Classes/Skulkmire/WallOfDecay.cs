using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WallOfDecay : Card
{
    public override string cardName { get { return "Wall of Decay"; } }

    public override int baseCost { get { return 2; } }

    public override string cardDescription { get { return "Play when an opponent plays an Attack card. One of your Hellions gains 3 block. Then, you may remove a Status or Terrain card."; } }

    public override CardType type { get { return CardType.Reaction; } }

    public override Element element { get { return Element.Dark; } }

    public override Target validTarget { get { return Target.YourHellion; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().addBlock(3);
        //remove status or terrain card
    }

}