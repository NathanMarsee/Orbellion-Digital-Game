using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team : MonoBehaviour
{
    public List<Hellion> hellions = new List<Hellion>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Hellion getActive()
    {
        return hellions[0];
    }

    public int getNumAlive()
    {
        int num = 0;
       // foreach(Hellion hellion in hellions)
        for( int i = 0; i < 3; i++)
        {
            if(!hellions[i].isDefeated())
            {
                num++;
            }
        }
        return num;
    }

    public void swap(int i)
    {
        Hellion temp = hellions[i];
        hellions[i] = hellions[0];
        hellions[0] = temp;
    }
}
