using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cinderblast : Card
{
    public override string cardName { get { return "Cinderblast"; } }

    public override int baseCost { get { return 6; } }

    public override string cardDescription { get { return "Discard 2 cards, then hit an active enemy hellion for 7 Elemental damage. Create an \"Ash\" Special card"; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Fire; } }

    public override Target validTarge { get { return Target.ActiveEnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().elemHit(7);
        //owner.draw();
    }

}