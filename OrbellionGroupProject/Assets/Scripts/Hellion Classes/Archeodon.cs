using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archeodon : Hellion
{
    public override string hellName { get { return "Archeodon"; } }

    public override Element element { get { return Element.Earth; } }

    public override int baseHp { get { return 22; } }

    public override int physDef { get { return 1; } }

    public override int elemDef { get { return 1; } }

    public override string passiveAbility { get { return "After you replenish your hand, you may pay 1 Energy to return one of the cards you discarded that way to your hand."; } }

    public override string activeAbility { get { return "Active: Whenever a Hellion takes damage, its owner puts that many cards from the top of their deck into their discard pile."; } }
}