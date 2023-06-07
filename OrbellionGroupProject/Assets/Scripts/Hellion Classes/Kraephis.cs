using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kraephis : Hellion
{
    public override string hellName { get { return "Kraephis"; } }

    public override Element element { get { return Element.Water; } }

    public override int baseHp { get { return 20; } }

    public override int physDef { get { return 0; } }

    public override int elemDef { get { return 1; } }

    public override string passiveAbility { get { return "At the beginning of your upkeep, one of your Hellions recovers 1 HP."; } }

    public override string activeAbility { get { return "Active: At the beginning of your upkeep, you may remove a Status from this Hellion."; } }
}