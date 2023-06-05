using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Hellion Card", menuName = "Hellion Card")]
public class HellionScript : ScriptableObject
{
    public new string name;
    public string passive;
    public string active;
    public string elementType;

    public int health;
    public int physicalDef;
    public int elementalDef;
    public int block;

    public Sprite artwork;
    public Sprite frame;
}
