using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EarthenWall : Card
{
    public override string cardName { get { return "Earthen Wall"; } }

    public override int baseCost { get { return 3; } }

    public override string cardDescription { get { return "Play when an opponent plays an Attack card. Each of your hellions gain 3 block."; } }

    public override CardType type { get { return CardType.Reaction; } }

    public override Element element { get { return Element.Earth; } }

    public override Target validTarget { get { return Target.EachOfYourHellions; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().addBlock(3);
    }

}