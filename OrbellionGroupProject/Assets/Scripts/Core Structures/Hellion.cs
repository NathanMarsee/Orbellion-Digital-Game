using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hellion : MonoBehaviour
{
    string hellName;
    Element.Elem element;
    int maxHp;
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

    void defeat()
    {
        hp = 0;
        defeated = true;
    }

    void elemDamage(int amount)
    {
        amount -= elemDef;
        reduceHP(amount);
    }

    void physDamage(int amount)
    {
        amount -= physDef;
        reduceHP(amount);
    }

    void recover(int amount)
    {
        hp += amount;
    }

    void reduceHP(int amount)
    {
        if (amount > 0)
        {
            hp -= amount;
            if (hp <= 0)
            {
                defeat();
            }
        }
    }
}
