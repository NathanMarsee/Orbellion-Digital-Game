using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mongrus : Hellion
{
    public override string hellName { get { return "Mongrus"; } }

    public override Element element { get { return Element.Fire; } }

    public override int baseHp { get { return 20; } }

    public override int physDef { get { return 1; } }

    public override int elemDef { get { return 0; } }

    public override string passiveAbility { get { return "Whenever one of your Hellions loses HP for the third time each turn, you may draw a card."; } }

    public override string activeAbility { get { return "Active: While this Hellion has 10 or less HP, each of your hits do 1 additional damage to enemy Hellions. While this Hellion has 5 or less HP, each of your hits do 2 additional damage to enemy Hellions instead."; } }
}
