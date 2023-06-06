using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Warmup : Card
{
    public override string cardName { get { return "Warm-up"; } }

    public override int baseCost { get { return 4; } }

    public override string cardDescription { get { return "Attack an active enemy Hellion for 3 damage. Other Attack cards you play this turn that cause Elemental damage cost 1 less energy."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Fire; } }

    public override Target validTarget { get { return Target.ActiveEnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().elemHit(3);
        //reduce energy cost
    }

}