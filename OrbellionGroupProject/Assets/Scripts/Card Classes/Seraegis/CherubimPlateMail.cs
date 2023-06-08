using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CherubimPlateMail : Card
{
    public override string cardName { get { return "Cherubim Plate Mail"; } }

    public override int baseCost { get { return 4; } }

    public override string cardDescription { get { return "At the beginning of each player's upkeep, affected hellion gains 1 block. If affected Hellion is Light, it gains 2 block instead."; } }

    public override CardType type { get { return CardType.Status; } }

    public override Element element { get { return Element.Light; } }

    public override Target validTarget { get { return Target.Hellion; } }

    override public void OnPlay(GameObject target)
    {
        //implement status
    }

}