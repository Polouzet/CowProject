using System;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class S_CowBase : MonoBehaviour
{
    public S_Stats Stats;

    public virtual void Start()
    {
        Stats = gameObject.GetComponent<S_Stats>();

        print(Stats.ToString());

        if (Stats == null)
        {
            print("!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        }
    }

    public virtual void Update()
    {

    }
  }
