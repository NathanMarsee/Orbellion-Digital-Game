using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TalismanOfPower : Card
{
    public override string cardName { get { return "Talisman of Power"; } }

    public override int baseCost { get { return 5; } }

    public override string cardDescription { get { return "While affected Hellion is active, each of your hits do 1 additional damage for every 2 Status cards on affected Hellion."; } }

    public override CardType type { get { return CardType.Status; } }

    public override Element element { get { return Element.Light; } }

    public override Target validTarget { get { return Target.EnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        //implement
    }

}