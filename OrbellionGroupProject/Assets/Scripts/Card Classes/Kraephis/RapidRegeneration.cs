using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RapidRegeneration : Card
{
    public override string cardName { get { return "Rapid Regeneration"; } }

    public override int baseCost { get { return 3; } }

    public override string cardDescription { get { return "Play when an opponent plays an Attack card. The next time your active Hellion loses HP, it recovers that much HP."; } }

    public override CardType type { get { return CardType.Reaction; } }

    public override Element element { get { return Element.Water; } }

    public override Target validTarget { get { return Target.YourActiveHellion; } }

    override public void OnPlay(GameObject target)
    {
        //implement
    }

}