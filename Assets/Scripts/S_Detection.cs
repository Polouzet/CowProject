using System;
using System.Collections.Generic;
using UnityEngine;

public class S_Detection : S_CowComponent
{
    public bool inRange = false;
    public HashSet<S_CowBase> vavaches = new();
    public GameObject targetToAttack;
    protected override void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        var cowBase = collision.gameObject.GetComponent<S_CowBase>();

        if (cowBase != null)
        {
            if (cowBase == parent)
                return;

            if (cowBase.Stats == null)
            {
                print("PAS DE STATS!!!!!!!!!!!!!!");
                return;
            }
            vavaches.Add(cowBase);
        }

    }
    
}
