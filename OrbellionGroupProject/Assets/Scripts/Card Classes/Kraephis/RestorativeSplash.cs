using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RestorativeSplash : Card
{
    public override string cardName { get { return "Restorative Splash"; } }

    public override int baseCost { get { return 4; } }

    public override string cardDescription { get { return "Choose a player. Hit that player's active Hellion for 5 Elemental damage. Each of that player's other Hellions recover 1 HP."; } }

    public override CardType type { get { return CardType.Attack; } }

    public override Element element { get { return Element.Water; } }

    public override Target validTarget { get { return Target.ActiveEnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        target.GetComponent<Hellion>().elemHit(5);
        //heal opponents other hellions by 1 HP
    }

}