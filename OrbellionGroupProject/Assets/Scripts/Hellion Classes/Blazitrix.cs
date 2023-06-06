using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blazitrix : Hellion
{
    public override string hellName { get { return "Blazitrix"; } }

    public override Element element { get { return Element.Fire; } }

    public override int baseHp { get { return 22; } }

    public override int physDef { get { return -1; } }

    public override int elemDef { get { return 0; } }

    public override string passiveAbility { get { return "If this Hellion would be defeated, you may discard 3 \"Ash\" cards, If you do, remove all Status cards from this Hellion, its HP becomes 3, and it gains 10 block."; } }

    public override string activeAbility { get { return "Active: Whenever an enemy Hellion takes Elemental damage from a Fire source you own, create an \"Ash\" Special card"; } }
}
