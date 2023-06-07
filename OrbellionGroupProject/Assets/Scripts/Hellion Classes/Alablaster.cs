using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alablaster : Hellion
{
    public override string hellName { get { return "Alablaster"; } }

    public override Element element { get { return Element.Light; } }

    public override int baseHp { get { return 25; } }

    public override int physDef { get { return 0; } }

    public override int elemDef { get { return 1; } }

    public override string passiveAbility { get { return "Whenever a Status card is put on a Light Hellion you own, consider 1."; } }

    public override string activeAbility { get { return "Active: For every 2 Status cards on this Hellion, each of your hits do 1 additional damage."; } }
}