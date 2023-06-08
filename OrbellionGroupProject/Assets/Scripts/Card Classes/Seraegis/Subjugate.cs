using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Subjugate : Card
{
    public override string cardName { get { return "Subjugate"; } }

    public override int baseCost { get { return 3; } }

    public override string cardDescription { get { return "Hit an active enemy Hellion for 2 Elemental damage. Then, the owner of that Hellion may swap their active Hellion. If they don't, that player cannot draw cards during their next turn."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Light; } }

    public override Target validTarget { get { return Target.ActiveEnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().elemHit(2);
        //implement either swap or disable opponent to draw cards
    }

}