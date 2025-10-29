using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class S_Detection : S_CowComponent
{
    public HashSet<S_CowBase> vavaches = new();
    protected override void Start()
    {
        base.Start();
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
            var top = vavaches.OrderByDescending(c => c.Stats.tauntValue).First();
            parent.baseTarget = top.gameObject;
        }

    }
    
}
