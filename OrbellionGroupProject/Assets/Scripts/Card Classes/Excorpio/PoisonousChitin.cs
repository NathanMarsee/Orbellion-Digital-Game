using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PoisonousChitin : Card
{
    public override string cardName { get { return "Poisonous Chitin"; } }

    public override int baseCost { get { return 2; } }

    public override string cardDescription { get { return "Play when an opponent plays an Attack card. create a \"Poison\" Special card and put it on that player's active helion. If it already had a \"Poison\" Status, one of your Hellions also gains 3 block."; } }

    public override CardType type { get { return CardType.Reaction; } }

    public override Element element { get { return Element.Dark; } }

    public override Target validTarget { get { return Target.ActiveEnemyHellion; } }

    override public void OnPlay(GameObject target)
    {
        /*
         * inflict active enemy hellion with poison
         * if already poisoned
         * addBlock(3) on player hellion
         */ 
    }

}