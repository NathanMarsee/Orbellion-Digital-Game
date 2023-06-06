using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ConsulttheFlames : Card
{
    public override string cardName { get { return "Consult the Flames"; } }

    public override int baseCost { get { return 2; } }

    public override string cardDescription { get { return "Draw 3 cards, then discard 2 cards"; } }

    public override CardType type { get { return CardType.Action; } }

    public override Element element { get { return Element.Fire; } }

    public override Target validTarget { get { return Target.None; } }

    override public void OnPlay(GameObject target)
    {
        int i = 0;
        while(i < 3)
        {
            owner.draw();
            i++;
        }
        i = 0;
        while(i < 2)
        {
            owner.discard();
        }
     
    }

}