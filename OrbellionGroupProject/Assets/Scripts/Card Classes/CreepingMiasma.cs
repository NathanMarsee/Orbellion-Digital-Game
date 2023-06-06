using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CreepingMiasma : Card
{
    public override string cardName { get { return "Creeping Miasma"; } }

    public override int baseCost { get { return 2; } }

    public override string cardDescription { get { return "Whenever this or another Status is put on affected Hellion, each player other than affected Hellion's owner may consider 2."; } }

    public override CardType type { get { return CardType.Status; } }

    public override Element element { get { return Element.Dark; } }

    public override Target validTarge { get { return Target.EnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        //inflict opponent hellion
        owner.consider();
        owner.consider();
    }

}