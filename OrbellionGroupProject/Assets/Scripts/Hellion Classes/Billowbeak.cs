using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billowbeak : Hellion
{
    public override string hellName { get { return "Billowbeak"; } }

    public override Element element { get { return Element.Air; } }

    public override int baseHp { get { return 16; } }

    public override int physDef { get { return 0; } }

    public override int elemDef { get { return 0; } }

    public override string passiveAbility { get { return "At the end of each of your turns, you may pay 2 Energy to swap your active Hellion."; } }

    public override string activeAbility { get { return "Active: Whenever this Hellion becomes active, hit an active enemy Hellion of your choice for 1 Physical damage or 1 Elemental damage."; } }
}