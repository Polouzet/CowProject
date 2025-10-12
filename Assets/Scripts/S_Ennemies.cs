using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
public class S_Ennemies : MonoBehaviour
{
    float speed = 2f;
    S_Detection detection;

    public float followDistance;
    public Animator animator;
    bool inMovement = false;

    void Start()
    {
        detection = GetComponentInChildren<S_Detection>();
    }

    void Update()
    {
            if (inMovement)
        {
            animator.SetBool("Walking", true);
        }
        if (inMovement == false)
        {
            animator.SetBool("Walking", false);            
        }
        if (detection.inRange)
        {
            if (Vector2.Distance(transform.position, detection.targetToAttack.transform.position) > followDistance)
            {

                transform.position = Vector2.MoveTowards(transform.position, detection.targetToAttack.transform.position, speed * Time.deltaTime);
                inMovement = true;
            }
            else
            {
                inMovement = false;
            }
        }

    }
}
