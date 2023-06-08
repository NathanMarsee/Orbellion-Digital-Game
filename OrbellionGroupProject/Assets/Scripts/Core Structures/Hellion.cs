using System;
using UnityEngine;

public abstract class Hellion : MonoBehaviour
{
    public abstract string hellName { get; }
    public abstract Element element { get; }
    public abstract int baseHp { get; }
    public int hp;
    public abstract int physDef { get; }
    public abstract int elemDef { get; }
    public abstract string passiveAbility { get; }
    public abstract string activeAbility { get; }
    private int block;

    bool defeated;

    
    void Awake()
    {
        hp = baseHp;
        block = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addBlock(int i)
    {
        block += i;
    }

    public void physHit(int i)
    {
        if (i > physDef)
        {
            if (block == 0)
                loseHP(i - physDef);
            else
                loseBlock(i - physDef);
        }
    }

    public void elemHit(int i)
    {
        if(i > elemDef)
        {
            if (block == 0)
                loseHP(i - elemDef);
            else
                loseBlock(i - elemDef);
        }
    }

    public void loseHP(int i)
    {
        hp -= i;
        onHPLoss();
            
    }

    public void loseBlock(int i)
    {
        block -= i;
        if (block < 0)
        {
            int dmg = block * -1;
            block = 0;
            loseHP(dmg);
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

    public int getHP()
    {
        return hp;
    }

    public int getPhysDef()
    {
        return physDef;
    }

    public void addHp(int i)
    {
        hp += i;
    }

    /*
    public void setPhysDef(int i)
    {
        physDef += i;
    }
    */

    public Element GetElement()
    {
        return element;
    }
}
