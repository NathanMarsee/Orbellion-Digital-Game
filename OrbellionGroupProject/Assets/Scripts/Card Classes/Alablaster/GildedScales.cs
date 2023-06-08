using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GildedScales : Card
{
    public override string cardName { get { return "Gilded Scales"; } }

    public override int baseCost { get { return 5; } }

    public override string cardDescription { get { return "For every 2 Status cards on affected Hellion, it gets +1 Physical defense."; } }

    public override CardType type { get { return CardType.Status; } }

    public override Element element { get { return Element.Light; } }

    public override Target validTarget { get { return Target.YourHellion; } }

    override public void OnPlay(GameObject target)
    {
        //implement status
    }

}