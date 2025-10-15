using System;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class S_CowBase : MonoBehaviour
{
    public static List<S_CowBase> Cows = new();

    public S_CowAttack attackComponenent;
    public S_MovementCow movementComponent;

    public S_Stats Stats;
    public GameObject target;
    public GameObject baseTarget;

    public virtual void Awake()
    {
        attackComponenent = GetComponent<S_CowAttack>();
        movementComponent = GetComponent<S_MovementCow>();

        Stats = gameObject.GetComponent<S_Stats>();

        Cows.Add(this);

        print(Stats.ToString());

        if (Stats == null)
        {
            print("!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        }
    }

    public virtual void Update()
    {
        if (target == null)
        {
            target = baseTarget;
        }
    }
    public void NewTarget()
    {
        target = baseTarget;
    }

    public virtual void Attack() {}
}
