using System;
using UnityEngine;

public class Hellion : MonoBehaviour
{
    string hellName;
    Element.Elem element;
    int hp;
    int physDef;
    int elemDef;
    int block;
    bool defeated;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void physHit(int i)
    {
        if (i > physDef)
        {
            if (block == 0)
                LoseHP(i - physDef);
            else
                LoseBlock(i - physDef);
        }
    }

    public void ElemHit(int i)
    {
        if(i > elemDef)
        {
            if (block == 0)
                LoseHP(i - elemDef);
            else
                LoseBlock(i - elemDef);
        }
    }

    public void LoseHP(int i)
    {
        hp -= i;
        if(hp <= 0 && block == 0)
        {
            hp = 0;
            defeated = true;
        }
            
    }

    public void LoseBlock(int i)
    {
        block -= i;
        if (block < 0)
        {
            int dmg = block * -1;
            block = 0;
            LoseHP(dmg);
        }
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
