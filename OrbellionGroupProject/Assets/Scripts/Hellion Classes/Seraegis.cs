using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seraegis : Hellion
{
    public override string hellName { get { return "Seraegis"; } }

    public override Element element { get { return Element.Light; } }

    public override int baseHp { get { return 20; } }

    public override int physDef { get { return 0; } }

    public override int elemDef { get { return 0; } }

    public override string passiveAbility { get { return "Whenever another one of your Hellions dies, you may move any number of Status cards from it onto this Hellion and draw 3 cards."; } }

    public override string activeAbility { get { return "Active: Whenever this Hellion takes damage, you may reduce that damage by 1. If you do, another one of your Hellions lose 1 HP."; } }
}