using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class is just an enum to reference the different Card Types
public class CardType : MonoBehaviour
{
    public enum Type
    {
        Attack,
        Action,
        Status,
        Terrain,
        Reaction
    }
}
