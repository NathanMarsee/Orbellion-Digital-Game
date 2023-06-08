using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScorchTheEarth : Card
{
    public override string cardName { get { return "Scorch the Earth"; } }

    public override int baseCost { get { return 6; } }

    public override string cardDescription { get { return "Cards you play this turn cost 4 less. Whenever you play another card this turn, each of your hellions lose 1 HP."; } }

    public override CardType type { get { return CardType.Action; } }

    public override Element element { get { return Element.Fire; } }

    public override Target validTarget { get { return Target.EachOfYourHellions; } }

    override public void OnPlay(GameObject target)
    {
        // implement
    }

}