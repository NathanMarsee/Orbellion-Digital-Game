using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iciscale : Hellion
{
    public override string hellName { get { return "Iciscale"; } }

    public override Element element { get { return Element.Water; } }

    public override int baseHp { get { return 25; } }

    public override int physDef { get { return 0; } }

    public override int elemDef { get { return 0; } }

    public override string passiveAbility { get { return "Whenever a player swaps their active Hellion, consider 1."; } }

    public override string activeAbility { get { return "Active: Each of your opponents cannot willingly swap their active Hellion if they did so during their previous turn."; } }
}
