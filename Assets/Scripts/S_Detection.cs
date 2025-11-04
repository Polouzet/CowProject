using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class S_Detection : S_CowComponent
{
    public List<S_CowBase> vavaches = new();
    public S_CowBase collisionCow = null;

    protected override void Start()
    {
        base.Start();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        collisionCow = collision.gameObject.GetComponent<FriendCow>();

        if (collisionCow != null)
        {
            if (collisionCow == parent)
                return;
            if (collisionCow.Stats == null)
            {
                print("PAS DE STATS!!!!!!!!!!!!!!");
                return;
            }
            if (!vavaches.Contains(collisionCow))
            {
                vavaches.Add(collisionCow);

                collisionCow.death += RemoveCow;
            }
        }
    }

    private void RemoveCow(S_CowBase cow)
    {
        vavaches.Remove(cow);
    }
    private void Update()
    {
        NewTarget();
    }
    void NewTarget()
    {
        if (vavaches != null && vavaches.Count >0)
        {
            var top = vavaches.OrderByDescending(c => c.Stats.tauntValue).First();

                print("Vavaches");
                parent.baseTarget = top.gameObject;
            
        }
    }
}
