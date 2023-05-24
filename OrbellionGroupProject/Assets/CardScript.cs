using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Playable Card", menuName = "Playable Card")]
public class CardScript : ScriptableObject{

    public new string name;
    public string description;
    public string type;

    public int energyCost;
    public int attack;
    

    public void Print()
    {
        Debug.Log(name + ": " + description + " The card costs: " + energyCost);
    }
}
