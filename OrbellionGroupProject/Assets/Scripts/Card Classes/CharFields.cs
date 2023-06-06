using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharFields : Card
{
    public override string cardName { get { return "Char Fields"; } }

    public override int baseCost { get { return 4; } }

    public override string cardDescription { get { return "Whenever a card's effect would cause you to discard one or more cards, hit an active enemy Hellion for 2 Physical damage."; } }

    public override CardType type { get { return CardType.Terrain; } }

    public override Element element { get { return Element.Fire; } }

    public override Target validTarge { get { return Target.None; } }

    override public void OnPlay(GameObject target)
    {
        //implement
    }

}