using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skulkmire : Hellion
{
    public override string hellName { get { return "Skulkmire"; } }

    public override Element element { get { return Element.Dark; } }

    public override int baseHp { get { return 20; } }

    public override int physDef { get { return 0; } }

    public override int elemDef { get { return 1; } }

    public override string passiveAbility { get { return "Whenever an enemy Hellion becomes active, that Hellion loses 1 HP."; } }

    public override string activeAbility { get { return "Active: At the end of your turn, draw a card for each opponent with no cards in hand."; } }
}