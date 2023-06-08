using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BlessedStrength : Card
{
    public override string cardName { get { return "Blessed Strength"; } }

    public override int baseCost { get { return 3; } }

    public override string cardDescription { get { return "Play only on a Light Hellion. While affected Hellion is active, your first hit on each of your turns does 2 additional damage."; } }

    public override CardType type { get { return CardType.Status; } }

    public override Element element { get { return Element.Light; } }

    public override Target validTarget { get { return Target.YourHellion; } }

    override public void OnPlay(GameObject target)
    {
        /*
        do
        {
            //implement status
        }while(target.GetComponent<Hellion>().GetElement() != Element.Light)
        */
    }

}