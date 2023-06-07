using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quetzalus : Hellion
{
    public override string hellName { get { return "Quetzalus"; } }

    public override Element element { get { return Element.Air; } }

    public override int baseHp { get { return 18; } }

    public override int physDef { get { return -1; } }

    public override int elemDef { get { return 0; } }

    public override string passiveAbility { get { return "After you replenish your hand, create a \"Fleeting Strike\" Special card."; } }

    public override string activeAbility { get { return "Active: On each of your turns, if you have already played 2 or more cards that turn, each of your hits do 1 additional damage."; } }
}