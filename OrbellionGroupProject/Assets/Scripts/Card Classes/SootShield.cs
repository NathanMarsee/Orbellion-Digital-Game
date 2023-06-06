using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SootShield : Card
{
    public override string cardName { get { return "Soot Shield"; } }

    public override int baseCost { get { return 1; } }

    public override string cardDescription { get { return "Play when an opponent plays an Attack card. You may discard any number of cards to gain that much block."; } }

    public override CardType type { get { return CardType.Reaction; } }

    public override Element element { get { return Element.Fire; } }

    public override Target validTarge { get { return Target.YourHellion; } }

    override public void OnPlay(GameObject target)
    {
        int i = 0;
        while (i != 0) //change
        {
            //discard
            i++;
        }
        target.GetComponent<Hellion>().addBlock(i);
    }

}