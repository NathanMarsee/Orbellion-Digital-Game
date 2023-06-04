using System;
using UnityEngine;

public class Hellion : MonoBehaviour
{
    string hellName;
    Element.Elem element;
    int hp;
    int physDef;
    int elemDef;
    bool defeated;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void physHit()
    {

    }

    public void ElemHit()
    {

    }

    public void LoseHP()
    {

    }

    public bool isDefeated()
    {
        return defeated;
    }

    public void onDamage()
    {
        onHPLoss();
    }

    public void onHPLoss()
    {
        if (hp < 0)
        {
            hp = 0;
            defeated = true;
        }
    }
}
