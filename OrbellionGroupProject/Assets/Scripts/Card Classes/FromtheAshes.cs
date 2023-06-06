using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FromtheAshes : Card
{
    public override string cardName { get { return "From the Ashes"; } }

    public override int baseCost { get { return 1; } }

    public override string cardDescription { get { return "Discard any number of \"Ash\" cards. Draw a card for each card you discarded this way. If that number was 3 or more, gain 2 Energy."; } }

    public override CardType type { get { return CardType.Action; } }

    public override Element element { get { return Element.Fire; } }

    public override Target validTarget { get { return Target.You; } }

    override public void OnPlay(GameObject target)
    {
        //discard
        //int i = 0;
        //if(i >= 3)
            //add 2 energy
    }

}