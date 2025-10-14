using UnityEngine;

public class S_MovementCow : S_CowComponent
{
    Rigidbody2D rb;
    public Animator animator;

    public float followDistance;
    private bool inMovement = false;

   protected override void Start()
    {
        base.Start();

        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (parent.target != null)
        {
            if (Vector2.Distance(transform.position, parent.target.transform.position) > followDistance)
            {
                rb.transform.position = Vector2.MoveTowards(transform.position, parent.target.transform.position,parent.Stats.speed * Time.deltaTime);
                inMovement = true;
            }
            else
            {
                inMovement = false;
            }

            if (inMovement)
            {
                animator.SetBool("Walking", true);
            }
            if (inMovement == false)
            {
                animator.SetBool("Walking", false);
            }
            else return;

        }

    }


}
