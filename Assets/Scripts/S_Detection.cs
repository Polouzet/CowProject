using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class S_Detection : MonoBehaviour
{
    public bool inRange = false;
    [HideInInspector] public List<S_Stats> targets;
        public List<GameObject> vavaches = new List<GameObject>();
    public GameObject targetToAttack;

    void Start()
    {
        targets = new List<S_Stats>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (!targets.Contains(collision.gameObject.GetComponent<S_Stats>()))
            {
            inRange = true;
            vavaches.Add(collision.gameObject);
            targets.Add(collision.gameObject.GetComponent<S_Stats>());  
            }
            targetToAttack = collision.gameObject;
        }
    }
    
}
