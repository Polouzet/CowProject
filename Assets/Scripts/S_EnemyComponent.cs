using System.Collections.Generic;
using UnityEngine;

public class S_EnemyComponent : MonoBehaviour
{
    protected S_Ennemies parent;
    protected S_Stats stats;
    void Start()
    {
        parent = GetComponentInParent<S_Ennemies>();
        stats = GetComponentInParent<S_Stats>();
    }
}