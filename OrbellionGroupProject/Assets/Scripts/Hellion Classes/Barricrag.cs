using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barricrag : Hellion
{
    public override string hellName { get { return "Barricrag"; } }

    public override Element element { get { return Element.Earth; } }

    public override int baseHp { get { return 26; } }

    public override int physDef { get { return 2; } }

    public override int elemDef { get { return 0; } }

    public override string passiveAbility { get { return "Whenever you play a card with cost 6 or more, draw 2 cards then discard a card."; } }

    public override string activeAbility { get { return "Active: Your other Hellions have +2 Physical Defense."; } }
}