using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excorpio : Hellion
{
    public override string hellName { get { return "Excorpio"; } }

    public override Element element { get { return Element.Dark; } }

    public override int baseHp { get { return 22; } }

    public override int physDef { get { return 1; } }

    public override int elemDef { get { return 0; } }

    public override string passiveAbility { get { return "At the beginning of your upkeep, if an opponent\'s Hellions have a \"Poison\" status, draw a card."; } }

    public override string activeAbility { get { return "Active: At the beginning of your upkeep, each Hellion with a \"Poison\" Status loses 1 HP for each Dark Status on it."; } }
}