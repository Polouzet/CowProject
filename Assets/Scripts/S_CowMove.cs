using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class S_CowMove : S_CowComponent
{
    Rigidbody2D rb;
    SpriteRenderer sprite;
    public Animator animator;

    public float speed;
    public float followDistance;
    private bool inMovement = false;

    public GameObject target;
    public GameObject targetToAttack;

    public GameObject player;
    public S_MouseClickEvent mouse;
    public S_CowCapture cowCapute;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cowCapute = GetComponentInChildren<S_CowCapture>();
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        if (target == null)
        {
            target = player;
        }


        if (inMovement)
        {
            animator.SetBool("Walking", true);
        }
        if (inMovement == false)
        {
            animator.SetBool("Walking", false);
        }


        if (Vector2.Distance(transform.position, target.transform.position) > followDistance && cowCapute.captured)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
            inMovement = true;
        }
        else
        {
            inMovement = false;
        }

        if (cowCapute.canCapture && Input.GetKeyDown(KeyCode.E))
        {
            cowCapute.captured = true;
            gameObject.tag = "Player";
        }
    }


    void ChangeTarget()
    {
        if (targetToAttack != null)
        {
            target = targetToAttack;
        }
    }
}
