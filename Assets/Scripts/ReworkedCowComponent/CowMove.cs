using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CowMove : S_CowComponent
{
    Rigidbody2D cowRB;

    float horizontal;
    float vertical;

    private bool inMovement = false;
    public float followDistance;

    public Animator animator;
    public S_CowCapture cowCapute;
    protected override void Start()
    {
        base.Start();

        animator = GetComponent<Animator>();
        cowCapute = GetComponentInChildren<S_CowCapture>();
        cowRB = GetComponent<Rigidbody2D>();

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    void Update()
    {
        cowRB.linearVelocity = new Vector2(horizontal * parent.Stats.speed, vertical * parent.Stats.speed);

        if (parent.target == null)
        {
            parent.target = parent.baseTarget;
        }

        if (inMovement)
        {
            animator.SetBool("Walking", true);
        }
        if (inMovement == false)
        {
            animator.SetBool("Walking", false);
        }
        if (parent.target != null)
        {

            if (Vector2.Distance(transform.position, parent.target.transform.position) > followDistance && cowCapute.captured)
            {
                var dir = parent.target.transform;
                cowRB.transform.position = Vector2.MoveTowards(transform.position, parent.target.transform.position, parent.Stats.speed * Time.deltaTime);
                inMovement = true;
            }
            else
                inMovement = false;
        }

    }
}
